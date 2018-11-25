Public Class frmSplashScreen
    Private Sub TimerSplashScreen_Tick(sender As Object, e As EventArgs) Handles TimerSplashScreen.Tick

    End Sub

    Private Sub Splashscreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim bitmap As New Bitmap(BookRentalSystem.My.Resources.Resources.Artboard_11)
        Dim back As Color = bitmap.GetPixel(2, 2)
        Me.TransparencyKey = back
        Me.BackgroundImage = bitmap
        Me.Size = bitmap.Size
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub
End Class
