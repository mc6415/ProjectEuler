Public Class Problem3
    Public Shared Function calc()
        Dim num As Long = 600851475143

        Return EulerMaths.getFactors(num).Where(Function(i) EulerMaths.checkPrime(i)).ToList().Max()

    End Function
End Class
