<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Voluntarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pedidos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Base_Datos11DataSet = New covid19.Base_Datos11DataSet()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTableAdapter = New covid19.Base_Datos11DataSetTableAdapters.PedidoTableAdapter()
        Me.TableAdapterManager = New covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager()
        CType(Me.pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar pedido"
        '
        'pedidos
        '
        Me.pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pedidos.Location = New System.Drawing.Point(60, 96)
        Me.pedidos.Name = "pedidos"
        Me.pedidos.Size = New System.Drawing.Size(744, 252)
        Me.pedidos.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(118, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(420, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Voluntarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 458)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pedidos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Voluntarios"
        Me.Text = "Voluntarios"
        CType(Me.pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pedidos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Base_Datos11DataSet As Base_Datos11DataSet
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents PedidoTableAdapter As Base_Datos11DataSetTableAdapters.PedidoTableAdapter
    Friend WithEvents TableAdapterManager As Base_Datos11DataSetTableAdapters.TableAdapterManager
End Class
