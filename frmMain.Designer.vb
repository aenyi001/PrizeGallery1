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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPrizeVal = New System.Windows.Forms.TextBox()
        Me.lblWinnings = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblForfeit = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(753, 83)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panther Prize Gallery - Spin to Win Prizes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 32)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 32)
        Me.Label4.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Linen
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(56, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 44)
        Me.TextBox1.TabIndex = 4
        '
        'lblPrizeVal
        '
        Me.lblPrizeVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrizeVal.Location = New System.Drawing.Point(56, 181)
        Me.lblPrizeVal.Name = "lblPrizeVal"
        Me.lblPrizeVal.Size = New System.Drawing.Size(176, 44)
        Me.lblPrizeVal.TabIndex = 5
        '
        'lblWinnings
        '
        Me.lblWinnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnings.Location = New System.Drawing.Point(56, 267)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(176, 44)
        Me.lblWinnings.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prize Value:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Your Total Winnings:"
        '
        'lblForfeit
        '
        Me.lblForfeit.AutoSize = True
        Me.lblForfeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfeit.ForeColor = System.Drawing.Color.Red
        Me.lblForfeit.Location = New System.Drawing.Point(71, 341)
        Me.lblForfeit.Name = "lblForfeit"
        Me.lblForfeit.Size = New System.Drawing.Size(142, 32)
        Me.lblForfeit.TabIndex = 9
        Me.lblForfeit.Text = "You Lose!"
        Me.lblForfeit.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Start the Spin!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(899, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblForfeit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.lblPrizeVal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "frmMain"
        Me.Text = "MysteryPrizes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPrizeVal As TextBox
    Friend WithEvents lblWinnings As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblForfeit As Label
    Friend WithEvents Button1 As Button
End Class
