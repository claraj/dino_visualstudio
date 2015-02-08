Module Module1

    Sub Main()

        Console.WriteLine("Dinosaur Program")
        Console.WriteLine("What is the name of your dinosaur?")
        Dim dinoName As String = Console.ReadLine()
        Dim newDino As Dinosaur = New Dinosaur
        newDino.name = dinoName
        Console.WriteLine("your dinosaur is called" & newDino.name & "and says ")
        newDino.roar()
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