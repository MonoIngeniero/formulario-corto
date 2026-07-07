<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultado
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
        Me.btnres = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnres
        '
        Me.btnres.BackColor = System.Drawing.Color.Fuchsia
        Me.btnres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnres.ForeColor = System.Drawing.Color.Black
        Me.btnres.Location = New System.Drawing.Point(75, 66)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(264, 132)
        Me.btnres.TabIndex = 0
        Me.btnres.Text = "RESULTADO"
        Me.btnres.UseVisualStyleBackColor = False
        '
        'Resultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 263)
        Me.Controls.Add(Me.btnres)
        Me.Name = "Resultado"
        Me.Text = "Resultado"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnres As System.Windows.Forms.Button
End Class
