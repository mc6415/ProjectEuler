'What is the largest prime factor of the number 600851475143 ?
Public Class Problem3
    Public Shared Function Calc()
        Dim num As Long = 600851475143
        Return EulerMaths.getFactors(num).Where(Function(i) EulerMaths.checkPrime(i)).ToList().Max()
    End Function
End Class
