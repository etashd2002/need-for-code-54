<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstSubject
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
        Me.tctrlProductMst = New System.Windows.Forms.TabControl()
        Me.TabProductDtl = New System.Windows.Forms.TabPage()
        Me.gboxProductDtl = New System.Windows.Forms.GroupBox()
        Me.chkDisabled = New System.Windows.Forms.CheckBox()
        Me.cmbxPostingAcGroup = New System.Windows.Forms.ComboBox()
        Me.lblPostingAcGroup = New System.Windows.Forms.Label()
        Me.txtUnitOfMeasure = New System.Windows.Forms.TextBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.cmbxCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabProductLst = New System.Windows.Forms.TabPage()
        Me.dtgdProductLst = New System.Windows.Forms.DataGridView()
        Me.tctrlProductMst.SuspendLayout()
        Me.TabProductDtl.SuspendLayout()
        Me.gboxProductDtl.SuspendLayout()
        Me.TabProductLst.SuspendLayout()
        CType(Me.dtgdProductLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlProductMst
        '
        Me.tctrlProductMst.Controls.Add(Me.TabProductDtl)
        Me.tctrlProductMst.Controls.Add(Me.TabProductLst)
        Me.tctrlProductMst.Location = New System.Drawing.Point(12, 12)
        Me.tctrlProductMst.Name = "tctrlProductMst"
        Me.tctrlProductMst.SelectedIndex = 0
        Me.tctrlProductMst.Size = New System.Drawing.Size(1210, 604)
        Me.tctrlProductMst.TabIndex = 4
        '
        'TabProductDtl
        '
        Me.TabProductDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabProductDtl.Controls.Add(Me.gboxProductDtl)
        Me.TabProductDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabProductDtl.Name = "TabProductDtl"
        Me.TabProductDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductDtl.Size = New System.Drawing.Size(1202, 578)
        Me.TabProductDtl.TabIndex = 0
        Me.TabProductDtl.Text = "Add/Update/Delete"
        '
        'gboxProductDtl
        '
        Me.gboxProductDtl.Controls.Add(Me.chkDisabled)
        Me.gboxProductDtl.Controls.Add(Me.cmbxPostingAcGroup)
        Me.gboxProductDtl.Controls.Add(Me.lblPostingAcGroup)
        Me.gboxProductDtl.Controls.Add(Me.txtUnitOfMeasure)
        Me.gboxProductDtl.Controls.Add(Me.lblUOM)
        Me.gboxProductDtl.Controls.Add(Me.txtProductName)
        Me.gboxProductDtl.Controls.Add(Me.cmbxCategory)
        Me.gboxProductDtl.Controls.Add(Me.lblCategory)
        Me.gboxProductDtl.Controls.Add(Me.lblName)
        Me.gboxProductDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxProductDtl.Name = "gboxProductDtl"
        Me.gboxProductDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxProductDtl.TabIndex = 30
        Me.gboxProductDtl.TabStop = False
        '
        'chkDisabled
        '
        Me.chkDisabled.AutoSize = True
        Me.chkDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkDisabled.Location = New System.Drawing.Point(728, 19)
        Me.chkDisabled.Name = "chkDisabled"
        Me.chkDisabled.Size = New System.Drawing.Size(101, 17)
        Me.chkDisabled.TabIndex = 67
        Me.chkDisabled.Text = "Disable Student"
        Me.chkDisabled.UseVisualStyleBackColor = True
        '
        'cmbxPostingAcGroup
        '
        Me.cmbxPostingAcGroup.AllowDrop = True
        Me.cmbxPostingAcGroup.FormattingEnabled = True
        Me.cmbxPostingAcGroup.Location = New System.Drawing.Point(262, 180)
        Me.cmbxPostingAcGroup.MaxLength = 100
        Me.cmbxPostingAcGroup.Name = "cmbxPostingAcGroup"
        Me.cmbxPostingAcGroup.Size = New System.Drawing.Size(226, 21)
        Me.cmbxPostingAcGroup.TabIndex = 59
        '
        'lblPostingAcGroup
        '
        Me.lblPostingAcGroup.AutoSize = True
        Me.lblPostingAcGroup.ForeColor = System.Drawing.Color.Sienna
        Me.lblPostingAcGroup.Location = New System.Drawing.Point(133, 184)
        Me.lblPostingAcGroup.Name = "lblPostingAcGroup"
        Me.lblPostingAcGroup.Size = New System.Drawing.Size(123, 13)
        Me.lblPostingAcGroup.TabIndex = 60
        Me.lblPostingAcGroup.Text = "Posting Account Group :"
        '
        'txtUnitOfMeasure
        '
        Me.txtUnitOfMeasure.Location = New System.Drawing.Point(262, 158)
        Me.txtUnitOfMeasure.MaxLength = 10
        Me.txtUnitOfMeasure.Name = "txtUnitOfMeasure"
        Me.txtUnitOfMeasure.Size = New System.Drawing.Size(76, 20)
        Me.txtUnitOfMeasure.TabIndex = 57
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.ForeColor = System.Drawing.Color.Sienna
        Me.lblUOM.Location = New System.Drawing.Point(168, 161)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(88, 13)
        Me.lblUOM.TabIndex = 58
        Me.lblUOM.Text = "Unit of Measure :"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(262, 113)
        Me.txtProductName.MaxLength = 125
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(292, 20)
        Me.txtProductName.TabIndex = 52
        '
        'cmbxCategory
        '
        Me.cmbxCategory.AllowDrop = True
        Me.cmbxCategory.FormattingEnabled = True
        Me.cmbxCategory.Location = New System.Drawing.Point(262, 135)
        Me.cmbxCategory.MaxLength = 50
        Me.cmbxCategory.Name = "cmbxCategory"
        Me.cmbxCategory.Size = New System.Drawing.Size(226, 21)
        Me.cmbxCategory.TabIndex = 53
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.Sienna
        Me.lblCategory.Location = New System.Drawing.Point(201, 139)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(55, 13)
        Me.lblCategory.TabIndex = 55
        Me.lblCategory.Text = "Category :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Sienna
        Me.lblName.Location = New System.Drawing.Point(175, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 13)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "Product Name :"
        '
        'TabProductLst
        '
        Me.TabProductLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabProductLst.Controls.Add(Me.dtgdProductLst)
        Me.TabProductLst.Location = New System.Drawing.Point(4, 22)
        Me.TabProductLst.Name = "TabProductLst"
        Me.TabProductLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductLst.Size = New System.Drawing.Size(1202, 578)
        Me.TabProductLst.TabIndex = 1
        Me.TabProductLst.Text = "List"
        '
        'dtgdProductLst
        '
        Me.dtgdProductLst.Location = New System.Drawing.Point(6, 7)
        Me.dtgdProductLst.Name = "dtgdProductLst"
        Me.dtgdProductLst.Size = New System.Drawing.Size(1190, 565)
        Me.dtgdProductLst.TabIndex = 0
        '
        'frmMstSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlProductMst)
        Me.Name = "frmMstSubject"
        Me.Text = "frmMstSubject"
        Me.tctrlProductMst.ResumeLayout(False)
        Me.TabProductDtl.ResumeLayout(False)
        Me.gboxProductDtl.ResumeLayout(False)
        Me.gboxProductDtl.PerformLayout()
        Me.TabProductLst.ResumeLayout(False)
        CType(Me.dtgdProductLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlProductMst As TabControl
    Friend WithEvents TabProductDtl As TabPage
    Friend WithEvents gboxProductDtl As GroupBox
    Friend WithEvents chkDisabled As CheckBox
    Friend WithEvents cmbxPostingAcGroup As ComboBox
    Friend WithEvents lblPostingAcGroup As Label
    Friend WithEvents txtUnitOfMeasure As TextBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbxCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TabProductLst As TabPage
    Friend WithEvents dtgdProductLst As DataGridView
End Class
