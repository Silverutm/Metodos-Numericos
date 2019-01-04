Public Class Metodos
    Dim nn, met As Integer
    Dim cv As Integer = 1
    Private Sub N_ValueChanged(sender As Object, e As EventArgs) Handles N.ValueChanged
        Try
            NLs.Maximum = N.Value
            NLi.Maximum = N.Value - 1
            nn = N.Value
            TablaEntrada.RowCount = nn + 1
            If nn > cv Then
                TIC.Columns(cv).Visible = True
                TINC.Columns(cv).Visible = True
            ElseIf nn < cv Then
                TIC.Columns(cv - 1).Visible = False
                TINC.Columns(cv - 1).Visible = False
            End If
            cv = nn
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub LSalir_Click(sender As Object, e As EventArgs) Handles LSalir.Click
        End
    End Sub

    Private Sub LRegresar_Click(sender As Object, e As EventArgs) Handles LRegresar.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Inter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Inter.SelectedIndexChanged
        Try
            If Inter.SelectedIndex = 3 Then
                TablaEntrada.Columns(2).Visible = True
            Else
                TablaEntrada.Columns(2).Visible = False
            End If
            met = Inter.SelectedIndex
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub Extra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Extra.SelectedIndexChanged
        Try
            TablaEntrada.Columns(2).Visible = False
            met = Extra.SelectedIndex + 5
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub GTabla_Click(sender As Object, e As EventArgs) Handles GTabla.Click
        Try
            Dim i, j As Integer
            ReDim XX(2 * nn + 2)
            ReDim YY(2 * nn + 2, 2 * nn + 2)

            For i = 0 To nn
                XX(i) = TablaEntrada.Item(0, i).Value
                YY(i, 0) = TablaEntrada.Item(1, i).Value
            Next
            Select Case met
                Case 0

                Case 1
                    TIC.RowCount = nn
                    DifFin(TIC, nn)
                Case 2
                    TINC.RowCount = nn
                    DifDiv(TINC, nn)
                Case 5
                    m = NGrado.Value
                    ReDim XM(2 * m + 5)
                    ReDim XY(m + 5)
                    For i = 0 To 2 * m
                        XM(i) = 0
                        For j = 0 To nn
                            XM(i) += Math.Pow(XX(j), i)
                        Next
                    Next
                    For i = 0 To m
                        XY(i) = 0
                        For j = 0 To nn
                            XY(i) += Math.Pow(XX(j), i) * YY(j, 0)
                        Next
                    Next
                    ipl = Ningresado.Text
                    FGauss.Show()
            End Select
            'TH.RowCount = 2 * (nn + 1)
            'Hermite(TH, nn)
        Catch ex As Exception
            MsgBox("Error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub NLi_ValueChanged(sender As Object, e As EventArgs) Handles NLi.ValueChanged
        NLs.Minimum = NLi.Value + 1
    End Sub

    Private Sub BSimp_Click(sender As Object, e As EventArgs) Handles BSimp.Click
        Try
            'Try
            Dim Area, h As Double
            Dim i, x0, xn, xp As Integer
            x0 = NLi.Value
            xn = NLs.Value
            xp = xn
            Dim comodin As Integer = (xn - x0) Mod 3

            ReDim XX(xn + 1)
            For i = x0 To xn
                XX(i) = TablaEntrada.Item(1, i).Value
            Next

            Select Case comodin
                Case 2
                    xn -= 2
                Case 1
                    xn -= 4
            End Select
            If xn < x0 Then
                MsgBox("Intervalos equivocados")
                Exit Sub
            End If

            If xn = x0 Then
                'MsgBox("d")
                Area = 0
            Else
                h = (TablaEntrada.Item(0, xn).Value - TablaEntrada.Item(0, x0).Value) / (xn - x0)
                Area = Area38(x0, xn, h)
                'MsgBox("w")
            End If

            If Not xn = xp Then
                h = (TablaEntrada.Item(0, xp).Value - TablaEntrada.Item(0, xn).Value) / (xp - xn)
                Area += Area13(xn, xp, h)
                'MsgBox("dsasa")
            Else
                'MsgBox("e")
            End If

            MsgBox(Area)
            'Catch ex As Exception
            '   MsgBox("eeradda")
            'End Try
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub Generarfx_Click(sender As Object, e As EventArgs) Handles Generarfx.Click
        Try
            Dim interpolar As Double = Ningresado.Text
            Select Case met
                Case 0
                    MsgBox("Lagrange" & Lagranch(nn, interpolar))
                Case 1
                    Dim k As Double = (interpolar - XX(0)) / (XX(1) - XX(0))
                    RIC.RowCount = RIC.RowCount + 1
                    RIC.Item(0, RIC.RowCount - 1).Value = CStr(InterDifFin(nn, interpolar, k))
                Case 2
                    RINC.RowCount = RINC.RowCount + 1
                    RINC.Item(0, RINC.RowCount - 1).Value = CStr(InterDifDiv(nn, interpolar))
                Case 5

            End Select
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar hacer la operacion")
        End Try
    End Sub

    Private Sub Metodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class