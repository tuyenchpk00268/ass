Public Class KhachHang

    Dim classdata1 As New layer_data

    Private Sub KhachHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        classdata1.laydulieu("select * from KhachHang ")
        Dim dt As New DataTable
        dt = classdata1.datatable
        dgr_Kh.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        classdata1.thucthi("insert into KhachHang (MaKH,TenKH,NamSinh,GioiTinh,SDT,DiaChi,CMND) values ('" + txtmakh.Text + "','" + txttenkh.Text + "','" + txtnamsinh.Text + "','" + txtgioitinh.Text + "','" + txtsdt.Text + "','" + txtdiachi.Text + "','" + txtcmnd.Text + "')")
        If classdata1.status = "ok" Then
            MessageBox.Show("Thêm Thành Công")
            loaddata()
        Else
            MessageBox.Show("Lỗi")
        End If
    End Sub

   
    Private Sub Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xoa.Click
        classdata1.thucthi("delete from KhachHang where MaKH = '" & txtmakh.Text & "'")
        If classdata1.status = "ok" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub dgr_Kh_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_Kh.CellClick
        Dim vitri As Integer = dgr_Kh.CurrentCell.RowIndex
        txtmakh.Text = dgr_Kh.Rows(vitri).Cells(0).Value.ToString()
    End Sub

    Private Sub Sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sua.Click
        classdata1.thucthi("update KhachHang Set MaKH = '" + txtmakh.Text + "',TenKH = N'" + txttenkh.Text + "',NamSinh = '" + txtnamsinh.Text + "', GioiTinh = '" + txtnamsinh.Text + "',SDT = '" + txtsdt.Text + "',DiaChi = '" + txtsdt.Text + "',CMND = '" + txtcmnd.Text + "' where MaKH = '" + txtmakh.Text + "'  ")
        If classdata1.status = "ok" Then
            MessageBox.Show("Đã Sữa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub dgr_Kh_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_Kh.CellContentClick
        Dim vitri As Integer = dgr_Kh.CurrentCell.RowIndex
        txtmakh.Text = dgr_Kh.Rows(vitri).Cells(0).Value.ToString()
        txttenkh.Text = dgr_Kh.Rows(vitri).Cells(1).Value.ToString()

    End Sub
End Class