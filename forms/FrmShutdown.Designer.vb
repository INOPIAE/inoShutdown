<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShutdown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnShutdown = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblFolder = New System.Windows.Forms.Label()
        Me.lbFolder = New System.Windows.Forms.ListBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.ChkSubfolders = New System.Windows.Forms.CheckBox()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnShutdown
        '
        Me.BtnShutdown.Location = New System.Drawing.Point(73, 353)
        Me.BtnShutdown.Name = "BtnShutdown"
        Me.BtnShutdown.Size = New System.Drawing.Size(121, 32)
        Me.BtnShutdown.TabIndex = 0
        Me.BtnShutdown.Text = "Herunterfahren"
        Me.BtnShutdown.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(216, 353)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(121, 32)
        Me.BtnLogout.TabIndex = 1
        Me.BtnLogout.Text = "Abmelden"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnRestart
        '
        Me.BtnRestart.Location = New System.Drawing.Point(359, 353)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(121, 32)
        Me.BtnRestart.TabIndex = 2
        Me.BtnRestart.Text = "Neustarten"
        Me.BtnRestart.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(527, 353)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(121, 32)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Abbrechen"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblFolder
        '
        Me.LblFolder.AutoSize = True
        Me.LblFolder.Location = New System.Drawing.Point(79, 33)
        Me.LblFolder.Name = "LblFolder"
        Me.LblFolder.Size = New System.Drawing.Size(165, 13)
        Me.LblFolder.TabIndex = 4
        Me.LblFolder.Text = "Ordner, die geleert werden sollen:"
        '
        'lbFolder
        '
        Me.lbFolder.FormattingEnabled = True
        Me.lbFolder.Location = New System.Drawing.Point(83, 83)
        Me.lbFolder.Name = "lbFolder"
        Me.lbFolder.Size = New System.Drawing.Size(408, 212)
        Me.lbFolder.TabIndex = 5
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(527, 83)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 32)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Hinzufügen"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(527, 121)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(121, 32)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "Löschen"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'ChkSubfolders
        '
        Me.ChkSubfolders.AutoSize = True
        Me.ChkSubfolders.Location = New System.Drawing.Point(76, 312)
        Me.ChkSubfolders.Name = "ChkSubfolders"
        Me.ChkSubfolders.Size = New System.Drawing.Size(138, 17)
        Me.ChkSubfolders.TabIndex = 8
        Me.ChkSubfolders.Text = "Unterordner mit löschen"
        Me.ChkSubfolders.UseVisualStyleBackColor = True
        '
        'BtnInfo
        '
        Me.BtnInfo.Location = New System.Drawing.Point(599, 269)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(49, 26)
        Me.BtnInfo.TabIndex = 9
        Me.BtnInfo.Text = "Info"
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'FrmShutdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 450)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.ChkSubfolders)
        Me.Controls.Add(Me.lbFolder)
        Me.Controls.Add(Me.LblFolder)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnShutdown)
        Me.Name = "FrmShutdown"
        Me.Text = "Ordner leeren beim Beenden von Windows"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnShutdown As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnRestart As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblFolder As Label
    Friend WithEvents lbFolder As ListBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ChkSubfolders As CheckBox
    Friend WithEvents BtnInfo As Button
End Class
