Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Transfer
Imports Amazon.S3.Model

Module Vars
    Public Structure _Settings
        Dim Bucketname As String
        Dim fName As String
        Dim KeyName As String
    End Structure

    Public Settings As _Settings
    Public client As IAmazonS3
    Public AccessKey As String
    Public SecretKey As String

End Module