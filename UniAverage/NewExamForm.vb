Public Class NewExamForm
    Function FieldsAreCorrect()
        If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) And (TextBox1.Text.Count() <> 0) Then
            If TextBox2.Text >= Exam.MINCFU And TextBox2.Text <= Exam.MAXCFU Then
                If (TextBox3.Text >= Exam.MINVOTE Or TextBox3.Text = Exam.NOVOTE) And TextBox3.Text <= Exam.MAXVOTE Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click
        If FieldsAreCorrect() Then
            Dim added As Boolean
            If CheckPassedExam.Checked Then
                added = Form1.student.AddPasExam(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateExamPicker.Value.Date)
            Else
                added = Form1.student.AddRemExam(TextBox1.Text, TextBox2.Text)
            End If
            If added Then
                SetJSON(Form1.student)
                Form1.UpdateValues()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Text = "0"
                Hide()
            End If
        Else
            MsgBox("Error: incorrect values. N.B: The 30L should be written as " & Exam.MAXVOTE, , Form1.Text)
        End If
    End Sub

    Private Sub NewExamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Add a new exam" & " - " & Form1.Text
        DateExamPicker.MaxDate = Date.Now
        Form1.SetToolTip(CheckPassedExam, "Passed Exam", "Check this checkbox if you passed this exam." & vbCrLf & "It will be included in the list of past exams (the list on the left of this program), otherwise in the list of remaining exams (the list on the right)", 1)
    End Sub

    Private Sub CheckPassedExam_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassedExam.CheckedChanged
        Label3.Visible = sender.checked
        Label4.Visible = sender.checked
        TextBox3.Visible = sender.checked
        DateExamPicker.Visible = sender.checked
    End Sub
End Class