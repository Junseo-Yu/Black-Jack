
Public Class Form1
    Dim intplayercard1 As Integer = 99
    Dim intplayercard2 As Integer = 99
    Dim intplayercard3 As Integer = 99
    Dim intplayercard4 As Integer = 99
    Dim intplayercard5 As Integer = 99
    Dim intdealercard1 As Integer = 99
    Dim intdealercard2 As Integer = 99
    Dim intdealercard3 As Integer = 99
    Dim intdealercard4 As Integer = 99
    Dim intdealercard5 As Integer = 99

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Dim generator As New Random
        Dim Randomnumbers As Integer = 0
        Dim countofcards As Integer = 0

        Do While countofcards < 1k0
            Randomnumbers = generator.Next(0, 51)
            Select Case Randomnumbers
                Case intplayercard1, intplayercard2, intplayercard3, intplayercard4, intplayercard5, intdealercard1, intdealercard2, intdealercard3, intdealercard4, intdealercard5

                Case Else
                    Select Case countofcards
                        Case 0
                            intplayercard1 = Randomnumbers
                        Case 1
                            intplayercard2 = Randomnumbers
                        Case 2
                            intplayercard3 = Randomnumbers
                        Case 3
                            intplayercard4 = Randomnumbers
                        Case 4
                            intplayercard5 = Randomnumbers
                        Case 5
                            intdealercard1 = Randomnumbers
                        Case 6
                            intdealercard2 = Randomnumbers
                        Case 7
                            intdealercard3 = Randomnumbers
                        Case 8
                            intdealercard4 = Randomnumbers
                        Case 9
                            intdealercard5 = Randomnumbers
                    End Select
                    countofcards += 1
            End Select
        Loop

        Me.card1.Text = intplayercard1
        Me.card2.Text = intplayercard2
        Me.card3.Text = intplayercard3
        Me.card4.Text = intplayercard4
        Me.card5.Text = intplayercard5
        Me.card6.Text = intdealercard1
        Me.card7.Text = intdealercard2
        Me.card8.Text = intdealercard3
        Me.card9.Text = intdealercard4
        Me.card10.Text = intdealercard5




    End Sub
End Class
