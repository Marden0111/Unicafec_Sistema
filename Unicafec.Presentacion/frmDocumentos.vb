Imports System.Reflection

Public Class frmDocumentos

    Private Sub xDocumntos_Listar()
        Try
            Dim Neg As New Negocio.NxDocumentos
            dgvRegistrosListado.DataSource = Neg.ListarDocuemtnos
            Me.Dimensionar_xEnti()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub xDocumentos_Insertar()
        Try
            Dim Obj As New Entidades.xDocumentos
            Dim Neg As New Negocio.NxDocumentos

            Obj.IdDoc = txtIdDoc.Text
            Obj.NomDoc = txtNomDoc.Text
            Obj.Abrevt = txtAbrevt.Text
            Obj.Vencimiento = If(chbVencimiento.Checked = True, True, False)
            Obj.Referencia = If(chbReferencia.Checked = True, True, False)
            Obj.IdMePa = txtIdMePa.Text
            Obj.UserIngre = "ADMINIST" 'FALTA RELACIONARLO CON VARIABLES DEL ID USUARIO Q SE RECIBE DEL LOGIN 
            Obj.FechaIngre = DateAndTime.Now.ToLocalTime

            If (Neg.InsertarDocuemtnos(Obj)) Then
                'MsgBox("Se a registrado Correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                Me.xDocumntos_Listar()
            Else
                MsgBox("Hubo una falla en el registro", vbOKOnly + vbCritical, "Acción Fallida")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub xEnti_Actualizar()
        Try
            Dim Obj As New Entidades.xDocumentos
            Dim Neg As New Negocio.NxDocumentos

            Obj.IdDoc = txtIdDoc.Text
            Obj.NomDoc = txtNomDoc.Text
            Obj.Abrevt = txtAbrevt.Text
            Obj.Vencimiento = If(chbVencimiento.Checked = True, True, False)
            Obj.Referencia = If(chbReferencia.Checked = True, True, False)
            Obj.IdMePa = txtIdMePa.Text
            Obj.UserModif = "ADMINIST" 'FALTA RELACIONARLO CON VARIABLES DEL ID USUARIO Q SE RECIBE DEL LOGIN 
            Obj.FechaModif = DateAndTime.Now.ToLocalTime

            If (Neg.ActualizarDocuemtnos(Obj)) Then
                'MsgBox("Se a registrado Correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                Me.xDocumntos_Listar()
            Else
                MsgBox("Hubo una falla en el registro", vbOKOnly + vbCritical, "Acción Fallida")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub xEnti_Eliminar()

        Dim Neg As New Negocio.NxDocumentos
        Neg.EliminarDocuemtnos(Trim(txtIdDoc.Text))

    End Sub

    Private Sub CargarDatos()
        On Error Resume Next

        txtIdDoc.Text = dgvRegistrosListado.SelectedCells.Item(0).Value
        txtNomDoc.Text = dgvRegistrosListado.SelectedCells.Item(1).Value
        txtAbrevt.Text = dgvRegistrosListado.SelectedCells.Item(2).Value
        chbVencimiento.Checked = If(dgvRegistrosListado.SelectedCells.Item(3).Value = True, True, False)
        chbReferencia.Checked = If(dgvRegistrosListado.SelectedCells.Item(4).Value = True, True, False)

        If (lblGuardar.Text = "Detalle" Or lblGuardar.Text = "Eliminar") Then
            Panel4.Visible = True
            Panel5.Visible = True

            lblUserIngre.Text = dgvRegistrosListado.SelectedCells.Item(6).Value
            lblFechaIngre.Text = dgvRegistrosListado.SelectedCells.Item(7).Value

            lblUserModif.Text = dgvRegistrosListado.SelectedCells.Item(8).Value
            lblFechaModif.Text = dgvRegistrosListado.SelectedCells.Item(9).Value
        End If


    End Sub

    Private Sub Dimensionar_xEnti()
        dgvRegistrosListado.Columns(0).HeaderText = "CÓDIGO"
        dgvRegistrosListado.Columns(1).HeaderText = "NOMBRE"
        dgvRegistrosListado.Columns(2).HeaderText = "ABREVIATURA"
        dgvRegistrosListado.Columns(3).HeaderText = "VENCIMIENTO"
        dgvRegistrosListado.Columns(4).HeaderText = "REFERENCIA"
        dgvRegistrosListado.Columns(5).Visible = False
        dgvRegistrosListado.Columns(6).HeaderText = "INGRESADO"
        dgvRegistrosListado.Columns(7).HeaderText = "FECHA"
        dgvRegistrosListado.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRegistrosListado.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss"
        dgvRegistrosListado.Columns(8).HeaderText = "MODIFICADO"
        dgvRegistrosListado.Columns(9).HeaderText = "FECHA"
        dgvRegistrosListado.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRegistrosListado.Columns(9).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss"

        dgvRegistrosListado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRegistrosListado.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvRegistrosListado.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvRegistrosListado.Columns(0).Width = 70
        dgvRegistrosListado.Columns(1).Width = 400
        dgvRegistrosListado.Columns(2).Width = 90
        dgvRegistrosListado.Columns(3).Width = 90
        dgvRegistrosListado.Columns(4).Width = 90
        dgvRegistrosListado.Columns(6).Width = 95
        dgvRegistrosListado.Columns(7).Width = 120
        dgvRegistrosListado.Columns(8).Width = 95

    End Sub

    Private Sub BuscarIndexDatagridview()

        Dim NumeroFilas, IndexActual, IndexPrevius, IndexNex As Integer
        NumeroFilas = dgvRegistrosListado.Rows.Count
        IndexActual = dgvRegistrosListado.CurrentRow.Index.ToString
        IndexPrevius = IndexActual - 1
        IndexNex = IndexActual + 1

        If NumeroFilas > 0 Then

            If IndexPrevius > -1 Then
                dgvRegistrosListado.Rows(IndexPrevius).Selected = True
                dgvRegistrosListado.CurrentCell = dgvRegistrosListado.Rows(IndexPrevius).Cells(1)
                lblBuscarID.Text = dgvRegistrosListado(0, dgvRegistrosListado.CurrentRow.Index).Value

            ElseIf IndexPrevius = -1 Then

                If IndexNex < NumeroFilas Then
                    dgvRegistrosListado.Rows(IndexNex).Selected = True
                    dgvRegistrosListado.CurrentCell = dgvRegistrosListado.Rows(IndexNex).Cells(1)
                    lblBuscarID.Text = dgvRegistrosListado(0, dgvRegistrosListado.CurrentRow.Index).Value

                ElseIf IndexNex = dgvRegistrosListado.Rows.Count Then
                    Exit Sub

                End If

            End If

        End If

    End Sub

    Private Sub SeleccionarFilaDatagridview(ByVal Busqueda As String, Datagrid As DataGridView)

        For Each row As DataGridViewRow In Datagrid.Rows

            If row.Cells("IdDoc").Value = Busqueda Then
                Datagrid.CurrentCell = row.Cells(0)
                Exit For
            End If
        Next

    End Sub

    Private Sub Limpiar()
        'Campos:
        txtIdDoc.Text = ""
        txtNomDoc.Text = ""
        txtAbrevt.Text = ""
        chbReferencia.Checked = False
        chbVencimiento.Checked = False
        lblUserIngre.Text = ""
        lblFechaIngre.Text = ""
        lblUserModif.Text = ""
        lblFechaModif.Text = ""

        txtIdDoc.Enabled = True

        Panel4.Visible = False
        Panel5.Visible = False

        Panel3.Visible = False
        TabControl1.SelectedIndex = 0
        TabControl1.Enabled = True

        gvoDatosDoc.Enabled = True
        gvoDocLleva.Enabled = True
        gvoMedioPago.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub frmDocumentos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        On Error Resume Next

        TabControl1.Location = New Point(1, 2)
        TabControl1.Size = New Size(Me.Width - 20, 30)
        TabControl1.ItemSize = New Size((TabControl1.Width - 16) / 5, 21)

        Panel2.Location = New Point(2, 24)
        Panel2.Size = New Size(Me.Width - 25, Me.Height - 110)

        Panel3.Location = New Point(2, 26)
        Panel3.Size = New Size(Panel2.Width, Panel2.Height)
    End Sub


    Private Sub frmDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.xDocumntos_Listar()

        'Lineas para desactivar parpadeo del DataGridView al cargar varios registros
        Dim systemType As Type = dgvRegistrosListado.GetType()
        Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propertyInfo.SetValue(dgvRegistrosListado, True, Nothing)
        '--------------------------------------------------------------------------

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Select Case TabControl1.SelectedIndex

            Case 0 'Listar
                'por definir

            Case 1 ' Detalle
                If dgvRegistrosListado.Rows.Count = 0 Then
                    MsgBox("No existe registros para detallar", vbInformation, "Mesnaje del sistema")
                    TabControl1.SelectedIndex = 0
                    Exit Sub
                Else
                    lblGuardar.Text = "Detalle"
                    Panel3.Visible = True
                    TabControl1.Enabled = False
                    CargarDatos()

                    gvoDatosDoc.Enabled = False
                    gvoDocLleva.Enabled = False
                    gvoMedioPago.Enabled = False
                    btnGuardar.Enabled = False
                End If

            Case 2 'Nuevo
                Panel3.Visible = True
                txtIdDoc.Select()
                TabControl1.Enabled = False
                lblGuardar.Text = "Nuevo"

            Case 3 'Modificar
                If dgvRegistrosListado.Rows.Count = 0 Then
                    MsgBox("No existe registros para modificar", vbInformation, "Mesnaje del sistema")
                    TabControl1.SelectedIndex = 0
                    Exit Sub
                Else
                    Panel3.Visible = True
                    txtIdDoc.Enabled = False
                    TabControl1.Enabled = False
                    lblGuardar.Text = "Modificar"
                    CargarDatos()
                End If

            Case 4 'Eliminar
                If dgvRegistrosListado.Rows.Count = 0 Then
                    MsgBox("No existe registros para eliminar", vbInformation, "Mesnaje del sistema")
                    TabControl1.SelectedIndex = 0
                    Exit Sub
                Else
                    Panel3.Visible = True
                    TabControl1.Enabled = False
                    lblGuardar.Text = "Eliminar"
                    CargarDatos()

                    btnGuardar.Enabled = False

                    If MsgBox("¿Esta seguro de eliminar el registro seleccionado?", vbYesNo + vbQuestion, "Mensaje del Sistema") = vbYes Then

                        Me.BuscarIndexDatagridview()
                        Me.xEnti_Eliminar()
                        Me.xDocumntos_Listar()
                        Me.SeleccionarFilaDatagridview(lblBuscarID.Text, dgvRegistrosListado)
                        Me.btnCancelar_Click(Nothing, Nothing)

                    Else
                        Me.btnCancelar_Click(Nothing, Nothing)
                    End If
                End If
        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtIdDoc.Text = "" Then
            MsgBox("Insertar Información Requerida en el Campo Código", vbOKOnly + vbCritical, "Falta Ingresar Datos")
            txtIdDoc.Select()
            Exit Sub

        ElseIf txtNomDoc.Text = "" Then
            MsgBox("Insertar Información Requerida en el Campo Nombre", vbOKOnly + vbCritical, "Falta Ingresar Datos")
            txtNomDoc.Select()
            Exit Sub

        ElseIf txtAbrevt.Text = "" Then
            MsgBox("Insertar Información Requerida en el Campo Abreviatura", vbOKOnly + vbCritical, "Falta Ingresar Datos")
            txtAbrevt.Select()
            Exit Sub

        End If

        If lblGuardar.Text = "Nuevo" Then
            Me.xDocumentos_Insertar()
            Me.SeleccionarFilaDatagridview(txtIdDoc.Text, dgvRegistrosListado)
            Me.Limpiar()

        ElseIf lblGuardar.Text = "Modificar" Then
            Me.xEnti_Actualizar()
            Me.SeleccionarFilaDatagridview(txtIdDoc.Text, dgvRegistrosListado)
            Me.Limpiar()

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Limpiar()
    End Sub

    Private Sub dgvRegistrosListado_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistrosListado.DoubleClick
        Me.CargarDatos()

        TabControl1.SelectedIndex = 3
        TabControl1_Click(Nothing, Nothing)
    End Sub


#Region "Caja de texto IdDoc"
    Private Sub txtIdDoc_Click(sender As Object, e As EventArgs) Handles txtIdDoc.Click

        txtIdDoc.SelectionStart = 0
        txtIdDoc.SelectionLength = txtIdDoc.Text.Length

    End Sub

    Private Sub txtIdDoc_GotFocus(sender As Object, e As EventArgs) Handles txtIdDoc.GotFocus

        txtIdDoc.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdDoc_LostFocus(sender As Object, e As EventArgs) Handles txtIdDoc.LostFocus

        If Trim(txtIdDoc.Text) <> "" Then
            txtIdDoc.Text = Format(CULng(txtIdDoc.Text), "00")
        End If

        Dim Neg As New Negocio.NxDocumentos
        Dim Valor As String
        Valor = Trim(txtIdDoc.Text)
        Dim IdEnti As DataTable = Neg.BuscarIdDoc(Valor)

        If IdEnti.Rows.Count = 1 Then
            MsgBox("Esta código ya se encuentra registrada con" & vbNewLine & "los siguentes datos:" & vbNewLine & vbNewLine & "Código: " & IdEnti.Rows(0)(columnIndex:=0).ToString() & vbNewLine & "Nombre: " & IdEnti.Rows(0)(columnIndex:=1).ToString(), vbInformation, "Mensaje del sistema")
            txtIdDoc.Select()
            txtIdDoc.SelectionStart = 0
            txtIdDoc.SelectionLength = txtIdDoc.Text.Length
            Return
        End If

        txtIdDoc.BackColor = Color.White

    End Sub

    Private Sub txtIdDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDoc.KeyPress

        'Función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'Si la p¿tecla presionada es un Enter

            txtNomDoc.Select()
            txtNomDoc.SelectionStart = 0
            txtNomDoc.SelectionLength = txtNomDoc.Text.Length

            e.Handled = True 'Linea para quitar ek pitido del enter
        End If

    End Sub



#End Region

#Region "Caja de texto Nombre"

    Private Sub txtNomDoc_Click(sender As Object, e As EventArgs) Handles txtNomDoc.Click

        txtNomDoc.SelectionStart = 0
        txtNomDoc.SelectionLength = txtNomDoc.Text.Length

    End Sub

    Private Sub txtNomDoc_GotFocus(sender As Object, e As EventArgs) Handles txtNomDoc.GotFocus

        txtNomDoc.BackColor = Color.LightYellow

    End Sub

    Private Sub txtNomDoc_LostFocus(sender As Object, e As EventArgs) Handles txtNomDoc.LostFocus

        txtNomDoc.BackColor = Color.White

    End Sub

    Private Sub txtNomDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomDoc.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            txtAbrevt.Select()
            txtAbrevt.SelectionStart = 0
            txtAbrevt.SelectionLength = txtAbrevt.Text.Length

            e.Handled = True 'Linea para quitar ek pitido del enter
        End If

    End Sub


#End Region

#Region "Caja de texto Abreviatura"

    Private Sub txtAbrevt_Click(sender As Object, e As EventArgs) Handles txtAbrevt.Click

        txtAbrevt.SelectionStart = 0
        txtAbrevt.SelectionLength = txtAbrevt.Text.Length

    End Sub

    Private Sub txtAbrevt_GotFocus(sender As Object, e As EventArgs) Handles txtAbrevt.GotFocus

        txtAbrevt.BackColor = Color.LightYellow

    End Sub

    Private Sub txtAbrevt_LostFocus(sender As Object, e As EventArgs) Handles txtAbrevt.LostFocus

        txtAbrevt.BackColor = Color.White

    End Sub

    Private Sub txtAbrevt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbrevt.KeyPress
        'función para escribir sólo letras
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("No puedes digitar numeros enteros", vbInformation, "Mesnaje del Sistema")
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            chbVencimiento.Select()

            e.Handled = True 'Linea para quitar ek pitido del enter

        End If
    End Sub


#End Region

#Region "checkBox Vencimiento"

    Private Sub chbVencimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chbVencimiento.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            chbReferencia.Select()
            e.Handled = True 'Linea para quitar ek pitido del enter
        End If

    End Sub

#End Region

#Region "checkBox Referencia"

    Private Sub chbReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chbReferencia.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            txtIdMePa.Select()
            e.Handled = True 'Linea para quitar ek pitido del enter
        End If

    End Sub

#End Region

#Region "Caja de texto IdMePa"

    Private Sub txtIdMePa_Click(sender As Object, e As EventArgs) Handles txtIdMePa.Click

        txtIdMePa.SelectionStart = 0
        txtIdMePa.SelectionLength = txtIdMePa.Text.Length

    End Sub

    Private Sub txtIdMePa_GotFocus(sender As Object, e As EventArgs) Handles txtIdMePa.GotFocus

        txtIdMePa.BackColor = Color.LightYellow

    End Sub

    Private Sub txtIdMePa_LostFocus(sender As Object, e As EventArgs) Handles txtIdMePa.LostFocus

        If txtIdMePa.Text <> "" Then
            txtIdMePa.Text = Format(CLng(txtIdMePa.Text), "000")

            Dim Neg As New Negocio.NxDocumentos
            'Dim IdMePa = Neg.BuscarDocMePa(txtIdMePa.Text)

            'If IdDocIden.Rows.Count = 1 Then

            '    txtNom_DocIden.Text = IdDocIden.Rows(0)(columnIndex:=1).ToString()
            'Else

            '    MsgBox("El código " & txtTip_DocIden.Text & " no existe en los registros Documentos de Identidad", vbCritical, "Mensjae del Sistema")

            '    txtNom_DocIden.Text = ""
            '    txtTip_DocIden.Select()
            '    txtTip_DocIden.SelectionStart = 0
            '    txtTip_DocIden.SelectionLength = txtTip_DocIden.Text.Length

            'End If
        End If

        txtIdMePa.BackColor = Color.White

    End Sub

    Private Sub txtIdMePa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMePa.KeyPress

        'Función para escribir sólo números enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puede digitar números enteros", vbInformation, "Mesnaje del Sistema")
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            btnGuardar.Select()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox(dgvRegistrosListado.Height & vbNewLine & dgvRegistrosListado.ColumnHeadersHeight & vbNewLine & dgvRegistrosListado.Rows(1).Height & vbNewLine & Panel2.Height)
    End Sub

    Private Sub btnMedioPago_Click(sender As Object, e As EventArgs) Handles btnMedioPago.Click

    End Sub


#End Region

End Class