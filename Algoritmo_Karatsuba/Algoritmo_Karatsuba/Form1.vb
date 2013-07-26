Imports System.Numerics

Public Class Aplicacion


    Private karatsuba As New Karatsuba

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_multiplicar.Click
        Try
            Dim num1 As BigInteger = BigInteger.Parse(TB_numero1.Text.Trim.ToString)
            Try
                Dim num2 As BigInteger = BigInteger.Parse(TB_numero2.Text.Trim.ToString)
                Try
                    TB_resultado.Text = karatsuba.multiplicarKaratsuba(num1, num2).ToString
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MessageBox.Show("Error en la multiplicacion, verifique que los numeros sean enteros positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error el Numero2 debe ser un entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            MessageBox.Show("Error el Numero1 debe ser un entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TB_numero1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_numero1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub TB_numero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_numero2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BT_limpiar.Click
        TB_numero1.Text = ""
        TB_numero2.Text = ""
        TB_resultado.Text = ""
    End Sub
End Class
