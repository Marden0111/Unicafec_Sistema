Imports System.Data.SqlClient
Imports Unicafec.Entidades

Public Class DCajaBcosReg
    Inherits Conexion

    Public Function ListarCajas() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From CajaBcosReg Where Modulo='101' Order By Codigo asc", MyBase.conn)
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
