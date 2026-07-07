<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta4
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.Lblcor = New System.Windows.Forms.Label()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.btnval = New System.Windows.Forms.Button()
        Me.btnsig = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PREGUNTA 4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Que estudia la cartografía? "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Formularioculturageneral.My.Resources.Resources.IMAGEN_4
        Me.PictureBox1.Location = New System.Drawing.Point(52, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblinc)
        Me.GroupBox1.Controls.Add(Me.Lblcor)
        Me.GroupBox1.Controls.Add(Me.rdo4)
        Me.GroupBox1.Controls.Add(Me.rdo3)
        Me.GroupBox1.Controls.Add(Me.rdo2)
        Me.GroupBox1.Controls.Add(Me.rdo1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 131)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE:"
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinc.ForeColor = System.Drawing.Color.Red
        Me.lblinc.Location = New System.Drawing.Point(210, 54)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(145, 24)
        Me.lblinc.TabIndex = 5
        Me.lblinc.Text = "INCORRECTO"
        '
        'Lblcor
        '
        Me.Lblcor.AutoSize = True
        Me.Lblcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcor.ForeColor = System.Drawing.Color.Green
        Me.Lblcor.Location = New System.Drawing.Point(230, 54)
        Me.Lblcor.Name = "Lblcor"
        Me.Lblcor.Size = New System.Drawing.Size(125, 24)
        Me.Lblcor.TabIndex = 4
        Me.Lblcor.Text = "CORRECTO"
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo4.Location = New System.Drawing.Point(393, 83)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(89, 28)
        Me.rdo4.TabIndex = 3
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Mapas"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo3.Location = New System.Drawing.Point(393, 38)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(117, 28)
        Me.rdo3.TabIndex = 2
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "Cartones "
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo2.Location = New System.Drawing.Point(33, 83)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(133, 28)
        Me.rdo2.TabIndex = 1
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "Las alturas "
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo1.Location = New System.Drawing.Point(33, 34)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(85, 28)
        Me.rdo1.TabIndex = 0
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Mares"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'btnval
        '
        Me.btnval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnval.Location = New System.Drawing.Point(36, 370)
        Me.btnval.Name = "btnval"
        Me.btnval.Size = New System.Drawing.Size(209, 57)
        Me.btnval.TabIndex = 4
        Me.btnval.Text = "VALIDAR"
        Me.btnval.UseVisualStyleBackColor = False
        '
        'btnsig
        '
        Me.btnsig.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsig.Location = New System.Drawing.Point(323, 370)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(323, 55)
        Me.btnsig.TabIndex = 5
        Me.btnsig.Text = "SIGUIENTE PREGUNTA "
        Me.btnsig.UseVisualStyleBackColor = False
        '
        'Pregunta4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 443)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.btnval)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pregunta4"
        Me.Text = "Pregunta4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnval As System.Windows.Forms.Button
    Friend WithEvents btnsig As System.Windows.Forms.Button
    Friend WithEvents lblinc As System.Windows.Forms.Label
    Friend WithEvents Lblcor As System.Windows.Forms.Label
End Class
