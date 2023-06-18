Public Class Form1

    'Fields
    Private result As Double = 0
    Private operation As String = String.Empty
    Private fstNum, secNum As String
    Private enterValue As Boolean = False


    Private Sub btnMathOperation_Click(sender As Object, e As EventArgs) Handles btnDivision.Click, btnSubtract.Click, btnMultiply.Click, btnAdd.Click
        If result <> 0 Then
            btnEquals.PerformClick()
        Else
            result = Double.Parse(txtDisplay1.Text)
        End If
        Dim button As Button = DirectCast(sender, Button)
        operation = button.Text
        enterValue = True
        If txtDisplay1.Text <> "0" Then
            fstNum = $"{result} {operation}"
            txtDisplay2.Text = fstNum
            txtDisplay1.Text = String.Empty
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secNum = txtDisplay1.Text
        txtDisplay2.Text = $"{txtDisplay2.Text} {txtDisplay1.Text}="

        ' Handle division by zero error
        If operation = "÷" AndAlso Double.Parse(txtDisplay1.Text) = 0 Then
            txtDisplay1.Text = "Error"
        Else
            Dim inputNum As Double

            If Double.TryParse(txtDisplay1.Text, inputNum) Then
                Select Case operation
                    Case "+"
                        txtDisplay1.Text = (result + inputNum).ToString()
                        RTBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {txtDisplay1.Text}{vbCrLf}")
                    Case "-"
                        txtDisplay1.Text = (result - inputNum).ToString()
                        RTBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {txtDisplay1.Text}{vbCrLf}")
                    Case "x"
                        txtDisplay1.Text = (result * inputNum).ToString()
                        RTBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {txtDisplay1.Text}{vbCrLf}")
                    Case "÷"
                        txtDisplay1.Text = (result / inputNum).ToString()
                        RTBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {txtDisplay1.Text}{vbCrLf}")
                    Case Else
                        txtDisplay2.Text = $"{txtDisplay1.Text} = "
                End Select

                result = inputNum
                operation = String.Empty
                fstNum = String.Empty
            Else
                txtDisplay1.Text = "Error"
            End If
        End If
    End Sub



    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnlHistory.Height = If(pnlHistory.Height = 5, 345, 5)
    End Sub

    Private Sub btnClearHistory_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        RTBoxDisplayHistory.Clear()
        If RTBoxDisplayHistory.Text = String.Empty Then
            RTBoxDisplayHistory.Text = "There's no history yet."
        End If
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtDisplay1.Text.Length > 0 Then
            txtDisplay1.Text = txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1, 1)
        End If
        If txtDisplay1.Text = String.Empty Then
            txtDisplay1.Text = "0"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay1.Text = "0"
        txtDisplay2.Text = String.Empty
        result = 0
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay1.Text = "0"
    End Sub

    Private Sub btnOperations_Click(sender As Object, e As EventArgs) Handles btnPercent.Click, btnSquare.Click, btnX2.Click, btn1X.Click, btnPM.Click
        Dim button As ArtanButton = DirectCast(sender, ArtanButton)
        operation = button.Text
        Dim input As Double
        If Double.TryParse(txtDisplay1.Text, input) Then
            Select Case operation
                Case "√x"
                    txtDisplay2.Text = $"√({txtDisplay1.Text})"
                    txtDisplay1.Text = Math.Sqrt(input).ToString()
                Case "^2"
                    txtDisplay2.Text = $"({txtDisplay1.Text})^2"
                    txtDisplay1.Text = (input * input).ToString()
                Case "⅟x"
                    txtDisplay2.Text = $"⅟({txtDisplay1.Text})"
                    txtDisplay1.Text = (1 / input).ToString()
                Case "%"
                    txtDisplay2.Text = $"%({txtDisplay1.Text})"
                    txtDisplay1.Text = (input / 100).ToString()
                Case "±"
                    txtDisplay1.Text = (-input).ToString()
                Case Else
                    Exit Select
            End Select
            RTBoxDisplayHistory.AppendText($"{txtDisplay2.Text}{txtDisplay1.Text} = {txtDisplay1.Text}{vbCrLf}")
        Else
            MessageBox.Show("Invalid input value. Please enter a valid numeric value.")
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btn6.Click, btn5.Click, btn4.Click, btn9.Click, btn8.Click, btn7.Click, btnDecimal.Click, btn0.Click, btn3.Click, btn2.Click, btn1.Click
        If txtDisplay1.Text = "0" OrElse enterValue Then
            txtDisplay1.Text = String.Empty
            enterValue = False
        End If
        Dim button As Button = DirectCast(sender, Button)
        If button.Text = "." Then
            If Not txtDisplay1.Text.Contains(".") Then
                txtDisplay1.Text += button.Text
            End If
        Else
            txtDisplay1.Text += button.Text
        End If
    End Sub

End Class
