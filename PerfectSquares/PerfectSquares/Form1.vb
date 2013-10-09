Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        
        Dim i As Integer = 1

        Do While (i <= 10)

            lstResult.Items.Add("The perfect square:" & i ^ 2)
            i += 1

        Loop



    End Sub
End Class
