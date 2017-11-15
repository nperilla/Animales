<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.BtnAceptarFrmPersona = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNumeroContacto = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnActualizarPersona = New System.Windows.Forms.Button()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAceptarFrmPersona
        '
        Me.BtnAceptarFrmPersona.Location = New System.Drawing.Point(478, 69)
        Me.BtnAceptarFrmPersona.Name = "BtnAceptarFrmPersona"
        Me.BtnAceptarFrmPersona.Size = New System.Drawing.Size(279, 23)
        Me.BtnAceptarFrmPersona.TabIndex = 0
        Me.BtnAceptarFrmPersona.Text = "Aceptar"
        Me.BtnAceptarFrmPersona.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(184, 72)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(274, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(184, 154)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(274, 20)
        Me.TxtCedula.TabIndex = 2
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(184, 199)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(274, 20)
        Me.TxtDireccion.TabIndex = 3
        '
        'TxtNumeroContacto
        '
        Me.TxtNumeroContacto.Location = New System.Drawing.Point(184, 237)
        Me.TxtNumeroContacto.Name = "TxtNumeroContacto"
        Me.TxtNumeroContacto.Size = New System.Drawing.Size(274, 20)
        Me.TxtNumeroContacto.TabIndex = 4
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(184, 112)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(274, 20)
        Me.TxtApellido.TabIndex = 5
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(184, 278)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(274, 20)
        Me.TxtClave.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Numero Contacto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Clave:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DATOS DEL USUARIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(184, 315)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(274, 20)
        Me.txtCorreo.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Location = New System.Drawing.Point(42, 390)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.Size = New System.Drawing.Size(684, 128)
        Me.DataGridViewUser.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Adicionar Ubicación:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(181, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "+"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(481, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Volver a menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnActualizarPersona
        '
        Me.BtnActualizarPersona.Location = New System.Drawing.Point(478, 151)
        Me.BtnActualizarPersona.Name = "BtnActualizarPersona"
        Me.BtnActualizarPersona.Size = New System.Drawing.Size(279, 23)
        Me.BtnActualizarPersona.TabIndex = 21
        Me.BtnActualizarPersona.Text = "Actualizar"
        Me.BtnActualizarPersona.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 532)
        Me.Controls.Add(Me.BtnActualizarPersona)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridViewUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNumeroContacto)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnAceptarFrmPersona)
        Me.Name = "FrmUsuario"
        Me.Text = "Formulario Persona"
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAceptarFrmPersona As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNumeroContacto As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewUser As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnActualizarPersona As Button
End Class
