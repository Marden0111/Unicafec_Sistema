Imports System.Data.Common

Public Class frmxTablas
    Dim IndexCellResaltada As Integer = -1 'Variable para seleccionar al pasar con el mouse

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
        lblIdTabla.Text = dgvTablas.SelectedCells.Item(1).Value
        lblTitulo.Text = "Registro de " & dgvTablas.SelectedCells.Item(2).Value
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

        Me.LimpiarDgvTabla()
    End Sub

    Private Sub dgvTablas_MouseLeave(sender As Object, e As EventArgs) Handles dgvTablas.MouseLeave
        Me.LimpiarDgvTabla()
    End Sub


    Function Listar_zxTablas() As DataTable
        Try
            Dim Neg As New Negocio.NxTablas
            dgvTablas.DataSource = Neg.Listar_Tablas()
            dgvTablas.ClearSelection()
            Me.Dimensionar_zxTablas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

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

    'Listado de tablas
    Private Sub Listar_xDocIden()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_DocIden()
            'Me.Dimensionar_xDocIden()
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
            'Me.Dimensionar_xDepartamento()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xProvincia()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Provincia()
            'Me.Dimensionar_xProvincia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xDistrito()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Distrito()
            'Me.Dimensionar_xDistrito()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar_xTipoVia()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_TipoVia()
            'Me.Dimensionar_xTipoVia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frmxTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar_xPais()
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
                txtIdTabla.Select()

            Case 3 ' Modificar
                Panel3.Visible = True
                TabControl1.Enabled = False
                lblGuardar.Text = "MODIFICAR"

            Case 4 'eleminar
                Panel3.Visible = True
                TabControl1.Enabled = False
                'dgvRegistros_CellDoubleClick(Nothing, Nothing)
                TabControl1.SelectedIndex = 4
                lblGuardar.Text = "ELIMINAR"

        End Select
    End Sub

    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.NxTablas
            Dim Valor As String
            Valor = Trim(dgvListado.SelectedCells.Item(0).Value)

            dgvCargarDatos.DataSource = Neg.CargarDatos_Pais(Valor)

            If dgvCargarDatos.Rows.Count <> 0 Then
                txtIdTabla.Text = dgvCargarDatos.SelectedCells.Item(0).Value
                txtNomTabla.Text = dgvCargarDatos.SelectedCells.Item(1).Value
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
    End Sub


End Class