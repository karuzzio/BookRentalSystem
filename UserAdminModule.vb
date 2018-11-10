Module UserAdminModule

    Public cn As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String

    Public Sub conn()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\Users\User\OneDrive - Asia Pacific University\Modules\[3] IVP\Assignment\_workfiles\BookRentalSystem\DBFiles\UserAdminModule.accdb"
    End Sub

End Module
