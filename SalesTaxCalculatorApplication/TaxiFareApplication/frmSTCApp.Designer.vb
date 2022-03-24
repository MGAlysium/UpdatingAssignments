<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxiFareApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaxiFareApp))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.picTaxi = New System.Windows.Forms.PictureBox()
        Me.picBG = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblFinalCost = New System.Windows.Forms.Label()
        Me.lblTicketCost = New System.Windows.Forms.Label()
        Me.btnCalcCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInitCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        CType(Me.picTaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(87, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(216, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Walmart Sale's Tax"
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDirections.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDirections.Location = New System.Drawing.Point(30, 79)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(99, 16)
        Me.lblDirections.TabIndex = 3
        Me.lblDirections.Text = "Name of Item:"
        Me.lblDirections.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picTaxi
        '
        Me.picTaxi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTaxi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picTaxi.Image = Global.TaxiFareApplication.My.Resources.Resources.Walmart
        Me.picTaxi.Location = New System.Drawing.Point(-4, 214)
        Me.picTaxi.Name = "picTaxi"
        Me.picTaxi.Size = New System.Drawing.Size(396, 182)
        Me.picTaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTaxi.TabIndex = 2
        Me.picTaxi.TabStop = False
        '
        'picBG
        '
        Me.picBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBG.Location = New System.Drawing.Point(12, 66)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(364, 100)
        Me.picBG.TabIndex = 1
        Me.picBG.TabStop = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(135, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(52, 23)
        Me.txtName.TabIndex = 0
        '
        'lblFinalCost
        '
        Me.lblFinalCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFinalCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFinalCost.Location = New System.Drawing.Point(98, 113)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(192, 32)
        Me.lblFinalCost.TabIndex = 4
        Me.lblFinalCost.Text = "Item: Name     Cost: $XX.XX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax: $XX.XX     Final: $XX.XX"
        Me.lblFinalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblFinalCost.Visible = False
        '
        'lblTicketCost
        '
        Me.lblTicketCost.AutoSize = True
        Me.lblTicketCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCost.ForeColor = System.Drawing.Color.Teal
        Me.lblTicketCost.Location = New System.Drawing.Point(81, 44)
        Me.lblTicketCost.Name = "lblTicketCost"
        Me.lblTicketCost.Size = New System.Drawing.Size(227, 19)
        Me.lblTicketCost.TabIndex = 5
        Me.lblTicketCost.Text = "Enter Item Name And Cost"
        '
        'btnCalcCost
        '
        Me.btnCalcCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCost.ForeColor = System.Drawing.Color.Teal
        Me.btnCalcCost.Location = New System.Drawing.Point(12, 173)
        Me.btnCalcCost.Name = "btnCalcCost"
        Me.btnCalcCost.Size = New System.Drawing.Size(117, 35)
        Me.btnCalcCost.TabIndex = 6
        Me.btnCalcCost.Text = "Display Cost"
        Me.btnCalcCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Teal
        Me.btnClear.Location = New System.Drawing.Point(135, 173)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(258, 173)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInitCost
        '
        Me.lblInitCost.AutoSize = True
        Me.lblInitCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInitCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInitCost.Location = New System.Drawing.Point(197, 79)
        Me.lblInitCost.Name = "lblInitCost"
        Me.lblInitCost.Size = New System.Drawing.Size(93, 16)
        Me.lblInitCost.TabIndex = 9
        Me.lblInitCost.Text = "Cost of Item:"
        Me.lblInitCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(296, 76)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(52, 23)
        Me.txtCost.TabIndex = 1
        '
        'frmTaxiFareApp
        '
        Me.AcceptButton = Me.btnCalcCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(389, 352)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblInitCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcCost)
        Me.Controls.Add(Me.lblTicketCost)
        Me.Controls.Add(Me.lblFinalCost)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.picTaxi)
        Me.Controls.Add(Me.picBG)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTaxiFareApp"
        Me.Text = "Ethan Anderson's Tax Calculator"
        CType(Me.picTaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picBG As System.Windows.Forms.PictureBox
    Friend WithEvents picTaxi As System.Windows.Forms.PictureBox
    Friend WithEvents lblDirections As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalCost As System.Windows.Forms.Label
    Friend WithEvents lblTicketCost As System.Windows.Forms.Label
    Friend WithEvents btnCalcCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInitCost As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox

End Class
