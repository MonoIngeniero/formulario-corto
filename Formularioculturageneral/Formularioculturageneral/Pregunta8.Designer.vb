<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnval = New System.Windows.Forms.Button()
        Me.btnsig = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.lblcor = New System.Windows.Forms.Label()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PREGUNTA 8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(598, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Que nombre recibe el instrumento utilizado para ver astros?"
        '
        'btnval
        '
        Me.btnval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnval.Location = New System.Drawing.Point(40, 356)
        Me.btnval.Name = "btnval"
        Me.btnval.Size = New System.Drawing.Size(199, 57)
        Me.btnval.TabIndex = 2
        Me.btnval.Text = "VALIDAR"
        Me.btnval.UseVisualStyleBackColor = False
        '
        'btnsig
        '
        Me.btnsig.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsig.Location = New System.Drawing.Point(291, 357)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(300, 56)
        Me.btnsig.TabIndex = 3
        Me.btnsig.Text = "SIGUIENTE PREGUNTA "
        Me.btnsig.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblinc)
        Me.GroupBox1.Controls.Add(Me.lblcor)
        Me.GroupBox1.Controls.Add(Me.rdo4)
        Me.GroupBox1.Controls.Add(Me.rdo3)
        Me.GroupBox1.Controls.Add(Me.rdo2)
        Me.GroupBox1.Controls.Add(Me.rdo1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 139)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE:"
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinc.ForeColor = System.Drawing.Color.Red
        Me.lblinc.Location = New System.Drawing.Point(160, 64)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(155, 25)
        Me.lblinc.TabIndex = 5
        Me.lblinc.Text = "INCORRECTO"
        '
        'lblcor
        '
        Me.lblcor.AutoSize = True
        Me.lblcor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcor.ForeColor = System.Drawing.Color.Green
        Me.lblcor.Location = New System.Drawing.Point(181, 64)
        Me.lblcor.Name = "lblcor"
        Me.lblcor.Size = New System.Drawing.Size(134, 25)
        Me.lblcor.TabIndex = 4
        Me.lblcor.Text = "CORRECTO"
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Location = New System.Drawing.Point(390, 106)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(113, 24)
        Me.rdo4.TabIndex = 3
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Telescopio"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Location = New System.Drawing.Point(390, 36)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(119, 24)
        Me.rdo3.TabIndex = 2
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "Observador"
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(16, 106)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(122, 24)
        Me.rdo2.TabIndex = 1
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "Microscopio"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(16, 36)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(67, 24)
        Me.rdo1.TabIndex = 0
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Lupa"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Formularioculturageneral.My.Resources.Resources.IMAGEN8
        Me.PictureBox1.Location = New System.Drawing.Point(56, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Pregunta8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.btnval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pregunta8"
        Me.Text = "Pregunta8"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnval As System.Windows.Forms.Button
    Friend WithEvents btnsig As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblinc As System.Windows.Forms.Label
    Friend WithEvents lblcor As System.Windows.Forms.Label
    Friend WithEvents rdo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo1 As System.Windows.Forms.RadioButton
End Class
