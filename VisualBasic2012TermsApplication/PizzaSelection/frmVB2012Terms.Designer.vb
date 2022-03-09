<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVB2012Terms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVB2012Terms))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnHardware = New System.Windows.Forms.Button()
        Me.btnDeveloper = New System.Windows.Forms.Button()
        Me.btnRAD = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.picDefBackdrop = New System.Windows.Forms.PictureBox()
        CType(Me.picDefBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Teal
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(56, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(302, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Professional 2012"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Teal
        Me.lblSubtitle.Location = New System.Drawing.Point(95, 84)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(224, 24)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Visual Basic 2012 Terms"
        '
        'btnHardware
        '
        Me.btnHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardware.ForeColor = System.Drawing.Color.Teal
        Me.btnHardware.Location = New System.Drawing.Point(28, 120)
        Me.btnHardware.Name = "btnHardware"
        Me.btnHardware.Size = New System.Drawing.Size(139, 45)
        Me.btnHardware.TabIndex = 2
        Me.btnHardware.Text = "Computer Hardware"
        Me.btnHardware.UseVisualStyleBackColor = False
        '
        'btnDeveloper
        '
        Me.btnDeveloper.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeveloper.ForeColor = System.Drawing.Color.Teal
        Me.btnDeveloper.Location = New System.Drawing.Point(28, 177)
        Me.btnDeveloper.Name = "btnDeveloper"
        Me.btnDeveloper.Size = New System.Drawing.Size(139, 45)
        Me.btnDeveloper.TabIndex = 3
        Me.btnDeveloper.Text = "Developer"
        Me.btnDeveloper.UseVisualStyleBackColor = False
        '
        'btnRAD
        '
        Me.btnRAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRAD.ForeColor = System.Drawing.Color.Teal
        Me.btnRAD.Location = New System.Drawing.Point(28, 234)
        Me.btnRAD.Name = "btnRAD"
        Me.btnRAD.Size = New System.Drawing.Size(139, 45)
        Me.btnRAD.TabIndex = 4
        Me.btnRAD.Text = "Rapid Application Development"
        Me.btnRAD.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(138, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 45)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDefinition.Location = New System.Drawing.Point(187, 167)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(64, 16)
        Me.lblDefinition.TabIndex = 6
        Me.lblDefinition.Text = "Test Text"
        Me.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDefinition.Visible = False
        '
        'picDefBackdrop
        '
        Me.picDefBackdrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picDefBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDefBackdrop.Location = New System.Drawing.Point(182, 120)
        Me.picDefBackdrop.Name = "picDefBackdrop"
        Me.picDefBackdrop.Size = New System.Drawing.Size(220, 159)
        Me.picDefBackdrop.TabIndex = 7
        Me.picDefBackdrop.TabStop = False
        '
        'frmVB2012Terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.lblDefinition)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRAD)
        Me.Controls.Add(Me.btnDeveloper)
        Me.Controls.Add(Me.btnHardware)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picDefBackdrop)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVB2012Terms"
        Me.Text = "Ethan Anderson's Visual Basic 2012 Terms"
        CType(Me.picDefBackdrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnHardware As System.Windows.Forms.Button
    Friend WithEvents btnDeveloper As System.Windows.Forms.Button
    Friend WithEvents btnRAD As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDefinition As System.Windows.Forms.Label
    Friend WithEvents picDefBackdrop As System.Windows.Forms.PictureBox

End Class
