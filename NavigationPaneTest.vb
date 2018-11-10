Public Class frmNavigationPaneTest
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close() 'Close application
        frmLoginScreen.Show() 'Open login screen
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpReturn 'Show Return Tab
        btnReturn.BackColor = Color.DimGray

    End Sub

    Private Sub btnPlaceHolder1_Click(sender As Object, e As EventArgs) Handles btnPlaceHolder1.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = TabPage3 'Show TabPage3

    End Sub

    Private Sub NavigationPaneTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcTabNavContainer.Visible = False 'Hide tcTabNavContainer when application opens
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()  'Close application
    End Sub

    Private Sub frmNavigationPaneTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Exit Application?", MsgBoxStyle.YesNo) 'Exit confirmation dialog

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            frmLoginScreen.Show() 'Open login dialog
            Me.Hide()

        End If


    End Sub
End Class