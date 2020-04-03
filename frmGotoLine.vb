Public Class frmGotoLine

    Private moRichTextBox As Object

    Public Sub New(ByVal oRichTextBox As Object)

        InitializeComponent()

        moRichTextBox = oRichTextBox

    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

        Dim pos As Integer
        Dim ans As Integer
        Dim maxLineNo As Integer
        With txtLineNo

            If .Text <> "" Then
                If IsNumeric(.Text) Then

                    pos = Len(moRichTextBox.Text)
                    maxLineNo = moRichTextBox.GetLineFromCharIndex(pos) + 1
                    If maxLineNo < CInt(.Text) Or CInt(.Text) = 0 Then
                        MsgBox("行番号が範囲外です。", , "指定行に移動")
                        Exit Sub
                    End If

                    pos = 0

                    ans = 0
                    Do
                        ans = moRichTextBox.GetLineFromCharIndex(pos) + 1
                        If ans = CInt(.Text) Then
                            Exit Do
                        End If
                        pos = pos + 1
                    Loop
                    moRichTextBox.SelectionStart = pos
                    moRichTextBox.SelectionLength = 0

                Else
                    MsgBox("正しく数値を入力してください。")
                    Exit Sub
                End If
            End If

        End With


        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class