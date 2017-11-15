Imports System.Windows.Forms
Imports Modelo

Public Class ControllerAnimal
    Dim animal As New ClsAnimal()
    Dim per As New ClsUsuario()
    Dim queries As New ClsQueries()

    Public Function registraAnimal(color As String, nom As String, especie As String, raza As String, imagen As String, fechaPerdida As String, estado As String, descripcion As String, correo As String)
        animal.registrarAnimal(color, nom, especie, raza, imagen, fechaPerdida, estado, descripcion, animal.retornarIdUsuario(correo))
        Return "Registro completado"

    End Function

    Public Function ConsultarAnimal(correo As String, data As DataGridView)
        animal.retornarAnimal(correo, data)
        Return ""
    End Function

    Public Function ActualizarAnimal(color As String, nom As String, especie As String, raza As String, imagen As String, fechaPerdida As String, estado As String, descripcion As String, correo As String)
        animal.actualizarAnimal(color, nom, especie, raza, imagen, fechaPerdida, estado, descripcion, animal.retornarIdUsuario(correo), correo)
        Return " "
    End Function

End Class
