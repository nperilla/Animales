<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTituloRegistro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAceptarFrmPersona
        '
        Me.BtnAceptarFrmPersona.Location = New System.Drawing.Point(42, 323)
        Me.BtnAceptarFrmPersona.Name = "BtnAceptarFrmPersona"
        Me.BtnAceptarFrmPersona.Size = New System.Drawing.Size(416, 23)
        Me.BtnAceptarFrmPersona.TabIndex = 0
        Me.BtnAceptarFrmPersona.Text = "Aceptar"
        Me.BtnAceptarFrmPersona.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(184, 38)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(274, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(184, 120)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(274, 20)
        Me.TxtCedula.TabIndex = 2
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(184, 165)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(274, 20)
        Me.TxtDireccion.TabIndex = 3
        '
        'TxtNumeroContacto
        '
        Me.TxtNumeroContacto.Location = New System.Drawing.Point(184, 208)
        Me.TxtNumeroContacto.Name = "TxtNumeroContacto"
        Me.TxtNumeroContacto.Size = New System.Drawing.Size(274, 20)
        Me.TxtNumeroContacto.TabIndex = 4
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(184, 78)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(274, 20)
        Me.TxtApellido.TabIndex = 5
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(184, 249)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(274, 20)
        Me.TxtClave.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Numero Contacto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Clave:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Adicionar mascota:"
        '
        'lblTituloRegistro
        '
        Me.lblTituloRegistro.AutoSize = True
        Me.lblTituloRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloRegistro.Location = New System.Drawing.Point(157, 3)
        Me.lblTituloRegistro.Name = "lblTituloRegistro"
        Me.lblTituloRegistro.Size = New System.Drawing.Size(222, 29)
        Me.lblTituloRegistro.TabIndex = 22
        Me.lblTituloRegistro.Text = "DATOS USUARIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "+"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 404)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTituloRegistro)
        Me.Controls.Add(Me.Label8)
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
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTituloRegistro As Label
    Friend WithEvents Label7 As Label
End Class
