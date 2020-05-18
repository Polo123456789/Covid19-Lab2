Imports System.Security.Cryptography
Imports System.Text

Public Class Registros
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_Datos11DataSet)

    End Sub

    Private Sub Registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_Datos11DataSet.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.Base_Datos11DataSet.Usuarios)

    End Sub
    Private Function Hash(contraseña As String)
        Dim UE As New UnicodeEncoding
        Dim bHash As Byte()
        'Almacena la cadena ingresada en una matriz de bytes
        Dim bCadena() As Byte = UE.GetBytes(contraseña)
        Dim s1Service As New SHA1CryptoServiceProvider
        'Crea el hash
        bHash = s1Service.ComputeHash(bCadena)
        'Retorna como una cadena codificada en base64
        Dim hash_texto As String
        hash_texto = Convert.ToBase64String(bHash)
        Return hash_texto
    End Function
    Private Function EntradasValidas()
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                If control.Text = "" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not EntradasValidas() Then
            MsgBox("No pueden haber campos en blanco")
            Return
        End If
        If txtContra.Text = txtContraConf.Text Then
            Dim contraseña As String
            contraseña = txtContra.Text
            contraseña = Hash(contraseña)
        Else
            MsgBox("Las contraseñas no coinciden, ingreselas nuevamente.")
        End If
    End Sub
End Class