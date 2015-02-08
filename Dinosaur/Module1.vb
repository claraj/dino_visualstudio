Module Module1

    Sub Main()

        Console.WriteLine("Dinosaur Program")
        Console.WriteLine("What is the name of your dinosaur?")
        Dim dinoName As String = Console.ReadLine()
        Dim newDino As Dinosaur = New Dinosaur
        newDino.name = dinoName
        Console.WriteLine("your dinosaur is called" & newDino.name & "and says ")

        Console.WriteLine("hug your dino!")
        Console.WriteLine("they have sharp teeth!!!!!!!")
        newDino.roar()

        Console.WriteLine("Lets make another dinosaur. enter new dino name")
        Dim anothername As String = Console.ReadLine()
        Dim anotherdino As Dinosaur = New Dinosaur()
        anotherdino.name = anothername
        Console.WriteLine("Your new dinosaur is called " & anotherdino.name & " and it says ")
        anotherdino.roar()


        Console.ReadKey()
    End Sub

End Module


Class Dinosaur

    Dim dinoName As String
    Public Property name As String
        Get
            Return dinoName
        End Get
        Set(value As String)
            dinoName = value
        End Set
    End Property


    Sub roar()
        Console.WriteLine("grrrrrrr!!!!")
    End Sub

End Class