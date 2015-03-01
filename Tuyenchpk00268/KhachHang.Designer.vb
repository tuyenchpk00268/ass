<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KhachHang
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
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtnamsinh = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtcmnd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.dgr_Kh = New System.Windows.Forms.DataGridView()
        CType(Me.dgr_Kh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Năm Sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giới Tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số Điện Thoại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Địa Chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Chứng Minh Nhân Dân"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(168, 26)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(221, 20)
        Me.txtmakh.TabIndex = 7
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(168, 77)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(221, 20)
        Me.txttenkh.TabIndex = 8
        '
        'txtnamsinh
        '
        Me.txtnamsinh.Location = New System.Drawing.Point(168, 127)
        Me.txtnamsinh.Name = "txtnamsinh"
        Me.txtnamsinh.Size = New System.Drawing.Size(221, 20)
        Me.txtnamsinh.TabIndex = 9
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(168, 171)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(221, 20)
        Me.txtgioitinh.TabIndex = 10
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(581, 29)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(221, 20)
        Me.txtsdt.TabIndex = 11
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(581, 77)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(221, 20)
        Me.txtdiachi.TabIndex = 12
        '
        'txtcmnd
        '
        Me.txtcmnd.Location = New System.Drawing.Point(581, 124)
        Me.txtcmnd.Name = "txtcmnd"
        Me.txtcmnd.Size = New System.Drawing.Size(221, 20)
        Me.txtcmnd.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Xoa
        '
        Me.Xoa.Location = New System.Drawing.Point(441, 224)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(85, 32)
        Me.Xoa.TabIndex = 15
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Sua
        '
        Me.Sua.Location = New System.Drawing.Point(707, 224)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(84, 32)
        Me.Sua.TabIndex = 16
        Me.Sua.Text = "Sữa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'dgr_Kh
        '
        Me.dgr_Kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgr_Kh.Location = New System.Drawing.Point(13, 268)
        Me.dgr_Kh.Name = "dgr_Kh"
        Me.dgr_Kh.Size = New System.Drawing.Size(945, 187)
        Me.dgr_Kh.TabIndex = 17
        '
        'KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 456)
        Me.Controls.Add(Me.dgr_Kh)
        Me.Controls.Add(Me.Sua)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcmnd)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtnamsinh)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.dgr_Kh, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtnamsinh As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtcmnd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents dgr_Kh As System.Windows.Forms.DataGridView
End Class
