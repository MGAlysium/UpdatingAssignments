<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoker))
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.picTable = New System.Windows.Forms.PictureBox()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.lblTester = New System.Windows.Forms.Label()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDeck
        '
        Me.picDeck.Image = Global.PokerV1.My.Resources.Resources.Card_Back
        Me.picDeck.Location = New System.Drawing.Point(255, 117)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(45, 63)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeck.TabIndex = 1
        Me.picDeck.TabStop = False
        '
        'picTable
        '
        Me.picTable.Image = Global.PokerV1.My.Resources.Resources.Poker_Table
        Me.picTable.Location = New System.Drawing.Point(13, 13)
        Me.picTable.Name = "picTable"
        Me.picTable.Size = New System.Drawing.Size(603, 344)
        Me.picTable.TabIndex = 0
        Me.picTable.TabStop = False
        '
        'btnDeal
        '
        Me.btnDeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeal.Location = New System.Drawing.Point(255, 52)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(116, 40)
        Me.btnDeal.TabIndex = 2
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = False
        '
        'lblTester
        '
        Me.lblTester.AutoSize = True
        Me.lblTester.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTester.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTester.Location = New System.Drawing.Point(255, 217)
        Me.lblTester.Name = "lblTester"
        Me.lblTester.Size = New System.Drawing.Size(88, 19)
        Me.lblTester.TabIndex = 3
        Me.lblTester.Text = "Test Text"
        '
        'frmPoker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(627, 364)
        Me.Controls.Add(Me.lblTester)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.picTable)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPoker"
        Me.Text = "Poker"
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTable As System.Windows.Forms.PictureBox
    Friend WithEvents picDeck As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeal As System.Windows.Forms.Button
    Friend WithEvents lblTester As System.Windows.Forms.Label

End Class
