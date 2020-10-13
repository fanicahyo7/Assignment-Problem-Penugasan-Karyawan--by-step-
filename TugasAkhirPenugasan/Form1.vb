Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call segarkan()
    End Sub
    Sub segarkan()
        Call Koneksi()
        Call TampilGrid()
        Call bersih()
        Call tombolhidup()
        Call isimati()
    End Sub
    Sub TampilGrid()
        DA = New OdbcDataAdapter("select * From karyawan", CONN)
        DS = New DataSet
        DA.Fill(DS, "karyawan")
        DataGridView1.DataSource = DS.Tables("karyawan")
        DataGridView1.ReadOnly = True
    End Sub
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Value = Now
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Sub tombolhidup()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Button1.Text = "Tambah"
        Button2.Text = "Ubah"
        Button3.Text = "Hapus"
    End Sub
    Sub isimati()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub
    Sub isihidup()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call bersih()
            Call isihidup()
        ElseIf Button1.Text = "Simpan" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Data Yang Anda Masukkan Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
            Else
                Dim jk As String = ""
                If RadioButton1.Checked = True Then
                    jk = "Laki-Laki"
                ElseIf RadioButton2.Checked = True Then
                    jk = "Perempuan"
                End If
                Dim simpan As String = "insert into karyawan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & jk & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & TextBox3.Text & "')"
                CMD = New OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!", vbInformation + vbOKOnly, "Informasi")
                Call segarkan()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Call segarkan()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Pilih Data Yang Akan Diubah!", vbCritical + vbOKOnly, "Peringatan")
        ElseIf Button2.Text = "Ubah" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call isihidup()
            TextBox1.Enabled = False
        ElseIf Button2.Text = "Simpan" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Data Yang Anda Masukkan Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
            Else
                Dim jk As String = ""
                If RadioButton1.Checked = True Then
                    jk = "Laki-Laki"
                ElseIf RadioButton2.Checked = True Then
                    jk = "Perempuan"
                End If
                Dim edit As String = "update karyawan set nama='" & TextBox2.Text & "',jenis_kelamin='" & jk & "',tanggal_lahir='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "',alamat='" & TextBox3.Text & "' where kd_karyawan='" & TextBox1.Text & "'"
                CMD = New OdbcCommand(edit, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah", vbInformation + vbOKOnly, "Informasi")
                Call segarkan()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        DateTimePicker1.Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        TextBox3.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        If DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value = "Laki-Laki" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value = "Perempuan" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Pilih Data Yang Akan Dihapus!", vbCritical + vbOKOnly, "Peringatan")
        Else
            If MsgBox("Anda Yakin Ingin Menghapus?", vbQuestion + vbYesNo) = vbYes Then
                Dim hapus As String = "delete From karyawan where kd_karyawan='" & TextBox1.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", vbInformation + vbOKOnly, "Informasi")
                Call segarkan()
            End If
        End If
    End Sub
End Class