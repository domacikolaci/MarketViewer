<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrypto
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
        Me.grpResultsCrypto = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtStockSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grpResultsCrypto
        '
        Me.grpResultsCrypto.Location = New System.Drawing.Point(3, 53)
        Me.grpResultsCrypto.Name = "grpResultsCrypto"
        Me.grpResultsCrypto.Size = New System.Drawing.Size(278, 116)
        Me.grpResultsCrypto.TabIndex = 5
        Me.grpResultsCrypto.TabStop = False
        Me.grpResultsCrypto.Text = "Results"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(206, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search Stock"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtStockSearch
        '
        Me.txtStockSearch.Location = New System.Drawing.Point(3, 12)
        Me.txtStockSearch.Name = "txtStockSearch"
        Me.txtStockSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtStockSearch.TabIndex = 3
        '
        'frmCrypto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 183)
        Me.Controls.Add(Me.grpResultsCrypto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStockSearch)
        Me.Name = "frmCrypto"
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpResultsCrypto As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStockSearch As TextBox
End Class
