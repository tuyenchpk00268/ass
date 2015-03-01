<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_masp = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txtgiasp = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtngaysx = New System.Windows.Forms.TextBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.drv_sanPham = New System.Windows.Forms.DataGridView()
        CType(Me.drv_sanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sản Phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Loại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mã Loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giá Sản Phẩm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mô Tả"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ngày Sản Xuất"
        '
        'txt_masp
        '
        Me.txt_masp.Location = New System.Drawing.Point(117, 26)
        Me.txt_masp.Name = "txt_masp"
        Me.txt_masp.Size = New System.Drawing.Size(218, 20)
        Me.txt_masp.TabIndex = 7
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(117, 66)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(218, 20)
        Me.txtTenSP.TabIndex = 8
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(117, 108)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(218, 20)
        Me.txttenloai.TabIndex = 9
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(117, 154)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(218, 20)
        Me.txtmaloai.TabIndex = 10
        '
        'txtgiasp
        '
        Me.txtgiasp.Location = New System.Drawing.Point(559, 26)
        Me.txtgiasp.Name = "txtgiasp"
        Me.txtgiasp.Size = New System.Drawing.Size(218, 20)
        Me.txtgiasp.TabIndex = 11
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(559, 65)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(218, 20)
        Me.txtmota.TabIndex = 12
        '
        'txtngaysx
        '
        Me.txtngaysx.Location = New System.Drawing.Point(559, 109)
        Me.txtngaysx.Name = "txtngaysx"
        Me.txtngaysx.Size = New System.Drawing.Size(218, 20)
        Me.txtngaysx.TabIndex = 13
        '
        'Them
        '
        Me.Them.Location = New System.Drawing.Point(176, 210)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(90, 35)
        Me.Them.TabIndex = 14
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Xoa
        '
        Me.Xoa.Location = New System.Drawing.Point(432, 210)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(91, 35)
        Me.Xoa.TabIndex = 15
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Sua
        '
        Me.Sua.Location = New System.Drawing.Point(663, 210)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(88, 35)
        Me.Sua.TabIndex = 16
        Me.Sua.Text = "Sữa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'drv_sanPham
        '
        Me.drv_sanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drv_sanPham.Location = New System.Drawing.Point(13, 265)
        Me.drv_sanPham.Name = "drv_sanPham"
        Me.drv_sanPham.Size = New System.Drawing.Size(975, 207)
        Me.drv_sanPham.TabIndex = 17
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 475)
        Me.Controls.Add(Me.drv_sanPham)
        Me.Controls.Add(Me.Sua)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Them)
        Me.Controls.Add(Me.txtngaysx)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtgiasp)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txttenloai)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txt_masp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SanPham"
        Me.Text = "SanPham"
        CType(Me.drv_sanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_masp As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txtgiasp As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtngaysx As System.Windows.Forms.TextBox
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents drv_sanPham As System.Windows.Forms.DataGridView
End Class
