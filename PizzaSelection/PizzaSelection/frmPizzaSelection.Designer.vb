<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Silver
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(123, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Pizza Selection"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picDeepDish
        '
        Me.picDeepDish.BackColor = System.Drawing.Color.PaleTurquoise
        Me.picDeepDish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDeepDish.Image = Global.PizzaSelection.My.Resources.Resources.DeepDishPNG
        Me.picDeepDish.Location = New System.Drawing.Point(12, 48)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.picDeepDish.TabIndex = 2
        Me.picDeepDish.TabStop = False
        Me.picDeepDish.Visible = False
        '
        'picThinCrust
        '
        Me.picThinCrust.BackColor = System.Drawing.Color.PaleTurquoise
        Me.picThinCrust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picThinCrust.Image = Global.PizzaSelection.My.Resources.Resources.ThinCrustPNG
        Me.picThinCrust.Location = New System.Drawing.Point(217, 48)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.picThinCrust.TabIndex = 3
        Me.picThinCrust.TabStop = False
        Me.picThinCrust.Visible = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeepDish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeepDish.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeepDish.ForeColor = System.Drawing.Color.Teal
        Me.btnDeepDish.Location = New System.Drawing.Point(13, 201)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(184, 27)
        Me.btnDeepDish.TabIndex = 4
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = False
        '
        'btnThinCrust
        '
        Me.btnThinCrust.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThinCrust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThinCrust.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThinCrust.ForeColor = System.Drawing.Color.Teal
        Me.btnThinCrust.Location = New System.Drawing.Point(217, 201)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(185, 27)
        Me.btnThinCrust.TabIndex = 5
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSelect.Enabled = False
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Teal
        Me.btnSelect.Location = New System.Drawing.Point(115, 231)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(185, 27)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.BackColor = System.Drawing.Color.Silver
        Me.lblInstruct.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblInstruct.ForeColor = System.Drawing.Color.Teal
        Me.lblInstruct.Location = New System.Drawing.Point(90, 261)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(235, 36)
        Me.lblInstruct.TabIndex = 7
        Me.lblInstruct.Text = "Choose a pizza type then click " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ""Select"" button."
        Me.lblInstruct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Silver
        Me.lblConfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfirm.Location = New System.Drawing.Point(145, 300)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(64, 14)
        Me.lblConfirm.TabIndex = 8
        Me.lblConfirm.Text = "Test Text"
        Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblConfirm.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(115, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(185, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Section"
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picDeepDish As System.Windows.Forms.PictureBox
    Friend WithEvents picThinCrust As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeepDish As System.Windows.Forms.Button
    Friend WithEvents btnThinCrust As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblInstruct As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
