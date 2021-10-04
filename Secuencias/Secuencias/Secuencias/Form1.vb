Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_on.Click
        B_sec_1.Visible = True
        B_sec_2.Visible = True
        B_sec_3.Visible = True

        B_vel_1.Visible = True
        B_vel_2.Visible = True
        B_vel_3.Visible = True


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles B_vel_1.Click

    End Sub

    Private Sub B_off_Click(sender As Object, e As EventArgs) Handles B_off.Click
        B_sec_1.Visible = False
        B_sec_2.Visible = False
        B_sec_3.Visible = False

        B_vel_1.Visible = False
        B_vel_2.Visible = False
        B_vel_3.Visible = False

        Timer1.Enabled = False
        Timer2.Enabled = False

        on_1.Visible = False
        on_2.Visible = False
        on_3.Visible = False
        on_4.Visible = False
        on_5.Visible = False
        on_6.Visible = False
        on_7.Visible = False
        on_8.Visible = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles on_1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al iniciar el programa todo esta desactivado, solo se activa si se pone en 1 el switch principal
        B_sec_1.Visible = False
        B_sec_2.Visible = False
        B_sec_3.Visible = False

        B_vel_1.Visible = False
        B_vel_2.Visible = False
        B_vel_3.Visible = False
        Timer1.Enabled = False

        on_1.Visible = False
        on_2.Visible = False
        on_3.Visible = False
        on_4.Visible = False
        on_5.Visible = False
        on_6.Visible = False
        on_7.Visible = False
        on_8.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If on_1.Visible = True Then
            on_1.Visible = False
        Else
            on_1.Visible = True
        End If

        If on_2.Visible = True Then
            on_2.Visible = False
        Else
            on_2.Visible = True
        End If

        If on_3.Visible = True Then
            on_3.Visible = False
        Else
            on_3.Visible = True
        End If
        If on_4.Visible = True Then
            on_4.Visible = False
        Else
            on_4.Visible = True
        End If
        If on_5.Visible = True Then
            on_5.Visible = False
        Else
            on_5.Visible = True
        End If
        If on_6.Visible = True Then
            on_6.Visible = False
        Else
            on_6.Visible = True
        End If
        If on_7.Visible = True Then
            on_7.Visible = False
        Else
            on_7.Visible = True
        End If
        If on_8.Visible = True Then
            on_8.Visible = False
        Else
            on_8.Visible = True
        End If






    End Sub

    Private Sub B_sec_1_Click(sender As Object, e As EventArgs) Handles B_sec_1.Click
        Timer1.Enabled = True
        Timer2.Enabled = False
        Timer3.Enabled = False
        SerialPort1.Write("1" + Chr(13))




    End Sub

    Private Sub B_sec_2_Click(sender As Object, e As EventArgs) Handles B_sec_2.Click
        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer3.Enabled = False
        SerialPort1.Write("2" + Chr(13))




    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If on_1.Visible = True Then
            on_1.Visible = False
            on_2.Visible = True
            on_3.Visible = False
            on_4.Visible = True
            on_5.Visible = False
            on_6.Visible = True
            on_7.Visible = False
            on_8.Visible = True
        Else
            on_8.Visible = False
            on_7.Visible = True
            on_6.Visible = False
            on_5.Visible = True
            on_4.Visible = False
            on_3.Visible = True
            on_2.Visible = False
            on_1.Visible = True
        End If


    End Sub

    Private Sub B_sec_3_Click(sender As Object, e As EventArgs) Handles B_sec_3.Click
        Timer3.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If on_1.Visible = True Then
            on_8.Visible = True
            on_7.Visible = True
            on_6.Visible = True
            on_5.Visible = True
            on_4.Visible = True
            on_3.Visible = True
            on_2.Visible = True
            on_1.Visible = True
        ElseIf on_1.Visible = False
            on_8.Visible = True
            on_7.Visible = True
            on_6.Visible = True
            on_5.Visible = True
            on_4.Visible = True
            on_3.Visible = True
            on_2.Visible = False
            on_1.Visible = True
        ElseIf on_1.Visible = True
            on_8.Visible = True
            on_7.Visible = True
            on_6.Visible = True
            on_5.Visible = True
            on_4.Visible = True
            on_3.Visible = False
            on_2.Visible = True
            on_1.Visible = True
        ElseIf on_1.Visible = False
            on_8.Visible = True
            on_7.Visible = True
            on_6.Visible = True
            on_5.Visible = True
            on_4.Visible = False
            on_3.Visible = True
            on_2.Visible = True
            on_1.Visible = True

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Buscar.Click
        ListaPuertos.Items.Clear()
        For Each puertoDisponible As String In My.Computer.Ports.SerialPortNames
            ListaPuertos.Items.Add(puertoDisponible)
        Next
        If ListaPuertos.Items.Count > 0 Then
            ListaPuertos.Text = ListaPuertos.Items(0)
            MessageBox.Show("Seleccione un puerto disponible")
            Conectar.Enabled = True
        Else
            MessageBox.Show("Ningun puerto seleccionado")
            Conectar.Enabled = False
            ListaPuertos.Items.Clear()
            ListaPuertos.Text = ("")

        End If
    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        If Conectar.Text = "Conectar" Then
            SerialPort1.PortName = ListaPuertos.Text
            Conectar.Text = "Desconectar"
            Buscar.Enabled = False
            SerialPort1.Open()
            'ListaPuertos.Text = ""
            'ListaPuertos.Focus()
        ElseIf Conectar.Text = "Desconectar" Then
            Conectar.Text = "Conectar"
            Buscar.Enabled = True
            SerialPort1.Close()
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub ListaPuertos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPuertos.SelectedIndexChanged

    End Sub
End Class
