Public Class HoaDon
    Dim classdata As New layer_data()

    Private Sub HoaDon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        classdata.laydulieu("select * from HoaDon")
        Dim dt As New DataTable
        dt = classdata.datatable
        DataGridView1.DataSource = dt
    End Sub
 
    Private Sub Them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Them.Click
        classdata.moketnoi()
        classdata.thucthi("insert into HoaDon (MaHD,MaKH,NgayLapHD,NhanVienLapHD,MaNV,MaSP) values ('" + txtMaHD.Text + "','" + txtmakh.Text + "',N'" + txtngaylaphd.Text + "','" + txtnhanvienlaphd.Text + "','" + txtmanv.Text + "','" + txtmasp.Text + "')")
        classdata.dongketnoi()
        If classdata.status = "ok" Then
            MessageBox.Show("Thêm thành công")
            loaddata()
        Else
            MessageBox.Show("Thêm dữ liệu lỗi")
        End If
    End Sub

    Private Sub Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xoa.Click
        classdata.thucthi("delete from HoaDon where MaHD = '" & txtMaHD.Text & "'")
        Dim status As String
        status = classdata.status
        If status = "ok" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaHD.Text = DataGridView1.Rows(vitri).Cells(0).Value.ToString()
        txtmakh.Text = DataGridView1.Rows(vitri).Cells(1).Value.ToString()

    End Sub

    Private Sub Sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sua.Click
        classdata.thucthi("update HoaDon set MaKH = '" & txtmakh.Text & "',NgayLapHD = '" & txtngaylaphd.Text & "',NhanVienLapHD ='" & txtnhanvienlaphd.Text & "',MaNV ='" & txtmanv.Text & "',MaSP = '" & txtmasp.Text & "' where MaHD = '" & txtMaHD.Text & "'")
        Dim status As String
        status = classdata.status
        If status = "ok" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub
End Class

