<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTF8で開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.元に戻すUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.検索FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.行へ移動GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.次へToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.すべて選択AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.書式OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.フォントFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTextArea = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.元に戻すUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーCToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けPToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.すべて選択AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.書式OToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(396, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開くOToolStripMenuItem, Me.UTF8で開くOToolStripMenuItem, Me.上書き保存ToolStripMenuItem, Me.AToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '開くOToolStripMenuItem
        '
        Me.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem"
        Me.開くOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.開くOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.開くOToolStripMenuItem.Text = "開く(&O)"
        
        '
        'UTF8で開くOToolStripMenuItem
        '
        Me.UTF8で開くOToolStripMenuItem.Name = "UTF8で開くOToolStripMenuItem"
        Me.UTF8で開くOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UTF8で開くOToolStripMenuItem.Text = "UTF8で開く"
        '
        '上書き保存ToolStripMenuItem
        '
        Me.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem"
        Me.上書き保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.上書き保存ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.上書き保存ToolStripMenuItem.Text = "上書き保存(&S)"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元に戻すUToolStripMenuItem, Me.ToolStripSeparator1, Me.切り取りXToolStripMenuItem, Me.コピーCToolStripMenuItem, Me.貼り付けPToolStripMenuItem, Me.検索FToolStripMenuItem, Me.行へ移動GToolStripMenuItem, Me.次へToolStripMenuItem, Me.すべて選択AToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '元に戻すUToolStripMenuItem
        '
        Me.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem"
        Me.元に戻すUToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        '切り取りXToolStripMenuItem
        '
        Me.切り取りXToolStripMenuItem.Name = "切り取りXToolStripMenuItem"
        Me.切り取りXToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.切り取りXToolStripMenuItem.Text = "切り取り(&T)"
        '
        'コピーCToolStripMenuItem
        '
        Me.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem"
        Me.コピーCToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.コピーCToolStripMenuItem.Text = "コピー(&C)"
        '
        '貼り付けPToolStripMenuItem
        '
        Me.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem"
        Me.貼り付けPToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)"
        '
        '検索FToolStripMenuItem
        '
        Me.検索FToolStripMenuItem.Name = "検索FToolStripMenuItem"
        Me.検索FToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.検索FToolStripMenuItem.Text = "検索(&F)"
        '
        '行へ移動GToolStripMenuItem
        '
        Me.行へ移動GToolStripMenuItem.Name = "行へ移動GToolStripMenuItem"
        Me.行へ移動GToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.行へ移動GToolStripMenuItem.Text = "行へ移動（&G)"
        '
        '次へToolStripMenuItem
        '
        Me.次へToolStripMenuItem.Name = "次へToolStripMenuItem"
        Me.次へToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.次へToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.次へToolStripMenuItem.Text = "次を検索(&N)"
        '
        'すべて選択AToolStripMenuItem
        '
        Me.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem"
        Me.すべて選択AToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)"
        '
        '書式OToolStripMenuItem
        '
        Me.書式OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.フォントFToolStripMenuItem})
        Me.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem"
        Me.書式OToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.書式OToolStripMenuItem.Text = "書式(&O)"
        '
        'フォントFToolStripMenuItem
        '
        Me.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem"
        Me.フォントFToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.フォントFToolStripMenuItem.Text = "フォント(&F)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報HToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報HToolStripMenuItem
        '
        Me.バージョン情報HToolStripMenuItem.Name = "バージョン情報HToolStripMenuItem"
        Me.バージョン情報HToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.バージョン情報HToolStripMenuItem.Text = "バージョン情報(&H)"
        '
        'txtTextArea
        '
        Me.txtTextArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextArea.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtTextArea.Location = New System.Drawing.Point(0, 27)
        Me.txtTextArea.Name = "txtTextArea"
        Me.txtTextArea.Size = New System.Drawing.Size(396, 235)
        Me.txtTextArea.TabIndex = 1
        Me.txtTextArea.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元に戻すUToolStripMenuItem1, Me.ToolStripSeparator2, Me.切り取りTToolStripMenuItem, Me.コピーCToolStripMenuItem1, Me.貼り付けPToolStripMenuItem1, Me.すべて選択AToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 120)
        '
        '元に戻すUToolStripMenuItem1
        '
        Me.元に戻すUToolStripMenuItem1.Name = "元に戻すUToolStripMenuItem1"
        Me.元に戻すUToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.元に戻すUToolStripMenuItem1.Text = "元に戻す(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        '切り取りTToolStripMenuItem
        '
        Me.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem"
        Me.切り取りTToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.切り取りTToolStripMenuItem.Text = "切り取り(&T)"
        '
        'コピーCToolStripMenuItem1
        '
        Me.コピーCToolStripMenuItem1.Name = "コピーCToolStripMenuItem1"
        Me.コピーCToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.コピーCToolStripMenuItem1.Text = "コピー(&C)"
        '
        '貼り付けPToolStripMenuItem1
        '
        Me.貼り付けPToolStripMenuItem1.Name = "貼り付けPToolStripMenuItem1"
        Me.貼り付けPToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.貼り付けPToolStripMenuItem1.Text = "貼り付け(&P)"
        '
        'すべて選択AToolStripMenuItem1
        '
        Me.すべて選択AToolStripMenuItem1.Name = "すべて選択AToolStripMenuItem1"
        Me.すべて選択AToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.すべて選択AToolStripMenuItem1.Text = "すべて選択(&A)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 261)
        Me.Controls.Add(Me.txtTextArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "エディタ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 元に戻すUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 書式OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents フォントFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents バージョン情報HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開くOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UTF8で開くOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上書き保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 切り取りXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents コピーCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 貼り付けPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 検索FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTextArea As System.Windows.Forms.RichTextBox
    Friend WithEvents 行へ移動GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 次へToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents すべて選択AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 元に戻すUToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 切り取りTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents コピーCToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 貼り付けPToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents すべて選択AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
