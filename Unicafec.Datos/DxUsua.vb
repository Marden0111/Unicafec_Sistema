Imports System.Data.SqlClient

Public Class DxUsua
    Inherits Conexion

    Public Function Login(Email As String, Clave As String, Usuario As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("xUsua_Login", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email
            Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario
            Comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Clave
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
