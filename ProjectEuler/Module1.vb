﻿Imports System.Reflection
Imports System.Text
Imports System.IO

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
        Dim sb = New StringBuilder()
        sb.Append("<table>")
        sb.Append("<thead><th>Problem</th><th>Solution</th></thead><tbody>")
        Dim funcs = Assembly.GetExecutingAssembly.GetTypes().Where(Function(t) t.Name.Contains("Problem")).ToList()
        Dim i = 1
        For Each func In funcs
            method = Type.GetType(func.FullName).GetMethod("Calc")
            If method IsNot Nothing Then
                Dim watch = Stopwatch.StartNew()
                Dim result = method.Invoke(Me, Nothing)
                watch.Stop()
                sb.Append("<tr>")
                sb.Append("<td>" + i.ToString + "</td><td>" + result.ToString + "</td></tr>")
                printTime(watch.ElapsedMilliseconds, i, result)
                i += 1
            End If
        Next
        sb.Append("</tbody></table>")
        Dim file As New FileInfo("./out.html")
        If Not file.Exists Then
            Dim f = file.Open(FileMode.CreateNew)
            f.Close()
            Dim write = file.CreateText()
            write.Write(sb.ToString)
            write.Close()
        Else
            Dim test = file.CreateText()
            test.Write(sb.ToString)
            test.Close()
        End If
        Console.WriteLine("Answers saved in: " + file.FullName)
    End Function
End Class