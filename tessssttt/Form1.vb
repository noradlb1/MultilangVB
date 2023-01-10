Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then updatelanguge(RadioButton1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then updatelanguge(RadioButton2)
    End Sub
    Private Sub updatelanguge(ByVal radio As RadioButton)
        Select Case radio.Name
            Case "RadioButton1"
                Label1.Text = My.Resources.Resource1.Label1
                Label2.Text = My.Resources.Resource1.Label2
            Case "RadioButton2"
                Label1.Text = My.Resources.Resource2.Label1
                Label2.Text = My.Resources.Resource2.Label2
        End Select
    End Sub
End Class
