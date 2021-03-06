  
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

Public Class Inicio_de_sesion
    Public correo, nombre, DPI As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Contraseña As String

        DPI = txtDPI.Text
        Contraseña = txtContraseña.Text

        Try
            If Registros.Hash(Contraseña) = Me.UsuariosTableAdapter.Password(DPI) Then
            Else
                MsgBox("El DPI o la contraseña son incorrectos")
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim tipo As String
        tipo = Me.UsuariosTableAdapter.GetTipo(DPI)
        correo = Me.UsuariosTableAdapter.GetEmail(DPI)

        nombre = Me.UsuariosTableAdapter.GET_NOMBRE(DPI)


        If tipo = "Beneficiario" Then
            Me.Hide()
            Presupuestos.Show()
        Else
            Me.Hide()
            Voluntarios.Show()
        End If

        txtContraseña.Text = ""
        txtDPI.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_Datos11DataSet)

    End Sub

    Private Sub Inicio_de_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_Datos11DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Base_Datos11DataSet.Usuarios)

    End Sub
End Class
