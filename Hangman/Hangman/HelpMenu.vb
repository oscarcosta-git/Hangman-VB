Public Class HelpMenu
    Dim Hints As Boolean
    Dim StateDebug As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Start.Show()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            StateDebug = True
        Else
            StateDebug = False
        End If
        Dim Hangman As New Hangman(StateDebug)
    End Sub
End Class