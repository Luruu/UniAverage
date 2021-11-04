Public Class Form1
    Public student As Student
    Sub UpdateValues()
        LMaxCFU.Text = student.MAX_CFU

        Lpuntcfu.Text = SumCFU(student.PassedExams) + SumCFU(student.PassedExamsNoVote)
        LExamPas.Text = student.GetNPassedExam + student.GetNPassedExamNoVote
        LExamRem.Text = student.GetNRemainingExams()

        If SumCFU(student.PassedExams) = 0 Then 'cannot calculate averages with 0 exams
            UpdateExamLists()
            ResetChart(ChartVote)
            SetChart(ChartVote, student.PassedExams)
            Exit Sub
        End If
        Lvotearit.Text = Arithmetic(student.PassedExams)
        LvotePon.Text = Weighted(student.PassedExams)
        Lvotepart.Text = GradStartVote(student.PassedExams)
        LProgress.Text = GetProgress(student.PassedExams, student.PassedExamsNoVote, student.MAX_CFU) & "%"

        If SumCFU(student.RemainingExams) > 0 Then
            LnoEstimates.Visible = False
            Lminpond.Text = EstimatedWeighted(student.PassedExams, student.RemainingExams, Exam.MINVOTE)
            Lmaspond.Text = EstimatedWeighted(student.PassedExams, student.RemainingExams, Exam.MAXVOTE)
            Lminpar.Text = EstimatedGradStartVote(student.PassedExams, student.RemainingExams, Exam.MINVOTE)
            Lmaspar.Text = EstimatedGradStartVote(student.PassedExams, student.RemainingExams, Exam.MAXVOTE)
        Else
            LnoEstimates.Visible = True
            Lminpond.Text = LvotePon.Text
            Lmaspond.Text = LvotePon.Text
            Lminpar.Text = Lvotepart.Text
            Lmaspar.Text = Lvotepart.Text
        End If

        UpdateExamLists()
        ResetChart(ChartVote)
        SetChart(ChartVote, student.PassedExams)
    End Sub
    Sub UpdateExamLists()
        ListaEsami.Items.Clear()
        For Each exam In student.PassedExams
            ListaEsami.Items.Add(exam.Name & "   cfu:" & exam.CFU & "   " & exam.Vote & " - " & exam.DateExam)
        Next
        For Each exam In student.PassedExamsNoVote
            ListaEsami.Items.Add(exam.Name & "   cfu:" & exam.CFU & "   " & exam.DateExam)
        Next
        ListaEsamiRimanenti.Items.Clear()
        For Each exam In student.RemainingExams
            ListaEsamiRimanenti.Items.Add(exam.Name & "   cfu:" & exam.CFU)
        Next
    End Sub
    Sub InitializeForm()
        LName.Text = student.Name & " " & student.Surname
        Exam.MAXVOTE = student.Lode
        UpdateValues()
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If JSONFileExists() Then
            student = GetStudent(ReadJSON_file())
            If student Is Nothing Then
                Close()
                Exit Sub 'normally the program is closed after the operations are finished.
            End If
        Else
            student = New Student()
            While (student.Name = "")
                student.Name = InputBox("Please, insert your name")
            End While
            While (student.Surname = "")
                student.Surname = InputBox("Please, insert your surname")
            End While
            Dim input As Short
            While (input <= 0)
                input = Val(InputBox("Please, insert max CFU of your degree course"))
            End While
            student.MAX_CFU = input
            input = 0
            While (input < 30) 'Input < 30 is not a lode.
                input = Val(InputBox("Which grade does the 30L correspond to? (Remember in the future to specify the 30L with the value you are about to enter)"))
            End While
            student.Lode = input
            WriteJSON_file(student)
        End If
        InitializeForm()
    End Sub

    Private Sub ListaEsami_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEsami.SelectedIndexChanged
        If ListaEsamiRimanenti.SelectedIndex > -1 And ListaEsami.SelectedIndex > -1 Then
            ListaEsamiRimanenti.SelectedIndex = -1
        End If

        BMove.Enabled = sender.selectedIndex > -1
        BRem.Enabled = sender.selectedIndex > -1
    End Sub

    Private Sub ListaEsamiRimanenti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEsamiRimanenti.SelectedIndexChanged
        If ListaEsami.SelectedIndex > -1 And ListaEsamiRimanenti.SelectedIndex > -1 Then
            ListaEsami.SelectedIndex = -1
        End If

        BMove.Enabled = sender.selectedIndex > -1
        BRem.Enabled = sender.selectedIndex > -1
    End Sub
    Function GetExamNameByList(ByRef List As ListBox, index As Integer)
        Return List.Items.Item(index).ToString.Substring(0, List.Items.Item(index).ToString.IndexOf("cfu") - 3)
    End Function

    Function RemoveExam(Optional ByRef CloneRemovedExam As Exam = Nothing, Optional ByRef nlist As UShort = 0) 'Remove Selected Exam in one of two lists
        Dim nameExam As String
        If ListaEsami.SelectedIndex > -1 Then
            nameExam = GetExamNameByList(ListaEsami, ListaEsami.SelectedIndex)
            ListaEsami.Items.RemoveAt(ListaEsami.SelectedIndex)
            nlist = 0
        ElseIf ListaEsamiRimanenti.SelectedIndex > -1 Then
            nameExam = GetExamNameByList(ListaEsamiRimanenti, ListaEsamiRimanenti.SelectedIndex)
            ListaEsamiRimanenti.Items.RemoveAt(ListaEsamiRimanenti.SelectedIndex)
            nlist = 1
        Else
            MsgBox("Error: Index not selected") 'Impossible case (maybe) because BRem is not enabled.
            Return False
        End If
        CloneRemovedExam = student.GetExamByName(nameExam)
        Dim removedInClass = student.RemoveExam(nameExam)
        Return removedInClass
    End Function
    Private Sub BRem_Click(sender As Object, e As EventArgs) Handles BRem.Click
        If RemoveExam() Then
            SetJSON(student)
            UpdateValues()
        End If
    End Sub
    Private Sub BMove_Click(sender As Object, e As EventArgs) Handles BMove.Click
        Dim used_list As UShort
        Dim examToMove As Exam = Nothing
        If RemoveExam(examToMove, used_list) Then
            If used_list = 0 Then 'Removed by Left List (Passed Exams)
                student.AddRemExam(examToMove.Name, examToMove.CFU)
            ElseIf used_list = 1 Then 'Removed by Right List (Remaining Exams)
                Dim vote As Integer = -1
                While (vote < 18 And vote <> 0)
                    vote = Val(InputBox("To move exam x to the list of past exams, it is necessary to specify the grade and the date of the exam." & vbCrLf & vbCrLf & "Please enter your vote (insert 0 for no voted exam)", "Insert new exam"))
                End While
                Dim strdateExam As String = ""
                While strdateExam = "" Or Not IsDate(strdateExam)
                    strdateExam = InputBox("Insert date exam (es: 04/11/2020)", "Insert new exam")
                End While
                Dim dateExam As Date = DateValue(strdateExam).Date
                student.AddPasExam(examToMove.Name, examToMove.CFU, vote, dateExam)
            Else 'Impossible case: there are just two list box
                MsgBox("Error: Generic error. Code: -10")
            End If
            SetJSON(student)
            UpdateValues()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetToolTip(ChartVote, "Exam Votes chart", "This graph shows the exam marks" & vbCrLf & "in comparison with their respective credits.", 1)
        SetToolTip(BEstimate, "Make an estimate!", "You can estimate your future situation with this tool." & vbCrLf & "Try it!", 1)
    End Sub

    Sub SetToolTip(oggetto As Control, titolo As String, testo As String, tipo As Integer)
        Dim ToolTip As New ToolTip With {
            .ToolTipTitle = titolo,
            .UseFading = True,
            .UseAnimation = True,
            .IsBalloon = False,
            .ShowAlways = True,
            .AutoPopDelay = 5000,
            .InitialDelay = 150,
            .ReshowDelay = 500,
            .ToolTipIcon = tipo
        }
        ToolTip.SetToolTip(oggetto, testo)
    End Sub
    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click
        EstimateForm.Hide()
        NewExamForm.Activate()
        NewExamForm.Show()
    End Sub
    Private Sub BEstimate_Click(sender As Object, e As EventArgs) Handles BEstimate.Click
        NewExamForm.Hide()
        EstimateForm.Activate()
        EstimateForm.Show()
    End Sub
End Class
