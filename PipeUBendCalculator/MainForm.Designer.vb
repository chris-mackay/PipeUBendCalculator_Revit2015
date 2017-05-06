<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblDimensionH = New System.Windows.Forms.Label()
        Me.txtDimensionH = New System.Windows.Forms.TextBox()
        Me.lblDimensionW = New System.Windows.Forms.Label()
        Me.txtDimensionW = New System.Windows.Forms.TextBox()
        Me.lblDimensionL = New System.Windows.Forms.Label()
        Me.txtDimensionL = New System.Windows.Forms.TextBox()
        Me.lblModulus = New System.Windows.Forms.Label()
        Me.txtModulus = New System.Windows.Forms.TextBox()
        Me.lblAllowableStressRange = New System.Windows.Forms.Label()
        Me.txtAllowableStressRange = New System.Windows.Forms.TextBox()
        Me.lblPipeSize = New System.Windows.Forms.Label()
        Me.cbPipeSizes = New System.Windows.Forms.ComboBox()
        Me.lblPipeLength = New System.Windows.Forms.Label()
        Me.txtPipeLength = New System.Windows.Forms.TextBox()
        Me.lblExpansion = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.gbPipeMaterial = New System.Windows.Forms.GroupBox()
        Me.rbCopper = New System.Windows.Forms.RadioButton()
        Me.rbCarbonSteel = New System.Windows.Forms.RadioButton()
        Me.cbTemperature = New System.Windows.Forms.ComboBox()
        Me.txtLinearExpansion = New System.Windows.Forms.TextBox()
        Me.gbPipeMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDimensionH
        '
        Me.lblDimensionH.AutoSize = True
        Me.lblDimensionH.BackColor = System.Drawing.Color.Transparent
        Me.lblDimensionH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDimensionH.Location = New System.Drawing.Point(198, 242)
        Me.lblDimensionH.Name = "lblDimensionH"
        Me.lblDimensionH.Size = New System.Drawing.Size(53, 13)
        Me.lblDimensionH.TabIndex = 57
        Me.lblDimensionH.Text = "Height (ft)"
        '
        'txtDimensionH
        '
        Me.txtDimensionH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtDimensionH.Location = New System.Drawing.Point(198, 260)
        Me.txtDimensionH.Name = "txtDimensionH"
        Me.txtDimensionH.ReadOnly = True
        Me.txtDimensionH.Size = New System.Drawing.Size(146, 20)
        Me.txtDimensionH.TabIndex = 58
        '
        'lblDimensionW
        '
        Me.lblDimensionW.AutoSize = True
        Me.lblDimensionW.BackColor = System.Drawing.Color.Transparent
        Me.lblDimensionW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDimensionW.Location = New System.Drawing.Point(198, 197)
        Me.lblDimensionW.Name = "lblDimensionW"
        Me.lblDimensionW.Size = New System.Drawing.Size(50, 13)
        Me.lblDimensionW.TabIndex = 55
        Me.lblDimensionW.Text = "Width (ft)"
        '
        'txtDimensionW
        '
        Me.txtDimensionW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtDimensionW.Location = New System.Drawing.Point(198, 215)
        Me.txtDimensionW.Name = "txtDimensionW"
        Me.txtDimensionW.ReadOnly = True
        Me.txtDimensionW.Size = New System.Drawing.Size(146, 20)
        Me.txtDimensionW.TabIndex = 56
        '
        'lblDimensionL
        '
        Me.lblDimensionL.AutoSize = True
        Me.lblDimensionL.BackColor = System.Drawing.Color.Transparent
        Me.lblDimensionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDimensionL.Location = New System.Drawing.Point(198, 152)
        Me.lblDimensionL.Name = "lblDimensionL"
        Me.lblDimensionL.Size = New System.Drawing.Size(94, 13)
        Me.lblDimensionL.TabIndex = 53
        Me.lblDimensionL.Text = "U Bend Length (ft)"
        '
        'txtDimensionL
        '
        Me.txtDimensionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtDimensionL.Location = New System.Drawing.Point(198, 170)
        Me.txtDimensionL.Name = "txtDimensionL"
        Me.txtDimensionL.ReadOnly = True
        Me.txtDimensionL.Size = New System.Drawing.Size(146, 20)
        Me.txtDimensionL.TabIndex = 54
        '
        'lblModulus
        '
        Me.lblModulus.AutoSize = True
        Me.lblModulus.BackColor = System.Drawing.Color.Transparent
        Me.lblModulus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblModulus.Location = New System.Drawing.Point(198, 107)
        Me.lblModulus.Name = "lblModulus"
        Me.lblModulus.Size = New System.Drawing.Size(103, 13)
        Me.lblModulus.TabIndex = 51
        Me.lblModulus.Text = "Modulus of Elasticity"
        '
        'txtModulus
        '
        Me.txtModulus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtModulus.Location = New System.Drawing.Point(198, 125)
        Me.txtModulus.Name = "txtModulus"
        Me.txtModulus.ReadOnly = True
        Me.txtModulus.Size = New System.Drawing.Size(146, 20)
        Me.txtModulus.TabIndex = 52
        '
        'lblAllowableStressRange
        '
        Me.lblAllowableStressRange.AutoSize = True
        Me.lblAllowableStressRange.BackColor = System.Drawing.Color.Transparent
        Me.lblAllowableStressRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblAllowableStressRange.Location = New System.Drawing.Point(198, 62)
        Me.lblAllowableStressRange.Name = "lblAllowableStressRange"
        Me.lblAllowableStressRange.Size = New System.Drawing.Size(119, 13)
        Me.lblAllowableStressRange.TabIndex = 49
        Me.lblAllowableStressRange.Text = "Allowable Stress Range"
        '
        'txtAllowableStressRange
        '
        Me.txtAllowableStressRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtAllowableStressRange.Location = New System.Drawing.Point(198, 80)
        Me.txtAllowableStressRange.Name = "txtAllowableStressRange"
        Me.txtAllowableStressRange.ReadOnly = True
        Me.txtAllowableStressRange.Size = New System.Drawing.Size(146, 20)
        Me.txtAllowableStressRange.TabIndex = 50
        '
        'lblPipeSize
        '
        Me.lblPipeSize.AutoSize = True
        Me.lblPipeSize.BackColor = System.Drawing.Color.Transparent
        Me.lblPipeSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblPipeSize.Location = New System.Drawing.Point(19, 62)
        Me.lblPipeSize.Name = "lblPipeSize"
        Me.lblPipeSize.Size = New System.Drawing.Size(51, 13)
        Me.lblPipeSize.TabIndex = 42
        Me.lblPipeSize.Text = "Pipe Size"
        '
        'cbPipeSizes
        '
        Me.cbPipeSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPipeSizes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cbPipeSizes.FormattingEnabled = True
        Me.cbPipeSizes.Location = New System.Drawing.Point(19, 80)
        Me.cbPipeSizes.Name = "cbPipeSizes"
        Me.cbPipeSizes.Size = New System.Drawing.Size(146, 21)
        Me.cbPipeSizes.TabIndex = 43
        '
        'lblPipeLength
        '
        Me.lblPipeLength.AutoSize = True
        Me.lblPipeLength.BackColor = System.Drawing.Color.Transparent
        Me.lblPipeLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblPipeLength.Location = New System.Drawing.Point(19, 107)
        Me.lblPipeLength.Name = "lblPipeLength"
        Me.lblPipeLength.Size = New System.Drawing.Size(73, 13)
        Me.lblPipeLength.TabIndex = 44
        Me.lblPipeLength.Text = "Pipe Length ft"
        '
        'txtPipeLength
        '
        Me.txtPipeLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtPipeLength.Location = New System.Drawing.Point(19, 125)
        Me.txtPipeLength.Name = "txtPipeLength"
        Me.txtPipeLength.Size = New System.Drawing.Size(146, 20)
        Me.txtPipeLength.TabIndex = 45
        '
        'lblExpansion
        '
        Me.lblExpansion.AutoSize = True
        Me.lblExpansion.BackColor = System.Drawing.Color.Transparent
        Me.lblExpansion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblExpansion.Location = New System.Drawing.Point(198, 17)
        Me.lblExpansion.Name = "lblExpansion"
        Me.lblExpansion.Size = New System.Drawing.Size(131, 13)
        Me.lblExpansion.TabIndex = 47
        Me.lblExpansion.Text = "Linear Expansion in/100 ft"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.BackColor = System.Drawing.Color.Transparent
        Me.lblTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTemperature.Location = New System.Drawing.Point(19, 17)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(92, 13)
        Me.lblTemperature.TabIndex = 40
        Me.lblTemperature.Text = "Fluid Temperature"
        '
        'gbPipeMaterial
        '
        Me.gbPipeMaterial.Controls.Add(Me.rbCopper)
        Me.gbPipeMaterial.Controls.Add(Me.rbCarbonSteel)
        Me.gbPipeMaterial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.gbPipeMaterial.Location = New System.Drawing.Point(19, 160)
        Me.gbPipeMaterial.Name = "gbPipeMaterial"
        Me.gbPipeMaterial.Size = New System.Drawing.Size(146, 120)
        Me.gbPipeMaterial.TabIndex = 46
        Me.gbPipeMaterial.TabStop = False
        Me.gbPipeMaterial.Text = "Pipe Material"
        '
        'rbCopper
        '
        Me.rbCopper.AutoSize = True
        Me.rbCopper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbCopper.Location = New System.Drawing.Point(22, 52)
        Me.rbCopper.Name = "rbCopper"
        Me.rbCopper.Size = New System.Drawing.Size(59, 17)
        Me.rbCopper.TabIndex = 1
        Me.rbCopper.Text = "Copper"
        Me.rbCopper.UseVisualStyleBackColor = True
        '
        'rbCarbonSteel
        '
        Me.rbCarbonSteel.AutoSize = True
        Me.rbCarbonSteel.Checked = True
        Me.rbCarbonSteel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.rbCarbonSteel.Location = New System.Drawing.Point(22, 29)
        Me.rbCarbonSteel.Name = "rbCarbonSteel"
        Me.rbCarbonSteel.Size = New System.Drawing.Size(86, 17)
        Me.rbCarbonSteel.TabIndex = 0
        Me.rbCarbonSteel.TabStop = True
        Me.rbCarbonSteel.Text = "Carbon Steel"
        Me.rbCarbonSteel.UseVisualStyleBackColor = True
        '
        'cbTemperature
        '
        Me.cbTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cbTemperature.FormattingEnabled = True
        Me.cbTemperature.Items.AddRange(New Object() {"100°F", "120°F", "140°F", "160°F", "180°F", "200°F", "212°F", "220°F", "240°F"})
        Me.cbTemperature.Location = New System.Drawing.Point(19, 35)
        Me.cbTemperature.Name = "cbTemperature"
        Me.cbTemperature.Size = New System.Drawing.Size(146, 21)
        Me.cbTemperature.TabIndex = 41
        '
        'txtLinearExpansion
        '
        Me.txtLinearExpansion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtLinearExpansion.Location = New System.Drawing.Point(198, 35)
        Me.txtLinearExpansion.Name = "txtLinearExpansion"
        Me.txtLinearExpansion.ReadOnly = True
        Me.txtLinearExpansion.Size = New System.Drawing.Size(146, 20)
        Me.txtLinearExpansion.TabIndex = 48
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(362, 308)
        Me.Controls.Add(Me.lblDimensionH)
        Me.Controls.Add(Me.txtDimensionH)
        Me.Controls.Add(Me.lblDimensionW)
        Me.Controls.Add(Me.txtDimensionW)
        Me.Controls.Add(Me.lblDimensionL)
        Me.Controls.Add(Me.txtDimensionL)
        Me.Controls.Add(Me.lblModulus)
        Me.Controls.Add(Me.txtModulus)
        Me.Controls.Add(Me.lblAllowableStressRange)
        Me.Controls.Add(Me.txtAllowableStressRange)
        Me.Controls.Add(Me.lblPipeSize)
        Me.Controls.Add(Me.cbPipeSizes)
        Me.Controls.Add(Me.lblPipeLength)
        Me.Controls.Add(Me.txtPipeLength)
        Me.Controls.Add(Me.lblExpansion)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.gbPipeMaterial)
        Me.Controls.Add(Me.cbTemperature)
        Me.Controls.Add(Me.txtLinearExpansion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pipe U Bend Calculator"
        Me.gbPipeMaterial.ResumeLayout(False)
        Me.gbPipeMaterial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDimensionH As System.Windows.Forms.Label
    Friend WithEvents txtDimensionH As System.Windows.Forms.TextBox
    Friend WithEvents lblDimensionW As System.Windows.Forms.Label
    Friend WithEvents txtDimensionW As System.Windows.Forms.TextBox
    Friend WithEvents lblDimensionL As System.Windows.Forms.Label
    Friend WithEvents txtDimensionL As System.Windows.Forms.TextBox
    Friend WithEvents lblModulus As System.Windows.Forms.Label
    Friend WithEvents txtModulus As System.Windows.Forms.TextBox
    Friend WithEvents lblAllowableStressRange As System.Windows.Forms.Label
    Friend WithEvents txtAllowableStressRange As System.Windows.Forms.TextBox
    Friend WithEvents lblPipeSize As System.Windows.Forms.Label
    Friend WithEvents cbPipeSizes As System.Windows.Forms.ComboBox
    Friend WithEvents lblPipeLength As System.Windows.Forms.Label
    Friend WithEvents txtPipeLength As System.Windows.Forms.TextBox
    Friend WithEvents lblExpansion As System.Windows.Forms.Label
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents gbPipeMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents rbCopper As System.Windows.Forms.RadioButton
    Friend WithEvents rbCarbonSteel As System.Windows.Forms.RadioButton
    Friend WithEvents cbTemperature As System.Windows.Forms.ComboBox
    Friend WithEvents txtLinearExpansion As System.Windows.Forms.TextBox
End Class
