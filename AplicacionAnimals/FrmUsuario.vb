Imports Controlador

Public Class FrmUsuario
    Dim persona As New ControllerPersona()
    Private Sub BtnAceptarFrmPersona_Click(sender As Object, e As EventArgs) Handles BtnAceptarFrmPersona.Click
        persona.ContarPersona(txtCorreo.Text)
        If persona.ContarPersona(txtCorreo.Text) < 1 Then
            txtCorreo.Clear()
        Else
            persona.registarPersona(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtCedula.Text, TxtNumeroContacto.Text, TxtClave.Text, txtCorreo.Text)
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtCedula.Clear()
            txtCorreo.Clear()
            TxtClave.Clear()
            TxtDireccion.Clear()
            TxtNumeroContacto.Clear()
            FrmLogin.Show()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCedula.Clear()
        txtCorreo.Clear()
        TxtClave.Clear()
        TxtDireccion.Clear()
        TxtNumeroContacto.Clear()
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        persona.ConsultarPersona(VariablesGlobales.correo, DataGridViewUser)
    End Sub

    Private Sub DataGridViewUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellContentClick
        TxtCedula.Text = DataGridViewUser.CurrentRow.Cells(2).Value
        TxtNombre.Text = DataGridViewUser.CurrentRow.Cells(0).Value
        TxtApellido.Text = DataGridViewUser.CurrentRow.Cells(1).Value
        TxtDireccion.Text = DataGridViewUser.CurrentRow.Cells(4).Value
        TxtNumeroContacto.Text = DataGridViewUser.CurrentRow.Cells(5).Value
        TxtClave.Text = DataGridViewUser.CurrentRow.Cells(6).Value
        txtCorreo.Text = DataGridViewUser.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        FrmUbicacion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FrmMenuUsuario.Show()
    End Sub

    Private Sub BtnActualizarPersona_Click(sender As Object, e As EventArgs) Handles BtnActualizarPersona.Click
        persona.ActualizarPersona(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtCedula.Text, TxtNumeroContacto.Text, TxtClave.Text, VariablesGlobales.correo)
        persona.ConsultarPersona(VariablesGlobales.correo, DataGridViewUser)
    End Sub
End Class
