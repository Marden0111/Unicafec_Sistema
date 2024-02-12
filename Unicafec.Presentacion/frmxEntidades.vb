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

    Private Sub CargarDatos()
        On Error Resume Next

        Dim Neg As New Negocio.NxEntidades
        Dim Valor As String
        Valor = dgvRegistrosListado.SelectedCells.Item(0).Value
        dgvCargarDatos.DataSource = Neg.CargarDatos(Valor)

        txtIdEnti.Text = dgvRegistrosListado.SelectedCells.Item(0).Value
        lblTipo_Enti.Text = dgvRegistrosListado.SelectedCells.Item(1).Value
        txtNomEnti_RS.Text = dgvRegistrosListado.SelectedCells.Item(2).Value
        txtTip_DocIden.Text = dgvRegistrosListado.SelectedCells.Item(3).Value
        txtNom_DocIden.Text = dgvRegistrosListado.SelectedCells.Item(4).Value
        txtNum_DocIden.Text = dgvRegistrosListado.SelectedCells.Item(6).Value
        lblSocio.Text = dgvRegistrosListado.SelectedCells.Item(7).Value
        lblCliente.Text = dgvRegistrosListado.SelectedCells.Item(8).Value
        lblProveedor.Text = dgvRegistrosListado.SelectedCells.Item(9).Value
        lblEmpleado.Text = dgvRegistrosListado.SelectedCells.Item(10).Value
        lblOtros.Text = dgvRegistrosListado.SelectedCells.Item(11).Value

        If lblTipo_Enti.Text = "Empresa" Then
            rbtEmpresa.Checked = True
        ElseIf lblTipo_Enti.Text = "Persona" Then
            rbtPersona.Checked = True
        ElseIf lblTipo_Enti.Text = "Otros" Then
            rbtOtro.Checked = True
        End If

        If lblSocio.Text = "False" Then
            chbSocio.Checked = False
        ElseIf lblSocio.Text = "True" Then
            chbSocio.Checked = True
        End If

        If lblCliente.Text = "False" Then
            chbCliente.Checked = False
        ElseIf lblCliente.Text = "True" Then
            chbCliente.Checked = True
        End If

        If lblProveedor.Text = "False" Then
            chbProveedor.Checked = False
        ElseIf lblProveedor.Text = "True" Then
            chbProveedor.Checked = True
        End If

        If lblEmpleado.Text = "False" Then
            chbEmpleado.Checked = False
        ElseIf lblEmpleado.Text = "True" Then
            chbEmpleado.Checked = True
        End If

        If lblOtros.Text = "False" Then
            chbOtros.Checked = False
        ElseIf lblOtros.Text = "True" Then
            chbOtros.Checked = True
        End If

        lblTipo_Empr.Text = dgvCargarDatos.SelectedCells.Item(0).Value
        txtNombres.Text = dgvCargarDatos.SelectedCells.Item(1).Value
        txt1er_Apellido.Text = dgvCargarDatos.SelectedCells.Item(2).Value
        txt2do_Apellido.Text = dgvCargarDatos.SelectedCells.Item(3).Value
        txtNom_Comercial.Text = dgvCargarDatos.SelectedCells.Item(4).Value
        txtIdTVia.Text = dgvCargarDatos.SelectedCells.Item(5).Value
        txtNom_TVia.Text = dgvCargarDatos.SelectedCells.Item(6).Value
        txtNombre_Via.Text = dgvCargarDatos.SelectedCells.Item(7).Value
        txtNroVia.Text = dgvCargarDatos.SelectedCells.Item(8).Value
        txtInterior.Text = dgvCargarDatos.SelectedCells.Item(9).Value
        txtZona.Text = dgvCargarDatos.SelectedCells.Item(10).Value
        txtReferencia.Text = dgvCargarDatos.SelectedCells.Item(11).Value
        txtUbigeo.Text = dgvCargarDatos.SelectedCells.Item(12).Value
        txtIdPais.Text = dgvCargarDatos.SelectedCells.Item(13).Value
        txtNom_Pais.Text = dgvCargarDatos.SelectedCells.Item(14).Value
        txtIdDep.Text = dgvCargarDatos.SelectedCells.Item(15).Value
        txtNom_Dep.Text = dgvCargarDatos.SelectedCells.Item(16).Value
        txtIdProv.Text = dgvCargarDatos.SelectedCells.Item(17).Value
        txtNom_Prov.Text = dgvCargarDatos.SelectedCells.Item(18).Value
        txtIdDist = dgvCargarDatos.SelectedCells.Item(19).Value
        txtNom_Dist.Text = dgvCargarDatos.SelectedCells.Item(20).Value
        txtTelefono.Text = dgvCargarDatos.SelectedCells.Item(21).Value
        txtCelular.Text = dgvCargarDatos.SelectedCells.Item(22).Value
        txtCorreo.Text = dgvCargarDatos.SelectedCells.Item(23).Value
        txtObservaciones.Text = dgvCargarDatos.SelectedCells.Item(24).Value

        If lblTipo_Empr.Text = "Juridica" Then
            rbtJuridica.Checked = True
        ElseIf lblTipo_Empr.Text = "Natural" Then
            rbtNatural.Checked = True
        End If

    End Sub

    Private Sub Dimensionar_xEnti()
        dgvRegistrosListado.Columns(0).HeaderText = "CÓDIGO"
        dgvRegistrosListado.Columns(1).HeaderText = "TIPO"
        dgvRegistrosListado.Columns(2).HeaderText = "NOMBRES Y/O RAZON SOCIAL"
        dgvRegistrosListado.Columns(3).Visible = False
        dgvRegistrosListado.Columns(4).Visible = False
        dgvRegistrosListado.Columns(5).HeaderText = "ABREV."
        dgvRegistrosListado.Columns(6).HeaderText = "NUM. DOC"
        dgvRegistrosListado.Columns(7).HeaderText = "SOCIO"
        dgvRegistrosListado.Columns(8).HeaderText = "CLIENTE"
        dgvRegistrosListado.Columns(9).HeaderText = "PROVEEDOR"
        dgvRegistrosListado.Columns(10).HeaderText = "EMPLEADO"
        dgvRegistrosListado.Columns(11).HeaderText = "OTROS"
        dgvRegistrosListado.Columns(12).HeaderText = "INGRESO"
        dgvRegistrosListado.Columns(13).HeaderText = "FECHA"
        dgvRegistrosListado.Columns(14).HeaderText = "MODIFICACIÓN"
        dgvRegistrosListado.Columns(15).HeaderText = "FECHA"

        dgvRegistrosListado.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRegistrosListado.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvRegistrosListado.Columns(0).Width = 90
        dgvRegistrosListado.Columns(1).Width = 55
        dgvRegistrosListado.Columns(2).Width = 300
        dgvRegistrosListado.Columns(5).Width = 50
        dgvRegistrosListado.Columns(6).Width = 90
        dgvRegistrosListado.Columns(7).Width = 50
        dgvRegistrosListado.Columns(8).Width = 60
        dgvRegistrosListado.Columns(9).Width = 80
        dgvRegistrosListado.Columns(10).Width = 70
        dgvRegistrosListado.Columns(11).Width = 50
        dgvRegistrosListado.Columns(12).Width = 100
        dgvRegistrosListado.Columns(13).Width = 90
        dgvRegistrosListado.Columns(14).Width = 100
    End Sub

    Private Sub Visualizar_Campos_Empresa()
        gvoTipoEmpr.Visible = True

        If lblTipo_Empr.Text = "Juridica" Then

            Label3.Text = "Razón Social:"
            Label3.Visible = True
            txtNomEnti_RS.Left = 94
            txtNomEnti_RS.Width = 672
            txtNomEnti_RS.Visible = True

            Label4.Visible = False
            txtNombres.Visible = False
            Label5.Visible = False
            txt1er_Apellido.Visible = False
            Label6.Visible = False
            txt2do_Apellido.Visible = False

        ElseIf lblTipo_Empr.Text = "Natural" Then

            Label3.Visible = False
            txtNomEnti_RS.Visible = False

            Label4.Visible = True
            txtNombres.Visible = True
            Label5.Visible = True
            txt1er_Apellido.Visible = True
            Label6.Visible = True
            txt2do_Apellido.Visible = True

        End If

        Label7.Visible = True
        txtNom_Comercial.Visible = True

        Panel4.Location = New Point(15, 109)
        gvoDatosEnti.Height = 360
        govFuncionEnti.Height = 360
        btnGuardar.Top = 440
        btnCancelar.Top = 440

    End Sub

    Private Sub Visualizar_Campos_Personas()
        gvoTipoEmpr.Visible = False

        Label3.Visible = False
        txtNomEnti_RS.Visible = False

        Label4.Visible = True
        txtNombres.Visible = True
        Label5.Visible = True
        txt1er_Apellido.Visible = True
        Label6.Visible = True
        txt2do_Apellido.Visible = True

        Label7.Visible = False
        txtNom_Comercial.Visible = False

        Panel4.Location = New Point(15, 78)
        gvoDatosEnti.Height = 330
        govFuncionEnti.Height = 330
        btnGuardar.Top = 410
        btnCancelar.Top = 410
    End Sub

    Private Sub Visualizar_Campos_Otro()
        gvoTipoEmpr.Visible = False

        Label3.Text = "Nombre:"
        Label3.Visible = True
        txtNomEnti_RS.Left = 68
        txtNomEnti_RS.Width = 700
        txtNomEnti_RS.Visible = True

        Label4.Visible = False
        txtNombres.Visible = False
        Label5.Visible = False
        txt1er_Apellido.Visible = False
        Label6.Visible = False
        txt2do_Apellido.Visible = False

        Label7.Visible = False
        txtNom_Comercial.Visible = False

        Panel4.Location = New Point(15, 78)
        gvoDatosEnti.Height = 330
        govFuncionEnti.Height = 330
        btnGuardar.Top = 410
        btnCancelar.Top = 410
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
        Panel2.Size = New Size(Me.Width - 25, Me.Height - 110)

        Panel3.Location = New Point(2, 26)
        Panel3.Size = New Size(Panel2.Width, Panel2.Height)
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Select Case TabControl1.SelectedIndex

            Case 0 'Listar
                'por definir

            Case 1 ' Detalle
                Panel3.Visible = True
                TabControl1.Enabled = False
                CargarDatos()

            Case 2 'Nuevo
                Panel3.Visible = True
                TabControl1.Enabled = False

            Case 3 'Modificar
                Panel3.Visible = True
                TabControl1.Enabled = False
                CargarDatos()

            Case 4 'Eliminar
                Panel3.Visible = True
                TabControl1.Enabled = False
                CargarDatos()

        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If lblGuardar.Text = "Nuevo" Then



        ElseIf lblGuardar.Text = "Modificar" Then



        Else


        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        rbtEmpresa.Checked = True
        rbtPersona.Checked = False
        rbtOtro.Checked = False
        lblTipo_Enti.Text = "Empresa"

        rbtJuridica.Checked = True
        rbtNatural.Checked = False
        lblTipo_Empr.Text = "Juridica"

        txtIdEnti.Text = ""
        txtNomEnti_RS.Text = ""
        txtNombres.Text = ""
        txt1er_Apellido.Text = ""
        txt2do_Apellido.Text = ""
        txtNom_Comercial.Text = ""
        txtTip_DocIden.Text = ""
        txtNom_DocIden.Text = ""
        txtNum_DocIden.Text = ""
        txtIdTVia.Text = ""
        txtNom_TVia.Text = ""
        txtNombre_Via.Text = ""
        txtNroVia.Text = ""
        txtInterior.Text = ""
        txtZona.Text = ""
        txtIdPais.Text = ""
        txtNom_Pais.Text = ""
        txtIdDep.Text = ""
        txtNom_Dep.Text = ""
        txtIdProv.Text = ""
        txtNom_Prov.Text = ""
        txtIdDist.Text = ""
        txtNom_Dist.Text = ""


        lblSocio.Text = "False"
        lblCliente.Text = "False"
        lblProveedor.Text = "False"
        lblEmpleado.Text = "False"
        lblOtros.Text = "False"
        txtReferencia.Text = ""
        txtUbigeo.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
        txtObservaciones.Text = ""

        chbSocio.Checked = False
        chbCliente.Checked = False
        chbProveedor.Checked = False
        chbEmpleado.Checked = False
        chbOtros.Checked = False


        Panel3.Visible = False
        TabControl1.SelectedIndex = 0
        TabControl1.Enabled = True
    End Sub


    Private Sub dgvRegistrosListado_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistrosListado.DoubleClick
        Me.CargarDatos()

        TabControl1.SelectedIndex = 1
        Panel3.Visible = True
        TabControl1.Enabled = False

    End Sub

    Private Sub rbtEmpresa_Click(sender As Object, e As EventArgs) Handles rbtEmpresa.Click

        rbtEmpresa.Checked = True
        lblTipo_Enti.Text = "Empresa"
        rbtJuridica.Checked = True
        lblTipo_Empr.Text = "Juridica"
        Me.Visualizar_Campos_Empresa()

    End Sub

    Private Sub rbtPersona_Click(sender As Object, e As EventArgs) Handles rbtPersona.Click

        rbtPersona.Checked = True
        lblTipo_Enti.Text = "Persona"
        rbtNatural.Checked = True
        lblTipo_Empr.Text = "Natural"
        Me.Visualizar_Campos_Personas()

    End Sub

    Private Sub rbtOtro_Click(sender As Object, e As EventArgs) Handles rbtOtro.Click

        rbtOtro.Checked = True
        lblTipo_Enti.Text = "Otros"
        lblTipo_Empr.Text = "Otros"
        Me.Visualizar_Campos_Otro()

    End Sub

    Private Sub rbtJuridica_Click(sender As Object, e As EventArgs) Handles rbtJuridica.Click

        lblTipo_Empr.Text = "Juridica"
        Me.Visualizar_Campos_Empresa()

    End Sub

    Private Sub rbtNatural_Click(sender As Object, e As EventArgs) Handles rbtNatural.Click

        lblTipo_Empr.Text = "Natural"
        Me.Visualizar_Campos_Empresa()

    End Sub

    Private Sub chbSocio_Click(sender As Object, e As EventArgs) Handles chbSocio.Click
        If chbSocio.Checked Then
            lblSocio.Text = "True"
        Else
            lblSocio.Text = "False"
        End If
    End Sub

    Private Sub chbCliente_Click(sender As Object, e As EventArgs) Handles chbCliente.Click
        If chbCliente.Checked Then
            lblCliente.Text = "True"
        Else
            lblCliente.Text = "False"
        End If
    End Sub

    Private Sub chbProveedor_Click(sender As Object, e As EventArgs) Handles chbProveedor.Click
        If chbProveedor.Checked Then
            lblProveedor.Text = "True"
        Else
            lblProveedor.Text = "False"
        End If
    End Sub

    Private Sub chbEmpleado_Click(sender As Object, e As EventArgs) Handles chbEmpleado.Click
        If chbEmpleado.Checked Then
            lblEmpleado.Text = "True"
        Else
            lblEmpleado.Text = "False"
        End If
    End Sub

    Private Sub chbOtros_Click(sender As Object, e As EventArgs) Handles chbOtros.Click
        If chbOtros.Checked Then
            lblOtros.Text = "True"
        Else
            lblOtros.Text = "False"
        End If
    End Sub

#Region "Caja de texto IdEnti"
    Private Sub txtIdEnti_Click(sender As Object, e As EventArgs) Handles txtIdEnti.Click

        txtIdEnti.SelectionStart = 0
        txtIdEnti.SelectionLength = txtIdEnti.Text.Length

    End Sub

    Private Sub txtIdEnti_GotFocus(sender As Object, e As EventArgs) Handles txtIdEnti.GotFocus

        txtIdEnti.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdEnti_LostFocus(sender As Object, e As EventArgs) Handles txtIdEnti.LostFocus

        txtIdEnti.BackColor = Color.White

    End Sub

    Private Sub txtIdEnti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdEnti.KeyPress
        'Función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '----------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Si la p¿tecla presionada es un Enter

            If (lblTipo_Enti.Text = "Empresa" And lblTipo_Empr.Text = "Juridica") Or lblTipo_Enti.Text = "Otros" Then
                txtNomEnti_RS.Select()
                txtNomEnti_RS.SelectionStart = 0
                txtNomEnti_RS.SelectionLength = txtNomEnti_RS.Text.Length

            ElseIf (lblTipo_Enti.Text = "Empresa" And lblTipo_Empr.Text = "Natural") Or lblTipo_Enti.Text = "Persona" Then
                txtNombres.Select()
                txtNombres.SelectionStart = 0
                txtNombres.SelectionLength = txtNombres.Text.Length

            End If
            e.Handled = True 'Linea para quitar ek pitido del enter

        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO NOMENTI_RS"
    Private Sub txtNomEnti_RS_Click(sender As Object, e As EventArgs) Handles txtNomEnti_RS.Click
        txtNomEnti_RS.SelectionStart = 0
        txtNomEnti_RS.SelectionLength = txtNomEnti_RS.Text.Length
    End Sub

    Private Sub txtNomEnti_RS_GotFocus(sender As Object, e As EventArgs) Handles txtNomEnti_RS.GotFocus

        txtNomEnti_RS.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNomEnti_RS_LostFocus(sender As Object, e As EventArgs) Handles txtNomEnti_RS.LostFocus

        txtNomEnti_RS.BackColor = Color.White

    End Sub

    Private Sub txtNomEnti_RS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomEnti_RS.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter

            If (lblTipo_Enti.Text = "Empresa" And lblTipo_Empr.Text = "Juridica") Then
                txtNom_Comercial.Select()
                txtNom_Comercial.SelectionStart = 0
                txtNom_Comercial.SelectionLength = txtNom_Comercial.Text.Length

            ElseIf lblTipo_Enti.Text = "Otros" Then
                txtTip_DocIden.Select()
                txtTip_DocIden.SelectionStart = 0
                txtTip_DocIden.SelectionLength = txtTip_DocIden.Text.Length

            End If

            e.Handled = True 'Quita el pitido de presionar el Enter

        End If

    End Sub

#End Region

#Region "CAJA DE TEXTO NOM_COMERCIAL"
    Private Sub txtNom_Comercial_Click(sender As Object, e As EventArgs) Handles txtNom_Comercial.Click

        txtNom_Comercial.SelectionStart = 0
        txtNom_Comercial.SelectionLength = txtNom_Comercial.Text.Length

    End Sub

    Private Sub txtNom_Comercial_GotFocus(sender As Object, e As EventArgs) Handles txtNom_Comercial.GotFocus

        txtNom_Comercial.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNom_Comercial_LostFocus(sender As Object, e As EventArgs) Handles txtNom_Comercial.LostFocus

        txtNom_Comercial.BackColor = Color.White

    End Sub

    Private Sub txtNom_Comercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Comercial.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtTip_DocIden.Select()
            txtTip_DocIden.SelectionStart = 0
            txtTip_DocIden.SelectionLength = txtTip_DocIden.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter

        End If

    End Sub

#End Region

#Region "CAJA DE TEXTO NOMBRES"
    Private Sub txtNombres_Click(sender As Object, e As EventArgs) Handles txtNombres.Click

        txtNombres.SelectionStart = 0
        txtNombres.SelectionLength = txtNombres.Text.Length

    End Sub

    Private Sub txtNombres_GotFocus(sender As Object, e As EventArgs) Handles txtNombres.GotFocus

        txtNombres.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNombres_LostFocus(sender As Object, e As EventArgs) Handles txtNombres.LostFocus

        txtNombres.BackColor = Color.White

    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            txt1er_Apellido.Select()
            txt1er_Apellido.SelectionStart = 0
            txt1er_Apellido.SelectionLength = txt1er_Apellido.Text.Length

            e.Handled = True

        End If

    End Sub

#End Region

#Region "CAJA DE TEXTO 1ER_APELLIDO"
    Private Sub txt1er_Apellido_Click(sender As Object, e As EventArgs) Handles txt1er_Apellido.Click

        txt1er_Apellido.SelectionStart = 0
        txt1er_Apellido.SelectionLength = txt1er_Apellido.Text.Length

    End Sub

    Private Sub txt1er_Apellido_GotFocus(sender As Object, e As EventArgs) Handles txt1er_Apellido.GotFocus

        txt1er_Apellido.BackColor = Color.LightYellow

    End Sub

    Private Sub txt1er_Apellido_LostFocus(sender As Object, e As EventArgs) Handles txt1er_Apellido.LostFocus

        txt1er_Apellido.BackColor = Color.White

    End Sub

    Private Sub txt1er_Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1er_Apellido.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            txt2do_Apellido.Select()
            txt2do_Apellido.SelectionStart = 0
            txt2do_Apellido.SelectionLength = txt2do_Apellido.Text.Length

            e.Handled = True

        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO 2DO_APELLIDO"
    Private Sub txt2do_Apellido_Click(sender As Object, e As EventArgs) Handles txt2do_Apellido.Click

        txt2do_Apellido.SelectionStart = 0
        txt2do_Apellido.SelectionLength = txt2do_Apellido.Text.Length

    End Sub

    Private Sub txt2do_Apellido_GotFocus(sender As Object, e As EventArgs) Handles txt2do_Apellido.GotFocus

        txt2do_Apellido.BackColor = Color.LightYellow

    End Sub

    Private Sub txt2do_Apellido_LostFocus(sender As Object, e As EventArgs) Handles txt2do_Apellido.LostFocus

        txt2do_Apellido.BackColor = Color.White

    End Sub

    Private Sub txt2do_Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2do_Apellido.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            If (lblTipo_Enti.Text = "Empresa" And lblTipo_Empr.Text = "Natural") Then
                txtNom_Comercial.Select()
                txtNom_Comercial.SelectionStart = 0
                txtNom_Comercial.SelectionLength = txtNom_Comercial.Text.Length

            ElseIf lblTipo_Enti.Text = "Persona" Then
                txtTip_DocIden.Select()
                txtTip_DocIden.SelectionStart = 0
                txtTip_DocIden.SelectionLength = txtTip_DocIden.Text.Length

            End If
            e.Handled = True

        End If


    End Sub

#End Region

#Region "CAJA DE TEXTO TIPO_DOCIDEN"
    Private Sub txtTip_DocIden_Click(sender As Object, e As EventArgs) Handles txtTip_DocIden.Click

        txtTip_DocIden.SelectionStart = 0
        txtTip_DocIden.SelectionLength = txtTip_DocIden.Text.Length

    End Sub

    Private Sub txtTip_DocIden_GotFocus(sender As Object, e As EventArgs) Handles txtTip_DocIden.GotFocus

        txtTip_DocIden.BackColor = Color.LightYellow

    End Sub

    Private Sub txtTip_DocIden_LostFocus(sender As Object, e As EventArgs) Handles txtTip_DocIden.LostFocus

        If txtTip_DocIden.Text <> "" Then
            txtTip_DocIden.Text = Format(CLng(txtTip_DocIden.Text), "000")
        End If

        txtTip_DocIden.BackColor = Color.White

    End Sub

    Private Sub txtTip_DocIden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTip_DocIden.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtNum_DocIden.Select()
            txtNum_DocIden.SelectionStart = 0
            txtNum_DocIden.SelectionLength = txtNum_DocIden.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub

#End Region

#Region "CAJA DE TEXTO TIPO_NUM_DOCIDEN"
    Private Sub txtNum_DocIden_Click(sender As Object, e As EventArgs) Handles txtNum_DocIden.Click

        txtNum_DocIden.SelectionStart = 0
        txtNum_DocIden.SelectionLength = txtNum_DocIden.Text.Length

    End Sub

    Private Sub txtNum_DocIden_GotFocus(sender As Object, e As EventArgs) Handles txtNum_DocIden.GotFocus

        txtNum_DocIden.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNum_DocIden_LostFocus(sender As Object, e As EventArgs) Handles txtNum_DocIden.LostFocus

        txtNum_DocIden.BackColor = Color.White

    End Sub

    Private Sub txtNum_DocIden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_DocIden.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtIdTVia.Select()
            txtIdTVia.SelectionStart = 0
            txtIdTVia.SelectionLength = txtIdTVia.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO TIPO_VIA"
    Private Sub txtIdTVia_Click(sender As Object, e As EventArgs) Handles txtIdTVia.Click

        txtIdTVia.SelectionStart = 0
        txtIdTVia.SelectionLength = txtIdTVia.Text.Length

    End Sub

    Private Sub txtIdTVia_GotFocus(sender As Object, e As EventArgs) Handles txtIdTVia.GotFocus

        txtIdTVia.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdTVia_LostFocus(sender As Object, e As EventArgs) Handles txtIdTVia.LostFocus

        If txtIdTVia.Text <> "" Then
            txtIdTVia.Text = Format(CLng(txtIdTVia.Text), "000")
        End If

        txtIdTVia.BackColor = Color.White

    End Sub

    Private Sub txtIdTVia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdTVia.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtNombre_Via.Select()
            txtNombre_Via.SelectionStart = 0
            txtNombre_Via.SelectionLength = txtNombre_Via.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO NOMBRE_VIA"
    Private Sub txtNombre_Via_Click(sender As Object, e As EventArgs) Handles txtNombre_Via.Click

        txtNombre_Via.SelectionStart = 0
        txtNombre_Via.SelectionLength = txtNombre_Via.Text.Length

    End Sub

    Private Sub txtNombre_Via_GotFocus(sender As Object, e As EventArgs) Handles txtNombre_Via.GotFocus

        txtNombre_Via.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNombre_Via_LostFocus(sender As Object, e As EventArgs) Handles txtNombre_Via.LostFocus

        txtNombre_Via.BackColor = Color.White

    End Sub

    Private Sub txtNombre_Via_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre_Via.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtNroVia.Select()
            txtNroVia.SelectionStart = 0
            txtNroVia.SelectionLength = txtInterior.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO NRO"
    Private Sub txtNroVia_Click(sender As Object, e As EventArgs) Handles txtNroVia.Click

        txtNroVia.SelectionStart = 0
        txtNroVia.SelectionLength = txtNroVia.Text.Length

    End Sub

    Private Sub txtNroVia_GotFocus(sender As Object, e As EventArgs) Handles txtNroVia.GotFocus

        txtNroVia.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNroVia_LostFocus(sender As Object, e As EventArgs) Handles txtNroVia.LostFocus

        txtNroVia.BackColor = Color.White

    End Sub

    Private Sub txtNroVia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroVia.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtInterior.Select()
            txtInterior.SelectionStart = 0
            txtInterior.SelectionLength = txtNroVia.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO INETRIOR"
    Private Sub txtInterior_Click(sender As Object, e As EventArgs) Handles txtInterior.Click

        txtInterior.SelectionStart = 0
        txtInterior.SelectionLength = txtInterior.Text.Length

    End Sub

    Private Sub txtInterior_GotFocus(sender As Object, e As EventArgs) Handles txtInterior.GotFocus

        txtInterior.BackColor = Color.LightYellow

    End Sub

    Private Sub txtInterior_LostFocus(sender As Object, e As EventArgs) Handles txtInterior.LostFocus

        txtInterior.BackColor = Color.White

    End Sub

    Private Sub txtInterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInterior.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtZona.Select()
            txtZona.SelectionStart = 0
            txtZona.SelectionLength = txtZona.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO ZONA"
    Private Sub txtZona_Click(sender As Object, e As EventArgs) Handles txtZona.Click

        txtZona.SelectionStart = 0
        txtZona.SelectionLength = txtZona.Text.Length

    End Sub

    Private Sub txtZona_GotFocus(sender As Object, e As EventArgs) Handles txtZona.GotFocus

        txtZona.BackColor = Color.LightYellow

    End Sub

    Private Sub txtZona_LostFocus(sender As Object, e As EventArgs) Handles txtZona.LostFocus

        txtZona.BackColor = Color.White

    End Sub

    Private Sub txtZona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZona.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtIdPais.Select()
            txtIdPais.SelectionStart = 0
            txtIdPais.SelectionLength = txtIdPais.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO ID_PAIS"
    Private Sub txtIdPais_Click(sender As Object, e As EventArgs) Handles txtIdPais.Click

        txtIdPais.SelectionStart = 0
        txtIdPais.SelectionLength = txtIdPais.Text.Length

    End Sub

    Private Sub txtIdPais_GotFocus(sender As Object, e As EventArgs) Handles txtIdPais.GotFocus

        txtIdPais.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdPais_LostFocus(sender As Object, e As EventArgs) Handles txtIdPais.LostFocus

        If txtIdPais.Text <> "" Then
            txtIdPais.Text = Format(CLng(txtIdPais.Text), "000000")
        End If

        txtIdPais.BackColor = Color.White

    End Sub

    Private Sub txtIdPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPais.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtIdDep.Select()
            txtIdDep.SelectionStart = 0
            txtIdDep.SelectionLength = txtIdDep.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO ID_DEPARTAMENTO"
    Private Sub txtIdDep_Click(sender As Object, e As EventArgs) Handles txtIdDep.Click

        txtIdDep.SelectionStart = 0
        txtIdDep.SelectionLength = txtIdDep.Text.Length

    End Sub

    Private Sub txtIdDep_GotFocus(sender As Object, e As EventArgs) Handles txtIdDep.GotFocus

        txtIdDep.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdDep_LostFocus(sender As Object, e As EventArgs) Handles txtIdDep.LostFocus

        If txtIdDep.Text <> "" Then
            txtIdDep.Text = Format(CLng(txtIdDep.Text), "000")
        End If

        txtIdDep.BackColor = Color.White

    End Sub

    Private Sub txtIdDep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDep.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtIdProv.Select()
            txtIdProv.SelectionStart = 0
            txtIdProv.SelectionLength = txtIdProv.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO ID_PROVINCIA"
    Private Sub txtIdProv_Click(sender As Object, e As EventArgs) Handles txtIdProv.Click

        txtIdProv.SelectionStart = 0
        txtIdProv.SelectionLength = txtIdProv.Text.Length

    End Sub

    Private Sub txtIdProv_GotFocus(sender As Object, e As EventArgs) Handles txtIdProv.GotFocus

        txtIdProv.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdProv_LostFocus(sender As Object, e As EventArgs) Handles txtIdProv.LostFocus

        If txtIdProv.Text <> "" Then
            txtIdProv.Text = Format(CLng(txtIdProv.Text), "0000")
        End If

        txtIdProv.BackColor = Color.White

    End Sub

    Private Sub txtIdProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProv.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtIdDist.Select()
            txtIdDist.SelectionStart = 0
            txtIdDist.SelectionLength = txtIdDist.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO ID_DISTRITO"
    Private Sub txtIdDist_Click(sender As Object, e As EventArgs) Handles txtIdDist.Click

        txtIdDist.SelectionStart = 0
        txtIdDist.SelectionLength = txtIdDist.Text.Length

    End Sub

    Private Sub txtIdDist_GotFocus(sender As Object, e As EventArgs) Handles txtIdDist.GotFocus

        txtIdDist.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdDist_LostFocus(sender As Object, e As EventArgs) Handles txtIdDist.LostFocus

        If txtIdDist.Text <> "" Then
            txtIdDist.Text = Format(CLng(txtIdDist.Text), "0000")
        End If

        txtIdDist.BackColor = Color.White

    End Sub

    Private Sub txtIdDist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDist.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtUbigeo.Select()
            txtUbigeo.SelectionStart = 0
            txtUbigeo.SelectionLength = txtUbigeo.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO UBIGEO"
    Private Sub txtUbigeo_Click(sender As Object, e As EventArgs) Handles txtUbigeo.Click

        txtUbigeo.SelectionStart = 0
        txtUbigeo.SelectionLength = txtUbigeo.Text.Length

    End Sub

    Private Sub txtUbigeo_GotFocus(sender As Object, e As EventArgs) Handles txtUbigeo.GotFocus

        txtUbigeo.BackColor = Color.LightYellow

    End Sub

    Private Sub txtUbigeo_LostFocus(sender As Object, e As EventArgs) Handles txtUbigeo.LostFocus

        txtUbigeo.BackColor = Color.White

    End Sub

    Private Sub txtUbigeo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUbigeo.KeyPress
        'función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If
        '-------------------------------------------

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtReferencia.Select()
            txtReferencia.SelectionStart = 0
            txtReferencia.SelectionLength = txtReferencia.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO REFERENCIA"
    Private Sub txtReferencia_Click(sender As Object, e As EventArgs) Handles txtReferencia.Click

        txtReferencia.SelectionStart = 0
        txtReferencia.SelectionLength = txtReferencia.Text.Length

    End Sub

    Private Sub txtReferencia_GotFocus(sender As Object, e As EventArgs) Handles txtReferencia.GotFocus

        txtReferencia.BackColor = Color.LightYellow

    End Sub

    Private Sub txtReferencia_LostFocus(sender As Object, e As EventArgs) Handles txtReferencia.LostFocus

        txtReferencia.BackColor = Color.White

    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtTelefono.Select()
            txtTelefono.SelectionStart = 0
            txtTelefono.SelectionLength = txtTelefono.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO TELEFONO"
    Private Sub txtTelefono_Click(sender As Object, e As EventArgs) Handles txtTelefono.Click

        txtTelefono.SelectionStart = 0
        txtTelefono.SelectionLength = txtTelefono.Text.Length

    End Sub

    Private Sub txtTelefono_GotFocus(sender As Object, e As EventArgs) Handles txtTelefono.GotFocus

        txtTelefono.BackColor = Color.LightYellow

    End Sub

    Private Sub txtTelefono_LostFocus(sender As Object, e As EventArgs) Handles txtTelefono.LostFocus

        txtTelefono.BackColor = Color.White

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtCelular.Select()
            txtCelular.SelectionStart = 0
            txtCelular.SelectionLength = txtCelular.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO CELULAR"

    Private Sub txtCelular_Click(sender As Object, e As EventArgs) Handles txtCelular.Click

        txtCelular.SelectionStart = 0
        txtCelular.SelectionLength = txtCelular.Text.Length

    End Sub

    Private Sub txtCelular_GotFocus(sender As Object, e As EventArgs) Handles txtCelular.GotFocus

        txtCelular.BackColor = Color.LightYellow

    End Sub

    Private Sub txtCelular_LostFocus(sender As Object, e As EventArgs) Handles txtCelular.LostFocus

        txtCelular.BackColor = Color.White

    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtCorreo.Select()
            txtCorreo.SelectionStart = 0
            txtCorreo.SelectionLength = txtCorreo.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO MAIL"
    Private Sub txtCorreo_Click(sender As Object, e As EventArgs) Handles txtCorreo.Click

        txtCorreo.SelectionStart = 0
        txtCorreo.SelectionLength = txtCorreo.Text.Length

    End Sub

    Private Sub txtCorreo_GotFocus(sender As Object, e As EventArgs) Handles txtCorreo.GotFocus

        txtCorreo.BackColor = Color.LightYellow

    End Sub

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus

        txtCorreo.BackColor = Color.White

    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            txtObservaciones.Select()
            txtObservaciones.SelectionStart = 0
            txtObservaciones.SelectionLength = txtObservaciones.Text.Length

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If

    End Sub
#End Region

#Region "CAJA DE TEXTO OBSERVACIONES"
    Private Sub txtObservaciones_Click(sender As Object, e As EventArgs) Handles txtObservaciones.Click

        txtObservaciones.SelectionStart = 0
        txtObservaciones.SelectionLength = txtObservaciones.Text.Length

    End Sub

    Private Sub txtObservaciones_GotFocus(sender As Object, e As EventArgs) Handles txtObservaciones.GotFocus

        txtObservaciones.BackColor = Color.LightYellow

    End Sub

    Private Sub txtObservaciones_LostFocus(sender As Object, e As EventArgs) Handles txtObservaciones.LostFocus

        txtObservaciones.BackColor = Color.White

    End Sub

    Private Sub txtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'Se activa si se presiona Enter
            btnGuardar.Select()

            e.Handled = True 'Quita el pitido de presionar el Enter
        End If
    End Sub
#End Region




#Region "texbox de los combobox"
    Private Sub txtNom_DocIden_Click(sender As Object, e As EventArgs) Handles txtNom_DocIden.Click

        txtNom_DocIden.SelectionStart = 0
        txtNom_DocIden.SelectionLength = txtNom_DocIden.Text.Length
        'picbxDocIden.BackColor = Color.FromArgb(229, 241, 251)
        Me.picbxDocIden_Click(Nothing, Nothing)

    End Sub

    Private Sub txtNom_TVia_Click(sender As Object, e As EventArgs) Handles txtNom_TVia.Click
        txtNom_TVia.SelectionStart = 0
        txtNom_TVia.SelectionLength = txtNom_TVia.Text.Length
        Me.picbxTVia_Click(Nothing, Nothing)
    End Sub

    Private Sub txtNom_Pais_Click(sender As Object, e As EventArgs) Handles txtNom_Pais.Click
        txtNom_Pais.SelectionStart = 0
        txtNom_Pais.SelectionLength = txtNom_Pais.Text.Length
        Me.picbxPais_Click(Nothing, Nothing)
    End Sub

    Private Sub txtNom_Dep_Click(sender As Object, e As EventArgs) Handles txtNom_Dep.Click
        txtNom_Dep.SelectionStart = 0
        txtNom_Dep.SelectionLength = txtNom_Dep.Text.Length
        Me.picbxDep_Click(Nothing, Nothing)
    End Sub

    Private Sub txtNom_Prov_Click(sender As Object, e As EventArgs) Handles txtNom_Prov.Click
        txtNom_Prov.SelectionStart = 0
        txtNom_Prov.SelectionLength = txtNom_Prov.Text.Length
        Me.picbxProv_Click(Nothing, Nothing)
    End Sub

    Private Sub txtNom_Dist_Click(sender As Object, e As EventArgs) Handles txtNom_Dist.Click
        txtNom_Dist.SelectionStart = 0
        txtNom_Dist.SelectionLength = txtNom_Dist.Text.Length
        Me.picbxDist_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "botones de los texbox"
    Private Sub picbxDocIden_MouseEnter(sender As Object, e As EventArgs) Handles picbxDocIden.MouseEnter

        picbxDocIden.BackColor = Color.FromArgb(229, 241, 255)

    End Sub

    Private Sub picbxDocIden_MouseLeave(sender As Object, e As EventArgs) Handles picbxDocIden.MouseLeave

        picbxDocIden.BackColor = Color.White

    End Sub

    Private Sub picbxDocIden_Click(sender As Object, e As EventArgs) Handles picbxDocIden.Click

        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_DocIden.Left, (txtNom_DocIden.Top + txtNom_DocIden.Height))
            dgvListarCombo.Size = New Size(Me.txtNom_DocIden.Width, 180)
            txtNom_DocIden.Select()

        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(250, 235)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False

        End If

    End Sub

    Private Sub picbxTVia_MouseEnter(sender As Object, e As EventArgs) Handles picbxTVia.MouseEnter

        picbxTVia.BackColor = Color.FromArgb(229, 241, 255)

    End Sub

    Private Sub picbxTVia_MouseLeave(sender As Object, e As EventArgs) Handles picbxTVia.MouseLeave

        picbxTVia.BackColor = Color.White

    End Sub

    Private Sub picbxTVia_Click(sender As Object, e As EventArgs) Handles picbxTVia.Click
        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_TVia.Left, (txtNom_TVia.Top + txtNom_TVia.Height))
            dgvListarCombo.Size = New Size(txtNom_TVia.Width, 180)
            txtNom_TVia.Select()
        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(88, 205)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False
        End If
    End Sub

    Private Sub picbxPais_MouseEnter(sender As Object, e As EventArgs) Handles picbxPais.MouseEnter

        picbxPais.BackColor = Color.FromArgb(229, 241, 255)

    End Sub

    Private Sub picbxPais_MouseLeave(sender As Object, e As EventArgs) Handles picbxPais.MouseLeave

        picbxPais.BackColor = Color.White

    End Sub

    Private Sub picbxPais_Click(sender As Object, e As EventArgs) Handles picbxPais.Click
        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_Pais.Left, (txtNom_Pais.Top + txtNom_Pais.Height))
            dgvListarCombo.Size = New Size(txtNom_Pais.Width, 180)
            txtNom_Pais.Select()
        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(88, 205)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False
        End If
    End Sub

    Private Sub picbxDep_MouseEnter(sender As Object, e As EventArgs) Handles picbxDep.MouseEnter
        picbxDep.BackColor = Color.FromArgb(229, 241, 255)
    End Sub

    Private Sub picbxDep_MouseLeave(sender As Object, e As EventArgs) Handles picbxDep.MouseLeave
        picbxDep.BackColor = Color.White
    End Sub

    Private Sub picbxDep_Click(sender As Object, e As EventArgs) Handles picbxDep.Click
        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_Dep.Left, (txtNom_Dep.Top + txtNom_Dep.Height))
            dgvListarCombo.Size = New Size(txtNom_Dep.Width, 180)
            txtNom_Dep.Select()
        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(88, 205)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False
        End If
    End Sub

    Private Sub picbxProv_MouseEnter(sender As Object, e As EventArgs) Handles picbxProv.MouseEnter
        picbxProv.BackColor = Color.FromArgb(229, 241, 255)
    End Sub

    Private Sub picbxProv_MouseLeave(sender As Object, e As EventArgs) Handles picbxProv.MouseLeave
        picbxProv.BackColor = Color.White
    End Sub

    Private Sub picbxProv_Click(sender As Object, e As EventArgs) Handles picbxProv.Click
        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_Prov.Left, (txtNom_Prov.Top + txtNom_Prov.Height))
            dgvListarCombo.Size = New Size(txtNom_Prov.Width, 180)
            txtNom_Prov.Select()
        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(88, 205)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False
        End If
    End Sub

    Private Sub picbxDist_MouseEnter(sender As Object, e As EventArgs) Handles picbxDist.MouseEnter
        picbxDist.BackColor = Color.FromArgb(229, 241, 255)
    End Sub

    Private Sub picbxDist_MouseLeave(sender As Object, e As EventArgs) Handles picbxDist.MouseLeave
        picbxDist.BackColor = Color.White
    End Sub

    Private Sub picbxDist_Click(sender As Object, e As EventArgs) Handles picbxDist.Click
        If dgvListarCombo.Visible = False Then
            dgvListarCombo.Visible = True
            dgvListarCombo.Location = New Point(txtNom_Dist.Left, (txtNom_Dist.Top + txtNom_Dist.Height))
            dgvListarCombo.Size = New Size(txtNom_Dist.Width, 180)
            txtNom_Dist.Select()
        ElseIf dgvListarCombo.Visible = True Then
            dgvListarCombo.Location = New Point(88, 205)
            dgvListarCombo.Size = New Size(90, 30)
            'dgvListarCombo.DataSource = Nothing
            'dgvListarCombo.Rows.Clear()
            dgvListarCombo.Visible = False
        End If
    End Sub

#End Region

End Class