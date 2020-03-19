Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackColor = Color.Coral
        RichTextBox1.BackColor = Color.Coral
        TransparencyKey = BackColor
        RichTextBox1.EnableAutoDragDrop = True






    End Sub

    Private Sub ClearScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearScreenToolStripMenuItem.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            SaveFileDialog1.ShowDialog()
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            MsgBox("Saved Successfully")
        Catch ex As Exception : End Try


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText)
            End If
        Catch ex As Exception : End Try




    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim B = InputBox("Enter String To Find")
        RichTextBox1.Find(B)
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Dim C = InputBox("Enter String To Find")
        Dim D = InputBox("Enter String To Replace")
        RichTextBox1.Find(C)
        RichTextBox1.SelectedText = D
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Developed By Aditya Dand" & vbNewLine & vbNewLine &
                         "© Aditya Dand 2020")
    End Sub

    Private Sub TxtColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TxtColorToolStripMenuItem.Click

        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then

            RichTextBox1.ForeColor = ColorDialog1.Color

        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Dim F As Form
        F = New Form1
        F.Show()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub



    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TransparentMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransparentMenuToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.Transparent

    End Sub

    Private Sub FormWithColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormWithColorToolStripMenuItem.Click
        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then

            RichTextBox1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub MenuWithColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuWithColorToolStripMenuItem.Click
        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then

            MenuStrip1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub TransparentFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransparentFormToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Coral
    End Sub

    Private Sub SpeakTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeakTextToolStripMenuItem.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(RichTextBox1.Text)
    End Sub

    Private Sub SpeakSelectedTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeakSelectedTextToolStripMenuItem.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(RichTextBox1.SelectedText)
    End Sub

    Private Sub TransparentTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransparentTitleToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub HideMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideMenuToolStripMenuItem.Click
        MenuStrip1.Hide()
    End Sub

    Private Sub TransparentTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransparentTextToolStripMenuItem.Click
        RichTextBox1.ForeColor = Color.Coral
    End Sub

    Private Sub FullTransparentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullTransparentToolStripMenuItem.Click

        Me.FormBorderStyle = FormBorderStyle.None
        RichTextBox1.ForeColor = Color.Coral
        MenuStrip1.Hide()

    End Sub

    Private Sub RevertBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevertBackToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        RichTextBox1.ForeColor = Color.White
        MenuStrip1.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        RichTextBox1.Text = DateString & vbNewLine & TimeOfDay
    End Sub
End Class
