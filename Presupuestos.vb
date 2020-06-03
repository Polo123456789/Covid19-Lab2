
Public Class Presupuestos

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProductosLista.Click

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPrecio.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbLugar.SelectedIndexChanged

    End Sub

    Private Sub Btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles Btnbuscar.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles registroproducto.SelectedIndexChanged
        Dim tabla As New DataTable
        Dim sql As String


    End Sub

    Private Sub Presupuestos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet.Lugares' Puede moverla o quitarla según sea necesario.
        Me.LugaresTableAdapter.Fill(Me.PresupuestoDataSet.Lugares)
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PresupuestoDataSet.Productos)



    End Sub

    Private Sub Btnagregar_Click(sender As System.Object, e As System.EventArgs) Handles Btnagregar.Click
        
        lstNombre.Items.Add(registroproducto.SelectedItem)


    End Sub

    Private Sub lstNombre_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstNombre.SelectedIndexChanged

    End Sub
End Class