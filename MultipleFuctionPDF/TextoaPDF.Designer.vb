<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextoaPDF
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
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.txtpalabra = New System.Windows.Forms.TextBox()
        Me.txtasunto = New System.Windows.Forms.TextBox()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(612, 19)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(87, 39)
        Me.btnlimpiar.TabIndex = 2
        Me.btnlimpiar.Text = "Limpiar Texto"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttexto)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Introducir Texto para convertir a PDF"
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(17, 20)
        Me.txttexto.Name = "txttexto"
        Me.txttexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txttexto.Size = New System.Drawing.Size(581, 20)
        Me.txttexto.TabIndex = 3
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
        Me.GroupBox2.Location = New System.Drawing.Point(26, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 181)
        Me.GroupBox2.TabIndex = 5
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btngenerar)
        Me.GroupBox3.Controls.Add(Me.btnseleccionar)
        Me.GroupBox3.Controls.Add(Me.txtdestino)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 93)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ruta de destino"
        '
        'btngenerar
        '
        Me.btngenerar.BackColor = System.Drawing.Color.White
        Me.btngenerar.Location = New System.Drawing.Point(560, 34)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(88, 33)
        Me.btngenerar.TabIndex = 2
        Me.btngenerar.Text = "Generar PDF"
        Me.btngenerar.UseVisualStyleBackColor = False
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.White
        Me.btnseleccionar.Location = New System.Drawing.Point(497, 34)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(37, 23)
        Me.btnseleccionar.TabIndex = 1
        Me.btnseleccionar.Text = "..."
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(17, 34)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(463, 20)
        Me.txtdestino.TabIndex = 0
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(688, 417)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(100, 29)
        Me.btnvolver.TabIndex = 14
        Me.btnvolver.Text = "Volver al Menu"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'TextoaPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "TextoaPDF"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtautor As TextBox
    Friend WithEvents txtpalabra As TextBox
    Friend WithEvents txtasunto As TextBox
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btngenerar As Button
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents txttexto As TextBox
    Friend WithEvents btnvolver As Button
End Class
