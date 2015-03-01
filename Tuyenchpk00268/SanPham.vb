Public Class SanPham

    Dim classdata As New layer_data()

    Private Sub SanPham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        classdata.laydulieu("select * from SanPham")
        Dim dt As New DataTable
        dt = classdata.datatable
        drv_sanPham.DataSource = dt
    End Sub


    Private Sub Them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Them.Click
        classdata.moketnoi()
        classdata.thucthi("insert into SanPham (MaSP,TenSP,TenLoai,MaLoai,GiaSP,MoTa,NSX) values ('" + txt_masp.Text + "',N'" + txtTenSP.Text + "',N'" + txttenloai.Text + "','" + txtmaloai.Text + "','" + txtgiasp.Text + "','" + txtmota.Text + "','" + txtngaysx.Text + "')")
        classdata.dongketnoi()
        If classdata.status = "ok" Then
            MessageBox.Show("Thêm thành công")
            loaddata()
        Else
            MessageBox.Show("Thêm dữ liệu lỗi")
        End If

    End Sub

    Private Sub Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xoa.Click
        classdata.thucthi("delete from SanPham where MaSP = '" & txt_masp.Text & "'")
        Dim status As String
        status = classdata.status
        If status = "ok" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub
    
    
    Private Sub Sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sua.Click

        classdata.thucthi("update SanPham set MaSP ='" & txt_masp.Text & "',TenSP = N'" & txtTenSP.Text & "',TenLoai = N'" & txttenloai.Text & "',MaLoai ='" & txtmaloai.Text & "',GiaSP ='" & txtgiasp.Text & "',MoTa = N'" & txtmota.Text & "',NSX= '" & txtngaysx.Text & "' where MaSP = '" & txt_masp.Text & "'")
        Dim status As String
        status = classdata.status
        If status = "ok" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub

    Private Sub drv_sanPham_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles drv_sanPham.CellClick
        Dim vitri As Integer = drv_sanPham.CurrentCell.RowIndex
        txt_masp.Text = drv_sanPham.Rows(vitri).Cells(0).Value.ToString()
        txtTenSP.Text = drv_sanPham.Rows(vitri).Cells(1).Value.ToString()

    End Sub
End Class

