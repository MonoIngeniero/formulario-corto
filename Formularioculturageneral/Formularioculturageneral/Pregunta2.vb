
Public Class Pregunta2
    Private Sub Pregunta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblincor.Visible = False
        lblcor.Visible = False
        btnsig.Visible = False
    End Sub

    Private Sub btnval_Click(sender As Object, e As EventArgs) Handles btnval.Click
        If rdo3.Checked = True Then
            lblcor.Visible = True
            lblincor.Visible = False
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo2.Enabled = False
            rdo4.Enabled = False
            buenas = buenas + 1
        ElseIf rdo4.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo2.Enabled = False
            rdo3.Enabled = False
            malas = malas + 1
        ElseIf rdo2.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo3.Enabled = False
            rdo4.Enabled = False
            malas = malas + 1
        ElseIf rdo1.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo2.Enabled = False
            rdo3.Enabled = False
            rdo4.Enabled = False
            malas = malas + 1
        End If
    End Sub

    Private Sub btnsig_Click(sender As Object, e As EventArgs) Handles btnsig.Click
        Pregunta3.Show()
        Me.Hide()

    End Sub
End Class