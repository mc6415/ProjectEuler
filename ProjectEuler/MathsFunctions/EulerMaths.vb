Public Class EulerMaths
    Public Shared Function getFactors(ByVal num As Long) As List(Of Long)
        Dim factors = New List(Of Long)

        Dim i As Integer = 1

        For i = 1 To Math.Sqrt(num) + 1
            If num Mod i = 0 Then
                factors.Add(i)
                If Long.Parse(num / i) <> i Then
                    factors.Add(num / i)
                End If
            End If
        Next

        factors.Remove(num)

        Return factors
    End Function

    Public Shared Function checkPrime(ByVal num As Long) As Boolean
        If num <= 1 Or num Mod 2 = 0 Then
            Return False
        End If
        If num = 2 Then
            Return True
        End If

        For i = 3 To Math.Sqrt(num) Step 2
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Public Shared Function isPalindrome(ByVal input)

        If input.ToString().Equals(StrReverse(input.ToString())) Then
            Return True
        End If

        Return False

    End Function

End Class
