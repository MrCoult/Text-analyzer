Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textul As String
        textul = TextBox2.Text

        Dim cuvinte As String()
        cuvinte = textul.Split((" .,:;!?()/" + vbNewLine).ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        Dim propozitii As String()
        propozitii = textul.Split((".!?" + vbNewLine).ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        Form2.ListPropozitii.Items.Clear()
        For Each prop In propozitii
            Form2.ListPropozitii.Items.Add(prop)

        Next

        Dim cuvlung As String = ""

        Form2.ListCuvinte.Items.Clear()
        For Each cuvant In cuvinte
            Form2.ListCuvinte.Items.Add(cuvant)
            If Len(cuvant) > Len(cuvlung) Then cuvlung = cuvant

        Next

        Form2.TextBox1.Text = "Textul contine " + cuvinte.Count.ToString() + " cuvinte" + vbNewLine + "Cel mai lung cuvant este " + vbNewLine + cuvlung + vbNewLine + "Textul contine " + propozitii.Count.ToString() + " propozitii"

        Me.Hide()
        Form2.ShowDialog()

    End Sub
End Class
