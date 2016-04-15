'Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
Public Class Problem6
    Public Shared Function Calc()
        Dim sumSquares = 0
        For Each num In Enumerable.Range(1, 100).ToList
            sumSquares += (num * num)
        Next

        Return (Math.Pow(Enumerable.Range(1, 100).Sum, 2) - sumSquares)
    End Function
End Class
