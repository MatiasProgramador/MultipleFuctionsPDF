<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DividirPDF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpdforigen = New System.Windows.Forms.TextBox()
        Me.btnpdforigen = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.txtpalabra = New System.Windows.Forms.TextBox()
        Me.txtasunto = New System.Windows.Forms.TextBox()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.btncarpetadestino = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombreficheros = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.bp = New System.Windows.Forms.ProgressBar()
        Me.lsFicherosPDFDivididos = New System.Windows.Forms.ListBox()
        Me.Linfoprogreso = New System.Windows.Forms.Label()
        Me.LinfoPDF = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fichero PDF a dividir"
        '
        'txtpdforigen
        '
        Me.txtpdforigen.Location = New System.Drawing.Point(37, 46)
        Me.txtpdforigen.Name = "txtpdforigen"
        Me.txtpdforigen.Size = New System.Drawing.Size(635, 20)
        Me.txtpdforigen.TabIndex = 1
        '
        'btnpdforigen
        '
        Me.btnpdforigen.Location = New System.Drawing.Point(678, 30)
        Me.btnpdforigen.Name = "btnpdforigen"
        Me.btnpdforigen.Size = New System.Drawing.Size(42, 36)
        Me.btnpdforigen.TabIndex = 2
        Me.btnpdforigen.Text = "..."
        Me.btnpdforigen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtautor)
        Me.GroupBox2.Controls.Add(Me.txtpalabra)
        Me.GroupBox2.Controls.Add(Me.txtasunto)
        Me.GroupBox2.Controls.Add(Me.txttitulo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 181)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(395, 119)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(203, 20)
        Me.txtautor.TabIndex = 7
        '
        'txtpalabra
        '
        Me.txtpalabra.Location = New System.Drawing.Point(88, 120)
        Me.txtpalabra.Name = "txtpalabra"
        Me.txtpalabra.Size = New System.Drawing.Size(255, 20)
        Me.txtpalabra.TabIndex = 6
        '
        'txtasunto
        '
        Me.txtasunto.Location = New System.Drawing.Point(88, 79)
        Me.txtasunto.Name = "txtasunto"
        Me.txtasunto.Size = New System.Drawing.Size(510, 20)
        Me.txtasunto.TabIndex = 5
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(88, 28)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(510, 20)
        Me.txttitulo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Autor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Palabra Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Asunto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Titulo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(37, 280)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(635, 20)
        Me.txtdestino.TabIndex = 11
        '
        'btncarpetadestino
        '
        Me.btncarpetadestino.Location = New System.Drawing.Point(678, 264)
        Me.btncarpetadestino.Name = "btncarpetadestino"
        Me.btncarpetadestino.Size = New System.Drawing.Size(42, 36)
        Me.btncarpetadestino.TabIndex = 12
        Me.btncarpetadestino.Text = "..."
        Me.btncarpetadestino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ruta de destino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Separar paginas"
        '
        'txtnombreficheros
        '
        Me.txtnombreficheros.Location = New System.Drawing.Point(125, 335)
        Me.txtnombreficheros.Name = "txtnombreficheros"
        Me.txtnombreficheros.Size = New System.Drawing.Size(510, 20)
        Me.txtnombreficheros.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nombre Ficheros"
        '
        'btndividir
        '
        Me.btndividir.Location = New System.Drawing.Point(645, 318)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(116, 37)
        Me.btndividir.TabIndex = 17
        Me.btndividir.Text = "Dividir PDF"
        Me.btndividir.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(653, 539)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(108, 42)
        Me.btnmenu.TabIndex = 18
        Me.btnmenu.Text = "Volver al Menu"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'bp
        '
        Me.bp.Location = New System.Drawing.Point(40, 407)
        Me.bp.Name = "bp"
        Me.bp.Size = New System.Drawing.Size(595, 20)
        Me.bp.TabIndex = 19
        '
        'lsFicherosPDFDivididos
        '
        Me.lsFicherosPDFDivididos.FormattingEnabled = True
        Me.lsFicherosPDFDivididos.Location = New System.Drawing.Point(40, 434)
        Me.lsFicherosPDFDivididos.Name = "lsFicherosPDFDivididos"
        Me.lsFicherosPDFDivididos.Size = New System.Drawing.Size(595, 147)
        Me.lsFicherosPDFDivididos.TabIndex = 20
        '
        'Linfoprogreso
        '
        Me.Linfoprogreso.AutoSize = True
        Me.Linfoprogreso.Location = New System.Drawing.Point(40, 388)
        Me.Linfoprogreso.Name = "Linfoprogreso"
        Me.Linfoprogreso.Size = New System.Drawing.Size(0, 13)
        Me.Linfoprogreso.TabIndex = 21
        '
        'LinfoPDF
        '
        Me.LinfoPDF.AutoSize = True
        Me.LinfoPDF.Location = New System.Drawing.Point(40, 388)
        Me.LinfoPDF.Name = "LinfoPDF"
        Me.LinfoPDF.Size = New System.Drawing.Size(0, 13)
        Me.LinfoPDF.TabIndex = 22
        '
        'DividirPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 603)
        Me.Controls.Add(Me.LinfoPDF)
        Me.Controls.Add(Me.Linfoprogreso)
        Me.Controls.Add(Me.lsFicherosPDFDivididos)
        Me.Controls.Add(Me.bp)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btndividir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnombreficheros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btncarpetadestino)
        Me.Controls.Add(Me.txtdestino)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnpdforigen)
        Me.Controls.Add(Me.txtpdforigen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DividirPDF"
        Me.Text = "DividirPDF"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtpdforigen As TextBox
    Friend WithEvents btnpdforigen As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtautor As TextBox
    Friend WithEvents txtpalabra As TextBox
    Friend WithEvents txtasunto As TextBox
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents btncarpetadestino As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnombreficheros As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btndividir As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents bp As ProgressBar
    Friend WithEvents lsFicherosPDFDivididos As ListBox
    Friend WithEvents Linfoprogreso As Label
    Friend WithEvents LinfoPDF As Label
End Class
