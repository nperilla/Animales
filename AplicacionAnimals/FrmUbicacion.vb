Imports Controlador

Public Class FrmUbicacion
    'Instancia el controlador
    Dim ubicacion As New ControllerUbicacion
    Private Sub BtnAceptarUbicacion_Click(sender As Object, e As EventArgs) Handles BtnAceptarUbicacion.Click
        ubicacion.registarUbicacion(TxtBarrio.Text, TxtDepartamento.Text, TxtLocalidad.Text, TxtMunicipio.Text, VariablesGlobales.correo)
        'limpia los controles
        TxtBarrio.Clear()
        TxtDepartamento.Clear()
        TxtLocalidad.Clear()
        TxtMunicipio.Clear()

    End Sub

    Private Sub FrmUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ubicacion.ConsultarUbicacion(VariablesGlobales.correo, DataGridViewUbicacion)
    End Sub

    Private Sub DataGridViewUbicacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUbicacion.CellContentClick
        TxtBarrio.Text = DataGridViewUbicacion.CurrentRow.Cells(1).Value
        TxtDepartamento.Text = DataGridViewUbicacion.CurrentRow.Cells(2).Value
        TxtLocalidad.Text = DataGridViewUbicacion.CurrentRow.Cells(0).Value
        TxtMunicipio.Text = DataGridViewUbicacion.CurrentRow.Cells(3).Value
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'limpia los controles
        TxtBarrio.Clear()
        TxtDepartamento.Clear()
        TxtLocalidad.Clear()
        TxtMunicipio.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmMenuUsuario.Show()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ubicacion.actualizarUbicacion(TxtLocalidad.Text, TxtBarrio.Text, TxtMunicipio.Text, TxtDepartamento.Text, VariablesGlobales.correo)
        ubicacion.ConsultarUbicacion(VariablesGlobales.correo, DataGridViewUbicacion)
    End Sub
End Class