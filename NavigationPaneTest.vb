Imports System.IO 'Allows writing/reading to file on disk

Public Class frmNavigationPaneTest

    Dim ThisFilename As String = Application.StartupPath & "\MyData.dat" 'Filepath for datagridview data    
    Dim entryIndex As Integer 'Declare variable for row index in Datagridview

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close() 'Close application
        frmLoginScreen.Show() 'Open login screen
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpReturn 'Show Return Tab
        btnReturn.BackColor = Color.DimGray

    End Sub

    Private Sub btnPlaceHolder1_Click(sender As Object, e As EventArgs) Handles btnPlaceHolder1.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpAddBook 'Show TabPage3

    End Sub

    Private Sub NavigationPaneTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcTabNavContainer.Visible = False 'Hide tcTabNavContainer when application opens
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()  'Close application
    End Sub

    Private Sub frmNavigationPaneTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Exit Application?", MsgBoxStyle.YesNo) 'Exit confirmation dialog

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            frmLoginScreen.Show() 'Open login dialog
            Me.Hide()

        End If


    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        'Remove selected entry in datagridview
        dgvBookRentList_A.Rows.RemoveAt(entryIndex)

    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        'Add entered data into datagridview list
        dgvBookRentList_A.Rows.Add(txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtPubYear.Text, txtStudentName.Text, txtAdmissionNum.Text, dtpRentDate.Text, dtpDueDate.Text)
        SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file
    End Sub

    Private Sub dgvBookRentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookRentList_A.CellClick
        'Row entry shows in textboxes upon clicking
        entryIndex = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvBookRentList_A.Rows(entryIndex)

        'Change Textbox and dates based on selected row
        txtBookID.Text = selectedRow.Cells(0).Value.ToString
        txtBookTitle.Text = selectedRow.Cells(1).Value.ToString
        txtAuthor.Text = selectedRow.Cells(2).Value.ToString
        txtPubYear.Text = selectedRow.Cells(3).Value.ToString
        txtStudentName.Text = selectedRow.Cells(4).Value.ToString
        txtAdmissionNum.Text = selectedRow.Cells(5).Value.ToString
        dtpRentDate.Text = selectedRow.Cells(6).Value.ToString
        dtpDueDate.Text = selectedRow.Cells(7).Value.ToString


    End Sub

    Private Sub txtAdmissionNo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBookID.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdateEntry.Click
        'Update slected row with new data

        Dim newDataRow As DataGridViewRow
        newDataRow = dgvBookRentList_A.Rows(entryIndex)

        newDataRow.Cells(0).Value = txtBookID.Text
        newDataRow.Cells(1).Value = txtBookTitle.Text
        newDataRow.Cells(2).Value = txtAuthor.Text
        newDataRow.Cells(3).Value = txtPubYear.Text
        newDataRow.Cells(4).Value = txtStudentName.Text
        newDataRow.Cells(5).Value = txtAdmissionNum.Text
        newDataRow.Cells(6).Value = dtpRentDate.Text
        newDataRow.Cells(7).Value = dtpDueDate.Text

        SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        'Attempt at textbox search
        Dim temp As Integer = 0
        For i As Integer = 0 To dgvBookRentList_A.RowCount - 1
            For j As Integer = 0 To dgvBookRentList_A.ColumnCount - 1
                If dgvBookRentList_A.Rows(i).Cells(j).Value.ToString = txtReturnBookID.Text Then
                    MsgBox("Item found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------------------

    Private Sub btnSaveGridData_Click(sender As Object, e As EventArgs) Handles btnSaveGridData.Click
        SaveGridData(dgvBookRentList_A, ThisFilename) 'loads data from file
    End Sub

    Private Sub btnLoadGridData_Click(sender As Object, e As EventArgs) Handles btnLoadGridDataA.Click
        LoadGridData(dgvBookRentList_A, ThisFilename) 'loads data from file
    End Sub

    Private Sub SaveGridData(ByRef dgvBookRentList As DataGridView, ByVal Filename As String)
        'Function to save datagridview data to .dat file
        dgvBookRentList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        dgvBookRentList.SelectAll()
        IO.File.WriteAllText(Filename, dgvBookRentList.GetClipboardContent().GetText.TrimEnd)
        dgvBookRentList.ClearSelection()
    End Sub

    Private Sub LoadGridData(ByRef dgvBookRentList As DataGridView, ByVal Filename As String)
        'Function to load datagridview data from .dat file
        dgvBookRentList.Rows.Clear()
        For Each THisLine In My.Computer.FileSystem.ReadAllText(Filename).Split(Environment.NewLine)
            dgvBookRentList.Rows.Add(Split(THisLine, "	"))
        Next
    End Sub

    Private Sub btnLoadGridDataB_Click(sender As Object, e As EventArgs) Handles btnLoadGridDataB.Click
        LoadGridData(dgvBookRentList_B, ThisFilename) 'loads data from file
    End Sub
End Class