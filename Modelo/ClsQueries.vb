Imports System.Data.SqlClient

Public Class ClsQueries
    Public Function conexion() As SqlConnection
        Dim Conn As String = "data source=EQUIPO\SQLEXPRESS;initial catalog=mascotas;user=user;password=nelson;"
        Return New SqlConnection(Conn)
    End Function

    Public strcon As SqlConnection = conexion()
    Public result As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Error al almacenar datos", MsgBoxStyle.Information)
                Else
                    MsgBox("Procesando...")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub


    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
        da.Dispose()
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Error al actualizar.", MsgBoxStyle.Information)
                Else
                    MsgBox("Procesando...")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Fallo la eliminación del dato", MsgBoxStyle.Critical)
                Else
                    MsgBox("Procesando...")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub


End Class
