Public Class Menu

    Private Sub Mn_Click(sender As Object, e As EventArgs) Handles Mn.Click
        FMetodos.Show()
        Me.Hide()
    End Sub

    Private Sub Gj_Click(sender As Object, e As EventArgs) Handles Gj.Click
        FGauss.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class