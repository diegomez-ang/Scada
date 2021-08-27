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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.B_off = New System.Windows.Forms.Button()
        Me.B_on = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.B_sec_3 = New System.Windows.Forms.Button()
        Me.B_sec_2 = New System.Windows.Forms.Button()
        Me.B_sec_1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.B_vel_3 = New System.Windows.Forms.Button()
        Me.B_vel_2 = New System.Windows.Forms.Button()
        Me.B_vel_1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.on_8 = New System.Windows.Forms.PictureBox()
        Me.on_7 = New System.Windows.Forms.PictureBox()
        Me.on_6 = New System.Windows.Forms.PictureBox()
        Me.on_5 = New System.Windows.Forms.PictureBox()
        Me.on_4 = New System.Windows.Forms.PictureBox()
        Me.on_3 = New System.Windows.Forms.PictureBox()
        Me.on_2 = New System.Windows.Forms.PictureBox()
        Me.on_1 = New System.Windows.Forms.PictureBox()
        Me.off_8 = New System.Windows.Forms.PictureBox()
        Me.off_7 = New System.Windows.Forms.PictureBox()
        Me.off_6 = New System.Windows.Forms.PictureBox()
        Me.off_5 = New System.Windows.Forms.PictureBox()
        Me.off_4 = New System.Windows.Forms.PictureBox()
        Me.off_3 = New System.Windows.Forms.PictureBox()
        Me.off_2 = New System.Windows.Forms.PictureBox()
        Me.off_1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.on_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.on_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.off_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(246, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SECUENCIAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.B_off)
        Me.GroupBox1.Controls.Add(Me.B_on)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.Location = New System.Drawing.Point(40, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ON/OFF"
        '
        'B_off
        '
        Me.B_off.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_off.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_off.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_off.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.B_off.Location = New System.Drawing.Point(18, 75)
        Me.B_off.Name = "B_off"
        Me.B_off.Size = New System.Drawing.Size(57, 41)
        Me.B_off.TabIndex = 1
        Me.B_off.Text = "O"
        Me.B_off.UseVisualStyleBackColor = False
        '
        'B_on
        '
        Me.B_on.BackColor = System.Drawing.Color.Green
        Me.B_on.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_on.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_on.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.B_on.Location = New System.Drawing.Point(18, 28)
        Me.B_on.Name = "B_on"
        Me.B_on.Size = New System.Drawing.Size(57, 41)
        Me.B_on.TabIndex = 0
        Me.B_on.Text = "I"
        Me.B_on.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B_sec_3)
        Me.GroupBox2.Controls.Add(Me.B_sec_2)
        Me.GroupBox2.Controls.Add(Me.B_sec_1)
        Me.GroupBox2.Location = New System.Drawing.Point(180, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SECUENCIAS"
        '
        'B_sec_3
        '
        Me.B_sec_3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sec_3.Location = New System.Drawing.Point(111, 51)
        Me.B_sec_3.Name = "B_sec_3"
        Me.B_sec_3.Size = New System.Drawing.Size(40, 40)
        Me.B_sec_3.TabIndex = 2
        Me.B_sec_3.Text = "3"
        Me.B_sec_3.UseVisualStyleBackColor = True
        '
        'B_sec_2
        '
        Me.B_sec_2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sec_2.Location = New System.Drawing.Point(65, 51)
        Me.B_sec_2.Name = "B_sec_2"
        Me.B_sec_2.Size = New System.Drawing.Size(40, 40)
        Me.B_sec_2.TabIndex = 2
        Me.B_sec_2.Text = "2"
        Me.B_sec_2.UseVisualStyleBackColor = True
        '
        'B_sec_1
        '
        Me.B_sec_1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sec_1.Location = New System.Drawing.Point(19, 51)
        Me.B_sec_1.Name = "B_sec_1"
        Me.B_sec_1.Size = New System.Drawing.Size(40, 40)
        Me.B_sec_1.TabIndex = 0
        Me.B_sec_1.Text = "1"
        Me.B_sec_1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.B_vel_3)
        Me.GroupBox3.Controls.Add(Me.B_vel_2)
        Me.GroupBox3.Controls.Add(Me.B_vel_1)
        Me.GroupBox3.Location = New System.Drawing.Point(400, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 132)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VELOCIDAD"
        '
        'B_vel_3
        '
        Me.B_vel_3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_vel_3.Location = New System.Drawing.Point(107, 51)
        Me.B_vel_3.Name = "B_vel_3"
        Me.B_vel_3.Size = New System.Drawing.Size(40, 40)
        Me.B_vel_3.TabIndex = 5
        Me.B_vel_3.Text = "3"
        Me.B_vel_3.UseVisualStyleBackColor = True
        '
        'B_vel_2
        '
        Me.B_vel_2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_vel_2.Location = New System.Drawing.Point(61, 51)
        Me.B_vel_2.Name = "B_vel_2"
        Me.B_vel_2.Size = New System.Drawing.Size(40, 40)
        Me.B_vel_2.TabIndex = 4
        Me.B_vel_2.Text = "2"
        Me.B_vel_2.UseVisualStyleBackColor = True
        '
        'B_vel_1
        '
        Me.B_vel_1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_vel_1.Location = New System.Drawing.Point(15, 51)
        Me.B_vel_1.Name = "B_vel_1"
        Me.B_vel_1.Size = New System.Drawing.Size(40, 40)
        Me.B_vel_1.TabIndex = 3
        Me.B_vel_1.Text = "1"
        Me.B_vel_1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.on_8)
        Me.GroupBox4.Controls.Add(Me.on_7)
        Me.GroupBox4.Controls.Add(Me.on_6)
        Me.GroupBox4.Controls.Add(Me.on_5)
        Me.GroupBox4.Controls.Add(Me.on_4)
        Me.GroupBox4.Controls.Add(Me.on_3)
        Me.GroupBox4.Controls.Add(Me.on_2)
        Me.GroupBox4.Controls.Add(Me.on_1)
        Me.GroupBox4.Controls.Add(Me.off_8)
        Me.GroupBox4.Controls.Add(Me.off_7)
        Me.GroupBox4.Controls.Add(Me.off_6)
        Me.GroupBox4.Controls.Add(Me.off_5)
        Me.GroupBox4.Controls.Add(Me.off_4)
        Me.GroupBox4.Controls.Add(Me.off_3)
        Me.GroupBox4.Controls.Add(Me.off_2)
        Me.GroupBox4.Controls.Add(Me.off_1)
        Me.GroupBox4.Location = New System.Drawing.Point(41, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(522, 109)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LEDS"
        '
        'on_8
        '
        Me.on_8.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_8.Location = New System.Drawing.Point(445, 31)
        Me.on_8.Name = "on_8"
        Me.on_8.Size = New System.Drawing.Size(52, 60)
        Me.on_8.TabIndex = 15
        Me.on_8.TabStop = False
        '
        'on_7
        '
        Me.on_7.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_7.Location = New System.Drawing.Point(387, 31)
        Me.on_7.Name = "on_7"
        Me.on_7.Size = New System.Drawing.Size(52, 60)
        Me.on_7.TabIndex = 14
        Me.on_7.TabStop = False
        '
        'on_6
        '
        Me.on_6.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_6.Location = New System.Drawing.Point(329, 31)
        Me.on_6.Name = "on_6"
        Me.on_6.Size = New System.Drawing.Size(52, 60)
        Me.on_6.TabIndex = 13
        Me.on_6.TabStop = False
        '
        'on_5
        '
        Me.on_5.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_5.Location = New System.Drawing.Point(271, 31)
        Me.on_5.Name = "on_5"
        Me.on_5.Size = New System.Drawing.Size(52, 60)
        Me.on_5.TabIndex = 12
        Me.on_5.TabStop = False
        '
        'on_4
        '
        Me.on_4.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_4.Location = New System.Drawing.Point(213, 31)
        Me.on_4.Name = "on_4"
        Me.on_4.Size = New System.Drawing.Size(52, 60)
        Me.on_4.TabIndex = 11
        Me.on_4.TabStop = False
        '
        'on_3
        '
        Me.on_3.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_3.Location = New System.Drawing.Point(155, 31)
        Me.on_3.Name = "on_3"
        Me.on_3.Size = New System.Drawing.Size(52, 60)
        Me.on_3.TabIndex = 10
        Me.on_3.TabStop = False
        '
        'on_2
        '
        Me.on_2.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_2.Location = New System.Drawing.Point(97, 31)
        Me.on_2.Name = "on_2"
        Me.on_2.Size = New System.Drawing.Size(52, 60)
        Me.on_2.TabIndex = 9
        Me.on_2.TabStop = False
        '
        'on_1
        '
        Me.on_1.Image = Global.Secuencias.My.Resources.Resources._ON
        Me.on_1.Location = New System.Drawing.Point(39, 31)
        Me.on_1.Name = "on_1"
        Me.on_1.Size = New System.Drawing.Size(52, 60)
        Me.on_1.TabIndex = 8
        Me.on_1.TabStop = False
        '
        'off_8
        '
        Me.off_8.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_8.Location = New System.Drawing.Point(445, 31)
        Me.off_8.Name = "off_8"
        Me.off_8.Size = New System.Drawing.Size(52, 60)
        Me.off_8.TabIndex = 7
        Me.off_8.TabStop = False
        '
        'off_7
        '
        Me.off_7.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_7.Location = New System.Drawing.Point(387, 31)
        Me.off_7.Name = "off_7"
        Me.off_7.Size = New System.Drawing.Size(52, 60)
        Me.off_7.TabIndex = 6
        Me.off_7.TabStop = False
        '
        'off_6
        '
        Me.off_6.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_6.Location = New System.Drawing.Point(329, 31)
        Me.off_6.Name = "off_6"
        Me.off_6.Size = New System.Drawing.Size(52, 60)
        Me.off_6.TabIndex = 5
        Me.off_6.TabStop = False
        '
        'off_5
        '
        Me.off_5.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_5.Location = New System.Drawing.Point(271, 31)
        Me.off_5.Name = "off_5"
        Me.off_5.Size = New System.Drawing.Size(52, 60)
        Me.off_5.TabIndex = 4
        Me.off_5.TabStop = False
        '
        'off_4
        '
        Me.off_4.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_4.Location = New System.Drawing.Point(213, 31)
        Me.off_4.Name = "off_4"
        Me.off_4.Size = New System.Drawing.Size(52, 60)
        Me.off_4.TabIndex = 3
        Me.off_4.TabStop = False
        '
        'off_3
        '
        Me.off_3.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_3.Location = New System.Drawing.Point(155, 31)
        Me.off_3.Name = "off_3"
        Me.off_3.Size = New System.Drawing.Size(52, 60)
        Me.off_3.TabIndex = 2
        Me.off_3.TabStop = False
        '
        'off_2
        '
        Me.off_2.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_2.Location = New System.Drawing.Point(97, 31)
        Me.off_2.Name = "off_2"
        Me.off_2.Size = New System.Drawing.Size(52, 60)
        Me.off_2.TabIndex = 1
        Me.off_2.TabStop = False
        '
        'off_1
        '
        Me.off_1.Image = Global.Secuencias.My.Resources.Resources.OFF
        Me.off_1.Location = New System.Drawing.Point(39, 31)
        Me.off_1.Name = "off_1"
        Me.off_1.Size = New System.Drawing.Size(52, 60)
        Me.off_1.TabIndex = 0
        Me.off_1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(693, 529)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Secuencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.on_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.on_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.off_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents B_off As Button
    Friend WithEvents B_on As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents B_sec_3 As Button
    Friend WithEvents B_sec_2 As Button
    Friend WithEvents B_sec_1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents B_vel_3 As Button
    Friend WithEvents B_vel_2 As Button
    Friend WithEvents B_vel_1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents off_1 As PictureBox
    Friend WithEvents off_8 As PictureBox
    Friend WithEvents off_7 As PictureBox
    Friend WithEvents off_6 As PictureBox
    Friend WithEvents off_5 As PictureBox
    Friend WithEvents off_4 As PictureBox
    Friend WithEvents off_3 As PictureBox
    Friend WithEvents off_2 As PictureBox
    Friend WithEvents on_1 As PictureBox
    Friend WithEvents on_8 As PictureBox
    Friend WithEvents on_7 As PictureBox
    Friend WithEvents on_6 As PictureBox
    Friend WithEvents on_5 As PictureBox
    Friend WithEvents on_4 As PictureBox
    Friend WithEvents on_3 As PictureBox
    Friend WithEvents on_2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
