Public Class Form1
    Dim num1, num2, num3, num4, total, average As Integer
    Private Sub Score1_TextChanged(sender As Object, e As EventArgs) Handles Score1.TextChanged
        Score1.MaxLength = 2
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Score2.TextChanged
        Score2.MaxLength = 2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Score1.Text = ""
        Score2.Text = ""
        Score3.Text = ""
        Score4.Text = ""
        TotalScore.Text = ""
        AverageScore.Text = ""
        DisplayGrade.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles AverageScore.TextChanged
        AverageScore.MaxLength = 6
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Score3.TextChanged
        Score3.MaxLength = 2
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Score4.TextChanged
        Score4.MaxLength = 2
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TotalScore.TextChanged
        TotalScore.MaxLength = 5

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Convert.ToInt32(Score1.Text)
        num2 = Convert.ToInt32(Score2.Text)
        num3 = Convert.ToInt32(Score3.Text)
        num4 = Convert.ToInt32(Score4.Text)

        total = num1 + num2 + num3 + num4
        average = total / 4

        TotalScore.Text = total
        AverageScore.Text = average

        Select Case average
            Case 0 To 40
                DisplayGrade.Text = "F"
            Case 41 To 45
                DisplayGrade.Text = "D"
            Case 46 To 50
                DisplayGrade.Text = "D+"
            Case 51 To 55
                DisplayGrade.Text = "C-"
            Case 56 To 60
                DisplayGrade.Text = "C"
            Case 61 To 65
                DisplayGrade.Text = "C+"
            Case 66 To 70
                DisplayGrade.Text = "B-"
            Case 71 To 75
                DisplayGrade.Text = "B"
            Case 76 To 80
                DisplayGrade.Text = "B+"
            Case 81 To 90
                DisplayGrade.Text = "A-"
            Case Is > 90
                DisplayGrade.Text = "A"
            Case Else
                DisplayGrade.Text = "X"
        End Select

    End Sub
End Class
