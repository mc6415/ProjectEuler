'By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
Public Class Problem2
    Public Shared Function Calc()
        Dim a = 1
        Dim b = 2
        Dim c
        Dim results As New List(Of Integer)

        While a + b < 4000000
            c = a + b
            results.Add(a)
            results.Add(b)
            results.Add(c)
            a = b
            b = c
        End While

        Dim result = results.Distinct().Where(Function(i) i Mod 2 = 0).ToList().Sum()

        Return result

    End Function
End Class
