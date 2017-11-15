<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUbicacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAceptarUbicacion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBarrio = New System.Windows.Forms.TextBox()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.DataGridViewUbicacion = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAceptarUbicacion
        '
        Me.BtnAceptarUbicacion.Location = New System.Drawing.Point(301, 34)
        Me.BtnAceptarUbicacion.Name = "BtnAceptarUbicacion"
        Me.BtnAceptarUbicacion.Size = New System.Drawing.Size(162, 23)
        Me.BtnAceptarUbicacion.TabIndex = 0
        Me.BtnAceptarUbicacion.Text = "Aceptar"
        Me.BtnAceptarUbicacion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barrio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Municipio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Departamento"
        '
        'TxtBarrio
        '
        Me.TxtBarrio.Location = New System.Drawing.Point(122, 34)
        Me.TxtBarrio.Name = "TxtBarrio"
        Me.TxtBarrio.Size = New System.Drawing.Size(157, 20)
        Me.TxtBarrio.TabIndex = 5
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(122, 81)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(157, 20)
        Me.TxtLocalidad.TabIndex = 6
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(122, 126)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(157, 20)
        Me.TxtMunicipio.TabIndex = 7
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(122, 173)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(157, 20)
        Me.TxtDepartamento.TabIndex = 8
        '
        'DataGridViewUbicacion
        '
        Me.DataGridViewUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUbicacion.Location = New System.Drawing.Point(30, 236)
        Me.DataGridViewUbicacion.Name = "DataGridViewUbicacion"
        Me.DataGridViewUbicacion.Size = New System.Drawing.Size(433, 150)
        Me.DataGridViewUbicacion.TabIndex = 9
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(301, 83)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(162, 23)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Volver a menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(301, 121)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(162, 23)
        Me.BtnActualizar.TabIndex = 21
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'FrmUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 440)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.DataGridViewUbicacion)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.TxtMunicipio)
        Me.Controls.Add(Me.TxtLocalidad)
        Me.Controls.Add(Me.TxtBarrio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAceptarUbicacion)
        Me.Name = "FrmUbicacion"
        Me.Text = "FrmUbicacion"
        CType(Me.DataGridViewUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAceptarUbicacion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBarrio As TextBox
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents DataGridViewUbicacion As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnActualizar As Button
End Class
