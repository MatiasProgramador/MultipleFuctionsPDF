Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class ImagenaPDF


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dlBuscar As New OpenFileDialog

        dlBuscar.ShowDialog()
        PictureBox1.ImageLocation = dlBuscar.FileName

    End Sub



    Private Sub Btnconvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        If txtdestino.Text = "" Then
            MsgBox("Debe indicar el fichero PDF destino de la union de archivos.",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txtdestino.Focus()
        Else
            Try
                Dim documentoPDF As New Document
                PdfWriter.GetInstance(documentoPDF,
                    New FileStream(txtdestino.Text, FileMode.Create))
                documentoPDF.Open()
                Dim imagen = iTextSharp.text.Image.GetInstance(PictureBox1.ImageLocation)
                imagen.BorderWidth = 0
                imagen.Alignment = Element.ALIGN_LEFT

                documentoPDF.Add(imagen)

                documentoPDF.AddAuthor(txtautor.Text)
                documentoPDF.AddKeywords(txtpalabra.Text)
                documentoPDF.AddSubject(txtasunto.Text)
                documentoPDF.AddTitle(txttitulo.Text)
                documentoPDF.AddCreationDate()

                documentoPDF.Close()

                If System.IO.File.Exists(txtdestino.Text) Then
                    If MsgBox("Imagen convertida a fichero PDF correctamente " +
                           "¿desea abrir el fichero PDF resultante?",
                           MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        System.Diagnostics.Process.Start(txtdestino.Text)
                    End If
                Else
                    MsgBox("El fichero PDF no se ha generado, " +
                           "compruebe que tiene permisos en la carpeta de destino.",
                           MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                End If
            Catch ex As Exception
                MsgBox("Se ha producido un error al intentar convertir la imagen a PDF: " +
                    vbCrLf + vbCrLf + ex.Message,
                    MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub

    Private Sub Btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Dim dlGuardar As New SaveFileDialog
        dlGuardar.CheckFileExists = False
        dlGuardar.CheckPathExists = True
        dlGuardar.DefaultExt = "jpg"
        dlGuardar.FileName = ""
        dlGuardar.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
        dlGuardar.Title = "Fichero PDF destino"
        If dlGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtdestino.Text = dlGuardar.FileName
        End If
    End Sub

    Private Sub Btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
        MenuPrincipal.Visible = True
    End Sub
End Class