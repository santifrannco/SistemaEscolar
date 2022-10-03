Public Class FormInicioSesion

    Private Sub BTNaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNaceptar.Click
        MENÚ.Show()
        Me.Hide()
        'If TXTusuario.Text = "alex" And TXTcontra.Text = "123" Then
        '    Form1.Show()
        'Else
        '    If TXTusuario.Text = "pepe" And TXTcontra.Text = "12345" Then
        '        Form2.Show()
        '    Else
        '        MsgBox("La contraseña es incorrecta", MsgBoxStyle.Exclamation, "Error")
        '    End If
        'End If
    End Sub

    Private Sub BTNcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNcancelar.Click
        FormUsuarioLogin.Show()
    End Sub
End Class