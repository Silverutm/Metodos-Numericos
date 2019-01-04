<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GaussJordan
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Matriz = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VectorR = New System.Windows.Forms.DataGridView()
        Me.r1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resolver = New System.Windows.Forms.Label()
        Me.Numeric = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LRegresar = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Label()
        Me.LCargarM = New System.Windows.Forms.Label()
        Me.LEsconder = New System.Windows.Forms.Label()
        Me.Linterpolar = New System.Windows.Forms.Label()
        CType(Me.Matriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VectorR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Matriz
        '
        Me.Matriz.AllowUserToAddRows = False
        Me.Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Matriz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.c2, Me.c3, Me.c4, Me.C5, Me.C6, Me.C7, Me.C8, Me.C9, Me.C10, Me.C11})
        Me.Matriz.Location = New System.Drawing.Point(31, 65)
        Me.Matriz.Name = "Matriz"
        Me.Matriz.Size = New System.Drawing.Size(440, 251)
        Me.Matriz.TabIndex = 0
        '
        'C1
        '
        Me.C1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C1.HeaderText = ""
        Me.C1.MaxInputLength = 15
        Me.C1.MinimumWidth = 10
        Me.C1.Name = "C1"
        Me.C1.Width = 19
        '
        'c2
        '
        Me.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c2.HeaderText = ""
        Me.c2.MaxInputLength = 15
        Me.c2.MinimumWidth = 10
        Me.c2.Name = "c2"
        Me.c2.Width = 19
        '
        'c3
        '
        Me.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c3.HeaderText = ""
        Me.c3.MaxInputLength = 15
        Me.c3.MinimumWidth = 10
        Me.c3.Name = "c3"
        Me.c3.Visible = False
        '
        'c4
        '
        Me.c4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c4.HeaderText = ""
        Me.c4.MaxInputLength = 15
        Me.c4.MinimumWidth = 10
        Me.c4.Name = "c4"
        Me.c4.Visible = False
        '
        'C5
        '
        Me.C5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C5.HeaderText = ""
        Me.C5.MaxInputLength = 15
        Me.C5.MinimumWidth = 10
        Me.C5.Name = "C5"
        Me.C5.Visible = False
        '
        'C6
        '
        Me.C6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C6.HeaderText = ""
        Me.C6.MaxInputLength = 15
        Me.C6.MinimumWidth = 10
        Me.C6.Name = "C6"
        Me.C6.Visible = False
        '
        'C7
        '
        Me.C7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C7.HeaderText = ""
        Me.C7.MaxInputLength = 15
        Me.C7.MinimumWidth = 10
        Me.C7.Name = "C7"
        Me.C7.Visible = False
        '
        'C8
        '
        Me.C8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C8.HeaderText = ""
        Me.C8.MaxInputLength = 15
        Me.C8.MinimumWidth = 10
        Me.C8.Name = "C8"
        Me.C8.Visible = False
        '
        'C9
        '
        Me.C9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C9.HeaderText = ""
        Me.C9.MaxInputLength = 15
        Me.C9.MinimumWidth = 10
        Me.C9.Name = "C9"
        Me.C9.Visible = False
        '
        'C10
        '
        Me.C10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C10.HeaderText = ""
        Me.C10.MaxInputLength = 15
        Me.C10.MinimumWidth = 10
        Me.C10.Name = "C10"
        Me.C10.Visible = False
        '
        'C11
        '
        Me.C11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.C11.HeaderText = ""
        Me.C11.MaxInputLength = 15
        Me.C11.MinimumWidth = 10
        Me.C11.Name = "C11"
        Me.C11.Visible = False
        '
        'VectorR
        '
        Me.VectorR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VectorR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.r1, Me.res, Me.R2})
        Me.VectorR.Location = New System.Drawing.Point(498, 102)
        Me.VectorR.Name = "VectorR"
        Me.VectorR.Size = New System.Drawing.Size(235, 253)
        Me.VectorR.TabIndex = 1
        '
        'r1
        '
        Me.r1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.r1.HeaderText = "Xi"
        Me.r1.MinimumWidth = 10
        Me.r1.Name = "r1"
        Me.r1.ReadOnly = True
        Me.r1.Width = 41
        '
        'res
        '
        Me.res.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.res.HeaderText = "Respuesta"
        Me.res.MinimumWidth = 10
        Me.res.Name = "res"
        Me.res.ReadOnly = True
        Me.res.Width = 83
        '
        'R2
        '
        Me.R2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.R2.HeaderText = "Resp"
        Me.R2.MinimumWidth = 10
        Me.R2.Name = "R2"
        Me.R2.ReadOnly = True
        Me.R2.Width = 57
        '
        'Resolver
        '
        Me.Resolver.AutoSize = True
        Me.Resolver.Location = New System.Drawing.Point(406, 419)
        Me.Resolver.Name = "Resolver"
        Me.Resolver.Size = New System.Drawing.Size(49, 13)
        Me.Resolver.TabIndex = 2
        Me.Resolver.Text = "Resolver"
        '
        'Numeric
        '
        Me.Numeric.Location = New System.Drawing.Point(216, 28)
        Me.Numeric.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Numeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Numeric.Name = "Numeric"
        Me.Numeric.Size = New System.Drawing.Size(47, 20)
        Me.Numeric.TabIndex = 3
        Me.Numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escoja el tamano de la matriz"
        '
        'LRegresar
        '
        Me.LRegresar.AutoSize = True
        Me.LRegresar.Location = New System.Drawing.Point(495, 447)
        Me.LRegresar.Name = "LRegresar"
        Me.LRegresar.Size = New System.Drawing.Size(50, 13)
        Me.LRegresar.TabIndex = 5
        Me.LRegresar.Text = "Regresar"
        '
        'Salir
        '
        Me.Salir.AutoSize = True
        Me.Salir.Location = New System.Drawing.Point(495, 419)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(27, 13)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        '
        'LCargarM
        '
        Me.LCargarM.AutoSize = True
        Me.LCargarM.Location = New System.Drawing.Point(46, 396)
        Me.LCargarM.Name = "LCargarM"
        Me.LCargarM.Size = New System.Drawing.Size(69, 13)
        Me.LCargarM.TabIndex = 7
        Me.LCargarM.Text = "Cargar Matriz"
        '
        'LEsconder
        '
        Me.LEsconder.AutoSize = True
        Me.LEsconder.Location = New System.Drawing.Point(46, 447)
        Me.LEsconder.Name = "LEsconder"
        Me.LEsconder.Size = New System.Drawing.Size(52, 13)
        Me.LEsconder.TabIndex = 8
        Me.LEsconder.Text = "Esconder"
        '
        'Linterpolar
        '
        Me.Linterpolar.AutoSize = True
        Me.Linterpolar.Location = New System.Drawing.Point(46, 419)
        Me.Linterpolar.Name = "Linterpolar"
        Me.Linterpolar.Size = New System.Drawing.Size(103, 13)
        Me.Linterpolar.TabIndex = 9
        Me.Linterpolar.Text = "Interpolar/Extrapolar"
        '
        'GaussJordan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Trucos_Numericos_II.My.Resources.Resources.i6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(745, 520)
        Me.Controls.Add(Me.Linterpolar)
        Me.Controls.Add(Me.LEsconder)
        Me.Controls.Add(Me.LCargarM)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.LRegresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Numeric)
        Me.Controls.Add(Me.Resolver)
        Me.Controls.Add(Me.VectorR)
        Me.Controls.Add(Me.Matriz)
        Me.Name = "GaussJordan"
        Me.Text = "GaussJordan"
        CType(Me.Matriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VectorR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Matriz As System.Windows.Forms.DataGridView
    Friend WithEvents VectorR As System.Windows.Forms.DataGridView
    Friend WithEvents Resolver As System.Windows.Forms.Label
    Friend WithEvents Numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents r1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents res As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LRegresar As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Label
    Friend WithEvents LCargarM As System.Windows.Forms.Label
    Friend WithEvents LEsconder As System.Windows.Forms.Label
    Friend WithEvents Linterpolar As System.Windows.Forms.Label
End Class
