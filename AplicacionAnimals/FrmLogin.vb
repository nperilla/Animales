Imports Controlador

Public Class FrmLogin
    Dim rpta As Boolean
    Dim persona As New ControllerPersona
    Public correo As String

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        VariablesGlobales.correo = TxtCorreoLogin.Text
        If TxtCorreoLogin.Text.Equals(" ") Or TxtClaveLogin.Text.Equals("") Then
            MsgBox("Ingresar el Correo o clave")
            persona.validarUsuario(TxtCorreoLogin.Text, TxtClaveLogin.Text)
        Else

            rpta = persona.validarUsuario(TxtCorreoLogin.Text, TxtClaveLogin.Text)
            If rpta Then
                Me.Hide()
                FrmMenuUsuario.Show()
            End If
        End If
    End Sub

    Private Sub LblRegistrarse_Click(sender As Object, e As EventArgs) Handles LblRegistrarse.Click
        FrmUsuario.Show()

        Me.Hide()
    End Sub
End Class
