Imports System.Security.Cryptography
Imports System.Configuration
Imports System.Data.Linq
Imports System.Data.Linq.Mapping

''' <summary>
''' GJDatabaseHelper module handles all database input and output for this project
''' </summary>
''' <remarks>
''' To increase performance, tables are read into memory when the system is loaded, then
''' are edited in memory and saved when the system closes, or at set intervals
''' Each table is modelled as an Object. This project relies heavily on Linq, which
''' is .NET's data handling library. By representing the tables as objects, I can
''' use a natural syntax throughout my program. This file contains the class
''' definitions for each table, and provides functions for accessing, editing
''' and deleting the data. It also populates the tables with data when the 
''' program begins.
''' </remarks>

Module GJDatabaseHelper

    ' The GJDatabase class represents the database so that I can use the Linq framework
    ' GJDatabase class is a template for an object to represent the database
    Partial Public Class GJDatabase
        Inherits DataContext

        ' Setting up the objects to represent each table:
        Public Staff As Table(Of StaffMember)
        Public Payroll As Table(Of PayrollMember)
        Public Newsletter As Table(Of Customer)
        Public Items As Table(Of Item)
        Public Stock As Table(Of StockItem)

        ' Constructor for the database object, setting up the connection 
        ' using the passed connection string.
        Public Sub New(ByVal connection As String)
            MyBase.New(connection)
        End Sub
    End Class

    ' Generic class for all table members to inherit from
    Public Class TableMember

    End Class

    ' The following code sets up each separate table. These will act as templates
    ' for table objects in later code.

    <Table(Name:="Staff")> _
    Public Class StaffMember
        Inherits TableMember
        <Column(IsPrimaryKey:=True)> Public StaffID As String
        <Column()> Public FirstName As String
        <Column()> Public LastName As String
        <Column()> Public DOB As Date
        <Column()> Public Address As String
        <Column()> Public Postcode As String
        <Column()> Public Admin As Boolean
        <Column()> Public PayrollID As Guid
        <Column()> Public PasswordHash As Byte()

        ' Override the equality function so I can compare objects in my search function
        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return StaffID = obj.StaffID
        End Function
        ' Public StaffID, FirstName, LastName, DOB, Address, Postcode, Admin, PayrollID, PasswordHash
    End Class

    <Table(Name:="Payroll")> _
    Public Class PayrollMember
        Inherits TableMember
        <Column(IsPrimaryKey:=True)> Public PayrollID As Guid
        <Column()> Public MonthHours As Single
        <Column()> Public HourlyPay As Single
        <Column()> Public GrossPayToDate As Single
        <Column()> Public NetPayToDate As Single
        <Column()> Public TaxPaidToDate As Single
        <Column()> Public NIPaidToDate As Single
        <Column()> Public BankAccountNumber As String
        <Column()> Public SortCode As String

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return PayrollID = obj.PayrollID
        End Function
    End Class

    <Table(Name:="Newsletter")> _
    Public Class Customer
        Inherits TableMember
        <Column(IsPrimaryKey:=True)> Public CustomerID As String
        <Column()> Public Title As String
        <Column()> Public Initial As String
        <Column()> Public Surname As String
        <Column()> Public Address As String
        <Column()> Public Postcode As String

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return CustomerID = obj.CustomerID
        End Function
    End Class

    <Table(Name:="Items")> _
    Public Class Item
        Inherits TableMember
        <Column(IsPrimaryKey:=True)> Public ItemID As String
        <Column()> Public ItemName As String
        <Column()> Public ItemPrice As Single
        <Column()> Public ItemCategory As String
        <Column()> Public ItemSales As Single
        <Column()> Public StockID As String

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return ItemID = obj.ItemID
        End Function
    End Class

    <Table(Name:="Stock")> _
    Public Class StockItem
        Inherits TableMember
        <Column(IsPrimaryKey:=True)> Public StockID As String
        <Column()> Public StockName As String
        <Column()> Public StockLevel As Integer
        <Column()> Public MinStockLevel As Integer

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return StockID = obj.StockID
        End Function
    End Class

    Public connectionString
    Private currentStaffID As String

    ' Arrays to store objects to read data from:
    ' (effectively act as tables, so they are named as such)
    Public staffTable As StaffMember()
    Public payrollTable As PayrollMember()
    Public itemTable As Item()
    Public newsletterTable As Customer()
    Public stockTable As StockItem()

    Sub New()
        ' Retrieve the stored connection string - contains details on the location of the database and login details
        connectionString = ConfigurationManager.ConnectionStrings("GJFinal.My.MySettings.gjdatabaseConnectionString").ConnectionString

        ' initialise the database with the connection string
        Using ctx As GJDatabase = New GJDatabase(connectionString)

            ' Read in the data from each table into the arrays set up earlier:

            staffTable = (From staff In ctx.Staff).ToArray()

            payrollTable = (From payroll In ctx.Payroll).ToArray()

            itemTable = (From item In ctx.Items).ToArray()

            newsletterTable = (From customer In ctx.Newsletter).ToArray()

            stockTable = (From stock In ctx.Stock).ToArray()

        End Using
    End Sub

    ' Searching algorithm:
    ' The condition will be an anonymous function that will be called on each item. If this function returns true
    ' on an item, this item will be added to the list of results
    ' Linear search is used as the data is likely to be unsorted

    ' The condition function will be passed to this function from other places in code.
    ' An example would be:
    ' Function(record)
    '       return record.StaffName = 'James'
    ' End Function
    ' which would mean that only records with a StaffName of James would be returned.
    ' The entire function call would look like this:
    '
    ' Dim records = SearchTable(StaffTable, Function(record)
    '                                           return record.StaffName = 'James'
    '                                       End Function)
    '
    ' This demonstrates how "anonymous functions" are passed, and shows the necessity of 
    ' also passing the table reference, so the correct table can be searched.
    ' By using the TableMember generic type, this function can be called for any of the 
    ' types of records in the database.

    Function SearchTable(ByVal table As TableMember(), ByVal condition As Func(Of TableMember, Boolean))
        ' Initalise the results array
        Dim results(table.Length) As TableMember

        Dim count = 0
        For Each record In table

            ' iterate through each record in the table, and call the passed function on it

            If condition(record) Then

                ' if the passed function returns true, we will return this record, so add it to
                ' the results array
                results(count) = record
                count += 1
            End If
        Next

        ' Trim the results array down to size
        Array.Resize(results, count)
        ' Return the array
        Return results
    End Function

    ' This function can be called to add a new TableMember to one of the tables
    Sub AddToTable(ByVal table As TableMember(), ByVal record As Object)

        ' Resize table array
        Array.Resize(table, table.Length + 1)
        table(table.Length - 1) = record

        ' Save this table back into memory
        SetTable(record, table)
    End Sub

    Sub DeleteFromTable(ByVal t As TableMember(), ByVal record As TableMember)

        Dim table(t.Length - 2) As TableMember
        Dim count = 0
        For Each rec In t
            If Not rec.Equals(record) Then
                table(count) = rec
                count += 1
            End If
        Next

        SetTable(record, table)
    End Sub

    Private Sub SetTable(ByVal record, ByVal table)

        ' Unfortunately the following code requires repeated calls to
        ' ConvertAll to convert between TableMember types and the non-generic
        ' table record types that must be used when storing data back into the arrays

        ' 
        If TypeOf record Is Item Then
            ' If the table is the ItemTable...
            ' Convert every record back into Items (from TableMembers) so that they can be used later
            itemTable = Array.ConvertAll(table, New Converter(Of TableMember, Item)(Function(p As TableMember) As Item
                                                                                        Dim i As Item = p
                                                                                        Return i
                                                                                    End Function))
            ' The rest of the if statements follow the same pattern:
        ElseIf TypeOf record Is StaffMember Then
            staffTable = Array.ConvertAll(table, New Converter(Of TableMember, StaffMember)(Function(p) As StaffMember
                                                                                                Dim i As StaffMember = p
                                                                                                Return i
                                                                                            End Function))
        ElseIf TypeOf record Is Customer Then
            newsletterTable = Array.ConvertAll(table, New Converter(Of TableMember, Customer)(Function(p) As Customer
                                                                                                  Dim i As Customer = p
                                                                                                  Return i
                                                                                              End Function))

        ElseIf TypeOf record Is PayrollMember Then
            payrollTable = Array.ConvertAll(table, New Converter(Of TableMember, PayrollMember)(Function(p) As PayrollMember
                                                                                                    Dim i As PayrollMember = p
                                                                                                    Return i
                                                                                                End Function))

        ElseIf TypeOf record Is StockItem Then
            stockTable = Array.ConvertAll(table, New Converter(Of TableMember, StockItem)(Function(p) As StockItem
                                                                                              Dim i As StockItem = p
                                                                                              Return i
                                                                                          End Function))
        End If
    End Sub

    ' Searching algorithm:
    ' The changeFunction will be an anonymous function that will be called on each item.
    ' The changeFunction function will be passed to this function from other places in code.

    ' An example would be:
    ' Function(record)
    '       record.StaffName = 'James'
    ' End Function
    ' which would set the passed record's StaffName to 'James'
    ' The entire function call would look like this:
    '
    ' EditTableMember(StaffTable, staffRecord, Function(record)
    '                                              record.StaffName = 'James'
    '                                          End Function)
    '
    ' This demonstrates how "anonymous functions" are passed, and shows the necessity of 
    ' also passing the table reference, so the correct table can be searched.
    ' By using the TableMember generic type, this function can be called for any of the 
    ' types of records in the database.
    Sub EditTableMember(ByVal table As TableMember(), ByVal record As TableMember, ByVal changeFunction As Func(Of TableMember, Boolean))

        Dim index = 0
        Dim itemIndex = 0
        ' This For loop searches the table passed for the record passed
        For Each entry In table
            ' Convert to object to compare the two
            Dim e As Object = entry
            Dim r As Object = record

            If e.Equals(r) Then
                ' when the record is found, the index of the record in the table
                ' is noted
                itemIndex = index
            End If
            index += 1
        Next

        ' Call the function to change the item
        changeFunction(table(itemIndex))
    End Sub

    ' This function is called at the end of the program to commit all the changes
    ' to the database
    Sub SubmitChanges()

        Using ctx As GJDatabase = New GJDatabase(connectionString)
            ' Loop through each table array in memory and save to the database
            For Each t In {itemTable, newsletterTable, staffTable, stockTable, payrollTable}
                ' Get the type of the array so that I can refer to it using ctx.GetTable(Type)
                Dim arrayType = t.GetType().GetElementType()

                ' wipe database then resubmit with new data

                Dim table = ctx.GetTable(arrayType)
                ' Using linq to get all records from the table
                Dim tableElements = From record In table
                ' Deleting all of the table elements
                table.DeleteAllOnSubmit(tableElements)

                ' Save changes
                ctx.SubmitChanges()

                ' Reinsert all of the new data
                table.InsertAllOnSubmit(t)

                ' Save changes
                ctx.SubmitChanges()
            Next
        End Using

    End Sub

    Sub SetStaffID(ByVal id)
        currentStaffID = id
    End Sub

    Function GetStaffID() As String
        Return currentStaffID
    End Function
End Module
