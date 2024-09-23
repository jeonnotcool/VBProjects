<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Act1
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
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.PressMeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Font = New System.Drawing.Font("SF Pro Text", 10.25!, System.Drawing.FontStyle.Bold)
        Me.DisplayTextBox.Location = New System.Drawing.Point(152, 145)
        Me.DisplayTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayTextBox.Multiline = True
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.Size = New System.Drawing.Size(401, 152)
        Me.DisplayTextBox.TabIndex = 0
        '
        'PressMeBtn
        '
        Me.PressMeBtn.Font = New System.Drawing.Font("SF Pro Text", 10.25!, System.Drawing.FontStyle.Bold)
        Me.PressMeBtn.Location = New System.Drawing.Point(260, 318)
        Me.PressMeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.PressMeBtn.Name = "PressMeBtn"
        Me.PressMeBtn.Size = New System.Drawing.Size(196, 55)
        Me.PressMeBtn.TabIndex = 1
        Me.PressMeBtn.Text = "Press Me"
        Me.PressMeBtn.UseVisualStyleBackColor = True
        '
        'Act1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 471)
        Me.Controls.Add(Me.PressMeBtn)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Act1"
        Me.Text = "My First Program Activity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayTextBox As TextBox
    Friend WithEvents PressMeBtn As Button
End Class
