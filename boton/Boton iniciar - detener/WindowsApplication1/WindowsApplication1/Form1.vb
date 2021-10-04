Public Class Form1
    'declaramos la variable q se va a usar como contador
    Dim a As Integer


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'iniciamos el contador en 1
        a = 1
        Button1.Text = "  Iniciar"
        'la ruta de la imagen para cargar
        Button1.Image = Image.FromFile("tu direccion de imagen\go.png")
        'corremos el codigo pero antes..
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If a = 1 Then
            Button1.Text = "  Detener"
            'la direccion de la imagen tiene q ser correcta
            'Button1.Image = Image.FromFile("tu direccion de imagen\time.png")
            'aqui ponen el codigo que quieran

        ElseIf a = 0 Then
            Button1.Text = "  Iniciar"
            'la direccion de la imagen tiene q ser correcta
            ' Button1.Image = Image.FromFile("tu direccion de imagen \go.png")
            'aqui ponen el codigo que quieran

        End If
        a = a + 1
        'limitamos el contador a 2
        If a = 2 Then
            a = 0
            ' Y se repite la misma historia jjj
        End If

        'ESO ES TODO..


    End Sub
End Class
