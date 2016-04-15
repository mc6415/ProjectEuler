'What is the 10 001st prime number?
Public Class Problem7
    Public Shared Function Calc()
        ' Offset i by 1 as the below will miss out 2 which is Prime
        Dim i = 1
        For num = 1 To Integer.MaxValue Step 2
            If EulerMaths.checkPrime(num) Then
                i += 1
                If i = 10001 Then
                    Return num
                End If
            End If
        Next
    End Function
End Class
