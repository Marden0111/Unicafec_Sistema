Imports Unicafec.Negocio

Public Class frmxEntidades

    Private Sub xEnti_Listar()
        Try
            Dim Neg As New Negocio.NxEntidades
            dgvRegistrosListado.DataSource = Neg.Listar()
            Me.Dimensionar_xEnti()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dimensionar_xEnti()
        dgvRegistrosListado.Columns(0).HeaderText = "CODIGO"
        dgvRegistrosListado.Columns(1).HeaderText = "TIPO"
        dgvRegistrosListado.Columns(2).HeaderText = "NOMBRES Y/O RAZON SOCIAL"
        dgvRegistrosListado.Columns(3).Visible = False
        dgvRegistrosListado.Columns(4).HeaderText = "ABREVIATURA."
        dgvRegistrosListado.Columns(5).HeaderText = "Num.DOC"
        dgvRegistrosListado.Columns(6).HeaderText = "SOCIO"
        dgvRegistrosListado.Columns(7).HeaderText = "CLIENTE"
        dgvRegistrosListado.Columns(8).HeaderText = "PROVEEDOR"
        dgvRegistrosListado.Columns(9).HeaderText = "EMPLEADO"
        dgvRegistrosListado.Columns(10).HeaderText = "OTROS"
        dgvRegistrosListado.Columns(11).HeaderText = "INGRESO"
        dgvRegistrosListado.Columns(12).HeaderText = "FECHA"
        dgvRegistrosListado.Columns(13).HeaderText = "MODIFICACIÓN"
        dgvRegistrosListado.Columns(14).HeaderText = "FECHA"


        dgvRegistrosListado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRegistrosListado.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvRegistrosListado.Columns(0).Width = 90
        dgvRegistrosListado.Columns(1).Width = 55
        dgvRegistrosListado.Columns(2).Width = 200
        dgvRegistrosListado.Columns(3).Width = 65
        dgvRegistrosListado.Columns(4).Width = 90
        dgvRegistrosListado.Columns(5).Width = 90
        dgvRegistrosListado.Columns(6).Width = 50
        dgvRegistrosListado.Columns(7).Width = 60
        dgvRegistrosListado.Columns(8).Width = 80
        dgvRegistrosListado.Columns(9).Width = 70
        dgvRegistrosListado.Columns(10).Width = 50
        dgvRegistrosListado.Columns(11).Width = 100
        dgvRegistrosListado.Columns(12).Width = 90
        dgvRegistrosListado.Columns(13).Width = 100
    End Sub

    Private Sub frmxEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.xEnti_Listar()
    End Sub

    Private Sub frmxEntidades_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next

        TabControl1.Location = New Point(1, 2)
        TabControl1.Size = New Size(Me.Width - 20, 30)
        TabControl1.ItemSize = New Size((TabControl1.Width - 16) / 5, 21)

        Panel2.Location = New Point(2, 24)
        Panel2.Size = New Size(Me.Width - 25, Me.Height - 114)

        Panel3.Location = New Point(2, 26)
        Panel3.Size = New Size(Panel2.Width, Panel2.Height)
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Select Case TabControl1.SelectedIndex
            Case 0
                'por definir
            Case 1
                Panel3.Visible = True
                TabControl1.Enabled = False

            Case 2
                Panel3.Visible = True
                TabControl1.Enabled = False

            Case 3
                Panel3.Visible = True
                TabControl1.Enabled = False

            Case 4
                Panel3.Visible = True
                TabControl1.Enabled = False

        End Select
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Panel3.Visible = False
        TabControl1.SelectedIndex = 0
        TabControl1.Enabled = True
    End Sub

End Class