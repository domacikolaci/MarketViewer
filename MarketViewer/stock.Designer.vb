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
        Me.txtStockSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txtStockSearch
        '
        Me.txtStockSearch.Location = New System.Drawing.Point(13, 13)
        Me.txtStockSearch.Name = "txtStockSearch"
        Me.txtStockSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtStockSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(216, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search Stock"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpResults
        '
        Me.grpResults.Location = New System.Drawing.Point(13, 54)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(278, 116)
        Me.grpResults.TabIndex = 2
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 178)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStockSearch)
        Me.Name = "frmStock"
        Me.Text = "Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStockSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents grpResults As GroupBox
End Class
