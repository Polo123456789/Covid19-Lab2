Public Class Inicio_de_sesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DPI, Contraseña As String

        DPI = txtDPI.Text
        Contraseña = txtContraseña.Text

        Try
            If Registros.Hash(Contraseña) = Me.UsuariosTableAdapter.Password(DPI) Then
                MsgBox("Exito")
            Else
                MsgBox("El DPI o la contraseña son incorrectos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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