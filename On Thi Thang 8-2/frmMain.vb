Public Class frmMain
    Public MaNV As Integer
    Private Sub mniDocGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniDocGia.Click
        'frmDocGia.MdiParent = Me
        'frmDocGia.Show() 
        showsubform(Me, frmDocGia)
    End Sub
    Function showsubform(ByVal MainForm As Form, ByVal subform As Form) As String
        Dim frm As Form
        For Each frm In MainForm.MdiChildren
            If frm.Text.ToUpper = subform.Text.ToUpper Then
                frm.Activate()
                Return False
            Else
                frm.Close()
            End If
        Next
        subform.MdiParent = MainForm
        subform.StartPosition = FormStartPosition.CenterParent
        subform.Show()
        Return True
    End Function

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn muốn thoát chương trình?" & vbCrLf & "Nhấn 'Yes' để thoát. Nhấn 'No' để bỏ qua", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Đóng chương trình") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mniMuonsach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniMuonsach.Click
        showsubform(Me, frmMuonsach)
    End Sub

    Private Sub SáchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SáchToolStripMenuItem.Click
        showsubform(Me, frmSach)
    End Sub

    Private Sub BáoCáoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BáoCáoToolStripMenuItem.Click
        showsubform(Me, frmCRDocGiaMS)
    End Sub
End Class
