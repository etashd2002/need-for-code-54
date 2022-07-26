<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMdiMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuMasters = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstSalutation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstDebtor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstMstSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMstEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMstExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnSaleReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnGiftCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrnPurchaseReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRepoPurchaseLst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoSaleLst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoReceiptLst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoPaymentLst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoPurchaseRtnLst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoSaleReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRepoCurrentStk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoBatchwiseStk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRepoStkRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRepoOsReceivables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSystemTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSysChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSysUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSysUserPermissions = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolBar = New System.Windows.Forms.ToolStrip()
        Me.NewToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.EditToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.PreviewToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolBtn = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.MainToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMasters, Me.mnuTransaction, Me.mnuReports, Me.mnuSystemTools, Me.WindowsMenu, Me.mnuExit})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(987, 24)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuMasters
        '
        Me.mnuMasters.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMstSalutation, Me.mnuMstBrand, Me.mnuMstCategory, Me.mnuMstProducts, Me.mnuMstDebtor, Me.mstMstSupplier, Me.ToolStripSeparator4, Me.mnuMstEmployee, Me.mnuMstExpense})
        Me.mnuMasters.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuMasters.Name = "mnuMasters"
        Me.mnuMasters.Size = New System.Drawing.Size(63, 20)
        Me.mnuMasters.Text = "&Masters"
        Me.mnuMasters.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'mnuMstSalutation
        '
        Me.mnuMstSalutation.Name = "mnuMstSalutation"
        Me.mnuMstSalutation.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstSalutation.Text = "Salutation"
        '
        'mnuMstBrand
        '
        Me.mnuMstBrand.Name = "mnuMstBrand"
        Me.mnuMstBrand.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstBrand.Text = "Brand"
        '
        'mnuMstCategory
        '
        Me.mnuMstCategory.Name = "mnuMstCategory"
        Me.mnuMstCategory.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstCategory.Text = "Category"
        '
        'mnuMstProducts
        '
        Me.mnuMstProducts.Name = "mnuMstProducts"
        Me.mnuMstProducts.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstProducts.Text = "Products"
        '
        'mnuMstDebtor
        '
        Me.mnuMstDebtor.Name = "mnuMstDebtor"
        Me.mnuMstDebtor.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstDebtor.Text = "Customer"
        '
        'mstMstSupplier
        '
        Me.mstMstSupplier.Name = "mstMstSupplier"
        Me.mstMstSupplier.Size = New System.Drawing.Size(129, 22)
        Me.mstMstSupplier.Text = "Supplier"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(126, 6)
        '
        'mnuMstEmployee
        '
        Me.mnuMstEmployee.Name = "mnuMstEmployee"
        Me.mnuMstEmployee.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstEmployee.Text = "Employee"
        '
        'mnuMstExpense
        '
        Me.mnuMstExpense.Name = "mnuMstExpense"
        Me.mnuMstExpense.Size = New System.Drawing.Size(129, 22)
        Me.mnuMstExpense.Text = "Expense"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTrnPurchase, Me.mnuTrnSale, Me.mnuTrnReceipt, Me.mnuTrnPayment, Me.mnuTrnSaleReturn, Me.mnuTrnPurchaseReturn, Me.mnuTrnGiftCard})
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(83, 20)
        Me.mnuTransaction.Text = "Transaction"
        '
        'mnuTrnPurchase
        '
        Me.mnuTrnPurchase.Name = "mnuTrnPurchase"
        Me.mnuTrnPurchase.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnPurchase.Text = "Purchase"
        '
        'mnuTrnSale
        '
        Me.mnuTrnSale.Name = "mnuTrnSale"
        Me.mnuTrnSale.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnSale.Text = "Sale"
        '
        'mnuTrnReceipt
        '
        Me.mnuTrnReceipt.Name = "mnuTrnReceipt"
        Me.mnuTrnReceipt.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnReceipt.Text = "Receipt"
        '
        'mnuTrnPayment
        '
        Me.mnuTrnPayment.Name = "mnuTrnPayment"
        Me.mnuTrnPayment.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnPayment.Text = "Payment"
        '
        'mnuTrnSaleReturn
        '
        Me.mnuTrnSaleReturn.Name = "mnuTrnSaleReturn"
        Me.mnuTrnSaleReturn.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnSaleReturn.Text = "Sale Return"
        '
        'mnuTrnGiftCard
        '
        Me.mnuTrnGiftCard.Name = "mnuTrnGiftCard"
        Me.mnuTrnGiftCard.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnGiftCard.Text = "Gift Card"
        '
        'mnuTrnPurchaseReturn
        '
        Me.mnuTrnPurchaseReturn.Name = "mnuTrnPurchaseReturn"
        Me.mnuTrnPurchaseReturn.Size = New System.Drawing.Size(180, 22)
        Me.mnuTrnPurchaseReturn.Text = "Purchase Return"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRepoBrand, Me.mnuRepoCategory, Me.mnuRepoProduct, Me.mnuRepoCustomer, Me.mnuRepoSupplier, Me.mnuRepoEmployee, Me.mnuRepoExpense, Me.ToolStripSeparator3, Me.mnuRepoPurchaseLst, Me.mnuRepoSaleLst, Me.mnuRepoReceiptLst, Me.mnuRepoPaymentLst, Me.mnuRepoPurchaseRtnLst, Me.mnuRepoSaleReturn, Me.ToolStripSeparator5, Me.mnuRepoCurrentStk, Me.mnuRepoBatchwiseStk, Me.mnuRepoStkRegister, Me.ToolStripSeparator6, Me.mnuRepoOsReceivables})
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(62, 20)
        Me.mnuReports.Text = "Reports"
        '
        'mnuRepoBrand
        '
        Me.mnuRepoBrand.Name = "mnuRepoBrand"
        Me.mnuRepoBrand.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoBrand.Text = "Brand"
        '
        'mnuRepoCategory
        '
        Me.mnuRepoCategory.Name = "mnuRepoCategory"
        Me.mnuRepoCategory.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoCategory.Text = "Category"
        '
        'mnuRepoProduct
        '
        Me.mnuRepoProduct.Name = "mnuRepoProduct"
        Me.mnuRepoProduct.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoProduct.Text = "Product"
        '
        'mnuRepoCustomer
        '
        Me.mnuRepoCustomer.Name = "mnuRepoCustomer"
        Me.mnuRepoCustomer.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoCustomer.Text = "Customer"
        '
        'mnuRepoSupplier
        '
        Me.mnuRepoSupplier.Name = "mnuRepoSupplier"
        Me.mnuRepoSupplier.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoSupplier.Text = "Supplier"
        '
        'mnuRepoEmployee
        '
        Me.mnuRepoEmployee.Name = "mnuRepoEmployee"
        Me.mnuRepoEmployee.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoEmployee.Text = "Employee"
        '
        'mnuRepoExpense
        '
        Me.mnuRepoExpense.Name = "mnuRepoExpense"
        Me.mnuRepoExpense.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoExpense.Text = "Expense"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(163, 6)
        '
        'mnuRepoPurchaseLst
        '
        Me.mnuRepoPurchaseLst.Name = "mnuRepoPurchaseLst"
        Me.mnuRepoPurchaseLst.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoPurchaseLst.Text = "Purchase"
        '
        'mnuRepoSaleLst
        '
        Me.mnuRepoSaleLst.Name = "mnuRepoSaleLst"
        Me.mnuRepoSaleLst.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoSaleLst.Text = "Sale "
        '
        'mnuRepoReceiptLst
        '
        Me.mnuRepoReceiptLst.Name = "mnuRepoReceiptLst"
        Me.mnuRepoReceiptLst.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoReceiptLst.Text = "Receipt"
        '
        'mnuRepoPaymentLst
        '
        Me.mnuRepoPaymentLst.Name = "mnuRepoPaymentLst"
        Me.mnuRepoPaymentLst.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoPaymentLst.Text = "Payment"
        '
        'mnuRepoPurchaseRtnLst
        '
        Me.mnuRepoPurchaseRtnLst.Name = "mnuRepoPurchaseRtnLst"
        Me.mnuRepoPurchaseRtnLst.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoPurchaseRtnLst.Text = "Purchase Return"
        '
        'mnuRepoSaleReturn
        '
        Me.mnuRepoSaleReturn.Name = "mnuRepoSaleReturn"
        Me.mnuRepoSaleReturn.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoSaleReturn.Text = "Sale Return"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(163, 6)
        '
        'mnuRepoCurrentStk
        '
        Me.mnuRepoCurrentStk.Name = "mnuRepoCurrentStk"
        Me.mnuRepoCurrentStk.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoCurrentStk.Text = "Current Stock"
        '
        'mnuRepoBatchwiseStk
        '
        Me.mnuRepoBatchwiseStk.Name = "mnuRepoBatchwiseStk"
        Me.mnuRepoBatchwiseStk.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoBatchwiseStk.Text = "Batchwise Stock"
        '
        'mnuRepoStkRegister
        '
        Me.mnuRepoStkRegister.Name = "mnuRepoStkRegister"
        Me.mnuRepoStkRegister.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoStkRegister.Text = "Stock Register"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(163, 6)
        '
        'mnuRepoOsReceivables
        '
        Me.mnuRepoOsReceivables.Name = "mnuRepoOsReceivables"
        Me.mnuRepoOsReceivables.Size = New System.Drawing.Size(166, 22)
        Me.mnuRepoOsReceivables.Text = "O/s Receivables"
        '
        'mnuSystemTools
        '
        Me.mnuSystemTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSysChangePassword, Me.mnuSysUsers, Me.mnuSysUserPermissions})
        Me.mnuSystemTools.Name = "mnuSystemTools"
        Me.mnuSystemTools.Size = New System.Drawing.Size(92, 20)
        Me.mnuSystemTools.Text = "&System Tools"
        '
        'mnuSysChangePassword
        '
        Me.mnuSysChangePassword.Name = "mnuSysChangePassword"
        Me.mnuSysChangePassword.Size = New System.Drawing.Size(174, 22)
        Me.mnuSysChangePassword.Text = "Change Password"
        '
        'mnuSysUsers
        '
        Me.mnuSysUsers.Name = "mnuSysUsers"
        Me.mnuSysUsers.Size = New System.Drawing.Size(174, 22)
        Me.mnuSysUsers.Text = "Users"
        '
        'mnuSysUserPermissions
        '
        Me.mnuSysUserPermissions.Name = "mnuSysUserPermissions"
        Me.mnuSysUserPermissions.Size = New System.Drawing.Size(174, 22)
        Me.mnuSysUserPermissions.Text = "User Permissions"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(69, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(39, 20)
        Me.mnuExit.Text = "Exit"
        '
        'MainToolBar
        '
        Me.MainToolBar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolBtn, Me.EditToolBtn, Me.SaveToolBtn, Me.CancelToolBtn, Me.DeleteToolBtn, Me.ToolStripSeparator1, Me.PrintToolBtn, Me.PreviewToolBtn, Me.ToolStripSeparator2, Me.HelpToolBtn, Me.CloseToolBtn})
        Me.MainToolBar.Location = New System.Drawing.Point(0, 24)
        Me.MainToolBar.Name = "MainToolBar"
        Me.MainToolBar.Size = New System.Drawing.Size(987, 25)
        Me.MainToolBar.TabIndex = 7
        Me.MainToolBar.Text = "ToolBar"
        '
        'NewToolBtn
        '
        Me.NewToolBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NewToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolBtn.Image = CType(resources.GetObject("NewToolBtn.Image"), System.Drawing.Image)
        Me.NewToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolBtn.Name = "NewToolBtn"
        Me.NewToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.NewToolBtn.Text = "New"
        '
        'EditToolBtn
        '
        Me.EditToolBtn.BackColor = System.Drawing.SystemColors.Control
        Me.EditToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolBtn.Image = CType(resources.GetObject("EditToolBtn.Image"), System.Drawing.Image)
        Me.EditToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.EditToolBtn.Name = "EditToolBtn"
        Me.EditToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.EditToolBtn.Text = "Open"
        '
        'SaveToolBtn
        '
        Me.SaveToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolBtn.Image = CType(resources.GetObject("SaveToolBtn.Image"), System.Drawing.Image)
        Me.SaveToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolBtn.Name = "SaveToolBtn"
        Me.SaveToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolBtn.Text = "Save"
        '
        'CancelToolBtn
        '
        Me.CancelToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolBtn.Image = CType(resources.GetObject("CancelToolBtn.Image"), System.Drawing.Image)
        Me.CancelToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolBtn.Name = "CancelToolBtn"
        Me.CancelToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolBtn.Text = "Cancel"
        '
        'DeleteToolBtn
        '
        Me.DeleteToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolBtn.Image = CType(resources.GetObject("DeleteToolBtn.Image"), System.Drawing.Image)
        Me.DeleteToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolBtn.Name = "DeleteToolBtn"
        Me.DeleteToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.DeleteToolBtn.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolBtn
        '
        Me.PrintToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolBtn.Image = CType(resources.GetObject("PrintToolBtn.Image"), System.Drawing.Image)
        Me.PrintToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolBtn.Name = "PrintToolBtn"
        Me.PrintToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolBtn.Text = "Print"
        '
        'PreviewToolBtn
        '
        Me.PreviewToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PreviewToolBtn.Image = CType(resources.GetObject("PreviewToolBtn.Image"), System.Drawing.Image)
        Me.PreviewToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.PreviewToolBtn.Name = "PreviewToolBtn"
        Me.PreviewToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.PreviewToolBtn.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolBtn
        '
        Me.HelpToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolBtn.Image = CType(resources.GetObject("HelpToolBtn.Image"), System.Drawing.Image)
        Me.HelpToolBtn.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolBtn.Name = "HelpToolBtn"
        Me.HelpToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolBtn.Text = "Help"
        '
        'CloseToolBtn
        '
        Me.CloseToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseToolBtn.Image = CType(resources.GetObject("CloseToolBtn.Image"), System.Drawing.Image)
        Me.CloseToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolBtn.Name = "CloseToolBtn"
        Me.CloseToolBtn.Size = New System.Drawing.Size(23, 22)
        Me.CloseToolBtn.Text = "Close"
        '
        'frmMdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 444)
        Me.Controls.Add(Me.MainToolBar)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MainToolBar.ResumeLayout(False)
        Me.MainToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuMasters As ToolStripMenuItem
    Friend WithEvents mnuMstDebtor As ToolStripMenuItem
    Friend WithEvents mnuMstProducts As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuMstEmployee As ToolStripMenuItem
    Friend WithEvents mnuTransaction As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents mnuSystemTools As ToolStripMenuItem
    Friend WithEvents mnuSysChangePassword As ToolStripMenuItem
    Friend WithEvents mnuSysUsers As ToolStripMenuItem
    Friend WithEvents mnuSysUserPermissions As ToolStripMenuItem
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents MainToolBar As ToolStrip
    Friend WithEvents NewToolBtn As ToolStripButton
    Friend WithEvents EditToolBtn As ToolStripButton
    Friend WithEvents SaveToolBtn As ToolStripButton
    Friend WithEvents CancelToolBtn As ToolStripButton
    Friend WithEvents DeleteToolBtn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolBtn As ToolStripButton
    Friend WithEvents PreviewToolBtn As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HelpToolBtn As ToolStripButton
    Friend WithEvents CloseToolBtn As ToolStripButton
    Friend WithEvents mnuMstCategory As ToolStripMenuItem
    Friend WithEvents mstMstSupplier As ToolStripMenuItem
    Friend WithEvents mnuTrnPurchase As ToolStripMenuItem
    Friend WithEvents mnuMstSalutation As ToolStripMenuItem
    Friend WithEvents mnuMstBrand As ToolStripMenuItem
    Friend WithEvents mnuMstExpense As ToolStripMenuItem
    Friend WithEvents mnuTrnSale As ToolStripMenuItem
    Friend WithEvents mnuTrnReceipt As ToolStripMenuItem
    Friend WithEvents mnuTrnPayment As ToolStripMenuItem
    Friend WithEvents mnuTrnSaleReturn As ToolStripMenuItem
    Friend WithEvents mnuTrnGiftCard As ToolStripMenuItem
    Friend WithEvents mnuTrnPurchaseReturn As ToolStripMenuItem
    Friend WithEvents mnuRepoBrand As ToolStripMenuItem
    Friend WithEvents mnuRepoCategory As ToolStripMenuItem
    Friend WithEvents mnuRepoProduct As ToolStripMenuItem
    Friend WithEvents mnuRepoCustomer As ToolStripMenuItem
    Friend WithEvents mnuRepoSupplier As ToolStripMenuItem
    Friend WithEvents mnuRepoEmployee As ToolStripMenuItem
    Friend WithEvents mnuRepoExpense As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuRepoPurchaseLst As ToolStripMenuItem
    Friend WithEvents mnuRepoSaleLst As ToolStripMenuItem
    Friend WithEvents mnuRepoReceiptLst As ToolStripMenuItem
    Friend WithEvents mnuRepoPaymentLst As ToolStripMenuItem
    Friend WithEvents mnuRepoPurchaseRtnLst As ToolStripMenuItem
    Friend WithEvents mnuRepoSaleReturn As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuRepoCurrentStk As ToolStripMenuItem
    Friend WithEvents mnuRepoBatchwiseStk As ToolStripMenuItem
    Friend WithEvents mnuRepoStkRegister As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuRepoOsReceivables As ToolStripMenuItem
End Class
