Public Class MenuPrincipal


    Private Sub Btnformtexto_Click(sender As Object, e As EventArgs) Handles btnformtexto.Click
        Me.Hide()
        TextoaPDF.Show()
    End Sub

    Private Sub Btnformimagen_Click(sender As Object, e As EventArgs) Handles btnformimagen.Click
        Me.Hide()
        ImagenaPDF.Show()
    End Sub

    Private Sub Btnformunir_Click(sender As Object, e As EventArgs) Handles btnformunir.Click
        Me.Hide()
        UnirPDF.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DividirPDF.Show()
    End Sub


End Class