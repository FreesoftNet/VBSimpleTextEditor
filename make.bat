vbc /target:winexe  /out:VBTextEditor.exe /main:frmMain  frmMain.vb Application.Designer.vb AssemblyInfo.vb frmAbout.Designer.vb frmAbout.vb frmGotoLine.Designer.vb frmGotoLine.vb frmMain.Designer.vb  frmReplace.Designer.vb frmReplace.vb Resources.Designer.vb Settings.Designer.vb  /reference:ICSharpCode.TextEditor.dll
rem vbc /target:winexe /out:VBTextEditor.exe /main:frmMain  frmMain.vb Application.Designer.vb AssemblyInfo.vb frmAbout.Designer.vb frmAbout.vb frmGotoLine.Designer.vb frmGotoLine.vb frmMain.Designer.vb  frmReplace.Designer.vb frmReplace.vb  Settings.Designer.vb  /reference:ICSharpCode.TextEditor.dll
VBTextEditor.exe
pause
