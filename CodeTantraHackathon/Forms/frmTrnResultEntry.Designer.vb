<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrnResultEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tctrlPurchaseTrn = New System.Windows.Forms.TabControl()
        Me.TabPurchaseDtl = New System.Windows.Forms.TabPage()
        Me.gboxPurchaseDtl = New System.Windows.Forms.GroupBox()
        Me.lblRoundOff = New System.Windows.Forms.Label()
        Me.txtRoundOff = New System.Windows.Forms.TextBox()
        Me.lblBillAmt = New System.Windows.Forms.Label()
        Me.lblInOutState = New System.Windows.Forms.Label()
        Me.txtBillAmt = New System.Windows.Forms.TextBox()
        Me.txtTotTransport = New System.Windows.Forms.TextBox()
        Me.lblTotTransportAmt = New System.Windows.Forms.Label()
        Me.txtEntryNo = New System.Windows.Forms.TextBox()
        Me.cmbxClient = New System.Windows.Forms.ComboBox()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.txtTotSGSTAmt = New System.Windows.Forms.TextBox()
        Me.lblTotSGSTAmt = New System.Windows.Forms.Label()
        Me.txtTotIGSTAmt = New System.Windows.Forms.TextBox()
        Me.lblTotIGSTAmt = New System.Windows.Forms.Label()
        Me.txtTotCGSTAmt = New System.Windows.Forms.TextBox()
        Me.lblTotCGSTAmt = New System.Windows.Forms.Label()
        Me.txtTotDiscAmt = New System.Windows.Forms.TextBox()
        Me.lblTotDiscAmt = New System.Windows.Forms.Label()
        Me.txtTotNetAmt = New System.Windows.Forms.TextBox()
        Me.lblTotNetAmt = New System.Windows.Forms.Label()
        Me.dtgPurchaseDtl = New System.Windows.Forms.DataGridView()
        Me.dtgTrnDtlId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgProduct = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgHSNCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgGSTPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgBrand = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgSizeContent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgPatternDesign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgDiscPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgDiscAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgTransport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgOtherChrgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgSGSTPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgSGSTAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgCGSTPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgCGSTAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgIGSTPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgIGSTAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgMRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgClientId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblBillDate = New System.Windows.Forms.Label()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEntryNo = New System.Windows.Forms.Label()
        Me.lblEntryDate = New System.Windows.Forms.Label()
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.TabPurchaseLst = New System.Windows.Forms.TabPage()
        Me.dtgdPurchaseLst = New System.Windows.Forms.DataGridView()
        Me.tctrlPurchaseTrn.SuspendLayout()
        Me.TabPurchaseDtl.SuspendLayout()
        Me.gboxPurchaseDtl.SuspendLayout()
        CType(Me.dtgPurchaseDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPurchaseLst.SuspendLayout()
        CType(Me.dtgdPurchaseLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlPurchaseTrn
        '
        Me.tctrlPurchaseTrn.Controls.Add(Me.TabPurchaseDtl)
        Me.tctrlPurchaseTrn.Controls.Add(Me.TabPurchaseLst)
        Me.tctrlPurchaseTrn.Location = New System.Drawing.Point(3, 2)
        Me.tctrlPurchaseTrn.Name = "tctrlPurchaseTrn"
        Me.tctrlPurchaseTrn.SelectedIndex = 0
        Me.tctrlPurchaseTrn.Size = New System.Drawing.Size(1367, 674)
        Me.tctrlPurchaseTrn.TabIndex = 4
        '
        'TabPurchaseDtl
        '
        Me.TabPurchaseDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabPurchaseDtl.Controls.Add(Me.gboxPurchaseDtl)
        Me.TabPurchaseDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabPurchaseDtl.Name = "TabPurchaseDtl"
        Me.TabPurchaseDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPurchaseDtl.Size = New System.Drawing.Size(1359, 648)
        Me.TabPurchaseDtl.TabIndex = 0
        Me.TabPurchaseDtl.Text = "Add/Update/Delete"
        '
        'gboxPurchaseDtl
        '
        Me.gboxPurchaseDtl.Controls.Add(Me.lblRoundOff)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtRoundOff)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblBillAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblInOutState)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtBillAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotTransport)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotTransportAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtEntryNo)
        Me.gboxPurchaseDtl.Controls.Add(Me.cmbxClient)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtBillNo)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblBillNo)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotSGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotSGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotIGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotIGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotCGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotCGSTAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotDiscAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotDiscAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtTotNetAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblTotNetAmt)
        Me.gboxPurchaseDtl.Controls.Add(Me.dtgPurchaseDtl)
        Me.gboxPurchaseDtl.Controls.Add(Me.txtDetails)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblDetails)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblBillDate)
        Me.gboxPurchaseDtl.Controls.Add(Me.dtpBillDate)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblEntryNo)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblEntryDate)
        Me.gboxPurchaseDtl.Controls.Add(Me.dtpEntryDate)
        Me.gboxPurchaseDtl.Controls.Add(Me.lblSupplier)
        Me.gboxPurchaseDtl.Location = New System.Drawing.Point(18, 16)
        Me.gboxPurchaseDtl.Name = "gboxPurchaseDtl"
        Me.gboxPurchaseDtl.Size = New System.Drawing.Size(1322, 607)
        Me.gboxPurchaseDtl.TabIndex = 30
        Me.gboxPurchaseDtl.TabStop = False
        '
        'lblRoundOff
        '
        Me.lblRoundOff.AutoSize = True
        Me.lblRoundOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundOff.Location = New System.Drawing.Point(1113, 493)
        Me.lblRoundOff.Name = "lblRoundOff"
        Me.lblRoundOff.Size = New System.Drawing.Size(90, 18)
        Me.lblRoundOff.TabIndex = 158
        Me.lblRoundOff.Text = "Round Off : "
        Me.lblRoundOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRoundOff
        '
        Me.txtRoundOff.BackColor = System.Drawing.SystemColors.Window
        Me.txtRoundOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(1206, 488)
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.Size = New System.Drawing.Size(110, 26)
        Me.txtRoundOff.TabIndex = 7
        Me.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBillAmt
        '
        Me.lblBillAmt.AutoSize = True
        Me.lblBillAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmt.Location = New System.Drawing.Point(1128, 519)
        Me.lblBillAmt.Name = "lblBillAmt"
        Me.lblBillAmt.Size = New System.Drawing.Size(75, 18)
        Me.lblBillAmt.TabIndex = 156
        Me.lblBillAmt.Text = "Bill Amt. : "
        Me.lblBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInOutState
        '
        Me.lblInOutState.AutoSize = True
        Me.lblInOutState.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOutState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInOutState.Location = New System.Drawing.Point(464, 44)
        Me.lblInOutState.Name = "lblInOutState"
        Me.lblInOutState.Size = New System.Drawing.Size(0, 18)
        Me.lblInOutState.TabIndex = 155
        '
        'txtBillAmt
        '
        Me.txtBillAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtBillAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillAmt.Location = New System.Drawing.Point(1206, 516)
        Me.txtBillAmt.Name = "txtBillAmt"
        Me.txtBillAmt.ReadOnly = True
        Me.txtBillAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtBillAmt.TabIndex = 154
        Me.txtBillAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotTransport
        '
        Me.txtTotTransport.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotTransport.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotTransport.Location = New System.Drawing.Point(1206, 460)
        Me.txtTotTransport.Name = "txtTotTransport"
        Me.txtTotTransport.ReadOnly = True
        Me.txtTotTransport.Size = New System.Drawing.Size(110, 26)
        Me.txtTotTransport.TabIndex = 153
        Me.txtTotTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotTransportAmt
        '
        Me.lblTotTransportAmt.AutoSize = True
        Me.lblTotTransportAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTransportAmt.Location = New System.Drawing.Point(1116, 465)
        Me.lblTotTransportAmt.Name = "lblTotTransportAmt"
        Me.lblTotTransportAmt.Size = New System.Drawing.Size(87, 18)
        Me.lblTotTransportAmt.TabIndex = 152
        Me.lblTotTransportAmt.Text = "Transport : "
        Me.lblTotTransportAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEntryNo
        '
        Me.txtEntryNo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEntryNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryNo.Location = New System.Drawing.Point(138, 12)
        Me.txtEntryNo.MaxLength = 50
        Me.txtEntryNo.Name = "txtEntryNo"
        Me.txtEntryNo.ReadOnly = True
        Me.txtEntryNo.Size = New System.Drawing.Size(124, 26)
        Me.txtEntryNo.TabIndex = 151
        '
        'cmbxClient
        '
        Me.cmbxClient.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxClient.FormattingEnabled = True
        Me.cmbxClient.Location = New System.Drawing.Point(137, 40)
        Me.cmbxClient.Name = "cmbxClient"
        Me.cmbxClient.Size = New System.Drawing.Size(321, 26)
        Me.cmbxClient.TabIndex = 2
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(137, 68)
        Me.txtBillNo.MaxLength = 250
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(160, 26)
        Me.txtBillNo.TabIndex = 3
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBillNo.Location = New System.Drawing.Point(78, 72)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(56, 18)
        Me.lblBillNo.TabIndex = 143
        Me.lblBillNo.Text = "Bill No :"
        '
        'txtTotSGSTAmt
        '
        Me.txtTotSGSTAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotSGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotSGSTAmt.Location = New System.Drawing.Point(932, 516)
        Me.txtTotSGSTAmt.Name = "txtTotSGSTAmt"
        Me.txtTotSGSTAmt.ReadOnly = True
        Me.txtTotSGSTAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtTotSGSTAmt.TabIndex = 142
        Me.txtTotSGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotSGSTAmt
        '
        Me.lblTotSGSTAmt.AutoSize = True
        Me.lblTotSGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSGSTAmt.Location = New System.Drawing.Point(832, 521)
        Me.lblTotSGSTAmt.Name = "lblTotSGSTAmt"
        Me.lblTotSGSTAmt.Size = New System.Drawing.Size(96, 18)
        Me.lblTotSGSTAmt.TabIndex = 141
        Me.lblTotSGSTAmt.Text = "SGST Amt. : "
        Me.lblTotSGSTAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotIGSTAmt
        '
        Me.txtTotIGSTAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotIGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotIGSTAmt.Location = New System.Drawing.Point(932, 572)
        Me.txtTotIGSTAmt.Name = "txtTotIGSTAmt"
        Me.txtTotIGSTAmt.ReadOnly = True
        Me.txtTotIGSTAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtTotIGSTAmt.TabIndex = 140
        Me.txtTotIGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotIGSTAmt
        '
        Me.lblTotIGSTAmt.AutoSize = True
        Me.lblTotIGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotIGSTAmt.Location = New System.Drawing.Point(831, 577)
        Me.lblTotIGSTAmt.Name = "lblTotIGSTAmt"
        Me.lblTotIGSTAmt.Size = New System.Drawing.Size(94, 18)
        Me.lblTotIGSTAmt.TabIndex = 139
        Me.lblTotIGSTAmt.Text = "IGST Amt. : "
        Me.lblTotIGSTAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotCGSTAmt
        '
        Me.txtTotCGSTAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotCGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCGSTAmt.Location = New System.Drawing.Point(932, 544)
        Me.txtTotCGSTAmt.Name = "txtTotCGSTAmt"
        Me.txtTotCGSTAmt.ReadOnly = True
        Me.txtTotCGSTAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtTotCGSTAmt.TabIndex = 138
        Me.txtTotCGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotCGSTAmt
        '
        Me.lblTotCGSTAmt.AutoSize = True
        Me.lblTotCGSTAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCGSTAmt.Location = New System.Drawing.Point(831, 549)
        Me.lblTotCGSTAmt.Name = "lblTotCGSTAmt"
        Me.lblTotCGSTAmt.Size = New System.Drawing.Size(97, 18)
        Me.lblTotCGSTAmt.TabIndex = 137
        Me.lblTotCGSTAmt.Text = "CGST Amt. : "
        Me.lblTotCGSTAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotDiscAmt
        '
        Me.txtTotDiscAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotDiscAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotDiscAmt.Location = New System.Drawing.Point(932, 488)
        Me.txtTotDiscAmt.Name = "txtTotDiscAmt"
        Me.txtTotDiscAmt.ReadOnly = True
        Me.txtTotDiscAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtTotDiscAmt.TabIndex = 136
        Me.txtTotDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotDiscAmt
        '
        Me.lblTotDiscAmt.AutoSize = True
        Me.lblTotDiscAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDiscAmt.Location = New System.Drawing.Point(851, 493)
        Me.lblTotDiscAmt.Name = "lblTotDiscAmt"
        Me.lblTotDiscAmt.Size = New System.Drawing.Size(78, 18)
        Me.lblTotDiscAmt.TabIndex = 135
        Me.lblTotDiscAmt.Text = "Discount : "
        Me.lblTotDiscAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotNetAmt
        '
        Me.txtTotNetAmt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotNetAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotNetAmt.Location = New System.Drawing.Point(932, 460)
        Me.txtTotNetAmt.Name = "txtTotNetAmt"
        Me.txtTotNetAmt.ReadOnly = True
        Me.txtTotNetAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtTotNetAmt.TabIndex = 134
        Me.txtTotNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotNetAmt
        '
        Me.lblTotNetAmt.AutoSize = True
        Me.lblTotNetAmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotNetAmt.Location = New System.Drawing.Point(827, 465)
        Me.lblTotNetAmt.Name = "lblTotNetAmt"
        Me.lblTotNetAmt.Size = New System.Drawing.Size(102, 18)
        Me.lblTotNetAmt.TabIndex = 133
        Me.lblTotNetAmt.Text = "Net Amount : "
        Me.lblTotNetAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtgPurchaseDtl
        '
        Me.dtgPurchaseDtl.AllowUserToAddRows = False
        Me.dtgPurchaseDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPurchaseDtl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgTrnDtlId, Me.dtgProduct, Me.dtgProductId, Me.dtgHSNCode, Me.dtgGSTPerc, Me.dtgBrand, Me.dtgSizeContent, Me.dtgPatternDesign, Me.dtgQuantity, Me.dtgRate, Me.dtgAmount, Me.dtgDiscPerc, Me.dtgDiscAmt, Me.dtgTransport, Me.dtgOtherChrgs, Me.dtgSGSTPerc, Me.dtgSGSTAmt, Me.dtgCGSTPerc, Me.dtgCGSTAmt, Me.dtgIGSTPerc, Me.dtgIGSTAmt, Me.dtgMRP, Me.dtgClientId})
        Me.dtgPurchaseDtl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgPurchaseDtl.Location = New System.Drawing.Point(6, 101)
        Me.dtgPurchaseDtl.Name = "dtgPurchaseDtl"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPurchaseDtl.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgPurchaseDtl.Size = New System.Drawing.Size(1310, 356)
        Me.dtgPurchaseDtl.TabIndex = 6
        '
        'dtgTrnDtlId
        '
        Me.dtgTrnDtlId.HeaderText = "TrnDtlId"
        Me.dtgTrnDtlId.Name = "dtgTrnDtlId"
        Me.dtgTrnDtlId.ReadOnly = True
        Me.dtgTrnDtlId.Visible = False
        '
        'dtgProduct
        '
        Me.dtgProduct.HeaderText = "Product"
        Me.dtgProduct.Name = "dtgProduct"
        Me.dtgProduct.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgProduct.Width = 250
        '
        'dtgProductId
        '
        Me.dtgProductId.HeaderText = "ProductId"
        Me.dtgProductId.Name = "dtgProductId"
        Me.dtgProductId.ReadOnly = True
        Me.dtgProductId.Visible = False
        '
        'dtgHSNCode
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dtgHSNCode.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgHSNCode.HeaderText = "HSN Code"
        Me.dtgHSNCode.Name = "dtgHSNCode"
        Me.dtgHSNCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgGSTPerc
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dtgGSTPerc.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgGSTPerc.HeaderText = "GST %"
        Me.dtgGSTPerc.Name = "dtgGSTPerc"
        Me.dtgGSTPerc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgGSTPerc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgBrand
        '
        Me.dtgBrand.HeaderText = "Brand"
        Me.dtgBrand.Name = "dtgBrand"
        '
        'dtgSizeContent
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dtgSizeContent.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSizeContent.HeaderText = "Size / Content"
        Me.dtgSizeContent.Name = "dtgSizeContent"
        Me.dtgSizeContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgPatternDesign
        '
        Me.dtgPatternDesign.HeaderText = "Pattern / Design"
        Me.dtgPatternDesign.Name = "dtgPatternDesign"
        Me.dtgPatternDesign.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dtgQuantity
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dtgQuantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgQuantity.HeaderText = "Quantity"
        Me.dtgQuantity.Name = "dtgQuantity"
        '
        'dtgRate
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.dtgRate.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgRate.HeaderText = "Rate"
        Me.dtgRate.Name = "dtgRate"
        Me.dtgRate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgAmount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.dtgAmount.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgAmount.HeaderText = "Amount"
        Me.dtgAmount.Name = "dtgAmount"
        '
        'dtgDiscPerc
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dtgDiscPerc.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgDiscPerc.HeaderText = "Disc. %"
        Me.dtgDiscPerc.Name = "dtgDiscPerc"
        Me.dtgDiscPerc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgDiscAmt
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.dtgDiscAmt.DefaultCellStyle = DataGridViewCellStyle8
        Me.dtgDiscAmt.HeaderText = "Disc. Amt"
        Me.dtgDiscAmt.Name = "dtgDiscAmt"
        Me.dtgDiscAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgTransport
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.dtgTransport.DefaultCellStyle = DataGridViewCellStyle9
        Me.dtgTransport.HeaderText = "Transport/Courier"
        Me.dtgTransport.Name = "dtgTransport"
        '
        'dtgOtherChrgs
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.dtgOtherChrgs.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtgOtherChrgs.HeaderText = "Other Chrgs"
        Me.dtgOtherChrgs.Name = "dtgOtherChrgs"
        '
        'dtgSGSTPerc
        '
        Me.dtgSGSTPerc.HeaderText = "SGST %"
        Me.dtgSGSTPerc.Name = "dtgSGSTPerc"
        Me.dtgSGSTPerc.Visible = False
        '
        'dtgSGSTAmt
        '
        Me.dtgSGSTAmt.HeaderText = "SGST Amt."
        Me.dtgSGSTAmt.Name = "dtgSGSTAmt"
        Me.dtgSGSTAmt.Visible = False
        '
        'dtgCGSTPerc
        '
        Me.dtgCGSTPerc.HeaderText = "CGST %"
        Me.dtgCGSTPerc.Name = "dtgCGSTPerc"
        Me.dtgCGSTPerc.Visible = False
        '
        'dtgCGSTAmt
        '
        Me.dtgCGSTAmt.HeaderText = "CGST Amt."
        Me.dtgCGSTAmt.Name = "dtgCGSTAmt"
        Me.dtgCGSTAmt.Visible = False
        '
        'dtgIGSTPerc
        '
        Me.dtgIGSTPerc.HeaderText = "IGST %"
        Me.dtgIGSTPerc.Name = "dtgIGSTPerc"
        Me.dtgIGSTPerc.Visible = False
        '
        'dtgIGSTAmt
        '
        Me.dtgIGSTAmt.HeaderText = "IGST Amt."
        Me.dtgIGSTAmt.Name = "dtgIGSTAmt"
        Me.dtgIGSTAmt.Visible = False
        '
        'dtgMRP
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.dtgMRP.DefaultCellStyle = DataGridViewCellStyle11
        Me.dtgMRP.HeaderText = "MRP"
        Me.dtgMRP.Name = "dtgMRP"
        '
        'dtgClientId
        '
        Me.dtgClientId.HeaderText = "Customer"
        Me.dtgClientId.Name = "dtgClientId"
        '
        'txtDetails
        '
        Me.txtDetails.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(128, 463)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(380, 53)
        Me.txtDetails.TabIndex = 5
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(65, 466)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(60, 18)
        Me.lblDetails.TabIndex = 119
        Me.lblDetails.Text = "Details :"
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDate.Location = New System.Drawing.Point(448, 72)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(69, 18)
        Me.lblBillDate.TabIndex = 116
        Me.lblBillDate.Text = "Bill Date :"
        '
        'dtpBillDate
        '
        Me.dtpBillDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBillDate.Location = New System.Drawing.Point(518, 67)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.ShowCheckBox = True
        Me.dtpBillDate.Size = New System.Drawing.Size(154, 26)
        Me.dtpBillDate.TabIndex = 4
        '
        'lblEntryNo
        '
        Me.lblEntryNo.AutoSize = True
        Me.lblEntryNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryNo.Location = New System.Drawing.Point(66, 16)
        Me.lblEntryNo.Name = "lblEntryNo"
        Me.lblEntryNo.Size = New System.Drawing.Size(68, 18)
        Me.lblEntryNo.TabIndex = 109
        Me.lblEntryNo.Text = "Entry # :"
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.Location = New System.Drawing.Point(468, 16)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(49, 18)
        Me.lblEntryDate.TabIndex = 108
        Me.lblEntryDate.Text = "Date :"
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntryDate.Location = New System.Drawing.Point(518, 12)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.Size = New System.Drawing.Size(128, 26)
        Me.dtpEntryDate.TabIndex = 1
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSupplier.Location = New System.Drawing.Point(67, 44)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(67, 18)
        Me.lblSupplier.TabIndex = 46
        Me.lblSupplier.Text = "Supplier :"
        '
        'TabPurchaseLst
        '
        Me.TabPurchaseLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabPurchaseLst.Controls.Add(Me.dtgdPurchaseLst)
        Me.TabPurchaseLst.Location = New System.Drawing.Point(4, 22)
        Me.TabPurchaseLst.Name = "TabPurchaseLst"
        Me.TabPurchaseLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPurchaseLst.Size = New System.Drawing.Size(1359, 648)
        Me.TabPurchaseLst.TabIndex = 1
        Me.TabPurchaseLst.Text = "List"
        '
        'dtgdPurchaseLst
        '
        Me.dtgdPurchaseLst.Location = New System.Drawing.Point(6, 6)
        Me.dtgdPurchaseLst.Name = "dtgdPurchaseLst"
        Me.dtgdPurchaseLst.Size = New System.Drawing.Size(1347, 636)
        Me.dtgdPurchaseLst.TabIndex = 0
        '
        'frmTrnResultEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.tctrlPurchaseTrn)
        Me.Name = "frmTrnResultEntry"
        Me.Text = "frmTrnResultEntry"
        Me.tctrlPurchaseTrn.ResumeLayout(False)
        Me.TabPurchaseDtl.ResumeLayout(False)
        Me.gboxPurchaseDtl.ResumeLayout(False)
        Me.gboxPurchaseDtl.PerformLayout()
        CType(Me.dtgPurchaseDtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPurchaseLst.ResumeLayout(False)
        CType(Me.dtgdPurchaseLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlPurchaseTrn As TabControl
    Friend WithEvents TabPurchaseDtl As TabPage
    Friend WithEvents gboxPurchaseDtl As GroupBox
    Friend WithEvents lblRoundOff As Label
    Friend WithEvents txtRoundOff As TextBox
    Friend WithEvents lblBillAmt As Label
    Friend WithEvents lblInOutState As Label
    Friend WithEvents txtBillAmt As TextBox
    Friend WithEvents txtTotTransport As TextBox
    Friend WithEvents lblTotTransportAmt As Label
    Friend WithEvents txtEntryNo As TextBox
    Friend WithEvents cmbxClient As ComboBox
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents lblBillNo As Label
    Friend WithEvents txtTotSGSTAmt As TextBox
    Friend WithEvents lblTotSGSTAmt As Label
    Friend WithEvents txtTotIGSTAmt As TextBox
    Friend WithEvents lblTotIGSTAmt As Label
    Friend WithEvents txtTotCGSTAmt As TextBox
    Friend WithEvents lblTotCGSTAmt As Label
    Friend WithEvents txtTotDiscAmt As TextBox
    Friend WithEvents lblTotDiscAmt As Label
    Friend WithEvents txtTotNetAmt As TextBox
    Friend WithEvents lblTotNetAmt As Label
    Friend WithEvents dtgPurchaseDtl As DataGridView
    Friend WithEvents dtgTrnDtlId As DataGridViewTextBoxColumn
    Friend WithEvents dtgProduct As DataGridViewComboBoxColumn
    Friend WithEvents dtgProductId As DataGridViewTextBoxColumn
    Friend WithEvents dtgHSNCode As DataGridViewTextBoxColumn
    Friend WithEvents dtgGSTPerc As DataGridViewTextBoxColumn
    Friend WithEvents dtgBrand As DataGridViewComboBoxColumn
    Friend WithEvents dtgSizeContent As DataGridViewTextBoxColumn
    Friend WithEvents dtgPatternDesign As DataGridViewTextBoxColumn
    Friend WithEvents dtgQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dtgRate As DataGridViewTextBoxColumn
    Friend WithEvents dtgAmount As DataGridViewTextBoxColumn
    Friend WithEvents dtgDiscPerc As DataGridViewTextBoxColumn
    Friend WithEvents dtgDiscAmt As DataGridViewTextBoxColumn
    Friend WithEvents dtgTransport As DataGridViewTextBoxColumn
    Friend WithEvents dtgOtherChrgs As DataGridViewTextBoxColumn
    Friend WithEvents dtgSGSTPerc As DataGridViewTextBoxColumn
    Friend WithEvents dtgSGSTAmt As DataGridViewTextBoxColumn
    Friend WithEvents dtgCGSTPerc As DataGridViewTextBoxColumn
    Friend WithEvents dtgCGSTAmt As DataGridViewTextBoxColumn
    Friend WithEvents dtgIGSTPerc As DataGridViewTextBoxColumn
    Friend WithEvents dtgIGSTAmt As DataGridViewTextBoxColumn
    Friend WithEvents dtgMRP As DataGridViewTextBoxColumn
    Friend WithEvents dtgClientId As DataGridViewComboBoxColumn
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblBillDate As Label
    Friend WithEvents dtpBillDate As DateTimePicker
    Friend WithEvents lblEntryNo As Label
    Friend WithEvents lblEntryDate As Label
    Friend WithEvents dtpEntryDate As DateTimePicker
    Friend WithEvents lblSupplier As Label
    Friend WithEvents TabPurchaseLst As TabPage
    Friend WithEvents dtgdPurchaseLst As DataGridView
End Class
