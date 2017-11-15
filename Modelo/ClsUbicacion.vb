Imports System.Windows.Forms

Public Class ClsUbicacion
    Private _Localidad As String
    Private _Barrio As String
    Private _Departament As String
    Private _Municipio As String
    Dim Queries As New ClsQueries()
    Dim animal As New ClsAnimal()
    Public Sub New(_Localidad As String, _Barrio As String, _Departament As String, _Municipio As String)
        Me._Localidad = _Localidad
        Me._Barrio = _Barrio
        Me._Departament = _Departament
        Me._Municipio = _Municipio
    End Sub

    Public Sub New()
    End Sub

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Barrio As String
        Get
            Return _Barrio
        End Get
        Set(value As String)
            _Barrio = value
        End Set
    End Property

    Public Property Departament As String
        Get
            Return _Departament
        End Get
        Set(value As String)
            _Departament = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property



    Function CrearUbicacion(localidad As String, barrio As String, departamento As String, municipio As String, codigo As Integer)
        Try
            Queries.create("INSERT INTO Ubicacion(localidad, barrio, departamente, municipio, CodigoUsuario) VALUES ('" _
                   & localidad & "','" & barrio & "','" & departamento & "','" & municipio & "','" & codigo & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return MsgBox("Se ha creado la ubicacion")

    End Function


    Function retornarUbicacion(Correo As String, DataGridView As DataGridView)
        Dim n As Integer = animal.retornarIdUsuario(Correo)
        Dim query As String = "SELECT * FROM Ubicacion WHERE codigoUsuario ='" & n & "';"
        Queries.reload(query, DataGridView)
        Return ""
    End Function

    Function ActualizarUbicacion(localidad As String, barrio As String, departamento As String, municipio As String, correo As String)
        Try
            Dim n As Integer = animal.retornarIdUsuario(correo)
            Queries.updates("UPDATE Ubicacion SET barrio='" & barrio & "' , localidad='" & localidad & "', Municipio='" & municipio & "', Departamento= '" & departamento & "' WHERE codigoUsuario ='" & n & "';")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return MsgBox("Se ha actualizado la ubicacion")

    End Function

End Class
