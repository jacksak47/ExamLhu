<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSach
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
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTacGia = New System.Windows.Forms.ComboBox()
        Me.SpDSTacGiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsQuanLyThuVien = New On_Thi_Thang_8_2.dsQuanLyThuVien()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sp_DSTacGiaTableAdapter = New On_Thi_Thang_8_2.dsQuanLyThuVienTableAdapters.sp_DSTacGiaTableAdapter()
        Me.btnLuuSach = New System.Windows.Forms.Button()
        CType(Me.SpDSTacGiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsQuanLyThuVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(86, 43)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(189, 20)
        Me.txtTenSach.TabIndex = 0
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(364, 43)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(105, 20)
        Me.txtSoLuong.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số lượng"
        '
        'cboTacGia
        '
        Me.cboTacGia.DataSource = Me.SpDSTacGiaBindingSource
        Me.cboTacGia.DisplayMember = "HoTenTacGia"
        Me.cboTacGia.FormattingEnabled = True
        Me.cboTacGia.Location = New System.Drawing.Point(86, 86)
        Me.cboTacGia.Name = "cboTacGia"
        Me.cboTacGia.Size = New System.Drawing.Size(189, 21)
        Me.cboTacGia.TabIndex = 2
        Me.cboTacGia.ValueMember = "MaTacGia"
        '
        'SpDSTacGiaBindingSource
        '
        Me.SpDSTacGiaBindingSource.DataMember = "sp_DSTacGia"
        Me.SpDSTacGiaBindingSource.DataSource = Me.DsQuanLyThuVien
        '
        'DsQuanLyThuVien
        '
        Me.DsQuanLyThuVien.DataSetName = "dsQuanLyThuVien"
        Me.DsQuanLyThuVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tác giả"
        '
        'Sp_DSTacGiaTableAdapter
        '
        Me.Sp_DSTacGiaTableAdapter.ClearBeforeFill = True
        '
        'btnLuuSach
        '
        Me.btnLuuSach.Location = New System.Drawing.Point(364, 84)
        Me.btnLuuSach.Name = "btnLuuSach"
        Me.btnLuuSach.Size = New System.Drawing.Size(75, 23)
        Me.btnLuuSach.TabIndex = 3
        Me.btnLuuSach.Text = "Lưu"
        Me.btnLuuSach.UseVisualStyleBackColor = True
        '
        'frmSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 379)
        Me.Controls.Add(Me.btnLuuSach)
        Me.Controls.Add(Me.cboTacGia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenSach)
        Me.Name = "frmSach"
        Me.Text = "frmSach"
        CType(Me.SpDSTacGiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsQuanLyThuVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTacGia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DsQuanLyThuVien As On_Thi_Thang_8_2.dsQuanLyThuVien
    Friend WithEvents SpDSTacGiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_DSTacGiaTableAdapter As On_Thi_Thang_8_2.dsQuanLyThuVienTableAdapters.sp_DSTacGiaTableAdapter
    Friend WithEvents btnLuuSach As System.Windows.Forms.Button
End Class
