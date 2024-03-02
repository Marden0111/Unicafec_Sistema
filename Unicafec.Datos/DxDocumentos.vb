Imports System.Data.SqlClient
Imports Unicafec.Entidades

Public Class DxDocumentos
    Inherits Conexion

    Public Function ListarDocuemntos() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * from xDoc Order By IdDoc Asc", MyBase.conn)
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

    Public Sub InsertarDocuemntos(Obj As xDocumentos)
        Try
            Dim Comando As New SqlCommand("xDoc_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdDocIden", SqlDbType.VarChar).Value = Obj.IdDoc
            Comando.Parameters.Add("@NomDocIden", SqlDbType.VarChar).Value = Obj.NomDoc
            Comando.Parameters.Add("@Abrevt", SqlDbType.VarChar).Value = Obj.Abrevt
            Comando.Parameters.Add("@Referencia", SqlDbType.Bit).Value = Obj.Referencia
            Comando.Parameters.Add("@Vencimiento", SqlDbType.Bit).Value = Obj.Vencimiento
            Comando.Parameters.Add("@IdMePa", SqlDbType.VarChar).Value = Obj.IdMePa
            Comando.Parameters.Add("@UserIngre", SqlDbType.VarChar).Value = Obj.UserIngre
            Comando.Parameters.Add("@FechaIngre", SqlDbType.DateTime).Value = Obj.FechaIngre
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ActualizarDocuemntos(Obj As xDocumentos)
        Try
            Dim Comando As New SqlCommand("xDoc_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdDocIden", SqlDbType.VarChar).Value = Obj.IdDoc
            Comando.Parameters.Add("@NomDocIden", SqlDbType.VarChar).Value = Obj.NomDoc
            Comando.Parameters.Add("@Abrevt", SqlDbType.VarChar).Value = Obj.Abrevt
            Comando.Parameters.Add("@Referencia", SqlDbType.Bit).Value = Obj.Referencia
            Comando.Parameters.Add("@Vencimiento", SqlDbType.Bit).Value = Obj.Vencimiento
            Comando.Parameters.Add("@IdMePa", SqlDbType.VarChar).Value = Obj.IdMePa
            Comando.Parameters.Add("@UserModif", SqlDbType.VarChar).Value = Obj.UserModif
            Comando.Parameters.Add("@FechaModif", SqlDbType.DateTime).Value = Obj.FechaModif
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarDocuemntos(ID As String)
        Try
            Dim Comando As New SqlCommand("Delete From xDoc Where IdDoc='" & ID & "'", MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdDoc", SqlDbType.VarChar).Value = ID
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function BuscarIdDoc(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdDoc, NomDoc From xDoc Where IdDoc='" & valor & "'", MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdDoc", SqlDbType.VarChar).Value = valor
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
