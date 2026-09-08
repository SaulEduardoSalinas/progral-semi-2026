Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String
        Dim apellido As String
        Dim edad As String
        Dim transporte As String = ""
        Dim sexo As String = ""

        nombre = TextBox1.Text
        apellido = TextBox2.Text
        edad = TextBox3.Text

        If CheckBox1.Checked Then
            transporte = transporte & "Carro "
        End If

        If CheckBox2.Checked Then
            transporte = transporte & "Moto "
        End If

        If CheckBox3.Checked Then
            transporte = transporte & TextBox4.Text
        End If

        If RadioButton1.Checked Then
            sexo = "Masculino"
        End If

        If RadioButton2.Checked Then
            sexo = "Femenino"
        End If

        MessageBox.Show("Nombre: " & nombre &
                        vbCrLf & "Apellido: " & apellido &
                        vbCrLf & "Edad: " & edad &
                        vbCrLf & "Transporte: " & transporte &
                        vbCrLf & "Sexo: " & sexo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged


        If CheckBox3.Checked Then
            Label5.Visible = True
            TextBox4.Visible = True
        Else
            Label11.Visible = False
            TextBox4.Visible = False
        End If

    End Sub
