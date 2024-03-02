Imports System.Data.SqlClient

Public Class DCajaBcosMov
    Inherits Conexion

    Public Function ListarMovIngresos() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From CajaBcosMov Where TipMov = '1' Order By Codigo asc", MyBase.conn)
            Comando.CommandType = CommandType.Text
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMovEgresos() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From CajaBcosMov Where TipMov = '2' Order By Codigo asc", MyBase.conn)
            Comando.CommandType = CommandType.Text
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
