Public Class Circle
    Public Color As String = "Black"
    Public Radius As Double

    ' Function to Get Area of Circle
    Public Function GetArea()
        Return (Math.PI) * (Math.Pow(Me.Radius, 2))
    End Function
End Class
