Module tablas_hash

    Public hash_panes As Hashtable = New Hashtable()
    Public hash_quesos As Hashtable = New Hashtable()
    Public hash_salsas As Hashtable = New Hashtable()
    Public hash_proteinas As Hashtable = New Hashtable()
    Public hash_vegetales As Hashtable = New Hashtable()

    Public Function iniciaizar_tablas()
        Dim panes(4) As String
        Dim quesos(2) As String
        Dim salsas(9) As String
        Dim proteinas(11) As String
        Dim vegetales(7) As String

        Dim index As Integer

        ''tabla_hash panes
        For Each item As String In Form1.CheckedListBox1.Items()
            index = item.GetHashCode() Mod 4

            While hash_panes.ContainsKey(index)
                index += 1

            End While
            hash_panes.Add(index, item)
        Next

        ''tabla_hash quesos
        For Each item As String In Form1.CheckedListBox2.Items()
            index = item.GetHashCode() Mod 2

            While hash_quesos.ContainsKey(index)
                index += 1

            End While
            hash_quesos.Add(index, item)
        Next

        ''tabla_hash salsas
        For Each item As String In Form1.CheckedListBox4.Items()
            index = item.GetHashCode() Mod 9

            While hash_salsas.ContainsKey(index)
                index += 1

            End While
            hash_salsas.Add(index, item)
        Next

        ''tabla_hash proteinas
        For Each item As String In Form1.CheckedListBox5.Items()
            index = item.GetHashCode() Mod 11

            While hash_proteinas.ContainsKey(index)
                index += 1

            End While
            hash_proteinas.Add(index, item)
        Next

        ''tabla_hash vegetales
        For Each item As String In Form1.CheckedListBox3.Items()
            index = item.GetHashCode() Mod 7

            While hash_vegetales.ContainsKey(index)
                index += 1

            End While
            Console.WriteLine(index)
            hash_vegetales.Add(index, item)
        Next
    End Function


End Module
