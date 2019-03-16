Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Transfer
Imports Amazon.S3.Model

Const AWS_ACCESS_KEY As String = "AKIAIVYIWYRCTAMY2LRA"
Const AWS_SECRET_KEY As String = "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"

Public Class VBForm
    Private Sub VBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim btn As Button
        Try
            btn = DirectCast(sender, Button)
            Select Case btn.Name

                Case Button1.Name

                    Dim anothergreatvariable As String


                    OpenFileDialog1.ShowDialog()

                    anothergreatvariable = OpenFileDialog1.FileName
                    Using wc As New System.Net.WebClient()
                        wc.UploadFile("https://78cirdegtd.execute-api.us-east-1.amazonaws.com/default/textileEndpoint" & anothergreatvariable, anothergreatvariable)

                    End Using


                Case Button2.Name


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try



    End Sub
End Class
