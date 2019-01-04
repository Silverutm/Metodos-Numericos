<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Mn = New System.Windows.Forms.Label()
        Me.Gj = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Mn
        '
        Me.Mn.AutoSize = True
        Me.Mn.BackColor = System.Drawing.Color.Transparent
        Me.Mn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mn.ForeColor = System.Drawing.Color.Red
        Me.Mn.Location = New System.Drawing.Point(19, 75)
        Me.Mn.Name = "Mn"
        Me.Mn.Size = New System.Drawing.Size(260, 59)
        Me.Mn.TabIndex = 0
        Me.Mn.Text = "Metodos Numericos II"
        '
        'Gj
        '
        Me.Gj.AutoSize = True
        Me.Gj.BackColor = System.Drawing.Color.Transparent
        Me.Gj.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gj.ForeColor = System.Drawing.Color.Red
        Me.Gj.Location = New System.Drawing.Point(305, 217)
        Me.Gj.Name = "Gj"
        Me.Gj.Size = New System.Drawing.Size(168, 59)
        Me.Gj.TabIndex = 1
        Me.Gj.Text = "Gauss-Jordan"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Trucos_Numericos_II.My.Resources.Resources.i2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 418)
        Me.Controls.Add(Me.Gj)
        Me.Controls.Add(Me.Mn)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mn As System.Windows.Forms.Label
    Friend WithEvents Gj As System.Windows.Forms.Label
End Class
