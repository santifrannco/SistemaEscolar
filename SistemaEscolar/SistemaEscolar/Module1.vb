Imports MySql.Data.MySqlClient
Module Module1
    Friend conexion As MySqlConnection
    Sub conectar()
        Try
            conexion = New MySqlConnection()

            Dim cadena As String

            cadena = "server=localhost; user id=root; password=r5o90fam; database=sistemadeescuela; port=3306;"
            conexion.ConnectionString = cadena
            conexion.Open()
            conexion.Close()
            MessageBox.Show("Se conecto correctamente")

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
            End
            'MessageBox.Show(ex.Message) -Muestra el error de la aplicacion

        End Try

    End Sub
End Module
