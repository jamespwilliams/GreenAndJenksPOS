Public Class OrderPanelItem

    ' The following code declares a number of properties that each
    ' orderpanelitem will have (to make it easier to access values
    ' from elsewhere in code):

    ' Each will have an ItemName, which is effectively an alias
    ' for ItemNameLabel.Text
    Property ItemName As String
        Get
            Return ItemNameLabel.Text
        End Get
        Set(ByVal value As String)
            ItemNameLabel.Text = value
        End Set
    End Property

    ' Each will have an ItemCount, which is effectively an alias
    ' for ItemNumberLabel.Text, but is represented as an integer
    ' which reduces the need for conversions to strings in other areas
    ' of code
    Property ItemCount As Integer
        Get
            Return CInt(ItemNumberLabel.Text)
        End Get
        Set(ByVal value As Integer)
            ItemNumberLabel.Text = CStr(value)
        End Set
    End Property

    ' Each will have an ItemCount, which is effectively an alias
    ' for SubtotalLabel.Text
    Property SubTotalString As String
        Get
            Return SubtotalLabel.Text
        End Get
        Set(ByVal value As String)
            SubtotalLabel.Text = value
        End Set
    End Property

    ' Also, each OrderPanelItem will have a number of functions that will need to be called
    ' when different events occur on buttons on the component. These functions will be
    ' declared elsewhere in code, so they act as a callback system.
    ' In practice they act as an interface between the Till Form and these components -
    ' the till form needs to be able to react to changes in the order panel items
    ' to update the subtotal etc.
    Dim addButtonFunc As Func(Of OrderPanelItem, Boolean)
    Dim subtractButtonFunc As Func(Of OrderPanelItem, Boolean)
    Dim deleteButtonFunc As Func(Of OrderPanelItem, Boolean)

    ' provide way to set a callback function for when items are added
    Property AddButtonCallback As Func(Of OrderPanelItem, Boolean)
        Get
            Return addButtonFunc
        End Get
        Set(ByVal f As Func(Of OrderPanelItem, Boolean))
            addButtonFunc = f
        End Set
    End Property

    ' provide way to set a callback function for when items are subtracted
    Property SubtractButtonCallback As Func(Of OrderPanelItem, Boolean)
        Get
            Return subtractButtonFunc
        End Get
        Set(ByVal f As Func(Of OrderPanelItem, Boolean))
            subtractButtonFunc = f
        End Set
    End Property

    ' provide way to set a callback function for when items are deleted
    Property DeleteButtonCallback As Func(Of OrderPanelItem, Boolean)
        Get
            Return deleteButtonFunc
        End Get
        Set(ByVal f As Func(Of OrderPanelItem, Boolean))
            deleteButtonFunc = f
        End Set
    End Property

    ' Stores the itemID of the item the OrderPanelItem is representing
    Public itemID

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        ' Call the callback function
        addButtonFunc(Me)
    End Sub

    Private Sub SubtractButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtractButton.Click
        ' Call the callback function
        subtractButtonFunc(Me)
    End Sub

    Sub New(ByVal itemID)
        Me.itemID = itemID
        InitializeComponent()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        ' Call the callback function
        deleteButtonFunc(Me)
    End Sub
End Class
