<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpBTC = New System.Windows.Forms.GroupBox()
        Me.lblBTC = New System.Windows.Forms.Label()
        Me.lblStock1 = New System.Windows.Forms.Label()
        Me.grpStock2 = New System.Windows.Forms.GroupBox()
        Me.lblStock2 = New System.Windows.Forms.Label()
        Me.grpStock3 = New System.Windows.Forms.GroupBox()
        Me.lblStock3 = New System.Windows.Forms.Label()
        Me.grpStock4 = New System.Windows.Forms.GroupBox()
        Me.lblStock4 = New System.Windows.Forms.Label()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.btnCrypto = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.grpBTC.SuspendLayout()
        Me.grpStock2.SuspendLayout()
        Me.grpStock3.SuspendLayout()
        Me.grpStock4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBTC
        '
        Me.grpBTC.Controls.Add(Me.lblBTC)
        Me.grpBTC.Controls.Add(Me.lblStock1)
        Me.grpBTC.Location = New System.Drawing.Point(12, 12)
        Me.grpBTC.Name = "grpBTC"
        Me.grpBTC.Size = New System.Drawing.Size(363, 137)
        Me.grpBTC.TabIndex = 0
        Me.grpBTC.TabStop = False
        '
        'lblBTC
        '
        Me.lblBTC.AutoSize = True
        Me.lblBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTC.Location = New System.Drawing.Point(137, 16)
        Me.lblBTC.Name = "lblBTC"
        Me.lblBTC.Size = New System.Drawing.Size(54, 25)
        Me.lblBTC.TabIndex = 1
        Me.lblBTC.Text = "BTC"
        '
        'lblStock1
        '
        Me.lblStock1.AutoSize = True
        Me.lblStock1.Location = New System.Drawing.Point(148, 64)
        Me.lblStock1.Name = "lblStock1"
        Me.lblStock1.Size = New System.Drawing.Size(34, 13)
        Me.lblStock1.TabIndex = 0
        Me.lblStock1.Text = "$0.00"
        '
        'grpStock2
        '
        Me.grpStock2.Controls.Add(Me.lblStock2)
        Me.grpStock2.Location = New System.Drawing.Point(12, 155)
        Me.grpStock2.Name = "grpStock2"
        Me.grpStock2.Size = New System.Drawing.Size(363, 137)
        Me.grpStock2.TabIndex = 1
        Me.grpStock2.TabStop = False
        Me.grpStock2.Text = "Stock 2"
        '
        'lblStock2
        '
        Me.lblStock2.AutoSize = True
        Me.lblStock2.Location = New System.Drawing.Point(157, 73)
        Me.lblStock2.Name = "lblStock2"
        Me.lblStock2.Size = New System.Drawing.Size(34, 13)
        Me.lblStock2.TabIndex = 4
        Me.lblStock2.Text = "$0.00"
        '
        'grpStock3
        '
        Me.grpStock3.Controls.Add(Me.lblStock3)
        Me.grpStock3.Location = New System.Drawing.Point(12, 298)
        Me.grpStock3.Name = "grpStock3"
        Me.grpStock3.Size = New System.Drawing.Size(363, 137)
        Me.grpStock3.TabIndex = 1
        Me.grpStock3.TabStop = False
        Me.grpStock3.Text = "Stock 3"
        '
        'lblStock3
        '
        Me.lblStock3.AutoSize = True
        Me.lblStock3.Location = New System.Drawing.Point(157, 71)
        Me.lblStock3.Name = "lblStock3"
        Me.lblStock3.Size = New System.Drawing.Size(34, 13)
        Me.lblStock3.TabIndex = 3
        Me.lblStock3.Text = "$0.00"
        '
        'grpStock4
        '
        Me.grpStock4.Controls.Add(Me.lblStock4)
        Me.grpStock4.Location = New System.Drawing.Point(12, 441)
        Me.grpStock4.Name = "grpStock4"
        Me.grpStock4.Size = New System.Drawing.Size(363, 137)
        Me.grpStock4.TabIndex = 1
        Me.grpStock4.TabStop = False
        Me.grpStock4.Text = "Stock 4"
        '
        'lblStock4
        '
        Me.lblStock4.AutoSize = True
        Me.lblStock4.Location = New System.Drawing.Point(157, 74)
        Me.lblStock4.Name = "lblStock4"
        Me.lblStock4.Size = New System.Drawing.Size(34, 13)
        Me.lblStock4.TabIndex = 2
        Me.lblStock4.Text = "$0.00"
        '
        'btnStocks
        '
        Me.btnStocks.Location = New System.Drawing.Point(12, 584)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(117, 54)
        Me.btnStocks.TabIndex = 3
        Me.btnStocks.Text = "Search Stocks"
        Me.btnStocks.UseVisualStyleBackColor = True
        '
        'btnCrypto
        '
        Me.btnCrypto.Location = New System.Drawing.Point(135, 584)
        Me.btnCrypto.Name = "btnCrypto"
        Me.btnCrypto.Size = New System.Drawing.Size(117, 54)
        Me.btnCrypto.TabIndex = 4
        Me.btnCrypto.Text = "Search Crypto"
        Me.btnCrypto.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(258, 584)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(117, 54)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 650)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnCrypto)
        Me.Controls.Add(Me.btnStocks)
        Me.Controls.Add(Me.grpStock4)
        Me.Controls.Add(Me.grpStock3)
        Me.Controls.Add(Me.grpStock2)
        Me.Controls.Add(Me.grpBTC)
        Me.Name = "frmMain"
        Me.Text = "Market Viewer"
        Me.grpBTC.ResumeLayout(False)
        Me.grpBTC.PerformLayout()
        Me.grpStock2.ResumeLayout(False)
        Me.grpStock2.PerformLayout()
        Me.grpStock3.ResumeLayout(False)
        Me.grpStock3.PerformLayout()
        Me.grpStock4.ResumeLayout(False)
        Me.grpStock4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBTC As GroupBox
    Friend WithEvents grpStock2 As GroupBox
    Friend WithEvents grpStock3 As GroupBox
    Friend WithEvents grpStock4 As GroupBox
    Friend WithEvents btnStocks As Button
    Friend WithEvents btnCrypto As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents lblStock1 As Label
    Friend WithEvents lblStock2 As Label
    Friend WithEvents lblStock3 As Label
    Friend WithEvents lblStock4 As Label
    Friend WithEvents lblBTC As Label
End Class
