<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FileExcelPathTextBox = New System.Windows.Forms.TextBox()
        Me.DirectoryPathTextBox = New System.Windows.Forms.TextBox()
        Me.SearchFileExcelButton = New System.Windows.Forms.Button()
        Me.searchdirectorybutton = New System.Windows.Forms.Button()
        Me.renameAndMoveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.listDirectoriesPath = New System.Windows.Forms.ListBox()
        Me.renameButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileExcelPathTextBox
        '
        Me.FileExcelPathTextBox.AllowDrop = True
        Me.FileExcelPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileExcelPathTextBox.Location = New System.Drawing.Point(23, 56)
        Me.FileExcelPathTextBox.Name = "FileExcelPathTextBox"
        Me.FileExcelPathTextBox.Size = New System.Drawing.Size(370, 20)
        Me.FileExcelPathTextBox.TabIndex = 0
        '
        'DirectoryPathTextBox
        '
        Me.DirectoryPathTextBox.AllowDrop = True
        Me.DirectoryPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectoryPathTextBox.Location = New System.Drawing.Point(23, 116)
        Me.DirectoryPathTextBox.Name = "DirectoryPathTextBox"
        Me.DirectoryPathTextBox.Size = New System.Drawing.Size(370, 20)
        Me.DirectoryPathTextBox.TabIndex = 1
        '
        'SearchFileExcelButton
        '
        Me.SearchFileExcelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchFileExcelButton.Location = New System.Drawing.Point(399, 54)
        Me.SearchFileExcelButton.Name = "SearchFileExcelButton"
        Me.SearchFileExcelButton.Size = New System.Drawing.Size(48, 23)
        Me.SearchFileExcelButton.TabIndex = 2
        Me.SearchFileExcelButton.Text = "..."
        Me.SearchFileExcelButton.UseVisualStyleBackColor = True
        '
        'searchdirectorybutton
        '
        Me.searchdirectorybutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchdirectorybutton.Location = New System.Drawing.Point(399, 114)
        Me.searchdirectorybutton.Name = "searchdirectorybutton"
        Me.searchdirectorybutton.Size = New System.Drawing.Size(48, 23)
        Me.searchdirectorybutton.TabIndex = 3
        Me.searchdirectorybutton.Text = "..."
        Me.searchdirectorybutton.UseVisualStyleBackColor = True
        '
        'renameAndMoveButton
        '
        Me.renameAndMoveButton.Location = New System.Drawing.Point(87, 154)
        Me.renameAndMoveButton.Name = "renameAndMoveButton"
        Me.renameAndMoveButton.Size = New System.Drawing.Size(109, 23)
        Me.renameAndMoveButton.TabIndex = 4
        Me.renameAndMoveButton.Text = "Renombrar y Mover"
        Me.renameAndMoveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscador Arvhico Excel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscador de folder"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(119, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'listDirectoriesPath
        '
        Me.listDirectoriesPath.FormattingEnabled = True
        Me.listDirectoriesPath.Location = New System.Drawing.Point(536, 166)
        Me.listDirectoriesPath.Name = "listDirectoriesPath"
        Me.listDirectoriesPath.Size = New System.Drawing.Size(453, 173)
        Me.listDirectoriesPath.TabIndex = 8
        Me.listDirectoriesPath.Visible = False
        '
        'renameButton
        '
        Me.renameButton.Location = New System.Drawing.Point(226, 154)
        Me.renameButton.Name = "renameButton"
        Me.renameButton.Size = New System.Drawing.Size(83, 23)
        Me.renameButton.TabIndex = 9
        Me.renameButton.Text = "Renombrar "
        Me.renameButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 356)
        Me.Controls.Add(Me.renameButton)
        Me.Controls.Add(Me.listDirectoriesPath)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.renameAndMoveButton)
        Me.Controls.Add(Me.searchdirectorybutton)
        Me.Controls.Add(Me.SearchFileExcelButton)
        Me.Controls.Add(Me.DirectoryPathTextBox)
        Me.Controls.Add(Me.FileExcelPathTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileExcelPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirectoryPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchFileExcelButton As System.Windows.Forms.Button
    Friend WithEvents searchdirectorybutton As System.Windows.Forms.Button
    Friend WithEvents renameAndMoveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents listDirectoriesPath As System.Windows.Forms.ListBox
    Friend WithEvents renameButton As System.Windows.Forms.Button

End Class
