<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta25
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcor = New System.Windows.Forms.Label()
        Me.lblincor = New System.Windows.Forms.Label()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.btnval = New System.Windows.Forms.Button()
        Me.btnsig = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo4)
        Me.GroupBox1.Controls.Add(Me.rdo3)
        Me.GroupBox1.Controls.Add(Me.rdo2)
        Me.GroupBox1.Controls.Add(Me.rdo1)
        Me.GroupBox1.Controls.Add(Me.lblincor)
        Me.GroupBox1.Controls.Add(Me.lblcor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PREGUNTA 25"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Quien escribió ""100 años de Soledad""?"
        '
        'lblcor
        '
        Me.lblcor.AutoSize = True
        Me.lblcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcor.ForeColor = System.Drawing.Color.Lime
        Me.lblcor.Location = New System.Drawing.Point(144, 54)
        Me.lblcor.Name = "lblcor"
        Me.lblcor.Size = New System.Drawing.Size(134, 25)
        Me.lblcor.TabIndex = 0
        Me.lblcor.Text = "CORRECTO"
        '
        'lblincor
        '
        Me.lblincor.AutoSize = True
        Me.lblincor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincor.ForeColor = System.Drawing.Color.Red
        Me.lblincor.Location = New System.Drawing.Point(123, 54)
        Me.lblincor.Name = "lblincor"
        Me.lblincor.Size = New System.Drawing.Size(155, 25)
        Me.lblincor.TabIndex = 1
        Me.lblincor.Text = "INCORRECTO"
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(18, 34)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(90, 24)
        Me.rdo1.TabIndex = 2
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Homero"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(18, 93)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(125, 24)
        Me.rdo2.TabIndex = 3
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "San Agustín"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Location = New System.Drawing.Point(316, 34)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(222, 24)
        Me.rdo3.TabIndex = 4
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "Gabriel García Márquez "
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Location = New System.Drawing.Point(283, 93)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(276, 24)
        Me.rdo4.TabIndex = 5
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Miguel de Cervantes Saavedra "
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'btnval
        '
        Me.btnval.BackColor = System.Drawing.Color.Wheat
        Me.btnval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnval.Location = New System.Drawing.Point(12, 342)
        Me.btnval.Name = "btnval"
        Me.btnval.Size = New System.Drawing.Size(218, 59)
        Me.btnval.TabIndex = 4
        Me.btnval.Text = "VALIDAR"
        Me.btnval.UseVisualStyleBackColor = False
        '
        'btnsig
        '
        Me.btnsig.BackColor = System.Drawing.Color.Wheat
        Me.btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsig.Location = New System.Drawing.Point(262, 343)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(320, 58)
        Me.btnsig.TabIndex = 5
        Me.btnsig.Text = "SIGUIENTE PREGUNTA"
        Me.btnsig.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Formularioculturageneral.My.Resources.Resources.IMAGEN_25
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Pregunta25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(600, 423)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.btnval)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pregunta25"
        Me.Text = "Pregunta25"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblincor As System.Windows.Forms.Label
    Friend WithEvents lblcor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnval As System.Windows.Forms.Button
    Friend WithEvents btnsig As System.Windows.Forms.Button
End Class
