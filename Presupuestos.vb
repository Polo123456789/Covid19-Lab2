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

Public Class Presupuestos
    Dim xsubtotal, xtotal As Double
    Dim ultimoenlista, elementos, numeropedido As Integer
    Dim access As New DBControl 'conexion a la base de datos

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProductosLista.Click

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPrecio.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Btnbuscar_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub Presupuestos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_Datos11DataSet.Pedido' Puede moverla o quitarla según sea necesario.
        Me.PedidoTableAdapter.Fill(Me.Base_Datos11DataSet.Pedido)
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet.Lugares' Puede moverla o quitarla según sea necesario.
        Me.LugaresTableAdapter.Fill(Me.PresupuestoDataSet.Lugares)
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PresupuestoDataSet.Productos)



    End Sub

    Private Sub Btnagregar_Click(sender As System.Object, e As System.EventArgs) Handles Btnagregar.Click
        If txtCantidad.Text = "" Then
            MsgBox("Tiene que ingresar una cantidad del producto")
            Return
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese una cantidad numerica")
            Return
        End If

        Try
            lstNombre.Items.Add(registroproducto.Text)
            lstPrecio.Items.Add(TextBox1PrecioU.Text)
            lstCantidad.Items.Add(txtCantidad.Text)
            xsubtotal = (Val(TextBox1PrecioU.Text) * Val(txtCantidad.Text))
            lstSubtotal.Items.Add(xsubtotal)

            xtotal = xtotal + xsubtotal
            txtTotal.Text = xtotal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnFinalizar.Click

        If lstCantidad.Items.Count = 0 Then
            MsgBox("Tiene que ingresar productos antes de poder realizar el pedido")
            Return

        ElseIf Not IsNumeric(txtPresupuesto.text) Then
            MsgBox("Ingrese un valor numerico para el presupuesto")
            Return
        End If

        Try
            Me.PedidoTableAdapter.LimpiarPedido(Inicio_de_sesion.nombre)
        Catch ex As Exception

        End Try


        If xtotal > txtPresupuesto.Text Then

            MsgBox("El total no puede ser mayor al presupuesto")
        Else
            numeropedido = Me.PedidoTableAdapter.BUSQUEDA_MAX() + 1
            Me.PedidoTableAdapter.Insertar_Pedido(numeropedido, Inicio_de_sesion.DPI, Inicio_de_sesion.nombre, Val(txtTotal.Text), Date.Today)

            If Not access.Crear_Tabla(Inicio_de_sesion.nombre) Then
                MsgBox(access.Exception)
                Return

            End If



            For producto As Integer = 0 To lstNombre.Items.Count - 1
                If Not access.ingresar_producto(producto, lstNombre.Items(producto), Val(lstCantidad.Items(producto)), Inicio_de_sesion.nombre) Then
                    MsgBox(access.Exception)
                    Return

                End If

            Next


            MsgBox("Se ha realizado el pedido, espere a ser contactado por uno de los voluntarios")
            Me.Hide()
            Inicio_de_sesion.Show()
        End If

    End Sub

    Private Sub Btnborrar_Click(sender As System.Object, e As System.EventArgs) Handles Btnborrar.Click
        Try
            ultimoenlista = lstCantidad.Items.Count - 1
            If ultimoenlista >= 0 Then
                xsubtotal = (Val(lstPrecio.Items(ultimoenlista))) * Val(lstCantidad.Items(ultimoenlista))
                xtotal = xtotal - xsubtotal
                txtTotal.Text = xtotal

                lstNombre.Items.RemoveAt(ultimoenlista)
                lstPrecio.Items.RemoveAt(ultimoenlista)
                lstSubtotal.Items.RemoveAt(ultimoenlista)
                lstCantidad.Items.RemoveAt(ultimoenlista)
            Else
                MsgBox("No puede borrar datos de una lista vacia")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class
