Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Transfer
Imports Amazon.S3.Model
Imports Amazon.S3.Util



Public Class VBForm
    Private Sub VBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settings.Bucketname = "usitextilesbucket"
    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim btn As Button

        client = New AmazonS3Client(Amazon.RegionEndpoint.USEast1)

        Try
            btn = DirectCast(sender, Button)
            Select Case btn.Name

                Case Button1.Name
                    Settings.Bucketname = "usitextilesbucket"
                    Dim Transfer As New Amazon.S3.Transfer.TransferUtility(client)
                    Dim Uploads As New Amazon.S3.Transfer.TransferUtilityUploadRequest

                    Dim FilePath As String
                    OpenFileDialog.ShowDialog()

                    Settings.KeyName = OpenFileDialog.FileName


                    FilePath = System.IO.Path.GetFullPath(OpenFileDialog.FileName)

                    Uploads.BucketName = Settings.Bucketname & "/"
                    Uploads.FilePath = FilePath

                    '                    Transfer.UploadAsync(Uploads)
                    Transfer.UploadAsync(Uploads)


                Case Button2.Name

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Public Function CreateABucket(bucketName As String) As String
        Dim returnval As String = ""
        Try
            Try
                Dim putRequest1 As PutBucketRequest = New PutBucketRequest() With {.BucketName = bucketName, .UseClientRegion = True}
                Dim response1 As PutBucketResponse = client.PutBucket(putRequest1)
            Catch amazonS3Exception As AmazonS3Exception
                If amazonS3Exception.ErrorCode = "BucketAlreadyOwnedByYou" Then
                    returnval = "Bucket already exists"
                Else
                    If (Not IsNothing(amazonS3Exception.ErrorCode) And amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")) Or amazonS3Exception.ErrorCode.Equals("InvalidSecurity") Then
                        returnval = "Check the provided AWS Credentials."
                    Else
                        returnval = String.Format("Error occurred. Message:'{0}' when writing an object", amazonS3Exception.Message)
                    End If
                End If
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            returnval = ""
        End Try
        Return returnval
    End Function

    Public Function AddFileToFolder(FileName As String, bucketName As String, folderName As String) As String
        Dim returnval As String = ""
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
                por.Key = key
                por.InputStream = file.OpenRead()
                client.PutObject(por)
            Catch ex As Exception
                returnval = ex.Message
            End Try
        Catch ex As AmazonS3Exception
            returnval = ex.Message
        End Try
        Return returnval
    End Function

    Private Sub OpenFile_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

    End Sub
End Class
