﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grpStock1 = New System.Windows.Forms.GroupBox()
        Me.grpStock2 = New System.Windows.Forms.GroupBox()
        Me.grpStock3 = New System.Windows.Forms.GroupBox()
        Me.grpStock4 = New System.Windows.Forms.GroupBox()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.btnCrypto = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grpStock1
        '
        Me.grpStock1.Location = New System.Drawing.Point(12, 12)
        Me.grpStock1.Name = "grpStock1"
        Me.grpStock1.Size = New System.Drawing.Size(363, 137)
        Me.grpStock1.TabIndex = 0
        Me.grpStock1.TabStop = False
        Me.grpStock1.Text = "Stock1"
        '
        'grpStock2
        '
        Me.grpStock2.Location = New System.Drawing.Point(12, 155)
        Me.grpStock2.Name = "grpStock2"
        Me.grpStock2.Size = New System.Drawing.Size(363, 137)
        Me.grpStock2.TabIndex = 1
        Me.grpStock2.TabStop = False
        Me.grpStock2.Text = "Stock 2"
        '
        'grpStock3
        '
        Me.grpStock3.Location = New System.Drawing.Point(12, 298)
        Me.grpStock3.Name = "grpStock3"
        Me.grpStock3.Size = New System.Drawing.Size(363, 137)
        Me.grpStock3.TabIndex = 1
        Me.grpStock3.TabStop = False
        Me.grpStock3.Text = "Stock 3"
        '
        'grpStock4
        '
        Me.grpStock4.Location = New System.Drawing.Point(12, 441)
        Me.grpStock4.Name = "grpStock4"
        Me.grpStock4.Size = New System.Drawing.Size(363, 137)
        Me.grpStock4.TabIndex = 1
        Me.grpStock4.TabStop = False
        Me.grpStock4.Text = "Stock 4"
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
        Me.Controls.Add(Me.grpStock1)
        Me.Name = "frmMain"
        Me.Text = "Market Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpStock1 As GroupBox
    Friend WithEvents grpStock2 As GroupBox
    Friend WithEvents grpStock3 As GroupBox
    Friend WithEvents grpStock4 As GroupBox
    Friend WithEvents btnStocks As Button
    Friend WithEvents btnCrypto As Button
    Friend WithEvents btnAbout As Button
End Class
