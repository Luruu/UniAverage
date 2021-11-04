Public Class EstimateForm
    Private Sub EstimateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "make your estimate" & " - " & Form1.Text
        Form1.SetToolTip(RadioClassic, RadioClassic.Text, "This type of estimation allows you to verify what results" & vbCrLf & "you may have by obtaining the same grade in all the remaining exams.", 1)
        Form1.SetToolTip(RadioAdvanced, RadioAdvanced.Text, "This type of estimation allows you to check what results" & vbCrLf & "you can have by choosing each grade to be given in the remaining exams.", 1)
    End Sub

    Private Sub BStart_Click(sender As Object, e As EventArgs) Handles BStart.Click
        If SumCFU(Form1.student.RemainingExams) = 0 Then
            MsgBox("You can't make an estimate if you don't have any remaining exams.")
            Exit Sub
        End If
        If RadioClassic.Checked Then
            classicEstimate()
        Else
            AdvancedEstimated()
        End If
    End Sub

    Sub ClassicEstimate()
        Dim chosenVote = InputBox("Enter the grade to be given to all the remaining exams for the simulation.", "Insert Vote")
        If chosenVote = "" Then
            Exit Sub
        ElseIf Not IsNumeric(chosenVote) Then
            MsgBox("Please, insert a number value.", , Text)
            Exit Sub
        ElseIf chosenVote < Exam.MINVOTE Or chosenVote > Form1.student.Lode Then
            MsgBox("Please, insert a vote from " & Exam.MINVOTE & " to " & Form1.student.Lode, , Text)
            Exit Sub
        End If
        chosenVote = Convert.ToInt32(chosenVote)
        Dim AllExams As New List(Of Exam)
        AllExams.AddRange(Form1.student.PassedExams)
        For Each exam In Form1.student.RemainingExams
            AllExams.Add(New Exam(exam.Name, exam.CFU, chosenVote, Date.Now.Date))
        Next
        CalculateEstimateAverages(AllExams)
    End Sub
    Sub AdvancedEstimated()
        Dim AllExams As New List(Of Exam)
        AllExams.AddRange(Form1.student.PassedExams)
        For Each exam In Form1.student.RemainingExams
            Dim chosenVote = InputBox("Enter the grade to be given to all the remaining exams for the simulation." & vbCrLf & "Insert Vote for exam " & exam.Name & "(cfu:" & exam.CFU & ")" & vbCrLf & "N.B: Insert 0 for no voted exam", "Insert Exam Vote")
            If chosenVote = "" Then
                Exit Sub
            ElseIf Not IsNumeric(chosenVote) Then
                MsgBox("Please, insert a number value.", , Text)
                Exit Sub
            ElseIf (chosenVote < Exam.MINVOTE And chosenVote <> 0) Or chosenVote > Form1.student.Lode Then
                MsgBox("Please, insert a vote from " & Exam.MINVOTE & " to " & Form1.student.Lode & " (or insert 0 for Not voted exam)", , Text)
                Exit Sub
            End If
            chosenVote = Convert.ToInt32(chosenVote)
            If (chosenVote <> 0) Then ' = 0 is no voted exam. 
                AllExams.Add(New Exam(exam.Name, exam.CFU, chosenVote, Date.Now.Date))
            End If
        Next
        CalculateEstimateAverages(AllExams)
    End Sub
    Sub CalculateEstimateAverages(AllExams As List(Of Exam))
        MsgBox("Calculated estimate. Results:" & vbCrLf &
            vbCrLf & "Arithmetic Average: " & Arithmetic(AllExams) &
               vbCrLf & "Weighted Average: " & Weighted(AllExams) &
                vbCrLf & "Graduation Vote Start: " & GradStartVote(AllExams))
    End Sub

End Class