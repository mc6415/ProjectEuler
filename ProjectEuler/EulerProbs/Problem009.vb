'There exists exactly one Pythagorean triplet for which a + b + c = 1000.
'Find the product abc.
Public Class Problem009
    Public Shared Function Calc()
        ' If a is the smallest digit, it must always be under 500
        For a = 1 To 1000 / 2
            ' b is always larger than a
            For b = a + 1 To 1000 / 2
                Dim c = 1000 - a - b
                If (a * a) + (b * b) = (c * c) Then
                    Return a * b * c
                End If
            Next
        Next
    End Function
End Class
