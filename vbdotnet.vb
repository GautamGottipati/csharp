Imports System

Public Class Program
    Public Shared Sub Main()
        Dim a, b As Integer
        Dim op As String
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        op = Console.ReadLine()

        If op = "+" Then
            Console.WriteLine(a + b)
        ElseIf op = "*" Then
            Console.WriteLine(a * b)
        ElseIf op = "/" Then
            Console.WriteLine(a / b)
        ElseIf op = "-" Then
            Console.WriteLine(a - b)
        Else
            Console.WriteLine("Invalid Operator !")
        End If
    End Sub
End Class
