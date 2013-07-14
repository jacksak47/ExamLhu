Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmMuonsach

    Private Sub txtMaDocGia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaDocGia.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.CommandText = "sp_LayThongTinDocGiaTheoMa"
            cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = txtMaDocGia.Text
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txtHoTen.Text = dr.GetValue(0)
                If dr.GetValue(1) = True Then
                    txtGioiTinh.Text = "Nam"
                Else
                    txtGioiTinh.Text = "Nữ"
                End If
                txtNgaySinh.Text = dr.GetValue(2)
                txtDiaChi.Text = dr.GetValue(3)
                dr.Close()
                lblTB.Text = ""
            Else
                xoathongtindocgia()
                lblTB.Text = "Không tồn tại mã độc giả này"
                txtMaDocGia.SelectAll()
                txtMaDocGia.Focus()
            End If
            conn.Close()
        End If
    End Sub
    Sub xoathongtindocgia()
        Dim ctr As Control
        For Each ctr In grbDocGia.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            End If
        Next

    End Sub
    
    
    Private Sub txtMasach_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMasach.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.CommandText = "sp_LayThongTinSach"
            cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = txtMasach.Text
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txttensach.Text = dr.GetValue(0)
                txtTacGia.Text = dr.GetValue(1)
                dr.Close()
                lblTBSach.Text = ""
            Else
                lblTBSach.Text = "Sách này không tồn tại"
                txttensach.Text = ""
                txtTacGia.Text = ""
                txtMasach.SelectAll()
                txtMasach.Focus()
            End If
        End If
    End Sub
    Function kiemtrasach(ByVal MaSach As String) As Boolean
        For i As Integer = 0 To dtgDSMuonSach.Rows.Count - 1
            If dtgDSMuonSach.Item(0, i).Value = MaSach Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        If kiemtrasach(txtMasach.Text) Then
            dtgDSMuonSach.Rows.Add(txtMasach.Text, txttensach.Text, txtTacGia.Text, dtpNgaymuon.Value, dtpNgayHenTra.Value, True)
            txttensach.Clear()
            txtTacGia.Clear()
            dtpNgaymuon.Value = Now
            dtpNgayHenTra.Value = Now
            txtMasach.Focus()
        Else
            lblTBSach.Text = "Đã mượn cuốn sách này. Hãy chọn cuốn khác."
            txtMasach.SelectAll()
            txtMasach.Focus()
        End If
    End Sub

    Private Sub btnXoaDanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaDanhSach.Click
        dtgDSMuonSach.Rows.Clear()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If dtgDSMuonSach.Rows.Count > 0 Then
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            For i As Integer = 0 To dtgDSMuonSach.Rows.Count - 1
                If dtgDSMuonSach.Item(5, i).Value = True Then
                    Dim cmd As New SqlCommand
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_LuuMuonSach"
                    cmd.Connection = conn
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = txtMaDocGia.Text
                    cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = dtgDSMuonSach.Item(0, i).Value
                    cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = dtgDSMuonSach.Item(3, i).Value
                    cmd.Parameters.Add("@NgayHenTra", SqlDbType.DateTime).Value = dtgDSMuonSach.Item(4, i).Value
                    cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = frmMain.MaNV 'Ma Nhan vien. cd:Khi login thanh cong luu ma nhan vien vao mot bien MaNV
                    cmd.ExecuteNonQuery()
                End If
            Next
            conn.Close()
            MsgBox("Đã lưu thành công")
            xoatrang()'Xoa cac thong tin: doc gia, sach, danh sach muon sach
        Else
            MsgBox("Chưa chọn sách.")
        End If
    End Sub
    Sub xoatrang()
        Dim ctr As Control
        For Each ctr In Me.grbDocGia.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            End If
        Next
        For Each ctr In Me.gbSachMuon.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            End If
        Next
        dtgDSMuonSach.Rows.Clear()
    End Sub

   
End Class