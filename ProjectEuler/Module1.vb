Imports System.Reflection

Module Module1
    Sub Main()
        Dim calcs As New DoWork
        calcs.PerformCalcs()
        Console.ReadKey()
    End Sub

    Function printTime(ByVal time, ByVal probNumber, ByVal ans)
        Console.WriteLine(String.Format("Problem {0} answer is {1} took {2}ms", probNumber, ans, time))
        Return Nothing
    End Function
End Module

Public Class DoWork
    Public Function PerformCalcs()
        Dim method As System.Reflection.MethodInfo
        Dim funcs = Assembly.GetExecutingAssembly.GetTypes().Where(Function(t) t.Name.Contains("Problem")).ToList()
        Dim i = 1
        For Each func In funcs
            method = Type.GetType(func.FullName).GetMethod("Calc")
            If method IsNot Nothing Then
                Dim watch = Stopwatch.StartNew()
                Dim result = method.Invoke(Me, Nothing)
                watch.Stop()
                printTime(watch.ElapsedMilliseconds, i, result)
                i += 1
            End If
        Next
    End Function
End Class