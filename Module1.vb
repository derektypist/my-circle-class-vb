Module Module1

    Sub Main()
        ' Define Variables
        Dim mycircle1 As New Circle
        Dim mycircle2 As New Circle

        ' Set Up Properties
        mycircle1.Color = "Red"
        mycircle1.Radius = 1.6
        mycircle2.Radius = 2.5

        ' Display Properties and Methods in the Console Window
        Console.WriteLine($"Circle 1 is colored {mycircle1.Color}")
        Console.WriteLine($"Circle 1 has a radius of {mycircle1.Radius:F2} units")
        Console.WriteLine($"Circle 1 has an area of {mycircle1.GetArea:F2} square units" + vbCrLf)
        Console.WriteLine($"Circle 2 is colored {mycircle2.Color}")
        Console.WriteLine($"Circle 2 has a radius of {mycircle2.Radius:F2} units")
        Console.WriteLine($"Circle 2 has an area of {mycircle2.GetArea:F2} square units")
    End Sub

End Module
