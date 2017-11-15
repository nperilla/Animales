Imports System.Windows.Forms
Imports Modelo

Public Class ControllerPersona
    Dim user As New ClsUsuario()
    Dim per As New ClsPersona()
    Dim rpta As Boolean
    Public Function validarUsuario(correo As String, clave As String) As Boolean
        rpta = user.ValidarUsuario(correo, clave)
        Return rpta
    End Function

    Public Function ContarPersona(correo As String)
        per.Contar(correo)
        Return per.Cantidad1
    End Function

    Public Function ActualizarPersona(Nombre As String, Apellido As String, Direccion As String, Cedula As Integer, NumeroContacto As Integer, Clave As String, Correo As String)
        rpta = user.ValidarUsuario(Correo, Clave)
        per.ActualizarPersona(Nombre, Apellido, Direccion, Cedula, NumeroContacto, Clave, Correo)
        Return "Actualizar realizado correctamente"
    End Function

    Public Function ConsultarPersona(correo As String, data As DataGridView)
        per.retornarPersona(correo, data)
        Return ""
    End Function

    Public Function registarPersona(Nombre As String, Apellido As String, Direccion As String, Cedula As Integer, NumeroContacto As Integer, Clave As String, Correo As String)
        rpta = user.ValidarUsuario(Correo, Clave)
        per.CrearPersona(Nombre, Apellido, Direccion, Cedula, NumeroContacto, Clave, Correo)
        Return "Registro realizado correctamente"
    End Function

End Class
