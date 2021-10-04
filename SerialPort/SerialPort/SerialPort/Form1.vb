Public Class Form1
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Write("1" + Chr(13))
    End Sub
End Class
