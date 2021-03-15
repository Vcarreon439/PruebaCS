Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        LabelSaludo.Text = PruebaLibreria.PruebaCS.Saludo()
    End Sub

    Private Sub btnSaludoNom_Click(sender As Object, e As EventArgs) Handles btnSaludoNom.Click
        LabelSaludo.Text = PruebaLibreria.PruebaCS.Saludo(txtNombre.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked Then
            LabelSaludo.Text = "Varsion del ensamblado de C#:" & ConsolaC_Sharp.Program.FileVersion
        Else
            LabelSaludo.Text = "Varsion del ensamblado de C#:" & PruebaLibreria.PruebaCS.FileVersion
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If CheckBox1.Checked Then
            LabelSaludo.Text = ConsolaC_Sharp.Program.Saludo()
        Else
            LabelSaludo.Text = PruebaLibreria.PruebaCS.Saludo()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            LabelSaludo.Text = ConsolaC_Sharp.Program.Saludo(Me.txtNombre.Text)
        Else
            LabelSaludo.Text = PruebaLibreria.PruebaCS.Saludo(Me.txtNombre.Text)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            LabelSaludo.Text = "Versión del ensamblado de C#: " &
            ConsolaC_Sharp.Program.FileVersion
        Else
            LabelSaludo.Text = "Versión del ensamblado de C#: " &
            PruebaLibreria.PruebaCS.FileVersion
        End If
    End Sub
End Class
