Imports System.Text

Public Class Form1
    Dim rS As String
    Dim r As New Random
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strBuff As New String(T1.Text.ToCharArray.OrderBy(Function(c) r.NextDouble).ToArray)
        Dim AlphaNumericString As String = Guid.NewGuid.ToString
        AlphaNumericString = AlphaNumericString.Replace("-", "")
        rS = AlphaNumericString.ToUpper + AlphaNumericString
        T1.Text = rS
        T1.Text = New String(T1.Text.ToCharArray.OrderBy(Function(c) r.NextDouble).ToArray)

    End Sub
End Class
