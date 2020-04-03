Imports System.Windows.Forms

Public Class frmReplace

    Private mRichTextBox As Object

    Public searchp As Integer
    Private startPos As Integer


    Public Sub New(ByVal oRichTextBox As Object)

        InitializeComponent()
        mRichTextBox = oRichTextBox

    End Sub

    Public Sub PrcSearchNext(Richtext)
        Dim ret As Boolean = FncSearchNext()
    End Sub

    Private Function FncSearchNext() As Boolean
        Dim sKeyword As String
        Dim iEOFposi As Integer
        Dim flag As RichTextBoxFinds


        sKeyword = txtSearchString.Text
        mRichTextBox.HideSelection = False

        '最終位置まで到達
        If searchp = -1 Then
            MsgBox("最終位置まで到達しました。")
            Return False
        Else
            startPos = searchp + sKeyword.length()
            mRichTextBox.SelectionLength = 0
        End If

        iEOFposi = mRichTextBox.Text.Length()

        searchp = mRichTextBox.Find(sKeyword, startPos, iEOFposi, flag)
        System.Diagnostics.Debug.Print(startPos.ToString + "," + searchp.ToString)
        If searchp = -1 Then

            Return False
        Else

            mRichTextBox.SelectionStart = searchp
            Return True
        End If

    End Function


    Private Sub cmdSearchNext_Click(sender As Object, e As EventArgs) Handles cmdSearchNext.Click
        Dim ret As Boolean
        
        ret = FncSearchNext()
        If ret = False Then
            MsgBox("キーワードが見つかりません。")
        End If
    End Sub

    Private Function PrcReplaceNext() As Boolean
        Dim ret As Boolean

        ret = FncSearchNext()
        If ret = False Then
            PrcReplaceNext = False
            Exit Function
        End If

        mRichTextBox.SelectedText = txtReplaceString.Text
        PrcReplaceNext = True
    End Function

    Private Sub cmdReplaceNext_Click(sender As Object, e As EventArgs) Handles cmdReplaceNext.Click

        Dim ret As Boolean = PrcReplaceNext()

    End Sub

    Private Sub frmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchString.Text = mRichTextBox.SelectedText
        'ここでリセット
        searchp = 0

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        '
        searchp = -1
        Me.Close()
    End Sub

    Private Sub cmdReplaceAll_Click(sender As Object, e As EventArgs) Handles cmdReplaceAll.Click
        Do While True
            Dim ret As Boolean = PrcReplaceNext()

            If ret = False Then
                Exit Do
            End If
        Loop
    End Sub
End Class