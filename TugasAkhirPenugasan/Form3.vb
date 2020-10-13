Imports System.Data.Odbc
Public Class Form3
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid() 'menmapilkan data produksi ke datagrid
        Call tampilsalin() 'menyalin data dari datagrid1 ke datagrid2
        Call baristerkecil() 'mencari nilai terkecil pada baris dan mengurangi baris dengan nilai terkecil pada baris
        Call tampilsalin2() 'menyalin data dari datagrid2 ke datagrid3
        Call kolomterkecil() 'mencari nilai terkecil pada kolom dan mengurangi kolom dengan nilai terkecil pada kolom
    End Sub
    Sub tampilsalin()
        For a = 0 To 6
            DataGridView2.Rows.Add(DataGridView1.Item(0, a).Value)
            For b = 0 To 7
                DataGridView2.Item(b, a).Value = DataGridView1.Item(b, a).Value
            Next
        Next
    End Sub
    Sub tampilsalin2()
        For a = 0 To 6
            DataGridView3.Rows.Add(DataGridView2.Item(0, a).Value)
            For b = 0 To 7
                DataGridView3.Item(b, a).Value = DataGridView2.Item(b, a).Value
            Next
        Next
    End Sub
    Sub baristerkecil()
        For a = 0 To 6
            'mencari nilai terkecil pada baris
            Dim nilai As Integer = CInt(DataGridView2.Item(1, a).Value)
            For b = 1 To 7
                If CInt(DataGridView2.Item(b, a).Value) < nilai Then
                    nilai = DataGridView2.Item(b, a).Value
                End If
            Next
            'mengurangi nilai pada baris dengan nilai terkecil pada baris
            For b = 1 To 7
                DataGridView2.Item(b, a).Value = DataGridView2.Item(b, a).Value - nilai
            Next
        Next
    End Sub
    Sub kolomterkecil()
        For a = 1 To 7
            Dim deteksinol As String = ""
            Dim kolom As Integer
            Dim nilai As Integer
            'mendeteksi kolom sudah terdapat nilai 0 atau tidak
            For b = 0 To 6
                If CInt(DataGridView3.Item(a, b).Value) = 0 Then
                    deteksinol = "Ada"
                    b = 7
                Else
                    deteksinol = "Tidak Ada"
                    kolom = a
                End If
            Next

            If deteksinol = "Tidak Ada" Then
                'mencari nilai terkecil pada kolom
                nilai = CInt(DataGridView3.Item(kolom, 0).Value)
                For c = 0 To kolom
                    If CInt(DataGridView3.Item(kolom, c).Value) < nilai Then
                        nilai = DataGridView3.Item(kolom, c).Value
                    End If
                Next
                'mengurangi nilai kolom dengan nilai terkecil pada kolom
                For c = 0 To 6
                    DataGridView3.Item(kolom, c).Value = DataGridView3.Item(kolom, c).Value - nilai
                Next
            End If
        Next
    End Sub
    Sub TampilGrid()
        DA = New OdbcDataAdapter("select * From tb_produksi", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_produksi")
        DataGridView1.DataSource = DS.Tables("tb_produksi")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub
End Class