
Public Class Start
    Dim FullAnswer As String
    Dim FullWordAnswer As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        TextBox1.Visible = True
        Button3.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HelpMenu.Show()
    End Sub
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        Label1.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter a valid word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        FullWordAnswer = TextBox1.Text
        Dim Hangman As New Hangman(FullWordAnswer)
        Hangman.Show()
        Me.Hide()
    End Sub
End Class