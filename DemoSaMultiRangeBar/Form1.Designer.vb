<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SaMultiRangeBar1 = New SportingAppFW.SaWindows.Forms.SaMultiRangeBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(849, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(87, 112)
        Me.ListBox1.TabIndex = 1
        '
        'SaMultiRangeBar1
        '
        Me.SaMultiRangeBar1.BackColor = System.Drawing.Color.Transparent
        Me.SaMultiRangeBar1.BarColor = System.Drawing.Color.Red
        Me.SaMultiRangeBar1.BarDefineColor = System.Drawing.Color.Khaki
        Me.SaMultiRangeBar1.BarRangeColor = System.Drawing.SystemColors.Window
        Me.SaMultiRangeBar1.EnableMultiRangeIndicator = True
        Me.SaMultiRangeBar1.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.SaMultiRangeBar1.Location = New System.Drawing.Point(68, 12)
        Me.SaMultiRangeBar1.Maximum = 100
        Me.SaMultiRangeBar1.Minimum = 0
        Me.SaMultiRangeBar1.Name = "SaMultiRangeBar1"
        Me.SaMultiRangeBar1.PenWidth = 2
        Me.SaMultiRangeBar1.Size = New System.Drawing.Size(757, 92)
        Me.SaMultiRangeBar1.TabIndex = 0
        Me.SaMultiRangeBar1.Text = "SaMultiRangeBar1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ratio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 130)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SaMultiRangeBar1)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Name = "Form1"
        Me.Text = "Demo SaMultiRangeBar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaMultiRangeBar1 As SportingAppFW.SaWindows.Forms.SaMultiRangeBar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
