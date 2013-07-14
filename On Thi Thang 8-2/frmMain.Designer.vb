<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuChucNang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDocGia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMuonsach = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChucNang})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuChucNang
        '
        Me.mnuChucNang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDocGia, Me.mniMuonsach, Me.SáchToolStripMenuItem, Me.BáoCáoToolStripMenuItem})
        Me.mnuChucNang.Name = "mnuChucNang"
        Me.mnuChucNang.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuChucNang.Size = New System.Drawing.Size(76, 20)
        Me.mnuChucNang.Text = "&Chức năng"
        '
        'mniDocGia
        '
        Me.mniDocGia.Name = "mniDocGia"
        Me.mniDocGia.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mniDocGia.Size = New System.Drawing.Size(177, 22)
        Me.mniDocGia.Text = "Độc giả"
        '
        'mniMuonsach
        '
        Me.mniMuonsach.Name = "mniMuonsach"
        Me.mniMuonsach.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mniMuonsach.Size = New System.Drawing.Size(177, 22)
        Me.mniMuonsach.Text = "Mượn sách"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SáchToolStripMenuItem.Text = "Sách "
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BáoCáoToolStripMenuItem.Text = "Báo cáo"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 347)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "FrmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuChucNang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDocGia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniMuonsach As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SáchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
