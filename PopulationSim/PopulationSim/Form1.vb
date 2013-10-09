Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim Year As Integer
        Dim Pop As Double

        'Population in millions'

        Year = 2012
        Pop = 7000

        Do While (Pop > 6)
            Year = Year - 50
            Pop = Pop / 2

        Loop

        MessageBox.Show("The year is " & Year)

    End Sub
End Class
