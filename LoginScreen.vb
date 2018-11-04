Public Class LoginScreen
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close() 'Close login window
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        NavigationPaneTest.Show() 'Open main application window
        'Me.Close()
    End Sub
End Class