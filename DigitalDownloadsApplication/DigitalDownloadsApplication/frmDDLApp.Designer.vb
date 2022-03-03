<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDDLApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDDLApp))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbl99Cents = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblOohFancy = New System.Windows.Forms.Label()
        Me.btnCalcCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblFinalCost = New System.Windows.Forms.Label()
        Me.picDudeJamming = New System.Windows.Forms.PictureBox()
        Me.picBG = New System.Windows.Forms.PictureBox()
        CType(Me.picDudeJamming, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(131, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(211, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Digital Downloads!"
        '
        'lbl99Cents
        '
        Me.lbl99Cents.AutoSize = True
        Me.lbl99Cents.ForeColor = System.Drawing.Color.Teal
        Me.lbl99Cents.Location = New System.Drawing.Point(150, 46)
        Me.lbl99Cents.Name = "lbl99Cents"
        Me.lbl99Cents.Size = New System.Drawing.Size(88, 19)
        Me.lbl99Cents.TabIndex = 1
        Me.lbl99Cents.Text = "Test Text"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPrompt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrompt.Location = New System.Drawing.Point(31, 110)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(207, 16)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Number of Songs to Download:"
        '
        'lblOohFancy
        '
        Me.lblOohFancy.AutoSize = True
        Me.lblOohFancy.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOohFancy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblOohFancy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOohFancy.Location = New System.Drawing.Point(69, 142)
        Me.lblOohFancy.Name = "lblOohFancy"
        Me.lblOohFancy.Size = New System.Drawing.Size(169, 16)
        Me.lblOohFancy.TabIndex = 3
        Me.lblOohFancy.Text = "Total Cost of Downloads:"
        '
        'btnCalcCost
        '
        Me.btnCalcCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcCost.ForeColor = System.Drawing.Color.Teal
        Me.btnCalcCost.Location = New System.Drawing.Point(12, 187)
        Me.btnCalcCost.Name = "btnCalcCost"
        Me.btnCalcCost.Size = New System.Drawing.Size(137, 35)
        Me.btnCalcCost.TabIndex = 5
        Me.btnCalcCost.Text = "Calculate Cost"
        Me.btnCalcCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.Color.Teal
        Me.btnClear.Location = New System.Drawing.Point(168, 187)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(324, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tbxInput
        '
        Me.tbxInput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbxInput.Location = New System.Drawing.Point(277, 107)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(58, 23)
        Me.tbxInput.TabIndex = 8
        Me.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFinalCost
        '
        Me.lblFinalCost.AutoSize = True
        Me.lblFinalCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFinalCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblFinalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFinalCost.Location = New System.Drawing.Point(274, 142)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(68, 16)
        Me.lblFinalCost.TabIndex = 9
        Me.lblFinalCost.Text = "Test Text"
        Me.lblFinalCost.Visible = False
        '
        'picDudeJamming
        '
        Me.picDudeJamming.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDudeJamming.Image = Global.DigitalDownloadsApplication.My.Resources.Resources.Dude_Jamming_Out
        Me.picDudeJamming.Location = New System.Drawing.Point(-7, 228)
        Me.picDudeJamming.Name = "picDudeJamming"
        Me.picDudeJamming.Size = New System.Drawing.Size(487, 313)
        Me.picDudeJamming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDudeJamming.TabIndex = 10
        Me.picDudeJamming.TabStop = False
        '
        'picBG
        '
        Me.picBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBG.Location = New System.Drawing.Point(12, 85)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(449, 96)
        Me.picBG.TabIndex = 4
        Me.picBG.TabStop = False
        '
        'frmDDLApp
        '
        Me.AcceptButton = Me.btnCalcCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(473, 381)
        Me.Controls.Add(Me.picDudeJamming)
        Me.Controls.Add(Me.lblFinalCost)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcCost)
        Me.Controls.Add(Me.lblOohFancy)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lbl99Cents)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBG)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmDDLApp"
        Me.Text = "Ethan Anderson's Digital Downloads"
        CType(Me.picDudeJamming, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbl99Cents As System.Windows.Forms.Label
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblOohFancy As System.Windows.Forms.Label
    Friend WithEvents picBG As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalcCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tbxInput As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalCost As System.Windows.Forms.Label
    Friend WithEvents picDudeJamming As System.Windows.Forms.PictureBox

End Class
