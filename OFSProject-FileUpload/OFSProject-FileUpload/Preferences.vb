Public Class Preferences
    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        commonKey.Text = "Current Common Key: " + GetSetting("AWS", "Keys", "Common Key")
        secretKey.Text = "Current S.Key: " + GetSetting("AWS", "Keys", "Private Key")
        lblBucketNameDesc.Text = "BucketName: " & GetSetting("AWS", "BucketName", "BucketName")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If commonKeyTxt.Text = "" Then Exit Sub
        If secretKeyTxt.Text = "" Then Exit Sub
        If txtBucketName.Text = "" Then Exit Sub

        SaveSetting("AWS", "Keys", "Common Key", commonKeyTxt.Text)
        SaveSetting("AWS", "Keys", "Secret Key", secretKeyTxt.Text)
        SaveSetting("AWS", "BucketName", "BucketName", txtBucketName.Text)

    End Sub
End Class