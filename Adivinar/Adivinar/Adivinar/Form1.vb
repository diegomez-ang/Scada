Public Class Form1
    Dim numero As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dato
        For i = 1 To 10
            dato = InputBox("Ingresa un número entre 1 y 999", "Juega",, 200, 200)

            If IsNumeric(dato) Then
                If dato > numero Then
                    intento.Text += vbCrLf & "Número ingresado: " & dato.ToString() & " El número es menor"
                    Label3.Text = i
                ElseIf dato < numero Then
                    intento.Text += vbCrLf & "Número ingresado: " & dato.ToString() & " El número es mayor"
                    Label3.Text = i
                Else
                    'intento.ForeColor = Rnd()

                    intento.Text += vbCrLf & "¡GANASTE! el número era " & numero.ToString()

                    Exit For
                End If
            Else
                If dato = "" Then Exit For
                MsgBox("Solo Numeros, pierdes un intento")
                Label3.Text = i
            End If
            If i = 10 Then
                intento.Text += vbCrLf & "Perdiste, el número era: " & numero.ToString()
                Exit For
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        numero = CInt(Int((999 * Rnd()) + 1))
        numero_generado.Text = numero


    End Sub

    Private Sub numero_generado_Click(sender As Object, e As EventArgs) Handles numero_generado.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
