Public Class Form2
    Private Sub ListCuvinte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCuvinte.SelectedIndexChanged
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class