Imports System.Data.SqlClient
Imports System.Data
Public Class FrmQLSV
    Dim sqlConnect As New QLSinhVien
    Private Sub FrmQLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQLSV()
    End Sub

    Private Sub LoadQLSV()
        LwQLSV.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from DanhSach")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(LwQLSV.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            item.SubItems.Add(dt.Rows(i).ItemArray(5))
            item.SubItems.Add(dt.Rows(i).ItemArray(6))
            LwQLSV.Items.Add(item)
        Next

    End Sub
    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        If TxbMSV.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sinh viên")
        ElseIf TxbTSV.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên sinh viên")
        ElseIf CbGT.Text = "" Then
            MessageBox.Show("Vui lòng chọn giới tính")
        ElseIf TxbNS.Text = "" Then
            MessageBox.Show("Vui lòng nhập ngày sinh")
        ElseIf TxbDC.Text = "" Then
            MessageBox.Show("Vui lòng nhập địa chỉ")
        ElseIf TxbSDT.Text = "" Then
            MessageBox.Show("Vui lòng nhập số điện thoại")
        Else
            sqlConnect.ExecuteNoneQuery("Insert into DanhSach(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi,SDT) values('" + TxbMSV.Text + "',N'" + TxbTSV.Text + "','" + CbGT.Text + "','" + TxbNS.Text + "',N'" + TxbDC.Text + "','" + TxbSDT.Text + "')")
            LoadQLSV()
        End If
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Application.Exit()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        If TxbMSV.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sinh viên")
        ElseIf TxbTSV.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên sinh viên")
        ElseIf CbGT.Text = "" Then
            MessageBox.Show("Vui lòng chọn giới tính")
        ElseIf TxbNS.Text = "" Then
            MessageBox.Show("Vui lòng nhập ngày sinh")
        ElseIf TxbDC.Text = "" Then
            MessageBox.Show("Vui lòng nhập địa chỉ")
        ElseIf TxbSDT.Text = "" Then
            MessageBox.Show("Vui lòng nhập số điện thoại")
        Else
            For i As Integer = LwQLSV.SelectedIndices.Count - 1 To 0 Step -1
                Dim viTriCanSua As Integer = LwQLSV.SelectedIndices(i)
                Dim maSvCanSua As String = LwQLSV.Items(viTriCanSua).SubItems(1).Text
                sqlConnect.ExecuteNoneQuery("Update DanhSach set MaSV='" + TxbMSV.Text + "',TenSV=N'" + TxbTSV.Text + "',GioiTinh='" + CbGT.Text + "',NgaySinh='" + TxbNS.Text + "',DiaChi=N'" + TxbDC.Text + "',SDT='" + TxbSDT.Text + "' where MaSV=" + maSvCanSua)
            Next
            LoadQLSV()
        End If
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        For i As Integer = LwQLSV.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LwQLSV.SelectedIndices(i)
            Dim maSvCanXoa As String = LwQLSV.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from DanhSach where MaSV =" + maSvCanXoa)
        Next
        LoadQLSV()
    End Sub

    Private Sub LwQLSV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LwQLSV.SelectedIndexChanged
        For Each ds As ListViewItem In LwQLSV.SelectedItems
            TxbMSV.Text = ds.SubItems(1).Text
            TxbTSV.Text = ds.SubItems(2).Text
            CbGT.Text = ds.SubItems(3).Text
            TxbNS.Text = ds.SubItems(4).Text
            TxbDC.Text = ds.SubItems(5).Text
            TxbSDT.Text = ds.SubItems(6).Text
        Next
    End Sub
End Class
