'  Guatemala en Casa
'  Copyright (C) 2020 Pablo Sanchez, Marco Aguilon, Masiel Dieguez,
'  Sebastian Letona, Any Gonzales, Alejandra Paredes.
'
'  This program is free software: you can redistribute it and/or modify
'  it under the terms of the GNU General Public License as published by
'  the Free Software Foundation, either version 3 of the License, or
'  (at your option) any later version.
'
'  This program is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'
'  You should have received a copy of the GNU General Public License
'  along with this program.  If not, see <https://www.gnu.org/licenses/>.

Imports System.Net
Imports Environment

Public Class Detalles_pedido
    Dim Access As New DBControl
    Dim Pedido As DataSet

    Private Function FormatearCorreo()
        Dim mensaje, br As String
        br = "<br>"
        mensaje = "Muy buen dia, es un gusto saludarle. Somos el equipo de Guatemala en casa" & br
        mensaje += "El motivo de este correo es brindarle los detalles del pedido que tomo." & br
        mensaje += "Este pedido es para: <em>" & NombreTextBox.Text & "</em> a quien puede encontrar en la siguiente direccion: <em>" & ZonaTextBox.Text & "</em>" & br & br
        mensaje += "<strong>Formato:</strong> Producto, cantidad" & br
        For Each fila As DataRow In Access.DBDT.Rows
            mensaje += fila.Item(0).ToString & ", " & fila.Item(1).ToString & br
        Next
        mensaje += "Le agradecemos el apoyo que nos brinda en estos tiempos de crisis" & br & br
        mensaje += "<strong>Att. El equipo de Guatemala en casa</strong>"
        Return mensaje
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim correo As String
        correo = InputBox("Ingrese el correo al que desea que sea enviado el pedido, en dado caso que sea el mismo con el que se registro deje este campo en blanco")
        If correo = "" Then
            correo = Inicio_de_sesion.correo
        End If


        Dim Mensaje As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        SMTP.Credentials = New System.Net.NetworkCredential("guatemalaencasa@gmail.com", "4f43dfe1322bdadaa11d8e611b1543fb1443c96ce2b286851033fd69ac302d42")
        SMTP.Host = "smtp.gmail.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True
        Try
            Mensaje.[To].Add(correo)
            Mensaje.From = New System.Net.Mail.MailAddress("guatemalaencasa@gmail.com", "Guatemala en Casa", System.Text.Encoding.UTF8)
            Mensaje.Subject = "Detalles del pedido"
            Mensaje.SubjectEncoding = System.Text.Encoding.UTF8
            Mensaje.Body = FormatearCorreo()
            Mensaje.BodyEncoding = System.Text.Encoding.UTF8
            Mensaje.Priority = System.Net.Mail.MailPriority.High
            Mensaje.IsBodyHtml = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        Try
            SMTP.Send(Mensaje)
            MessageBox.Show("Mensaje enviado correctamente", "Guatemala en casa", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
            Return
        End Try

        Me.PedidoTableAdapter.BorrarPedido(Val(Numero_de_PedidoTextBox.Text))
        Access.ExecQuery("DROP TABLE " & Me.Base_Datos11DataSet.Pedido.Rows(0).Item(1).ToString)
    End Sub

    Private Sub Detalles_pedido_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Me.PedidoTableAdapter.FillByPedido(Me.Base_Datos11DataSet.Pedido, Voluntarios.NumPedido)
            Me.UsuariosTableAdapter.FillByDPI(Me.Base_Datos11DataSet.Usuarios, Me.Base_Datos11DataSet.Pedido.Rows(0).Item(4).ToString)
            Access.ExecQuery("Select Producto, Cantidad FROM " & Me.Base_Datos11DataSet.Pedido.Rows(0).Item(1).ToString)
            If Access.Exception = "" Then
                detalles.DataSource = Access.DBDT
            Else
                MsgBox(Access.Exception)
            End If
        Catch ex As Exception
            MsgBox("Seleccione unicamente el numero del pedido")
            Me.Hide()
            Voluntarios.Show()
        End Try
    End Sub

    Private Sub PedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_Datos11DataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        '  Try
        '   Me.PedidoTableAdapter.Fill(Me.Base_Datos11DataSet.Pedido, CType(Numero_de_PedidoToolStripTextBox.Text, Integer))
        '   Catch ex As System.Exception
        '   System.Windows.Forms.MessageBox.Show(ex.Message)
        '    End Try

    End Sub

    Private Sub Detalles_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Voluntarios.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Detalles_pedido_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

End Class
