Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim fullname As String
    Dim username As String
    Dim password As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        fullname = txtfullname.Text
        username = txtusername.Text
        password = txtpassword.Text
        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO employee(" _
                       & "Fullname, Uname, pwd) VALUES" _
                       & "('" & fullname & "','" & username & "','" & password & "')"
                'execute the insert query
                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Record inserted Successfully!")
                    txtfullname.Clear()
                    txtusername.Clear()
                    txtpassword.Clear()
                Else
                    MsgBox("insertion Failed!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide() 'hide form2
    End Sub
End Class