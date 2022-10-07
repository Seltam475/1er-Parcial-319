Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim ascendente, descendente As String
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If (a >= b) And (a >= c) Then GoTo a_mayor Else GoTo bc_mayor
a_mayor:
        If b >= c Then GoTo cba Else GoTo bca
bc_mayor:
        If (b >= a) And (b >= c) Then GoTo b_mayor Else GoTo c_mayor
b_mayor:
        If a >= c Then GoTo cab Else GoTo acb
c_mayor:
        If a >= b Then GoTo bac Else GoTo abc
cba:
        ascendente = c.ToString + " — " + b.ToString + " — " + a.ToString
        descendente = a.ToString + " — " + b.ToString + " — " + c.ToString
        GoTo fin
bca:
        ascendente = b.ToString + " — " + c.ToString + " — " + a.ToString
        descendente = a.ToString + " — " + c.ToString + " — " + b.ToString
        GoTo fin
cab:
        ascendente = c.ToString + " — " + a.ToString + " — " + b.ToString
        descendente = b.ToString + " — " + a.ToString + " — " + c.ToString
        GoTo fin
acb:
        ascendente = a.ToString + " — " + c.ToString + " — " + b.ToString
        descendente = b.ToString + " — " + c.ToString + " — " + a.ToString
        GoTo fin
bac:
        ascendente = b.ToString + " — " + a.ToString + " — " + c.ToString
        descendente = c.ToString + " — " + a.ToString + " — " + b.ToString
        GoTo fin
abc:
        ascendente = a.ToString + " — " + b.ToString + " — " + c.ToString
        descendente = c.ToString + " — " + b.ToString + " — " + a.ToString
fin:
        TextBox4.Text = ascendente
        TextBox5.Text = descendente
    End Sub
End Class
