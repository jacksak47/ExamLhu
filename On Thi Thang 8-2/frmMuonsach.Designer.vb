<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuonsach
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
        Me.grbDocGia = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaDocGia = New System.Windows.Forms.TextBox()
        Me.gbSachMuon = New System.Windows.Forms.GroupBox()
        Me.btnDongY = New System.Windows.Forms.Button()
        Me.dtpNgayHenTra = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgaymuon = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTBSach = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMasach = New System.Windows.Forms.TextBox()
        Me.dtgDSMuonSach = New System.Windows.Forms.DataGridView()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayHenTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoaDanhSach = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.grbDocGia.SuspendLayout()
        Me.gbSachMuon.SuspendLayout()
        CType(Me.dtgDSMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDocGia
        '
        Me.grbDocGia.Controls.Add(Me.Label4)
        Me.grbDocGia.Controls.Add(Me.lblTB)
        Me.grbDocGia.Controls.Add(Me.Label5)
        Me.grbDocGia.Controls.Add(Me.Label3)
        Me.grbDocGia.Controls.Add(Me.Label2)
        Me.grbDocGia.Controls.Add(Me.txtDiaChi)
        Me.grbDocGia.Controls.Add(Me.txtGioiTinh)
        Me.grbDocGia.Controls.Add(Me.txtNgaySinh)
        Me.grbDocGia.Controls.Add(Me.txtHoTen)
        Me.grbDocGia.Controls.Add(Me.Label1)
        Me.grbDocGia.Controls.Add(Me.txtMaDocGia)
        Me.grbDocGia.Location = New System.Drawing.Point(21, 33)
        Me.grbDocGia.Name = "grbDocGia"
        Me.grbDocGia.Size = New System.Drawing.Size(418, 134)
        Me.grbDocGia.TabIndex = 0
        Me.grbDocGia.TabStop = False
        Me.grbDocGia.Text = "Thông tin độc giả"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giới tính"
        '
        'lblTB
        '
        Me.lblTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTB.ForeColor = System.Drawing.Color.Red
        Me.lblTB.Location = New System.Drawing.Point(73, 103)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(277, 22)
        Me.lblTB.TabIndex = 6
        Me.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ngày sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Họ tên"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(297, 75)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(104, 20)
        Me.txtDiaChi.TabIndex = 4
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(327, 35)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(74, 20)
        Me.txtGioiTinh.TabIndex = 3
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(76, 75)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(104, 20)
        Me.txtNgaySinh.TabIndex = 2
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(76, 35)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(159, 20)
        Me.txtHoTen.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã độc giả   "
        '
        'txtMaDocGia
        '
        Me.txtMaDocGia.Location = New System.Drawing.Point(318, -1)
        Me.txtMaDocGia.Name = "txtMaDocGia"
        Me.txtMaDocGia.Size = New System.Drawing.Size(100, 20)
        Me.txtMaDocGia.TabIndex = 0
        '
        'gbSachMuon
        '
        Me.gbSachMuon.Controls.Add(Me.btnDongY)
        Me.gbSachMuon.Controls.Add(Me.dtpNgayHenTra)
        Me.gbSachMuon.Controls.Add(Me.dtpNgaymuon)
        Me.gbSachMuon.Controls.Add(Me.Label6)
        Me.gbSachMuon.Controls.Add(Me.lblTBSach)
        Me.gbSachMuon.Controls.Add(Me.d)
        Me.gbSachMuon.Controls.Add(Me.Label9)
        Me.gbSachMuon.Controls.Add(Me.Label10)
        Me.gbSachMuon.Controls.Add(Me.txtTacGia)
        Me.gbSachMuon.Controls.Add(Me.txttensach)
        Me.gbSachMuon.Controls.Add(Me.Label11)
        Me.gbSachMuon.Controls.Add(Me.txtMasach)
        Me.gbSachMuon.Location = New System.Drawing.Point(483, 33)
        Me.gbSachMuon.Name = "gbSachMuon"
        Me.gbSachMuon.Size = New System.Drawing.Size(418, 134)
        Me.gbSachMuon.TabIndex = 1
        Me.gbSachMuon.TabStop = False
        Me.gbSachMuon.Text = "Thông tin sách mượn"
        '
        'btnDongY
        '
        Me.btnDongY.Location = New System.Drawing.Point(355, 72)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(46, 23)
        Me.btnDongY.TabIndex = 9
        Me.btnDongY.Text = "OK"
        Me.btnDongY.UseVisualStyleBackColor = True
        '
        'dtpNgayHenTra
        '
        Me.dtpNgayHenTra.CustomFormat = "dd/MM/yyy"
        Me.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHenTra.Location = New System.Drawing.Point(259, 75)
        Me.dtpNgayHenTra.Name = "dtpNgayHenTra"
        Me.dtpNgayHenTra.Size = New System.Drawing.Size(90, 20)
        Me.dtpNgayHenTra.TabIndex = 8
        '
        'dtpNgaymuon
        '
        Me.dtpNgaymuon.CustomFormat = "dd/MM/yyy"
        Me.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaymuon.Location = New System.Drawing.Point(76, 75)
        Me.dtpNgaymuon.Name = "dtpNgaymuon"
        Me.dtpNgaymuon.Size = New System.Drawing.Size(90, 20)
        Me.dtpNgaymuon.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tác giả"
        '
        'lblTBSach
        '
        Me.lblTBSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTBSach.ForeColor = System.Drawing.Color.Red
        Me.lblTBSach.Location = New System.Drawing.Point(73, 100)
        Me.lblTBSach.Name = "lblTBSach"
        Me.lblTBSach.Size = New System.Drawing.Size(277, 22)
        Me.lblTBSach.TabIndex = 6
        Me.lblTBSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(185, 78)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(68, 13)
        Me.d.TabIndex = 6
        Me.d.Text = "Ngày hẹn trả"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Ngày mượn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tên sách"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(297, 35)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(104, 20)
        Me.txtTacGia.TabIndex = 3
        '
        'txttensach
        '
        Me.txttensach.Location = New System.Drawing.Point(76, 35)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(136, 20)
        Me.txttensach.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(249, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Mã sách       "
        '
        'txtMasach
        '
        Me.txtMasach.Location = New System.Drawing.Point(319, -1)
        Me.txtMasach.Name = "txtMasach"
        Me.txtMasach.Size = New System.Drawing.Size(100, 20)
        Me.txtMasach.TabIndex = 0
        '
        'dtgDSMuonSach
        '
        Me.dtgDSMuonSach.AllowUserToAddRows = False
        Me.dtgDSMuonSach.AllowUserToDeleteRows = False
        Me.dtgDSMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDSMuonSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.TacGia, Me.NgayMuon, Me.NgayHenTra, Me.Chon})
        Me.dtgDSMuonSach.Location = New System.Drawing.Point(21, 242)
        Me.dtgDSMuonSach.Name = "dtgDSMuonSach"
        Me.dtgDSMuonSach.Size = New System.Drawing.Size(594, 231)
        Me.dtgDSMuonSach.TabIndex = 2
        '
        'MaSach
        '
        Me.MaSach.HeaderText = "Mã sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.Width = 80
        '
        'TenSach
        '
        Me.TenSach.HeaderText = "Tên sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.Width = 120
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác giả"
        Me.TacGia.Name = "TacGia"
        '
        'NgayMuon
        '
        Me.NgayMuon.HeaderText = "Ngày mượn"
        Me.NgayMuon.Name = "NgayMuon"
        '
        'NgayHenTra
        '
        Me.NgayHenTra.HeaderText = "Ngày hẹn trả"
        Me.NgayHenTra.Name = "NgayHenTra"
        '
        'Chon
        '
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Width = 50
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(594, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DANH SÁCH CÁC SÁCH CHO MƯỢN"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnXoaDanhSach)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Location = New System.Drawing.Point(711, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 255)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(50, 82)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(89, 23)
        Me.btnThoat.TabIndex = 10
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoaDanhSach
        '
        Me.btnXoaDanhSach.Location = New System.Drawing.Point(50, 53)
        Me.btnXoaDanhSach.Name = "btnXoaDanhSach"
        Me.btnXoaDanhSach.Size = New System.Drawing.Size(89, 23)
        Me.btnXoaDanhSach.TabIndex = 10
        Me.btnXoaDanhSach.Text = "Xóa danh sách"
        Me.btnXoaDanhSach.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(50, 24)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(89, 23)
        Me.btnLuu.TabIndex = 10
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'frmMuonsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtgDSMuonSach)
        Me.Controls.Add(Me.gbSachMuon)
        Me.Controls.Add(Me.grbDocGia)
        Me.Name = "frmMuonsach"
        Me.Text = "frmMuonsach"
        Me.grbDocGia.ResumeLayout(False)
        Me.grbDocGia.PerformLayout()
        Me.gbSachMuon.ResumeLayout(False)
        Me.gbSachMuon.PerformLayout()
        CType(Me.dtgDSMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDocGia As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaDocGia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents lblTB As System.Windows.Forms.Label
    Friend WithEvents gbSachMuon As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTBSach As System.Windows.Forms.Label
    Friend WithEvents d As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents txttensach As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMasach As System.Windows.Forms.TextBox
    Friend WithEvents dtpNgayHenTra As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNgaymuon As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDongY As System.Windows.Forms.Button
    Friend WithEvents dtgDSMuonSach As System.Windows.Forms.DataGridView
    Friend WithEvents MaSach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TacGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayMuon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayHenTra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoaDanhSach As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
End Class
