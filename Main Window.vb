Imports System.IO 'Allows writing/reading to file on disk

Public Class frmMainAppWindow

    Dim ThisFilename As String = Application.StartupPath & "\MyData.dat" 'Filepath for datagridview data    
    Dim entryIndex As Integer 'Declare variable for row index in Datagridview

    Dim totalPrice As New List(Of Double) 'Declare list for use in rent price calculation
    Dim totalPaid As New List(Of Double) 'Declare list for use in total paid calculation

    'Form load event
    Private Sub NavigationPaneTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize DisplayMember and ValueMember of an existing combobox to be filled with dictionary values
        cboRentPrice.DisplayMember = "Key"
        cboRentPrice.ValueMember = "Value"

        'Declare and fill dictionary for use in Rent Price Combobox
        Dim rentPriceDic As New Dictionary(Of String, Double) From {
            {"Fiction Book: RM10", 10},
            {"Non-Fiction Book: RM11", 11},
            {"Text Book: RM12", 12},
            {"Reference Book: RM15", 15}
        }
        'Bind the combobox to dictionary
        cboRentPrice.DataSource = New BindingSource(rentPriceDic, Nothing)

        tcTabNavContainer.Visible = False 'Hide tcTabNavContainer when application opens

        dtpDueDate.Value = dtpRentDate.Value.AddDays(7) 'Set due date to 7 days after current rent date
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close() 'Close application
        frmLoginScreen.Show() 'Open login screen
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        LoadGridData(dgvBookRentList_B, ThisFilename) 'loads data from file into DataGridView

        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpReturn 'Show Return Tab
        btnReturn.BackColor = Color.DimGray

    End Sub

    Private Sub btnPlaceHolder1_Click(sender As Object, e As EventArgs) Handles btnPlaceHolder1.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpAddBook 'Show TabPage3

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()  'Close application
    End Sub

    Private Sub frmNavigationPaneTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Are you you want to Log Out?", MsgBoxStyle.YesNo) 'Exit confirmation dialog

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            frmLoginScreen.Show() 'Open login dialog
            Me.Hide()

        End If


    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click

        dgvBookRentList_A.Rows.RemoveAt(entryIndex) 'Remove selected entry in datagridview

        SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

        'lstbDebug.Items.RemoveAt(entryIndex)
        'Remove selected book's entry price from totalPrice list
        totalPrice.RemoveAt(entryIndex)
        'calculate sum of list and update label
        lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
        'Update number of items
        lblNumItems.Text = totalPrice.Count.ToString


    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        'Check if under 5 book limit
        If totalPrice.Count = 5 Then
            MsgBox("Book Limit of 5 reached")
        End If

        'Add entered data into datagridview list
        dgvBookRentList_A.Rows.Add(txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtPubYear.Text, txtCustomerName.Text, txtCustomerNum.Text, cboRentPrice.SelectedValue, dtpRentDate.Text, dtpDueDate.Text)
        SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

        'Add combobox Rent price to array
        totalPrice.Add(cboRentPrice.SelectedValue)

        'lstbDebug.Items.Add(cboRentPrice.SelectedValue)

        'calculate sum of list and update label
        lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
        'Update number of items
        lblNumItems.Text = totalPrice.Count.ToString

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
        txtCustomerName.Text = selectedRow.Cells(4).Value.ToString
        txtCustomerNum.Text = selectedRow.Cells(5).Value.ToString
        'cboRentPrice.SelectedValue = selectedRow.Cells(6).Value.ToString
        dtpRentDate.Text = selectedRow.Cells(7).Value.ToString
        dtpDueDate.Text = selectedRow.Cells(8).Value.ToString


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
        newDataRow.Cells(4).Value = txtCustomerName.Text
        newDataRow.Cells(5).Value = txtCustomerNum.Text
        newDataRow.Cells(6).Value = cboRentPrice.SelectedValue
        newDataRow.Cells(7).Value = dtpRentDate.Text
        newDataRow.Cells(8).Value = dtpDueDate.Text

        'update item at chose idex in list
        totalPrice(entryIndex) = cboRentPrice.SelectedValue
        'calculate sum of list and update label
        lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
        'Update number of items
        lblNumItems.Text = totalPrice.Count.ToString

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

    Private Sub btnSaveGridData_Click(sender As Object, e As EventArgs) 
        SaveGridData(dgvBookRentList_A, ThisFilename) 'loads data from file
    End Sub

    Private Sub btnLoadGridData_Click(sender As Object, e As EventArgs) 
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

    Private Sub btnLoadGridDataB_Click(sender As Object, e As EventArgs) 
        LoadGridData(dgvBookRentList_B, ThisFilename) 'loads data from file
    End Sub

    Private Sub dtpRentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpRentDate.ValueChanged
        dtpDueDate.Value = dtpRentDate.Value.AddDays(7) 'Set due date to 7 days after current rent date
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpCheckOut 'Show checout tab

        lblCheckOutItems.Text = lblNumItems.Text
        lblCheckOutBill.Text = lblTotalBill.Text
    End Sub

    '----------------------------------------------------------------------------------------------------------

    ' Function to update checkout labels after calculating change due
    Private Function UpdateCheckOutLabels() As String
        lblCheckOutPaid.Text = "RM " + totalPaid.Sum.ToString("N2") 'calculate sum of list and update label

        If totalPaid.Sum > totalPrice.Sum Then
            lblChangeDue.Text = "RM " + (totalPaid.Sum - totalPrice.Sum).ToString("N2")
        Else
            lblChangeDue.Text = "RM 00.00"
        End If
        Return lblChangeDue.Text

    End Function

    'Denomination Buttons
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn10Sen.Click
        totalPaid.Add(0.1)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn50RM_Click(sender As Object, e As EventArgs) Handles btn50RM.Click
        totalPaid.Add(50.0)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn50Sen_Click(sender As Object, e As EventArgs) Handles btn50Sen.Click
        totalPaid.Add(0.5)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn1RM_Click(sender As Object, e As EventArgs) Handles btn1RM.Click
        totalPaid.Add(1.0)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn5RM_Click(sender As Object, e As EventArgs) Handles btn5RM.Click
        totalPaid.Add(5.0)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn10RM_Click(sender As Object, e As EventArgs) Handles btn10RM.Click
        totalPaid.Add(10.0)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn20RM_Click(sender As Object, e As EventArgs) Handles btn20RM.Click
        totalPaid.Add(20.0)
        UpdateCheckOutLabels()
    End Sub

    Private Sub btn20Sen_Click(sender As Object, e As EventArgs) Handles btn20Sen.Click
        totalPaid.Add(0.2)
        UpdateCheckOutLabels()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnClearPaid.Click
        totalPaid.Clear()
        lblCheckOutPaid.Text = "RM 00.00"
        lblChangeDue.Text = "RM 00.00"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnEndTransaction.Click
        Dim result As DialogResult = MessageBox.Show("Transcation Complete! Go back to Rent Screen?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            tcTabNavContainer.Visible = True 'Show tcTabNavContainer
            tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab
        End If

    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        LoadGridData(dgvBookRentList_A, ThisFilename) 'loads data from file
    End Sub

    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        SaveGridData(dgvBookRentList_A, ThisFilename) 'saves data to file
    End Sub
End Class