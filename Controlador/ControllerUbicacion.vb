Imports System.Windows.Forms
Imports Modelo

Public Class ControllerUbicacion

    Dim ubicacion As New ClsUbicacion()
    Dim animal As New ClsAnimal()

    Public Function registarUbicacion(localidad As String, barrio As String, municipio As String, departamento As String, correo As String)

        ubicacion.CrearUbicacion(localidad, barrio, departamento, municipio, animal.retornarIdUsuario(correo))
        Return "Registro realizado correctamente"
    End Function

    Public Function ConsultarUbicacion(correo As String, data As DataGridView)
        ubicacion.retornarUbicacion(correo, data)
        Return ""
    End Function

    Public Function actualizarUbicacion(localidad As String, barrio As String, municipio As String, departamento As String, correo As String)

        ubicacion.ActualizarUbicacion(localidad, barrio, departamento, municipio, animal.retornarIdUsuario(correo))
        Return "Registro realizado correctamente"
    End Function
End Class
