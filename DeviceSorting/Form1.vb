Imports System.IO

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim path As String = FilePath()
        If path <> "" Then
            DataGridViewDevice.DataSource = ImportDataToGridView(path)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = FilePath()
        If path <> "" Then
            DataGridViewPackage.DataSource = ImportDataToGridView(path)
        End If
    End Sub

    Function FilePath() As String
        Dim ret As String = ""
        Dim dg As New OpenFileDialog
        If dg.ShowDialog = DialogResult.OK Then
            ret = dg.FileName
        End If
        Return ret
    End Function
    Function ImportDataToGridView(path As String) As DataTable
        If Not File.Exists(path) Then
            Return Nothing
        ElseIf path.Contains("csv") = False Then
            Return Nothing
        End If


        Using SR As StreamReader = New StreamReader(path)
            Dim line As String = SR.ReadLine()
            Dim strArray As String() = line.Split(","c)
            Dim dt As DataTable = New DataTable()
            Dim row As DataRow

            For Each s As String In strArray
                ' line = SR.ReadLine
                Dim dataColumnName As New DataColumn
                dataColumnName.ColumnName = s
                dt.Columns.Add(dataColumnName)
            Next

            Do
                line = SR.ReadLine
                If Not line = String.Empty Then
                    row = dt.NewRow()
                    row.ItemArray = line.Split(","c)
                    dt.Rows.Add(row)
                Else
                    Exit Do
                End If
            Loop
            Return dt
        End Using
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridViewDevice.Rows.Count = 0 Then
            MsgBox("กรุณาเลือก Device")
            Exit Sub
        ElseIf DataGridViewPackage.Rows.Count = 0 Then
            MsgBox("กรุณาเลือก TP Rank")
            Exit Sub
        End If

        Dim DeviceListtable As New DataTable
        Dim packageColumn As New DataColumn
        Dim deviceColumn As New DataColumn

        packageColumn.ColumnName = "Package"
        deviceColumn.ColumnName = "Device"

        DeviceListtable.Columns.Add(packageColumn)
        DeviceListtable.Columns.Add(deviceColumn)

        For Each strdata As DataGridViewRow In DataGridViewDevice.Rows
            Try

                Dim package1 As String = strdata.Cells("Package1").Value.ToString
                Dim device As String = strdata.Cells("DeviceName").Value.ToString
                Dim rank As String = strdata.Cells("InputRank").Value.ToString
                Dim ArrayS As String() = rank.Split("/")

                For Each deviceAdd As String In ArrayS
                    Dim newRow As DataRow = DeviceListtable.NewRow
                    newRow("Package") = package1
                    Dim newDevice As String = device
                    If deviceAdd.Contains("-") Then
                        newRow("Device") = device
                    Else
                        newRow("Device") = device & "-" & deviceAdd
                    End If
                    DeviceListtable.Rows.Add(newRow)
                Next
            Catch ex As Exception

            End Try
        Next


        For Each strData As DataRow In DeviceListtable.Rows
            Dim package As String = strData("Package")
            For Each strdata1 As DataGridViewRow In DataGridViewPackage.Rows
                Try
                    If package.Trim = strdata1.Cells("TYPE_NAME").Value.ToString.Trim Then
                        strData("Device") = strData("Device") & strdata1.Cells("TPRANK").Value.ToString.Trim
                    End If
                Catch ex As Exception

                End Try
            Next

        Next

        DataGridView2.DataSource = DeviceListtable



    End Sub
End Class
