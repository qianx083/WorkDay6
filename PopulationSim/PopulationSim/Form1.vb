Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim curyear As Integer
        Dim pop As Double
        curyear = 2012
        pop = 7000

        Do While (pop > 6)

            curyear = curyear - 50
            pop = pop / 2

        Loop
        MessageBox.Show("This year is " & curyear, "Result")

    End Sub
End Class
