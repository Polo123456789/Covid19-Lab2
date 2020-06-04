<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuestos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblProductosLista = New System.Windows.Forms.Label()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPrecioU = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.lstCantidad = New System.Windows.Forms.ListBox()
        Me.lstSubtotal = New System.Windows.Forms.ListBox()
        Me.LugaresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDataSet = New covid19.PresupuestoDataSet()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.registroproducto = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PresupuestoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New covid19.PresupuestoDataSetTableAdapters.ProductosTableAdapter()
        Me.PresupuestoDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LugaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LugaresTableAdapter = New covid19.PresupuestoDataSetTableAdapters.LugaresTableAdapter()
        Me.PresupuestoDataSetBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.TextBox1PrecioU = New System.Windows.Forms.TextBox()
        Me.Base_Datos11DataSet = New covid19.Base_Datos11DataSet()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTableAdapter = New covid19.Base_Datos11DataSetTableAdapters.PedidoTableAdapter()
        Me.TableAdapterManager = New covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager()
        CType(Me.LugaresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LugaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataSetBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductosLista
        '
        Me.lblProductosLista.AutoSize = True
        Me.lblProductosLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductosLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductosLista.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblProductosLista.Location = New System.Drawing.Point(253, 9)
        Me.lblProductosLista.Name = "lblProductosLista"
        Me.lblProductosLista.Size = New System.Drawing.Size(334, 41)
        Me.lblProductosLista.TabIndex = 0
        Me.lblProductosLista.Text = "Productos a tu lista"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuesto.Location = New System.Drawing.Point(255, 91)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(167, 31)
        Me.lblPresupuesto.TabIndex = 1
        Me.lblPresupuesto.Text = "Presupuesto"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(432, 91)
        Me.txtPresupuesto.Multiline = True
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(159, 33)
        Me.txtPresupuesto.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(21, 259)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(179, 25)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre Producto"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(369, 252)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(109, 29)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblPrecioU
        '
        Me.lblPrecioU.AutoSize = True
        Me.lblPrecioU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioU.Location = New System.Drawing.Point(213, 259)
        Me.lblPrecioU.Name = "lblPrecioU"
        Me.lblPrecioU.Size = New System.Drawing.Size(144, 25)
        Me.lblPrecioU.TabIndex = 7
        Me.lblPrecioU.Text = "Precio unidad"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(506, 256)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(91, 25)
        Me.lblSubtotal.TabIndex = 8
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lstNombre
        '
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.Location = New System.Drawing.Point(28, 292)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(166, 147)
        Me.lstNombre.TabIndex = 10
        '
        'lstCantidad
        '
        Me.lstCantidad.FormattingEnabled = True
        Me.lstCantidad.Location = New System.Drawing.Point(367, 292)
        Me.lstCantidad.Name = "lstCantidad"
        Me.lstCantidad.Size = New System.Drawing.Size(103, 147)
        Me.lstCantidad.TabIndex = 11
        '
        'lstSubtotal
        '
        Me.lstSubtotal.FormattingEnabled = True
        Me.lstSubtotal.Location = New System.Drawing.Point(489, 292)
        Me.lstSubtotal.Name = "lstSubtotal"
        Me.lstSubtotal.Size = New System.Drawing.Size(120, 147)
        Me.lstSubtotal.TabIndex = 13
        '
        'LugaresBindingSource1
        '
        Me.LugaresBindingSource1.DataMember = "Lugares"
        Me.LugaresBindingSource1.DataSource = Me.PresupuestoDataSet
        '
        'PresupuestoDataSet
        '
        Me.PresupuestoDataSet.DataSetName = "PresupuestoDataSet"
        Me.PresupuestoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(383, 458)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 31)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(489, 458)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 39)
        Me.txtTotal.TabIndex = 16
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.Black
        Me.btnFinalizar.Location = New System.Drawing.Point(647, 458)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(137, 40)
        Me.btnFinalizar.TabIndex = 17
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Btnagregar
        '
        Me.Btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btnagregar.Location = New System.Drawing.Point(606, 160)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(137, 36)
        Me.Btnagregar.TabIndex = 19
        Me.Btnagregar.Text = "agregar"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'Btnborrar
        '
        Me.Btnborrar.Location = New System.Drawing.Point(644, 369)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(140, 38)
        Me.Btnborrar.TabIndex = 20
        Me.Btnborrar.Text = "Borrar"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'registroproducto
        '
        Me.registroproducto.DataSource = Me.ProductosBindingSource2
        Me.registroproducto.DisplayMember = "Nombre"
        Me.registroproducto.FormattingEnabled = True
        Me.registroproducto.Location = New System.Drawing.Point(239, 174)
        Me.registroproducto.Name = "registroproducto"
        Me.registroproducto.Size = New System.Drawing.Size(121, 21)
        Me.registroproducto.TabIndex = 22
        Me.registroproducto.ValueMember = "Id"
        '
        'ProductosBindingSource2
        '
        Me.ProductosBindingSource2.DataMember = "Productos"
        Me.ProductosBindingSource2.DataSource = Me.PresupuestoDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Registro producto"
        '
        'PresupuestoDataSetBindingSource
        '
        Me.PresupuestoDataSetBindingSource.DataSource = Me.PresupuestoDataSet
        Me.PresupuestoDataSetBindingSource.Position = 0
        '
        'PresupuestoDataSetBindingSource1
        '
        Me.PresupuestoDataSetBindingSource1.DataSource = Me.PresupuestoDataSet
        Me.PresupuestoDataSetBindingSource1.Position = 0
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.PresupuestoDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDataSetBindingSource2
        '
        Me.PresupuestoDataSetBindingSource2.DataSource = Me.PresupuestoDataSet
        Me.PresupuestoDataSetBindingSource2.Position = 0
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.PresupuestoDataSet
        '
        'LugaresBindingSource
        '
        Me.LugaresBindingSource.DataMember = "Lugares"
        Me.LugaresBindingSource.DataSource = Me.PresupuestoDataSet
        '
        'LugaresTableAdapter
        '
        Me.LugaresTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDataSetBindingSource3
        '
        Me.PresupuestoDataSetBindingSource3.DataSource = Me.PresupuestoDataSet
        Me.PresupuestoDataSetBindingSource3.Position = 0
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(380, 174)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(98, 25)
        Me.cantidad.TabIndex = 25
        Me.cantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(484, 174)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(78, 26)
        Me.txtCantidad.TabIndex = 26
        '
        'lstPrecio
        '
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Location = New System.Drawing.Point(218, 292)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(127, 147)
        Me.lstPrecio.TabIndex = 12
        '
        'TextBox1PrecioU
        '
        Me.TextBox1PrecioU.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource2, "Precio unitario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1PrecioU.Location = New System.Drawing.Point(606, 165)
        Me.TextBox1PrecioU.Multiline = True
        Me.TextBox1PrecioU.Name = "TextBox1PrecioU"
        Me.TextBox1PrecioU.Size = New System.Drawing.Size(78, 26)
        Me.TextBox1PrecioU.TabIndex = 27
        '
        'Base_Datos11DataSet
        '
        Me.Base_Datos11DataSet.DataSetName = "Base_Datos11DataSet"
        Me.Base_Datos11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "Pedido"
        Me.PedidoBindingSource.DataSource = Me.Base_Datos11DataSet
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PedidoTableAdapter = Me.PedidoTableAdapter
        Me.TableAdapterManager.UpdateOrder = covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Presupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(842, 518)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.registroproducto)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstSubtotal)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.lstCantidad)
        Me.Controls.Add(Me.lstNombre)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblPrecioU)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Controls.Add(Me.lblProductosLista)
        Me.Controls.Add(Me.TextBox1PrecioU)
        Me.Name = "Presupuestos"
        Me.Text = "Presupuestos"
        CType(Me.LugaresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LugaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataSetBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductosLista As System.Windows.Forms.Label
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblPrecioU As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lstNombre As System.Windows.Forms.ListBox
    Friend WithEvents lstCantidad As System.Windows.Forms.ListBox
    Friend WithEvents lstSubtotal As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents registroproducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PresupuestoDataSet As covid19.PresupuestoDataSet
    Friend WithEvents PresupuestoDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As covid19.PresupuestoDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDataSetBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents LugaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LugaresTableAdapter As covid19.PresupuestoDataSetTableAdapters.LugaresTableAdapter
    Friend WithEvents ProductosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDataSetBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents LugaresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1PrecioU As System.Windows.Forms.TextBox
    Friend WithEvents Base_Datos11DataSet As covid19.Base_Datos11DataSet
    Friend WithEvents PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidoTableAdapter As covid19.Base_Datos11DataSetTableAdapters.PedidoTableAdapter
    Friend WithEvents TableAdapterManager As covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager
End Class
