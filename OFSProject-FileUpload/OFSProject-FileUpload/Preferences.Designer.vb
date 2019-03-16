<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.commonKey = New System.Windows.Forms.Label()
        Me.secretKey = New System.Windows.Forms.Label()
        Me.commonKeyTxt = New System.Windows.Forms.TextBox()
        Me.secretKeyTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBucketName = New System.Windows.Forms.TextBox()
        Me.lblBucketNameDesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'commonKey
        '
        Me.commonKey.AutoSize = True
        Me.commonKey.Location = New System.Drawing.Point(89, 7)
        Me.commonKey.Name = "commonKey"
        Me.commonKey.Size = New System.Drawing.Size(0, 13)
        Me.commonKey.TabIndex = 0
        '
        'secretKey
        '
        Me.secretKey.AutoSize = True
        Me.secretKey.Location = New System.Drawing.Point(12, 82)
        Me.secretKey.Name = "secretKey"
        Me.secretKey.Size = New System.Drawing.Size(54, 13)
        Me.secretKey.TabIndex = 1
        Me.secretKey.Text = "secretKey"
        '
        'commonKeyTxt
        '
        Me.commonKeyTxt.Location = New System.Drawing.Point(57, 40)
        Me.commonKeyTxt.Name = "commonKeyTxt"
        Me.commonKeyTxt.Size = New System.Drawing.Size(272, 20)
        Me.commonKeyTxt.TabIndex = 2
        '
        'secretKeyTxt
        '
        Me.secretKeyTxt.Location = New System.Drawing.Point(57, 110)
        Me.secretKeyTxt.Name = "secretKeyTxt"
        Me.secretKeyTxt.Size = New System.Drawing.Size(272, 20)
        Me.secretKeyTxt.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBucketName
        '
        Me.txtBucketName.Location = New System.Drawing.Point(57, 172)
        Me.txtBucketName.Name = "txtBucketName"
        Me.txtBucketName.Size = New System.Drawing.Size(272, 20)
        Me.txtBucketName.TabIndex = 6
        '
        'lblBucketNameDesc
        '
        Me.lblBucketNameDesc.AutoSize = True
        Me.lblBucketNameDesc.Location = New System.Drawing.Point(12, 144)
        Me.lblBucketNameDesc.Name = "lblBucketNameDesc"
        Me.lblBucketNameDesc.Size = New System.Drawing.Size(75, 13)
        Me.lblBucketNameDesc.TabIndex = 5
        Me.lblBucketNameDesc.Text = "Bucket Name:"
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 267)
        Me.Controls.Add(Me.txtBucketName)
        Me.Controls.Add(Me.lblBucketNameDesc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.secretKeyTxt)
        Me.Controls.Add(Me.commonKeyTxt)
        Me.Controls.Add(Me.secretKey)
        Me.Controls.Add(Me.commonKey)
        Me.Name = "Preferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents commonKey As Label
    Friend WithEvents secretKey As Label
    Friend WithEvents commonKeyTxt As TextBox
    Friend WithEvents secretKeyTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBucketName As TextBox
    Friend WithEvents lblBucketNameDesc As Label
End Class
