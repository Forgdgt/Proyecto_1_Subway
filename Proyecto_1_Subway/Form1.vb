Public Class Form1
    Dim arrlist As ArrayList = New ArrayList()

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Solo_un_valor(CheckedListBox1)

        Cadena_de_comados(CheckedListBox1, 1)

        text_comandos()

    End Sub


    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        Solo_un_valor(CheckedListBox2)

        Cadena_de_comados(CheckedListBox2, 2)

        text_comandos()
    End Sub
    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged
        Cadena_de_comados(CheckedListBox3, 3)

        text_comandos()
    End Sub
    Private Sub CheckedListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox4.SelectedIndexChanged

        Cadena_de_comados(CheckedListBox4, 3)

        text_comandos()

    End Sub

    Private Sub CheckedListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox5.SelectedIndexChanged
        Cadena_de_comados(CheckedListBox5, 3)

        text_comandos()
    End Sub

    Function Solo_un_valor(CheckedListBox As CheckedListBox)
        Dim seleccionado As Integer

        For Indice As Integer = 0 To CheckedListBox.Items.Count - 1
            CheckedListBox.SetItemChecked(Indice, False)

            If (CheckedListBox.GetSelected(Indice)) Then
                seleccionado = Indice
            End If

        Next Indice


        If (CheckedListBox.GetItemChecked(seleccionado)) Then

        Else
            CheckedListBox.SetItemChecked(seleccionado, True)
        End If


    End Function

    Function Cadena_de_comados(CheckedListBox As CheckedListBox, opcion As Integer)
        Dim seleccionado As Integer


        Select Case opcion
            Case 1
                Dim panes(4) As String
                CheckedListBox1.Items.CopyTo(panes, 0)
                For Indice As Integer = 0 To CheckedListBox.Items.Count - 1
                    If (arrlist.Contains(panes(Indice))) Then
                        arrlist.RemoveAt(arrlist.IndexOf(panes(Indice)))
                    End If
                    If (CheckedListBox.GetItemChecked(Indice)) Then
                        seleccionado = Indice
                    End If
                Next Indice
                arrlist.Add(panes(seleccionado))
            Case 2
                Dim quesos(2) As String
                CheckedListBox2.Items.CopyTo(quesos, 0)
                For Indice As Integer = 0 To CheckedListBox.Items.Count - 1
                    If (arrlist.Contains(quesos(Indice))) Then
                        arrlist.RemoveAt(arrlist.IndexOf(quesos(Indice)))
                    End If
                    If (CheckedListBox.GetItemChecked(Indice)) Then
                        seleccionado = Indice
                    End If
                Next Indice
                arrlist.Add(quesos(seleccionado))
            Case 3

                Dim arreglo(CheckedListBox.Items.Count) As String
                CheckedListBox.Items.CopyTo(arreglo, 0)

                If (arrlist.Contains(arreglo(CheckedListBox.SelectedIndex))) Then
                    arrlist.RemoveAt(arrlist.IndexOf(arreglo(CheckedListBox.SelectedIndex)))
                Else
                    arrlist.Add(arreglo(CheckedListBox.SelectedIndex))
                End If






        End Select

    End Function

    Function text_comandos()
        Dim strings As String
        strings = ""
        TextBox1.Text = arrlist.Item(0) & vbCrLf
        For Indice As Integer = 1 To arrlist.Count - 1

            TextBox1.Text += arrlist.Item(Indice) & vbCrLf

        Next Indice
    End Function


End Class
