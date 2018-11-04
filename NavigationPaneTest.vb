Public Class NavigationPaneTest
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close() 'Close application
        LoginScreen.Show() 'Open login screen
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        tcTabNavContainer.SelectedTab = TabPage1 'Show Rent Tab
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        tcTabNavContainer.SelectedTab = TabPage2 'Show Return Tab

    End Sub

    Private Sub btnPlaceHolder1_Click(sender As Object, e As EventArgs) Handles btnPlaceHolder1.Click
        tcTabNavContainer.SelectedTab = TabPage3 'Show TabPage3

    End Sub
End Class