<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion
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
        Me.BT_multiplicar = New System.Windows.Forms.Button()
        Me.TB_numero1 = New System.Windows.Forms.TextBox()
        Me.TB_numero2 = New System.Windows.Forms.TextBox()
        Me.TB_resultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_limpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BT_multiplicar
        '
        Me.BT_multiplicar.Location = New System.Drawing.Point(212, 147)
        Me.BT_multiplicar.Name = "BT_multiplicar"
        Me.BT_multiplicar.Size = New System.Drawing.Size(89, 23)
        Me.BT_multiplicar.TabIndex = 0
        Me.BT_multiplicar.Text = " Multiplicar"
        Me.BT_multiplicar.UseVisualStyleBackColor = True
        '
        'TB_numero1
        '
        Me.TB_numero1.BackColor = System.Drawing.Color.White
        Me.TB_numero1.Location = New System.Drawing.Point(93, 22)
        Me.TB_numero1.Multiline = True
        Me.TB_numero1.Name = "TB_numero1"
        Me.TB_numero1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB_numero1.Size = New System.Drawing.Size(481, 49)
        Me.TB_numero1.TabIndex = 1
        '
        'TB_numero2
        '
        Me.TB_numero2.Location = New System.Drawing.Point(93, 88)
        Me.TB_numero2.Multiline = True
        Me.TB_numero2.Name = "TB_numero2"
        Me.TB_numero2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB_numero2.Size = New System.Drawing.Size(481, 53)
        Me.TB_numero2.TabIndex = 2
        '
        'TB_resultado
        '
        Me.TB_resultado.Location = New System.Drawing.Point(93, 173)
        Me.TB_resultado.Multiline = True
        Me.TB_resultado.Name = "TB_resultado"
        Me.TB_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB_resultado.Size = New System.Drawing.Size(481, 99)
        Me.TB_resultado.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'BT_limpiar
        '
        Me.BT_limpiar.Location = New System.Drawing.Point(358, 147)
        Me.BT_limpiar.Name = "BT_limpiar"
        Me.BT_limpiar.Size = New System.Drawing.Size(87, 23)
        Me.BT_limpiar.TabIndex = 7
        Me.BT_limpiar.Text = " Limpiar"
        Me.BT_limpiar.UseVisualStyleBackColor = True
        '
        'Aplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(579, 286)
        Me.Controls.Add(Me.BT_limpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_resultado)
        Me.Controls.Add(Me.TB_numero2)
        Me.Controls.Add(Me.TB_numero1)
        Me.Controls.Add(Me.BT_multiplicar)
        Me.Name = "Aplicacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Karatsuba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_multiplicar As System.Windows.Forms.Button
    Friend WithEvents TB_numero1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_numero2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_resultado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BT_limpiar As System.Windows.Forms.Button

End Class
