Public Class Form4
    Sub tampilsalin()
        For a = 0 To 6
            DataGridView1.Rows.Add(Form3.DataGridView3.Item(0, a).Value)
            For b = 0 To 7
                DataGridView1.Item(b, a).Value = Form3.DataGridView3.Item(b, a).Value
            Next
        Next
    End Sub
    Sub tampilsalin2()
        For a = 0 To 6
            DataGridView2.Rows.Add(DataGridView1.Item(0, a).Value)
            For b = 0 To 7
                DataGridView2.Item(b, a).Value = DataGridView1.Item(b, a).Value
            Next
        Next
    End Sub
    Sub tampilsalin3()
        For a = 0 To 6
            DataGridView3.Rows.Add(DataGridView2.Item(0, a).Value)
            For b = 0 To 7
                DataGridView3.Item(b, a).Value = DataGridView2.Item(b, a).Value
            Next
        Next
    End Sub
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call tampilsalin() 'mensalin data pada datagrid3 form3 ke datagrid1 form4
        Call tarikgaris1()
        Call tampilsalin2()
        Call carikesempatanlagi()
        Call tampilsalin3()
        Call tarikgaris2()
    End Sub

    Sub tarikgaris1()
        Dim K1, K2, K3, K4, K5, K6, K7 As Integer
        Dim B1, B2, B3, B4, B5, B6, B7 As Integer
        Dim totalgaris As Integer = 0
        Dim totalgarisb As Integer = 0
        Dim totalgarisk As Integer = 0

        'mencari total nol pada kolom
        For a = 1 To 7
            For b = 0 To 6
                If CInt(DataGridView1.Item(a, b).Value) = 0 Then
                    If a = 1 Then
                        K1 += 1
                    ElseIf a = 2 Then
                        K2 += 1
                    ElseIf a = 3 Then
                        K3 += 1
                    ElseIf a = 4 Then
                        K4 += 1
                    ElseIf a = 5 Then
                        K5 += 1
                    ElseIf a = 6 Then
                        K6 += 1
                    ElseIf a = 7 Then
                        K7 += 1
                    End If
                End If
            Next
        Next

        'mencari total 0 pada baris
        For a = 0 To 6
            For b = 1 To 7
                If CInt(DataGridView1.Item(b, a).Value) = 0 Then
                    If a = 0 Then
                        B1 += 1
                    ElseIf a = 1 Then
                        B2 += 1
                    ElseIf a = 2 Then
                        B3 += 1
                    ElseIf a = 3 Then
                        B4 += 1
                    ElseIf a = 4 Then
                        B5 += 1
                    ElseIf a = 5 Then
                        B6 += 1
                    ElseIf a = 6 Then
                        B7 += 1
                    End If
                End If
            Next
        Next

        Dim besark As Integer = 0
        Dim keterangank As String = ""
        Dim besarb As Integer = 0
        Dim keteranganb As String = ""

        Do Until (totalgaris = 6)
            For a = 0 To 6
                If K1 > besark Then
                    besark = K1
                    keterangank = "K1"
                ElseIf K2 > besark Then
                    besark = K2
                    keterangank = "K2"
                ElseIf K3 > besark Then
                    besark = K3
                    keterangank = "K3"
                ElseIf K4 > besark Then
                    besark = K4
                    keterangank = "K4"
                ElseIf K5 > besark Then
                    besark = K5
                    keterangank = "K5"
                ElseIf K6 > besark Then
                    besark = K6
                    keterangank = "K6"
                ElseIf K7 > besark Then
                    besark = K7
                    keterangank = "K7"
                End If


                If B1 > besarb Then
                    besarb = B1
                    keteranganb = "B1"
                ElseIf B2 > besarb Then
                    besarb = B2
                    keteranganb = "B2"
                ElseIf B3 > besarb Then
                    besarb = B3
                    keteranganb = "B3"
                ElseIf B4 > besarb Then
                    besarb = B4
                    keteranganb = "B4"
                ElseIf B5 > besarb Then
                    besarb = B5
                    keteranganb = "B5"
                ElseIf B6 > besarb Then
                    besarb = B6
                    keteranganb = "B6"
                ElseIf B7 > besarb Then
                    besarb = B7
                    keteranganb = "B7"
                End If
            Next

            If besark > besarb Then
                Dim a As Integer = 0
                If keterangank = "K1" Then
                    a = 1
                    K1 = 0
                ElseIf keterangank = "K2" Then
                    a = 2
                    K2 = 0
                ElseIf keterangank = "K3" Then
                    a = 3
                    K3 = 0
                ElseIf keterangank = "K4" Then
                    a = 4
                    K4 = 0
                ElseIf keterangank = "K5" Then
                    a = 5
                    K5 = 0
                ElseIf keterangank = "K6" Then
                    a = 6
                    K6 = 0
                ElseIf keterangank = "K7" Then
                    a = 7
                    K7 = 0
                End If

                For b = 0 To 6
                    If DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Aqua Then
                        DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Brown
                    Else
                        DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Aqua
                    End If
                Next
                totalgaris += 1
                totalgarisk += 1

            ElseIf besarb > besark Then
                Dim a As Integer = 0
                If keteranganb = "B1" Then
                    a = 0
                    B1 = 0
                ElseIf keteranganb = "B2" Then
                    a = 1
                    B2 = 0
                ElseIf keteranganb = "B3" Then
                    a = 2
                    B3 = 0
                ElseIf keteranganb = "B4" Then
                    a = 3
                    B4 = 0
                ElseIf keteranganb = "B5" Then
                    a = 4
                    B5 = 0
                ElseIf keteranganb = "B6" Then
                    a = 5
                    B6 = 0
                ElseIf keteranganb = "B7" Then
                    a = 6
                    B7 = 0
                End If

                For b = 1 To 7
                    If DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua Then
                        DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Brown
                    Else
                        DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua
                    End If
                Next
                totalgaris += 1
                totalgarisb += 1
            ElseIf besarb = besark Then
                If totalgarisb >= totalgarisk Then
                    Dim a As Integer = 0
                    If keteranganb = "B1" Then
                        a = 0
                        B1 = 0
                    ElseIf keteranganb = "B2" Then
                        a = 1
                        B2 = 0
                    ElseIf keteranganb = "B3" Then
                        a = 2
                        B3 = 0
                    ElseIf keteranganb = "B4" Then
                        a = 3
                        B4 = 0
                    ElseIf keteranganb = "B5" Then
                        a = 4
                        B5 = 0
                    ElseIf keteranganb = "B6" Then
                        a = 5
                        B6 = 0
                    ElseIf keteranganb = "B7" Then
                        a = 6
                        B7 = 0
                    End If
                    For b = 1 To 7
                        If DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua Then
                            DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Brown
                        Else
                            DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua
                        End If
                    Next
                    totalgaris += 1
                    totalgarisb += 1
                Else
                    Dim a As Integer = 0
                    If keterangank = "K1" Then
                        a = 1
                        K1 = 0
                    ElseIf keterangank = "K2" Then
                        a = 2
                        K2 = 0
                    ElseIf keterangank = "K3" Then
                        a = 3
                        K3 = 0
                    ElseIf keterangank = "K4" Then
                        a = 4
                        K4 = 0
                    ElseIf keterangank = "K5" Then
                        a = 5
                        K5 = 0
                    ElseIf keterangank = "K6" Then
                        a = 6
                        K6 = 0
                    ElseIf keterangank = "K7" Then
                        a = 7
                        K7 = 0
                    End If

                    For b = 0 To 6
                        If DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Aqua Then
                            DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Brown
                        Else
                            DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Aqua
                        End If
                    Next
                    totalgaris += 1
                    totalgarisk += 1
                End If
            End If
            besark = 0
            keterangank = ""
            besarb = 0
            keteranganb = ""
        Loop
    End Sub
    Sub carikesempatanlagi()
        Dim nilaikecil As String = ""
        'cari nilai kecil yang tidak terkena garis
        For a = 0 To 6
            For b = 1 To 7
                If Not DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua And Not DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Brown Then
                    If nilaikecil = "" Then
                        nilaikecil = DataGridView1.Item(b, a).Value
                    ElseIf CInt(DataGridView1.Item(b, a).Value) < CInt(nilaikecil) Then
                        nilaikecil = DataGridView1.Item(b, a).Value
                    End If
                End If
            Next
        Next

        'mengurangkan nilai yang tidak terkena garis dengan nilai terkecil yang tidak terkena garis
        For a = 0 To 6
            For b = 1 To 7
                If Not DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Aqua And Not DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Brown Then
                    DataGridView2.Item(b, a).Value = DataGridView1.Item(b, a).Value - CInt(nilaikecil)
                End If
            Next
        Next


        For a = 0 To 6
            For b = 1 To 7
                If DataGridView1.Rows(a).Cells(b).Style.BackColor = Color.Brown Then
                    DataGridView2.Item(b, a).Value = CInt(DataGridView1.Item(b, a).Value) + nilaikecil
                End If
            Next
        Next
        ''menambahkan nilai yang berpotongan garis dengan nilai terkecil
        'For a = 1 To 7
        '    Dim kolom As Integer = 0
        '    Dim baris As Integer = 0
        '    For b = 0 To 6
        '        If DataGridView1.Rows(b).Cells(a).Style.BackColor = Color.Aqua Then
        '            kolom += 1
        '        End If
        '    Next

        '    'jika kolom tergaris lalu mencari apakah baris memiliki potongan
        '    If kolom = 7 Then
        '        For c = 0 To 6
        '            For d = 1 To 7
        '                If DataGridView1.Rows(c).Cells(d).Style.BackColor = Color.Aqua Then
        '                    baris += 1
        '                End If
        '                If Not baris = 7 And d = 7 Then
        '                    baris = 0
        '                End If
        '                If baris = 7 Then
        '                    If Not DataGridView2.Item(a, c).Value = 0 Then
        '                        DataGridView2.Item(a, c).Value = DataGridView2.Item(a, c).Value + nilaikecil
        '                        baris = 0
        '                    End If
        '                    baris = 0
        '                End If
        '            Next
        '        Next
        '    End If
        'Next
    End Sub
    Sub tarikgaris2()
        Dim K1, K2, K3, K4, K5, K6, K7 As Integer
        Dim B1, B2, B3, B4, B5, B6, B7 As Integer
        Dim totalgaris As Integer = 0
        Dim totalgarisb As Integer = 0
        Dim totalgarisk As Integer = 0

        'mencari total nol pada kolom
        For a = 1 To 7
            For b = 0 To 6
                If CInt(DataGridView3.Item(a, b).Value) = 0 Then
                    If a = 1 Then
                        K1 += 1
                    ElseIf a = 2 Then
                        K2 += 1
                    ElseIf a = 3 Then
                        K3 += 1
                    ElseIf a = 4 Then
                        K4 += 1
                    ElseIf a = 5 Then
                        K5 += 1
                    ElseIf a = 6 Then
                        K6 += 1
                    ElseIf a = 7 Then
                        K7 += 1
                    End If
                End If
            Next
        Next

        'mencari total 0 pada baris
        For a = 0 To 6
            For b = 1 To 7
                If CInt(DataGridView3.Item(b, a).Value) = 0 Then
                    If a = 0 Then
                        B1 += 1
                    ElseIf a = 1 Then
                        B2 += 1
                    ElseIf a = 2 Then
                        B3 += 1
                    ElseIf a = 3 Then
                        B4 += 1
                    ElseIf a = 4 Then
                        B5 += 1
                    ElseIf a = 5 Then
                        B6 += 1
                    ElseIf a = 6 Then
                        B7 += 1
                    End If
                End If
            Next
        Next

        Dim besark As Integer = 0
        Dim keterangank As String = ""
        Dim besarb As Integer = 0
        Dim keteranganb As String = ""

        Do Until (totalgaris = 7)
            For a = 0 To 6
                If K1 > besark Then
                    besark = K1
                    keterangank = "K1"
                ElseIf K2 > besark Then
                    besark = K2
                    keterangank = "K2"
                ElseIf K3 > besark Then
                    besark = K3
                    keterangank = "K3"
                ElseIf K4 > besark Then
                    besark = K4
                    keterangank = "K4"
                ElseIf K5 > besark Then
                    besark = K5
                    keterangank = "K5"
                ElseIf K6 > besark Then
                    besark = K6
                    keterangank = "K6"
                ElseIf K7 > besark Then
                    besark = K7
                    keterangank = "K7"
                End If


                If B1 > besarb Then
                    besarb = B1
                    keteranganb = "B1"
                ElseIf B2 > besarb Then
                    besarb = B2
                    keteranganb = "B2"
                ElseIf B3 > besarb Then
                    besarb = B3
                    keteranganb = "B3"
                ElseIf B4 > besarb Then
                    besarb = B4
                    keteranganb = "B4"
                ElseIf B5 > besarb Then
                    besarb = B5
                    keteranganb = "B5"
                ElseIf B6 > besarb Then
                    besarb = B6
                    keteranganb = "B6"
                ElseIf B7 > besarb Then
                    besarb = B7
                    keteranganb = "B7"
                End If
            Next

            If besark > besarb Then
                Dim a As Integer = 0
                If keterangank = "K1" Then
                    a = 1
                    K1 = 0
                ElseIf keterangank = "K2" Then
                    a = 2
                    K2 = 0
                ElseIf keterangank = "K3" Then
                    a = 3
                    K3 = 0
                ElseIf keterangank = "K4" Then
                    a = 4
                    K4 = 0
                ElseIf keterangank = "K5" Then
                    a = 5
                    K5 = 0
                ElseIf keterangank = "K6" Then
                    a = 6
                    K6 = 0
                ElseIf keterangank = "K7" Then
                    a = 7
                    K7 = 0
                End If

                For b = 0 To 6
                    DataGridView3.Rows(b).Cells(a).Style.BackColor = Color.Aqua
                Next
                totalgaris += 1
                totalgarisk += 1

            ElseIf besarb > besark Then
                Dim a As Integer = 0
                If keteranganb = "B1" Then
                    a = 0
                    B1 = 0
                ElseIf keteranganb = "B2" Then
                    a = 1
                    B2 = 0
                ElseIf keteranganb = "B3" Then
                    a = 2
                    B3 = 0
                ElseIf keteranganb = "B4" Then
                    a = 3
                    B4 = 0
                ElseIf keteranganb = "B5" Then
                    a = 4
                    B5 = 0
                ElseIf keteranganb = "B6" Then
                    a = 5
                    B6 = 0
                ElseIf keteranganb = "B7" Then
                    a = 6
                    B7 = 0
                End If

                For b = 1 To 7
                    DataGridView3.Rows(a).Cells(b).Style.BackColor = Color.Aqua
                Next
                totalgaris += 1
                totalgarisb += 1
            ElseIf besarb = besark Then
                If totalgarisb >= totalgarisk Then
                    Dim a As Integer = 0
                    If keteranganb = "B1" Then
                        a = 0
                        B1 = 0
                    ElseIf keteranganb = "B2" Then
                        a = 1
                        B2 = 0
                    ElseIf keteranganb = "B3" Then
                        a = 2
                        B3 = 0
                    ElseIf keteranganb = "B4" Then
                        a = 3
                        B4 = 0
                    ElseIf keteranganb = "B5" Then
                        a = 4
                        B5 = 0
                    ElseIf keteranganb = "B6" Then
                        a = 5
                        B6 = 0
                    ElseIf keteranganb = "B7" Then
                        a = 6
                        B7 = 0
                    End If
                    For b = 1 To 7
                        DataGridView3.Rows(a).Cells(b).Style.BackColor = Color.Aqua
                    Next
                    totalgaris += 1
                    totalgarisb += 1
                Else
                    Dim a As Integer = 0
                    If keterangank = "K1" Then
                        a = 1
                        K1 = 0
                    ElseIf keterangank = "K2" Then
                        a = 2
                        K2 = 0
                    ElseIf keterangank = "K3" Then
                        a = 3
                        K3 = 0
                    ElseIf keterangank = "K4" Then
                        a = 4
                        K4 = 0
                    ElseIf keterangank = "K5" Then
                        a = 5
                        K5 = 0
                    ElseIf keterangank = "K6" Then
                        a = 6
                        K6 = 0
                    ElseIf keterangank = "K7" Then
                        a = 7
                        K7 = 0
                    End If

                    For b = 0 To 6
                        DataGridView3.Rows(b).Cells(a).Style.BackColor = Color.Aqua
                    Next
                    totalgaris += 1
                    totalgarisk += 1
                End If
            End If
            besark = 0
            keterangank = ""
            besarb = 0
            keteranganb = ""
        Loop
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub
End Class