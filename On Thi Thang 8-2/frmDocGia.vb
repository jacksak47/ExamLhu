Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmDocGia
    Dim maDocGia As Integer

    Private Sub btnChonhinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChonhinh.Click
        dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp| image gift(*.gif)|*.gif| jpeg(*.jpg; *.jpeg)|*.jpg;*.jpeg| All File|*.*"
        dlgOpen.Title = "Chon hinh cua doc gia"
        Dim result = dlgOpen.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            picHinh.ImageLocation = dlgOpen.FileName
            picHinh.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If btnLuu.Text = "Lưu" Then
            Dim img As Byte() = Nothing
            If picHinh.ImageLocation <> "" Then
                Dim fs As FileStream = New FileStream(picHinh.ImageLocation.ToString(), FileMode.Open)
                img = New Byte(fs.Length) {}
                fs.Read(img, 0, fs.Length)
                fs.Close()
            End If
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If picHinh.ImageLocation <> "" Then
                cmd.CommandText = "sp_ThemDocGia"
                cmd.Parameters.Add("@Hinh", SqlDbType.Image).Value = img
            Else
                cmd.CommandText = "sp_ThemDocGia_noImage"
            End If
            cmd.Parameters.Add("@HoTenDocGia", SqlDbType.NVarChar).Value = txtHoTen.Text
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtpNS.Value
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = chkGioiTinh.Checked
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text
            cmd.ExecuteNonQuery()
            lblTB.Text = "Đã thêm độc giả thành công"
            conn.Close()
            LayDSDocGia()
        Else
            Dim img As Byte() = Nothing
            If picHinh.ImageLocation <> "" Then
                Dim fs As FileStream = New FileStream(picHinh.ImageLocation.ToString(), FileMode.Open)
                img = New Byte(fs.Length) {}
                fs.Read(img, 0, fs.Length)
                fs.Close()
            End If
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            If picHinh.ImageLocation <> "" Then
                cmd.CommandText = "sp_CapNhatDocGia"
                cmd.Parameters.Add("@Hinh", SqlDbType.Image).Value = img
            Else
                cmd.CommandText = "sp_CapnhatDG_NoImage"
            End If
            cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = maDocGia
            cmd.Parameters.Add("@HoTenDocGia", SqlDbType.NVarChar).Value = txtHoTen.Text
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtpNS.Value
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = chkGioiTinh.Checked
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text
            cmd.ExecuteNonQuery()
            lblTB.Text = "Đã cập nhật độc giả thành công"
            conn.Close()
            LayDSDocGia()
        End If
        BoQua()
    End Sub
    Sub LayDSDocGia()
        Dim conn As New SqlConnection
        conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
        conn.Open()
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.CommandText = "sp_LayDSDocGia"
        da.SelectCommand.Connection = conn
        DsQuanLyThuVien.Tables("sp_LayDSDocGia").Clear()
        da.Fill(DsQuanLyThuVien, "sp_LayDSDocGia")
        conn.Close()
    End Sub

    Private Sub frmDocGia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LayDSDocGia()
    End Sub

    

    Private Sub dtgDSDocGia_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDSDocGia.CellDoubleClick
        maDocGia = dtgDSDocGia.Item(0, e.RowIndex).Value
        txtHoTen.Text = dtgDSDocGia.Item(1, e.RowIndex).Value
        dtpNS.Value = dtgDSDocGia.Item(2, e.RowIndex).Value
        chkGioiTinh.Checked = dtgDSDocGia.Item(3, e.RowIndex).Value
        txtDiaChi.Text = dtgDSDocGia.Item(4, e.RowIndex).Value
        If IsDBNull(dtgDSDocGia.Item(5, e.RowIndex).Value) Then
            picHinh.Image = Nothing
        Else
            Dim arrImg() As Byte = CType(dtgDSDocGia.Item(5, e.RowIndex).Value, Byte())
            Dim ms As New IO.MemoryStream(arrImg, 0, arrImg.Length)
            Dim img As Image = Image.FromStream(ms)
            picHinh.Image = img
            picHinh.SizeMode = PictureBoxSizeMode.Zoom
        End If
        btnLuu.Text = "Cập nhật"
    End Sub

    Sub BoQua()
        btnLuu.Text = "Lưu"
        maDocGia = 0
        txtHoTen.Clear()
        txtDiaChi.Clear()
        picHinh.Image = Nothing
        picHinh.ImageLocation = ""
        chkGioiTinh.Checked = False
    End Sub

    Private Sub BtnBoqua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBoqua.Click
        btnLuu.Text = "Lưu"
        maDocGia = 0
        txtHoTen.Clear()
        txtDiaChi.Clear()
        picHinh.Image = Nothing
        chkGioiTinh.Checked = False
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub dtgDSDocGia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDSDocGia.CellClick

    End Sub
End Class