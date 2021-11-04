Public Class Student
    Public Name As String
    Public Surname As String
    Public MAX_CFU As UShort
    Public Lode As UShort

    Public PassedExams As New List(Of Exam)
    Public PassedExamsNoVote As New List(Of Exam)
    Public RemainingExams As New List(Of Exam)

    Public Function GetNPassedExam()
        Return PassedExams.Count()
    End Function

    Public Function GetNRemainingExams()
        Return RemainingExams.Count()
    End Function

    Public Function GetNPassedExamNoVote()
        Return PassedExamsNoVote.Count()
    End Function
    Function GetExamByName(NameExam As String)
        For Each elm In PassedExams
            If elm.Name.Equals(NameExam) Then
                Return elm
            End If
        Next
        For Each elm In PassedExamsNoVote
            If elm.Name.Equals(NameExam) Then
                Return elm
            End If
        Next
        For Each elm In RemainingExams
            If elm.Name.Equals(NameExam) Then
                Return elm
            End If
        Next
        Return Nothing 'Exam does not exists in the Lists
    End Function
    Public Function AddPasExam(Name As String, CFU As String, Vote As String, DateExam As Date) 'Vote = 0 -> Exam no vote
        Dim exam = GetExamByName(Name)
        If exam IsNot Nothing Then
            MsgBox("Error: This exam has already been entered. Code: -2", , Form1.Text)
            Return False
        End If
        If Vote <> 0 Then
            PassedExams.Add(New Exam(Name, CFU, Vote, DateExam.Date))
        Else
            PassedExamsNoVote.Add(New Exam(Name, CFU, Vote, DateExam.Date))
        End If
        Return True
    End Function
    Public Function AddRemExam(Name As String, CFU As String)
        Dim exam = GetExamByName(Name)
        If exam IsNot Nothing Then
            MsgBox("Error: This exam has already been entered. Code: -1", , Form1.Text)
            Return False
        End If
        RemainingExams.Add(New Exam(Name, CFU))
        Return True
    End Function

    Public Function RemoveExam(Name As String)
        For Each elm In PassedExams
            If elm.Name.Equals(Name) Then
                PassedExams.Remove(elm)
                Return True
            End If
        Next
        For Each elm In PassedExamsNoVote
            If elm.Name.Equals(Name) Then
                PassedExamsNoVote.Remove(elm)
                Return True
            End If
        Next
        For Each elm In RemainingExams
            If elm.Name.Equals(Name) Then
                RemainingExams.Remove(elm)
                Return True
            End If
        Next
        MsgBox("Error: The indicated exam was not found.", , Form1.Text)
        Return False
    End Function
End Class
