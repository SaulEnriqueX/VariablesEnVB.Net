Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As Date
        fecha = Date.Now
        lblFecha.Text = fecha

        Dim mensaje As String
        mensaje = "Ingrese los campos"
        lblMensaje.Text = mensaje



    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim n1 As Double
        n1 = txtuno.Text

        Dim n2 As Double
        n2 = txtdos.Text

        Dim res As Double
        res = n1 + n2
        txtResultado.Text = res








    End Sub
End Class
