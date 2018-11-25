<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainAppWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainAppWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstbDebug = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPlaceHolder1 = New System.Windows.Forms.Button()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.msTopMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpAddBook = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPublicationYear = New System.Windows.Forms.TextBox()
        Me.txtMarketPrice = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tpReturn = New System.Windows.Forms.TabPage()
        Me.gbFine = New System.Windows.Forms.GroupBox()
        Me.lblTotalFine = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblSelectedFine = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dgvBookRentList_B = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReturnBookID = New System.Windows.Forms.MaskedTextBox()
        Me.cbBookCondition = New System.Windows.Forms.ComboBox()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.txtReturnBookTitle = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtReturnCustomerName = New System.Windows.Forms.TextBox()
        Me.txtReturnCustomerNum = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblDaysOverdue = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpReturnDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturnRentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tpRent = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lstCartList = New System.Windows.Forms.ListBox()
        Me.lblNumItems = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvBookRentList_A = New System.Windows.Forms.DataGridView()
        Me.IDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpRentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerNum = New System.Windows.Forms.MaskedTextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboRentPrice = New System.Windows.Forms.ComboBox()
        Me.txtBookID = New System.Windows.Forms.MaskedTextBox()
        Me.txtPubYear = New System.Windows.Forms.MaskedTextBox()
        Me.btnUpdateEntry = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.btnIssueBook = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tcTabNavContainer = New System.Windows.Forms.TabControl()
        Me.tpCheckOut = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rtxtReceipt = New System.Windows.Forms.RichTextBox()
        Me.gbDenominations = New System.Windows.Forms.GroupBox()
        Me.btn50RM = New System.Windows.Forms.Button()
        Me.btn10Sen = New System.Windows.Forms.Button()
        Me.btn20RM = New System.Windows.Forms.Button()
        Me.btn20Sen = New System.Windows.Forms.Button()
        Me.btn10RM = New System.Windows.Forms.Button()
        Me.btn50Sen = New System.Windows.Forms.Button()
        Me.btn5RM = New System.Windows.Forms.Button()
        Me.btn1RM = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnClearPaid = New System.Windows.Forms.Button()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblCheckOutPaid = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblCheckOutItems = New System.Windows.Forms.Label()
        Me.btnEndTransaction = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblCheckOutBill = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.msTopMainMenu.SuspendLayout()
        Me.tpAddBook.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReturn.SuspendLayout()
        Me.gbFine.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgvBookRentList_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpRent.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvBookRentList_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tcTabNavContainer.SuspendLayout()
        Me.tpCheckOut.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.gbDenominations.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lstbDebug)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.btnPlaceHolder1)
        Me.Panel1.Controls.Add(Me.btnRent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 630)
        Me.Panel1.TabIndex = 1
        '
        'lstbDebug
        '
        Me.lstbDebug.FormattingEnabled = True
        Me.lstbDebug.Location = New System.Drawing.Point(4, 326)
        Me.lstbDebug.Name = "lstbDebug"
        Me.lstbDebug.Size = New System.Drawing.Size(153, 199)
        Me.lstbDebug.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(-3, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "USERS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-3, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "BOOKS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturn.Location = New System.Drawing.Point(-3, 126)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(163, 43)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder1
        '
        Me.btnPlaceHolder1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPlaceHolder1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPlaceHolder1.FlatAppearance.BorderSize = 0
        Me.btnPlaceHolder1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPlaceHolder1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPlaceHolder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceHolder1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceHolder1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlaceHolder1.Location = New System.Drawing.Point(-3, 170)
        Me.btnPlaceHolder1.Name = "btnPlaceHolder1"
        Me.btnPlaceHolder1.Size = New System.Drawing.Size(163, 43)
        Me.btnPlaceHolder1.TabIndex = 1
        Me.btnPlaceHolder1.Text = "Placeholder1"
        Me.btnPlaceHolder1.UseVisualStyleBackColor = False
        '
        'btnRent
        '
        Me.btnRent.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnRent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRent.Location = New System.Drawing.Point(-3, 82)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(163, 43)
        Me.btnRent.TabIndex = 0
        Me.btnRent.Text = "Rent / Issue"
        Me.btnRent.UseVisualStyleBackColor = False
        '
        'msTopMainMenu
        '
        Me.msTopMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.msTopMainMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msTopMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BookManagementToolStripMenuItem})
        Me.msTopMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msTopMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msTopMainMenu.Name = "msTopMainMenu"
        Me.msTopMainMenu.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.msTopMainMenu.Size = New System.Drawing.Size(1164, 24)
        Me.msTopMainMenu.TabIndex = 2
        Me.msTopMainMenu.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LogOutToolStripMenuItem.Text = "Log &Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'BookManagementToolStripMenuItem
        '
        Me.BookManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDataToolStripMenuItem, Me.SaveDataToolStripMenuItem, Me.AddBookToolStripMenuItem})
        Me.BookManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BookManagementToolStripMenuItem.Name = "BookManagementToolStripMenuItem"
        Me.BookManagementToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.BookManagementToolStripMenuItem.Text = "Data Management"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.BackColor = System.Drawing.Color.Ivory
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LoadDataToolStripMenuItem.Text = "Load Database"
        '
        'SaveDataToolStripMenuItem
        '
        Me.SaveDataToolStripMenuItem.BackColor = System.Drawing.Color.Honeydew
        Me.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        Me.SaveDataToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SaveDataToolStripMenuItem.Text = "Save Database"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddBookToolStripMenuItem.Text = "Delete Database"
        '
        'tpAddBook
        '
        Me.tpAddBook.BackColor = System.Drawing.Color.White
        Me.tpAddBook.Controls.Add(Me.GroupBox7)
        Me.tpAddBook.Location = New System.Drawing.Point(4, 24)
        Me.tpAddBook.Margin = New System.Windows.Forms.Padding(0)
        Me.tpAddBook.Name = "tpAddBook"
        Me.tpAddBook.Size = New System.Drawing.Size(996, 602)
        Me.tpAddBook.TabIndex = 2
        Me.tpAddBook.Text = "Add Book"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox7.Controls.Add(Me.TextBox4)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.btnLogin)
        Me.GroupBox7.Controls.Add(Me.btnSelectImage)
        Me.GroupBox7.Controls.Add(Me.txtQuantity)
        Me.GroupBox7.Controls.Add(Me.PictureBox3)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.txtPublicationYear)
        Me.GroupBox7.Controls.Add(Me.txtMarketPrice)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.TextBox5)
        Me.GroupBox7.Controls.Add(Me.TextBox6)
        Me.GroupBox7.Controls.Add(Me.TextBox7)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(599, 306)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Book Information"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(324, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(253, 25)
        Me.TextBox4.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Rent Price (RM) :"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(324, 255)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 27)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "&Add Book"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnSelectImage
        '
        Me.btnSelectImage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelectImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectImage.Location = New System.Drawing.Point(32, 254)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(142, 29)
        Me.btnSelectImage.TabIndex = 11
        Me.btnSelectImage.Text = "&Select Image"
        Me.btnSelectImage.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(324, 224)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(253, 25)
        Me.txtQuantity.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(32, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 210)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(189, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Quantity :"
        '
        'txtPublicationYear
        '
        Me.txtPublicationYear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPublicationYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublicationYear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublicationYear.Location = New System.Drawing.Point(324, 193)
        Me.txtPublicationYear.Name = "txtPublicationYear"
        Me.txtPublicationYear.Size = New System.Drawing.Size(253, 25)
        Me.txtPublicationYear.TabIndex = 6
        '
        'txtMarketPrice
        '
        Me.txtMarketPrice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMarketPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarketPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarketPrice.Location = New System.Drawing.Point(324, 131)
        Me.txtMarketPrice.Name = "txtMarketPrice"
        Me.txtMarketPrice.Size = New System.Drawing.Size(253, 25)
        Me.txtMarketPrice.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(189, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 17)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Publication Year :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(189, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 17)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Market Price (RM) :"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(324, 101)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(253, 25)
        Me.TextBox5.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(324, 71)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(253, 25)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(324, 41)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(95, 25)
        Me.TextBox7.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(189, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Author(s) :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(189, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 17)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Book Title :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(189, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "ID No. :"
        '
        'tpReturn
        '
        Me.tpReturn.BackColor = System.Drawing.Color.White
        Me.tpReturn.Controls.Add(Me.gbFine)
        Me.tpReturn.Controls.Add(Me.GroupBox8)
        Me.tpReturn.Controls.Add(Me.GroupBox5)
        Me.tpReturn.Controls.Add(Me.GroupBox3)
        Me.tpReturn.Location = New System.Drawing.Point(4, 24)
        Me.tpReturn.Margin = New System.Windows.Forms.Padding(0)
        Me.tpReturn.Name = "tpReturn"
        Me.tpReturn.Size = New System.Drawing.Size(996, 602)
        Me.tpReturn.TabIndex = 1
        Me.tpReturn.Text = "Return"
        '
        'gbFine
        '
        Me.gbFine.BackColor = System.Drawing.Color.MistyRose
        Me.gbFine.Controls.Add(Me.ListBox1)
        Me.gbFine.Controls.Add(Me.lblTotalFine)
        Me.gbFine.Controls.Add(Me.Label28)
        Me.gbFine.Controls.Add(Me.Button2)
        Me.gbFine.Controls.Add(Me.lblSelectedFine)
        Me.gbFine.Controls.Add(Me.Label37)
        Me.gbFine.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbFine.Location = New System.Drawing.Point(808, 8)
        Me.gbFine.Name = "gbFine"
        Me.gbFine.Size = New System.Drawing.Size(178, 228)
        Me.gbFine.TabIndex = 16
        Me.gbFine.TabStop = False
        Me.gbFine.Text = "Fine"
        '
        'lblTotalFine
        '
        Me.lblTotalFine.AutoSize = True
        Me.lblTotalFine.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFine.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFine.Location = New System.Drawing.Point(66, 151)
        Me.lblTotalFine.Name = "lblTotalFine"
        Me.lblTotalFine.Size = New System.Drawing.Size(106, 30)
        Me.lblTotalFine.TabIndex = 20
        Me.lblTotalFine.Text = "RM 00.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(102, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 17)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "Total Fine :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(78, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 30)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Checkout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblSelectedFine
        '
        Me.lblSelectedFine.AutoSize = True
        Me.lblSelectedFine.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedFine.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectedFine.Location = New System.Drawing.Point(76, 101)
        Me.lblSelectedFine.Name = "lblSelectedFine"
        Me.lblSelectedFine.Size = New System.Drawing.Size(96, 25)
        Me.lblSelectedFine.TabIndex = 9
        Me.lblSelectedFine.Text = "RM 00.00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(81, 86)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(91, 17)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Selected Fine :"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dgvBookRentList_B)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 242)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(986, 352)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Return List"
        '
        'dgvBookRentList_B
        '
        Me.dgvBookRentList_B.AllowUserToAddRows = False
        Me.dgvBookRentList_B.AllowUserToDeleteRows = False
        Me.dgvBookRentList_B.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookRentList_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBookRentList_B.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBookRentList_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookRentList_B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvBookRentList_B.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBookRentList_B.Location = New System.Drawing.Point(6, 24)
        Me.dgvBookRentList_B.Name = "dgvBookRentList_B"
        Me.dgvBookRentList_B.ReadOnly = True
        Me.dgvBookRentList_B.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBookRentList_B.Size = New System.Drawing.Size(979, 336)
        Me.dgvBookRentList_B.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 112
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Rent Price RM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rent Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtReturnBookID)
        Me.GroupBox5.Controls.Add(Me.cbBookCondition)
        Me.GroupBox5.Controls.Add(Me.btnReturnBook)
        Me.GroupBox5.Controls.Add(Me.txtReturnBookTitle)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.txtReturnCustomerName)
        Me.GroupBox5.Controls.Add(Me.txtReturnCustomerNum)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(450, 230)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Return Infromation"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Condition :"
        '
        'txtReturnBookID
        '
        Me.txtReturnBookID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtReturnBookID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtReturnBookID.Location = New System.Drawing.Point(129, 25)
        Me.txtReturnBookID.Mask = "a00"
        Me.txtReturnBookID.Name = "txtReturnBookID"
        Me.txtReturnBookID.Size = New System.Drawing.Size(81, 25)
        Me.txtReturnBookID.TabIndex = 19
        Me.txtReturnBookID.ValidatingType = GetType(Integer)
        '
        'cbBookCondition
        '
        Me.cbBookCondition.FormattingEnabled = True
        Me.cbBookCondition.Items.AddRange(New Object() {"As New", "Fine", "Fair", "Poor"})
        Me.cbBookCondition.Location = New System.Drawing.Point(129, 149)
        Me.cbBookCondition.Name = "cbBookCondition"
        Me.cbBookCondition.Size = New System.Drawing.Size(200, 25)
        Me.cbBookCondition.TabIndex = 6
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReturnBook.FlatAppearance.BorderSize = 0
        Me.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturnBook.Location = New System.Drawing.Point(129, 194)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(95, 30)
        Me.btnReturnBook.TabIndex = 15
        Me.btnReturnBook.Text = "Return"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'txtReturnBookTitle
        '
        Me.txtReturnBookTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtReturnBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnBookTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnBookTitle.Location = New System.Drawing.Point(129, 56)
        Me.txtReturnBookTitle.Name = "txtReturnBookTitle"
        Me.txtReturnBookTitle.Size = New System.Drawing.Size(293, 25)
        Me.txtReturnBookTitle.TabIndex = 17
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 59)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 17)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Book Title :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 17)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "ID No. :"
        '
        'txtReturnCustomerName
        '
        Me.txtReturnCustomerName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtReturnCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnCustomerName.Location = New System.Drawing.Point(129, 118)
        Me.txtReturnCustomerName.Name = "txtReturnCustomerName"
        Me.txtReturnCustomerName.Size = New System.Drawing.Size(293, 25)
        Me.txtReturnCustomerName.TabIndex = 1
        '
        'txtReturnCustomerNum
        '
        Me.txtReturnCustomerNum.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtReturnCustomerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnCustomerNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnCustomerNum.Location = New System.Drawing.Point(129, 87)
        Me.txtReturnCustomerNum.Name = "txtReturnCustomerNum"
        Me.txtReturnCustomerNum.Size = New System.Drawing.Size(95, 25)
        Me.txtReturnCustomerNum.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Customer Name :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Customer ID No. :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.lblDaysOverdue)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpReturnDate)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpReturnDueDate)
        Me.GroupBox3.Controls.Add(Me.dtpReturnRentDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(459, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 228)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Date Information"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Maroon
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(9, 17)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 68)
        Me.ListBox1.TabIndex = 21
        '
        'lblDaysOverdue
        '
        Me.lblDaysOverdue.AutoSize = True
        Me.lblDaysOverdue.BackColor = System.Drawing.Color.Transparent
        Me.lblDaysOverdue.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysOverdue.Location = New System.Drawing.Point(114, 119)
        Me.lblDaysOverdue.Name = "lblDaysOverdue"
        Me.lblDaysOverdue.Size = New System.Drawing.Size(78, 30)
        Me.lblDaysOverdue.TabIndex = 23
        Me.lblDaysOverdue.Text = "0 Days"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Total Fine :"
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.dtpReturnDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpReturnDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturnDate.Location = New System.Drawing.Point(119, 87)
        Me.dtpReturnDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpReturnDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReturnDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpReturnDate.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Return Date :"
        '
        'dtpReturnDueDate
        '
        Me.dtpReturnDueDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.dtpReturnDueDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpReturnDueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturnDueDate.Location = New System.Drawing.Point(119, 56)
        Me.dtpReturnDueDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpReturnDueDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnDueDate.Name = "dtpReturnDueDate"
        Me.dtpReturnDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReturnDueDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpReturnDueDate.TabIndex = 3
        '
        'dtpReturnRentDate
        '
        Me.dtpReturnRentDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.dtpReturnRentDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpReturnRentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturnRentDate.Location = New System.Drawing.Point(119, 25)
        Me.dtpReturnRentDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpReturnRentDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnRentDate.Name = "dtpReturnRentDate"
        Me.dtpReturnRentDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReturnRentDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpReturnRentDate.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Due Date :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Rent Date :"
        '
        'tpRent
        '
        Me.tpRent.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tpRent.Controls.Add(Me.GroupBox9)
        Me.tpRent.Controls.Add(Me.GroupBox6)
        Me.tpRent.Controls.Add(Me.GroupBox4)
        Me.tpRent.Controls.Add(Me.GroupBox1)
        Me.tpRent.Controls.Add(Me.GroupBox2)
        Me.tpRent.Location = New System.Drawing.Point(4, 24)
        Me.tpRent.Name = "tpRent"
        Me.tpRent.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRent.Size = New System.Drawing.Size(996, 602)
        Me.tpRent.TabIndex = 0
        Me.tpRent.Text = "Rent"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox9.Controls.Add(Me.lstCartList)
        Me.GroupBox9.Controls.Add(Me.lblNumItems)
        Me.GroupBox9.Controls.Add(Me.btnCheckout)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.lblTotalBill)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox9.Location = New System.Drawing.Point(791, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(180, 272)
        Me.GroupBox9.TabIndex = 11
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = " Cart"
        '
        'lstCartList
        '
        Me.lstCartList.BackColor = System.Drawing.Color.Maroon
        Me.lstCartList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCartList.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCartList.FormattingEnabled = True
        Me.lstCartList.ItemHeight = 17
        Me.lstCartList.Location = New System.Drawing.Point(9, 23)
        Me.lstCartList.Name = "lstCartList"
        Me.lstCartList.Size = New System.Drawing.Size(160, 119)
        Me.lstCartList.TabIndex = 20
        '
        'lblNumItems
        '
        Me.lblNumItems.AutoSize = True
        Me.lblNumItems.BackColor = System.Drawing.Color.Transparent
        Me.lblNumItems.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumItems.Location = New System.Drawing.Point(149, 146)
        Me.lblNumItems.Name = "lblNumItems"
        Me.lblNumItems.Size = New System.Drawing.Size(25, 30)
        Me.lblNumItems.TabIndex = 19
        Me.lblNumItems.Text = "0"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Goldenrod
        Me.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCheckout.Location = New System.Drawing.Point(80, 234)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(94, 30)
        Me.btnCheckout.TabIndex = 18
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 154)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(87, 17)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "No. of Items :"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.AutoSize = True
        Me.lblTotalBill.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBill.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBill.Location = New System.Drawing.Point(71, 183)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(106, 30)
        Me.lblTotalBill.TabIndex = 9
        Me.lblTotalBill.Text = "RM 00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvBookRentList_A)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 278)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(963, 310)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'dgvBookRentList_A
        '
        Me.dgvBookRentList_A.AllowUserToAddRows = False
        Me.dgvBookRentList_A.AllowUserToDeleteRows = False
        Me.dgvBookRentList_A.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookRentList_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBookRentList_A.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBookRentList_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookRentList_A.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDNumber, Me.BookTitle, Me.BookAuthor, Me.BookYear, Me.StudentName, Me.CustomerID, Me.RentPrice, Me.RentDate, Me.DueDate})
        Me.dgvBookRentList_A.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBookRentList_A.Location = New System.Drawing.Point(6, 13)
        Me.dgvBookRentList_A.Name = "dgvBookRentList_A"
        Me.dgvBookRentList_A.ReadOnly = True
        Me.dgvBookRentList_A.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBookRentList_A.Size = New System.Drawing.Size(948, 291)
        Me.dgvBookRentList_A.TabIndex = 7
        '
        'IDNumber
        '
        Me.IDNumber.HeaderText = "ID"
        Me.IDNumber.Name = "IDNumber"
        Me.IDNumber.ReadOnly = True
        Me.IDNumber.Width = 60
        '
        'BookTitle
        '
        Me.BookTitle.HeaderText = "Title"
        Me.BookTitle.Name = "BookTitle"
        Me.BookTitle.ReadOnly = True
        Me.BookTitle.Width = 120
        '
        'BookAuthor
        '
        Me.BookAuthor.HeaderText = "Author"
        Me.BookAuthor.Name = "BookAuthor"
        Me.BookAuthor.ReadOnly = True
        Me.BookAuthor.Width = 120
        '
        'BookYear
        '
        Me.BookYear.HeaderText = "Year"
        Me.BookYear.Name = "BookYear"
        Me.BookYear.ReadOnly = True
        Me.BookYear.Width = 50
        '
        'StudentName
        '
        Me.StudentName.HeaderText = "Name"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        '
        'CustomerID
        '
        Me.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Width = 112
        '
        'RentPrice
        '
        Me.RentPrice.HeaderText = "Rent Price RM"
        Me.RentPrice.Name = "RentPrice"
        Me.RentPrice.ReadOnly = True
        Me.RentPrice.Width = 120
        '
        'RentDate
        '
        Me.RentDate.HeaderText = "Rent Date"
        Me.RentDate.Name = "RentDate"
        Me.RentDate.ReadOnly = True
        '
        'DueDate
        '
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.dtpDueDate)
        Me.GroupBox4.Controls.Add(Me.dtpRentDate)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(384, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(399, 124)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Issue Information"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.dtpDueDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpDueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDueDate.Location = New System.Drawing.Point(119, 56)
        Me.dtpDueDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpDueDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpDueDate.TabIndex = 3
        '
        'dtpRentDate
        '
        Me.dtpRentDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark
        Me.dtpRentDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpRentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentDate.Location = New System.Drawing.Point(119, 19)
        Me.dtpRentDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpRentDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpRentDate.Name = "dtpRentDate"
        Me.dtpRentDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpRentDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpRentDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Due Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Rent Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtCustomerNum)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(384, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Customer Information"
        '
        'txtCustomerNum
        '
        Me.txtCustomerNum.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCustomerNum.Location = New System.Drawing.Point(119, 22)
        Me.txtCustomerNum.Mask = "a00"
        Me.txtCustomerNum.Name = "txtCustomerNum"
        Me.txtCustomerNum.Size = New System.Drawing.Size(81, 25)
        Me.txtCustomerNum.TabIndex = 16
        Me.txtCustomerNum.ValidatingType = GetType(Integer)
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(119, 55)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(253, 25)
        Me.txtCustomerName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Customer Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer ID No. :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.cboRentPrice)
        Me.GroupBox2.Controls.Add(Me.txtBookID)
        Me.GroupBox2.Controls.Add(Me.txtPubYear)
        Me.GroupBox2.Controls.Add(Me.btnUpdateEntry)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.btnClearFields)
        Me.GroupBox2.Controls.Add(Me.btnIssueBook)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtAuthor)
        Me.GroupBox2.Controls.Add(Me.txtBookTitle)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 272)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Information"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(19, 183)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 17)
        Me.Label30.TabIndex = 17
        Me.Label30.Text = "Rent Price :"
        '
        'cboRentPrice
        '
        Me.cboRentPrice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboRentPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRentPrice.FormattingEnabled = True
        Me.cboRentPrice.ItemHeight = 17
        Me.cboRentPrice.Location = New System.Drawing.Point(121, 178)
        Me.cboRentPrice.Name = "cboRentPrice"
        Me.cboRentPrice.Size = New System.Drawing.Size(196, 25)
        Me.cboRentPrice.TabIndex = 16
        '
        'txtBookID
        '
        Me.txtBookID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtBookID.Location = New System.Drawing.Point(121, 21)
        Me.txtBookID.Mask = "a00"
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(81, 25)
        Me.txtBookID.TabIndex = 15
        Me.txtBookID.ValidatingType = GetType(Integer)
        '
        'txtPubYear
        '
        Me.txtPubYear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPubYear.Location = New System.Drawing.Point(121, 115)
        Me.txtPubYear.Mask = "0000"
        Me.txtPubYear.Name = "txtPubYear"
        Me.txtPubYear.Size = New System.Drawing.Size(100, 25)
        Me.txtPubYear.TabIndex = 15
        Me.txtPubYear.ValidatingType = GetType(Integer)
        '
        'btnUpdateEntry
        '
        Me.btnUpdateEntry.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdateEntry.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateEntry.FlatAppearance.BorderSize = 0
        Me.btnUpdateEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnUpdateEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateEntry.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateEntry.Location = New System.Drawing.Point(123, 234)
        Me.btnUpdateEntry.Name = "btnUpdateEntry"
        Me.btnUpdateEntry.Size = New System.Drawing.Size(115, 30)
        Me.btnUpdateEntry.TabIndex = 14
        Me.btnUpdateEntry.Text = "Update Entry"
        Me.btnUpdateEntry.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(121, 146)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 25)
        Me.TextBox9.TabIndex = 12
        Me.TextBox9.Text = "  5"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 148)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 17)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Stock No :"
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.DimGray
        Me.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearFields.FlatAppearance.BorderSize = 0
        Me.btnClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFields.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClearFields.Location = New System.Drawing.Point(244, 234)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(94, 30)
        Me.btnClearFields.TabIndex = 11
        Me.btnClearFields.Text = "Clear Entry"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'btnIssueBook
        '
        Me.btnIssueBook.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIssueBook.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIssueBook.FlatAppearance.BorderSize = 0
        Me.btnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssueBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIssueBook.Location = New System.Drawing.Point(20, 234)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(94, 30)
        Me.btnIssueBook.TabIndex = 8
        Me.btnIssueBook.Text = "Issue Book"
        Me.btnIssueBook.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 118)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 17)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Year :"
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(121, 84)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(240, 25)
        Me.txtAuthor.TabIndex = 2
        '
        'txtBookTitle
        '
        Me.txtBookTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtBookTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(121, 54)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(240, 25)
        Me.txtBookTitle.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Author(s) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Book Title :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 17)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "ID No. :"
        '
        'tcTabNavContainer
        '
        Me.tcTabNavContainer.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcTabNavContainer.Controls.Add(Me.tpRent)
        Me.tcTabNavContainer.Controls.Add(Me.tpReturn)
        Me.tcTabNavContainer.Controls.Add(Me.tpAddBook)
        Me.tcTabNavContainer.Controls.Add(Me.tpCheckOut)
        Me.tcTabNavContainer.Dock = System.Windows.Forms.DockStyle.Right
        Me.tcTabNavContainer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tcTabNavContainer.ItemSize = New System.Drawing.Size(0, 20)
        Me.tcTabNavContainer.Location = New System.Drawing.Point(160, 24)
        Me.tcTabNavContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.tcTabNavContainer.Multiline = True
        Me.tcTabNavContainer.Name = "tcTabNavContainer"
        Me.tcTabNavContainer.Padding = New System.Drawing.Point(0, 0)
        Me.tcTabNavContainer.SelectedIndex = 0
        Me.tcTabNavContainer.Size = New System.Drawing.Size(1004, 630)
        Me.tcTabNavContainer.TabIndex = 0
        '
        'tpCheckOut
        '
        Me.tpCheckOut.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tpCheckOut.Controls.Add(Me.GroupBox11)
        Me.tpCheckOut.Controls.Add(Me.gbDenominations)
        Me.tpCheckOut.Controls.Add(Me.GroupBox10)
        Me.tpCheckOut.Location = New System.Drawing.Point(4, 24)
        Me.tpCheckOut.Name = "tpCheckOut"
        Me.tpCheckOut.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCheckOut.Size = New System.Drawing.Size(996, 602)
        Me.tpCheckOut.TabIndex = 3
        Me.tpCheckOut.Text = "Check Out"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rtxtReceipt)
        Me.GroupBox11.Location = New System.Drawing.Point(488, 54)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(268, 474)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        '
        'rtxtReceipt
        '
        Me.rtxtReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.rtxtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtReceipt.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtReceipt.Location = New System.Drawing.Point(3, 21)
        Me.rtxtReceipt.Name = "rtxtReceipt"
        Me.rtxtReceipt.Size = New System.Drawing.Size(262, 450)
        Me.rtxtReceipt.TabIndex = 14
        Me.rtxtReceipt.Text = ""
        '
        'gbDenominations
        '
        Me.gbDenominations.Controls.Add(Me.btn50RM)
        Me.gbDenominations.Controls.Add(Me.btn10Sen)
        Me.gbDenominations.Controls.Add(Me.btn20RM)
        Me.gbDenominations.Controls.Add(Me.btn20Sen)
        Me.gbDenominations.Controls.Add(Me.btn10RM)
        Me.gbDenominations.Controls.Add(Me.btn50Sen)
        Me.gbDenominations.Controls.Add(Me.btn5RM)
        Me.gbDenominations.Controls.Add(Me.btn1RM)
        Me.gbDenominations.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbDenominations.Location = New System.Drawing.Point(244, 54)
        Me.gbDenominations.Name = "gbDenominations"
        Me.gbDenominations.Size = New System.Drawing.Size(238, 137)
        Me.gbDenominations.TabIndex = 13
        Me.gbDenominations.TabStop = False
        Me.gbDenominations.Text = "Denominations (RM)"
        '
        'btn50RM
        '
        Me.btn50RM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn50RM.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn50RM.FlatAppearance.BorderSize = 0
        Me.btn50RM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn50RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn50RM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn50RM.Location = New System.Drawing.Point(167, 75)
        Me.btn50RM.Name = "btn50RM"
        Me.btn50RM.Size = New System.Drawing.Size(46, 45)
        Me.btn50RM.TabIndex = 29
        Me.btn50RM.Text = "50.00"
        Me.btn50RM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50RM.UseVisualStyleBackColor = False
        '
        'btn10Sen
        '
        Me.btn10Sen.BackColor = System.Drawing.Color.Goldenrod
        Me.btn10Sen.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn10Sen.FlatAppearance.BorderSize = 0
        Me.btn10Sen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn10Sen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10Sen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn10Sen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn10Sen.Location = New System.Drawing.Point(14, 24)
        Me.btn10Sen.Name = "btn10Sen"
        Me.btn10Sen.Size = New System.Drawing.Size(46, 45)
        Me.btn10Sen.TabIndex = 22
        Me.btn10Sen.Text = "0.10"
        Me.btn10Sen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10Sen.UseVisualStyleBackColor = False
        '
        'btn20RM
        '
        Me.btn20RM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn20RM.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn20RM.FlatAppearance.BorderSize = 0
        Me.btn20RM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn20RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn20RM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn20RM.Location = New System.Drawing.Point(116, 75)
        Me.btn20RM.Name = "btn20RM"
        Me.btn20RM.Size = New System.Drawing.Size(46, 45)
        Me.btn20RM.TabIndex = 28
        Me.btn20RM.Text = "20.00"
        Me.btn20RM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20RM.UseVisualStyleBackColor = False
        '
        'btn20Sen
        '
        Me.btn20Sen.BackColor = System.Drawing.Color.Goldenrod
        Me.btn20Sen.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn20Sen.FlatAppearance.BorderSize = 0
        Me.btn20Sen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn20Sen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20Sen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn20Sen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn20Sen.Location = New System.Drawing.Point(65, 24)
        Me.btn20Sen.Name = "btn20Sen"
        Me.btn20Sen.Size = New System.Drawing.Size(46, 45)
        Me.btn20Sen.TabIndex = 23
        Me.btn20Sen.Text = "0.20"
        Me.btn20Sen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn20Sen.UseVisualStyleBackColor = False
        '
        'btn10RM
        '
        Me.btn10RM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn10RM.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn10RM.FlatAppearance.BorderSize = 0
        Me.btn10RM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn10RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn10RM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn10RM.Location = New System.Drawing.Point(65, 75)
        Me.btn10RM.Name = "btn10RM"
        Me.btn10RM.Size = New System.Drawing.Size(46, 45)
        Me.btn10RM.TabIndex = 27
        Me.btn10RM.Text = "10.00"
        Me.btn10RM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10RM.UseVisualStyleBackColor = False
        '
        'btn50Sen
        '
        Me.btn50Sen.BackColor = System.Drawing.Color.Goldenrod
        Me.btn50Sen.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn50Sen.FlatAppearance.BorderSize = 0
        Me.btn50Sen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn50Sen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50Sen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn50Sen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn50Sen.Location = New System.Drawing.Point(116, 24)
        Me.btn50Sen.Name = "btn50Sen"
        Me.btn50Sen.Size = New System.Drawing.Size(46, 45)
        Me.btn50Sen.TabIndex = 24
        Me.btn50Sen.Text = "0.50"
        Me.btn50Sen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn50Sen.UseVisualStyleBackColor = False
        '
        'btn5RM
        '
        Me.btn5RM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn5RM.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn5RM.FlatAppearance.BorderSize = 0
        Me.btn5RM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn5RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn5RM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn5RM.Location = New System.Drawing.Point(14, 75)
        Me.btn5RM.Name = "btn5RM"
        Me.btn5RM.Size = New System.Drawing.Size(46, 45)
        Me.btn5RM.TabIndex = 26
        Me.btn5RM.Text = "5.00"
        Me.btn5RM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn5RM.UseVisualStyleBackColor = False
        '
        'btn1RM
        '
        Me.btn1RM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn1RM.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn1RM.FlatAppearance.BorderSize = 0
        Me.btn1RM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btn1RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn1RM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn1RM.Location = New System.Drawing.Point(167, 24)
        Me.btn1RM.Name = "btn1RM"
        Me.btn1RM.Size = New System.Drawing.Size(46, 45)
        Me.btn1RM.TabIndex = 25
        Me.btn1RM.Text = "1.00"
        Me.btn1RM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1RM.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox10.Controls.Add(Me.btnClearPaid)
        Me.GroupBox10.Controls.Add(Me.lblChangeDue)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.lblCheckOutPaid)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.lblCheckOutItems)
        Me.GroupBox10.Controls.Add(Me.btnEndTransaction)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.lblCheckOutBill)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox10.Location = New System.Drawing.Point(244, 197)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(238, 335)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Check Out"
        '
        'btnClearPaid
        '
        Me.btnClearPaid.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClearPaid.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearPaid.FlatAppearance.BorderSize = 0
        Me.btnClearPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClearPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPaid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClearPaid.Location = New System.Drawing.Point(14, 274)
        Me.btnClearPaid.Name = "btnClearPaid"
        Me.btnClearPaid.Size = New System.Drawing.Size(94, 30)
        Me.btnClearPaid.TabIndex = 24
        Me.btnClearPaid.Text = "Clear"
        Me.btnClearPaid.UseVisualStyleBackColor = False
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.BackColor = System.Drawing.Color.Transparent
        Me.lblChangeDue.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDue.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblChangeDue.Location = New System.Drawing.Point(126, 172)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(107, 30)
        Me.lblChangeDue.TabIndex = 23
        Me.lblChangeDue.Text = "RM 00.00"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(14, 182)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(86, 17)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Change Due :"
        '
        'lblCheckOutPaid
        '
        Me.lblCheckOutPaid.AutoSize = True
        Me.lblCheckOutPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckOutPaid.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutPaid.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblCheckOutPaid.Location = New System.Drawing.Point(126, 133)
        Me.lblCheckOutPaid.Name = "lblCheckOutPaid"
        Me.lblCheckOutPaid.Size = New System.Drawing.Size(106, 30)
        Me.lblCheckOutPaid.TabIndex = 21
        Me.lblCheckOutPaid.Text = "RM 00.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(14, 143)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 17)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Total Paid :"
        '
        'lblCheckOutItems
        '
        Me.lblCheckOutItems.AutoSize = True
        Me.lblCheckOutItems.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckOutItems.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutItems.Location = New System.Drawing.Point(204, 57)
        Me.lblCheckOutItems.Name = "lblCheckOutItems"
        Me.lblCheckOutItems.Size = New System.Drawing.Size(25, 30)
        Me.lblCheckOutItems.TabIndex = 19
        Me.lblCheckOutItems.Text = "0"
        '
        'btnEndTransaction
        '
        Me.btnEndTransaction.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEndTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEndTransaction.FlatAppearance.BorderSize = 0
        Me.btnEndTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnEndTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEndTransaction.Location = New System.Drawing.Point(114, 274)
        Me.btnEndTransaction.Name = "btnEndTransaction"
        Me.btnEndTransaction.Size = New System.Drawing.Size(118, 30)
        Me.btnEndTransaction.TabIndex = 18
        Me.btnEndTransaction.Text = "End Transaction"
        Me.btnEndTransaction.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(14, 67)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 17)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "No. of Items :"
        '
        'lblCheckOutBill
        '
        Me.lblCheckOutBill.AutoSize = True
        Me.lblCheckOutBill.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckOutBill.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutBill.ForeColor = System.Drawing.Color.Orange
        Me.lblCheckOutBill.Location = New System.Drawing.Point(126, 94)
        Me.lblCheckOutBill.Name = "lblCheckOutBill"
        Me.lblCheckOutBill.Size = New System.Drawing.Size(103, 30)
        Me.lblCheckOutBill.TabIndex = 9
        Me.lblCheckOutBill.Text = "RM 10.50"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(14, 104)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 17)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Total Due :"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(353, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DimGray
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(1010, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(143, 24)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmMainAppWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1164, 654)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tcTabNavContainer)
        Me.Controls.Add(Me.msTopMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.msTopMainMenu
        Me.MaximizeBox = False
        Me.Name = "frmMainAppWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NavigationPaneTest"
        Me.Panel1.ResumeLayout(False)
        Me.msTopMainMenu.ResumeLayout(False)
        Me.msTopMainMenu.PerformLayout()
        Me.tpAddBook.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReturn.ResumeLayout(False)
        Me.gbFine.ResumeLayout(False)
        Me.gbFine.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgvBookRentList_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpRent.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvBookRentList_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tcTabNavContainer.ResumeLayout(False)
        Me.tpCheckOut.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.gbDenominations.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRent As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnPlaceHolder1 As Button
    Friend WithEvents msTopMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tpAddBook As TabPage
    Friend WithEvents tpReturn As TabPage
    Friend WithEvents tpRent As TabPage
    Friend WithEvents tcTabNavContainer As TabControl
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpRentDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnIssueBook As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpReturnDueDate As DateTimePicker
    Friend WithEvents dtpReturnRentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbBookCondition As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtReturnCustomerName As TextBox
    Friend WithEvents txtReturnCustomerNum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents btnLogout As Button
    Friend WithEvents BookManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgvBookRentList_A As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSelectImage As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPublicationYear As TextBox
    Friend WithEvents txtMarketPrice As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnClearFields As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents btnUpdateEntry As Button
    Friend WithEvents txtBookID As MaskedTextBox
    Friend WithEvents txtPubYear As MaskedTextBox
    Friend WithEvents txtCustomerNum As MaskedTextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents txtReturnBookTitle As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents cboRentPrice As ComboBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblNumItems As Label
    Friend WithEvents lstbDebug As ListBox
    Friend WithEvents tpCheckOut As TabPage
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lblCheckOutItems As Label
    Friend WithEvents btnEndTransaction As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents lblCheckOutBill As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents rtxtReceipt As RichTextBox
    Friend WithEvents gbDenominations As GroupBox
    Friend WithEvents btn50RM As Button
    Friend WithEvents btn10Sen As Button
    Friend WithEvents btn20RM As Button
    Friend WithEvents btn20Sen As Button
    Friend WithEvents btn10RM As Button
    Friend WithEvents btn50Sen As Button
    Friend WithEvents btn5RM As Button
    Friend WithEvents btn1RM As Button
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblCheckOutPaid As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnClearPaid As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstCartList As ListBox
    Friend WithEvents gbFine As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSelectedFine As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txtReturnBookID As MaskedTextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dgvBookRentList_B As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents IDNumber As DataGridViewTextBoxColumn
    Friend WithEvents BookTitle As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthor As DataGridViewTextBoxColumn
    Friend WithEvents BookYear As DataGridViewTextBoxColumn
    Friend WithEvents StudentName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents RentPrice As DataGridViewTextBoxColumn
    Friend WithEvents RentDate As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents lblDaysOverdue As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotalFine As Label
    Friend WithEvents Label28 As Label
End Class
