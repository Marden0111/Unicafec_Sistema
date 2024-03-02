Imports Unicafec.Datos
Imports Unicafec.Entidades

Public Class NxDocumentos

    Public Function ListarDocuemtnos() As DataTable
        Try
            Dim Datos As New DxDocumentos
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDocuemntos
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function InsertarDocuemtnos(Obj As xDocumentos) As Boolean
        Try
            Dim Datos As New DxDocumentos
            Datos.InsertarDocuemntos(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function ActualizarDocuemtnos(Obj As xDocumentos) As Boolean
        Try
            Dim Datos As New DxDocumentos
            Datos.ActualizarDocuemntos(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function EliminarDocuemtnos(Id As String) As Boolean
        Try
            Dim Datos As New DxDocumentos
            Datos.EliminarDocuemntos(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarIdDoc(Valor As String) As DataTable
        Try
            Dim Datos As New DxDocumentos
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarIdDoc(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
