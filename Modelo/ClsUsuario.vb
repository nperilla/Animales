Imports System.Data.SqlClient

Public Class ClsUsuario

    Dim Queries As New ClsQueries()
    Dim Sql As New SqlConnection
    Dim rpta As Boolean
    Dim correo As String
    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Function ValidarUsuario(ByVal correo As String, ByVal clave As String) As Boolean
        Sql = Queries.strcon
        Try
            Sql.Close()
            Sql.Open()
            Dim comando As New SqlCommand("SELECT correo, clave FROM Persona WHERE correo='" + correo + "'and clave='" + clave + "';", Sql)
            Dim DAdapter As SqlDataReader = comando.ExecuteReader()
            If DAdapter.HasRows = True Then
                While DAdapter.Read
                    If correo.Equals(Trim(DAdapter(0))) And clave.Equals(Trim(DAdapter(1))) Then
                        MsgBox("Bienvenido")
                        rpta = True
                    Else
                        MsgBox("Usuario o clave incorrecta")
                        rpta = False
                    End If
                End While
            Else
                Sql.Close()
                MsgBox("No esta registrado el usuario")
                rpta = False
            End If
        Catch ex As Exception
            MsgBox("Fallo la consulta login" + Err.Description)
            Sql.Close()
        End Try
        Return rpta
    End Function
End Class
