<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PP))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Picas = New System.Windows.Forms.TextBox()
        Me.Fijas = New System.Windows.Forms.TextBox()
        Me.Numero = New System.Windows.Forms.TextBox()
        Me.Validar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Registro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(63, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Picas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(225, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fijas"
        '
        'Picas
        '
        Me.Picas.Enabled = False
        Me.Picas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Picas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Picas.Location = New System.Drawing.Point(141, 161)
        Me.Picas.Name = "Picas"
        Me.Picas.Size = New System.Drawing.Size(66, 33)
        Me.Picas.TabIndex = 3
        Me.Picas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fijas
        '
        Me.Fijas.Enabled = False
        Me.Fijas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Fijas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Fijas.Location = New System.Drawing.Point(295, 162)
        Me.Fijas.Name = "Fijas"
        Me.Fijas.Size = New System.Drawing.Size(66, 33)
        Me.Fijas.TabIndex = 4
        Me.Fijas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Numero
        '
        Me.Numero.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Numero.Location = New System.Drawing.Point(141, 77)
        Me.Numero.MaxLength = 3
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(166, 33)
        Me.Numero.TabIndex = 5
        Me.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Validar
        '
        Me.Validar.Enabled = False
        Me.Validar.Location = New System.Drawing.Point(232, 116)
        Me.Validar.Name = "Validar"
        Me.Validar.Size = New System.Drawing.Size(75, 23)
        Me.Validar.TabIndex = 6
        Me.Validar.Text = "Validar"
        Me.Validar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.Registro.AutoSize = True
        Me.Registro.BackColor = System.Drawing.Color.Transparent
        Me.Registro.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Registro.ForeColor = System.Drawing.Color.AliceBlue
        Me.Registro.Location = New System.Drawing.Point(30, 218)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(71, 17)
        Me.Registro.TabIndex = 8
        Me.Registro.Text = "Intentos: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cascadia Code", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(90, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Adivina el número"
        '
        'PP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(449, 488)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Validar)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.Fijas)
        Me.Controls.Add(Me.Picas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PP"
        Me.Text = "Picas y fijas"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Picas As TextBox
    Friend WithEvents Fijas As TextBox
    Friend WithEvents Numero As TextBox
    Friend WithEvents Validar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Registro As Label
    Friend WithEvents Label1 As Label
End Class
