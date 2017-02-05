<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rTBCode = New System.Windows.Forms.RichTextBox()
        Me.dGridLexi = New System.Windows.Forms.ListView()
        Me.Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Line = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lexeme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Token = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dGridError = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dGridBoard = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dGridIden = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorText = New System.Windows.Forms.TextBox()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dGridSemantic = New System.Windows.Forms.ListView()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lineNum = New System.Windows.Forms.PictureBox()
        Me.btnAna = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CodeGenerationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rTBCode
        '
        Me.rTBCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTBCode.Location = New System.Drawing.Point(226, 13)
        Me.rTBCode.Name = "rTBCode"
        Me.rTBCode.Size = New System.Drawing.Size(362, 446)
        Me.rTBCode.TabIndex = 2
        Me.rTBCode.Text = ""
        '
        'dGridLexi
        '
        Me.dGridLexi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.dGridLexi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dGridLexi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Number, Me.Line, Me.Lexeme, Me.Token, Me.ColumnHeader19})
        Me.dGridLexi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridLexi.ForeColor = System.Drawing.Color.White
        Me.dGridLexi.GridLines = True
        Me.dGridLexi.Location = New System.Drawing.Point(604, 13)
        Me.dGridLexi.Name = "dGridLexi"
        Me.dGridLexi.Size = New System.Drawing.Size(484, 137)
        Me.dGridLexi.TabIndex = 4
        Me.dGridLexi.UseCompatibleStateImageBehavior = False
        Me.dGridLexi.View = System.Windows.Forms.View.Details
        '
        'Number
        '
        Me.Number.Text = "No."
        Me.Number.Width = 0
        '
        'Line
        '
        Me.Line.Text = "Line"
        Me.Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Line.Width = 62
        '
        'Lexeme
        '
        Me.Lexeme.Text = "Lexeme"
        Me.Lexeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Lexeme.Width = 137
        '
        'Token
        '
        Me.Token.Text = "Token"
        Me.Token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Token.Width = 139
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Attibutes"
        Me.ColumnHeader19.Width = 144
        '
        'dGridError
        '
        Me.dGridError.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.dGridError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dGridError.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1})
        Me.dGridError.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridError.ForeColor = System.Drawing.Color.White
        Me.dGridError.GridLines = True
        Me.dGridError.Location = New System.Drawing.Point(604, 156)
        Me.dGridError.Name = "dGridError"
        Me.dGridError.Size = New System.Drawing.Size(484, 127)
        Me.dGridError.TabIndex = 5
        Me.dGridError.UseCompatibleStateImageBehavior = False
        Me.dGridError.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No."
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Line"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 64
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Error Message"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 423
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 458)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        '
        'dGridBoard
        '
        Me.dGridBoard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dGridBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dGridBoard.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader17})
        Me.dGridBoard.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridBoard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dGridBoard.GridLines = True
        Me.dGridBoard.Location = New System.Drawing.Point(44, 586)
        Me.dGridBoard.Name = "dGridBoard"
        Me.dGridBoard.Size = New System.Drawing.Size(176, 136)
        Me.dGridBoard.TabIndex = 36
        Me.dGridBoard.UseCompatibleStateImageBehavior = False
        Me.dGridBoard.View = System.Windows.Forms.View.Details
        Me.dGridBoard.Visible = False
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "object_name"
        Me.ColumnHeader.Width = 88
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "board_name"
        Me.ColumnHeader17.Width = 84
        '
        'dGridIden
        '
        Me.dGridIden.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dGridIden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dGridIden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18})
        Me.dGridIden.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridIden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dGridIden.GridLines = True
        Me.dGridIden.Location = New System.Drawing.Point(334, 586)
        Me.dGridIden.Name = "dGridIden"
        Me.dGridIden.Size = New System.Drawing.Size(714, 136)
        Me.dGridIden.TabIndex = 35
        Me.dGridIden.UseCompatibleStateImageBehavior = False
        Me.dGridIden.View = System.Windows.Forms.View.Details
        Me.dGridIden.Visible = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID No."
        Me.ColumnHeader7.Width = 42
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 101
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Data Type"
        Me.ColumnHeader9.Width = 61
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Value"
        Me.ColumnHeader10.Width = 102
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Val_Dtype"
        Me.ColumnHeader11.Width = 71
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Type"
        Me.ColumnHeader12.Width = 76
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Used"
        Me.ColumnHeader13.Width = 38
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Size"
        Me.ColumnHeader14.Width = 36
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Parameter"
        Me.ColumnHeader15.Width = 42
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Function"
        Me.ColumnHeader16.Width = 75
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Size2"
        Me.ColumnHeader18.Width = 68
        '
        'ErrorText
        '
        Me.ErrorText.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ErrorText.ForeColor = System.Drawing.Color.White
        Me.ErrorText.Location = New System.Drawing.Point(604, 289)
        Me.ErrorText.Multiline = True
        Me.ErrorText.Name = "ErrorText"
        Me.ErrorText.ReadOnly = True
        Me.ErrorText.Size = New System.Drawing.Size(484, 108)
        Me.ErrorText.TabIndex = 41
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Error no."
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Line"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 64
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Semantic Error"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 423
        '
        'dGridSemantic
        '
        Me.dGridSemantic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.dGridSemantic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dGridSemantic.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.dGridSemantic.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridSemantic.ForeColor = System.Drawing.Color.White
        Me.dGridSemantic.GridLines = True
        Me.dGridSemantic.Location = New System.Drawing.Point(604, 408)
        Me.dGridSemantic.Name = "dGridSemantic"
        Me.dGridSemantic.Size = New System.Drawing.Size(484, 126)
        Me.dGridSemantic.TabIndex = 37
        Me.dGridSemantic.UseCompatibleStateImageBehavior = False
        Me.dGridSemantic.View = System.Windows.Forms.View.Details
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnClr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnClr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.White
        Me.btnClr.Image = Global.Zootopia_Compiler.My.Resources.Resources.analyze
        Me.btnClr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClr.Location = New System.Drawing.Point(367, 463)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(221, 57)
        Me.btnClr.TabIndex = 42
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Zootopia_Compiler.My.Resources.Resources.analyzer
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(58, 170)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(49, 198)
        Me.Panel3.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Zootopia_Compiler.My.Resources.Resources.Zoo_whale
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 139)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lineNum
        '
        Me.lineNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lineNum.Location = New System.Drawing.Point(190, 11)
        Me.lineNum.Name = "lineNum"
        Me.lineNum.Size = New System.Drawing.Size(30, 446)
        Me.lineNum.TabIndex = 8
        Me.lineNum.TabStop = False
        '
        'btnAna
        '
        Me.btnAna.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAna.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAna.ForeColor = System.Drawing.Color.White
        Me.btnAna.Image = Global.Zootopia_Compiler.My.Resources.Resources.analyze
        Me.btnAna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAna.Location = New System.Drawing.Point(1, 463)
        Me.btnAna.Name = "btnAna"
        Me.btnAna.Size = New System.Drawing.Size(360, 57)
        Me.btnAna.TabIndex = 3
        Me.btnAna.Text = "Analyze"
        Me.btnAna.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 540)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1100, 25)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleOutputToolStripMenuItem, Me.CodeGenerationToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'CodeGenerationToolStripMenuItem1
        '
        Me.CodeGenerationToolStripMenuItem1.Checked = True
        Me.CodeGenerationToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CodeGenerationToolStripMenuItem1.Name = "CodeGenerationToolStripMenuItem1"
        Me.CodeGenerationToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.CodeGenerationToolStripMenuItem1.Text = "Code generation"
        '
        'ConsoleOutputToolStripMenuItem
        '
        Me.ConsoleOutputToolStripMenuItem.Name = "ConsoleOutputToolStripMenuItem"
        Me.ConsoleOutputToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ConsoleOutputToolStripMenuItem.Text = "Console output"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 565)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.ErrorText)
        Me.Controls.Add(Me.dGridSemantic)
        Me.Controls.Add(Me.dGridBoard)
        Me.Controls.Add(Me.dGridIden)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lineNum)
        Me.Controls.Add(Me.dGridError)
        Me.Controls.Add(Me.dGridLexi)
        Me.Controls.Add(Me.btnAna)
        Me.Controls.Add(Me.rTBCode)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rTBCode As RichTextBox
    Friend WithEvents btnAna As Button
    Friend WithEvents dGridLexi As ListView
    Friend WithEvents dGridError As ListView
    Friend WithEvents lineNum As PictureBox
    Friend WithEvents Number As ColumnHeader
    Friend WithEvents Line As ColumnHeader
    Friend WithEvents Lexeme As ColumnHeader
    Friend WithEvents Token As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dGridIden As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents dGridBoard As ListView
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ErrorText As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents dGridSemantic As ListView
    Friend WithEvents btnClr As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ConsoleOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodeGenerationToolStripMenuItem1 As ToolStripMenuItem
End Class
