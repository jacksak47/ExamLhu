<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocGia
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
        Me.components = New System.ComponentModel.Container()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.dtpNS = New System.Windows.Forms.DateTimePicker()
        Me.chkGioiTinh = New System.Windows.Forms.CheckBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.picHinh = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.btnChonhinh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnBoqua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dtgDSDocGia = New System.Windows.Forms.DataGridView()
        Me.MaDocGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDocGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinhDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SpLayDSDocGiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsQuanLyThuVienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsQuanLyThuVien = New On_Thi_Thang_8_2.dsQuanLyThuVien()
        Me.Sp_LayDSDocGiaTableAdapter = New On_Thi_Thang_8_2.dsQuanLyThuVienTableAdapters.sp_LayDSDocGiaTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmsXoa = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgDSDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLayDSDocGiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsQuanLyThuVienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsQuanLyThuVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsXoa.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(77, 35)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(221, 20)
        Me.txtHoTen.TabIndex = 0
        '
        'dtpNS
        '
        Me.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNS.Location = New System.Drawing.Point(77, 75)
        Me.dtpNS.Name = "dtpNS"
        Me.dtpNS.Size = New System.Drawing.Size(123, 20)
        Me.dtpNS.TabIndex = 1
        '
        'chkGioiTinh
        '
        Me.chkGioiTinh.AutoSize = True
        Me.chkGioiTinh.Location = New System.Drawing.Point(250, 75)
        Me.chkGioiTinh.Name = "chkGioiTinh"
        Me.chkGioiTinh.Size = New System.Drawing.Size(48, 17)
        Me.chkGioiTinh.TabIndex = 2
        Me.chkGioiTinh.Text = "Nam"
        Me.chkGioiTinh.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(77, 115)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(221, 20)
        Me.txtDiaChi.TabIndex = 3
        '
        'picHinh
        '
        Me.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHinh.Location = New System.Drawing.Point(359, 35)
        Me.picHinh.Name = "picHinh"
        Me.picHinh.Size = New System.Drawing.Size(100, 100)
        Me.picHinh.TabIndex = 4
        Me.picHinh.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTB)
        Me.GroupBox1.Controls.Add(Me.btnChonhinh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.picHinh)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.dtpNS)
        Me.GroupBox1.Controls.Add(Me.chkGioiTinh)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 194)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin độc giả"
        '
        'lblTB
        '
        Me.lblTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTB.ForeColor = System.Drawing.Color.Red
        Me.lblTB.Location = New System.Drawing.Point(23, 151)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(275, 24)
        Me.lblTB.TabIndex = 7
        '
        'btnChonhinh
        '
        Me.btnChonhinh.Location = New System.Drawing.Point(359, 141)
        Me.btnChonhinh.Name = "btnChonhinh"
        Me.btnChonhinh.Size = New System.Drawing.Size(100, 23)
        Me.btnChonhinh.TabIndex = 6
        Me.btnChonhinh.Text = "Chọn hình"
        Me.btnChonhinh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ngày sinh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Họ tên"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Controls.Add(Me.BtnBoqua)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Location = New System.Drawing.Point(550, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 194)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(21, 77)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Thoát"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnBoqua
        '
        Me.BtnBoqua.Location = New System.Drawing.Point(21, 48)
        Me.BtnBoqua.Name = "BtnBoqua"
        Me.BtnBoqua.Size = New System.Drawing.Size(75, 23)
        Me.BtnBoqua.TabIndex = 1
        Me.BtnBoqua.Text = "Bỏ qua"
        Me.BtnBoqua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(21, 19)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 0
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "Chon hinh"
        Me.dlgOpen.FilterIndex = 4
        '
        'dtgDSDocGia
        '
        Me.dtgDSDocGia.AllowUserToAddRows = False
        Me.dtgDSDocGia.AllowUserToDeleteRows = False
        Me.dtgDSDocGia.AutoGenerateColumns = False
        Me.dtgDSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDSDocGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDocGiaDataGridViewTextBoxColumn, Me.HoTenDocGiaDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewCheckBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.HinhDataGridViewImageColumn})
        Me.dtgDSDocGia.ContextMenuStrip = Me.cmsXoa
        Me.dtgDSDocGia.DataSource = Me.SpLayDSDocGiaBindingSource
        Me.dtgDSDocGia.Location = New System.Drawing.Point(12, 246)
        Me.dtgDSDocGia.Name = "dtgDSDocGia"
        Me.dtgDSDocGia.ReadOnly = True
        Me.dtgDSDocGia.RowHeadersWidth = 10
        Me.dtgDSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDSDocGia.Size = New System.Drawing.Size(415, 138)
        Me.dtgDSDocGia.TabIndex = 7
        '
        'MaDocGiaDataGridViewTextBoxColumn
        '
        Me.MaDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia"
        Me.MaDocGiaDataGridViewTextBoxColumn.HeaderText = "MaDocGia"
        Me.MaDocGiaDataGridViewTextBoxColumn.Name = "MaDocGiaDataGridViewTextBoxColumn"
        Me.MaDocGiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaDocGiaDataGridViewTextBoxColumn.Visible = False
        '
        'HoTenDocGiaDataGridViewTextBoxColumn
        '
        Me.HoTenDocGiaDataGridViewTextBoxColumn.DataPropertyName = "HoTenDocGia"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.HoTenDocGiaDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.Name = "HoTenDocGiaDataGridViewTextBoxColumn"
        Me.HoTenDocGiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GioiTinhDataGridViewCheckBoxColumn
        '
        Me.GioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewCheckBoxColumn.FillWeight = 50.0!
        Me.GioiTinhDataGridViewCheckBoxColumn.HeaderText = "Nam"
        Me.GioiTinhDataGridViewCheckBoxColumn.Name = "GioiTinhDataGridViewCheckBoxColumn"
        Me.GioiTinhDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Dịa chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HinhDataGridViewImageColumn
        '
        Me.HinhDataGridViewImageColumn.DataPropertyName = "Hinh"
        Me.HinhDataGridViewImageColumn.HeaderText = "Hinh"
        Me.HinhDataGridViewImageColumn.Name = "HinhDataGridViewImageColumn"
        Me.HinhDataGridViewImageColumn.ReadOnly = True
        Me.HinhDataGridViewImageColumn.Visible = False
        '
        'SpLayDSDocGiaBindingSource
        '
        Me.SpLayDSDocGiaBindingSource.DataMember = "sp_LayDSDocGia"
        Me.SpLayDSDocGiaBindingSource.DataSource = Me.DsQuanLyThuVienBindingSource
        '
        'DsQuanLyThuVienBindingSource
        '
        Me.DsQuanLyThuVienBindingSource.DataSource = Me.DsQuanLyThuVien
        Me.DsQuanLyThuVienBindingSource.Position = 0
        '
        'DsQuanLyThuVien
        '
        Me.DsQuanLyThuVien.DataSetName = "dsQuanLyThuVien"
        Me.DsQuanLyThuVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_LayDSDocGiaTableAdapter
        '
        Me.Sp_LayDSDocGiaTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(415, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DANH SÁCH ĐỘC GIẢ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmsXoa
        '
        Me.cmsXoa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStripMenuItem})
        Me.cmsXoa.Name = "cmsXoa"
        Me.cmsXoa.Size = New System.Drawing.Size(153, 48)
        '
        'DelToolStripMenuItem
        '
        Me.DelToolStripMenuItem.Name = "DelToolStripMenuItem"
        Me.DelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DelToolStripMenuItem.Text = "Del"
        '
        'frmDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtgDSDocGia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDocGia"
        Me.Text = "frmDocGia"
        CType(Me.picHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgDSDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLayDSDocGiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsQuanLyThuVienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsQuanLyThuVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsXoa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents dtpNS As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkGioiTinh As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents picHinh As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChonhinh As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblTB As System.Windows.Forms.Label
    Friend WithEvents dtgDSDocGia As System.Windows.Forms.DataGridView
    Friend WithEvents DsQuanLyThuVienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsQuanLyThuVien As On_Thi_Thang_8_2.dsQuanLyThuVien
    Friend WithEvents SpLayDSDocGiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_LayDSDocGiaTableAdapter As On_Thi_Thang_8_2.dsQuanLyThuVienTableAdapters.sp_LayDSDocGiaTableAdapter
    Friend WithEvents MaDocGiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoTenDocGiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinhDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnBoqua As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents cmsXoa As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
