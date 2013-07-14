Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmSach

    Private Sub frmSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
        conn.Open()
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.CommandText = "sp_DSTacGia"
        da.SelectCommand.Connection = conn
        DsQuanLyThuVien.Tables("sp_DSTacGia").Clear()
        da.Fill(DsQuanLyThuVien, "sp_DSTacGia")
        conn.Close()
    End Sub

    Private Sub btnLuuSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuuSach.Click
        'MsgBox(cboTacGia.SelectedValue)
        Dim conn As New SqlConnection
        conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
        conn.Open()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_LuuSach"
        cmd.Connection = conn
        cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = txtTenSach.Text
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtSoLuong.Text
        cmd.Parameters.Add("@MaTacGia", SqlDbType.Int).Value = cboTacGia.SelectedValue
        cmd.ExecuteNonQuery()
        MsgBox("Luu thanh cong")
        txtSoLuong.Clear()
        txtTenSach.Clear()
        conn.Close()

    End Sub

   
End Class