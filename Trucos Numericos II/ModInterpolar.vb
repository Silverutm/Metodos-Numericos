Module ModInterpolar
    Public XM(), XY() As Double
    Sub DifFin(ByRef a As DataGridView, ByVal n As Integer)
        Dim i As Integer
        For i = 1 To n
            For j = 0 To n - i
                YY(j, i) = YY(j + 1, i - 1) - YY(j, i - 1)
                a.Item(i - 1, j).Value = YY(j, i)
            Next
        Next
    End Sub

    Sub DifDiv(ByRef a As DataGridView, ByVal n As Integer)
        Dim i As Integer
        For i = 1 To n
            For j = 0 To n - i
                YY(j, i) = (YY(j + 1, i - 1) - YY(j, i - 1)) / (XX(j + i) - XX(j))
                a.Item(i - 1, j).Value = YY(j, i)
            Next
        Next
    End Sub

    Sub Hermite(ByRef a As DataGridView, ByVal n As Integer)
        Dim i As Integer
        For i = 2 To 2 * n + 1
            For j = 0 To 2 * n - i
                YY(j, i) = (YY(j + 1, i - 1) - YY(j, i - 1)) / (XX(j + i) - XX(j))
                a.Item(i - 1, j).Value = YY(j, i)
            Next
        Next
    End Sub

    Function Multiplicatoria(ByVal j As Integer, ByVal k As Double) As Double
        Dim res As Double = 1
        Dim r As Integer
        For r = 0 To j - 1
            res *= (k - (-r + j - 1))
        Next
        Return res
    End Function
    Function Factorial(ByVal j As Integer) As Double
        Dim r As Double = 1
        Dim i As Integer
        For i = 1 To j
            r *= i
        Next
        Return r
    End Function

    Function InterDifFin(ByVal n As Integer, ByVal interpolar As Double, ByVal k As Double) As Double
        Dim yk As Double = 0
        Dim j As Integer
        For j = 0 To n-1
            yk += YY(0, j) * Multiplicatoria(j, k) / Factorial(j)
        Next
        Return yk
    End Function

    Function Multi(ByVal xk As Double, ByVal j As Integer) As Double
        Dim i As Integer
        Dim res As Double = 1
        For i = 0 To j - 1
            res *= (xk - XX(i))
        Next
        Return res
    End Function

    Function InterDifDiv(ByVal n As Integer, ByVal interpolar As Double) As Double
        Try
            Dim fk As Double = 0
            Dim j As Integer
            For j = 0 To n
                fk += (YY(0, j) * Multi(interpolar, j))
            Next
            Return fk
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
            Return 0
        End Try
    End Function
    Function Mul(ByVal j As Integer, ByVal n As Integer, ByVal interpolar As Double) As Double
        Try
            Dim res As Double = 1
            Dim i As Integer
            For i = 0 To n
                If i <> j Then
                    res *= (interpolar - XX(i))
                    res /= (XX(j) - XX(i))
                End If
            Next
            Return res
        Catch ex As Exception
            
        End Try
    End Function

    Function Lagranch(ByVal n As Integer, ByVal interpolar As Double) As Double
        Try
            Dim pn As Double = 0
            Dim j As Integer
            For j = 0 To n
                pn += YY(j, 0) * Mul(j, n, interpolar)
            Next
            Return pn
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
            Return 0
        End Try
    End Function
End Module
