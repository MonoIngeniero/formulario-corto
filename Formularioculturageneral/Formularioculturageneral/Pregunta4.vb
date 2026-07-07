Public Class Pregunta4

    Private Sub Pregunta4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblcor.Visible = False
        lblinc.Visible = False
        btnsig.Visible = False

    End Sub

    Private Sub btnval_Click(sender As Object, e As EventArgs) Handles btnval.Click
        If rdo4.Checked = True Then
            Lblcor.Visible = True
            lblinc.Visible = False
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo2.Enabled = False
            rdo3.Enabled = False
            buenas = buenas + 1
        ElseIf rdo3.Checked = True Then
            Lblcor.Visible = False
            lblinc.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo2.Enabled = False
            rdo4.Enabled = False
            malas = malas + 1
        ElseIf rdo2.Checked = True Then
            Lblcor.Visible = False
            lblinc.Visible = True
            btnsig.Visible = True
            rdo1.Enabled = False
            rdo4.Enabled = False
            rdo3.Enabled = False
            malas = malas + 1
        ElseIf rdo1.Checked = True Then
            Lblcor.Visible = False
            lblinc.Visible = True
            btnsig.Visible = True
            rdo2.Enabled = False
            rdo4.Enabled = False
            rdo3.Enabled = False
            malas = malas + 1
        End If
    End Sub

    Private Sub btnsig_Click(sender As Object, e As EventArgs) Handles btnsig.Click
        Pregunta5.Show()
        Me.Hide()

    End Sub
End Class