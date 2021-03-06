﻿Imports System.Threading
Imports System.Globalization
Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean
    Public fntOutput, fntScript, fntComment As Font
    Public clrOutput, clrScript, clrComment As Color
    Public strComment, strLanguageCultureCode As String
    Public iPreviewRows As Integer
    Public iMaxRows As Integer

    Public Sub SetMaxRows(iRows As Integer)
        iMaxRows = iRows
        frmMain.clsGrids.SetMaxRows(iMaxRows)
    End Sub

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        frmMain.clsRLink.setFormatOutput(fntOutput, clrOutput)
    End Sub

    Public Sub SetFormatCommand(fntNew As Font, clrNew As Color)
        fntScript = fntNew
        clrScript = clrNew
        frmMain.clsRLink.setFormatScript(fntScript, clrScript)
    End Sub

    Public Sub SetFormatComment(fntNew As Font, clrNew As Color)
        fntComment = fntNew
        clrComment = clrNew
        frmMain.clsRLink.setFormatComment(fntComment, clrComment)
    End Sub

    Public Sub SetPreviewRows(intlines As Integer)
        iPreviewRows = intlines
        dlgImportDataset.setLinesToRead(iPreviewRows)
    End Sub

    Public Sub SetComment(strText As String)
        strComment = strText
    End Sub

    Public Sub SetLanguageCultureCode(strLanguage As String)
        strLanguageCultureCode = strLanguage
        Select Case strLanguageCultureCode
            Case "en-GB"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
            Case "fr-FR"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "sw-KE"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            Case "es-ES"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
            Case Else
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        End Select
    End Sub

End Class
