Public Class frmMstSubject
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enformMode As GlobalVariables.FormMode
    Dim cnData As New SQLControl
    Dim Execption As String
    Public intKeySubjectId As Integer
    Public pgState As String

    Private Sub frmMstStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        enformMode = GlobalVariables.FormMode.fmView
        gboxProductDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub
    Public Sub AddData()
        If frmMdiMain.NewToolBtn.Enabled = False Then
            MessageBox.Show("User does Not have rights to Add New entries ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        tctrlProductMst.SelectedTab = TabProductDtl
        gboxProductDtl.Enabled = True
        FillCombos()
        FillBlanks()
        Me.Refresh()
        pgState = "I"
        enformMode = GlobalVariables.FormMode.fmAddData
    End Sub

    Public Sub EditData()
        If frmMdiMain.EditToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Edit entry ...")
            Exit Sub
        End If
        If intKeySubjectId <> 0 Then
            tctrlProductMst.SelectedTab = TabProductDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxProductDtl.Enabled = True
            pgState = "U"
            enformMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select a Product to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        'gboxProductDtl.Enabled = True
        If dtgdProductLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Product to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enformMode = GlobalVariables.FormMode.fmDeleteData
        intKeySubjectId = dtgdProductLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Entry " & dtgdProductLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            '           MessageBox.Show("Deleting Entry ...")
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Private Sub FillBlanks()
        txtProductName.Text = ""
        txtUnitOfMeasure.Text = ""
        cmbxCategory.SelectedIndex = -1
        cmbxPostingAcGroup.Text = ""
        cmbxPostingAcGroup.ResetText()
        cmbxCategory.ResetText()
        chkDisabled.Checked = False
    End Sub

    Private Sub FillCombos()
        Dim cnComboDate As New SQLControl
        cnComboDate.ExecQuery("Select CategoryId,CategoryName from MstCategory Order by CategoryName;")
        If cnComboDate.HasException = True Then Exit Sub
        If cnComboDate.RecordCount > 0 Then
            cmbxCategory.DisplayMember = "CategoryName"
            cmbxCategory.ValueMember = "CategoryId"
            cmbxCategory.DataSource = cnComboDate.DBDT
        End If
        cnComboDate.ExecQuery("Select Distinct ProdPostingAcGroup as PostAcGroup from MstProduct Order by ProdPostingAcGroup")
        If cnComboDate.HasException = True Then Exit Sub
        If cnComboDate.RecordCount > 0 Then
            cmbxPostingAcGroup.DisplayMember = "PostAcGroup"
            cmbxPostingAcGroup.DataSource = cnComboDate.DBDT
        End If
        cnComboDate = Nothing
    End Sub

    Private Sub FillDetails()
        Dim cnGetData As New SQLControl
        cnGetData.AddParam("@in_Listtype", "D")
        cnGetData.AddParam("@in_ProductId", intKeySubjectId)
        cnGetData.ExecProcedure("RSS_ProductGet")
        If cnGetData.DBDT.Rows.Count > 0 Then
            txtProductName.Text = cnGetData.DBDT.Rows(0)("ProductName").ToString
            cmbxCategory.SelectedValue = cnGetData.DBDT.Rows(0)("ProdCategoryId")
            cmbxPostingAcGroup.SelectedText = cnGetData.DBDT.Rows(0)("ProdPostingAcGroup").ToString
            txtUnitOfMeasure.Text = cnGetData.DBDT.Rows(0)("ProdUOM").ToString
            chkDisabled.Checked = cnGetData.DBDT.Rows(0)("ProdDisabled").ToString
        End If
        cnGetData = Nothing
    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxProductDtl.Enabled = False
        tctrlProductMst.SelectedTab = TabProductLst
        pgState = "V"
        enformMode = GlobalVariables.FormMode.fmView
    End Sub

    Public Sub CloseData()
        If enformMode <> GlobalVariables.FormMode.fmAddData And
                enformMode <> GlobalVariables.FormMode.fmEditData And
                enformMode <> GlobalVariables.FormMode.fmDeleteData Then
            Me.Close()
        Else
            MessageBox.Show("Cannot close, Cancel the Current Mode to proceed ...")
        End If
    End Sub

    Public Sub SaveData()
        enformMode = GlobalVariables.FormMode.fmSaveData
        Dim intErrCode As Integer
        Dim strErrMsg As String = ""
        Try
            cnData.AddParam("@in_SaveType", pgState)     ' SqlDbType.NVarChar, 1, ParameterDirection.Input,
            If pgState = "U" Or pgState = "D" Then
                cnData.AddParam("@in_ProductId", intKeySubjectId)
            End If
            cnData.AddParam("@in_ProductName", txtProductName.Text)       ' SqlDbType.NVarChar, 150, ParameterDirection.Input,
            cnData.AddParam("@in_ProdCategoryId", cmbxCategory.SelectedValue)
            cnData.AddParam("@in_ProdUOM", txtUnitOfMeasure.Text)
            cnData.AddParam("@in_ProdPostingAcGroup", cmbxPostingAcGroup.Text)
            cnData.AddParam("@in_UserCode", GlobalVariables.UserCode)     ' SqlDbType.NVarChar, 5, ParameterDirection.Input,
            cnData.ExecProcedure("RSS_ProductAUD")
            intErrCode = cnData.intCtrlErrCode
            strErrMsg = cnData.strCtrlErrMsg
            If cnData.HasException = True Then
                MessageBox.Show("Entry did not Save ...")
                Exit Sub
            End If

            If intErrCode < 0 Then
                MessageBox.Show("Entry did not Saved ..." & vbCrLf & strErrMsg)
                Exit Sub
            End If
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
            FillBlanks()
            If pgState = "I" Then
                AddData()
            ElseIf pgState = "U" Or pgState = "D" Then
                tctrlProductMst.SelectedTab = TabProductLst
            End If
        Catch ex As Exception
            cnData.Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            '        Finally
            ' CLOSE CONNECTION
        End Try
    End Sub

    Private Sub tctrlProductMst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlProductMst.SelectedIndexChanged
        If tctrlProductMst.SelectedTab.Name = "TabProductLst" Then
            cnData.ExecQuery("Select MstProduct.*,CategoryName,'  ' as Blank from MstProduct INNER JOIN MstCategory ON ProdCategoryId = CategoryId Order by ProductName;")
            If cnData.HasException = True Then Exit Sub

            dtgdProductLst.DataSource = cnData.DBDT

            With dtgdProductLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = ""
                .Columns(1).HeaderText = "Name"
                .Columns(2).HeaderText = "ProdCategoryId"
                .Columns(3).HeaderText = "UOM"
                .Columns(4).HeaderText = "Posting Ac. Group"
                .Columns(5).HeaderText = "Maintain Item Stock"
                .Columns(6).HeaderText = "Sale Qty Editable"
                .Columns(7).HeaderText = "Sale Rate Editable"
                .Columns(8).HeaderText = "Disabled"
                .Columns(13).HeaderText = "Category"
                .Columns(14).HeaderText = "  "
                .Columns(0).Visible = False
                .Columns(1).Width = 200
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).Width = 200
                .Columns(6).Width = 100
                .Columns(7).Width = 100
                .Columns(8).Width = 100
                .Columns(13).Width = 100
                .Columns(14).Width = 100
                .Columns(2).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .ReadOnly = True
            End With
            '            cnData = Nothing
        ElseIf tctrlProductMst.SelectedTab.Name = "TabProductDtl" Then
            '            If dtgdProductLst.SelectedRows.Count <> 0 Then
            If intKeySubjectId <> 0 Then
                FillDetails()
            End If
        End If
    End Sub

    Private Sub dtgdProductLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdProductLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdProductLst.Rows(e.RowIndex)
            intKeySubjectId = dtgdProductLst.Rows(e.RowIndex).Cells("ProductId").Value.ToString
            tctrlProductMst.SelectedTab = TabProductDtl
        End If
    End Sub

    Public Sub PrintData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, False)
    End Sub
    Public Sub PreviewData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, True)
    End Sub

    'Private Sub frmMstProduct_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    If enformMode = GlobalVariables.FormMode.fmView Then
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
    '    Else
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
    '    End If
    'End Sub
End Class