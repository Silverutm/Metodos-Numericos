Public Class GaussJordan
    Dim n As Integer
    Dim cv As Integer = 1
    Private Sub GaussJordan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Matriz.RowCount = 10
    End Sub

    Private Sub Resolver_Click(sender As Object, e As EventArgs) Handles Resolver.Click
        Try
            Dim i, j, mcd As Integer
            Dim v As Boolean
            Numeric.Focus()
            n = Numeric.Value - 1
            ReDim A(n + 1, n + 2)
            Try
                For i = 0 To n
                    For j = 0 To n + 1
                        'MsgBox(Matriz.Item(j, i).Value)
                        A(i, j) = Matriz.Item(j, i).Value
                    Next
                Next
            Catch ex As Exception
                Limpiar(VectorR)
                MsgBox("Ocurrio un error al cargar la matriz")
                Exit Sub
            End Try

            'Try
            v = ResolverGauss(n)
            If v = True Then
                VectorR.RowCount = n + 1
                For i = 0 To n
                    VectorR.Item(0, i).Value = "X" & i
                    VectorR.Item(1, i).Value = CStr(A(i, n + 1) / A(i, i))
                    'If A(i, n + 1) = Math.Round(A(i, n + 1)) Then
                    'MsgBox(A(i, n + 1))

                    'If A(i, i) = Math.Round(A(i, i)) Then
                    'If Math.Round(A(i, n + 1)) Mod Math.Round(A(i, i)) <> 0 Then
                    'mcd = MaxCD(A(i, n + 1), A(i, i))
                    'VectorR.Item(2, i).Value = A(i, n + 1) / mcd & " / " & A(i, i) / mcd
                    'End If
                    'End If
                    'Else
                    'VectorR.Item(2, i).Value = ""
                    'End If
                Next
            Else
                Limpiar(VectorR)
                MsgBox("No se pudo resolver")
            End If
            'Catch ex As Exception
            'MsgBox("Ocurrio un error al intentar resolver la matriz")
            ' End Try
        Catch ex As Exception
            MsgBox("Error al intentar hacer alguna operacion")
        End Try
    End Sub

    Private Sub Numeric_ValueChanged(sender As Object, e As EventArgs) Handles Numeric.ValueChanged
        Try
            Matriz.RowCount = Numeric.Value
            If Numeric.Value > cv Then
                Matriz.Columns.Item(cv + 1).Visible = True
            ElseIf Numeric.Value < cv Then
                Matriz.Columns.Item(cv).Visible = False
            End If
            cv = Numeric.Value
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub LRegresar_Click(sender As Object, e As EventArgs) Handles LRegresar.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub LCargarM_Click(sender As Object, e As EventArgs) Handles LCargarM.Click
        Try
            Dim i, j, k As Integer
            For i = 0 To m
                For j = 0 To m
                    Matriz.Item(j, i).Value = CStr(XM(2 * m - i - j))
                Next
            Next
            For j = 0 To m
                Matriz.Item(m + 1, j).Value = CStr(XY(m - j))
            Next
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub LEsconder_Click(sender As Object, e As EventArgs) Handles LEsconder.Click
        Me.Hide()
    End Sub

    Private Sub Linterpolar_Click(sender As Object, e As EventArgs) Handles Linterpolar.Click
        Try
            Dim yi As Double = 0
            Dim j As Integer
            For j = 0 To m
                'MsgBox(yi)
                yi += VectorR.Item(1, j).Value * Math.Pow(ipl, m - j)
            Next
            MsgBox("La respuesta es " & yi)
        Catch ex As Exception
            MsgBox("Error al hacer la operacion")
        End Try
    End Sub
End Class