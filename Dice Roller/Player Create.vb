Imports Microsoft.VisualBasic
Imports System.IO
Imports System

Module PlayerCreate
    Sub PlayerCreate()

        Randomize()

        Dim Retire = 0
        Dim PlayerClass As String = "Undecided"
        Dim PlayerGold As Integer = 0
        Dim StatsReady As Boolean = False
        Dim Repeat As Boolean = True
        Dim Repeat2 As Boolean = True
        Dim Repeat3 As Boolean = True
        Dim Repeat4 As Boolean = True
        Dim Repeat5 As Boolean = True

        Dim RollA As Integer = 0
        Dim RollB As Integer = 0
        Dim RollC As Integer = 0
        Dim StatA As Integer = 0
        Dim StatB As Integer = 0
        Dim StatC As Integer = 0

        Dim Strength As Integer = 0
        Dim Agility As Integer = 0
        Dim Smarts As Integer = 0

        'First while loop is class selection'
        While PlayerClass = "Undecided"

            Console.WriteLine("Welcome to DiceRoller(TM) Introduction")
            Console.WriteLine("Press 'Enter' to start rolling up a new character")

            If Console.ReadKey.Key = ConsoleKey.Enter Then

                Console.Write("Great!")
                System.Threading.Thread.Sleep(1000)

                Console.Clear()
                Console.WriteLine("First off you need to choose a class")
                System.Threading.Thread.Sleep(2000)
                Console.Clear()


                'Character Selection'
                While PlayerClass = "Undecided"

                    Console.WriteLine("Press the coresponding key to choose your class...")
                    Console.WriteLine("1. Soldier: Sword & Sheild just can't be beat.")
                    Console.WriteLine("2. Mage: ...Fireball")
                    Console.WriteLine("3. Rouge: MMMM Juicy Damage")

                    Select Case Console.ReadKey.Key

                        'Soldier Class'
                        Case ConsoleKey.D1

                            PlayerClass = "Soldier"

                            Console.Clear()
                            Console.Write("You have chosen ")
                            Console.Write(PlayerClass)

                            System.Threading.Thread.Sleep(1000)

                            Console.WriteLine("")
                            Console.WriteLine("Are you sure?")
                            Console.WriteLine("Y - N")

                            Select Case Console.ReadKey.Key

                                Case ConsoleKey.Y

                                    Console.Clear()
                                    Console.Write("Great! Now we can start rolling up stats!")
                                    System.Threading.Thread.Sleep(3000)
                                    Console.Clear()

                                Case ConsoleKey.N

                                    Console.Clear()
                                    PlayerClass = "Undecided"

                            End Select

                        'Mage Class'
                        Case ConsoleKey.D2

                            PlayerClass = "Mage"

                            Console.Clear()
                            Console.Write("You have chosen ")
                            Console.Write(PlayerClass)

                            System.Threading.Thread.Sleep(1000)

                            Console.WriteLine("")
                            Console.WriteLine("Are you sure?")
                            Console.WriteLine("Y - N")

                            Select Case Console.ReadKey.Key

                                Case ConsoleKey.Y

                                    Console.Clear()
                                    Console.Write("Great! Now we can start rolling up stats!")
                                    System.Threading.Thread.Sleep(3000)
                                    Console.Clear()

                                Case ConsoleKey.N

                                    Console.Clear()
                                    PlayerClass = "Undecided"

                            End Select

                        'Rouge Class'
                        Case ConsoleKey.D3

                            PlayerClass = "Rouge"

                            Console.Clear()
                            Console.Write("You have chosen ")
                            Console.Write(PlayerClass)

                            System.Threading.Thread.Sleep(1000)

                            Console.WriteLine("")
                            Console.WriteLine("Are you sure?")
                            Console.WriteLine("Y - N")

                            Select Case Console.ReadKey.Key

                                Case ConsoleKey.Y

                                    Console.Clear()
                                    Console.Write("Great! Now we can start rolling up stats!")
                                    System.Threading.Thread.Sleep(3000)
                                    Console.Clear()

                                Case ConsoleKey.N

                                    Console.Clear()
                                    PlayerClass = "Undecided"

                            End Select

                        Case Else

                            Console.Clear()
                            Console.Write("Please choose a valid class...")
                            System.Threading.Thread.Sleep(2000)
                            Console.Clear()

                    End Select

                End While

            Else

                'Angry computer bit'
                Retire = Retire + 1

                If Retire > 1 Then

                    Console.Clear()
                    Console.WriteLine("God dammit...")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("Im done")
                    System.Threading.Thread.Sleep(2000)
                    End

                Else

                    Console.Clear()
                    Console.WriteLine("Come on...")
                    System.Threading.Thread.Sleep(2500)
                    Console.WriteLine("You seriously can't press Enter?")
                    System.Threading.Thread.Sleep(2500)
                    Console.WriteLine("Jesus...")
                    System.Threading.Thread.Sleep(4000)

                    Console.Clear()

                    Console.WriteLine("Ok, i'm going to give you another chance, just don't mess it up this time...")
                    System.Threading.Thread.Sleep(3000)
                    Console.WriteLine("Ready?")
                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("You can do this, I belive in you")
                    System.Threading.Thread.Sleep(2500)
                    Console.WriteLine("Just press ENTER")
                    System.Threading.Thread.Sleep(2000)
                    Console.Clear()

                End If

            End If

        End While

        'Rolling Stats'
        While StatsReady = False

            Console.WriteLine("You have 3 different stats...")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Strength: Physical attack power and health.")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Agility: Movement Speed and evasiveness.")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Smarts: Intelectual ability and perceptiveness.")
            System.Threading.Thread.Sleep(3000)

            Console.WriteLine("")
            Console.WriteLine("Got that? Good, are you ready for numbers?")
            Console.WriteLine("Y - N")

            If Console.ReadKey.Key = ConsoleKey.Y Then

                Console.Clear()
                Console.WriteLine("Perfect, lets go!")
                System.Threading.Thread.Sleep(1500)
                Console.Clear()

            Else

                Console.Clear()
                Console.WriteLine("Ok, I can wait...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("No no, Please, take your time...")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("Just uhhh, hit Y when your ready...")
                System.Threading.Thread.Sleep(5000)
                Console.WriteLine("No rush...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("None at all...")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("Just gunna wait here")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("Just chillin...")

                While Console.ReadKey.Key <> ConsoleKey.Y

                End While

                Console.Clear()
                Console.WriteLine("Ahh! Your ready, great! Lets roll some stats")
                System.Threading.Thread.Sleep(2000)
                Console.Clear()

            End If

            Console.Write("Your first rolls are... ")
            System.Threading.Thread.Sleep(1000)
            Console.Write("Clunk, Clunk, Clunk, Clunk," & vbNewLine)
            System.Threading.Thread.Sleep(1000)

            While Repeat = True

                RollA = VBMath.Rnd * 6 + 2
                RollB = VBMath.Rnd * 6 + 2
                RollC = VBMath.Rnd * 6 + 2

                If RollA > 6 Then
                    RollA = 6
                End If

                If RollB > 6 Then
                    RollB = 6
                End If

                If RollC > 6 Then
                    RollC = 6
                End If

                StatA = RollA + RollB + RollC

                Console.Write(RollA)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollB)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollC)
                System.Threading.Thread.Sleep(250)
                Console.WriteLine("...")
                System.Threading.Thread.Sleep(500)
                Console.Write("For a total of ")
                System.Threading.Thread.Sleep(1000)
                Console.WriteLine(StatA)

                RollA = VBMath.Rnd * 6 + 1
                RollB = VBMath.Rnd * 6 + 1
                RollC = VBMath.Rnd * 6 + 1
                StatB = RollA + RollB + RollC

                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("")
                Console.WriteLine("Next is...")
                System.Threading.Thread.Sleep(2000)
                Console.Write(RollA)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollB)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollC)
                System.Threading.Thread.Sleep(250)
                Console.WriteLine("...")
                System.Threading.Thread.Sleep(500)
                Console.Write("For a total of ")
                System.Threading.Thread.Sleep(1000)
                Console.WriteLine(StatB)

                RollA = VBMath.Rnd * 6 + 1
                RollB = VBMath.Rnd * 6 + 1
                RollC = VBMath.Rnd * 6 + 1
                StatC = RollA + RollB + RollC

                System.Threading.Thread.Sleep(2000)
                Console.WriteLine(" ")
                Console.WriteLine("And finally...")
                System.Threading.Thread.Sleep(2000)
                Console.Write(RollA)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollB)
                System.Threading.Thread.Sleep(250)
                Console.Write(" + ")
                System.Threading.Thread.Sleep(250)
                Console.Write(RollC)
                System.Threading.Thread.Sleep(250)
                Console.WriteLine("...")
                System.Threading.Thread.Sleep(500)
                Console.Write("For a total of ")
                System.Threading.Thread.Sleep(1000)
                Console.WriteLine(StatC)

                Console.Write("Alright, so we have: ")
                System.Threading.Thread.Sleep(500)
                Console.Write(StatA)
                Console.Write(", ")
                System.Threading.Thread.Sleep(500)
                Console.Write(StatB)
                Console.Write(", and ")
                System.Threading.Thread.Sleep(500)
                Console.Write(StatC)
                Console.WriteLine(".")

                System.Threading.Thread.Sleep(2000)
                Console.WriteLine(" ")
                Console.WriteLine("Do you want to keep these stats?")
                Console.WriteLine("Y - N")

                Select Case Console.ReadKey.Key

                    Case ConsoleKey.Y

                        Console.Clear()
                        Console.WriteLine("Awesome! Now, which one belongs where?")
                        System.Threading.Thread.Sleep(1500)
                        Console.Clear()
                        Repeat = False

                    Case ConsoleKey.N

                        Console.Clear()
                        Console.WriteLine("Alright, lets try this again...")
                        System.Threading.Thread.Sleep(1500)
                        Repeat = True

                End Select

            End While

            Repeat = True

LineOne:

            Strength = 0
            Agility = 0
            Smarts = 0

            'Allocating Stats'
            While Repeat = True

                'Stat A'
                While Repeat2 = True

                    Console.Clear()
                    Console.Write("Your Stats: ")
                    System.Threading.Thread.Sleep(500)
                    Console.Write(StatA)
                    Console.Write(", ")
                    System.Threading.Thread.Sleep(500)
                    Console.Write(StatB)
                    Console.Write(", and ")
                    System.Threading.Thread.Sleep(500)
                    Console.Write(StatC)
                    Console.WriteLine(".")

                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("So, what do we want the " & StatA & " to be?")
                    System.Threading.Thread.Sleep(2000)

                    Console.WriteLine(" ")
                    Console.Write("1. Strength" & vbNewLine & "2. Agility" & vbNewLine & "3. Smarts")

                    Select Case Console.ReadKey.Key

                        Case ConsoleKey.D1

                            Console.WriteLine(" ")
                            Console.WriteLine("Alright, Strength it is...")
                            System.Threading.Thread.Sleep(1500)
                            Strength = StatA
                            Repeat2 = False

                        Case ConsoleKey.D2

                            Console.WriteLine(" ")
                            Console.WriteLine("Alright, Agility it is...")
                            System.Threading.Thread.Sleep(1500)
                            Agility = StatA
                            Repeat2 = False

                        Case ConsoleKey.D3

                            Console.WriteLine(" ")
                            Console.WriteLine("Alright, Smarts it is...")
                            System.Threading.Thread.Sleep(1500)
                            Smarts = StatA
                            Repeat2 = False

                        Case Else

                            Console.WriteLine(" ")
                            Console.WriteLine("Please choose a valid stat.")
                            Repeat2 = True

                    End Select

                End While

                Repeat2 = True

                'Stat B'
                While Repeat3 = True

                    Console.Clear()
                    Console.Write("Your Remaining Stats: ")
                    System.Threading.Thread.Sleep(500)
                    Console.Write(StatB)
                    Console.Write(" and ")
                    System.Threading.Thread.Sleep(500)
                    Console.Write(StatC)
                    Console.WriteLine(".")

                    System.Threading.Thread.Sleep(2000)
                    Console.WriteLine("So, what do we want the " & StatB & " to be?")
                    System.Threading.Thread.Sleep(2000)

                    Console.Write(vbNewLine & "1. Strength" & vbNewLine & "2. Agility" & vbNewLine & "3. Smarts")

                    Select Case Console.ReadKey.Key

                        Case ConsoleKey.D1

                            If Strength = 0 Then

                                Console.WriteLine(" ")
                                Console.WriteLine("Alright, Strength it is...")
                                System.Threading.Thread.Sleep(1500)
                                Strength = StatB
                                Repeat3 = False

                            Else

                                Console.Clear()
                                Console.WriteLine("Please choose a new Stat...")
                                System.Threading.Thread.Sleep(1500)
                                Repeat3 = True

                            End If

                        Case ConsoleKey.D2


                            If Agility = 0 Then

                                Console.WriteLine(" ")
                                Console.WriteLine("Alright, Agility it is...")
                                System.Threading.Thread.Sleep(1500)
                                Agility = StatB
                                Repeat3 = False

                            Else

                                Console.Clear()
                                Console.WriteLine("Please choose a new Stat...")
                                System.Threading.Thread.Sleep(1500)
                                Repeat3 = True

                            End If

                        Case ConsoleKey.D3

                            If Smarts = 0 Then

                                Console.WriteLine(" ")
                                Console.WriteLine("Alright, Smarts it is...")
                                System.Threading.Thread.Sleep(1500)
                                Smarts = StatB
                                Repeat3 = False

                            Else

                                Console.WriteLine("Please choose a new Stat...")
                                System.Threading.Thread.Sleep(1500)
                                Repeat3 = True

                            End If

                        Case Else

                            Console.WriteLine(" ")
                            Console.WriteLine("Please choose a valid stat.")
                            Repeat3 = True

                    End Select

                End While

                Repeat4 = True

                'Stat C'
                Console.Clear()
                Console.Write("Your Remaining Stats: ")
                System.Threading.Thread.Sleep(500)
                Console.WriteLine(StatC & ".")
                System.Threading.Thread.Sleep(1500)

                Console.Write(vbNewLine & "So that leaves: ")
                System.Threading.Thread.Sleep(500)

                'Choose the remainging stat'
                If Strength = 0 Then

                    Console.Write("Strength")
                    Strength = StatC

                Else

                    If Agility = 0 Then

                        Console.Write("Aglility")
                        Agility = StatC

                    Else

                        Console.Write("Smarts")
                        Smarts = StatC

                    End If

                End If

                System.Threading.Thread.Sleep(2000)

                Console.Clear()
                Console.WriteLine("Your current stats are:" & vbNewLine & "Strength: " & Strength & vbNewLine & "Agility: " & Agility & vbNewLine & "Smarts: " & Smarts)
                Console.WriteLine(vbNewLine & "Are you happy with these stats?" & vbNewLine & "Y - N")

                While Repeat4 = True

                    Select Case Console.ReadKey.Key

                        Case = ConsoleKey.Y

                            Console.Clear()
                            Console.WriteLine("Nice, now what was next?")
                            System.Threading.Thread.Sleep(4000)
                            Repeat4 = False
                            Repeat = False
                            StatsReady = True

                        Case = ConsoleKey.N

                            Console.Clear()
                            Console.WriteLine("Alright, lets try this again...")
                            System.Threading.Thread.Sleep(3000)
                            Repeat4 = False
                            StatsReady = False
                            Console.Clear()
                            GoTo LineOne

                        Case Else

                            Console.Clear()
                            Console.WriteLine("Y or N pal...")
                            System.Threading.Thread.Sleep(3000)
                            Repeat4 = True
                            Console.Clear()

                    End Select

                End While

            End While

        End While

        Retire = 0

        'Rolling Gold'
        While Repeat5 = True

            Repeat2 = True

            Console.Clear()
            Console.WriteLine("Oh, right, to get anywhere in this world you're going to need some gold.")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("Gold is 10 10D")
            System.Threading.Thread.Sleep(1500)

            'Do 10 Clunks'
            While Retire < 10

                Console.Write("Clunk, ")
                System.Threading.Thread.Sleep(200)
                Retire = Retire + 1

            End While

            Retire = 0

            '...'
            System.Threading.Thread.Sleep(1000)
            Console.Write(".")
            System.Threading.Thread.Sleep(1000)
            Console.Write(".")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine(".")

            'Lists 10 rolls'
            While Repeat2 = True

                Retire = Retire + 1
                RollA = VBMath.Rnd * 10 + 1

                If RollA > 10 Then

                    RollA = 10

                End If

                PlayerGold = RollA + PlayerGold

                'Write out the roll and + or just the roll on the last roll
                If Retire = 10 Then

                    Console.Write(RollA)

                Else

                    Console.Write(RollA & " + ")

                End If

                'Stop after 10 rolls'
                If Retire > 9 Then

                    Console.WriteLine(" ")
                    Repeat2 = False

                End If

                System.Threading.Thread.Sleep(1000)

            End While

            Console.Write("For a grand total of... ")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine(PlayerGold)
            System.Threading.Thread.Sleep(1000)

            Console.WriteLine(vbNewLine & "Sorry, no redos on this one...")
            System.Threading.Thread.Sleep(4000)

            Console.Clear()
            Console.WriteLine("Alright... I think you're all set....")
            System.Threading.Thread.Sleep(4000)
            Console.WriteLine("Let the adventure begin!")
            System.Threading.Thread.Sleep(4000)
            Repeat5 = False

        End While

        'Calculating Health'
        Dim PlayerHealthMax As Integer = 0
        Dim PlayerLevel As Integer = 1
        Dim StrengthMod As Integer = 0

        StrengthMod = Strength / 2 - 5

        Select Case PlayerClass

            Case "Soldier"

                If StrengthMod > 0 Then

                    PlayerHealthMax = PlayerLevel * 10 + StrengthMod

                Else

                    PlayerHealthMax = PlayerLevel * 10 + 1

                End If


            Case "Rouge"

                If StrengthMod > 0 Then

                    PlayerHealthMax = PlayerLevel * 8 + StrengthMod

                Else

                    PlayerHealthMax = PlayerLevel * 8 + 1

                End If

            Case "Mage"

                If StrengthMod > 0 Then

                    PlayerHealthMax = PlayerLevel * 6 + StrengthMod

                Else

                    PlayerHealthMax = PlayerLevel * 6 + 1

                End If

            Case "Else"

                Console.WriteLine("A critical error has occoured, PlayerClass cannot be found")

        End Select

        'Write to player stats txt file'
        Dim sr As New StreamWriter("PlayerStats.txt")

        sr.WriteLine(PlayerClass)
        sr.WriteLine(Strength)
        sr.WriteLine(Agility)
        sr.WriteLine(Smarts)
        sr.WriteLine(PlayerHealthMax)

        sr.Close()

        Dim sr2 As New StreamWriter("PlayerInv.txt")

        sr2.WriteLine(PlayerGold)
        sr2.WriteLine("<Empty>")
        sr2.WriteLine("<Empty>")
        sr2.WriteLine("<Empty>")
        sr2.WriteLine("<Empty>")

        sr2.Close()

        'Stength
        'Agility
        'Smarts
        'PlayerHealthMax

        Console.Clear()
        Console.WriteLine("<End Player Create>")
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()

    End Sub

End Module
