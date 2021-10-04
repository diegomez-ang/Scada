<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListaPuertos = New System.Windows.Forms.ComboBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Conectar = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListaPuertos
        '
        Me.ListaPuertos.FormattingEnabled = True
        Me.ListaPuertos.Location = New System.Drawing.Point(12, 26)
        Me.ListaPuertos.Name = "ListaPuertos"
        Me.ListaPuertos.Size = New System.Drawing.Size(89, 21)
        Me.ListaPuertos.TabIndex = 0
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(12, 65)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(89, 23)
        Me.Buscar.TabIndex = 1
        Me.Buscar.Text = "Buscar puerto"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Conectar
        '
        Me.Conectar.Location = New System.Drawing.Point(12, 109)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(89, 23)
        Me.Conectar.TabIndex = 2
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(758, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Conectar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.ListaPuertos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListaPuertos As ComboBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Conectar As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
End Class
