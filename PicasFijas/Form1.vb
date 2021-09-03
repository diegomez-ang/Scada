Public Class PP

    Dim Num As Integer = 0
    Dim ST As String
    Dim Conteo As Integer = 1

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click

        If Numero.TextLength = 3 Then
            If Conteo < 10 Then
                Dim nIn = Numero.Text

                Dim p, f As Integer
                p = 0
                f = 0

                ' Fijas
                For i = 0 To 2
                    If nIn(i) = ST(i) Then
                        f = f + 1
                    End If
                Next

                ' 232 // Ingresado
                ' 122 // Original
                Dim foo As New List(Of String)

                For i = 0 To 2
                    If foo.IndexOf(nIn(i)) >= 0 Then
                    Else
                        If nIn(i) = ST(i) Then
                        Else
                            For j = 0 To 2
                                If nIn(i) = ST(j) Then
                                    p = p + 1
                                    foo.Add(nIn(i))
                                End If
                            Next
                        End If
                    End If
                Next

                Picas.Text = p
                Fijas.Text = f

                If f = 3 Then
                    Registro.Text += vbCrLf & "¡Ganaste!"
                    Validar.Enabled = False
                Else
                    Registro.Text += vbCrLf & Conteo &
                        "Ingresado: " & nIn & ". Picas: " & p & ". Fijas: " & f
                End If
            Else
                Registro.Text += vbCrLf & "¡¡¡ PERDISTE !!!"
                Validar.Enabled = False
            End If
            Conteo = Conteo + 1

        Else
            MsgBox("Debes ingresar tres números, solamente ingresaste: " & Numero.TextLength, MsgBoxStyle.Critical, "Datos incorrectos")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Num = CInt(Int((999 * Rnd()) + 1))
        MsgBox(Num)
        ST = Format(Num, "000")
        Validar.Enabled = True
        Registro.Text = "Intentos: "
        Picas.Text = 0
        Fijas.Text = 0
        Conteo = 1
        Numero.Text = ""
    End Sub

    Private Sub PP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
