Option Explicit On


Imports System.Data.OleDb
Imports System.IO



Public Class Form1



    Private Sub SearchFileExcelButton_Click(sender As Object, e As EventArgs) Handles SearchFileExcelButton.Click

        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Excel Files|*.xlsx"
        openfiledialog1.Title = "Selecciona archivo excel"

        If openfiledialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        FileExcelPathTextBox.Text = Path.GetFullPath(openfiledialog1.FileName)





    End Sub

    Private Sub searchdirectorybutton_Click(sender As Object, e As EventArgs) Handles searchdirectorybutton.Click

        Dim folderbrowserdialog1 As New FolderBrowserDialog()
        folderbrowserdialog1.Description = "Selecciona una carpeta:"
        folderbrowserdialog1.ShowNewFolderButton = False
        If folderbrowserdialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        DirectoryPathTextBox.Text = Path.GetFullPath(folderbrowserdialog1.SelectedPath)


    End Sub

    Private Sub FileExcelPathTextBox_DragDrop(sender As Object, e As DragEventArgs) Handles FileExcelPathTextBox.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim Objetos() As String = e.Data.GetData(DataFormats.FileDrop)

            For Each Archivo As String In Objetos
                FileExcelPathTextBox.Text = Objetos(0)
            Next

        End If


    End Sub

    Private Sub FileExcelPathTextBox_DragEnter(sender As Object, e As DragEventArgs) Handles FileExcelPathTextBox.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub DirectoryPathTextBox_DragDrop(sender As Object, e As DragEventArgs) Handles DirectoryPathTextBox.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim Objetos2() As String = e.Data.GetData(DataFormats.FileDrop)

            For Each Archivo As String In Objetos2
                DirectoryPathTextBox.Text = Objetos2(0)
            Next

        End If


    End Sub

    Private Sub DirectoryPathTextBox_DragEnter(sender As Object, e As DragEventArgs) Handles DirectoryPathTextBox.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub renameAndMoveButton_Click(sender As Object, e As EventArgs) Handles renameAndMoveButton.Click


        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                           "Data Source=" & FileExcelPathTextBox.Text & ";" & _
                           "Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"""

        Dim connectionExcel As New OleDbConnection(connectionString)

        If Not File.Exists(FileExcelPathTextBox.Text) Then
            MsgBox("No se encontró el Documento de excel ", MsgBoxStyle.Critical, "Archivo inválido")
            Exit Sub
        End If

        If Not Directory.Exists(DirectoryPathTextBox.Text) Then
            MsgBox("No se encontró el directorio ", MsgBoxStyle.Critical, "Ruta inválida")
            Exit Sub
        End If



        Dim dataAdapter As New OleDbDataAdapter("Select * From [Hoja1$]", connectionString)
        Dim dataSet As New DataSet
        connectionExcel.Open()
        dataAdapter.Fill(dataSet)
        connectionExcel.Close()



        Dim dataTable As DataTable = dataSet.Tables(0)
        DataGridView1.DataSource = dataTable

        Dim directoryPath As String = Path.GetFullPath(DirectoryPathTextBox.Text)
        Dim directoryDir As New DirectoryInfo(directoryPath)

        searchDirectories(directoryPath)

        Dim successFileCount As Integer = 0
        Dim row As DataRow
        Dim myFilePath As String = Path.GetDirectoryName(FileExcelPathTextBox.Text)
        Dim myFileDirectoryPath As New DirectoryInfo(myFilePath)

        For Each row In dataTable.Rows
            For Each myFiles As FileInfo In myFileDirectoryPath.GetFiles()
                If Path.GetFileNameWithoutExtension(myFiles.FullName).ToString = row.Item(0).ToString Then

                    Dim oldNamePath = Path.GetFullPath(myFiles.FullName).ToString
                    Dim fileExtension = Path.GetExtension(myFiles.FullName).ToString

                    For i = 0 To listDirectoriesPath.Items.Count - 1
                        Dim getCurrentDirectory = (Path.GetDirectoryName(listDirectoriesPath.Items(i))).ToString
                        If listDirectoriesPath.Items(i) = getCurrentDirectory & "\" & row.Item(2).ToString Then
                            Dim newNamePath = getCurrentDirectory & "\" & row.Item(2).ToString & "\" & row.Item(1).ToString & fileExtension
                            If File.Exists(newNamePath) Then
                                MsgBox("El archivo: " & row.Item(1) & fileExtension & ", ¡ya existe!", MsgBoxStyle.Critical, "No se puede sobreescribir el archivo")
                            ElseIf Not File.Exists(newNamePath) Then
                                My.Computer.FileSystem.MoveFile(oldNamePath, newNamePath)
                                successFileCount += 1
                            End If
                        End If
                    Next
                End If
            Next
        Next
        listDirectoriesPath.Items.Clear()
        MsgBox("Archivos movidos correctamente: " & successFileCount, MsgBoxStyle.Information, "Archivos movidos")








    End Sub


    Private Function searchDirectories(searchInDirectoryPath As String) As String

        listDirectoriesPath.Items.Add(Path.GetFullPath(searchInDirectoryPath))
        For Each myDirectoryPath As String In Directory.GetDirectories(searchInDirectoryPath)
            listDirectoriesPath.Items.Add(myDirectoryPath)
            For Each mySubDirectoryPath As String In Directory.GetDirectories(myDirectoryPath)
                listDirectoriesPath.Items.Add(mySubDirectoryPath)
            Next
        Next
        Return ""
    End Function

    Private Sub renameButton_Click(sender As Object, e As EventArgs) Handles renameButton.Click

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                           "Data Source=" & FileExcelPathTextBox.Text & ";" & _
                           "Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"""

        Dim connectionExcel As New OleDbConnection(connectionString)

        If Not File.Exists(FileExcelPathTextBox.Text) Then
            MsgBox("No se encontró el Documento de excel ", MsgBoxStyle.Critical, "Archivo inválido")
            Exit Sub
        End If

        If Not Directory.Exists(DirectoryPathTextBox.Text) Then
            MsgBox("No se encontró el directorio ", MsgBoxStyle.Critical, "Ruta inválida")
            Exit Sub
        End If



        Dim dataAdapter As New OleDbDataAdapter("Select * From [Hoja1$]", connectionString)
        Dim dataSet As New DataSet
        connectionExcel.Open()
        dataAdapter.Fill(dataSet)
        connectionExcel.Close()



        Dim dataTable As DataTable = dataSet.Tables(0)
        DataGridView1.DataSource = dataTable

        Dim successFileRenamedCount As Integer = 0
        Dim filePath As String = Path.GetDirectoryName(FileExcelPathTextBox.Text)
        Dim fileDir As New DirectoryInfo(filePath)
        For Each row In dataTable.Rows
            For Each myFile As FileInfo In fileDir.GetFiles()
                If Path.GetFileNameWithoutExtension(myFile.FullName).ToString = row.Item(0).ToString Then
                    Dim oldNamePath = Path.GetFullPath(myFile.FullName).ToString
                    Dim fileExtension = Path.GetExtension(myFile.FullName).ToString
                    Dim newNamePath = row.Item(1).ToString & fileExtension
                    If File.Exists(newNamePath) Then
                        MsgBox("El archivo: " & row.Item(1) & fileExtension & ", ¡ya existe!", MsgBoxStyle.Critical, "No se puede sobreescribir el archivo")
                    ElseIf Not File.Exists(newNamePath) Then
                        My.Computer.FileSystem.RenameFile(oldNamePath, newNamePath)
                        successFileRenamedCount += 1

                    End If
                End If
            Next
        Next

        MsgBox("Archivos renombrados correctamente: " & successFileRenamedCount, MsgBoxStyle.Information, "Archivos renombrados")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Result = MsgBox("deseas continuar", MsgBoxStyle.OkCancel)
        If Result <> vbOK Then End
    End Sub
End Class

