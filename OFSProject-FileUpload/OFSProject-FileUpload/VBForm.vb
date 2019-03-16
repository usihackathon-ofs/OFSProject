Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Transfer
Imports Amazon.S3.Model



Public Class VBForm
    Private Sub VBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim btn As Button


        Try
            btn = DirectCast(sender, Button)
            Select Case btn.Name

                Case Button1.Name
                    Settings.Bucketname = "usitextilesbucket"
                    lblSend.Text = ""
                    Static client As IAmazonS3
                    client = New AmazonS3Client(Amazon.RegionEndpoint.USEast1)
                    Dim Transfer As New Amazon.S3.Transfer.TransferUtility(client)
                    Dim Uploads As New Amazon.S3.Transfer.TransferUtilityUploadRequest

                    Dim FilePath As String
                    OpenFile.ShowDialog()

                    Settings.KeyName = OpenFile.FileName


                    FilePath = System.IO.Path.GetFullPath(OpenFile.FileName)

                    Uploads.BucketName = Settings.Bucketname & "\"
                    Uploads.FilePath = FilePath

                    '                    Transfer.UploadAsync(Uploads)
                    Transfer.UploadAsync(Uploads)
                    lblSend.Text = "Successfully Sent"


                Case Button2.Name

            End Select

        Catch ex As Exception
            lblSend.Text = "Failure"
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub
End Class
