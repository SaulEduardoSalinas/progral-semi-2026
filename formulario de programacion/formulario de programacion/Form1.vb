Public Class Form1
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Label6.Visible = True
            TextBox4.Visible = True

        Else CheckBox3.Checked = False
            Label6.Visible = False
            TextBox4.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre As String = TextBox1.Text
        Dim Apellido As String = TextBox2.Text
        Dim Edad As String = TextBox3.Text
        Dim Vehiculo As String
        Dim Genero As String
        Dim Moto As String
        Dim Otro As String

        If CheckBox1.Checked Then Vehiculo = "Carro"
        If CheckBox2.Checked Then Moto = "Moto"
        If CheckBox3.Checked Then Otro = TextBox4.Text

        If RadioButton1.Checked Then Genero = "Masculino"
        If RadioButton2.Checked Then Genero = "Femenino"

        MessageBox.Show("Su nombre es: " & Nombre & vbCrLf &
                        "Su Apellido es: " & Apellido & vbCrLf &
                        "Su edad es: " & Edad & vbCrLf &
                        "Su transporte es. " & Vehiculo & ", " & Moto & ", " & Otro & vbCrLf &
                        "Su Genero es: " & Genero)
    End Sub
End Class