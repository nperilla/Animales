<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtCorreoLogin = New System.Windows.Forms.TextBox()
        Me.TxtClaveLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblRegistrarse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(50, 156)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(193, 23)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Aceptar"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtCorreoLogin
        '
        Me.TxtCorreoLogin.Location = New System.Drawing.Point(50, 46)
        Me.TxtCorreoLogin.Name = "TxtCorreoLogin"
        Me.TxtCorreoLogin.Size = New System.Drawing.Size(193, 20)
        Me.TxtCorreoLogin.TabIndex = 1
        '
        'TxtClaveLogin
        '
        Me.TxtClaveLogin.Location = New System.Drawing.Point(50, 105)
        Me.TxtClaveLogin.Name = "TxtClaveLogin"
        Me.TxtClaveLogin.Size = New System.Drawing.Size(193, 20)
        Me.TxtClaveLogin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave"
        '
        'LblRegistrarse
        '
        Me.LblRegistrarse.AutoSize = True
        Me.LblRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrarse.Location = New System.Drawing.Point(47, 202)
        Me.LblRegistrarse.Name = "LblRegistrarse"
        Me.LblRegistrarse.Size = New System.Drawing.Size(71, 13)
        Me.LblRegistrarse.TabIndex = 25
        Me.LblRegistrarse.Text = "Registrarse"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 243)
        Me.Controls.Add(Me.LblRegistrarse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtClaveLogin)
        Me.Controls.Add(Me.TxtCorreoLogin)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtCorreoLogin As TextBox
    Friend WithEvents TxtClaveLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblRegistrarse As Label
End Class
