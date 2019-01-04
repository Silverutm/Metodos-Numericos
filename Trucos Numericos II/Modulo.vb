Module Modulo
    'Son las Forms
    Public FMenu As New Menu
    Public FMetodos As New Metodos
    Public FGauss As New GaussJordan
    Public m As Integer
    Public A(,), XX(), YY(,), X(), ipl As Double
    Function CambiarRenglon(ByVal i As Integer, ByVal n As Integer) As Boolean
        Try
            Dim v As Boolean = False
            Dim j, k As Integer
            For j = i + 1 To n
                If A(j, i) <> 0 Then
                    ReDim X(n + 2)
                    For k = i To n + 1
                        X(k) = A(i, k)
                        A(i, k) = A(j, k)
                        A(j, k) = X(k)
                    Next
                    v = True
                    Exit For
                End If
            Next
            Return v
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar resolver la operacion")
            Return False
        End Try
    End Function

    Function ResolverGauss(ByVal n As Integer) As Boolean
        Try
            Dim i, j, k As Integer
            Dim mi, mj As Double
            Dim v As Boolean = True

            For i = 0 To n
                If A(i, i) = 0 Then
                    v = CambiarRenglon(i, n)
                End If
                If v = False Then
                    Exit For
                End If
                For j = 0 To n
                    If i <> j And A(j, i) <> 0 Then
                        mi = -A(i, i)
                        mj = A(j, i)
                        'MsgBox(mi & "  " & mj)
                        For k = 0 To n + 1
                            A(i, k) *= mj
                            A(j, k) *= mi
                            A(j, k) += A(i, k)
                            'MsgBox(A(j, k))
                        Next
                    End If
                Next
            Next
            Return v
        Catch ex As Exception
            MsgBox("Ocurrio un erro al intentar resolver la operacion")
            Return False
        End Try
    End Function

    Function MaxCD(ByVal a As Double, ByVal b As Double) As Integer
        Try
            If a < 0 Then
                a = -a
            End If
            If b < 0 Then
                b = -b
            End If
            Dim mcd As Integer = 1
            Dim lim As Integer = Math.Round(a)
            Dim i As Integer
            If a > b Then
                lim = Math.Round(b)
            End If
            For i = 2 To lim
                If a Mod i = 0 And b Mod i = 0 Then
                    a /= i
                    b /= i
                    lim /= i
                    mcd *= i
                    i -= 1
                End If
            Next
            Return mcd
        Catch ex As Exception
            '   MsgBox("algo3")
            Return 1
        End Try
    End Function

    Sub Limpiar(ByRef a As DataGridView)
        Try
            a.RowCount = 1
            a.Item(0, 0).Value = ""
            a.Item(1, 0).Value = ""
            a.Item(2, 0).Value = ""
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
End Module
