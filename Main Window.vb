Public Class frmMainAppWindow

    Dim ThisFilename As String = Application.StartupPath & "\MyData.dat" 'Filepath for datagridview data    
    Dim entryIndex As Integer 'Declare variable for row index in Datagridview
    Dim rentScreenCheck As Boolean 'Declare variable for check whether checkout uses rent or return tab

    Dim totalPrice As New List(Of Double) 'Declare list for use in rent price calculation
    Dim totalPaid As New List(Of Double) 'Declare list for use in total paid calculation
    Dim totalFine As New List(Of Double) 'Decalre list for use in total fine calculation

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

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Application.Exit()  'Close application
        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close() 'Close application
        frmLoginScreen.Show() 'Open login screen
    End Sub

    'Open data file through dialog box
    Private Sub OpenDatabaseFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseFileToolStripMenuItem.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                LoadGridData(dgvBookRentList_B, path) 'loads data from openfiledialog
                MsgBox("File Loaded Succesfully.")
            Catch ex As Exception
                MsgBox("Error! File Loaded unsuccesfully")
            End Try
        End If
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab

        btnCheckout.Enabled = False 'disable checkout button until needed

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        LoadGridData(dgvBookRentList_B, ThisFilename) 'loads data from file into DataGridView
        dtpReturnDate.Value = Now 'set retun date to current date

        btnReturnCheckout.Enabled = False 'Disable check out button until fines are detected
        btnReturnCheckout.BackColor = Color.LightGray
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpReturn 'Show Return Tab

        gbFine.BackColor = Color.White
        lstReturnCartList.BackColor = Color.White

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Application.Exit()  'Close application
        End If
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
        Try
            dgvBookRentList_A.Rows.RemoveAt(entryIndex) 'Remove selected entry in datagridview

            SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

            'lstbDebug.Items.RemoveAt(entryIndex)
            'Remove selected book's entry price from totalPrice list
            totalPrice.RemoveAt(entryIndex)
            'calculate sum of list and update label
            lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
            'Update number of items
            lblNumItems.Text = totalPrice.Count.ToString

        Catch ex As Exception
            MsgBox("Please Select a valid entry.")
        End Try

    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click

        'Check if under 5 book limit
        If totalPrice.Count = 5 Then
            MsgBox("Book Limit of 5 reached")
        End If

        'Use error provider to check if textboxes have any text
        ErrorProvider1.Clear()
        If Not Me.ValidateChildren Then

            lblTextBoxValidation.Text = "Please input missing information."

        ElseIf Me.ValidateChildren Then

            lblTextBoxValidation.Visible = False

            'Add entered data into datagridview list
            dgvBookRentList_A.Rows.Add(txtBookID.Text, txtBookTitle.Text, txtAuthor.Text, txtPubYear.Text, txtCustomerName.Text, txtCustomerNum.Text, cboRentPrice.SelectedValue, dtpRentDate.Text, dtpDueDate.Text)
            SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

            'Add combobox Rent price to array
            totalPrice.Add(cboRentPrice.SelectedValue)

            'Enable Checkout Button
            btnCheckout.Enabled = True

            'calculate sum of list and update label
            lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
            'Update number of items
            lblNumItems.Text = totalPrice.Count.ToString

            'Add items to cart listbox
            Dim selectedRow As DataGridViewRow
            selectedRow = dgvBookRentList_A.Rows(entryIndex)

            lstRentCartList.Items.Add("Book ID: " + selectedRow.Cells(0).Value.ToString)
        End If


    End Sub


    Private Sub textboxRent_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBookID.Validating, txtCustomerNum.Validating, txtCustomerName.Validating, txtBookTitle.Validating, txtAuthor.Validating
        'Function event to check if textboxes are empty or not

        Dim ctl As Control = CType(sender, Control)
        If ctl.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(ctl, "Please enter a value")
        End If
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

        Try
            'update item at chose idex in list
            totalPrice(entryIndex) = cboRentPrice.SelectedValue
        Catch ex As Exception
            MsgBox("Could not update transaction list")
        End Try

        'calculate sum of list and update label
        lblTotalBill.Text = "RM " + totalPrice.Sum.ToString + ".00"
        'Update number of items
        lblNumItems.Text = totalPrice.Count.ToString

        SaveGridData(dgvBookRentList_A, ThisFilename) 'save datagridview to file

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
        Try
            'Function to save datagridview data to .dat file
            dgvBookRentList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
            dgvBookRentList.SelectAll()
            IO.File.WriteAllText(Filename, dgvBookRentList.GetClipboardContent().GetText.TrimEnd)
            dgvBookRentList.ClearSelection()
        Catch ex As Exception
            MsgBox("Database is empty or storage device is write protected. Please run program from writeable storage (e.g USB Flash drive)")
        End Try

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

        rentScreenCheck = True 'set check out screen to use UpdateCheckOutLabelsRent() function

        lblNumItems.Visible = True
        lblitemNumA.Visible = True
        lblCheckOutItems.Text = lblNumItems.Text
        lblCheckOutBill.Text = lblTotalBill.Text
    End Sub

    '----------------------------------------CHECK OUT TAB-----------------------------------------------------

    ' Function to update checkout labels after calculating change due
    Private Function UpdateCheckOutLabelsRent() As String
        lblCheckOutPaid.Text = "RM " + totalPaid.Sum.ToString("N2") 'calculate sum of list and update label

        If totalPaid.Sum > totalPrice.Sum Then
            lblChangeDue.Text = "RM " + (totalPaid.Sum - totalPrice.Sum).ToString("N2")
        Else
            lblChangeDue.Text = "RM 00.00"
        End If
        Return lblChangeDue.Text

    End Function

    Private Function UpdateCheckOutLabelsReturn() As String
        lblCheckOutBill.Text = "RM " + totalFine.Sum.ToString("N2") 'change label to total fine due
        lblCheckOutPaid.Text = "RM " + totalPaid.Sum.ToString("N2") 'calculate total paid and update label

        Dim changeDue As Double = (totalPaid.Sum - totalFine.Sum)

        If changeDue <= 0 Then
            lblChangeDue.Text = "RM 00.00"
        Else
            lblChangeDue.Text = "RM " + changeDue.ToString("N2")
        End If
        Return lblChangeDue.Text

    End Function

    'Denomination Buttons
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn10Sen.Click
        totalPaid.Add(0.1)

        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn50RM_Click(sender As Object, e As EventArgs) Handles btn50RM.Click
        totalPaid.Add(50.0)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If

    End Sub

    Private Sub btn50Sen_Click(sender As Object, e As EventArgs) Handles btn50Sen.Click
        totalPaid.Add(0.5)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn1RM_Click(sender As Object, e As EventArgs) Handles btn1RM.Click
        totalPaid.Add(1.0)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn5RM_Click(sender As Object, e As EventArgs) Handles btn5RM.Click
        totalPaid.Add(5.0)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn10RM_Click(sender As Object, e As EventArgs) Handles btn10RM.Click
        totalPaid.Add(10.0)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn20RM_Click(sender As Object, e As EventArgs) Handles btn20RM.Click
        totalPaid.Add(20.0)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub btn20Sen_Click(sender As Object, e As EventArgs) Handles btn20Sen.Click
        totalPaid.Add(0.2)
        'check if user is coming from rent screen or return screen and execute needed function
        If rentScreenCheck = True Then
            UpdateCheckOutLabelsRent()
        ElseIf rentScreenCheck = False Then
            UpdateCheckOutLabelsReturn()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnClearPaid.Click
        totalPaid.Clear()
        lblCheckOutPaid.Text = "RM 00.00"
        lblChangeDue.Text = "RM 00.00"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnEndTransaction.Click
        Dim result As DialogResult = MessageBox.Show("Transcation Complete! Go back to home screen?", "Notification")

        If result = DialogResult.OK Then
            Me.Controls.Clear() 'reset control and restart form
            Me.InitializeComponent()
            tcTabNavContainer.Visible = True 'Show tcTabNavContainer
            tcTabNavContainer.SelectedTab = tpRent 'Show Rent Tab
        End If

    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        LoadGridData(dgvBookRentList_A, ThisFilename) 'loads data from file
        MsgBox("File Loaded Succesfully.")
    End Sub

    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        SaveGridData(dgvBookRentList_A, ThisFilename) 'saves data to file
        MsgBox("File Saved Succesfully.")
    End Sub

    Private Sub dgvBookRentListB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookRentList_B.CellContentClick, dgvBookRentList_B.CellClick
        'Row entry shows in textboxes upon clicking
        entryIndex = e.RowIndex
        Dim selectedRowB As DataGridViewRow
        Try
            selectedRowB = dgvBookRentList_B.Rows(entryIndex)

            'Change Textbox and dates based on selected row
            txtReturnBookID.Text = selectedRowB.Cells(0).Value.ToString
            txtReturnBookTitle.Text = selectedRowB.Cells(1).Value.ToString
            txtReturnCustomerName.Text = selectedRowB.Cells(4).Value.ToString
            txtReturnCustomerNum.Text = selectedRowB.Cells(5).Value.ToString
            dtpReturnRentDate.Text = selectedRowB.Cells(7).Value.ToString
            dtpReturnDueDate.Text = selectedRowB.Cells(8).Value.ToString
        Catch ex As Exception
            'Ignore because user clicked on cell grids
        End Try

        'Calculate fines upon cell click, if any
        Dim overdueDays As Long = DateDiff(DateInterval.Day, dtpReturnDueDate.Value, dtpReturnDate.Value) 'Find difference in dates
        Dim currentFine As Long = (overdueDays * 1)

        If overdueDays <= 0 Then
            lblDaysOverdue.Text = "0 Days"
            gbFine.BackColor = Color.Honeydew
            lstReturnCartList.BackColor = Color.Honeydew
        Else
            btnReturnCheckout.Enabled = True 'enable checkout button
            btnReturnCheckout.BackColor = Color.Maroon
            gbFine.BackColor = Color.MistyRose
            lstReturnCartList.BackColor = Color.MistyRose
            lblDaysOverdue.Text = overdueDays.ToString + " Days"
            lblSelectedFine.Text = "RM " + currentFine.ToString("N2")
        End If

    End Sub



    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Dim overdueDays As Long = DateDiff(DateInterval.Day, dtpDueDate.Value, dtpReturnDate.Value) 'Find difference in dates
        Dim currentFine As Long = (overdueDays * 1) 'calculate fine due for current selection

        If overdueDays <= 0 Then
            dgvBookRentList_B.Rows.RemoveAt(entryIndex) 'Remove selected entry in datagridview
            SaveGridData(dgvBookRentList_B, ThisFilename) 'save datagridview to file

            lblReturnStatus.Visible = True
            lblReturnStatus.Enabled = True
            lblReturnStatus.Text = "Book Successfully Return!"
        ElseIf overdueDays > 0 Then
            Try
                lblReturnStatus.Visible = False
                totalFine.Add(CDbl(currentFine)) 'Cast to double and add current fine to list

                lblTotalFine.Text = "RM " + totalFine.Sum.ToString("N2") 'calculate sum of list and update label

                dgvBookRentList_B.Rows.RemoveAt(entryIndex) 'Remove selected entry in datagridview

                SaveGridData(dgvBookRentList_B, ThisFilename) 'save datagridview to file

                'Add items to cart listbox
                Dim selectedRow As DataGridViewRow
                selectedRow = dgvBookRentList_B.Rows(entryIndex)

                lstReturnCartList.Items.Add("Book ID: " + selectedRow.Cells(0).Value.ToString)
            Catch ex As Exception
                MsgBox("Please select a valid entry.")
            End Try

        End If

    End Sub

    Private Sub dtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnDate.ValueChanged

        'Calculate fines upon cell click, if any
        Dim overdueDays As Long = DateDiff(DateInterval.Day, dtpDueDate.Value, dtpReturnDate.Value) 'Find difference in dates
        Dim currentFine As Long = (overdueDays * 1)

        If overdueDays <= 0 Then
            lblDaysOverdue.Text = "0 Days"
            gbFine.BackColor = Color.Honeydew
            lstReturnCartList.BackColor = Color.MistyRose
        Else
            btnReturnCheckout.Enabled = True 'enable checkout button and change colour
            btnReturnCheckout.BackColor = Color.Maroon
            lstReturnCartList.BackColor = Color.MistyRose
            gbFine.BackColor = Color.MistyRose
            lblDaysOverdue.Text = overdueDays.ToString + " Days"
            lblSelectedFine.Text = "RM " + currentFine.ToString("N2")
        End If
    End Sub

    Private Sub btnReturnCheckout_Click(sender As Object, e As EventArgs) Handles btnReturnCheckout.Click
        tcTabNavContainer.Visible = True 'Show tcTabNavContainer
        tcTabNavContainer.SelectedTab = tpCheckOut 'Show checout tab

        rentScreenCheck = False 'set check out screen to use UpdateCheckOutLabelsReturn() function

        totalPaid.Clear() 'clear rent total paid list
        lblNumItems.Visible = False
        lblitemNumA.Visible = False
        lblCheckOutItems.Visible = False
        lblChangeDue.Text = "RM 00.00"
        lblCheckOutPaid.Text = "RM 00.00"
        lblCheckOutBill.Text = lblTotalFine.Text
    End Sub

End Class