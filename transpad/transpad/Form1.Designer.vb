<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormWithColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuWithColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullTransparentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevertBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdditionalFeatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeakTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeakSelectedTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(600, 342)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SpecialToolStripMenuItem, Me.AdditionalFeatureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ClearScreenToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ClearScreenToolStripMenuItem
        '
        Me.ClearScreenToolStripMenuItem.Name = "ClearScreenToolStripMenuItem"
        Me.ClearScreenToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearScreenToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ClearScreenToolStripMenuItem.Text = "Clear Screen"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem, Me.GoToToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.TimeDateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReplaceToolStripMenuItem.Text = "Replace"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GoToToolStripMenuItem.Text = "Go To"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TimeDateToolStripMenuItem.Text = "Time/Date"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.TxtColorToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'TxtColorToolStripMenuItem
        '
        Me.TxtColorToolStripMenuItem.Name = "TxtColorToolStripMenuItem"
        Me.TxtColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TxtColorToolStripMenuItem.Text = "Txt Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SpecialToolStripMenuItem
        '
        Me.SpecialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransparentMenuToolStripMenuItem, Me.FormWithColorToolStripMenuItem, Me.MenuWithColorToolStripMenuItem, Me.TransparentFormToolStripMenuItem, Me.TransparentTitleToolStripMenuItem, Me.HideMenuToolStripMenuItem, Me.TransparentTextToolStripMenuItem, Me.FullTransparentToolStripMenuItem, Me.RevertBackToolStripMenuItem})
        Me.SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem"
        Me.SpecialToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SpecialToolStripMenuItem.Text = "Special"
        '
        'TransparentMenuToolStripMenuItem
        '
        Me.TransparentMenuToolStripMenuItem.Name = "TransparentMenuToolStripMenuItem"
        Me.TransparentMenuToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.TransparentMenuToolStripMenuItem.Text = "Transparent Menu"
        '
        'FormWithColorToolStripMenuItem
        '
        Me.FormWithColorToolStripMenuItem.Name = "FormWithColorToolStripMenuItem"
        Me.FormWithColorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FormWithColorToolStripMenuItem.Text = "Form With Color"
        '
        'MenuWithColorToolStripMenuItem
        '
        Me.MenuWithColorToolStripMenuItem.Name = "MenuWithColorToolStripMenuItem"
        Me.MenuWithColorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MenuWithColorToolStripMenuItem.Text = "Menu With Color"
        '
        'TransparentFormToolStripMenuItem
        '
        Me.TransparentFormToolStripMenuItem.Name = "TransparentFormToolStripMenuItem"
        Me.TransparentFormToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.TransparentFormToolStripMenuItem.Text = "Transparent Form"
        '
        'TransparentTitleToolStripMenuItem
        '
        Me.TransparentTitleToolStripMenuItem.Name = "TransparentTitleToolStripMenuItem"
        Me.TransparentTitleToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.TransparentTitleToolStripMenuItem.Text = "Transparent Title"
        '
        'HideMenuToolStripMenuItem
        '
        Me.HideMenuToolStripMenuItem.Name = "HideMenuToolStripMenuItem"
        Me.HideMenuToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.HideMenuToolStripMenuItem.Text = "Hide Menu"
        '
        'TransparentTextToolStripMenuItem
        '
        Me.TransparentTextToolStripMenuItem.Name = "TransparentTextToolStripMenuItem"
        Me.TransparentTextToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.TransparentTextToolStripMenuItem.Text = "Transparent Text"
        '
        'FullTransparentToolStripMenuItem
        '
        Me.FullTransparentToolStripMenuItem.Name = "FullTransparentToolStripMenuItem"
        Me.FullTransparentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FullTransparentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FullTransparentToolStripMenuItem.Text = "Full Transparent"
        '
        'RevertBackToolStripMenuItem
        '
        Me.RevertBackToolStripMenuItem.Name = "RevertBackToolStripMenuItem"
        Me.RevertBackToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.RevertBackToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.RevertBackToolStripMenuItem.Text = "Revert Back"
        '
        'AdditionalFeatureToolStripMenuItem
        '
        Me.AdditionalFeatureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeakTextToolStripMenuItem, Me.SpeakSelectedTextToolStripMenuItem})
        Me.AdditionalFeatureToolStripMenuItem.Name = "AdditionalFeatureToolStripMenuItem"
        Me.AdditionalFeatureToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.AdditionalFeatureToolStripMenuItem.Text = "Additional Feature"
        '
        'SpeakTextToolStripMenuItem
        '
        Me.SpeakTextToolStripMenuItem.Name = "SpeakTextToolStripMenuItem"
        Me.SpeakTextToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SpeakTextToolStripMenuItem.Text = "Speak Text"
        '
        'SpeakSelectedTextToolStripMenuItem
        '
        Me.SpeakSelectedTextToolStripMenuItem.Name = "SpeakSelectedTextToolStripMenuItem"
        Me.SpeakSelectedTextToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SpeakSelectedTextToolStripMenuItem.Text = "Speak Selected Text"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "TransPad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SpecialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparentMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormWithColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuWithColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparentFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdditionalFeatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeakTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeakSelectedTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparentTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparentTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullTransparentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevertBackToolStripMenuItem As ToolStripMenuItem
End Class
