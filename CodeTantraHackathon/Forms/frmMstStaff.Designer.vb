<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstStaff
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
        Me.tctrlStaffMst = New System.Windows.Forms.TabControl()
        Me.TabStaffDtl = New System.Windows.Forms.TabPage()
        Me.gboxStaffDtl = New System.Windows.Forms.GroupBox()
        Me.cmbxPostingAcGroup = New System.Windows.Forms.ComboBox()
        Me.lblPostingAcGroup = New System.Windows.Forms.Label()
        Me.txtUnitOfMeasure = New System.Windows.Forms.TextBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.cmbxCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabStaffLst = New System.Windows.Forms.TabPage()
        Me.dtgdStaffLst = New System.Windows.Forms.DataGridView()
        Me.tctrlStaffMst.SuspendLayout()
        Me.TabStaffDtl.SuspendLayout()
        Me.gboxStaffDtl.SuspendLayout()
        Me.TabStaffLst.SuspendLayout()
        CType(Me.dtgdStaffLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlStaffMst
        '
        Me.tctrlStaffMst.Controls.Add(Me.TabStaffDtl)
        Me.tctrlStaffMst.Controls.Add(Me.TabStaffLst)
        Me.tctrlStaffMst.Location = New System.Drawing.Point(12, 12)
        Me.tctrlStaffMst.Name = "tctrlStaffMst"
        Me.tctrlStaffMst.SelectedIndex = 0
        Me.tctrlStaffMst.Size = New System.Drawing.Size(1210, 604)
        Me.tctrlStaffMst.TabIndex = 5
        '
        'TabStaffDtl
        '
        Me.TabStaffDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabStaffDtl.Controls.Add(Me.gboxStaffDtl)
        Me.TabStaffDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabStaffDtl.Name = "TabStaffDtl"
        Me.TabStaffDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStaffDtl.Size = New System.Drawing.Size(1202, 578)
        Me.TabStaffDtl.TabIndex = 0
        Me.TabStaffDtl.Text = "Add/Update/Delete"
        '
        'gboxStaffDtl
        '
        Me.gboxStaffDtl.Controls.Add(Me.cmbxPostingAcGroup)
        Me.gboxStaffDtl.Controls.Add(Me.lblPostingAcGroup)
        Me.gboxStaffDtl.Controls.Add(Me.txtUnitOfMeasure)
        Me.gboxStaffDtl.Controls.Add(Me.lblUOM)
        Me.gboxStaffDtl.Controls.Add(Me.txtProductName)
        Me.gboxStaffDtl.Controls.Add(Me.cmbxCategory)
        Me.gboxStaffDtl.Controls.Add(Me.lblCategory)
        Me.gboxStaffDtl.Controls.Add(Me.lblName)
        Me.gboxStaffDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxStaffDtl.Name = "gboxStaffDtl"
        Me.gboxStaffDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxStaffDtl.TabIndex = 30
        Me.gboxStaffDtl.TabStop = False
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
        'TabStaffLst
        '
        Me.TabStaffLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabStaffLst.Controls.Add(Me.dtgdStaffLst)
        Me.TabStaffLst.Location = New System.Drawing.Point(4, 22)
        Me.TabStaffLst.Name = "TabStaffLst"
        Me.TabStaffLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStaffLst.Size = New System.Drawing.Size(1202, 578)
        Me.TabStaffLst.TabIndex = 1
        Me.TabStaffLst.Text = "List"
        '
        'dtgdStaffLst
        '
        Me.dtgdStaffLst.Location = New System.Drawing.Point(6, 7)
        Me.dtgdStaffLst.Name = "dtgdStaffLst"
        Me.dtgdStaffLst.Size = New System.Drawing.Size(1190, 565)
        Me.dtgdStaffLst.TabIndex = 0
        '
        'frmMstStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlStaffMst)
        Me.Name = "frmMstStaff"
        Me.Text = "Staff"
        Me.tctrlStaffMst.ResumeLayout(False)
        Me.TabStaffDtl.ResumeLayout(False)
        Me.gboxStaffDtl.ResumeLayout(False)
        Me.gboxStaffDtl.PerformLayout()
        Me.TabStaffLst.ResumeLayout(False)
        CType(Me.dtgdStaffLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlStaffMst As TabControl
    Friend WithEvents TabStaffDtl As TabPage
    Friend WithEvents gboxStaffDtl As GroupBox
    Friend WithEvents cmbxPostingAcGroup As ComboBox
    Friend WithEvents lblPostingAcGroup As Label
    Friend WithEvents txtUnitOfMeasure As TextBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbxCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TabStaffLst As TabPage
    Friend WithEvents dtgdStaffLst As DataGridView
End Class
