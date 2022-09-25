<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox5 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Pan"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.Honeydew
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Blanco ", "Integral", "Integral y Avena Dulce", "Oregano"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(64, 208)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(249, 125)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 3
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.Honeydew
        Me.CheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Queso Amarillo", "Queso Blanco"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(372, 208)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(220, 125)
        Me.CheckedListBox2.Sorted = True
        Me.CheckedListBox2.TabIndex = 5
        Me.CheckedListBox2.UseWaitCursor = True
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.BackColor = System.Drawing.Color.Honeydew
        Me.CheckedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox3.CheckOnClick = True
        Me.CheckedListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"Aceitunas", "Cebolla Morada", "Lechuga", "Pepinillo", "Pepino", "Pimenton Verde", "Tomate"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(372, 407)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(220, 250)
        Me.CheckedListBox3.Sorted = True
        Me.CheckedListBox3.TabIndex = 7
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.BackColor = System.Drawing.Color.Honeydew
        Me.CheckedListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox4.CheckOnClick = True
        Me.CheckedListBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Items.AddRange(New Object() {"Aceite de Oliva", "BBQ", "Cebolla Dulce", "Chipotle", "Mayones", "Mostaza Dulce", "Sal y Pimienta", "Salsa de Tomate", "Vinagre"})
        Me.CheckedListBox4.Location = New System.Drawing.Point(64, 407)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(249, 250)
        Me.CheckedListBox4.Sorted = True
        Me.CheckedListBox4.TabIndex = 9
        '
        'CheckedListBox5
        '
        Me.CheckedListBox5.BackColor = System.Drawing.Color.Honeydew
        Me.CheckedListBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox5.CheckOnClick = True
        Me.CheckedListBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox5.FormattingEnabled = True
        Me.CheckedListBox5.Items.AddRange(New Object() {"Atún", "Bacon", "BBQ Ribs", "Carne", "Jamon", "Pavo", "Pechuga de pollo", "Peperoni", "Pollo BBQ", "Pollo Teriyaki", "Salami"})
        Me.CheckedListBox5.Location = New System.Drawing.Point(633, 208)
        Me.CheckedListBox5.Name = "CheckedListBox5"
        Me.CheckedListBox5.Size = New System.Drawing.Size(278, 450)
        Me.CheckedListBox5.Sorted = True
        Me.CheckedListBox5.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(967, 610)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 61)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(933, 208)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 286)
        Me.TextBox1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Salsas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Queso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Vegetales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(715, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Proteina"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1028, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Orden"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1280, 710)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox5)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox4 As CheckedListBox
    Friend WithEvents CheckedListBox5 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
