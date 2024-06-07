Public Class portalForm
    Private Sub btnPortalexit_Click(sender As Object, e As EventArgs) Handles btnPortalexit.Click
        Me.Close()
    End Sub

    Private Sub btnPortalLogin_Click(sender As Object, e As EventArgs) Handles btnPortalLogin.Click
        loginForm.Show()
        Me.Hide()
    End Sub
End Class