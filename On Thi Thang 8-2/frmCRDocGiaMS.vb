Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmCRDocGiaMS

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = ConfigurationManager.AppSettings("Constr")
            conn.Open()
            Dim da As New SqlDataAdapter
            Dim dsDocGia As New DataSet
            Dim crDocument As New crDocGia

            da.SelectCommand = New SqlCommand
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.CommandText = "sp_rptMuonSach"
            da.SelectCommand.Connection = conn
            da.SelectCommand.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = dtpTuNgay.Value
            da.SelectCommand.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = dtpDenNgay.Value
            da.Fill(dsDocGia, "sp_rptMuonSach")
            conn.Close()
            crDocument.SetDataSource(dsDocGia.Tables("sp_rptMuonSach"))
            crDocument.SetParameterValue("@TuNgay", Format(dtpTuNgay.Value, "MM/dd/yyyy"))
            crDocument.SetParameterValue("@DenNgay", Format(dtpDenNgay.Value, "MM/dd/yyyy"))
            CrDocGiaMS.ReportSource = crDocument
        Catch ex As Exception

        End Try
    End Sub
End Class