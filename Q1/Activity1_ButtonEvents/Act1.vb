Public Class Act1
    Private Sub PressMeBtn_Click(sender As Object, e As EventArgs) Handles PressMeBtn.Click ' Button Event Clicked
        DisplayTextBox.TextAlign = HorizontalAlignment.Center ' Sets the alignment to Center
        DisplayTextBox.ForeColor = Color.Green ' Sets the color to Green
        ' Sets the text to the following
        DisplayTextBox.Text = "Once upon a time, natulog ako tapos nagising tapos kumain tapos nagtoothbrush tapos naligo tapos pumunta sa school tapos nag aral tapos umuwi tapos nagcode tapos natulog."
    End Sub

End Class
