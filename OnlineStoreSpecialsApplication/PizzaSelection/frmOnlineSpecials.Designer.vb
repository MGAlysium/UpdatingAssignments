<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineSpecials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnlineSpecials))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDaily = New System.Windows.Forms.PictureBox()
        Me.picWeekly = New System.Windows.Forms.PictureBox()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.picHoliday = New System.Windows.Forms.PictureBox()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.lblDaily = New System.Windows.Forms.Label()
        Me.lblWeekly = New System.Windows.Forms.Label()
        Me.lblHoliday = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picInfoBG = New System.Windows.Forms.PictureBox()
        Me.lblDailySelect = New System.Windows.Forms.Label()
        Me.lblWeeklySelect = New System.Windows.Forms.Label()
        Me.lblHolidaySelect = New System.Windows.Forms.Label()
        CType(Me.picDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeekly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfoBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Silver
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(118, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(312, 25)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Anderson's Online Emporium"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picDaily
        '
        Me.picDaily.BackColor = System.Drawing.Color.Transparent
        Me.picDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDaily.Image = Global.PizzaSelection.My.Resources.Resources.phone_1_png
        Me.picDaily.Location = New System.Drawing.Point(12, 48)
        Me.picDaily.Name = "picDaily"
        Me.picDaily.Size = New System.Drawing.Size(164, 147)
        Me.picDaily.TabIndex = 2
        Me.picDaily.TabStop = False
        Me.picDaily.Visible = False
        '
        'picWeekly
        '
        Me.picWeekly.BackColor = System.Drawing.Color.Transparent
        Me.picWeekly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picWeekly.Image = Global.PizzaSelection.My.Resources.Resources.tablet_1_png
        Me.picWeekly.Location = New System.Drawing.Point(192, 48)
        Me.picWeekly.Name = "picWeekly"
        Me.picWeekly.Size = New System.Drawing.Size(164, 147)
        Me.picWeekly.TabIndex = 3
        Me.picWeekly.TabStop = False
        Me.picWeekly.Visible = False
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDaily.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.ForeColor = System.Drawing.Color.Teal
        Me.btnDaily.Location = New System.Drawing.Point(13, 201)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(164, 27)
        Me.btnDaily.TabIndex = 4
        Me.btnDaily.Text = "Daily Special"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'picHoliday
        '
        Me.picHoliday.BackColor = System.Drawing.Color.Transparent
        Me.picHoliday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picHoliday.Image = Global.PizzaSelection.My.Resources.Resources.camera_1_png
        Me.picHoliday.Location = New System.Drawing.Point(372, 48)
        Me.picHoliday.Name = "picHoliday"
        Me.picHoliday.Size = New System.Drawing.Size(164, 147)
        Me.picHoliday.TabIndex = 10
        Me.picHoliday.TabStop = False
        Me.picHoliday.Visible = False
        '
        'btnWeekly
        '
        Me.btnWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWeekly.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.ForeColor = System.Drawing.Color.Teal
        Me.btnWeekly.Location = New System.Drawing.Point(192, 201)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(164, 27)
        Me.btnWeekly.TabIndex = 11
        Me.btnWeekly.Text = "Weekly Special"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnHoliday
        '
        Me.btnHoliday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHoliday.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoliday.ForeColor = System.Drawing.Color.Teal
        Me.btnHoliday.Location = New System.Drawing.Point(372, 201)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(164, 27)
        Me.btnHoliday.TabIndex = 12
        Me.btnHoliday.Text = "Holiday Special"
        Me.btnHoliday.UseVisualStyleBackColor = False
        '
        'lblDaily
        '
        Me.lblDaily.AutoSize = True
        Me.lblDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDaily.Location = New System.Drawing.Point(29, 242)
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Size = New System.Drawing.Size(133, 48)
        Me.lblDaily.TabIndex = 13
        Me.lblDaily.Text = "Smart Phone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reg. Price: $99.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale Price: $84.50"
        Me.lblDaily.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblDaily.Visible = False
        '
        'lblWeekly
        '
        Me.lblWeekly.AutoSize = True
        Me.lblWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWeekly.Location = New System.Drawing.Point(204, 242)
        Me.lblWeekly.Name = "lblWeekly"
        Me.lblWeekly.Size = New System.Drawing.Size(141, 48)
        Me.lblWeekly.TabIndex = 14
        Me.lblWeekly.Text = "Tablet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reg. Price: $239.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale Price: $199.95"
        Me.lblWeekly.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWeekly.Visible = False
        '
        'lblHoliday
        '
        Me.lblHoliday.AutoSize = True
        Me.lblHoliday.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoliday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHoliday.Location = New System.Drawing.Point(384, 242)
        Me.lblHoliday.Name = "lblHoliday"
        Me.lblHoliday.Size = New System.Drawing.Size(141, 48)
        Me.lblHoliday.TabIndex = 15
        Me.lblHoliday.Text = "Digital Camera" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reg. Price: $259.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale Price: $203.19"
        Me.lblHoliday.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHoliday.Visible = False
        '
        'btnCart
        '
        Me.btnCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCart.Enabled = False
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCart.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.ForeColor = System.Drawing.Color.Teal
        Me.btnCart.Location = New System.Drawing.Point(92, 303)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(164, 27)
        Me.btnCart.TabIndex = 16
        Me.btnCart.Text = "Add To Cart"
        Me.btnCart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(293, 303)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 27)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picInfoBG
        '
        Me.picInfoBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picInfoBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picInfoBG.Location = New System.Drawing.Point(12, 234)
        Me.picInfoBG.Name = "picInfoBG"
        Me.picInfoBG.Size = New System.Drawing.Size(525, 63)
        Me.picInfoBG.TabIndex = 18
        Me.picInfoBG.TabStop = False
        '
        'lblDailySelect
        '
        Me.lblDailySelect.AutoSize = True
        Me.lblDailySelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDailySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailySelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDailySelect.Location = New System.Drawing.Point(60, 258)
        Me.lblDailySelect.Name = "lblDailySelect"
        Me.lblDailySelect.Size = New System.Drawing.Size(70, 16)
        Me.lblDailySelect.TabIndex = 19
        Me.lblDailySelect.Text = "Selected"
        Me.lblDailySelect.Visible = False
        '
        'lblWeeklySelect
        '
        Me.lblWeeklySelect.AutoSize = True
        Me.lblWeeklySelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWeeklySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklySelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWeeklySelect.Location = New System.Drawing.Point(239, 258)
        Me.lblWeeklySelect.Name = "lblWeeklySelect"
        Me.lblWeeklySelect.Size = New System.Drawing.Size(70, 16)
        Me.lblWeeklySelect.TabIndex = 20
        Me.lblWeeklySelect.Text = "Selected"
        Me.lblWeeklySelect.Visible = False
        '
        'lblHolidaySelect
        '
        Me.lblHolidaySelect.AutoSize = True
        Me.lblHolidaySelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHolidaySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidaySelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHolidaySelect.Location = New System.Drawing.Point(419, 258)
        Me.lblHolidaySelect.Name = "lblHolidaySelect"
        Me.lblHolidaySelect.Size = New System.Drawing.Size(70, 16)
        Me.lblHolidaySelect.TabIndex = 21
        Me.lblHolidaySelect.Text = "Selected"
        Me.lblHolidaySelect.Visible = False
        '
        'frmOnlineSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(549, 356)
        Me.Controls.Add(Me.lblWeeklySelect)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.btnHoliday)
        Me.Controls.Add(Me.btnWeekly)
        Me.Controls.Add(Me.picHoliday)
        Me.Controls.Add(Me.btnDaily)
        Me.Controls.Add(Me.picWeekly)
        Me.Controls.Add(Me.picDaily)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblDailySelect)
        Me.Controls.Add(Me.lblHolidaySelect)
        Me.Controls.Add(Me.lblWeekly)
        Me.Controls.Add(Me.lblDaily)
        Me.Controls.Add(Me.lblHoliday)
        Me.Controls.Add(Me.picInfoBG)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOnlineSpecials"
        Me.Text = "Ethan Anderson's Online Emporium"
        CType(Me.picDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeekly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfoBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picDaily As System.Windows.Forms.PictureBox
    Friend WithEvents picWeekly As System.Windows.Forms.PictureBox
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents picHoliday As System.Windows.Forms.PictureBox
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnHoliday As System.Windows.Forms.Button
    Friend WithEvents lblDaily As System.Windows.Forms.Label
    Friend WithEvents lblWeekly As System.Windows.Forms.Label
    Friend WithEvents lblHoliday As System.Windows.Forms.Label
    Friend WithEvents btnCart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picInfoBG As System.Windows.Forms.PictureBox
    Friend WithEvents lblDailySelect As System.Windows.Forms.Label
    Friend WithEvents lblWeeklySelect As System.Windows.Forms.Label
    Friend WithEvents lblHolidaySelect As System.Windows.Forms.Label

End Class
