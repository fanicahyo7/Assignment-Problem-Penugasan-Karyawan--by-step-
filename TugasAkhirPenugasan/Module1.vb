Imports System.Data.Odbc
Module Module1
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DS As New DataSet
    Public DA As OdbcDataAdapter
    Public RD As OdbcDataReader
    Dim LokasiData As String
    Sub Koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};Database=cb;server=localhost;uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module
