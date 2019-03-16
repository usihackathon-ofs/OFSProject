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
        Me.privateKey = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'commonKey
        '
        Me.commonKey.AutoSize = True
        Me.commonKey.Location = New System.Drawing.Point(35, 41)
        Me.commonKey.Name = "commonKey"
        Me.commonKey.Size = New System.Drawing.Size(65, 13)
        Me.commonKey.TabIndex = 0
        Me.commonKey.Text = "commonKey"
        '
        'privateKey
        '
        Me.privateKey.AutoSize = True
        Me.privateKey.Location = New System.Drawing.Point(35, 104)
        Me.privateKey.Name = "privateKey"
        Me.privateKey.Size = New System.Drawing.Size(57, 13)
        Me.privateKey.TabIndex = 1
        Me.privateKey.Text = "privateKey"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(38, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 360)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.privateKey)
        Me.Controls.Add(Me.commonKey)
        Me.Name = "Preferences"
        Me.Text = "Preferences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents commonKey As Label
    Friend WithEvents privateKey As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
