<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigationPaneTest
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPlaceHolder1 = New System.Windows.Forms.Button()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.msTopMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tcTabNavContainer = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        Me.msTopMainMenu.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.tcTabNavContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.btnPlaceHolder1)
        Me.Panel1.Controls.Add(Me.btnRent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 606)
        Me.Panel1.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturn.Location = New System.Drawing.Point(-1, 90)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(151, 43)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder1
        '
        Me.btnPlaceHolder1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPlaceHolder1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPlaceHolder1.FlatAppearance.BorderSize = 0
        Me.btnPlaceHolder1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlaceHolder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceHolder1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceHolder1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlaceHolder1.Location = New System.Drawing.Point(-1, 134)
        Me.btnPlaceHolder1.Name = "btnPlaceHolder1"
        Me.btnPlaceHolder1.Size = New System.Drawing.Size(151, 43)
        Me.btnPlaceHolder1.TabIndex = 1
        Me.btnPlaceHolder1.Text = "Placeholder1"
        Me.btnPlaceHolder1.UseVisualStyleBackColor = False
        '
        'btnRent
        '
        Me.btnRent.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnRent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRent.Location = New System.Drawing.Point(-1, 46)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(151, 43)
        Me.btnRent.TabIndex = 0
        Me.btnRent.Text = "Rent"
        Me.btnRent.UseVisualStyleBackColor = False
        '
        'msTopMainMenu
        '
        Me.msTopMainMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.msTopMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.msTopMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msTopMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msTopMainMenu.Name = "msTopMainMenu"
        Me.msTopMainMenu.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.msTopMainMenu.Size = New System.Drawing.Size(1023, 24)
        Me.msTopMainMenu.TabIndex = 2
        Me.msTopMainMenu.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "Log &Out"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(869, 578)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "It works!"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(869, 578)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(869, 578)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'tcTabNavContainer
        '
        Me.tcTabNavContainer.Controls.Add(Me.TabPage1)
        Me.tcTabNavContainer.Controls.Add(Me.TabPage2)
        Me.tcTabNavContainer.Controls.Add(Me.TabPage3)
        Me.tcTabNavContainer.Dock = System.Windows.Forms.DockStyle.Right
        Me.tcTabNavContainer.ItemSize = New System.Drawing.Size(60, 20)
        Me.tcTabNavContainer.Location = New System.Drawing.Point(146, 24)
        Me.tcTabNavContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.tcTabNavContainer.Name = "tcTabNavContainer"
        Me.tcTabNavContainer.Padding = New System.Drawing.Point(0, 0)
        Me.tcTabNavContainer.SelectedIndex = 0
        Me.tcTabNavContainer.Size = New System.Drawing.Size(877, 606)
        Me.tcTabNavContainer.TabIndex = 0
        '
        'NavigationPaneTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tcTabNavContainer)
        Me.Controls.Add(Me.msTopMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msTopMainMenu
        Me.MaximizeBox = False
        Me.Name = "NavigationPaneTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NavigationPaneTest"
        Me.Panel1.ResumeLayout(False)
        Me.msTopMainMenu.ResumeLayout(False)
        Me.msTopMainMenu.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.tcTabNavContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRent As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnPlaceHolder1 As Button
    Friend WithEvents msTopMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tcTabNavContainer As TabControl
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
