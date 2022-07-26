Public Class frmMdiMain
    Private m_ChildFormNumber As Integer

    Private Sub frmMdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub mnuSysUsers_Click(sender As Object, e As EventArgs) Handles mnuSysUsers.Click
        Dim objSysUsers As New frmSysUsers
        objSysUsers.MdiParent = Me
        m_ChildFormNumber += 1
        objSysUsers.Show()
    End Sub

    Private Sub mnuMstProducts_Click(sender As Object, e As EventArgs) Handles mnuMstProducts.Click
        Dim objMstProduct As New frmMstProduct
        objMstProduct.MdiParent = Me
        m_ChildFormNumber += 1
        objMstProduct.intMenuFormId = SQLControl.GetMenuFormId("mnuMstProduct", "frmMstProduct")
        objMstProduct.Show()
    End Sub

    Private Sub mnuMstCategory_Click(sender As Object, e As EventArgs) Handles mnuMstCategory.Click
        Dim objMstCategory As New frmMstCategory
        objMstCategory.MdiParent = Me
        m_ChildFormNumber += 1
        objMstCategory.strEntryType = "Category"
        objMstCategory.intMenuFormId = SQLControl.GetMenuFormId("mnuMstCategory", "frmMstCategory")
        objMstCategory.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MainToolBar.ItemClicked
        Dim strformname As String
        If ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        strformname = ActiveMdiChild.Name
        Select Case MainToolBar.Items.IndexOf(e.ClickedItem)
            Case 0
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstSupplier" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).AddData()
                End If
            Case 1
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).EditData()
                End If
            Case 2
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).SaveData()
                End If
            Case 3
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).CancelData()
                End If
            Case 4
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).DeleteData()
                End If
            Case 6
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    'DirectCast(ActiveMdiChild, frmMstCategory).PrintData()
                    'frmViewReport.Show()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PrintData()
                    'frmViewReport.Show()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    'DirectCast(ActiveMdiChild, frmMstProduct).PrintData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PrintData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PrintData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    'DirectCast(ActiveMdiChild, frmMstEmployee).PrintData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmRepoListing" Then
                    DirectCast(ActiveMdiChild, frmRepoListing).PrintData()
                End If
            Case 7
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    'DirectCast(ActiveMdiChild, frmMstCategory).PreviewData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PreviewData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    'DirectCast(ActiveMdiChild, frmMstProduct).PreviewData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PreviewData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    'DirectCast(ActiveMdiChild, frmMstDebtor).PreviewData()
                    'frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    '    DirectCast(ActiveMdiChild, frmMstEmployee).PreviewData()
                    '    frmReportPage.Show()
                ElseIf ActiveMdiChild.Name = "frmRepoListing" Then
                    DirectCast(ActiveMdiChild, frmRepoListing).PreviewData()
                End If
            Case 9
                MessageBox.Show("There is no Help provided currently ...")
            Case 10
                If ActiveMdiChild.Name = "frmMstCategory" Then
                    DirectCast(ActiveMdiChild, frmMstCategory).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstCompany" Then
                    'DirectCast(ActiveMdiChild, frmMstCompany).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstDebtor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstProduct" Then
                    DirectCast(ActiveMdiChild, frmMstProduct).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstCreditor" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstArchitect" Then
                    DirectCast(ActiveMdiChild, frmMstDebtor).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstEmployee" Then
                    DirectCast(ActiveMdiChild, frmMstEmployee).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchase).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    DirectCast(ActiveMdiChild, frmTrnReceipt).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    DirectCast(ActiveMdiChild, frmTrnSale).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnSaleReturn).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).CloseData()
                ElseIf ActiveMdiChild.Name = "frmRepoListing" Then
                    DirectCast(ActiveMdiChild, frmRepoListing).CloseData()
                End If
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub mnuMstDebtor_Click(sender As Object, e As EventArgs) Handles mnuMstDebtor.Click
        Dim objMstDebtor As New frmMstDebtor
        objMstDebtor.MdiParent = Me
        m_ChildFormNumber += 1
        objMstDebtor.intMenuFormId = SQLControl.GetMenuFormId("mnuMstDebtor", "frmMstDebtor")
        objMstDebtor.strEntryType = "D"
        objMstDebtor.Show()
    End Sub

    Private Sub mstMstSupplier_Click(sender As Object, e As EventArgs) Handles mstMstSupplier.Click
        Dim objMstCreditor As New frmMstDebtor
        objMstCreditor.MdiParent = Me
        m_ChildFormNumber += 1
        objMstCreditor.intMenuFormId = SQLControl.GetMenuFormId("mnuMstCreditor", "frmMstDebtor")
        objMstCreditor.strEntryType = "C"
        objMstCreditor.show()
    End Sub

    Private Sub mnuMstEmployee_Click(sender As Object, e As EventArgs) Handles mnuMstEmployee.Click
        Dim objMstEmployee As New frmMstEmployee
        objMstEmployee.MdiParent = Me
        m_ChildFormNumber += 1
        objMstEmployee.intMenuFormId = SQLControl.GetMenuFormId("mnuMstEmployee", "frmMstEmployee")
        objMstEmployee.show()
    End Sub

    Private Sub mnuTrnPurchase_Click(sender As Object, e As EventArgs) Handles mnuTrnPurchase.Click
        Dim objTrnPurchase As New frmTrnPurchase
        objTrnPurchase.MdiParent = Me
        m_ChildFormNumber += 1
        objTrnPurchase.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnPurchase", "frmTrnPurchase")
        objTrnPurchase.strEntryType = "P"
        objTrnPurchase.Show()
    End Sub

    Private Sub mnuMstBrand_Click(sender As Object, e As EventArgs) Handles mnuMstBrand.Click
        Dim objMstBrand As New frmMstCategory
        objMstBrand.MdiParent = Me
        m_ChildFormNumber += 1
        objMstBrand.strEntryType = "Brand"
        objMstBrand.intMenuFormId = SQLControl.GetMenuFormId("mnuMstBrand", "frmMstCategory")
        objMstBrand.Show()
    End Sub

    Private Sub mnuMstSalutation_Click(sender As Object, e As EventArgs) Handles mnuMstSalutation.Click
        Dim objMstSalutation As New frmMstCategory
        objMstSalutation.MdiParent = Me
        m_ChildFormNumber += 1
        objMstSalutation.strEntryType = "Salutation"
        objMstSalutation.intMenuFormId = SQLControl.GetMenuFormId("mnuMstSalutation", "frmMstCategory")
        objMstSalutation.Show()
    End Sub

    Private Sub mnuMstExpense_Click(sender As Object, e As EventArgs) Handles mnuMstExpense.Click
        Dim objMstExpense As New frmMstCategory
        objMstExpense.MdiParent = Me
        m_ChildFormNumber += 1
        objMstExpense.strEntryType = "Expense"
        objMstExpense.intMenuFormId = SQLControl.GetMenuFormId("mnuMstExpense", "frmMstCategory")
        objMstExpense.Show()
    End Sub

    Private Sub ReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnReceipt.Click
        Dim objTrnReceipt As New frmTrnReceipt
        objTrnReceipt.MdiParent = Me
        m_ChildFormNumber += 1
        objTrnReceipt.strEntryType = "Receipt"
        objTrnReceipt.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnReceipt", "frmTrnReceipt")
        objTrnReceipt.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnSale.Click
        Dim objTrnSale As New frmTrnSale
        objTrnSale.MdiParent = Me
        m_ChildFormNumber += 1
        objTrnSale.strEntryType = "Sale"
        objTrnSale.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnSale", "frmTrnSale")
        objTrnSale.Show()
    End Sub

    Private Sub SaleReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnSaleReturn.Click
        Dim objTrnSaleReturn As New frmTrnSaleReturn
        objTrnSaleReturn.MdiParent = Me
        m_ChildFormNumber += 1
        objTrnSaleReturn.strEntryType = "Sale Return"
        objTrnSaleReturn.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnSaleReturn", "frmTrnSaleReturn")
        objTrnSaleReturn.Show()
    End Sub

    Private Sub mnuTrnPurchaseReturn_Click(sender As Object, e As EventArgs) Handles mnuTrnPurchaseReturn.Click
        Dim objTrnPurchaseReturn As New frmTrnPurchaseReturn
        objTrnPurchaseReturn.MdiParent = Me
        m_ChildFormNumber += 1
        objTrnPurchaseReturn.strEntryType = "Purchase Return"
        objTrnPurchaseReturn.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnPurchaseReturn", "frmTrnPurchaseReturn")
        objTrnPurchaseReturn.Show()
    End Sub

    Private Sub mnuRepoBrand_Click(sender As Object, e As EventArgs) Handles mnuRepoBrand.Click
        Dim objRepoBrand As New frmRepoListing
        objRepoBrand.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoBrand.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoBrand", "frmRepoListing")
        objRepoBrand.strRepoType = "Brand List"
        objRepoBrand.Show()
    End Sub

    Private Sub mnuRepoCategory_Click(sender As Object, e As EventArgs) Handles mnuRepoCategory.Click
        Dim objRepoCategory As New frmRepoListing
        objRepoCategory.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoCategory.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCategory", "frmRepoListing")
        objRepoCategory.strRepoType = "Category List"
        objRepoCategory.Show()
    End Sub

    Private Sub mnuRepoProduct_Click(sender As Object, e As EventArgs) Handles mnuRepoProduct.Click
        Dim objRepoProduct As New frmRepoListing
        objRepoProduct.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoProduct.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoProduct", "frmRepoListing")
        objRepoProduct.strRepoType = "Product List"
        objRepoProduct.Show()
    End Sub

    Private Sub mnuRepoCustomer_Click(sender As Object, e As EventArgs) Handles mnuRepoCustomer.Click
        Dim objRepoCustomer As New frmRepoListing
        objRepoCustomer.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoCustomer.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCustomer", "frmRepoListing")
        objRepoCustomer.strRepoType = "Customer List"
        objRepoCustomer.Show()
    End Sub

    Private Sub mnuRepoSupplier_Click(sender As Object, e As EventArgs) Handles mnuRepoSupplier.Click
        Dim objRepoSupplier As New frmRepoListing
        objRepoSupplier.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoSupplier.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoSupplier", "frmRepoListing")
        objRepoSupplier.strRepoType = "Supplier List"
        objRepoSupplier.Show()
    End Sub

    Private Sub mnuRepoCurrentStk_Click(sender As Object, e As EventArgs) Handles mnuRepoCurrentStk.Click
        Dim objRepoItemCurrentStk As New frmRepoListing
        objRepoItemCurrentStk.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoItemCurrentStk.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCurrentStk", "frmRepoListing")
        objRepoItemCurrentStk.strRepoType = "Item Current Stock"
        objRepoItemCurrentStk.Show()
    End Sub

    Private Sub mnuRepoOsReceivables_Click(sender As Object, e As EventArgs) Handles mnuRepoOsReceivables.Click
        Dim objRepoOsReceivables As New frmRepoListing
        objRepoOsReceivables.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoOsReceivables.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoOsReceivables", "frmRepoListing")
        objRepoOsReceivables.strRepoType = "O/s Receivables"
        objRepoOsReceivables.Show()
    End Sub

    Private Sub mnuRepoBatchwiseStk_Click(sender As Object, e As EventArgs) Handles mnuRepoBatchwiseStk.Click
        Dim objRepoBatchwiseStk As New frmRepoListing
        objRepoBatchwiseStk.MdiParent = Me
        m_ChildFormNumber += 1
        objRepoBatchwiseStk.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoBatchwiseStk", "frmRepoListing")
        objRepoBatchwiseStk.strRepoType = "Batchwise Stock"
        objRepoBatchwiseStk.Show()
    End Sub
End Class
