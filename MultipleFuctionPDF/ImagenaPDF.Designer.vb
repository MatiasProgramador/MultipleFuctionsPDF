<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImagenaPDF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.txtpalabra = New System.Windows.Forms.TextBox()
        Me.txtasunto = New System.Windows.Forms.TextBox()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 195)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(297, 21)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(206, 55)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "Buscar una Imagen"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnconvertir
        '
        Me.btnconvertir.Location = New System.Drawing.Point(559, 447)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(116, 48)
        Me.btnconvertir.TabIndex = 8
        Me.btnconvertir.Text = "Convertir a PDF"
        Me.btnconvertir.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 181)
        Me.GroupBox2.TabIndex = 9
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.White
        Me.btnseleccionar.Location = New System.Drawing.Point(504, 472)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(37, 23)
        Me.btnseleccionar.TabIndex = 11
        Me.btnseleccionar.Text = "..."
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(24, 472)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(463, 20)
        Me.txtdestino.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ruta de Destino"
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(725, 466)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(100, 29)
        Me.btnvolver.TabIndex = 13
        Me.btnvolver.Text = "Volver al Menu"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'ImagenaPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(837, 504)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.txtdestino)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnconvertir)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ImagenaPDF"
        Me.Text = "ImagenaPDF"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnconvertir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtautor As TextBox
    Friend WithEvents txtpalabra As TextBox
    Friend WithEvents txtasunto As TextBox
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnvolver As Button
End Class
