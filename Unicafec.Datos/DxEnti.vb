Imports System.Data.SqlClient
Imports Unicafec.Entidades

Public Class DxEnti
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("xEnti_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarDatos(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("xEnti_CargarDatos", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdEnti", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(Obj As xEnti)
        Try
            Dim Comando As New SqlCommand("xEnti_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdEnti", SqlDbType.NVarChar).Value = Obj.IdEnti
            Comando.Parameters.Add("@TipoEnti", SqlDbType.NVarChar).Value = Obj.TipoEnti
            Comando.Parameters.Add("@TipoEmpr", SqlDbType.NVarChar).Value = Obj.TipoEmpr
            Comando.Parameters.Add("@NomEntiRS", SqlDbType.NVarChar).Value = Obj.NomEntiRS
            Comando.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = Obj.Nombres
            Comando.Parameters.Add("@Apellido1", SqlDbType.NVarChar).Value = Obj.Apellido1
            Comando.Parameters.Add("@Apellido2", SqlDbType.NVarChar).Value = Obj.Apellido2
            Comando.Parameters.Add("@NomComercial", SqlDbType.NVarChar).Value = Obj.NomComercial
            Comando.Parameters.Add("@IdDocIden", SqlDbType.NVarChar).Value = Obj.TipoDocIden
            Comando.Parameters.Add("@NumDocIden", SqlDbType.VarChar).Value = Obj.NumDocIden
            Comando.Parameters.Add("@Socio", SqlDbType.Bit).Value = Obj.Socio
            Comando.Parameters.Add("@Cliente", SqlDbType.Bit).Value = Obj.Cliente
            Comando.Parameters.Add("@Proveedor", SqlDbType.Bit).Value = Obj.Proveedor
            Comando.Parameters.Add("@Empleado", SqlDbType.Bit).Value = Obj.Empleado
            Comando.Parameters.Add("@Otros", SqlDbType.Bit).Value = Obj.Otros
            Comando.Parameters.Add("@TipoVia", SqlDbType.VarChar).Value = Obj.TipoVia
            Comando.Parameters.Add("@NombreVia", SqlDbType.NVarChar).Value = Obj.NomVia
            Comando.Parameters.Add("@Nro", SqlDbType.NVarChar).Value = Obj.Nro
            Comando.Parameters.Add("@Interior", SqlDbType.NVarChar).Value = Obj.Interior
            Comando.Parameters.Add("@DZona", SqlDbType.NVarChar).Value = Obj.DZona
            Comando.Parameters.Add("@VReferencia", SqlDbType.NVarChar).Value = Obj.VReferencia
            Comando.Parameters.Add("@Ubigeo", SqlDbType.VarChar).Value = Obj.Ubigeo
            Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Obj.Pais
            Comando.Parameters.Add("@Departamento", SqlDbType.VarChar).Value = Obj.Departamento
            Comando.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Obj.Provincia
            Comando.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = Obj.Distrito
            Comando.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = Obj.Celular
            Comando.Parameters.Add("@CorreoElectronico", SqlDbType.NVarChar).Value = Obj.CorreoElectronico
            Comando.Parameters.Add("@Observaciones", SqlDbType.NVarChar).Value = Obj.Observaciones
            Comando.Parameters.Add("@UserIngre", SqlDbType.VarChar).Value = Obj.UserIngre
            Comando.Parameters.Add("@FechaIngre", SqlDbType.DateTime).Value = Obj.FechaIngre
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As xEnti)
        Try
            Dim Comando As New SqlCommand("xEnti_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdEnti", SqlDbType.NVarChar).Value = Obj.IdEnti
            Comando.Parameters.Add("@TipoEnti", SqlDbType.NVarChar).Value = Obj.TipoEnti
            Comando.Parameters.Add("@TipoEmpr", SqlDbType.NVarChar).Value = Obj.TipoEmpr
            Comando.Parameters.Add("@NomEntiRS", SqlDbType.NVarChar).Value = Obj.NomEntiRS
            Comando.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = Obj.Nombres
            Comando.Parameters.Add("@Apellido1", SqlDbType.NVarChar).Value = Obj.Apellido1
            Comando.Parameters.Add("@Apellido2", SqlDbType.NVarChar).Value = Obj.Apellido2
            Comando.Parameters.Add("@NomComercial", SqlDbType.NVarChar).Value = Obj.NomComercial
            Comando.Parameters.Add("@IdDocIden", SqlDbType.NVarChar).Value = Obj.TipoDocIden
            Comando.Parameters.Add("@NumDocIden", SqlDbType.VarChar).Value = Obj.NumDocIden
            Comando.Parameters.Add("@Socio", SqlDbType.Bit).Value = Obj.Socio
            Comando.Parameters.Add("@Cliente", SqlDbType.Bit).Value = Obj.Cliente
            Comando.Parameters.Add("@Proveedor", SqlDbType.Bit).Value = Obj.Proveedor
            Comando.Parameters.Add("@Empleado", SqlDbType.Bit).Value = Obj.Empleado
            Comando.Parameters.Add("@Otros", SqlDbType.Bit).Value = Obj.Otros
            Comando.Parameters.Add("@TipoVia", SqlDbType.VarChar).Value = Obj.TipoVia
            Comando.Parameters.Add("@NombreVia", SqlDbType.NVarChar).Value = Obj.NomVia
            Comando.Parameters.Add("@Nro", SqlDbType.NVarChar).Value = Obj.Nro
            Comando.Parameters.Add("@Interior", SqlDbType.NVarChar).Value = Obj.Interior
            Comando.Parameters.Add("@DZona", SqlDbType.NVarChar).Value = Obj.DZona
            Comando.Parameters.Add("@VReferencia", SqlDbType.NVarChar).Value = Obj.VReferencia
            Comando.Parameters.Add("@Ubigeo", SqlDbType.VarChar).Value = Obj.Ubigeo
            Comando.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Obj.Pais
            Comando.Parameters.Add("@Departamento", SqlDbType.VarChar).Value = Obj.Departamento
            Comando.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Obj.Provincia
            Comando.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = Obj.Distrito
            Comando.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = Obj.Celular
            Comando.Parameters.Add("@CorreoElectronico", SqlDbType.NVarChar).Value = Obj.CorreoElectronico
            Comando.Parameters.Add("@Observaciones", SqlDbType.NVarChar).Value = Obj.Observaciones
            Comando.Parameters.Add("@UserModif", SqlDbType.VarChar).Value = Obj.UserModif
            Comando.Parameters.Add("@FechaModif", SqlDbType.DateTime).Value = Obj.FechaModif
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function BuscarDocIden(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xDocIDen Where IdDocIden=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdEnti", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDocIden() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdDocIden, NomDocIden, Abrevt From xDocIDen", MyBase.conn)
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

    Public Function BuscarTipVia(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xTipVia Where IdTipVia=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdTipVia", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTipVia() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdTipVia, NomVia, Abrevt From xTipVia", MyBase.conn)
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

    Public Function BuscarPais(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xPais Where IdPais=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdPais", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPais() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdPais, NomPais From xPais", MyBase.conn)
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

    Public Function BuscarDep(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xDep Where IdDep=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdDep", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDep() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdDep, NomDep From xDep", MyBase.conn)
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

    Public Function BuscarProv(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xProv Where IdProv=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdProv", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarProv() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdProv, NomProv From xProv", MyBase.conn)
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

    Public Function BuscarDist(valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select * From xDist Where IdDist=" & valor, MyBase.conn)
            Comando.CommandType = CommandType.Text
            Comando.Parameters.Add("@IdDist", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDist() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("Select IdDist, NomDist From xDist", MyBase.conn)
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
