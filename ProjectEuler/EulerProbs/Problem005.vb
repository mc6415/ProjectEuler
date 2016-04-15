'2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
'What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

Public Class Problem005
    Public Shared Function Calc()
        ' Most concise way I could think of writing it, probably a faster way somewhere
        For i = 2520 To Integer.MaxValue Step 20
            If Enumerable.Range(1, 20).Where(Function(j) i Mod j <> 0).ToList().Count = 0 Then
                Return i
            End If
        Next
    End Function
End Class
