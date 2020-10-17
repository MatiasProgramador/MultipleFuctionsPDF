Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class TextoaPDF
    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtTexto.Text = ""
    End Sub

    Private Sub Btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        If txttexto.Text = "" Then
            MsgBox("Debe introducir el texto a convertir a PDF.",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txttexto.Focus()
        Else
            If txtdestino.Text = "" Then
                MsgBox("Debe indicar el fichero PDF destino de la conversión del texto.",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                txtdestino.Focus()
            Else
                Try
                    Dim documentoPDF As New Document
                    PdfWriter.GetInstance(documentoPDF,
                        New FileStream(txtdestino.Text, FileMode.Create))
                    documentoPDF.Open()

                    documentoPDF.Add(New Paragraph(txttexto.Text,
                          FontFactory.GetFont(FontFactory.TIMES, 11,
                              iTextSharp.text.Font.NORMAL)))

                    documentoPDF.AddAuthor(txtautor.Text)
                    documentoPDF.AddKeywords(txtpalabra.Text)
                    documentoPDF.AddSubject(txtasunto.Text)
                    documentoPDF.AddTitle(txttitulo.Text)
                    documentoPDF.AddCreationDate()

                    documentoPDF.Close()

                    If System.IO.File.Exists(txtdestino.Text) Then
                        If MsgBox("Texto convertido a fichero PDF correctamente " +
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
                    MsgBox("Se ha producido un error al intentar convertir el texto a PDF: " +
                        vbCrLf + vbCrLf + ex.Message,
                        MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
            End If
        End If
    End Sub

    Private Sub Btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Dim dlGuardar As New SaveFileDialog
        dlGuardar.CheckFileExists = False
        dlGuardar.CheckPathExists = True
        dlGuardar.DefaultExt = "txt"
        dlGuardar.FileName = ""
        dlGuardar.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
        dlGuardar.Title = "Fichero PDF destino"
        If dlGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtdestino.Text = dlGuardar.FileName
        End If
    End Sub

    Private Sub formPDF_Load(sender As System.Object,
                e As System.EventArgs) Handles MyBase.Load
        txtdestino.Text =
            System.IO.Path.Combine(System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments), "documento.pdf")
    End Sub

    Private Sub Btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
        MenuPrincipal.Visible = True
    End Sub
End Class
