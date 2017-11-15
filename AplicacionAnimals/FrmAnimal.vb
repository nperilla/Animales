Imports Controlador

Public Class FrmAnimal
    'Instancia el controlador
    Dim mascota As New ControllerAnimal
    Private Sub BtnRegistrarMascota_Click(sender As Object, e As EventArgs) Handles BtnRegistrarMascota.Click

        'registra a la mascota
        mascota.registraAnimal(TxtColor.Text, TxtNombreMascota.Text, TxtEspecie.Text, TxtRaza.Text, TxtImagen.Text, TxtFechaPerdida.Text, TxtEstado.Text, TxtDescripcion.Text, VariablesGlobales.correo)
        'limpia los controles
        TxtColor.Clear()
        TxtDescripcion.Clear()
        TxtEspecie.Clear()
        TxtEstado.Clear()
        TxtFechaPerdida.Clear()
        TxtImagen.Clear()
        TxtNombreMascota.Clear()
        TxtRaza.Clear()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'limpia los controles
        TxtColor.Clear()
        TxtDescripcion.Clear()
        TxtEspecie.Clear()
        TxtEstado.Clear()
        TxtFechaPerdida.Clear()
        TxtImagen.Clear()
        TxtNombreMascota.Clear()
        TxtRaza.Clear()
    End Sub

    Private Sub DataGridViewAnimal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAnimal.CellContentClick
        TxtColor.Text = DataGridViewAnimal.CurrentRow.Cells(1).Value
        TxtNombreMascota.Text = DataGridViewAnimal.CurrentRow.Cells(2).Value
        TxtEspecie.Text = DataGridViewAnimal.CurrentRow.Cells(3).Value
        TxtRaza.Text = DataGridViewAnimal.CurrentRow.Cells(4).Value
        TxtImagen.Text = DataGridViewAnimal.CurrentRow.Cells(5).Value
        TxtFechaPerdida.Text = DataGridViewAnimal.CurrentRow.Cells(6).Value
        TxtEstado.Text = DataGridViewAnimal.CurrentRow.Cells(7).Value
        TxtDescripcion.Text = DataGridViewAnimal.CurrentRow.Cells(8).Value

    End Sub

    Private Sub FrmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mascota.ConsultarAnimal(VariablesGlobales.correo, DataGridViewAnimal)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmMenuUsuario.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mascota.ActualizarAnimal(TxtColor.Text, TxtNombreMascota.Text, TxtEspecie.Text, TxtRaza.Text, TxtImagen.Text, TxtFechaPerdida.Text, TxtEstado.Text, TxtDescripcion.Text, VariablesGlobales.correo)
        mascota.ConsultarAnimal(VariablesGlobales.correo, DataGridViewAnimal)

    End Sub
End Class