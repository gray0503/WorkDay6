Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim x As Integer

        Do While (x <= 10)
            lstResult.Items.Add("The perfect square: " & x ^ 2)
            x = x + 1
        Loop

    End Sub
End Class
