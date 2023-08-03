Public Class Form1
    Dim coordenadaX As Integer = 0
    Dim coordenadaY As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'función para generar pseudoaleatorios
        Randomize()
        'se generan 2 valores aleatorios
        coordenadaX = CInt((Rnd() * (200 - 100) + 100)) 'inf=100 sup=400 aleatorio*(supinf)+inf
        coordenadaY = CInt((Rnd() * (200 - 100) + 100)) 'inf=100 sup=400 aleatorio*(supinf)+inf
        'Se muestran los valores aleatorios en las cajas de texto
        TextBox1.Text = coordenadaX
        TextBox2.Text = coordenadaY
    End Sub
End Class
