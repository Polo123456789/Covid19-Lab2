Public Class Voluntarios
    Public Tabla As String
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
        Tabla = pedidos.CurrentCell.Value
        Me.Hide()
        Detalles_pedido.Show()
    End Sub
End Class