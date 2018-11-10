Imports System.Data.OleDb

Public Class frmLoginScreen
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close() 'Close login window
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim ctr, i As Integer
        Dim che As Integer = 0
        Dim emp As String = ""
        ds.Clear()
        'cn.Open()
        str = "select * from Users"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Users")
        ctr = ds.Tables("Users").Rows.Count - 1

        'Check if username and password match database entries
        For i = 0 To ctr
            If ds.Tables("Users").Rows(i)(1).ToString = txtUsername.Text And ds.Tables("Users").Rows(i)(2).ToString = txtPassword.Text Then
                che = 1
                emp = ds.Tables("Users").Rows(i)(3).ToString
            End If
        Next

        'TO DO: Choose what usertype controls are enabled or disabled in program
        If che = 1 Then
            cn.Close()

            If emp = "ADMIN" Then

            ElseIf emp = "TEACHING STAFF" Then
                ' Home.StaffToolStripMenuItem.Visible = False
                ' Home.FeesToolStripMenuItem.Visible = False
                'Home.AccountsToolStripMenuItem.Visible = False
                ' Home.UserToolStripMenuItem.Visible = False
                ' Home.PaymentsToolStripMenuItem.Visible = False
            ElseIf emp = "NON TEACHING STAFF" Then
                ' Home.StudentToolStripMenuItem.Visible = False
                ' Home.ClassToolStripMenuItem.Visible = False
                'Home.StaffToolStripMenuItem.Visible = False
                'Home.ExamToolStripMenuItem.Visible = False
                ' Home.SubjectToolStripMenuItem.Visible = False
                ' Home.UserToolStripMenuItem.Visible = False
            End If

            Dim userTypeText As String = cbUserType.Text

            frmNavigationPaneTest.btnLogout.Text = userTypeText & " - Logout" 'Change button text
            frmNavigationPaneTest.Show() 'Open Application
            Me.Hide() 'Hide login form
            cbUserType.ResetText() 'Clear usetypeComboBox
            txtUsername.Clear() 'Clears Textbox
            txtPassword.Clear() 'Clears Textbox
        Else
            MsgBox(" Incorrect Password ")
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub frmLoginScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub

    Private Sub frmLoginScreen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        cn.Close()
    End Sub

    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Clear() 'Clears Textbox
        txtUsername.Clear() 'Clears Textbox
        cbUserType.Items.Clear() 'Clears User type combobox

        'Database managment and linking
        Dim ctr, i As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        UserAdminModule.conn()
        cn.Open()
        str = "select * from Users"
        'Adding ms access db usertypes to combobox
        cmd = New OleDb.OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Users")
        ctr = ds.Tables("Users").Rows.Count - 1
        For i = 0 To ctr
            cbUserType.Items.Add(ds.Tables("Users").Rows(i)(1).ToString)
        Next
    End Sub

    Private Sub cbUserType_SelectedIndexChanged(sender As Object, e As EventArgs)

        txtUsername.Text = cbUserType.Text '

    End Sub
End Class