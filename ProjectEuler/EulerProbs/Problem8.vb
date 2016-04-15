Imports System.IO
' Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
' See input/Problem8.txt for the 1000-digit number
Public Class Problem8
    Public Shared Function Calc()
        Dim input = File.ReadAllText("./Input/Problem8.txt")
        Dim products = New List(Of Long)

        For i = 0 To input.Length - 13
            Dim product As Long = 1
            ' If the substring contains a 0 then the product will be 0
            ' Eliminating testing these produces around 700 fewer calculations
            If Not input.Substring(i, 13).Contains("0") Then
                For Each num In input.Substring(i, 13)
                    product = product * Long.Parse(num)
                Next
                products.Add(product)
            End If
        Next

        Return products.Max()

    End Function
End Class
