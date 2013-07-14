<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRDocGiaMS
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
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.CrDocGiaMS = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liệt kê danh sách độc giả mượn sách"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyy"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(359, 19)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(105, 20)
        Me.dtpTuNgay.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Từ  ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đến ngày"
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyy"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(575, 19)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(105, 20)
        Me.dtpDenNgay.TabIndex = 1
        '
        'CrDocGiaMS
        '
        Me.CrDocGiaMS.ActiveViewIndex = -1
        Me.CrDocGiaMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrDocGiaMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrDocGiaMS.Location = New System.Drawing.Point(15, 63)
        Me.CrDocGiaMS.Name = "CrDocGiaMS"
        Me.CrDocGiaMS.Size = New System.Drawing.Size(886, 326)
        Me.CrDocGiaMS.TabIndex = 3
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(702, 18)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(105, 20)
        Me.btnXem.TabIndex = 4
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'frmCRDocGiaMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 401)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.CrDocGiaMS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCRDocGiaMS"
        Me.Text = "frmCRDocGiaMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrDocGiaMS As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnXem As System.Windows.Forms.Button
End Class
