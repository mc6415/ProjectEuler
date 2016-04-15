Public Class Problem1
    Public Shared Function calc1() As Integer
        Dim result = 0

        For i = 0 To 999 Step 1
            If i Mod 3 = 0 Or i Mod 5 = 0 Then
                result += i
            End If
        Next

        Return result
    End Function
End Class
