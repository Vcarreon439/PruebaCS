<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSaludo = New System.Windows.Forms.Button()
        Me.btnSaludoNom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSaludo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaludo
        '
        Me.btnSaludo.Location = New System.Drawing.Point(15, 32)
        Me.btnSaludo.Name = "btnSaludo"
        Me.btnSaludo.Size = New System.Drawing.Size(94, 23)
        Me.btnSaludo.TabIndex = 0
        Me.btnSaludo.Text = "Saludo"
        Me.btnSaludo.UseVisualStyleBackColor = True
        '
        'btnSaludoNom
        '
        Me.btnSaludoNom.Location = New System.Drawing.Point(115, 32)
        Me.btnSaludoNom.Name = "btnSaludoNom"
        Me.btnSaludoNom.Size = New System.Drawing.Size(162, 23)
        Me.btnSaludoNom.TabIndex = 1
        Me.btnSaludoNom.Text = "Saludo con Nombre"
        Me.btnSaludoNom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'LabelSaludo
        '
        Me.LabelSaludo.Location = New System.Drawing.Point(12, 67)
        Me.LabelSaludo.Name = "LabelSaludo"
        Me.LabelSaludo.Size = New System.Drawing.Size(265, 139)
        Me.LabelSaludo.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(62, 6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 20)
        Me.txtNombre.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 299)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Consola"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Prueba desde Consola"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Prueba"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 375)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelSaludo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaludoNom)
        Me.Controls.Add(Me.btnSaludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaludo As Button
    Friend WithEvents btnSaludoNom As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSaludo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
