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

Imports System.Security.Cryptography
Imports System.Text

Public Class Registros
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_Datos11DataSet)

    End Sub

    Public Function Hash(contraseña As String)
        Dim UE As New UnicodeEncoding
        Dim bHash As Byte()
        'Almacena la cadena ingresada en una matriz de bytes
        Dim bCadena() As Byte = UE.GetBytes(contraseña)
        Dim s1Service As New SHA1CryptoServiceProvider
        'Crea el hash
        bHash = s1Service.ComputeHash(bCadena)
        'Retorna como una cadena codificada en base64
        Dim hash_texto As String
        hash_texto = Convert.ToBase64String(bHash)
        Return hash_texto
    End Function
    Private Function EntradasValidas()
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                If control.Text = "" Then
                    Return False
                End If
            End If
        Next
        If Not rbtnBeneficiario.Checked And Not rbtnVoluntario.Checked Then
            Return False
        End If
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not EntradasValidas() Then
            MsgBox("No pueden haber campos en blanco")
            Return
        End If
        If txtContra.Text = txtContraConf.Text Then
            Dim contraseña As String
            Dim tipo As String
            contraseña = txtContra.Text
            contraseña = Hash(contraseña)
            If rbtnBeneficiario.Checked Then
                tipo = "Beneficiario"
            Else
                tipo = "Voluntario"
            End If
            Try
                Me.UsuariosTableAdapter.Registrar(txtNombre.Text, txtContacto.Text, txtZona.Text, txtDpi.Text, txtCorreo.Text, contraseña, tipo)
                Me.Hide()
                ' En este momento deveria ir a las opciones de voluntario o de beneficiado
                Form1.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Las contraseñas no coinciden, ingreselas nuevamente.")
        End If
    End Sub
End Class
