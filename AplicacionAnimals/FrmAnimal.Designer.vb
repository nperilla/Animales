<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnimal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNombreMascota = New System.Windows.Forms.TextBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtEspecie = New System.Windows.Forms.TextBox()
        Me.TxtRaza = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtFechaPerdida = New System.Windows.Forms.TextBox()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnRegistrarMascota = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.DataGridViewAnimal = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreMascota
        '
        Me.TxtNombreMascota.Location = New System.Drawing.Point(206, 33)
        Me.TxtNombreMascota.Name = "TxtNombreMascota"
        Me.TxtNombreMascota.Size = New System.Drawing.Size(199, 20)
        Me.TxtNombreMascota.TabIndex = 0
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(206, 60)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(199, 20)
        Me.TxtColor.TabIndex = 1
        '
        'TxtEspecie
        '
        Me.TxtEspecie.Location = New System.Drawing.Point(206, 89)
        Me.TxtEspecie.Name = "TxtEspecie"
        Me.TxtEspecie.Size = New System.Drawing.Size(199, 20)
        Me.TxtEspecie.TabIndex = 2
        '
        'TxtRaza
        '
        Me.TxtRaza.Location = New System.Drawing.Point(206, 122)
        Me.TxtRaza.Name = "TxtRaza"
        Me.TxtRaza.Size = New System.Drawing.Size(199, 20)
        Me.TxtRaza.TabIndex = 3
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(206, 261)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(199, 76)
        Me.TxtDescripcion.TabIndex = 7
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(206, 232)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(199, 20)
        Me.TxtEstado.TabIndex = 6
        '
        'TxtFechaPerdida
        '
        Me.TxtFechaPerdida.Location = New System.Drawing.Point(206, 192)
        Me.TxtFechaPerdida.Name = "TxtFechaPerdida"
        Me.TxtFechaPerdida.Size = New System.Drawing.Size(199, 20)
        Me.TxtFechaPerdida.TabIndex = 5
        '
        'TxtImagen
        '
        Me.TxtImagen.Location = New System.Drawing.Point(206, 155)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(199, 20)
        Me.TxtImagen.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre mascota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Raza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Especie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha de perdida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Imagen:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descripción:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Estado:"
        '
        'BtnRegistrarMascota
        '
        Me.BtnRegistrarMascota.Location = New System.Drawing.Point(447, 33)
        Me.BtnRegistrarMascota.Name = "BtnRegistrarMascota"
        Me.BtnRegistrarMascota.Size = New System.Drawing.Size(276, 23)
        Me.BtnRegistrarMascota.TabIndex = 16
        Me.BtnRegistrarMascota.Text = "Aceptar"
        Me.BtnRegistrarMascota.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(447, 79)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(276, 23)
        Me.BtnLimpiar.TabIndex = 17
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'DataGridViewAnimal
        '
        Me.DataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnimal.Location = New System.Drawing.Point(50, 349)
        Me.DataGridViewAnimal.Name = "DataGridViewAnimal"
        Me.DataGridViewAnimal.Size = New System.Drawing.Size(726, 150)
        Me.DataGridViewAnimal.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Volver a menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(447, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 517)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewAnimal)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnRegistrarMascota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.TxtFechaPerdida)
        Me.Controls.Add(Me.TxtImagen)
        Me.Controls.Add(Me.TxtRaza)
        Me.Controls.Add(Me.TxtEspecie)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.TxtNombreMascota)
        Me.Name = "FrmAnimal"
        Me.Text = "FrmAnimal"
        CType(Me.DataGridViewAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombreMascota As TextBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtEspecie As TextBox
    Friend WithEvents TxtRaza As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtFechaPerdida As TextBox
    Friend WithEvents TxtImagen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnRegistrarMascota As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents DataGridViewAnimal As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
