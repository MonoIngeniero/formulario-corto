Public Class Pregunta26

    Private Sub Pregunta26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcor.Visible = False
        lblincor.Visible = False
        btnsig.Visible = False
    End Sub

    Private Sub btnval_Click(sender As Object, e As EventArgs) Handles btnval.Click
        If rdo1.Checked = True Then
            lblcor.Visible = True
            lblincor.Visible = False
            btnsig.Visible = True
            rdo2.Enabled = False
            rdo3.Enabled = False
            rdo4.Enabled = False
            buenas = buenas + 1
        ElseIf rdo2.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo3.Enabled = False
            rdo4.Enabled = False
            malas = malas + 1
        ElseIf rdo3.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo2.Enabled = False
            rdo4.Enabled = False
            malas = malas + 1
        ElseIf rdo4.Checked = True Then
            lblcor.Visible = False
            lblincor.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo3.Enabled = False
            rdo2.Enabled = False
            malas = malas + 1
        End If
    End Sub

    Private Sub btnsig_Click(sender As Object, e As EventArgs) Handles btnsig.Click
        Pregunta27.Show()
        Me.Hide()

    End Sub
End Class