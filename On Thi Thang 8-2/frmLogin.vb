Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conn As New SqlConnection
        conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
        conn.Open()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Login"
        cmd.Connection = conn
        cmd.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = txtUser.Text.Trim
        cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txtPass.Text.Trim
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If kiemtradangnhap() Then
            If dr.HasRows Then
                lblTB.Text = "Đăng nhập thành công"
                frmMain.Show()
                dr.Read()
                frmMain.MaNV = dr.GetValue(0)
                dr.Close()
            Else
                lblTB.Text = "Tài khoản hoặc mật khẩu không đúng"
            End If
        End If
        conn.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Function kiemtradangnhap() As Boolean
        If txtUser.Text.Trim = "" Then
            lblTB.Text = "Nhập User!"
            Return False
        ElseIf txtPass.Text.Trim = "" Then
            lblTB.Text = "Nhập Password!"
            Return False
        End If
        Return True
    End Function
End Class
