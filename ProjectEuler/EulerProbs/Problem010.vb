Public Class Problem010
    Public Shared Function Calc()
        Dim primes As New List(Of Long)
        primes.Add(2)
        For i = 3 To 2000000 Step 2
            If EulerMaths.checkPrime(i) Then
                primes.Add(i)
            End If
        Next

        Return primes.Sum()
    End Function
End Class
