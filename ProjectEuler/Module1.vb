Module Module1

    Sub Main()
        Dim result
        Dim start = Stopwatch.StartNew()
        result = Problem1.calc1()
        start.Stop()
        printTime(start.ElapsedMilliseconds, 1, result)
        start.Restart()
        result = Problem2.getFib()
        start.Stop()
        printTime(start.ElapsedMilliseconds, 2, result)
        start.Restart()
        result = Problem3.calc()
        start.Stop()
        printTime(start.ElapsedMilliseconds, 3, result)
        start.Restart()
        result = Problem4.Calc()
        start.Stop()
        printTime(start.ElapsedMilliseconds, 4, result)
        Console.ReadKey()
    End Sub


    Function printTime(ByVal time, ByVal probNumber, ByVal ans)
        Console.WriteLine(String.Format("Problem {0} answer is {1} took {2}ms", probNumber, ans, time))
        Return Nothing
    End Function
End Module
