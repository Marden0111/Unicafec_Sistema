Imports System.Data.Common
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frmxTablas
    Dim IndexCellResaltada As Integer = 0 '-1Variable para seleccionar al pasar con el mouse

#Region "Eventos del dgvTabla"
    Private Sub lblTablas_Click(sender As Object, e As EventArgs) Handles lblTablas.Click
        Me.btnTablas_Click(Nothing, Nothing)
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        If dgvTablas.Visible = False Then
            dgvTablas.Visible = True
            dgvTablas.Location = New Point(GroupBox1.Left + 5, GroupBox1.Top + 28)
            dgvTablas.Size = New Size(Me.lblTablas.Width - 3, 400)
            Me.Listar_zxTablas()

        ElseIf dgvTablas.Visible = True Then
            dgvTablas.Visible = False
        End If
    End Sub

    Private Sub LimpiarDgvTabla()
        dgvTablas.Visible = False
        dgvTablas.Location = New Point(170, 8)
        dgvTablas.Size = New Size(25, 25)
        dgvTablas.DataSource = Nothing
        dgvTablas.Rows.Clear()
    End Sub

    Private Sub dgvTablas_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTablas.CellMouseEnter
        On Error Resume Next

        If e.RowIndex = IndexCellResaltada Then Return

        If IndexCellResaltada >= 0 Then
            dgvTablas.Rows(IndexCellResaltada).DefaultCellStyle = Nothing
        End If

        IndexCellResaltada = e.RowIndex

        If IndexCellResaltada >= 0 Then
            dgvTablas.Rows(IndexCellResaltada).DefaultCellStyle.BackColor = Color.FromArgb(46, 134, 193)
        End If
    End Sub

    Private Sub dgvTablas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTablas.CellClick
        On Error Resume Next
        dgvCargarDatos.DataSource = Nothing
        dgvCargarDatos.Rows.Clear()
        lblIdTabla.Text = dgvTablas.SelectedCells.Item(1).Value
        lblTitulo.Text = "Registro de " & dgvTablas.SelectedCells.Item(2).Value
        dgvTablas.Columns(1).Visible = True
        lblTablas.Text = dgvTablas.SelectedCells.Item(2).Value
        dgvListado.DataSource = Nothing
        dgvListado.Rows.Clear()

        If lblIdTabla.Text = "xDocIden" Then
            Me.Listar_xDocIden()
        ElseIf lblIdTabla.Text = "xPais" Then
            Me.Listar_xPais()
        ElseIf lblIdTabla.Text = "xDep" Then
            Me.Listar_xDepartamento()
        ElseIf lblIdTabla.Text = "xProv" Then
            Me.Listar_xProvincia()
        ElseIf lblIdTabla.Text = "xDist" Then
            Me.Listar_xDistrito()
        ElseIf lblIdTabla.Text = "xTipVia" Then
            Me.Listar_xTipoVia()
        End If

        LimpiarDgvTabla()
    End Sub

    Private Sub dgvTablas_MouseLeave(sender As Object, e As EventArgs) Handles dgvTablas.MouseLeave
        Me.LimpiarDgvTabla()
    End Sub
#End Region

#Region "Dimensionar tablas"

    Private Sub Dimensionar_zxTablas()
        dgvTablas.Columns(0).HeaderText = "Código"
        dgvTablas.Columns(1).Visible = False
        dgvTablas.Columns(2).HeaderText = "Nombre de tabla"

        dgvTablas.Columns(0).Width = 55
        dgvTablas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        If dgvTablas.Rows.Count <= 15 Then
            dgvTablas.Height = 27 + (dgvTablas.Rows.Count * 19)
        Else
            dgvTablas.Height = 27 + (15 * 19)
        End If
    End Sub

    Private Sub Dimensionar_xDocIden()
        dgvListado.Columns(0).HeaderText = "Código"
        dgvListado.Columns(1).HeaderText = "Tipo"
        dgvListado.Columns(2).HeaderText = "Abreviatura"
        dgvListado.Columns(3).HeaderText = "Agregado"
        dgvListado.Columns(4).HeaderText = "Fecha"
        dgvListado.Columns(5).HeaderText = "Modificado"
        dgvListado.Columns(6).HeaderText = "Fecha"

        dgvListado.Columns(0).Width = 80
        dgvListado.Columns(1).Width = 400
        dgvListado.Columns(2).Width = 80
        dgvListado.Columns(3).Width = 95
        dgvListado.Columns(4).Width = 120
        dgvListado.Columns(5).Width = 95

        dgvListado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvListado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvListado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvListado.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

    End Sub

    Private Sub Dimensionar_xPais()
        dgvListado.Columns(0).HeaderText = " CODIGO"
        dgvListado.Columns(1).HeaderText = " NOMBRE"
        dgvListado.Columns(2).HeaderText = " INGRESO"
        dgvListado.Columns(3).HeaderText = " FECHA"
        dgvListado.Columns(4).HeaderText = " MODIFICACIÓN"
        dgvListado.Columns(5).HeaderText = " FECHA"

        dgvListado.Columns(0).Width = 70
        dgvListado.Columns(1).Width = 420
        dgvListado.Columns(2).Width = 95
        dgvListado.Columns(3).Width = 120
        dgvListado.Columns(4).Width = 95

        dgvListado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvListado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvListado.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub

    Private Sub Dimensionar_xTablasDePais()
        dgvListado.Columns(0).HeaderText = " CODIGO"
        dgvListado.Columns(1).HeaderText = " NOMBRE"
        dgvListado.Columns(2).Visible = False
        dgvListado.Columns(3).HeaderText = " INGRESO"
        dgvListado.Columns(4).HeaderText = " FECHA"
        dgvListado.Columns(5).HeaderText = " MODIFICACIÓN"
        dgvListado.Columns(6).HeaderText = " FECHA"

        dgvListado.Columns(0).Width = 70
        dgvListado.Columns(1).Width = 420
        dgvListado.Columns(3).Width = 95
        dgvListado.Columns(4).Width = 120
        dgvListado.Columns(5).Width = 95

        dgvListado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvListado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvListado.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub
#End Region

#Region "Listado de tablas"
    Private Function Listar_zxTablas() As DataTable
        Try
            Dim Neg As New Negocio.NxTablas
            dgvTablas.DataSource = Neg.Listar_Tablas()
            dgvTablas.ClearSelection()
            Me.Dimensionar_zxTablas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Listar_xDocIden()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_DocIden()
            Me.Dimensionar_xDocIden()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xPais()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Pais()
            Me.Dimensionar_xPais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xDepartamento()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Departamento()
            Me.Dimensionar_xTablasDePais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xProvincia()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Provincia()
            Me.Dimensionar_xTablasDePais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xDistrito()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Distrito()
            Me.Dimensionar_xTablasDePais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xTipoVia()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_TipoVia()
            Me.Dimensionar_xTablasDePais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region



    Private Sub frmxTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar_xPais()
        lblTablas.Text = "Paises"
        lblIdTabla.Text = "xPais"
        txtNomCampo.Text = "61219553"

        'Me.btnSunat_Click(Nothing, Nothing)
    End Sub

    Private Sub frmxTablas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next

        GroupBox1.Location = New Point(Me.Width - 670, 1)

        TabControl1.Location = New Point(1, 2)
        TabControl1.Size = New Size(Me.Width - 20, 30)
        TabControl1.ItemSize = New Size((TabControl1.Width - 16) / 5, 21)

        Panel2.Location = New Point(4, 24)
        Panel2.Size = New Size(Me.Width - 25, Me.Height - 114)

        Panel3.Location = New Point(2, 26)
        Panel3.Size = New Size(Panel2.Width, Panel2.Height)
    End Sub

    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.NxTablas
            Dim Valor As String
            Valor = dgvListado.SelectedCells.Item(0).Value

            If lblIdTabla.Text = "xDocIden" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_DocIden(Valor)
            ElseIf lblIdTabla.Text = "xPais" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_Pais(Valor)
            ElseIf lblIdTabla.Text = "xDep" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_Departamento(Valor)
            ElseIf lblIdTabla.Text = "xProv" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_Provincia(Valor)
            ElseIf lblIdTabla.Text = "xDist" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_Distrito(Valor)
            ElseIf lblIdTabla.Text = "xTipVia" Then
                dgvCargarDatos.DataSource = Neg.CargarDatos_TipoVia(Valor)
            End If

            If dgvCargarDatos.Rows.Count <> 0 Then
                txtIdCampo.Text = dgvCargarDatos.SelectedCells.Item(0).Value
                txtNomCampo.Text = dgvCargarDatos.SelectedCells.Item(1).Value
                TabControl1.SelectedIndex = 3
                Panel3.Visible = True
                TabControl1.Enabled = False
                lblGuardar.Text = "MODIFICAR"
            Else
                MsgBox("No se encontró registro", vbOKOnly + vbCritical, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnSunat.Visible = False
        lblTablas.Enabled = False
        Me.btnTablas.Enabled = False
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

        Select Case TabControl1.SelectedIndex
            Case 0 'Lista
                'por definir

            Case 1 'Detalle
                Panel3.Visible = True
                TabControl1.Enabled = False


            Case 2 'Ingresar
                Panel3.Visible = True
                TabControl1.Enabled = False
                lblGuardar.Text = "INGRESAR"
                txtIdCampo.Select()


            Case 3 ' Modificar
                Panel3.Visible = True
                TabControl1.Enabled = False
                lblGuardar.Text = "MODIFICAR"
                btnSunat.Visible = False

            Case 4 'eleminar
                Panel3.Visible = True
                TabControl1.Enabled = False
                'dgvRegistros_CellDoubleClick(Nothing, Nothing)
                TabControl1.SelectedIndex = 4
                lblGuardar.Text = "ELIMINAR"

        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lblGuardar.Text = "INGRESAR" Then


        ElseIf lblGuardar.Text = "MODIFICAR" Then


        ElseIf lblGuardar.Text = "ELIMINAR" Then


        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TabControl1.Enabled = True
        lblGuardar.Text = ""
        Panel3.Visible = False
        TabControl1.SelectedIndex = 0

        btnSunat.Visible = True
        lblTablas.Enabled = True
        Me.btnTablas.Enabled = True
    End Sub

    'Private Sub btnSunat_Click(sender As Object, e As EventArgs) Handles btnSunat.Click
    '    Dim idcampo = txtNomCampo.Text

    '    Dim RUC = ""
    '    'MsgBox(RUC, vbOKOnly)


    '    'Me.miBrowser.

    '    Dim Token As String
    '    Token = "apis-token-7193.0JO72i0TQAwEKtiKIUEMvxydxvgwgr1n"

    '    Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://api.apis.net.pe/v2/reniec/dni?numero=46027897"), HttpWebRequest)
    '    request.Method = "GET"
    '    request.Headers.Add("Authorization", "Bearer " & Token)
    '    request.ContentType = "application/json"

    '    Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
    '    Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()

    '    'MsgBox(responseString, vbOK)

    '    ' Parsear la respuesta JSON a un objeto JObject
    '    Dim jsonObject As JObject = JObject.Parse(responseString)

    '    ' Ahora puedes acceder a los valores en el objeto JSON usando los nombres de las claves
    '    ' Por ejemplo, si la respuesta tiene una clave llamada "nombre", puedes obtener su valor así:
    '    Dim nombre As String = jsonObject("nombres").ToString()

    '    MsgBox("Nombre: " & nombre, vbOKOnly, "ARCHIVO JSON")


    'End Sub
End Class