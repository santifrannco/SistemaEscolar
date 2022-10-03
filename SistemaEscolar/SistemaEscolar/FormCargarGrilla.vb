Imports MySql.Data.MySqlClient
Public Class FormCargarGrilla
    Sub CargarGrilla(ByVal cadena As String)
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

            'cargo la sentencia
            Comando.CommandText = cadena

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'limpio el list
                LViewAlumnos.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo la grilla utilizando el DReader
                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = LViewAlumnos.Items.Add(DReader("id_alumno"))
                    LV.SubItems.Add(DReader("DNI"))
                    LV.SubItems.Add(DReader("apellido"))
                    LV.SubItems.Add(DReader("nombre"))
                    LV.SubItems.Add(DReader("direccion"))
                    LV.SubItems.Add(DReader("sexo"))
                    LV.SubItems.Add(DReader("fecha_nacimiento"))
                Loop
            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub LViewAlumnos_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LViewAlumnos.ColumnClick
        Dim consulta As String

        'depende la columna que hace click ordena la lista
        Select Case e.Column
            Case 0
                consulta = "select * from alumno order by id_alumno;"
            Case 1
                consulta = "select * from alumno order by DNI;"
            Case 2
                consulta = "select * from alumno order by apellido;"
            Case 3
                consulta = "select * from alumno order by nombre;"
            Case 4
                consulta = "select * from alumno order by direccion;"
            Case 5
                consulta = "select * from alumno order by sexo;"
        End Select

        Call CargarGrilla(consulta)
    End Sub
    Private Sub LViewAlumnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LViewAlumnos.SelectedIndexChanged

    End Sub

    Private Sub FormCargarGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarGrilla("select * from alumno order by nombre")
    End Sub

    Private Sub BTNsalirGrilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalirGrilla.Click
        Me.Close()
        MENÚ.Show()
    End Sub
End Class