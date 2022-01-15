Public Class Form1
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    Dim fmtStr As String = "{0, 5}  {1, -5}" 'Two spaces after the
    '                                        first right curly bracket
    lstOutput.Items.Add("12345678901234567890")
    lstOutput.Items.Add(String.Format(fmtStr, 1, 2))

  End Sub
End Class
