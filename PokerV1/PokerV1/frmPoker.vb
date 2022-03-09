Public Class frmPoker

    Dim deck() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
        15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
        32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
        49, 50, 51}
    Dim playerCards(1) As Integer
    Dim enemy1Cards(1) As Integer
    Dim enemy2Cards(1) As Integer
    Dim enemy3Cards(1) As Integer
    Dim dealerCards(4) As Integer
    Dim dealStage As Integer = 0
    Dim randNum As Integer
    Dim randFinal As Integer

    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        If dealStage = 0 Then
            deck = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
                32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
                49, 50, 51}
            Randomize()
            randNum = CInt(Int(51 * Rnd()))
            randFinal = randNum
            playerCards(0) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            playerCards(1) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy1Cards(0) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy1Cards(1) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy2Cards(0) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy2Cards(1) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy3Cards(0) = deck(randFinal)
            deck(randFinal) = 52
            randFinal = WhileLoop()
            enemy3Cards(1) = deck(randFinal)
            deck(randFinal) = 52
            dealStage = 1
        ElseIf dealStage = 1 Then
            randFinal = WhileLoop()
            dealerCards(0) = deck(randFinal)
            deck(randFinal) = 52
        ElseIf dealStage = 1 Then
            randFinal = WhileLoop()
            dealerCards(1) = deck(randFinal)
            deck(randFinal) = 52
        ElseIf dealStage = 1 Then
            randFinal = WhileLoop()
            dealerCards(2) = deck(randFinal)
            deck(randFinal) = 52
        ElseIf dealStage = 1 Then
            randFinal = WhileLoop()
            dealerCards(3) = deck(randFinal)
            deck(randFinal) = 52
        ElseIf dealStage = 1 Then
            randFinal = WhileLoop()
            dealerCards(4) = deck(randFinal)
            deck(randFinal) = 52
            lblTester.Text = playerCards(0).ToString() + ", " + playerCards(1).ToString() + vbNewLine +
            enemy1Cards(0).ToString() + ", " + enemy1Cards(1).ToString() + vbNewLine +
            enemy2Cards(0).ToString() + ", " + enemy2Cards(1).ToString() + vbNewLine +
            enemy3Cards(0).ToString() + ", " + enemy3Cards(1).ToString() + vbNewLine +
            dealerCards(0).ToString() + ", " + dealerCards(1).ToString() + ", " + dealerCards(2).ToString() +
            ", " + dealerCards(3).ToString() + ", " + dealerCards(4).ToString()
        End If
    End Sub

    Function WhileLoop() As Integer
        randNum = CInt(Int(51 * Rnd()))
        While deck(randNum) = 52
            randNum = CInt(Int(51 * Rnd()))
        End While
        Return randNum
    End Function
End Class
