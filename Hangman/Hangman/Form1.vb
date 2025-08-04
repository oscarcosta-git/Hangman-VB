Imports System.Diagnostics
Imports System.Windows.Forms.AxHost

Public Class Hangman
    Dim i As Integer = 1
    Dim TotalGuess As Integer = 0
    Dim PictureNumber As Integer = 0
    Dim LetterPosition
    Dim InputLetter As String
    Dim FullAnswer As String
    Dim StringOutput As String = ""
    Dim TempWord As String
    Dim LettersCount
    Dim Sentences(20) As Char
    Dim CanContinueGuess As Boolean = True
    Dim GuessCorrect As Boolean = False
    Dim ResetGuessList As Boolean = True
    Dim ResetOutputLabel As Boolean = False
    Dim GameOver As Boolean = False
    Dim WrongGuess As Boolean = False
    Dim DebugBool As Boolean

    Public Sub New(ByVal FullWordAnswer As String)
        InitializeComponent()
        FullAnswer = FullWordAnswer
    End Sub
    Public Sub New(ByVal StateDebug As Boolean)
        InitializeComponent()
        DebugBool = StateDebug
    End Sub

    Sub CreateGuess()
        GameOver = False
        OutputLabel.Visible = True
        StatusLabel.Text = ""
        WrongGuess = True
        ResetGuessList = True
        PictureNumber = 0
        TotalGuess = 0

        If ResetOutputLabel Then
            StringOutput = ""
            OutputLabel.Text = ""
            TempWord = ""
            ResetOutputLabel = False
        End If

        HangmanPicture.ImageLocation = "https://imgur.com/L5GJ9kT.png"
        LettersCount = FullAnswer.Length
        DebuggingLabel.Text = FullAnswer
        For i = 1 To LettersCount
            Sentences(i) = Mid$(FullAnswer, i, 1)
        Next i

        StringOutput = StringOutput.PadLeft(LettersCount, "-")
        OutputLabel.Text = StringOutput
        TempWord = FullAnswer
        GuessList()
    End Sub


    Sub GuessList()
        If WrongGuess Then
            If ResetGuessList Then
                GuessedAlready.Text = ""
                ResetGuessList = False
                GuessedAlready.Text = GuessedAlready.Text & " "
                WrongGuess = False
            Else
                GuessedAlready.Text = GuessedAlready.Text & " " & InputLetter
                WrongGuess = False
            End If
        End If
    End Sub

    Sub CheckGuess()
        CanContinueGuess = True
        For i = 1 To LettersCount
            If TotalGuess = 8 Then
                HangmanPicture.ImageLocation = "https://mystickermania.com/cdn/stickers/noob-pack/game-over-glitch-effect-512x512.png"
                StatusLabel.Text = "You Lost!"

                OutputLabel.Text = "The word was " & LCase(FullAnswer)
                CanContinueGuess = False
                GameOver = True
            ElseIf StringOutput = FullAnswer Then
                StatusLabel.Text = "You Win!"
                HangmanPicture.ImageLocation = "https://www.pngkit.com/png/full/972-9729757_you-win-comic-speech-bubble-cartoon-game-assets.png"
                CanContinueGuess = False
                GameOver = True
            Else
                If CanContinueGuess Then
                    If InputLetter = Sentences(i) Then
                        If FullAnswer.Contains(InputLetter) Then
                            StatusLabel.Text = "Correct"
                            GuessCorrect = True
                            CanContinueGuess = False
                            For LetterPosition = 0 To FullAnswer.Length - 1
                                If FullAnswer.Chars(LetterPosition) = InputLetter Then
                                    If StringOutput = FullAnswer Then
                                        StatusLabel.Text = "You Win!"
                                        HangmanPicture.ImageLocation = "https://www.pngkit.com/png/full/972-9729757_you-win-comic-speech-bubble-cartoon-game-assets.png"
                                        CanContinueGuess = False
                                        GameOver = True
                                    Else
                                        If Not GameOver Then
                                            TempWord = StringOutput.Remove(LetterPosition, 1)
                                            StringOutput = TempWord.Insert(LetterPosition, InputLetter)
                                            OutputLabel.Text = StringOutput
                                            ResetOutputLabel = True
                                            If StringOutput = FullAnswer Then
                                                StatusLabel.Text = "You Win!"
                                                HangmanPicture.ImageLocation = "https://www.pngkit.com/png/full/972-9729757_you-win-comic-speech-bubble-cartoon-game-assets.png"
                                                CanContinueGuess = False
                                                GameOver = True
                                            End If
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    Else
                        If Not FullAnswer.Contains(InputLetter) Then
                            GuessCorrect = False
                            WrongGuess = True
                            StatusLabel.Text = "Incorrect"
                            If PictureNumber >= 8 Then
                                HangmanPicture.ImageLocation = "https://mystickermania.com/cdn/stickers/noob-pack/game-over-glitch-effect-512x512.png"
                                StatusLabel.Text = "You Lost!"

                                OutputLabel.Text = "The word was " & LCase(FullAnswer)
                                GameOver = True
                            Else
                                If GuessCorrect = False Then
                                    If PictureNumber = 0 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/jCUtxM5.png"
                                        PictureNumber = 1
                                    ElseIf PictureNumber = 2 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/sZtPuiP.png"
                                    ElseIf PictureNumber = 3 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/OaELkzV.png"
                                    ElseIf PictureNumber = 4 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/srhBJO7.png"
                                    ElseIf PictureNumber = 5 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/npXTjGI.png"
                                    ElseIf PictureNumber = 6 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/5MhKrFt.png"
                                    ElseIf PictureNumber = 7 Then
                                        HangmanPicture.ImageLocation = "https://imgur.com/HpfSe9v.png"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next i

        If CanContinueGuess Then
            TotalGuess = TotalGuess + 1
            PictureNumber = PictureNumber + 1
        End If
        GuessList()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DebugBool Then
            DebuggingLabel.Visible = True
            StatusLabel.Text = LettersCount
        Else
            DebuggingLabel.Visible = False
        End If
        CreateGuess()
    End Sub

    Private Sub AButton_Click(sender As Object, e As EventArgs) Handles AButton.Click
        InputLetter = "A"
        CheckGuess()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles ZButton.Click
        InputLetter = "Z"
        CheckGuess()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles YButton.Click
        InputLetter = "Y"
        CheckGuess()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles XButton.Click
        InputLetter = "X"
        CheckGuess()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles WButton.Click
        InputLetter = "W"
        CheckGuess()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles VButton.Click
        InputLetter = "V"
        CheckGuess()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles TButton.Click
        InputLetter = "T"
        CheckGuess()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles UButton.Click
        InputLetter = "U"
        CheckGuess()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles SButton.Click
        InputLetter = "S"
        CheckGuess()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles MButton.Click
        InputLetter = "M"
        CheckGuess()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles NButton.Click
        InputLetter = "N"
        CheckGuess()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles OButton.Click
        InputLetter = "O"
        CheckGuess()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles PButton.Click
        InputLetter = "P"
        CheckGuess()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles QButton.Click
        InputLetter = "Q"
        CheckGuess()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles RButton.Click
        InputLetter = "R"
        CheckGuess()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles LButton.Click
        InputLetter = "L"
        CheckGuess()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles KButton.Click
        InputLetter = "K"
        CheckGuess()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles IButton.Click
        InputLetter = "I"
        CheckGuess()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles JButton.Click
        InputLetter = "J"
        CheckGuess()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles HButton.Click
        InputLetter = "H"
        CheckGuess()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles GButton.Click
        InputLetter = "G"
        CheckGuess()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BButton.Click
        InputLetter = "B"
        CheckGuess()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CButton.Click
        InputLetter = "C"
        CheckGuess()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DButton.Click
        InputLetter = "D"
        CheckGuess()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EButton.Click
        InputLetter = "E"
        CheckGuess()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles FButton.Click
        InputLetter = "F"
        CheckGuess()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles MenuButton.Click
        Me.Hide()
        Start.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ResetButton.Click
        CreateGuess()
    End Sub
End Class