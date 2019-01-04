Module Areas
    Function Area38(ByVal x0 As Double, ByVal xn As Double, ByVal h As Double) As Double
        Try
            Dim Area As Double = 0
            Dim suma As Double
            suma = 0
            Dim i As Integer
            For i = 0 + 1 To ((xn - x0) - 3) / 3
                suma += XX(3 * i + x0)
            Next
            Area += 2 * suma
            suma = 0
            For i = 0 To ((xn - x0) - 3) / 3
                suma += XX(3 * i + 1 + x0) + XX(3 * i + 2 + x0)
            Next
            Area += 3 * suma
            Area += XX(x0) + XX(xn)
            ' MsgBox(Area & "38")
            Area = h * Area * 3 / 8
            Return Area
        Catch ex As Exception
            MsgBox("Error al cargar los archivos")
            Return 0
        End Try
    End Function

    Function Area13(ByVal x0 As Integer, ByVal xn As Integer, ByRef h As Double) As Double
        Try
            Dim Area As Double = 0
            Dim suma As Double = 0

            Dim i As Integer
            For i = 0 + 1 To ((xn - x0) - 2) / 2
                suma += XX(2 * i + x0)
            Next
            Area += 2 * suma
            suma = 0
            For i = 0 To ((xn - x0) - 2) / 2
                suma += XX(2 * i + 1 + x0)
            Next
            Area += 4 * suma
            Area += XX(x0) + XX(xn)
            Area = h * Area / 3
            'MsgBox(Area & "13")
            Return Area
        Catch ex As Exception
            MsgBox("Error al cargar los archivos")
            Return 0
        End Try
    End Function
End Module
