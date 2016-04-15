'Find the sum of all the multiples of 3 or 5 below 1000.
Public Class Problem001
    Public Shared Function Calc() As Integer
        Dim result = 0

        For i = 0 To 999 Step 1
            If i Mod 3 = 0 Or i Mod 5 = 0 Then
                result += i
            End If
        Next

        Return result
    End Function
End Class
