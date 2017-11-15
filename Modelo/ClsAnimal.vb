

Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsAnimal
    Private _NombreMascota As String
    Private _Color As String
    Private _Especie As String
    Private _Raza As String
    Private _Imagen As String
    Private _FechaPerdida As DateTime
    Private _EstadoAnimal As String
    Private _Descripción As String
    Private _CodigoPersona As Integer
    Dim queries As New ClsQueries()
    Private id As String
    Dim n As Integer

    Public Sub New()

    End Sub

    Public Sub New(_NombreMascota As String, _Color As String, _Especie As String, _Raza As String, _Imagen As String, _FechaPerdida As Date, _EstadoAnimal As String, _Descripción As String, _CodigoPersona As Integer)
        Me._NombreMascota = _NombreMascota
        Me._Color = _Color
        Me._Especie = _Especie
        Me._Raza = _Raza
        Me._Imagen = _Imagen
        Me._FechaPerdida = _FechaPerdida
        Me._EstadoAnimal = _EstadoAnimal
        Me._Descripción = _Descripción
        Me._CodigoPersona = _CodigoPersona
    End Sub

    Public Property NombreMascota As String
        Get
            Return _NombreMascota
        End Get
        Set(value As String)
            _NombreMascota = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
        End Set
    End Property

    Public Property Especie As String
        Get
            Return _Especie
        End Get
        Set(value As String)
            _Especie = value
        End Set
    End Property

    Public Property Raza As String
        Get
            Return _Raza
        End Get
        Set(value As String)
            _Raza = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
        End Set
    End Property

    Public Property FechaPerdida As Date
        Get
            Return _FechaPerdida
        End Get
        Set(value As Date)
            _FechaPerdida = value
        End Set
    End Property

    Public Property EstadoAnimal As String
        Get
            Return _EstadoAnimal
        End Get
        Set(value As String)
            _EstadoAnimal = value
        End Set
    End Property

    Public Property Descripción As String
        Get
            Return _Descripción
        End Get
        Set(value As String)
            _Descripción = value
        End Set
    End Property

    Public Property CodigoPersona As Integer
        Get
            Return _CodigoPersona
        End Get
        Set(value As Integer)
            _CodigoPersona = value
        End Set
    End Property

    Function registrarAnimal(Color As String, Nombre As String, especie As String, raza As String, imagen As String, FechaPerdida As String, EstadoAniml As String, descripcion As String, codigo As String)
        Try

            queries.create("INSERT INTO Mascota(Color,NombreMascota, Especie, Raza, Imagen, FechaPerdida, EstadoAnimal, Descripcion, CodigoPersona) VALUES ('" _
                   & Color & "','" & Nombre & "','" & especie & "','" & raza & "','" & imagen & "','" & FechaPerdida & "','" & EstadoAnimal & "','" & descripcion & "','" & codigo & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function


    Function retornarIdUsuario(Correo As String) As Long
        Dim n As Integer
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        cmd.CommandText = "SELECT CodigoUsuario FROM Persona WHERE Correo ='" & Correo & "';"
        cmd.CommandType = CommandType.Text
        cmd.Connection = queries.strcon
        queries.strcon.Open()
        n = CInt(cmd.ExecuteScalar())
        queries.strcon.Close()
        Return n
    End Function

    Function retornarAnimal(Correo As String, DataGridView As DataGridView)
        Dim n As Integer = retornarIdUsuario(Correo)
        Dim query As String = "SELECT * FROM Mascota WHERE codigoPersona ='" & n & "';"
        queries.reload(query, DataGridView)
        Return ""
    End Function

    Function actualizarAnimal(Color As String, Nombre As String, especie As String, raza As String, imagen As String, FechaPerdida As String, EstadoAniml As String, descripcion As String, codigo As String, correo As String)
        Try
            Dim n As Integer = retornarIdUsuario(correo)
            queries.updates("UPDATE Mascota SET Color='" & Color & "', NombreMascota=='" & NombreMascota & "', Especie=='" & especie & "', Raza='" & raza & "', Imagen ='" & imagen & "', FechaPerdida='" & FechaPerdida & "', EstadoAnimal='" & EstadoAnimal & "', Descripcion='" & descripcion & "' WHERE CodigoPersona='" & n & "');")

        Catch ex As Exception

        End Try
    End Function

End Class

