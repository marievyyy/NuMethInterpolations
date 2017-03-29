Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x(4) As Object
        Dim fx(4) As Object
        Dim dd1(3) As Double
        Dim dd2(2) As Double
        Dim dd3(1) As Double
        Dim dd4 As Double

        x(0) = TextBox1.Text
        x(1) = TextBox2.Text
        x(2) = TextBox3.Text
        x(3) = TextBox4.Text
        x(4) = TextBox5.Text
        fx(0) = TextBox6.Text
        fx(1) = TextBox7.Text
        fx(2) = TextBox8.Text
        fx(3) = TextBox9.Text
        fx(4) = TextBox10.Text

        If IsNumeric(fx(1)) = True And IsNumeric(x(1)) = True And IsNumeric(fx(2)) = True And IsNumeric(x(2)) = True And IsNumeric(fx(3)) = True And IsNumeric(x(3)) = True And IsNumeric(fx(4)) = True And IsNumeric(x(4)) = True Then
            If x(0) > -1000 And x(0) <> 0 And x(0) < 1000 And fx(0) > -1000 And fx(0) <> 0 And fx(0) < 1000 And x(1) > -1000 And x(1) <> 0 And x(1) < 1000 And fx(1) > -1000 And fx(1) <> 0 And fx(1) < 1000 And x(2) > -1000 And x(2) <> 0 And x(2) < 1000 And fx(2) > -1000 And fx(2) <> 0 And fx(2) < 1000 And x(3) > -1000 And x(3) <> 0 And x(3) < 1000 And fx(3) > -1000 And fx(3) <> 0 And fx(3) < 1000 And x(4) > -1000 And x(4) <> 0 And x(4) < 1000 And fx(4) > -1000 And fx(4) <> 0 And fx(4) < 1000 Then
                MessageBox.Show("Computing...")
                For index As Integer = 0 To 3 Step 1
                    dd1(index) = (fx(index) - fx(index + 1)) / (x(index) - x(index + 1))
                Next
                Label1.Text = dd1(0)
                Label2.Text = dd1(1)
                Label9.Text = dd1(2)
                Label10.Text = dd1(3)
                For index2 As Integer = 0 To 2 Step 1
                    dd2(index2) = (dd1(index2) - dd1(index2 + 1)) / (x(index2) - x(index2 + 2))
                Next
                Label12.Text = dd2(0)
                Label13.Text = dd2(1)
                Label14.Text = dd2(2)
                For index3 As Integer = 0 To 1 Step 1
                    dd3(index3) = (dd2(index3) - dd2(index3 + 1)) / (x(index3) - x(index3 + 3))
                Next
                Label17.Text = dd3(0)
                Label18.Text = dd3(1)
                dd4 = dd3(0) - dd3(1)
                Label22.Text = dd4
            Else
                MessageBox.Show("Value Not Exceed to -1000 or 1000 and not equal to 0! ")
            End If
        Else
            MessageBox.Show("Accept Number Only!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        Label1.Text = "0"
        Label2.Text = "0"
        Label9.Text = "0"
        Label10.Text = "0"
        Label12.Text = "0"
        Label13.Text = "0"
        Label14.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label22.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form0.Show()
        Me.Close()
    End Sub
End Class