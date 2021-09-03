Public Class Form1
    Dim N As Integer
    Dim M As Integer
    Dim Box As TextBox()
    Dim i As Integer
    Dim j As Integer
    Dim y As Integer
    Dim matrix(3, 3) As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SUMAR.Click
        R1.Text = Val(Box1.Text) + Val(TBox1.Text)
        R2.Text = Val(Box2.Text) + Val(TBox2.Text)
        R3.Text = Val(Box3.Text) + Val(TBox3.Text)
        R4.Text = Val(Box4.Text) + Val(TBox4.Text)
        R5.Text = Val(Box5.Text) + Val(TBox5.Text)
        R6.Text = Val(Box6.Text) + Val(TBox6.Text)
        R7.Text = Val(Box7.Text) + Val(TBox7.Text)
        R8.Text = Val(Box8.Text) + Val(TBox8.Text)
        R9.Text = Val(Box9.Text) + Val(TBox9.Text)

    End Sub

    Private Sub GENERAR_Click(sender As Object, e As EventArgs) Handles GENERAR.Click
        Dim matrix = New Integer()
        R1.Text = ""
        R2.Text = ""
        R3.Text = ""
        R4.Text = ""
        R5.Text = ""
        R6.Text = ""
        R7.Text = ""
        R8.Text = ""
        R9.Text = ""
        i = 0
        j = 0
        While i < 10
            Randomize()
            N = CInt(Int((10 * Rnd()) + 0))
            Randomize()
            M = CInt(Int((10 * Rnd()) + 0))
            If i < 10 Then

                i = i + 1

                If i = 1 Then
                    Box1.Text = N
                    TBox1.Text = M
                End If
                If i = 2 Then
                    Box2.Text = N
                    TBox2.Text = M
                End If
                If i = 3 Then
                    Box3.Text = N
                    TBox3.Text = M
                End If
                If i = 4 Then
                    Box4.Text = N
                    TBox4.Text = M
                End If
                If i = 5 Then
                    Box5.Text = N
                    TBox5.Text = M
                End If
                If i = 6 Then
                    Box6.Text = N
                    TBox6.Text = M
                End If

                If i = 7 Then
                    Box7.Text = N
                    TBox7.Text = M
                End If
                If i = 8 Then
                    Box8.Text = N
                    TBox8.Text = M
                End If
                If i = 9 Then
                    Box9.Text = N
                    TBox9.Text = M
                End If


            End If

        End While



    End Sub

    Private Sub RESTAR_Click(sender As Object, e As EventArgs) Handles RESTAR.Click
        R1.Text = Val(Box1.Text) - Val(TBox1.Text)
        R2.Text = Val(Box2.Text) - Val(TBox2.Text)
        R3.Text = Val(Box3.Text) - Val(TBox3.Text)
        R4.Text = Val(Box4.Text) - Val(TBox4.Text)
        R5.Text = Val(Box5.Text) - Val(TBox5.Text)
        R6.Text = Val(Box6.Text) - Val(TBox6.Text)
        R7.Text = Val(Box7.Text) - Val(TBox7.Text)
        R8.Text = Val(Box8.Text) - Val(TBox8.Text)
        R9.Text = Val(Box9.Text) - Val(TBox9.Text)
    End Sub

    Private Sub MULTI_Click(sender As Object, e As EventArgs) Handles MULTI.Click
        R1.Text = Val(Box1.Text) * Val(TBox1.Text) + Val(Box2.Text) * Val(TBox4.Text) + Val(Box3.Text) * Val(TBox7.Text)
        R2.Text = Val(Box1.Text) * Val(TBox2.Text) + Val(Box2.Text) * Val(TBox5.Text) + Val(Box3.Text) * Val(TBox8.Text)
        R3.Text = Val(Box1.Text) * Val(TBox3.Text) + Val(Box2.Text) * Val(TBox6.Text) + Val(Box3.Text) * Val(TBox9.Text)
        R4.Text = Val(Box4.Text) * Val(TBox1.Text) + Val(Box5.Text) * Val(TBox4.Text) + Val(Box6.Text) * Val(TBox7.Text)
        R5.Text = Val(Box4.Text) * Val(TBox2.Text) + Val(Box5.Text) * Val(TBox5.Text) + Val(Box6.Text) * Val(TBox8.Text)
        R6.Text = Val(Box4.Text) * Val(TBox3.Text) + Val(Box5.Text) * Val(TBox6.Text) + Val(Box6.Text) * Val(TBox9.Text)
        R7.Text = Val(Box7.Text) * Val(TBox1.Text) + Val(Box8.Text) * Val(TBox4.Text) + Val(Box9.Text) * Val(TBox7.Text)
        R8.Text = Val(Box7.Text) * Val(TBox2.Text) + Val(Box8.Text) * Val(TBox5.Text) + Val(Box9.Text) * Val(TBox8.Text)
        R9.Text = Val(Box7.Text) * Val(TBox3.Text) + Val(Box8.Text) * Val(TBox6.Text) + Val(Box9.Text) * Val(TBox9.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
