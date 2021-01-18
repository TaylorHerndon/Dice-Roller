Imports System
Imports System.IO
Module DiceRoller
    Sub Main()

        Dim PlayerStatsFileTemp As New StreamReader("PlayerStats.txt")
        Dim PlayerInventoryFileTemp As New StreamReader("PlayerInv.txt")

        Dim Index As Integer = 0
        Dim PlayerStatsArray(5)
        Dim PlayerInventoryArray(5)

        Dim PlayerClass = ""
        Dim PlayerLevel = 0
        Dim Strength = 0
        Dim Agility = 0
        Dim Smarts = 0

        Do Until PlayerStatsFileTemp.Peek = -1

            PlayerStatsArray(Index) = PlayerStatsFileTemp.ReadLine()
            Index = Index + 1

        Loop

        Index = 0

        Do Until PlayerInventoryFileTemp.Peek = -1

            PlayerInventoryArray(Index) = PlayerInventoryFileTemp.ReadLine()
            Index = Index + 1

        Loop

        PlayerStatsFileTemp.Close()
        PlayerInventoryFileTemp.Close()

LineTitle:

        Console.Clear()

        Console.WriteLine("Welcome to DiceRollers(TM)!!")
        Console.WriteLine("Do you want to create a new character or continue with your old save?")

        Console.WriteLine("1. Create new character." & vbNewLine & "2. Continue with old save")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.D1


                If PlayerStatsArray(0) = "Soldier" Or PlayerStatsArray(0) = "Mage" Or PlayerStatsArray(0) = "Rouge" Then

LinePlayerOverwrite:

                    Console.Clear()
                    Console.WriteLine("Are you absoltely sure?" & vbNewLine & "This will erase your current player data and cannot be undone!")
                    Console.WriteLine("Y - N")

                    Select Case Console.ReadKey.Key

                        Case ConsoleKey.Y

                            Console.Clear()
                            Console.WriteLine("Alright... hope you're sure about this...")
                            System.Threading.Thread.Sleep(3000)
                            Call PlayerCreate.PlayerCreate()

                        Case ConsoleKey.N

                            Console.Clear()
                            Console.WriteLine("Phew, you had me going there for a second...")
                            System.Threading.Thread.Sleep(3000)
                            GoTo LineTitle

                        Case Else

                            Console.Clear()
                            Console.WriteLine("Come on this is serious! Yes or No?")
                            System.Threading.Thread.Sleep(3000)
                            GoTo LinePlayerOverwrite

                    End Select

                Else

                    Console.Clear()
                    Console.WriteLine("Off to character creation!!!")
                    System.Threading.Thread.Sleep(3000)
                    Call PlayerCreate.PlayerCreate()

                End If

            Case ConsoleKey.D2

                If PlayerStatsArray(0) = "" Then

                    Console.Clear()
                    Console.WriteLine("It seems like you don't have a character... how about we take care of that?")
                    System.Threading.Thread.Sleep(3000)
                    Call PlayerCreate.PlayerCreate()

                Else

                    Console.Clear()
                    Console.WriteLine("Back to the adventure!!!")
                    System.Threading.Thread.Sleep(3000)

                End If

        End Select

        Index = 0

        Dim PlayerStatsFile As New StreamReader("PlayerStats.txt")
        Dim PlayerInventoryFIle As New StreamReader("PlayerStats.txt")

        Do Until PlayerStatsFile.Peek = -1

            PlayerStatsArray(Index) = PlayerStatsFile.ReadLine()
            Index = Index + 1

        Loop

        Index = 0

        Do Until PlayerInventoryFile.Peek = -1

            PlayerInventoryArray(Index) = PlayerInventoryFile.ReadLine()
            Index = Index + 1

        Loop

        PlayerStatsFile.Close()
        PlayerInventoryFile.Close()

        PlayerClass = PlayerStatsArray(0)
        PlayerLevel = PlayerStatsArray(1)
        Strength = PlayerStatsArray(2)
        Agility = PlayerStatsArray(3)
        Smarts = PlayerStatsArray(4)

        Console.WriteLine("Class: " & PlayerClass & " Level " & PlayerLevel & vbNewLine & "Strength: " & Strength & vbNewLine & "Agility: " & Agility & vbNewLine & "Smarts: " & Smarts)
        System.Threading.Thread.Sleep(4000)

        Console.Clear()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("You wake up to the sounds of birds chirping and a splinter of light shining through the front of your tent.")
        System.Threading.Thread.Sleep(5500)
        Console.Clear()
        System.Threading.Thread.Sleep(1000)
        Console.Write("You think about ")

        Select Case PlayerClass

            Case "Soldier"

                Console.WriteLine("how you would usualy be getting ready to man your post at the front gate right about now.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("It dosen't feel right to head out hunting like this...")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("What if the village gets attacked?")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("Who would be there to defend them?")
                System.Threading.Thread.Sleep(3000)
                Console.Clear()
                Console.WriteLine("Well, if we don't have anything to eat then what good would being at my post do?")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("I'd be sitting on my ass as everyone starved to death...")
                System.Threading.Thread.Sleep(3000)

            Case "Mage"

                Console.Write("your usual cozy study")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine(", and how you got stuck with hunting duty.")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("Why of all people did I get chosen to go hunting?")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("I'm a mage for crying out loud...")
                System.Threading.Thread.Sleep(2000)
                Console.WriteLine("Was there really no one better to send out here?")
                System.Threading.Thread.Sleep(5000)
                Console.Clear()
                Console.WriteLine("Well, everyones relying on me now...")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("If I don't bring back anything who knows what'll happen?")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("Nothing good, that's for sure...")
                System.Threading.Thread.Sleep(3000)

            Case "Rouge"

                Console.WriteLine("the first time you and your friends got caught snooping through lady adriana's manor.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("Damn near burned the place down after you dropped that candle.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("The whole village hated us because of all the shit we'd pull.")
                System.Threading.Thread.Sleep(4000)
                Console.Clear()
                Console.WriteLine("But now everyones counting on you.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("The village hasn't been able to bring in their normal catches after Hadrian got injured.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("No one really realized just how important he was.")
                System.Threading.Thread.Sleep(4000)
                Console.WriteLine("Good thing I'm good with a bow or we could be in some real trouble right now.")
                System.Threading.Thread.Sleep(5000)
                Console.WriteLine("Don't know who else they would send out here...")
                System.Threading.Thread.Sleep(3000)

            Case Else

                Console.WriteLine("A critical error has occoured... no player class found...")
                Console.ReadLine()
                End

        End Select

        Console.WriteLine("Press Any Key to Continue...")
        Console.ReadKey()

        Console.Clear()
        Console.WriteLine("You start to shuffle out of your bed roll and the cold immediately bites into your face and arms.")
        System.Threading.Thread.Sleep(3000)
        Console.WriteLine("Maybe it would be a good idea to get a fire going.")
        System.Threading.Thread.Sleep(6000)
        Console.Clear()

LineStartFire:

        Select Case PlayerClass

            Case "Soldier"

                Console.Write("1. Start a fire with ")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Tinder Box")
                Console.ResetColor()
                Console.WriteLine("2. No, I need to get moving, can't waste any time.")

            Case "Mage"

                Console.Write("1. Start a fire using ")
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.WriteLine("Control Flames")
                Console.ResetColor()
                Console.WriteLine("2. No, I need to get moving, can't waste any time.")

            Case "Rouge"

                Console.Write("1. Start a fire with ")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Tinder Box")
                Console.ResetColor()
                Console.WriteLine("2. No, I need to get moving, can't waste any time.")

            Case Else

                Console.WriteLine("An Error has occoured... no player class found.")

        End Select

        Select Case Console.ReadKey.Key

            Case ConsoleKey.D1

                If PlayerClass = "Mage" Then

                    Console.Clear()
                    Console.WriteLine("You relight your fire from the night before with a wave of your hand.")
                    System.Threading.Thread.Sleep(4000)
                    Console.WriteLine("Well, I guess there are perks to being a mage...")
                    System.Threading.Thread.Sleep(4000)
                    Console.WriteLine("You sit down next to the fire and relax in the heat, it's comforting.")
                    System.Threading.Thread.Sleep(4000)

                Else

                    Console.Clear()
                    Console.WriteLine("You take a minute to rekindle your fire from the night before.")
                    System.Threading.Thread.Sleep(4000)
                    Console.WriteLine("After around 2 minutes you get a strong flame going.")
                    System.Threading.Thread.Sleep(4000)
                    Console.WriteLine("You sit down next to the fire and find comfort in it's warmth.")
                    System.Threading.Thread.Sleep(4000)

                End If

                Console.WriteLine("Press any key to continue...")
                Console.ReadKey()

                Console.Clear()
                Console.WriteLine("Well, I got the fire going, I might as well have some food.")
                System.Threading.Thread.Sleep(5000)

LineEatBreakfast:

                Console.Clear()
                Console.WriteLine("1. Eat some nuts and berries.")
                Console.WriteLine("2. Cook some game meat over the fire.")
                Console.WriteLine("3. Leave")

                Select Case Console.ReadKey.Key

                    Case ConsoleKey.D1

                        Console.Clear()
                        Console.WriteLine("You pull out a pouch of nuts and berries that you gathered on the journey here.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("They're satisfying and suprisingly flavorfull.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("You continue to eat your breakfast as you stare into the fire.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Time seems to stretch on forever.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("But you don't mind, it's nice just sitting here.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Press any key to continue...")
                        Console.ReadKey()
                        Console.Clear()

                    Case ConsoleKey.D2

                        Console.Clear()
                        Console.WriteLine("You skewer a small slab of meat from your pouch with a stick and hold it over the fire.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Eventually, you cook it through and start having your breakfast.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("It's nice to be able to eat something besides tough bread and a watered down soup.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("You continue to eat your breakfast as you stare into the fire.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Time seems to stretch on forever.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("But you don't mind, it's nice just sitting here.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Press any key to continue...")
                        Console.ReadKey()
                        Console.Clear()

                    Case ConsoleKey.D3

                        Console.Clear()
                        Console.WriteLine("No, on second thought I should probably get moving.")
                        System.Threading.Thread.Sleep(4000)
                        Console.Clear()

                    Case Else

                        GoTo LineEatBreakfast

                End Select

            Case ConsoleKey.D2

                Console.Clear()
                Console.WriteLine("No, people are relying on me I need to get moving...")
                System.Threading.Thread.Sleep(4000)

            Case Else

                GoTo LineStartFire

        End Select

        Console.Clear()
        Console.Write("You tear down your tent, snuff out what's left of your fire, ")

        Select Case PlayerClass

            Case "Soldier"

                Console.WriteLine("equip your sword, and grab the bow Hadrian lended you across your back.")

            Case "Mage"

                Console.WriteLine("and grab your staff.")

            Case "Rouge"

                Console.WriteLine("and grab your bow.")

        End Select

        System.Threading.Thread.Sleep(6000)

LineStartHunting:

        Console.Clear()
        Console.WriteLine("1. Check the snares you set up last night.")
        Console.WriteLine("2. Try to track down some larger game.")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.D1

                Console.Clear()
                Console.WriteLine("The first 3 snares you visit are empty.")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("On the last snare you find a white fox.")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("Not caught by the neck but the leg.")
                System.Threading.Thread.Sleep(3000)
                Console.WriteLine("You can tell that hes been trying to free himself for some time now and is exhausted.")
                System.Threading.Thread.Sleep(6000)

LineFox:

                Console.Clear()

                Console.Write("1. ")
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.Write("Kill ")
                Console.ResetColor()
                Console.WriteLine("the fox.")

                Console.Write("2. ")
                Console.ForegroundColor = ConsoleColor.DarkGreen
                Console.Write("Free ")
                Console.ResetColor()
                Console.WriteLine("the fox.")

                Console.WriteLine("3. Do nothing and leave.")

                Select Case Console.ReadKey.Key

                    Case ConsoleKey.D1

                        Select Case PlayerClass

                            Case "Soldier"

                                Console.Clear()
                                Console.WriteLine("You have a duty to do and people are counting on you to bring food back.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("Without a second thought you grab the fox and plunge a knife into its heart.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("The fox dies nearly instantly.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("Press any key to continue...")
                                Console.ReadKey()


                            Case "Mage"

                                Console.Clear()
                                Console.WriteLine("You're a little taken back that you were able to catch anything on your first time around.")
                                System.Threading.Thread.Sleep(4000)
                                Console.Write("You raise your staff towards the fox and cast ")
                                Console.ForegroundColor = ConsoleColor.Cyan
                                Console.WriteLine("Ray of Frost")
                                Console.ResetColor()
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("The fox dies instantly and is immediatly preserved by the spell.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("Press any key to continue...")
                                Console.ReadKey()


                            Case "Rouge"

                                Console.Clear()
                                Console.WriteLine("Some target practice could be good.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("You draw back your bow and let out a slow breath.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("The arrow flies from the bow hitting the fox directly in the head.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("The fox dies instantly.")
                                System.Threading.Thread.Sleep(4000)
                                Console.WriteLine("Press any key to continue...")
                                Console.ReadKey()

                        End Select

                    Case ConsoleKey.D2

                        Console.WriteLine("Even though people are counting on you to bring back food, something just dosen't feel right about killing it.")
                        System.Threading.Thread.Sleep(5000)
                        Console.WriteLine("You hold the fox down and cut the rope, freeing it.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("A smile comes across your face as you watch it bolt into the forest.")
                        System.Threading.Thread.Sleep(4000)
                        Console.WriteLine("Press any key to continue...")
                        Console.ReadKey()


                    Case ConsoleKey.D3

                        Console.WriteLine("You say to yourself that theres no time to kill it and that you might come back for it later.")
                        System.Threading.Thread.Sleep(3000)
                        Console.WriteLine("As you leave the fox there to suffer.")
                        System.Threading.Thread.Sleep(3000)
                        Console.WriteLine("Press any key to continue...")
                        Console.ReadKey()

                    Case Else

                        GoTo LineFox

                End Select

            Case ConsoleKey.D2

                Console.Clear()
                Console.WriteLine("The snares aren't going anywhere, I should focus on tracking down some larger game.")
                System.Threading.Thread.Sleep(6000)

            Case Else

                GoTo LineStartHunting

        End Select

        Console.WriteLine("------<End Code>------")
        Console.ReadKey()

    End Sub

End Module