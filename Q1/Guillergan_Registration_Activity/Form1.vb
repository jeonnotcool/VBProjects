Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Form1
    Dim EmailField As TextBox
    Dim NameField As TextBox
    Dim Pass As TextBox
    Dim Con As TextBox
    Dim TC As CheckBox
    Dim News As CheckBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailField = Email1
        NameField = NameF2
        Pass = Password3
        Con = ConfirmPass4
        TC = Agree
        News = Newsletters

        Password3.PasswordChar = "*"
        ConfirmPass4.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("eme lang")
    End Sub


    Public Function IsEmailAddress(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function



    Private Sub Sign_Click(sender As Object, e As EventArgs) Handles Sign.Click
        If String.IsNullOrEmpty(EmailField.Text) OrElse String.IsNullOrEmpty(NameField.Text) OrElse String.IsNullOrEmpty(Pass.Text) OrElse String.IsNullOrEmpty(Con.Text) Then
            MessageBox.Show("Please fill in all required fields.")
        Else
            If TC.Checked Then
                If Not IsEmailAddress(EmailField.Text) Then
                    MessageBox.Show("Please enter a valid email.")
                    EmailField.Focus()
                End If

                If Pass.Text <> ConfirmPass4.Text Then
                    MessageBox.Show("Passwords do not match.")
                    Pass.Focus()
                Else
                    ' Show all info
                    ' Send notification to Windows Notification Center
                    Dim notification As New NotifyIcon()
                    notification.Icon = My.Resources.Group_1
                    notification.Visible = True
                    notification.BalloonTipTitle = "UniFind"
                    notification.BalloonTipText = "Registration Successful!"
                    notification.ShowBalloonTip(3000)

                    Dim info As String = "Name: " & NameField.Text & vbCrLf &
                                        "Email: " & EmailField.Text & vbCrLf &
                                        "Password: " & Pass.Text & vbCrLf &
                                        "Terms and Conditions: " & If(TC.Checked, "true", "false") & vbCrLf &
                                        "Newsletter: " & If(News.Checked, "true", "false")

                    MessageBox.Show(info)
                End If


            Else
                MessageBox.Show("Please agree to the terms and conditions.")
            End If
        End If
    End Sub


End Class
