<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim ZonaLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.txtDpi = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtContraConf = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbtnVoluntario = New System.Windows.Forms.RadioButton()
        Me.rbtnBeneficiario = New System.Windows.Forms.RadioButton()
        Me.Base_Datos11DataSet = New covid19.Base_Datos11DataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New covid19.Base_Datos11DataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager()
        NombreLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        ZonaLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 20)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(12, 46)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(52, 13)
        ContactoLabel.TabIndex = 3
        ContactoLabel.Text = "Telefono:"
        '
        'ZonaLabel
        '
        ZonaLabel.AutoSize = True
        ZonaLabel.Location = New System.Drawing.Point(12, 72)
        ZonaLabel.Name = "ZonaLabel"
        ZonaLabel.Size = New System.Drawing.Size(55, 13)
        ZonaLabel.TabIndex = 5
        ZonaLabel.Text = "Direccion:"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(12, 98)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 7
        DPILabel.Text = "DPI:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Location = New System.Drawing.Point(12, 124)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(97, 13)
        CorreoElectronicoLabel.TabIndex = 9
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(12, 150)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 11
        ContraseñaLabel.Text = "Contraseña:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(12, 202)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 13
        TipoLabel.Text = "Tipo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 176)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 13)
        Label1.TabIndex = 21
        Label1.Text = "Confirmar Contraseña:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(137, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(395, 20)
        Me.txtNombre.TabIndex = 14
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(137, 43)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(395, 20)
        Me.txtContacto.TabIndex = 15
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(137, 69)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(395, 20)
        Me.txtZona.TabIndex = 16
        '
        'txtDpi
        '
        Me.txtDpi.Location = New System.Drawing.Point(137, 95)
        Me.txtDpi.Name = "txtDpi"
        Me.txtDpi.Size = New System.Drawing.Size(395, 20)
        Me.txtDpi.TabIndex = 17
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(137, 124)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(395, 20)
        Me.txtCorreo.TabIndex = 18
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(137, 150)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(395, 20)
        Me.txtContra.TabIndex = 19
        '
        'txtContraConf
        '
        Me.txtContraConf.Location = New System.Drawing.Point(137, 176)
        Me.txtContraConf.Name = "txtContraConf"
        Me.txtContraConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraConf.Size = New System.Drawing.Size(395, 20)
        Me.txtContraConf.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 52)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtnVoluntario
        '
        Me.rbtnVoluntario.AutoSize = True
        Me.rbtnVoluntario.Location = New System.Drawing.Point(137, 203)
        Me.rbtnVoluntario.Name = "rbtnVoluntario"
        Me.rbtnVoluntario.Size = New System.Drawing.Size(72, 17)
        Me.rbtnVoluntario.TabIndex = 24
        Me.rbtnVoluntario.TabStop = True
        Me.rbtnVoluntario.Text = "Voluntario"
        Me.rbtnVoluntario.UseVisualStyleBackColor = True
        '
        'rbtnBeneficiario
        '
        Me.rbtnBeneficiario.AutoSize = True
        Me.rbtnBeneficiario.Location = New System.Drawing.Point(232, 203)
        Me.rbtnBeneficiario.Name = "rbtnBeneficiario"
        Me.rbtnBeneficiario.Size = New System.Drawing.Size(80, 17)
        Me.rbtnBeneficiario.TabIndex = 25
        Me.rbtnBeneficiario.TabStop = True
        Me.rbtnBeneficiario.Text = "Beneficiario"
        Me.rbtnBeneficiario.UseVisualStyleBackColor = True
        '
        'Base_Datos11DataSet
        '
        Me.Base_Datos11DataSet.DataSetName = "Base_Datos11DataSet"
        Me.Base_Datos11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Base_Datos11DataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = covid19.Base_Datos11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.rbtnBeneficiario)
        Me.Controls.Add(Me.rbtnVoluntario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContraConf)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDpi)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(ZonaLabel)
        Me.Controls.Add(DPILabel)
        Me.Controls.Add(CorreoElectronicoLabel)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(TipoLabel)
        Me.Name = "Registros"
        Me.Text = "Registros"
        CType(Me.Base_Datos11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Base_Datos11DataSet As Base_Datos11DataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As Base_Datos11DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As Base_Datos11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtZona As TextBox
    Friend WithEvents txtDpi As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtContraConf As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents rbtnVoluntario As RadioButton
    Friend WithEvents rbtnBeneficiario As RadioButton
End Class
