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

Public Class Voluntarios
    Public NumPedido As Integer
    Private Sub Voluntarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_Datos11DataSet.Pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.Base_Datos11DataSet.Pedido)
        pedidos.DataSource = Me.Base_Datos11DataSet.Pedido

    End Sub

    Private Sub PedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_Datos11DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not pedidos.CurrentCell.ColumnIndex = 0 Then
                MsgBox("Selecione el numero del pedido")
                Return
            End If
            NumPedido = pedidos.CurrentCell.Value
            Me.Hide()
            Detalles_pedido.Show()
        Catch ex As Exception
            MsgBox("Seleccione unicamente el numero del pedido")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
