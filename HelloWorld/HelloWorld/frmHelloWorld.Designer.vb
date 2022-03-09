<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelloWorld))
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblEnterPrompt = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblNameOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxInput
        '
        Me.tbxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInput.Location = New System.Drawing.Point(12, 30)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(260, 20)
        Me.tbxInput.TabIndex = 0
        '
        'lblEnterPrompt
        '
        Me.lblEnterPrompt.AutoSize = True
        Me.lblEnterPrompt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterPrompt.Location = New System.Drawing.Point(12, 12)
        Me.lblEnterPrompt.Name = "lblEnterPrompt"
        Me.lblEnterPrompt.Size = New System.Drawing.Size(95, 17)
        Me.lblEnterPrompt.TabIndex = 1
        Me.lblEnterPrompt.Text = "Enter Your Name"
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(12, 52)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(260, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblNameOut
        '
        Me.lblNameOut.AutoSize = True
        Me.lblNameOut.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOut.Location = New System.Drawing.Point(11, 150)
        Me.lblNameOut.Name = "lblNameOut"
        Me.lblNameOut.Size = New System.Drawing.Size(0, 19)
        Me.lblNameOut.TabIndex = 3
        Me.lblNameOut.Text = ">>"
        '
        'frmHelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblNameOut)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEnterPrompt)
        Me.Controls.Add(Me.tbxInput)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHelloWorld"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxInput As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterPrompt As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblNameOut As System.Windows.Forms.Label

End Class
