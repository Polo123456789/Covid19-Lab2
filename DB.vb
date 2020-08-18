'  Guatemala en Casa
'  Copyright (C) 2020 Pablo Sanchez, Marco Aguilon, Masiel Dieguez,
'  Sebastian Letona, Any Gonzales, Alejandra Paredes.
'
'  This program is free software: you can redistribute it and/or modify
'  it under the terms of the GNU General Public License as published by
'  the Free Software Foundation, either version 3 of the License, or
'  (at your option) any later version.
'
'  This program is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'
'  You should have received a copy of the GNU General Public License
'  along with this program.  If not, see <https://www.gnu.org/licenses/>.

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
            Return True
        Else
            Try
                ExecQuery("DROP TABLE " & nombre & ";")
            Catch ex As Exception
                Return False
            End Try
            Return Crear_Tabla(nombre)
        End If

    End Function

    Public Function ingresar_producto(codigo As Integer, producto As String, cantidad As Integer, nombre As String)
        Dim sql2 As String

        sql2 = "Insert into " & nombre & " ([Codigo Producto], Producto, Cantidad) values ( " & CStr(codigo) & ", '" & producto & "', " & CStr(cantidad) & ");"
        ExecQuery(sql2)

        If Exception = "" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
