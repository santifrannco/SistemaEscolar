Public Class MENÚ

    Private Sub BTNcargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTNconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNconectar.Click
        Call conectar()
    End Sub

    Private Sub BTNsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalir.Click
        Me.Close()
        FormInicioSesion.Show()
    End Sub

    Private Sub BTNagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNagregar.Click
        FormAgregarAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub btnCARGARGRILLA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCARGARGRILLA.Click
        FormCargarGrilla.Show()
        Me.Hide()
    End Sub
End Class