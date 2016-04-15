' Find the largest palindrome made from the product of two 3-digit numbers.
Public Class Problem4
    Public Shared Function Calc()
        Dim palindromes As New List(Of Long)

        For i = 999 To 100 Step -1
            For j = 999 To 100 Step -1
                If EulerMaths.isPalindrome(i * j) Then
                    palindromes.Add(i * j)
                End If
            Next
        Next

        Return palindromes.Max()

    End Function
End Class
