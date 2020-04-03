Imports System.Reflection

Public Class frmAbout

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dispose()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String


        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        TextBoxDescription.ReadOnly = True


        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("{0} のバージョン情報", ApplicationTitle)

        Me.LabelProductName.Text = My.Application.Info.ProductName

        Me.LabelVersion.Text = String.Format("バージョン {0}", Assembly.GetExecutingAssembly().GetName().Version())
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class