Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.IO
Public Class DividirPDF
    Private Sub Btnpdforigen_Click(sender As Object, e As EventArgs) Handles btnpdforigen.Click
        Dim dlAbrir As New OpenFileDialog
        dlAbrir.CheckFileExists = True
        dlAbrir.CheckPathExists = True
        dlAbrir.Multiselect = False
        dlAbrir.DefaultExt = "pdf"
        dlAbrir.FileName = ""
        dlAbrir.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
        dlAbrir.Title = "Seleccionar fichero PDF a dividir y separar páginas"
        If dlAbrir.ShowDialog = DialogResult.OK Then

            txtpdforigen.Text = dlAbrir.FileName
        End If
    End Sub

    Private Sub Txtpdforigen_TextChanged(sender As Object, e As EventArgs) Handles txtpdforigen.TextChanged
        Dim rutaFicheroPDFOrigenDividir As String = txtpdforigen.Text
        If File.Exists(rutaFicheroPDFOrigenDividir) Then

            Try

                Dim ficheroPDFOrigenDividir As PdfDocument =
                   PdfReader.Open(rutaFicheroPDFOrigenDividir, PdfDocumentOpenMode.InformationOnly)

                txtnombreficheros.Text =
                        Path.GetFileNameWithoutExtension(rutaFicheroPDFOrigenDividir)
                txttitulo.Text = ficheroPDFOrigenDividir.Info.Title
                txtautor.Text = ficheroPDFOrigenDividir.Info.Author
                txtasunto.Text = ficheroPDFOrigenDividir.Info.Subject
                txtpalabra.Text = ficheroPDFOrigenDividir.Info.Keywords
                LinfoPDF.Text = "Nº de páginas: " + ficheroPDFOrigenDividir.PageCount +
                       ", se generarán " + ficheroPDFOrigenDividir.PageCount +
                       " ficheros PDF, uno por cada página del fichero PDF origen"

            Catch ex As Exception

                MessageBox.Show("Error al leer fichero PDF." +
                        System.Environment.NewLine + System.Environment.NewLine +
                        ex.Message, "Error al abrir PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Btncarpetadestino_Click(sender As Object, e As EventArgs) Handles btncarpetadestino.Click
        Dim dlcarpeta As New FolderBrowserDialog
        dlcarpeta.RootFolder = System.Environment.SpecialFolder.Desktop
        dlcarpeta.ShowNewFolderButton = True
        dlcarpeta.Description = "Selecciona la carpeta de destino de los ficheros " +
                    "PDF resultantes de extraer cada página del PDF " +
                    "origen en un fichero PDF destino"
        If dlCarpeta.ShowDialog() = DialogResult.OK Then

            txtdestino.Text = dlcarpeta.SelectedPath
        End If
    End Sub

    Private Sub Btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        Dim paginaPDFActual As New Integer
        Try

            Dim rutaFicheroPDFOrigenDividir As String = txtpdforigen.Text

            If Not File.Exists(rutaFicheroPDFOrigenDividir) Then

                MessageBox.Show("El fichero origen del que se extraerán las páginas " +
                        "en ficheros PDF divididos no existe.", "Fichero origen PDF no existe",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpdforigen.Focus()

            Else

                If Not Directory.Exists(txtdestino.Text) Then

                    MessageBox.Show("La carpeta de destino donde se crearán los " +
                            "ficheros PDF de las páginas extraídas no existe.",
                            "Carpeta destino para PDF no existe",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtdestino.Focus()

                Else

                    Dim ficheroPDFOrigenDividir As PdfDocument =
                            PdfReader.Open(rutaFicheroPDFOrigenDividir, PdfDocumentOpenMode.Import)

                    Dim nombreFicheroDestinoPaginasPDF As String =
                            Path.GetFileNameWithoutExtension(txtnombreficheros.Text)
                    Linfoprogreso.Text = "Extrayendo páginas de fichero PDF"
                    Linfoprogreso.Refresh()
                    bp.Minimum = 0
                    bp.Maximum = ficheroPDFOrigenDividir.PageCount
                    bp.Value = 0

                    For paginaPDFActual = 0 To 0
                        paginaPDFActual = ficheroPDFOrigenDividir.PageCount

                        paginaPDFActual += paginaPDFActual
                        Continue For
                        Linfoprogreso.Text = "Dividiendo página " +
                                Convert.ToString(paginaPDFActual + 1)
                        Linfoprogreso.Refresh()


                        Dim ficheroPDFPaginaDestino As New PdfDocument(txtdestino.Text)
                        ficheroPDFPaginaDestino.Info.Subject = txtasunto.Text
                        ficheroPDFPaginaDestino.Info.Title = txttitulo.Text
                        ficheroPDFPaginaDestino.Info.Author = txtautor.Text
                        ficheroPDFPaginaDestino.Info.Keywords = txtpalabra.Text
                        ficheroPDFPaginaDestino.Info.Creator = Application.ProductName
                        ficheroPDFPaginaDestino.Info.ModificationDate = DateTime.Now


                        ficheroPDFPaginaDestino.Info.Title =
                                String.Format("Página {0} de {1}", paginaPDFActual + 1,
                                ficheroPDFOrigenDividir.PageCount)

                        ficheroPDFPaginaDestino.AddPage(ficheroPDFOrigenDividir.Pages(paginaPDFActual))
                        Dim nombreFicheroPDFDestino As String = Path.Combine(txtdestino.Text,
                                nombreFicheroDestinoPaginasPDF + " - Página " +
                                Convert.ToString(paginaPDFActual + 1)) + ".pdf"
                        ficheroPDFPaginaDestino.Save(nombreFicheroPDFDestino)
                        lsFicherosPDFDivididos.Items.Add(nombreFicheroPDFDestino)
                        bp.Value = paginaPDFActual + 1

                    Next
                    Linfoprogreso.Text = "Fichero dividido en páginas correctamente: se han generado " +
                           Convert.ToString(ficheroPDFOrigenDividir.PageCount) + " ficheros PDF"
                    Linfoprogreso.Refresh()
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al extraer páginas de fichero PDF." +
                  System.Environment.NewLine + System.Environment.NewLine +
                  ex.Message, "Error al crear PDF",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Me.Close()
        MenuPrincipal.Visible = True
    End Sub

    Private Sub LsFicherosPDFDivididos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsFicherosPDFDivididos.SelectedIndexChanged
        If lsFicherosPDFDivididos.SelectedIndex >= 0 Then

            Dim ficheroPDF As String = lsFicherosPDFDivididos.SelectedItem.ToString()
            If (File.Exists(ficheroPDF)) Then

                System.Diagnostics.Process.Start(ficheroPDF)

            Else

                MessageBox.Show("El fichero PDF seleccionado no existe " +
                        "o se ha cambiado de ubicación.",
                        "Fichero PDF no existe",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub


End Class