'Jamison Burton
'RCET0265
'Spring 2022
'Better Calculator
'https://github.com/Reimonoe17/BetterCalculator

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Calculations()

        Console.WriteLine("You Entered " & Chr(34) & "Q" & Chr(34) & vbNewLine & "Have a Nice Day" & vbNewLine & "Press ENTER to close this window")
        Console.ReadLine()
    End Sub
    Sub Calculations()
        'Declared variables
        Dim firstInput As String = ""
        Dim secondInput As String = ""
        Dim thirdInput As String = ""
        Dim firstNumber As Integer = 0
        Dim secondNumber As Integer = 0
        Dim thirdNumber As Integer = 0
        Dim thirdRight As Boolean = True
        Dim answer As Decimal = 0

        Do
            'First run of prompts for the user
            Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")
            Console.WriteLine("Choose a Number: ")
            firstInput = Console.ReadLine()
            If firstInput = "Q" Then
                Exit Sub
            End If
            Console.WriteLine("You entered: " & firstInput)
            Console.WriteLine("Choose another Number: ")
            secondInput = Console.ReadLine()
            If secondInput = "Q" Then
                Exit Sub
            End If
            Console.WriteLine("You entered: " & secondInput)

            'Assigns integer variable values based on string inputs
            firstNumber = CInt(firstInput)
            secondNumber = CInt(secondInput)
            Do
                Console.WriteLine("Choose a Math: " & vbNewLine & "1. Add" & vbNewLine & "2. Subtract" & vbNewLine & "3. Multiply" & vbNewLine & "4. Divid")
                thirdInput = Console.ReadLine()
                If thirdInput = "Q" Then
                    Exit Sub
                End If
                thirdNumber = CInt(thirdInput)

                Select Case thirdNumber
                        Case 1
                            thirdRight = True
                            answer = firstNumber + secondNumber
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {answer}")
                        Case 2
                            thirdRight = True
                            answer = firstNumber - secondNumber
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {answer}")
                        Case 3
                            thirdRight = True
                            answer = firstNumber * secondNumber
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {answer}")
                        Case 4
                            thirdRight = True
                            answer = CDec(firstNumber) / CDec(secondNumber)
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {answer}")
                        Case Else
                        thirdRight = False
                End Select
                Loop Until thirdRight = True

            Loop
    End Sub

End Module
