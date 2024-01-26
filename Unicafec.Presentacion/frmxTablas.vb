Public Class frmxTablas

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

    Private Sub Listar_xPais()
        Try
            Dim Neg As New Negocio.NxTablas
            dgvListado.DataSource = Neg.Listar_Pais()
            Me.Dimensionar_xPais()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmxPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Listar_xPais()

    End Sub

    Private Sub frmxPais_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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

    Private Sub dgvRegistros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
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


    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        If dgvTablas.Visible = False Then
            dgvTablas.Visible = True
            dgvTablas.Location = New Point(GroupBox1.Left + 5, GroupBox1.Top + 28)
            dgvTablas.Size = New Size(Me.lblTablas.Width, 400)
            'Me.Listar_xDocIden()
            'Me.Dimensionar_DocIden()
            'dgvDocIden.Visible = True
            'dgvDocIden.Select()
        ElseIf dgvTablas.Visible = True Then
            dgvTablas.Visible = False
        End If
    End Sub

    Private Sub lblTablas_Click(sender As Object, e As EventArgs) Handles lblTablas.Click
        Me.btnTablas_Click(Nothing, Nothing)
    End Sub
End Class