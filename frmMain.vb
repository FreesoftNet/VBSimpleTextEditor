Option Strict On
Option Explicit On

Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Data
Imports System.Text


Public Class frmMain

    Private FileName As String = ""
    Private TitleName As String
    Private Modified As Boolean
    Private AgentReplace As frmReplace
    '2020/02/27追加
    Private fileCode As String = ""

	Private sText As String

    Private Sub SearchProcess()
        Dim dlgTmp As frmReplace

        dlgTmp = AgentReplace


        If Not dlgTmp Is Nothing Then

            dlgTmp.StartPosition = FormStartPosition.CenterParent
            dlgTmp.MaximizeBox = False
            dlgTmp.MinimizeBox = False
            dlgTmp.FormBorderStyle = FormBorderStyle.FixedDialog

            dlgTmp.ShowDialog()
        End If

    End Sub


    Private Sub PasteProcess()

        txtTextArea.Paste()

    End Sub

    Private Sub CopyProcess()

        txtTextArea.Copy()

    End Sub


    Private Sub UndoProcess()

        txtTextArea.Undo()

    End Sub



    Private Sub CutProcess()
        txtTextArea.Cut()
    End Sub

    Private Sub SetTitle()
        Text = FileName
    End Sub

    Private Sub ReadFile(code As String)
        Dim ofd As New OpenFileDialog

        If CheckFileProcess() = False Then
            Exit Sub
        End If

        Try

            ofd.DefaultExt = "txt"
            ofd.Filter = "Textファイル|*.txt|すべてのファイル|*.*"
            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            '2020/02/27
            txtTextArea.Text = ""
            
            FileName = ofd.FileName
            
            LoadFile(FileName, code)

            SetTitle()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    
        'https://dobon.net/vb/dotnet/file/readfile.html
    'peekの使い方

    Private Sub LoadFile(ByVal sFileName As String, code As String)

        Dim sBuf As String           ' バッファ
        
        '2020/02/27
        sText = ""

        Try


            '文字コードを指定してStreamReaderを作成
            Dim sr1 As New StreamReader(sFileName, Encoding.GetEncoding(code))


            'ファイル読み取り処理開始
            While sr1.Peek >= 0

                Application.DoEvents()
                sBuf = sr1.ReadLine()
                sText += sBuf + vbNewLine

            End While

            'ストリームを閉じる
            sr1.Close()

            'System.Diagnostics.Debug.Print(sText)
            'MsgBox(sText)
            'RichTextBox1.Text = sText
			'2020/2/5
            txtTextArea.Text = sText
			

        Catch ex As Exception
            'エラー発生
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadFile")
        End Try
    End Sub


'2020/02/27 更新
    Private Function SaveFile(code As String) As Boolean
        Dim sr2 As StreamWriter

        sText = txtTextArea.Text
        If FileName = "" Then
            Dim sfd As New SaveFileDialog
            sfd.DefaultExt = "txt"
            sfd.Filter = "テキストファイル|*.txt|すべてのファイル|*.*"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            FileName = sfd.FileName
            'txtTextArea.SaveFile(sfd.FileName, RichTextBoxStreamType.UnicodePlainText)
        'Else
            'txtTextArea.SaveFile(sfd.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If

        'コード指定可能に
        sr2 = New StreamWriter( _
            New FileStream(FileName, FileMode.Create), _
            Encoding.GetEncoding(code))
        sr2.WriteLine(sText)
        sr2.Close()

        'バグ修正
        Modified = false

        Return True

    End Function




    Private Function CheckFileProcess() As Boolean
        If Modified = True Then
            Dim result As DialogResult = MessageBox.Show(Me, "ファイルは変更されています。" + vbNewLine + "の変更を保存しますか？", TitleName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim ret As Boolean
                ret = SaveFile(fileCode)
                If ret = False Then
                    Return False
                End If
            Else
                If result = DialogResult.Cancel Then
                    Return False
                End If
            End If
        End If

        Return True

    End Function

'2020/02/27 更新
    Private Sub SaveAsFile(code As String)
        Dim sfd As New SaveFileDialog
        Dim sr2 As StreamWriter
        
        Try

            sfd.FileName = FileName
            '
            sfd.DefaultExt = "txt"
            sfd.Filter = "Textファイル|*.txt|すべてのファイル|*.*"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            'txtTextArea.SaveFile(sfd.FileName, RichTextBoxStreamType.UnicodePlainText)
            FileName = sfd.FileName
            sText = txtTextArea.Text
            'コード指定可能に
            sr2 = New StreamWriter( _
                New FileStream(FileName, FileMode.Create), _
                Encoding.GetEncoding(code))
            sr2.WriteLine(sText)
            
            sr2.Close()
            SetTitle()
            
            'バグ修正
            Modified = false


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くOToolStripMenuItem.Click
        fileCode = "Shift-JIS"
        ReadFile(fileCode)
    End Sub
    
        Private Sub UTF8で開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UTF8で開くOToolStripMenuItem.Click
        fileCode = "UTF-8"
        ReadFile(fileCode)
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        SaveAsFile(fileCode)
    End Sub

    Private Sub 上書き保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存ToolStripMenuItem.Click
        Dim ret As Boolean
        ret = SaveFile(fileCode)
    End Sub

    Private Sub 切り取りXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 切り取りXToolStripMenuItem.Click
        CutProcess()
    End Sub

    Private Sub 元に戻すUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 元に戻すUToolStripMenuItem.Click
        UndoProcess()
    End Sub

    Private Sub コピーCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles コピーCToolStripMenuItem.Click
        CopyProcess()
    End Sub

    Private Sub 貼り付けPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 貼り付けPToolStripMenuItem.Click
        PasteProcess()
    End Sub

    Private Sub 検索FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 検索FToolStripMenuItem.Click
        SearchProcess()
    End Sub

    Private Sub 行へ移動GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 行へ移動GToolStripMenuItem.Click
        Dim dlg As New frmGotoLine(txtTextArea)

        dlg.StartPosition = FormStartPosition.CenterParent
        dlg.MaximizeBox = False
        dlg.MinimizeBox = False
        dlg.FormBorderStyle = FormBorderStyle.FixedDialog

        dlg.ShowDialog()
    End Sub

    Private Sub バージョン情報HToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles バージョン情報HToolStripMenuItem.Click
		Dim f As New frmAbout
        f.ShowDialog()
    End Sub

    Private Sub 次へToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 次へToolStripMenuItem.Click
        Dim dlgTmp As frmReplace

        dlgTmp = AgentReplace

        If dlgTmp.txtSearchString.Text = String.Empty Then

            dlgTmp.StartPosition = FormStartPosition.CenterParent
            dlgTmp.MaximizeBox = False
            dlgTmp.MinimizeBox = False
            dlgTmp.FormBorderStyle = FormBorderStyle.FixedDialog

            dlgTmp.ShowDialog()
        Else
            dlgTmp.PrcSearchNext(txtTextArea)
        End If


    End Sub

    Private Sub フォントFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles フォントFToolStripMenuItem.Click
        Dim fd As New FontDialog
        fd.Font = txtTextArea.Font

        fd.FontMustExist = True
        fd.FixedPitchOnly = True
        If fd.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        txtTextArea.Font = fd.Font

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'https://docs.microsoft.com/ja-jp/dotnet/api/system.environment.getcommandlineargs?view=netframework-4.8
        dim args as string() = Environment.GetCommandLineArgs()
        If args.Length <> 1 And args.Length <> 3 Then
            MsgBox("コマンドライン引数を指定してください。例） xxx.exe ファイル名 文字コード ")
        ElseIf args.Length = 3 Then 'コマンド自身を含まない
            Dim arg As String
            For Each arg In args
                'Console.WriteLine(arg)
                'MsgBox(arg)
                FileName = args(1)
                fileCode = args(2)
                'msgbox(args.Length.tostring())
            Next
        End If
    
        AgentReplace = New frmReplace(txtTextArea)
        txtTextArea.Font = New Font("MSゴシック", 10)
        txtTextArea.BackColor = Color.Black
        txtTextArea.ForeColor = Color.LightGray

        Left = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainLeft", "30"))
        Top = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainTop", "30"))
        Width = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainWidth", "600"))
        Height = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainHeight", "600"))

        Dim sTmp As String
        Dim iSize As Integer
        sTmp = GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontName", "ＭＳ ゴシック")
        iSize = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontSize", CStr(9)))
        txtTextArea.Font = New Font(sTmp, iSize)

        Dim iTmp As Integer

        iTmp = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontBold", CStr(0)))
        If iTmp = 1 Then
            txtTextArea.Font = New Font(txtTextArea.Font, txtTextArea.Font.Style Or FontStyle.Bold)

        Else
            txtTextArea.Font = New Font(txtTextArea.Font, txtTextArea.Font.Style Xor FontStyle.Bold)

        End If

        iTmp = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontItalic", CStr(0)))
        If iTmp = 1 Then
            txtTextArea.Font = New Font(txtTextArea.Font, FontStyle.Italic Or FontStyle.Italic)

        Else
            txtTextArea.Font = New Font(txtTextArea.Font, FontStyle.Italic Xor FontStyle.Italic)

        End If

        Modified = False
        
        If FileName <> "" Then
            'msgbox(FileName + " " + fileCode)
            LoadFile(FileName,fileCode)
        End If

    End Sub

    Private Sub SubSave()
        Dim iTmp As Integer
        If Me.Left >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainLeft", CStr(Me.Left))
        End If
        If Me.Top >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainTop", CStr(Me.Top))
        End If
        If Me.Width >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainWidth", CStr(Me.Width))
        End If
        If Me.Height >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainHeight", CStr(Me.Height))
        End If

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontName", txtTextArea.Font.Name)
        If txtTextArea.Font.Bold = True Then
            iTmp = 1
        Else
            iTmp = 0
        End If

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontSize", CStr(txtTextArea.Font.SizeInPoints))

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontBold", CStr(iTmp))

        If txtTextArea.Font.Italic = True Then
            iTmp = 1
        Else
            iTmp = 0
        End If
        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontItalic", CStr(iTmp))



    End Sub


    Private Sub 元に戻すUToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 元に戻すUToolStripMenuItem1.Click
        UndoProcess()
    End Sub

    Private Sub 切り取りTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 切り取りTToolStripMenuItem.Click
        CutProcess()
    End Sub

    Private Sub コピーCToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles コピーCToolStripMenuItem1.Click
        CopyProcess()
    End Sub

    Private Sub 貼り付けPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 貼り付けPToolStripMenuItem1.Click
        PasteProcess()
    End Sub

    Private Sub すべて選択AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles すべて選択AToolStripMenuItem.Click
        txtTextArea.SelectAll()
        txtTextArea.Focus()
    End Sub



    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Modified = True Then

            Dim ret As Boolean = CheckFileProcess()

            If ret = False Then
                e.Cancel = True
            End If

        End If
        SubSave()

    End Sub

    Private Sub txtTextArea_TextChanged(sender As Object, e As EventArgs) Handles txtTextArea.TextChanged
        Modified = True
    End Sub
End Class