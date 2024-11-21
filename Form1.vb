Imports MySql.Data.MySqlClient
Imports Module1
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1

    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim dt As DataTable



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            sqlQuery = "Select * from employee"
            da = New MySqlDataAdapter(sqlQuery, Module1.conn)
            dt = New DataTable
            da.Fill(dt)
            datarecord.DataSource = dt
            datarecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Form3.Show() 'load form 3
        Dim report As New ReportDocument
        'load crystal report
        report.Load("C:\Users\SANDBOX-28\source\repos\employee\CrystalReport1.rpt")
        Form3.CrystalReportViewer1.ReportSource = report
        Form3.CrystalReportViewer1.Refresh()
    End Sub
End Class
