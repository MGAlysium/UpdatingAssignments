<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHostelSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHostelSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picLondon = New System.Windows.Forms.PictureBox()
        Me.picDublin = New System.Windows.Forms.PictureBox()
        Me.btnLondon = New System.Windows.Forms.Button()
        Me.btnDublin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Silver
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(117, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(180, 25)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Hostel Selection"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picLondon
        '
        Me.picLondon.BackColor = System.Drawing.Color.Transparent
        Me.picLondon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLondon.Image = Global.PizzaSelection.My.Resources.Resources.LondonHostel_1_png
        Me.picLondon.Location = New System.Drawing.Point(12, 48)
        Me.picLondon.Name = "picLondon"
        Me.picLondon.Size = New System.Drawing.Size(185, 150)
        Me.picLondon.TabIndex = 2
        Me.picLondon.TabStop = False
        Me.picLondon.Visible = False
        '
        'picDublin
        '
        Me.picDublin.BackColor = System.Drawing.Color.Transparent
        Me.picDublin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDublin.Image = Global.PizzaSelection.My.Resources.Resources.DublinHostel_1_png
        Me.picDublin.Location = New System.Drawing.Point(217, 48)
        Me.picDublin.Name = "picDublin"
        Me.picDublin.Size = New System.Drawing.Size(185, 150)
        Me.picDublin.TabIndex = 3
        Me.picDublin.TabStop = False
        Me.picDublin.Visible = False
        '
        'btnLondon
        '
        Me.btnLondon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLondon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLondon.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLondon.ForeColor = System.Drawing.Color.Teal
        Me.btnLondon.Location = New System.Drawing.Point(13, 201)
        Me.btnLondon.Name = "btnLondon"
        Me.btnLondon.Size = New System.Drawing.Size(184, 27)
        Me.btnLondon.TabIndex = 4
        Me.btnLondon.Text = "London Hostel"
        Me.btnLondon.UseVisualStyleBackColor = False
        '
        'btnDublin
        '
        Me.btnDublin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDublin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDublin.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDublin.ForeColor = System.Drawing.Color.Teal
        Me.btnDublin.Location = New System.Drawing.Point(217, 201)
        Me.btnDublin.Name = "btnDublin"
        Me.btnDublin.Size = New System.Drawing.Size(185, 27)
        Me.btnDublin.TabIndex = 5
        Me.btnDublin.Text = "Dublin Hostel"
        Me.btnDublin.UseVisualStyleBackColor = False
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
        Me.lblInstruct.Location = New System.Drawing.Point(73, 261)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(269, 36)
        Me.lblInstruct.TabIndex = 7
        Me.lblInstruct.Text = "Choose a hostel location then click " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ""Select"" button."
        Me.lblInstruct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Silver
        Me.lblConfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfirm.Location = New System.Drawing.Point(87, 300)
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
        'frmHostelSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDublin)
        Me.Controls.Add(Me.btnLondon)
        Me.Controls.Add(Me.picDublin)
        Me.Controls.Add(Me.picLondon)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHostelSelection"
        Me.Text = "Ethan Anderson's Hostel Selection"
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picLondon As System.Windows.Forms.PictureBox
    Friend WithEvents picDublin As System.Windows.Forms.PictureBox
    Friend WithEvents btnLondon As System.Windows.Forms.Button
    Friend WithEvents btnDublin As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblInstruct As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
