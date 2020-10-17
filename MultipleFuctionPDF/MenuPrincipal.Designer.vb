<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnformtexto = New System.Windows.Forms.Button()
        Me.btnformimagen = New System.Windows.Forms.Button()
        Me.btnformunir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnrotar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MULTIPLE FUCTIONS PDF ""MENU"""
        '
        'btnformtexto
        '
        Me.btnformtexto.Location = New System.Drawing.Point(97, 58)
        Me.btnformtexto.Name = "btnformtexto"
        Me.btnformtexto.Size = New System.Drawing.Size(154, 43)
        Me.btnformtexto.TabIndex = 1
        Me.btnformtexto.Text = "Convertir Texto a PDF"
        Me.btnformtexto.UseVisualStyleBackColor = True
        '
        'btnformimagen
        '
        Me.btnformimagen.Location = New System.Drawing.Point(97, 116)
        Me.btnformimagen.Name = "btnformimagen"
        Me.btnformimagen.Size = New System.Drawing.Size(154, 43)
        Me.btnformimagen.TabIndex = 2
        Me.btnformimagen.Text = "Convertir Imagen a PDF"
        Me.btnformimagen.UseVisualStyleBackColor = True
        '
        'btnformunir
        '
        Me.btnformunir.Location = New System.Drawing.Point(97, 178)
        Me.btnformunir.Name = "btnformunir"
        Me.btnformunir.Size = New System.Drawing.Size(154, 43)
        Me.btnformunir.TabIndex = 3
        Me.btnformunir.Text = "Unir Archivos PDF"
        Me.btnformunir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Dividir Archivos PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnrotar
        '
        Me.btnrotar.Location = New System.Drawing.Point(97, 238)
        Me.btnrotar.Name = "btnrotar"
        Me.btnrotar.Size = New System.Drawing.Size(154, 38)
        Me.btnrotar.TabIndex = 5
        Me.btnrotar.Text = "Rotar PDF"
        Me.btnrotar.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(349, 375)
        Me.Controls.Add(Me.btnrotar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnformunir)
        Me.Controls.Add(Me.btnformimagen)
        Me.Controls.Add(Me.btnformtexto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnformtexto As Button
    Friend WithEvents btnformimagen As Button
    Friend WithEvents btnformunir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnrotar As Button
End Class
