Imports System.IO

Public Class FrmShutdown
    Private Sub BtnShutdown_Click(sender As Object, e As EventArgs) Handles BtnShutdown.Click
        If StartDelete() = False Then
            Exit Sub
        End If
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If StartDelete() = False Then
            Exit Sub
        End If
        System.Diagnostics.Process.Start("shutdown", "-l")
        Me.Close()
    End Sub

    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        If StartDelete() = False Then
            Exit Sub
        End If
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Fbd As New FolderBrowserDialog
        If Fbd.ShowDialog() = DialogResult.OK Then
            lbFolder.Items.Add(Fbd.SelectedPath)
        End If
        SaveFolder()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Do While (lbFolder.SelectedItems.Count > 0)
            lbFolder.Items.Remove(lbFolder.SelectedItem)
        Loop
        SaveFolder()
    End Sub

    Private Sub SaveFolder()
        Dim folders As New System.Collections.Specialized.StringCollection
        For Each entry As String In lbFolder.Items
            folders.Add(entry)
        Next

        My.Settings.Folders = folders
        My.Settings.Save()
    End Sub

    Private Sub frmShutdown_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (My.Settings.Folders Is Nothing) = False Then
            For Each entry As String In My.Settings.Folders
                lbFolder.Items.Add(entry)
            Next
        End If
        Me.ChkSubfolders.Checked = My.Settings.SubFolders
    End Sub

    Private Function FilesDelete(Folder As String, Optional blnSubfolder As Boolean = False) As Boolean
        For Each d In Directory.GetDirectories(Folder)
            If blnSubfolder = False Then Exit For
            If FilesDelete(d, blnSubfolder) = False Then
                Return False
            End If
            Directory.Delete(d, True)
        Next

        For Each f In Directory.GetFiles(Folder)
            Try
                File.Delete(f)
            Catch ex As System.IO.IOException
                MessageBox.Show(ex.Message)
                Return False
            End Try
        Next
        Return True
    End Function

    Private Function StartDelete() As Boolean
        My.Settings.SubFolders = Me.ChkSubfolders.Checked
        My.Settings.Save()

        For Each entry As String In lbFolder.Items
            If FilesDelete(entry, ChkSubfolders.Checked) = False Then
                MessageBox.Show("Das Beenden wird abgebrochen.")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        FrmAbout.ShowDialog()
    End Sub
End Class
