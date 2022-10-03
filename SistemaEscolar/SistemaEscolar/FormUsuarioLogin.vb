Public Class FormUsuarioLogin

    Private Sub BTNprofesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNprofesor.Click
        FormInicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub BTNpreceptor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNpreceptor.Click
        FormInicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub BTNadministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNadministracion.Click
        FormInicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub BTNsalirUsuarioLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalirUsuarioLogin.Click
        End
    End Sub
End Class