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
                    Static client As IAmazonS3

                    OpenFile.ShowDialog()

                    Settings.fName = OpenFile.FileName

                    client = New AmazonS3Client(Amazon.RegionEndpoint.USEast1)

                    Dim bucket = New PutBucketRequest()

                    bucket.BucketName = Settings.Bucketname

                    client.PutBucket(bucket)

                Case Button2.Name


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try



    End Sub
End Class
