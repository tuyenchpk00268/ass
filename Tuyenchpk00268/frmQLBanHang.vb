Public Class QLKH

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        DangNhap.Show()
        Me.Hide()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        SanPham.Show()

    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KhachHang.Show()

    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        HoaDon.Show()

    End Sub
End Class