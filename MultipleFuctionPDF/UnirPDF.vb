Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class UnirPDF
    Private Sub Btnabrir1_Click(sender As Object, e As EventArgs) Handles btnabrir1.Click
        OpenFileDialog1.Filter = "PDF ARCHIVOS | *.pdf"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Btnabrir2_Click(sender As Object, e As EventArgs) Handles btnabrir2.Click
        OpenFileDialog1.Filter = "PDF ARCHIVOS | *.pdf"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF2.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Btnunir_Click(sender As Object, e As EventArgs) Handles btnunir.Click
        If txtdestino.Text = "" Then
            MsgBox("Debe indicar el fichero PDF destino de la union de archivos.",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txtdestino.Focus()
        Else
            Try
                Dim PDF1 As New PdfReader(AxAcroPDF1.src)
        Dim PDF2 As New PdfReader(AxAcroPDF2.src)
        Dim PDFNuevo As New Document
        Dim Juntar As New PdfCopy(PDFNuevo, New FileStream(txtdestino.Text, FileMode.Create))
        PDFNuevo.Open()

                Dim Importa1 As PdfImportedPage = Juntar.GetImportedPage(PDF1, 1)
        Dim Importa2 As PdfImportedPage = Juntar.GetImportedPage(PDF2, 1)

        Juntar.AddPage(Importa1)
        Juntar.AddPage(Importa2)

        PDF1.Close()
        PDF2.Close()
        Juntar.Close()
        PDFNuevo.Close()

                If System.IO.File.Exists(txtdestino.Text) Then
                    If MsgBox("Union de archivos Pdf realizada correctamente " +
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
                MsgBox("Se ha producido un error al intentar unir archivos PDF: " +
                    vbCrLf + vbCrLf + ex.Message,
                    MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub

    Private Sub Btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Dim dlGuardar As New SaveFileDialog
        dlGuardar.CheckFileExists = False
        dlGuardar.CheckPathExists = True
        dlGuardar.DefaultExt = "pdf"
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Txtdestino_TextChanged(sender As Object, e As EventArgs) Handles txtdestino.TextChanged

    End Sub
End Class