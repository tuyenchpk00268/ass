<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoaDon
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
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtngaylaphd = New System.Windows.Forms.TextBox()
        Me.txtnhanvienlaphd = New System.Windows.Forms.TextBox()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Lập Hóa Đơn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nhân Viên Lập Hóa Đơn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mã Nhân Viên"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mã Sản Phẩm"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(167, 45)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(197, 20)
        Me.txtMaHD.TabIndex = 6
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(167, 93)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(197, 20)
        Me.txtmakh.TabIndex = 7
        '
        'txtngaylaphd
        '
        Me.txtngaylaphd.Location = New System.Drawing.Point(167, 139)
        Me.txtngaylaphd.Name = "txtngaylaphd"
        Me.txtngaylaphd.Size = New System.Drawing.Size(197, 20)
        Me.txtngaylaphd.TabIndex = 8
        '
        'txtnhanvienlaphd
        '
        Me.txtnhanvienlaphd.Location = New System.Drawing.Point(587, 42)
        Me.txtnhanvienlaphd.Name = "txtnhanvienlaphd"
        Me.txtnhanvienlaphd.Size = New System.Drawing.Size(197, 20)
        Me.txtnhanvienlaphd.TabIndex = 9
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(587, 86)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(197, 20)
        Me.txtmanv.TabIndex = 10
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(587, 135)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(197, 20)
        Me.txtmasp.TabIndex = 11
        '
        'Them
        '
        Me.Them.Location = New System.Drawing.Point(134, 187)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(86, 34)
        Me.Them.TabIndex = 12
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Xoa
        '
        Me.Xoa.Location = New System.Drawing.Point(388, 187)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(89, 34)
        Me.Xoa.TabIndex = 13
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Sua
        '
        Me.Sua.Location = New System.Drawing.Point(638, 187)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(80, 34)
        Me.Sua.TabIndex = 14
        Me.Sua.Text = "Sữa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(782, 196)
        Me.DataGridView1.TabIndex = 15
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 461)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Sua)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Them)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.txtmanv)
        Me.Controls.Add(Me.txtnhanvienlaphd)
        Me.Controls.Add(Me.txtngaylaphd)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HoaDon"
        Me.Text = "HoaDon"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtngaylaphd As System.Windows.Forms.TextBox
    Friend WithEvents txtnhanvienlaphd As System.Windows.Forms.TextBox
    Friend WithEvents txtmanv As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
