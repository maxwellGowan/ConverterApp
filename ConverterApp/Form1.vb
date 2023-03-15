Public Class Form1
    Private Sub txtEntry_TextChanged(sender As Object, e As EventArgs) Handles txtEntry.TextChanged

    End Sub

    Private Sub rbInchesToMeters_CheckedChanged(sender As Object, e As EventArgs) Handles rbInchesToMeters.CheckedChanged

    End Sub

    Private Sub rbMeterstoInches_CheckedChanged(sender As Object, e As EventArgs) Handles rbMeterstoInches.CheckedChanged

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Check if the text box is empty or contains invalid input
        If String.IsNullOrEmpty(txtEntry.Text) OrElse Not Double.TryParse(txtEntry.Text, Nothing) Then
            MessageBox.Show("Please enter a valid measurement value.")
        Else
            Dim measurement As Double = Double.Parse(txtEntry.Text)
            If measurement < 0 Then
                ' Negative value entered
                MessageBox.Show("Please enter a positive measurement value.")
            ElseIf rbInchesToMeters.Checked Then
                ' Convert Inches to Meters
                Dim meters As Double = measurement / 39.37
                lblResult.Text = $"{measurement} inches is {meters} meters"
                lblResult.Visible = True
            ElseIf rbMeterstoInches.Checked Then
                ' Convert Meters to Inches
                Dim inches As Double = measurement * 39.37
                lblResult.Text = $"{measurement} meters is {inches} inches"
                lblResult.Visible = True
            Else
                ' No RadioButton selected
                MessageBox.Show("Please select a conversion option.")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text box and result label
        lblResult.Text = ""
        txtEntry.Text = ""

        ' Set the Inches to Meters radio button as the default option
        rbInchesToMeters.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Visible = False
    End Sub

    Private Sub lblEntry_Click(sender As Object, e As EventArgs) Handles lblEntry.Click

    End Sub

    Private Sub grpSelection_Enter(sender As Object, e As EventArgs) Handles grpSelection.Enter

    End Sub
End Class
