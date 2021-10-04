Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPuertos.SelectedIndexChanged

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "ON" Then
            Button1.BackColor = Color.FromArgb(0, 196, 72, 72) 'alpha, red, green, blue
            Button1.ForeColor = Color.White
            Button1.Text = "OFF"
        ElseIf Button1.Text = "OFF" Then
            Button1.BackColor = Color.FromArgb(200, 196, 72, 72) 'alpha, red, green, blue
            Button1.ForeColor = Color.Red
            Button1.Text = "ON"
        End If




    End Sub
End Class
