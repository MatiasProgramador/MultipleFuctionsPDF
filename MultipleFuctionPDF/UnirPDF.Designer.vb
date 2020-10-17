<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnirPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnirPDF))
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.btnabrir1 = New System.Windows.Forms.Button()
        Me.AxAcroPDF2 = New AxAcroPDFLib.AxAcroPDF()
        Me.btnabrir2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnunir = New System.Windows.Forms.Button()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(32, 43)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(160, 176)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'btnabrir1
        '
        Me.btnabrir1.Location = New System.Drawing.Point(220, 176)
        Me.btnabrir1.Name = "btnabrir1"
        Me.btnabrir1.Size = New System.Drawing.Size(108, 43)
        Me.btnabrir1.TabIndex = 1
        Me.btnabrir1.Text = "Abrir archivo 1"
        Me.btnabrir1.UseVisualStyleBackColor = True
        '
        'AxAcroPDF2
        '
        Me.AxAcroPDF2.Enabled = True
        Me.AxAcroPDF2.Location = New System.Drawing.Point(389, 43)
        Me.AxAcroPDF2.Name = "AxAcroPDF2"
        Me.AxAcroPDF2.OcxState = CType(resources.GetObject("AxAcroPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF2.Size = New System.Drawing.Size(160, 176)
        Me.AxAcroPDF2.TabIndex = 2
        '
        'btnabrir2
        '
        Me.btnabrir2.Location = New System.Drawing.Point(603, 176)
        Me.btnabrir2.Name = "btnabrir2"
        Me.btnabrir2.Size = New System.Drawing.Size(108, 43)
        Me.btnabrir2.TabIndex = 3
        Me.btnabrir2.Text = "Abrir archivo 2"
        Me.btnabrir2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnunir
        '
        Me.btnunir.Location = New System.Drawing.Point(559, 303)
        Me.btnunir.Name = "btnunir"
        Me.btnunir.Size = New System.Drawing.Size(152, 48)
        Me.btnunir.TabIndex = 4
        Me.btnunir.Text = "Unir archivos PDF"
        Me.btnunir.UseVisualStyleBackColor = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.White
        Me.btnseleccionar.Location = New System.Drawing.Point(512, 331)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(37, 23)
        Me.btnseleccionar.TabIndex = 6
        Me.btnseleccionar.Text = "..."
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(32, 331)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(463, 20)
        Me.txtdestino.TabIndex = 5
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(688, 409)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(100, 29)
        Me.btnvolver.TabIndex = 14
        Me.btnvolver.Text = "Volver al Menu"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ruta de Destino"
        '
        'UnirPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.txtdestino)
        Me.Controls.Add(Me.btnunir)
        Me.Controls.Add(Me.btnabrir2)
        Me.Controls.Add(Me.AxAcroPDF2)
        Me.Controls.Add(Me.btnabrir1)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Name = "UnirPDF"
        Me.Text = "UnirPDF"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnabrir1 As Button
    Friend WithEvents AxAcroPDF2 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnabrir2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnunir As Button
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents btnvolver As Button
    Friend WithEvents Label1 As Label
End Class
