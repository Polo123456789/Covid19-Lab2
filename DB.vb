Imports System.Data.OleDb

Public Class DBControl
    ' CREATE YOUR DB CONNECTION
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         "Data Source=Base Datos11.accdb;")

    ' PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    ' DB DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    ' INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Function Crear_Tabla(nombre As String)
        Dim sql As String
        sql = "Create Table " & nombre & " ([Codigo Producto] integer primary key,Producto char(50), Cantidad integer);"
        ExecQuery(sql)

        If Exception = "" Then
            Return 0
        Else
            Return 1
        End If

    End Function

    Public Function ingresar_producto(codigo As Integer, producto As String, cantidad As Integer, nombre As String)
        Dim sql2 As String

        sql2 = "Insert into " & nombre & "(Codigo Producto, Producto , Cantidad) values ( " & CStr(codigo) & ", '" & producto & "', " & CStr(cantidad) & ");"
        If Exception = "" Then
            Return 0
        Else
            Return 1
        End If
    End Function

End Class
