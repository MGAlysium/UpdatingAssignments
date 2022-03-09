<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentPicnicApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentPicnicApp))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPicnic = New System.Windows.Forms.PictureBox()
        Me.btnStudentInfo = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Silver
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(216, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(157, 50)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Annual Spring" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fling Picnic"
        '
        'picPicnic
        '
        Me.picPicnic.BackColor = System.Drawing.Color.Transparent
        Me.picPicnic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPicnic.Image = Global.PizzaSelection.My.Resources.Resources.picnic_instagram_photo_scaled_1_png
        Me.picPicnic.Location = New System.Drawing.Point(12, 12)
        Me.picPicnic.Name = "picPicnic"
        Me.picPicnic.Size = New System.Drawing.Size(185, 332)
        Me.picPicnic.TabIndex = 2
        Me.picPicnic.TabStop = False
        '
        'btnStudentInfo
        '
        Me.btnStudentInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudentInfo.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentInfo.ForeColor = System.Drawing.Color.Teal
        Me.btnStudentInfo.Location = New System.Drawing.Point(221, 152)
        Me.btnStudentInfo.Name = "btnStudentInfo"
        Me.btnStudentInfo.Size = New System.Drawing.Size(185, 27)
        Me.btnStudentInfo.TabIndex = 5
        Me.btnStudentInfo.Text = "View Picnic Information"
        Me.btnStudentInfo.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Silver
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Teal
        Me.lblWelcome.Location = New System.Drawing.Point(247, 85)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(132, 36)
        Me.lblWelcome.TabIndex = 7
        Me.lblWelcome.Text = "All Students Are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Welcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(242, 208)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(142, 80)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "April 17, 2015" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Located in the Quad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in front of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barnard Building"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(221, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(185, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(221, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 126)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmStudentPicnicApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnStudentInfo)
        Me.Controls.Add(Me.picPicnic)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentPicnicApp"
        Me.Text = "Ethan Anderson's Student Picnic"
        CType(Me.picPicnic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picPicnic As System.Windows.Forms.PictureBox
    Friend WithEvents btnStudentInfo As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
