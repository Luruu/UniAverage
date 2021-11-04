Public Class Exam
    Public Shared MAXCFU = 38 'a random High value. 
    Public Shared MINCFU = 1
    Public Shared MAXVOTE = 33 'Max value for Lode but it will change
    Public Shared MINVOTE = 18
    Public Shared NOVOTE = 0

    Public Name As String
    Public CFU As UShort
    Public Vote As UShort = NOVOTE 'Vote can be 0 for no-voted exams or remaining exams
    Public DateExam As String
    Public Sub New()
        'for Deserialize
    End Sub
    Public Sub New(Name As String, CFU As UShort, Vote As UShort, DateExam As Date) 'Passed Exams
        Me.Name = Name
        Me.CFU = CFU
        Me.Vote = Vote
        Me.DateExam = DateExam.ToShortDateString
    End Sub

    Public Sub New(Name As String, CFU As UShort) 'Remaining Exams
        Me.Name = Name
        Me.CFU = CFU
    End Sub
End Class
