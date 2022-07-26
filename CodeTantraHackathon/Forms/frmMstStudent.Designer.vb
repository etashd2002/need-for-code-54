<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstStudent
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
        Me.dtpStudentDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblStudentDOB = New System.Windows.Forms.Label()
        Me.cmbxStudentYear = New System.Windows.Forms.ComboBox()
        Me.lblStudentYear = New System.Windows.Forms.Label()
        Me.txtParentContactNo = New System.Windows.Forms.TextBox()
        Me.lblParentContactNo = New System.Windows.Forms.Label()
        Me.txtStudentContactNo = New System.Windows.Forms.TextBox()
        Me.lblStudentContactNo = New System.Windows.Forms.Label()
        Me.txtStudentEmail = New System.Windows.Forms.TextBox()
        Me.lblStudentEmail = New System.Windows.Forms.Label()
        Me.cmbxStudentClass = New System.Windows.Forms.ComboBox()
        Me.lblStudentClass = New System.Windows.Forms.Label()
        Me.chkDisabled = New System.Windows.Forms.CheckBox()
        Me.txtStudentCode = New System.Windows.Forms.TextBox()
        Me.lblStudentCode = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabProductLst = New System.Windows.Forms.TabPage()
        Me.dtgdProductLst = New System.Windows.Forms.DataGridView()
        Me.txtStudentAddress = New System.Windows.Forms.TextBox()
        Me.lblStudentAddress = New System.Windows.Forms.Label()
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
        Me.tctrlProductMst.TabIndex = 3
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
        Me.gboxProductDtl.Controls.Add(Me.txtStudentAddress)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentAddress)
        Me.gboxProductDtl.Controls.Add(Me.dtpStudentDOB)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentDOB)
        Me.gboxProductDtl.Controls.Add(Me.cmbxStudentYear)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentYear)
        Me.gboxProductDtl.Controls.Add(Me.txtParentContactNo)
        Me.gboxProductDtl.Controls.Add(Me.lblParentContactNo)
        Me.gboxProductDtl.Controls.Add(Me.txtStudentContactNo)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentContactNo)
        Me.gboxProductDtl.Controls.Add(Me.txtStudentEmail)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentEmail)
        Me.gboxProductDtl.Controls.Add(Me.cmbxStudentClass)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentClass)
        Me.gboxProductDtl.Controls.Add(Me.chkDisabled)
        Me.gboxProductDtl.Controls.Add(Me.txtStudentCode)
        Me.gboxProductDtl.Controls.Add(Me.lblStudentCode)
        Me.gboxProductDtl.Controls.Add(Me.txtStudentName)
        Me.gboxProductDtl.Controls.Add(Me.lblName)
        Me.gboxProductDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxProductDtl.Name = "gboxProductDtl"
        Me.gboxProductDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxProductDtl.TabIndex = 30
        Me.gboxProductDtl.TabStop = False
        '
        'dtpStudentDOB
        '
        Me.dtpStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStudentDOB.Location = New System.Drawing.Point(244, 249)
        Me.dtpStudentDOB.Name = "dtpStudentDOB"
        Me.dtpStudentDOB.Size = New System.Drawing.Size(109, 20)
        Me.dtpStudentDOB.TabIndex = 80
        Me.dtpStudentDOB.Value = New Date(2022, 7, 26, 13, 17, 23, 0)
        '
        'lblStudentDOB
        '
        Me.lblStudentDOB.AutoSize = True
        Me.lblStudentDOB.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentDOB.Location = New System.Drawing.Point(162, 252)
        Me.lblStudentDOB.Name = "lblStudentDOB"
        Me.lblStudentDOB.Size = New System.Drawing.Size(76, 13)
        Me.lblStudentDOB.TabIndex = 79
        Me.lblStudentDOB.Text = "Student DOB :"
        '
        'cmbxStudentYear
        '
        Me.cmbxStudentYear.AllowDrop = True
        Me.cmbxStudentYear.FormattingEnabled = True
        Me.cmbxStudentYear.Location = New System.Drawing.Point(244, 222)
        Me.cmbxStudentYear.MaxLength = 50
        Me.cmbxStudentYear.Name = "cmbxStudentYear"
        Me.cmbxStudentYear.Size = New System.Drawing.Size(93, 21)
        Me.cmbxStudentYear.TabIndex = 78
        '
        'lblStudentYear
        '
        Me.lblStudentYear.AutoSize = True
        Me.lblStudentYear.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentYear.Location = New System.Drawing.Point(163, 225)
        Me.lblStudentYear.Name = "lblStudentYear"
        Me.lblStudentYear.Size = New System.Drawing.Size(75, 13)
        Me.lblStudentYear.TabIndex = 77
        Me.lblStudentYear.Text = "Student Year :"
        '
        'txtParentContactNo
        '
        Me.txtParentContactNo.Location = New System.Drawing.Point(244, 196)
        Me.txtParentContactNo.MaxLength = 10
        Me.txtParentContactNo.Name = "txtParentContactNo"
        Me.txtParentContactNo.Size = New System.Drawing.Size(292, 20)
        Me.txtParentContactNo.TabIndex = 75
        '
        'lblParentContactNo
        '
        Me.lblParentContactNo.AutoSize = True
        Me.lblParentContactNo.ForeColor = System.Drawing.Color.Sienna
        Me.lblParentContactNo.Location = New System.Drawing.Point(134, 199)
        Me.lblParentContactNo.Name = "lblParentContactNo"
        Me.lblParentContactNo.Size = New System.Drawing.Size(104, 13)
        Me.lblParentContactNo.TabIndex = 76
        Me.lblParentContactNo.Text = "Parent Contact No. :"
        '
        'txtStudentContactNo
        '
        Me.txtStudentContactNo.Location = New System.Drawing.Point(244, 170)
        Me.txtStudentContactNo.MaxLength = 10
        Me.txtStudentContactNo.Name = "txtStudentContactNo"
        Me.txtStudentContactNo.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentContactNo.TabIndex = 73
        '
        'lblStudentContactNo
        '
        Me.lblStudentContactNo.AutoSize = True
        Me.lblStudentContactNo.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentContactNo.Location = New System.Drawing.Point(128, 173)
        Me.lblStudentContactNo.Name = "lblStudentContactNo"
        Me.lblStudentContactNo.Size = New System.Drawing.Size(110, 13)
        Me.lblStudentContactNo.TabIndex = 74
        Me.lblStudentContactNo.Text = "Student Contact No. :"
        '
        'txtStudentEmail
        '
        Me.txtStudentEmail.Location = New System.Drawing.Point(244, 144)
        Me.txtStudentEmail.MaxLength = 100
        Me.txtStudentEmail.Name = "txtStudentEmail"
        Me.txtStudentEmail.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentEmail.TabIndex = 71
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.AutoSize = True
        Me.lblStudentEmail.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentEmail.Location = New System.Drawing.Point(160, 147)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentEmail.TabIndex = 72
        Me.lblStudentEmail.Text = "Student Email :"
        '
        'cmbxStudentClass
        '
        Me.cmbxStudentClass.AllowDrop = True
        Me.cmbxStudentClass.FormattingEnabled = True
        Me.cmbxStudentClass.Location = New System.Drawing.Point(244, 117)
        Me.cmbxStudentClass.MaxLength = 50
        Me.cmbxStudentClass.Name = "cmbxStudentClass"
        Me.cmbxStudentClass.Size = New System.Drawing.Size(93, 21)
        Me.cmbxStudentClass.TabIndex = 70
        '
        'lblStudentClass
        '
        Me.lblStudentClass.AutoSize = True
        Me.lblStudentClass.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentClass.Location = New System.Drawing.Point(160, 120)
        Me.lblStudentClass.Name = "lblStudentClass"
        Me.lblStudentClass.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentClass.TabIndex = 69
        Me.lblStudentClass.Text = "Student Class :"
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
        'txtStudentCode
        '
        Me.txtStudentCode.Location = New System.Drawing.Point(244, 91)
        Me.txtStudentCode.MaxLength = 10
        Me.txtStudentCode.Name = "txtStudentCode"
        Me.txtStudentCode.Size = New System.Drawing.Size(93, 20)
        Me.txtStudentCode.TabIndex = 57
        '
        'lblStudentCode
        '
        Me.lblStudentCode.AutoSize = True
        Me.lblStudentCode.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentCode.Location = New System.Drawing.Point(160, 94)
        Me.lblStudentCode.Name = "lblStudentCode"
        Me.lblStudentCode.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentCode.TabIndex = 58
        Me.lblStudentCode.Text = "Student Code :"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(244, 65)
        Me.txtStudentName.MaxLength = 125
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentName.TabIndex = 52
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Sienna
        Me.lblName.Location = New System.Drawing.Point(157, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 13)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "Student Name :"
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
        'txtStudentAddress
        '
        Me.txtStudentAddress.Location = New System.Drawing.Point(244, 275)
        Me.txtStudentAddress.MaxLength = 4000
        Me.txtStudentAddress.Multiline = True
        Me.txtStudentAddress.Name = "txtStudentAddress"
        Me.txtStudentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentAddress.Size = New System.Drawing.Size(292, 58)
        Me.txtStudentAddress.TabIndex = 81
        '
        'lblStudentAddress
        '
        Me.lblStudentAddress.AutoSize = True
        Me.lblStudentAddress.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentAddress.Location = New System.Drawing.Point(147, 278)
        Me.lblStudentAddress.Name = "lblStudentAddress"
        Me.lblStudentAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblStudentAddress.TabIndex = 82
        Me.lblStudentAddress.Text = "Student Address :"
        '
        'frmMstStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlProductMst)
        Me.Name = "frmMstStudent"
        Me.Text = "Students"
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
    Friend WithEvents txtStudentCode As TextBox
    Friend WithEvents lblStudentCode As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents TabProductLst As TabPage
    Friend WithEvents dtgdProductLst As DataGridView
    Friend WithEvents dtpStudentDOB As DateTimePicker
    Friend WithEvents lblStudentDOB As Label
    Friend WithEvents cmbxStudentYear As ComboBox
    Friend WithEvents lblStudentYear As Label
    Friend WithEvents txtParentContactNo As TextBox
    Friend WithEvents lblParentContactNo As Label
    Friend WithEvents txtStudentContactNo As TextBox
    Friend WithEvents lblStudentContactNo As Label
    Friend WithEvents txtStudentEmail As TextBox
    Friend WithEvents lblStudentEmail As Label
    Friend WithEvents cmbxStudentClass As ComboBox
    Friend WithEvents lblStudentClass As Label
    Friend WithEvents txtStudentAddress As TextBox
    Friend WithEvents lblStudentAddress As Label
End Class
