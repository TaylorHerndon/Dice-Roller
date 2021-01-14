Module DiceRoller

    Sub Main()

        Dim Input As Object

        Console.WriteLine("Welcome to DiceRoller™ would you like to create a new character?")
        Console.WriteLine("Enter Y to start rolling up a new character")

        Input = Console.Read()
        Console.WriteLine(Input)

        While True
            If Input = 89 Or Input = 121 Then

                Console.Write("Great!")
                System.Threading.Thread.Sleep(1000)

                Console.Clear()

                Console.WriteLine("First off you need to choose a class")

            Else

                Console.WriteLine("Come on...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("You seriously can't press y...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("Jesus...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("Ok, just don't mess it up this time...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("Ready?")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("You can do this, I belive in you")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("Just Press Y")
                System.Threading.Thread.Sleep(2000)
                Console.Clear()

                Console.WriteLine("Welcome to DiceRoller™ would you like to create a new character?")
                Console.WriteLine("Enter Y to start rolling up a new character")

                Input = Console.Read()
                Console.WriteLine(Input)

                If Input <> 89 Or Input <> 121 Then

                    Console.Clear()
                    Console.WriteLine("God dammit...")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Im done...")
                    System.Threading.Thread.Sleep(2000)
                    End

                End If

            End If
        End While

    End Sub

End Module

' y = 121, Y = 89