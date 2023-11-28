Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles
Imports Excel = Microsoft.Office.Interop.Excel
Module Mcontrol
    Public AppExcel As Excel.Application
    Public Libro As Excel.Workbook
    Public Hoja As Excel.Worksheet
    Public Sub Crear()
        AppExcel = CreateObject("Excel.Application")
        Libro = AppExcel.Worksheets.Add
        Hoja = Libro.ActiveSheet
        AppExcel.Visible = True 'sierve para abrir
        'AppExel.Aplication.DisplayAlerts = False
    End Sub
    Public Sub Guardarcomo()
        Try
            If Not FileIO.FileSystem.DirectoryExists("C:") Then
            End If
            Libro.SaveAs(Filename:="C:\Tutoriales\Remision.xlsx")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub Abrir()
        Try
            AppExcel = CreateObject("Excel.Application")
            Libro = AppExcel.Workbooks.Open(Filename:="C:\Tutoriales\Remision.xlsx")
            Hoja = Libro.ActiveSheet
            AppExcel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Guardar()
        Try

            Libro.Save()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub Cerrar()
        Try
            Libro.Close()
            AppExcel = Nothing
            Libro = Nothing
            Hoja = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
