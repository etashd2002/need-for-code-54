Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmTrnResultEntry
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enFormMode As GlobalVariables.FormMode
    Dim pgState As String
    Dim cnData As New SQLControl
    Dim Exception As String
    Dim intKeyResultId As Integer

    Private Sub frmTrnResultEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        enFormMode = GlobalVariables.FormMode.fmView
        gboxPurchaseDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub

    Public Sub AddData()
        'If frmMdiMain.NewToolBtn.Enabled = False Then
        '    MessageBox.Show("User does Not have rights to Add New entries ...")
        '    Exit Sub
        'End If
        tctrlPurchaseTrn.SelectedTab = TabPurchaseDtl
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        gboxPurchaseDtl.Enabled = True
        FillCombos()
        FillBlanks()
        Me.Refresh()
        pgState = "I"
        Me.Show()
        enFormMode = GlobalVariables.FormMode.fmAddData
        dtpEntryDate.Select()
    End Sub

    Public Sub EditData()
        If frmMdiMain.EditToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Edit entry ...")
            Exit Sub
        End If
        If intKeyResultId <> 0 Then
            tctrlPurchaseTrn.SelectedTab = TabPurchaseDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxPurchaseDtl.Enabled = True
            pgState = "U"
            enFormMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select a Expense to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        If dtgdPurchaseLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Order to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enFormMode = GlobalVariables.FormMode.fmDeleteData
        intKeyResultId = dtgdPurchaseLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Entry " & dtgdPurchaseLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Public Sub SaveData()
        enFormMode = GlobalVariables.FormMode.fmSaveData
        Dim intSaveEntryNo As Integer
        Dim intErrCode As Integer
        Dim strErrMsg As String = ""
        Dim lngRowCtr As Integer
        Dim StrDtlSave As String
        Dim dtEntry As Date
        Dim dtBillDate As Date
        Try
            StrDtlSave = ""
            lngRowCtr = 0
            CalPurchaseTotal()
            Do While lngRowCtr < dtgPurchaseDtl.Rows.Count

                If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgProductId").Value) = False _
                    And dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgProductId").Value IsNot Nothing Then

                    StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgTrnDtlId").Value + "!"
                    StrDtlSave = StrDtlSave + (dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgProductId").Value).ToString + "!"
                    StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgHSNCode").Value + "!"
                    StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgGSTPerc").Value.ToString + "!"
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgBrand").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgBrand").Value.ToString + "!"
                    End If
                    StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgSizeContent").Value + "!"
                    StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgPatternDesign").Value + "!"
                    StrDtlSave = StrDtlSave + (dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgQuantity").Value).ToString + "!"
                    StrDtlSave = StrDtlSave + (dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgRate").Value).ToString + "!"
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgDiscPerc").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgDiscPerc").Value.ToString + "!"
                    End If
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgTransport").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgTransport").Value.ToString + "!"
                    End If
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgOtherChrgs").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgOtherChrgs").Value.ToString + "!"
                    End If
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgMRP").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgMRP").Value.ToString + "!"
                    End If
                    If String.IsNullOrEmpty(dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgCLientId").Value) Then
                        StrDtlSave = StrDtlSave + "0!"
                    Else
                        StrDtlSave = StrDtlSave + dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgClientId").Value.ToString + "!"
                    End If
                    StrDtlSave = StrDtlSave + "$"
                End If
                lngRowCtr += 1
            Loop
            dtEntry = dtpEntryDate.Text
            If IsDate(dtpBillDate.Text) Then
                dtBillDate = dtpBillDate.Text
            End If

            cnData.AddParam("@in_SaveType", pgState)
            If pgState = "U" Or pgState = "D" Then
                cnData.AddParam("@in_StockId", intKeyResultId)
            End If
            cnData.AddParam("@in_BillNo", txtBillNo.Text)
            If IsDate(dtpBillDate.Text) Then
                cnData.AddParam("@in_EntryDate", dtEntry)
                cnData.AddParam("@in_BillDate", dtBillDate)
            End If
            cnData.AddParam("@in_ClientId", cmbxClient.SelectedValue)
            cnData.AddParam("@in_RoundOff", txtRoundOff.Text)
            cnData.AddParam("@in_BillAmt", txtBillAmt.Text)
            cnData.AddParam("@in_Detail", txtDetails.Text)
            cnData.AddParam("@in_StockDtl", StrDtlSave)
            cnData.AddParam("@in_UserCode", GlobalVariables.UserCode)
            cnData.ExecProcedure("RSS_TrnPurchaseAUD")
            If cnData.HasException = True Then
                MessageBox.Show("Entry did Not Save ...")
                Exit Sub
            End If
            intSaveEntryNo = cnData.intCtrlEntryNo
            intErrCode = cnData.intCtrlErrCode
            strErrMsg = cnData.strCtrlErrMsg
            If intErrCode < 0 Then
                Exit Sub
                MessageBox.Show("Entry did Not Saved ..." & vbCrLf & strErrMsg)
            Else
            End If

            '' Saving the PDF's into the specified folders 
            'txtEntryNo.Text = intSaveEntryNo
            'If Not String.IsNullOrEmpty(lblPurchaseInvFileName.Text) And lblPurchaseInvFileName.Text <> Application.StartupPath + "\Documents\" + Replace(txtEntryNo.Text, "/", "_") + "_VR.pdf" Then
            '    My.Computer.FileSystem.CopyFile(lblPurchaseInvFileName.Text, Application.StartupPath + "\Documents\" + Replace(txtEntryNo.Text, "/", "_") + "_VR.pdf", True)
            'End If

            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
            FillBlanks()
            If pgState = "I" Then
                AddData()
            ElseIf pgState = "U" Or pgState = "D" Then
                pgState = "V"
                tctrlPurchaseTrn.SelectedTab = TabPurchaseLst
                gboxPurchaseDtl.Enabled = False
            End If
        Catch ex As Exception
            cnData.Exception = "ExecQuery Error:   " & vbNewLine & ex.Message
            MessageBox.Show("Error in Saving Data " & ex.Message)
            '        Finally
            ' CLOSE CONNECTION
        End Try
    End Sub

    Public Sub FillCombos()
        Dim cnComboGet As New SQLControl
        cnComboGet.ExecQuery("Select ClientId,ClientName from MstClient Where EntryType = 'C' Order by ClientName;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            cmbxClient.DisplayMember = "ClientName"
            cmbxClient.ValueMember = "ClientId"
            cmbxClient.DataSource = cnComboGet.DBDT
        End If
        cnComboGet.ExecQuery("Select ProductId,ProductName from MstProduct Order by ProductName;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            Dim cboExpCol = CType(dtgPurchaseDtl.Columns("dtgProduct"), DataGridViewComboBoxColumn)
            cboExpCol.DataSource = cnComboGet.DBDT
            cboExpCol.ValueMember = "ProductId"
            cboExpCol.DisplayMember = "ProductName"
            '            cboExpCol.DisplayIndex = 0
            'cboExpCol.DefaultCellStyle.NullValue = cnComboGet.DBDT.Rows(0)("ProductName")
            'cboExpCol.DefaultCellStyle.DataSourceNullValue = cnComboGet.DBDT.Rows(0)("ProductId")
        End If
        cnComboGet.ExecQuery("Select ClientId,ClientName from MstClient Where EntryType = 'D' Order by ClientName;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            Dim cboExpCol = CType(dtgPurchaseDtl.Columns("dtgClientId"), DataGridViewComboBoxColumn)
            cboExpCol.DataSource = cnComboGet.DBDT
            cboExpCol.ValueMember = "ClientId"
            cboExpCol.DisplayMember = "ClientName"
            '            cboExpCol.DisplayIndex = 0
        End If
        cnComboGet.ExecQuery("Select BrandId,BrandName from MstBrand Order by BrandName;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            Dim cboExpCol = CType(dtgPurchaseDtl.Columns("dtgBrand"), DataGridViewComboBoxColumn)
            cboExpCol.DataSource = cnComboGet.DBDT
            cboExpCol.ValueMember = "BrandId"
            cboExpCol.DisplayMember = "BrandName"
            '            cboExpCol.DisplayIndex = 0
        End If
        cnComboGet = Nothing
        'Dim ComboData As New Dictionary(Of String, String)()
        'ComboData.Add(1, "PDI")
        'ComboData.Add(2, "Installation")
        'ComboData.Add(3, "Warranty Visit")
        'ComboData.Add(4, "After Warranty")
        'ComboData.Add(5, "AMC")
        'ComboData.Add(6, "Others")
        'cmbxVisitType.DataSource = New BindingSource(ComboData, Nothing)
        'cmbxVisitType.DisplayMember = "Value"
        'cmbxVisitType.ValueMember = "Key"
    End Sub

    Public Sub FillBlanks()
        lblInOutState.Text = ""
        cmbxClient.SelectedIndex = -1
        txtEntryNo.Text = ""
        txtBillNo.Text = ""
        txtDetails.Text = ""
        txtTotCGSTAmt.Text = ""
        txtTotIGSTAmt.Text = ""
        txtTotSGSTAmt.Text = ""
        txtTotDiscAmt.Text = ""
        txtTotNetAmt.Text = ""
        txtTotDiscAmt.Text = ""
        txtTotTransport.Text = ""
        txtRoundOff.Text = ""
        txtBillAmt.Text = ""
        dtgPurchaseDtl.Rows.Clear()
        dtgPurchaseDtl.Rows.Add()
        setDateTimePickerBlank(dtpEntryDate)
        setDateTimePickerBlank(dtpBillDate)
        dtpEntryDate.Value = DateTime.Now
    End Sub

    Private Sub FillDetails()
        Dim cnGetData As New SQLControl
        Dim lngRowCtr As Integer
        FillBlanks()
        FillCombos()
        cnGetData.AddParam("@in_StockId", intKeyResultId)
        cnGetData.ExecProcedure("RSS_TrnStockMstGet")
        If cnGetData.DBDT.Rows.Count > 0 Then

            txtEntryNo.Text = cnGetData.DBDT.Rows(0)("TrnEntryNo").ToString
            dtpEntryDate.Value = cnGetData.DBDT.Rows(0)("TrnDate")
            cmbxClient.SelectedValue = cnGetData.DBDT.Rows(0)("TrnClientId")
            txtBillNo.Text = cnGetData.DBDT.Rows(0)("TrnBillNo").ToString
            If IsDate(cnGetData.DBDT.Rows(0)("TrnBillDate").ToString) Then
                dtpBillDate.Value = DateTimePicker.MinimumDateTime
                dtpBillDate.Value = cnGetData.DBDT.Rows(0)("TrnDate")
            End If
            txtDetails.Text = cnGetData.DBDT.Rows(0)("TrnDetail").ToString
            txtTotNetAmt.Text = cnGetData.DBDT.Rows(0)("TrnNetAmt").ToString
            txtTotDiscAmt.Text = cnGetData.DBDT.Rows(0)("TrnDiscAmt").ToString
            txtTotCGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnCGSTAmt").ToString
            txtTotSGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnSGSTAmt").ToString
            txtTotIGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnIGSTAmt").ToString
            txtRoundOff.Text = cnGetData.DBDT.Rows(0)("TrnRoundOff").ToString
            txtBillAmt.Text = cnGetData.DBDT.Rows(0)("TrnBillAmt").ToString
            'lblPurchaseInvFileName.Text = cnGetData.DBDT.Rows(0)("TrnExpVisitReportScanFile").ToString
            'If Len(lblPurchaseInvFileName.Text) > 0 Then
            '    btnVwPurchaseInvoiceReportFile.Visible = True
            'Else
            '    btnVwPurchaseInvoiceReportFile.Visible = False
            'End If

            cnGetData.ClearDBDT()
            cnGetData.AddParam("@in_StockId", intKeyResultId)
            cnGetData.ExecProcedure("RSS_TrnStockDtlGet")
            If cnGetData.DBDT.Rows.Count > 0 Then
                lngRowCtr = 0
                '                dtgPurchaseDtl.Rows.Clear()
                dtgPurchaseDtl.Rows.Clear()
                dtgPurchaseDtl.Rows.Add()
                Do While lngRowCtr <= cnGetData.DBDT.Rows.Count - 1
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgTrnDtlId").Value = cnGetData.DBDT.Rows(lngRowCtr)("StockDtlId").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgProduct").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlProductId")
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgProductId").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlProductId").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgHSNCode").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlHSNCode").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlGSTPerc").ToString
                    If cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlBrandId") <> 0 Then
                        dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgBrand").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlBrandId")
                    End If
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgSizeContent").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSizeContent").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgPatternDesign").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlPatternDesign").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgQuantity").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlQuantity").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgRate").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlRate").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgAmount").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlAmount").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgDiscPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlDiscPerc").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgDiscAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlDiscAmt").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgTransport").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlTransport").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgSGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSGSTPerc").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgSGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSGSTAmt").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgCGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlCGSTPerc").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgCGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlCGSTAmt").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgIGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlIGSTPerc").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgIGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlIGSTAmt").ToString
                    dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgMRP").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlMRP").ToString
                    If cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlClientId") <> 0 Then
                        dtgPurchaseDtl.Rows(lngRowCtr).Cells("dtgClientId").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlClientId")
                    End If
                    dtgPurchaseDtl.Rows.Add()
                    lngRowCtr += 1
                Loop
            End If
        End If
        cnGetData = Nothing
    End Sub

    Private Sub tctrlPurchaseTrn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlPurchaseTrn.SelectedIndexChanged
        Dim intRowCtr As Integer = 0
        If cnData.HasException = True Then Exit Sub
        If tctrlPurchaseTrn.SelectedTab.Name = "TabPurchaseLst" Then
            cnData.ExecQuery("Select StockId,TrnEntryNo,TrnDate,TrnBillNo,TrnBillDate,TrnNetAmt,TrnDiscAmt,TrnTransport,
            	TrnOtherCharges,TrnSGSTAmt,TrnCGSTAmt,TrnIGSTAmt,TrnRoundOff,TrnBillAmt,TrnDetail,ClientName 
                from TrnStockMst 
                INNER JOIN MstClient ON TrnClientId=ClientId 
                Where TrnEntryType = 'P' And TrnEntryStatus = 'R' 
                Order by TrnDate Desc,StockId Desc;")
            dtgdPurchaseLst.DataSource = cnData.DBDT

            With dtgdPurchaseLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = "StockId"
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Entry #"
                .Columns(2).HeaderText = "Entry Date"
                .Columns(3).HeaderText = "Bill #"
                .Columns(4).HeaderText = "Bill Date"
                .Columns(5).HeaderText = "Net Amt."
                .Columns(6).HeaderText = "Discount"
                .Columns(7).HeaderText = "Transport"
                .Columns(8).HeaderText = "Other Charges"
                .Columns(9).HeaderText = "SGST Amt."
                .Columns(10).HeaderText = "CGST Amt."
                .Columns(11).HeaderText = "IGST Amt."
                .Columns(12).HeaderText = "R Off"
                .Columns(13).HeaderText = "Bill Amt."
                .Columns(14).HeaderText = "Details"
                .Columns(15).HeaderText = "Supplier"
                .Columns(0).Width = 0
                .Columns(1).Width = 40
                .Columns(2).Width = 90
                .Columns(3).Width = 70
                .Columns(4).Width = 90
                .Columns(5).Width = 70
                .Columns(6).Width = 70
                .Columns(7).Width = 70
                .Columns(8).Width = 70
                .Columns(9).Width = 70
                .Columns(10).Width = 70
                .Columns(11).Width = 70
                .Columns(12).Width = 50
                .Columns(13).Width = 90
                .Columns(14).Width = 100
                .Columns(15).Width = 150
                .Columns(15).DisplayIndex = 6
                .ReadOnly = True
            End With
        ElseIf tctrlPurchaseTrn.SelectedTab.Name = "TabPurchaseDtl" Then
            If intKeyResultId <> 0 Then
                FillDetails()
            End If
        End If

    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxPurchaseDtl.Enabled = False
        pgState = "V"
        tctrlPurchaseTrn.SelectedTab = TabPurchaseLst
        enFormMode = GlobalVariables.FormMode.fmView
    End Sub

    Public Sub CloseData()
        If enFormMode <> GlobalVariables.FormMode.fmAddData And
                    enFormMode <> GlobalVariables.FormMode.fmEditData And
                    enFormMode <> GlobalVariables.FormMode.fmDeleteData Then
            Me.Close()
        Else
            MessageBox.Show("Cannot close, Cancel the Current Mode to proceed ...")
        End If
    End Sub

    'Private Sub frmTrnPurchase_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
    '    If enFormMode = GlobalVariables.FormMode.fmView Then
    '    Else
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
    '    End If
    'End Sub

    Private Sub setDateTimePickerBlank(ByVal dateTimePicker As DateTimePicker)
        dateTimePicker.Visible = True
        dateTimePicker.Value = DateTime.Now
        dateTimePicker.CustomFormat = "    "
        dateTimePicker.Format = DateTimePickerFormat.Custom
        'dateTimePicker.Checked = False
    End Sub
    Private Sub setDateTimePickerBlanktext(ByVal dateTimePicker As DateTimePicker)
        dateTimePicker.Visible = True
        dateTimePicker.CustomFormat = "    "
        dateTimePicker.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub dtpEntryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEntryDate.ValueChanged
        dtpEntryDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtpBillDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBillDate.ValueChanged
        If dtpBillDate.Checked = CheckState.Unchecked Then
            setDateTimePickerBlank(dtpBillDate)
        Else
            dtpBillDate.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub dtgdPurchaseLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdPurchaseLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdPurchaseLst.Rows(e.RowIndex)
            intKeyResultId = dtgdPurchaseLst.Rows(e.RowIndex).Cells(0).Value.ToString
            tctrlPurchaseTrn.SelectedTab = TabPurchaseDtl
        End If
    End Sub

    Private Sub tctrlPurchaseTrn_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tctrlPurchaseTrn.Selecting
        If pgState = "I" Or pgState = "U" Then
            MessageBox.Show("Entry in Edit / Save mode cannot move ...")
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub dtgPurchaseDtl_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtgPurchaseDtl.CellBeginEdit
        '        MsgBox("Cell Begin Edit Event")
        If e.ColumnIndex = 1 Or e.ColumnIndex = 5 Then
            SendKeys.Send("%{DOWN}")
        ElseIf e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
        End If
    End Sub

    Private Sub dtgPurchaseDtl_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPurchaseDtl.CellValueChanged
        RemoveHandler dtgPurchaseDtl.CellBeginEdit, AddressOf dtgPurchaseDtl_CellBeginEdit
        RemoveHandler dtgPurchaseDtl.CellValueChanged, AddressOf dtgPurchaseDtl_CellValueChanged
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 1 Then
                If dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgProduct").Selected = True Then
                    dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgProductId").Value = dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgProduct").Value
                    dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 2, e.RowIndex)
                    'dtgExpenseDtl.BeginEdit(True)
                    If dtgPurchaseDtl.Rows.Count - 1 = e.RowIndex Then
                        If dtgPurchaseDtl.Rows(dtgPurchaseDtl.Rows.Count - 1).Cells("dtgProductId").Value <> 0 Then
                            dtgPurchaseDtl.Rows.Add()
                        End If
                    End If
                    dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 2, e.RowIndex)
                    dtgPurchaseDtl.BeginEdit(True)
                End If
            ElseIf e.ColumnIndex = 3 Then
                If dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgHSNCode").Value And dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgProductId").Value <> 0 Then
                    If cnData.HasException = True Then Exit Sub
                    cnData.ExecQuery("Select * from TrnStockDtl Where TrnDtlStkMovement = 'I' And TrnDtlHSNCode = '" + dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgHSNCode").Value + "' And TrnDtlProductId = " + (dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgProduct").Value).ToString + ";")
                    If cnData.RecordCount > 0 Then
                        dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 2, e.RowIndex)
                        dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value = cnData.DBDT.Rows(0)("TrnDtlGSTPerc").ToString
                    Else
                        dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 1, e.RowIndex)
                    End If
                    dtgPurchaseDtl.BeginEdit(True)
                End If
                CalPurchaseTotal()
            ElseIf e.ColumnIndex = 4 Then
                If Val(dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value) > 0 Then
                    If lblInOutState.Text = "Local" Then
                        dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgSGSTPerc").Value = dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value / 2
                        dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgCGSTPerc").Value = dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgSGSTPerc").Value
                    ElseIf lblInOutState.Text = "Out State" Then
                        dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgIGSTPerc").Value = dtgPurchaseDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value
                    End If
                    dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 1, e.RowIndex)
                End If
                dtgPurchaseDtl.BeginEdit(True)
            ElseIf e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Then
                CalPurchaseTotal()
                dtgPurchaseDtl.CurrentCell = dtgPurchaseDtl(e.ColumnIndex + 1, e.RowIndex)
                dtgPurchaseDtl.BeginEdit(True)
            End If
        End If
        AddHandler dtgPurchaseDtl.CellBeginEdit, AddressOf dtgPurchaseDtl_CellBeginEdit
        AddHandler dtgPurchaseDtl.CellValueChanged, AddressOf dtgPurchaseDtl_CellValueChanged
    End Sub

    Private Sub dtpEntryDate_GotFocus(sender As Object, e As EventArgs) Handles dtpEntryDate.GotFocus
        SendKeys.Send("%{DOWN}")
    End Sub

    Private Sub dtpBillDate_GotFocus(sender As Object, e As EventArgs) Handles dtpBillDate.GotFocus
        SendKeys.Send("%{DOWN}")
    End Sub

    Public Sub PrintData()
        'frmRepoViewer.ViewReport(Application.StartupPath & "\Reports\rptTrnExpenseLst.rpt",,,, True)
    End Sub

    Public Sub CalPurchaseTotal()
        Dim intRowCtr As Integer = 0
        Dim decTaxable As Decimal = 0
        txtTotNetAmt.Text = ""
        txtTotDiscAmt.Text = ""
        txtTotSGSTAmt.Text = ""
        txtTotCGSTAmt.Text = ""
        txtTotIGSTAmt.Text = ""
        txtTotTransport.Text = ""
        txtBillAmt.Text = ""
        For intRowCtr = 0 To dtgPurchaseDtl.Rows.Count - 1
            If Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgRate").Value) <> 0 And Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgQuantity").Value) <> 0 Then
                dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgAmount").Value = Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgRate").Value) * Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgQuantity").Value)
                If Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgDiscPerc").Value) <> 0 Then
                    dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value = Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgAmount").Value) * Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgDiscPerc").Value) / 100
                End If
                decTaxable = (Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgAmount").Value) - Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value) + Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgTransport").Value))
                dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgSGSTAmt").Value = decTaxable * Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgSGSTPerc").Value) / 100
                dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgCGSTAmt").Value = decTaxable * Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgCGSTPerc").Value) / 100
                dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgIGSTAmt").Value = decTaxable * Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgIGSTPerc").Value) / 100
                txtTotNetAmt.Text = Val(txtTotNetAmt.Text) + dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgAmount").Value
                txtTotDiscAmt.Text = Val(txtTotDiscAmt.Text) + dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value
                txtTotSGSTAmt.Text = Val(txtTotSGSTAmt.Text) + Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgSGSTAmt").Value)
                txtTotCGSTAmt.Text = Val(txtTotCGSTAmt.Text) + Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgCGSTAmt").Value)
                txtTotIGSTAmt.Text = Val(txtTotIGSTAmt.Text) + Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgIGSTAmt").Value)
                txtTotTransport.Text = Val(txtTotTransport.Text) + Val(dtgPurchaseDtl.Rows(intRowCtr).Cells("dtgTransport").Value)
            End If
        Next
        txtTotNetAmt.Text = Format(Val(txtTotNetAmt.Text), "0.00")
        txtTotDiscAmt.Text = Format(Val(txtTotDiscAmt.Text), "0.00")
        txtTotTransport.Text = Format(Val(txtTotTransport.Text), "0.00")
        txtTotSGSTAmt.Text = Format(Val(txtTotSGSTAmt.Text), "0.00")
        txtTotCGSTAmt.Text = Format(Val(txtTotCGSTAmt.Text), "0.00")
        txtTotIGSTAmt.Text = Format(Val(txtTotIGSTAmt.Text), "0.00")
        txtRoundOff.Text = Format(txtRoundOff.Text, "0.00")
        txtBillAmt.Text = Format(Val(txtTotNetAmt.Text) - Val(txtTotDiscAmt.Text) + Val(txtTotSGSTAmt.Text) + Val(txtTotCGSTAmt.Text) + Val(txtTotIGSTAmt.Text) + Val(txtTotTransport.Text) + Val(txtRoundOff.Text), "0.00")
    End Sub

    Private Sub cmbxClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxClient.SelectedIndexChanged
        Dim cnData As New SQLControl
        If cmbxClient.SelectedIndex <> -1 Then
            cnData.ExecQuery("Select * from MstClient Where ClientId = " + cmbxClient.SelectedValue.ToString + ";")
            If cnData.HasException = True Then Exit Sub
            If cnData.DBDT.Rows(0)("ClientInOutState").ToString() = "L" Then
                lblInOutState.Text = "Local"
            ElseIf cnData.DBDT.Rows(0)("ClientInOutState").ToString() = "O" Then
                lblInOutState.Text = "Out State"
            ElseIf cnData.DBDT.Rows(0)("ClientInOutState").ToString() = "E" Then
                lblInOutState.Text = "Export"
            End If
        End If
        cnData = Nothing
    End Sub

End Class