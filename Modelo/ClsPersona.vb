Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Modelo

Public Class ClsPersona

    Private _Nombre As String
    Private _Apellido As String
    Private _Direccion As String
    Private _Cedula As Integer
    Private _NumeroContacto As Integer
    Private _IdUbicacion As Integer
    Private _Clave As String
    Dim Queries As New ClsQueries()
    Dim animal As New ClsAnimal()
    Dim cantidad As Boolean

    Public Sub New(_Nombre As String, _Apellido As String, _Direccion As String, _Cedula As Integer, _NumeroContacto As Integer, _IdUbicacion As Integer, _Clave As String)
        Me._Nombre = _Nombre
        Me._Apellido = _Apellido
        Me._Direccion = _Direccion
        Me._Cedula = _Cedula
        Me._NumeroContacto = _NumeroContacto
        Me._IdUbicacion = _IdUbicacion
        Me._Clave = _Clave

    End Sub

    Public Sub New()

    End Sub

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Cedula As Integer
        Get
            Return _Cedula
        End Get
        Set(value As Integer)
            _Cedula = value
        End Set
    End Property

    Public Property NumeroContacto As Integer
        Get
            Return _NumeroContacto
        End Get
        Set(value As Integer)
            _NumeroContacto = value
        End Set
    End Property

    Public Property IdUbicacion As Integer
        Get
            Return _IdUbicacion
        End Get
        Set(value As Integer)
            _IdUbicacion = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Cantidad1 As Boolean
        Get
            Return cantidad
        End Get
        Set(value As Boolean)
            cantidad = value
        End Set
    End Property

    Function CrearPersona(Nombre As String, Apellido As String, Direccion As String, Cedula As Integer, NumeroContacto As Integer, Clave As String, Correo As String)
        Try
            Queries.create("INSERT INTO Persona(Nombre,Apellido, Cedula, Direccion, NumeroContacto, clave, correo) VALUES ('" _
                   & Nombre & "','" & Apellido & "','" & Cedula & "','" & Direccion & "','" & NumeroContacto & "','" & Clave & "','" & Correo & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return MsgBox("Se ha creado la persona")

    End Function

    Function Contar(Correo As String) As Boolean
        Try
            Queries.create("SELECT COUNT(correo) FROM Persona WHERE Correo ='" & Correo & "';")
            If Queries.result < 1 Then
                MsgBox("Este correo se encuentra registrado, cambielo")
                Cantidad1 = True
            Else
                Cantidad1 = False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cantidad1
    End Function

    Function retornarPersona(Correo As String, DataGridView As DataGridView)
        Dim n As Integer = animal.retornarIdUsuario(Correo)
        Dim query As String = "SELECT * FROM Persona WHERE codigoUsuario ='" & n & "';"
        Queries.reload(query, DataGridView)
        Return ""
    End Function



    Function ActualizarPersona(Nombre As String, Apellido As String, Direccion As String, Cedula As Integer, NumeroContacto As Integer, Clave As String, Correo As String)
        Try
            Dim n As Integer = animal.retornarIdUsuario(Correo)
            Queries.updates("UPDATE Persona SET Nombre='" & Nombre & "',Apellido='" & Apellido & "', Cedula='" & Cedula & "', Direccion='" & Direccion & "', NumeroContacto='" & NumeroContacto & "', clave='" & Clave & "'WHERE codigoUsuario ='" & n & "';")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return MsgBox("Se ha actualizado la persona")

    End Function

End Class
