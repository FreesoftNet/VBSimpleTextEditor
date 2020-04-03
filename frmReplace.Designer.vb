<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplace
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReplaceAll = New System.Windows.Forms.Button()
        Me.cmdReplaceNext = New System.Windows.Forms.Button()
        Me.txtReplaceString = New System.Windows.Forms.TextBox()
        Me.lblReplaceString = New System.Windows.Forms.Label()
        Me.cmdSearchNext = New System.Windows.Forms.Button()
        Me.txtSearchString = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(325, 80)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(108, 20)
        Me.cmdCancel.TabIndex = 28
        Me.cmdCancel.Text = "キャンセル"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReplaceAll
        '
        Me.cmdReplaceAll.Location = New System.Drawing.Point(325, 57)
        Me.cmdReplaceAll.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReplaceAll.Name = "cmdReplaceAll"
        Me.cmdReplaceAll.Size = New System.Drawing.Size(108, 20)
        Me.cmdReplaceAll.TabIndex = 27
        Me.cmdReplaceAll.Text = "すべて置換え(&A)"
        Me.cmdReplaceAll.UseVisualStyleBackColor = True
        '
        'cmdReplaceNext
        '
        Me.cmdReplaceNext.Location = New System.Drawing.Point(325, 34)
        Me.cmdReplaceNext.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReplaceNext.Name = "cmdReplaceNext"
        Me.cmdReplaceNext.Size = New System.Drawing.Size(108, 20)
        Me.cmdReplaceNext.TabIndex = 26
        Me.cmdReplaceNext.Text = "置換えして次に(&R)"
        Me.cmdReplaceNext.UseVisualStyleBackColor = True
        '
        'txtReplaceString
        '
        Me.txtReplaceString.Location = New System.Drawing.Point(126, 33)
        Me.txtReplaceString.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReplaceString.Name = "txtReplaceString"
        Me.txtReplaceString.Size = New System.Drawing.Size(170, 19)
        Me.txtReplaceString.TabIndex = 21
        '
        'lblReplaceString
        '
        Me.lblReplaceString.AutoSize = True
        Me.lblReplaceString.Location = New System.Drawing.Point(12, 36)
        Me.lblReplaceString.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReplaceString.Name = "lblReplaceString"
        Me.lblReplaceString.Size = New System.Drawing.Size(114, 12)
        Me.lblReplaceString.TabIndex = 23
        Me.lblReplaceString.Text = "置換えする文字列：(&P)"
        '
        'cmdSearchNext
        '
        Me.cmdSearchNext.Location = New System.Drawing.Point(325, 11)
        Me.cmdSearchNext.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSearchNext.Name = "cmdSearchNext"
        Me.cmdSearchNext.Size = New System.Drawing.Size(108, 20)
        Me.cmdSearchNext.TabIndex = 25
        Me.cmdSearchNext.Text = "次を検索(&F)"
        Me.cmdSearchNext.UseVisualStyleBackColor = True
        '
        'txtSearchString
        '
        Me.txtSearchString.Location = New System.Drawing.Point(126, 11)
        Me.txtSearchString.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchString.Name = "txtSearchString"
        Me.txtSearchString.Size = New System.Drawing.Size(170, 19)
        Me.txtSearchString.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "検索する文字列：(&N)"
        '
        'frmReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 111)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdReplaceAll)
        Me.Controls.Add(Me.cmdReplaceNext)
        Me.Controls.Add(Me.txtReplaceString)
        Me.Controls.Add(Me.lblReplaceString)
        Me.Controls.Add(Me.cmdSearchNext)
        Me.Controls.Add(Me.txtSearchString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReplace"
        Me.Text = "検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdReplaceAll As System.Windows.Forms.Button
    Friend WithEvents cmdReplaceNext As System.Windows.Forms.Button
    Friend WithEvents txtReplaceString As System.Windows.Forms.TextBox
    Friend WithEvents lblReplaceString As System.Windows.Forms.Label
    Friend WithEvents cmdSearchNext As System.Windows.Forms.Button
    Friend WithEvents txtSearchString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
