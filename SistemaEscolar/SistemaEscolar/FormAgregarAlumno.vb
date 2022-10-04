Imports MySql.Data.MySqlClient
Public Class FormAgregarAlumno
    Private Sub LimpiarForm()
        TXTdni.Text = ""
        TXTnombre.Text = ""
        TXTapellido.Text = ""
        TXTdireccion.Text = ""
        TXTciudad.Text = ""
        TXTfecha_nac.Text = ""
        dtpFecha_insc.Text = ""
        CMBsexo.Text = ""
        TXTano.Text = ""
    End Sub
    Private Sub BTNagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNagregar.Click
        'primero controlo que esten los datos cargados
        'And Trim(TXTfecha_inscp.Text) = ""
        'And Trim(TXTfecha_nac.Text) = "
        If Trim(TXTdni.Text) = "" And Trim(TXTnombre.Text) = "" And Trim(CMBsexo.Text) = "" And Trim(TXTapellido.Text) = "" And Trim(TXTdireccion.Text) = "" And Trim(TXTciudad.Text) = "" And Trim(TXTdireccion.Text) = "" Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical)
            TXTdni.Focus()
            Exit Sub
        End If

        'agrego un registro a la tabla
        Try
            'conecto a la base
            'Call conectar()
            conexion.Open()

            'trabajo con los datos
            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand
            'conecto el objeto command
            Comando.Connection = conexion
            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text
            'PRIMERO CONTROLO QUE EL REGISTRO NO EXISTA
            Comando.CommandText = "select * from alumno where DNI = '" &
                Trim(TXTdni.Text) & "';"
            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader
            'si no encontro, entonces agrego
            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            Else
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para AGREGAR un registro
                Comando.CommandText = "insert into alumno values (" &
            Trim(TXTdni.Text) & ",'" & Trim(TXTnombre.Text) & "','" &
            Trim(TXTapellido.Text) & "','" & Trim(TXTciudad.Text) & "','" &
            Trim(TXTdireccion.Text) & "','" & dtpFecha_Naci.Value.ToString("yyyy-MM-dd") & "','" & dtpFecha_insc.Value.ToString("yyyy-MM-dd") & "','" & Trim(TXTano.Text) & "');"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & Resultado)

                'cargo el list
                'Call CargarList()
                Call LimpiarForm()
            End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub BTNsalirr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalirr.Click
        Me.Close()
        MENÚ.Show()
    End Sub

    Private Sub BTNAgregarImagenAlum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregarImagenAlum.Click
        FormCargarImagenAlum.Show()
        Me.Hide()
    End Sub
End Class