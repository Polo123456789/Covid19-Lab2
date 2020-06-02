<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detalles_pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.detalles = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Numero_de_PedidoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.ZonaTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_Datos11DataSet = New covid19.Base_Datos11DataSet()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTableAdapter = New covid19.Base_Datos11DataSetTableAdapters.PedidoTableAdapter()
        Me.TableAdapterManager = New covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager()
        Me.UsuariosTableAdapter = New covid19.Base_Datos11DataSetTableAdapters.UsuariosTableAdapter()
        CType(Me.detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 22)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 22)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha del Pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 50)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "PEDIDOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Precio del pedido "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Numero de pedido"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(39, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 53)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Aceptar pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 53)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(543, 423)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 53)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'detalles
        '
        Me.detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalles.Enabled = False
        Me.detalles.Location = New System.Drawing.Point(809, 75)
        Me.detalles.Name = "detalles"
        Me.detalles.Size = New System.Drawing.Size(391, 401)
        Me.detalles.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(909, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 22)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Detalles del pedido"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(228, 262)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 35
        '
        'Numero_de_PedidoTextBox
        '
        Me.Numero_de_PedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Numero de Pedido", True))
        Me.Numero_de_PedidoTextBox.Location = New System.Drawing.Point(78, 366)
        Me.Numero_de_PedidoTextBox.Name = "Numero_de_PedidoTextBox"
        Me.Numero_de_PedidoTextBox.ReadOnly = True
        Me.Numero_de_PedidoTextBox.Size = New System.Drawing.Size(193, 20)
        Me.Numero_de_PedidoTextBox.TabIndex = 36
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(307, 366)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.ReadOnly = True
        Me.PrecioTextBox.Size = New System.Drawing.Size(193, 20)
        Me.PrecioTextBox.TabIndex = 37
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(227, 129)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(406, 20)
        Me.NombreTextBox.TabIndex = 38
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(227, 176)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.ReadOnly = True
        Me.ContactoTextBox.Size = New System.Drawing.Size(406, 20)
        Me.ContactoTextBox.TabIndex = 39
        '
        'ZonaTextBox
        '
        Me.ZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Zona", True))
        Me.ZonaTextBox.Location = New System.Drawing.Point(227, 221)
        Me.ZonaTextBox.Name = "ZonaTextBox"
        Me.ZonaTextBox.ReadOnly = True
        Me.ZonaTextBox.Size = New System.Drawing.Size(406, 20)
        Me.ZonaTextBox.TabIndex = 40
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Base_Datos11DataSet
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
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Detalles_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 507)
        Me.Controls.Add(Me.ZonaTextBox)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.Numero_de_PedidoTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.detalles)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Detalles_pedido"
        Me.Text = "Detalles_pedido"
        CType(Me.detalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents detalles As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Base_Datos11DataSet As Base_Datos11DataSet
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents PedidoTableAdapter As Base_Datos11DataSetTableAdapters.PedidoTableAdapter
    Friend WithEvents TableAdapterManager As Base_Datos11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosTableAdapter As Base_Datos11DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Numero_de_PedidoTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents ZonaTextBox As TextBox
End Class
