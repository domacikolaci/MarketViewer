<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.txtStockSearchStocks = New System.Windows.Forms.TextBox()
        Me.btnSearchStocks = New System.Windows.Forms.Button()
        Me.grpResultsStocks = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txtStockSearchStocks
        '
        Me.txtStockSearchStocks.Location = New System.Drawing.Point(13, 13)
        Me.txtStockSearchStocks.Name = "txtStockSearchStocks"
        Me.txtStockSearchStocks.Size = New System.Drawing.Size(197, 20)
        Me.txtStockSearchStocks.TabIndex = 0
        '
        'btnSearchStocks
        '
        Me.btnSearchStocks.Location = New System.Drawing.Point(216, 13)
        Me.btnSearchStocks.Name = "btnSearchStocks"
        Me.btnSearchStocks.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchStocks.TabIndex = 1
        Me.btnSearchStocks.Text = "Search Stock"
        Me.btnSearchStocks.UseVisualStyleBackColor = True
        '
        'grpResultsStocks
        '
        Me.grpResultsStocks.Location = New System.Drawing.Point(13, 54)
        Me.grpResultsStocks.Name = "grpResultsStocks"
        Me.grpResultsStocks.Size = New System.Drawing.Size(278, 116)
        Me.grpResultsStocks.TabIndex = 2
        Me.grpResultsStocks.TabStop = False
        Me.grpResultsStocks.Text = "Results"
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 178)
        Me.Controls.Add(Me.grpResultsStocks)
        Me.Controls.Add(Me.btnSearchStocks)
        Me.Controls.Add(Me.txtStockSearchStocks)
        Me.Name = "frmStock"
        Me.Text = "Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStockSearchStocks As TextBox
    Friend WithEvents btnSearchStocks As Button
    Friend WithEvents grpResultsStocks As GroupBox
End Class
