Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.WindowState = FormWindowState.Minimized
        ''panes
        For Each element As DictionaryEntry In hash_panes

            DataGridView1.Rows.Add(element.Key, element.Value)
        Next

        ''Quesos
        For Each element As DictionaryEntry In hash_quesos

            DataGridView2.Rows.Add(element.Key, element.Value)
        Next

        ''Salsas
        For Each element As DictionaryEntry In hash_salsas

            DataGridView3.Rows.Add(element.Key, element.Value)
        Next

        ''Proteinas
        For Each element As DictionaryEntry In hash_proteinas

            DataGridView4.Rows.Add(element.Key, element.Value)
        Next

        ''Vegetales
        For Each element As DictionaryEntry In hash_vegetales

            DataGridView5.Rows.Add(element.Key, element.Value)
        Next
    End Sub


End Class