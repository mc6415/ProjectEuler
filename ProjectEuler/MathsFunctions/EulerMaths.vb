Public Class EulerMaths
    ' Some functions that come in handy throughout the problem   

    ''' <summary>
    ''' Gets all the factors of a number and returns them as a list
    ''' </summary>
    ''' <param name="num">number you're getting the factors of</param>
    ''' <returns>A list of the factors of the number minus the number itself</returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Checks if a number is prime
    ''' </summary>
    ''' <param name="num">number that's being checked for primality</param>
    ''' <returns>True if prime, false if not</returns>
    ''' <remarks></remarks>
    Public Shared Function checkPrime(ByVal num As Long) As Boolean
        If num <= 1 Or num Mod 2 = 0 Then
            Return False
        End If
        If num = 2 Then
            Return True
        End If

        ' No even number is prime, only need to check upto the Sqrt of the number being checked
        ' Cuts down on iterations substantially
        For i = 3 To Math.Sqrt(num) Step 2
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    ''' <summary>
    ''' Just checks if an input is a palindrome
    ''' </summary>
    ''' <param name="input">Any input, can be a string,long,int etc.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function isPalindrome(ByVal input)

        If input.ToString().Equals(StrReverse(input.ToString())) Then
            Return True
        End If

        Return False

    End Function

End Class
