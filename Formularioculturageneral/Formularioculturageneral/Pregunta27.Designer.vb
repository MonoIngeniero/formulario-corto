<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta27
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.lblincor = New System.Windows.Forms.Label()
        Me.lblcor = New System.Windows.Forms.Label()
        Me.btnsig = New System.Windows.Forms.Button()
        Me.btnval = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PREGUNTA 27"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "¿Qué significa ""gobierno federalista""?"
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 161)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE:"
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Location = New System.Drawing.Point(354, 110)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(280, 24)
        Me.rdo4.TabIndex = 5
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Un sistema de gobierno familiar"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Location = New System.Drawing.Point(355, 41)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(257, 24)
        Me.rdo3.TabIndex = 4
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "Poder dividido por territorios "
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(6, 110)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(342, 24)
        Me.rdo2.TabIndex = 3
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "El poder se centra en una sola persona"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(6, 41)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(227, 24)
        Me.rdo1.TabIndex = 2
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Un régimen de izquierda "
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'lblincor
        '
        Me.lblincor.AutoSize = True
        Me.lblincor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincor.ForeColor = System.Drawing.Color.Red
        Me.lblincor.Location = New System.Drawing.Point(218, 68)
        Me.lblincor.Name = "lblincor"
        Me.lblincor.Size = New System.Drawing.Size(155, 25)
        Me.lblincor.TabIndex = 1
        Me.lblincor.Text = "INCORRECTO"
        '
        'lblcor
        '
        Me.lblcor.AutoSize = True
        Me.lblcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcor.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblcor.Location = New System.Drawing.Point(239, 68)
        Me.lblcor.Name = "lblcor"
        Me.lblcor.Size = New System.Drawing.Size(134, 25)
        Me.lblcor.TabIndex = 0
        Me.lblcor.Text = "CORRECTO"
        '
        'btnsig
        '
        Me.btnsig.BackColor = System.Drawing.Color.Yellow
        Me.btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsig.Location = New System.Drawing.Point(304, 341)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(356, 58)
        Me.btnsig.TabIndex = 7
        Me.btnsig.Text = "SIGUIENTE PREGUNTA "
        Me.btnsig.UseVisualStyleBackColor = False
        '
        'btnval
        '
        Me.btnval.BackColor = System.Drawing.Color.Yellow
        Me.btnval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnval.Location = New System.Drawing.Point(22, 339)
        Me.btnval.Name = "btnval"
        Me.btnval.Size = New System.Drawing.Size(192, 62)
        Me.btnval.TabIndex = 6
        Me.btnval.Text = "VALIDAR"
        Me.btnval.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Formularioculturageneral.My.Resources.Resources.IMAGEN_27
        Me.PictureBox1.Location = New System.Drawing.Point(54, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Pregunta27
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(666, 415)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.btnval)
        Me.Name = "Pregunta27"
        Me.Text = "Pregunta27"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblincor As System.Windows.Forms.Label
    Friend WithEvents lblcor As System.Windows.Forms.Label
    Friend WithEvents btnsig As System.Windows.Forms.Button
    Friend WithEvents btnval As System.Windows.Forms.Button
End Class
