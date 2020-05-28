Imports System.Net
Imports Environment

Public Class Detalles_pedido
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim correo As String
        correo = Environment.GetEnvironmentVariable("mail")

        Dim Mensaje As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        SMTP.Credentials = New System.Net.NetworkCredential("guatemalaencasa@gmail.com", "4f43dfe1322bdadaa11d8e611b1543fb1443c96ce2b286851033fd69ac302d42")
        SMTP.Host = "smtp.gmail.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True
        Try
            Mensaje.[To].Add(correo)
            Mensaje.From = New System.Net.Mail.MailAddress("guatemalaencasa@gmail.com", "Guatemala en Casa", System.Text.Encoding.UTF8)
            Mensaje.Subject = "Pruebas de protocolo smtp"
            Mensaje.SubjectEncoding = System.Text.Encoding.UTF8
            Mensaje.Body = "<p>Variables configuradas</p>"
            Mensaje.BodyEncoding = System.Text.Encoding.UTF8
            Mensaje.Priority = System.Net.Mail.MailPriority.High
            Mensaje.IsBodyHtml = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            SMTP.Send(Mensaje)
            MessageBox.Show("Mensaje enviado correctamente", "Politecnia", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try

    End Sub
End Class