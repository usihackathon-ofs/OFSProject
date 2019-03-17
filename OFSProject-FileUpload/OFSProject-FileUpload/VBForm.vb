Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Transfer
Imports Amazon.S3.Model
Imports Amazon.S3.Util
Imports System.IO



Public Class VBForm
    Private Sub VBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccessKey = GetSetting("AWS", "Keys", "Private Key")
        SecretKey = GetSetting("AWS", "Keys", "Common Key")
        Settings.Bucketname = GetSetting("AWS", "Bucketname", "Bucketname")
    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnSelect.Click, btnSubmit.Click
        Dim btn As Button

        Try
            btn = DirectCast(sender, Button)
            Select Case btn.Name
                Case btnSelect.Name
                    OpenFileDialog.ShowDialog()
                    Settings.fName = OpenFileDialog.FileName
                    btnSubmit.Enabled = True

                Case btnSubmit.Name
                    Dim FileTrans As String
                    client = New AmazonS3Client(SecretKey, AccessKey, Amazon.RegionEndpoint.USEast1)
                    Dim Transfer As New Amazon.S3.Transfer.TransferUtility(client)
                    Dim Uploads As New Amazon.S3.Transfer.TransferUtilityUploadRequest
                    FileTrans = AddFileToFolder(Settings.fName, Settings.Bucketname, "")
                    MessageBox.Show(FileTrans)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Function AddFileToFolder(FileName As String, bucketName As String, folderName As String) As String
        Dim returnval As String = "File Successfully uploaded"
        Try
            Try
                Dim path As String = FileName
                Dim file As FileInfo = New FileInfo(path)
                Dim key As String = String.Format("{0}/{1}", folderName, file.Name)
                Dim por As PutObjectRequest = New PutObjectRequest()
                por.BucketName = bucketName
                por.StorageClass = S3StorageClass.Standard
                por.ServerSideEncryptionMethod = ServerSideEncryptionMethod.None
                por.CannedACL = S3CannedACL.PublicRead
                por.Key = file.Name
                por.InputStream = file.OpenRead()
                client.PutObject(por)
            Catch ex As Exception
                returnval = ex.Message
            End Try
        Catch ex As AmazonS3Exception
            MessageBox.Show(ex.Message)
            returnval = ex.Message
        End Try
        Return returnval
    End Function



    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.Show()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
