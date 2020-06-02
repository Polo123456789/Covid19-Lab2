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