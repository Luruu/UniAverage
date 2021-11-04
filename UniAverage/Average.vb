Module Average
    Function Arithmetic(Exams As List(Of Exam))
        Return Decimal.Round(SumVote(Exams) / Exams.Count, 2)
    End Function

    Function GetProgress(PassedExams As List(Of Exam), PassedExamsNoVote As List(Of Exam), StudentMaxCFU As UShort)
        Return Decimal.Round((SumCFU(PassedExams) + SumCFU(PassedExamsNoVote)) / StudentMaxCFU * 100, 1)
    End Function

    Function Weighted(Exams As List(Of Exam))
        Return Decimal.Round(SumVotexCFU(Exams) / SumCFU(Exams), 2)
    End Function

    Function EstimatedWeighted(PassedExams As List(Of Exam), RemainingExams As List(Of Exam), voteRemExams As UShort)
        Dim votecfuSimulated As Single = 0
        For Each exam In RemainingExams
            votecfuSimulated += voteRemExams * exam.CFU
        Next
        Return Decimal.Round((((SumVotexCFU(PassedExams) + votecfuSimulated)) / (SumCFU(PassedExams) + SumCFU(RemainingExams))), 2)
    End Function

    Function GradStartVote(Exams As List(Of Exam)) 'Grad = Graduation
        Return Decimal.Round(Weighted(Exams) * 11 / 3, 2)
    End Function

    Function EstimatedGradStartVote(PassedExams As List(Of Exam), RemainingExams As List(Of Exam), voteRemExams As UShort)
        Return Decimal.Round(EstimatedWeighted(PassedExams, RemainingExams, voteRemExams) * 11 / 3, 2)
    End Function

    Function SumCFU(Exams As List(Of Exam))
        Dim sum As UShort = 0
        For Each exam In Exams
            sum += exam.CFU
        Next
        Return sum
    End Function

    Function SumVote(Exams As List(Of Exam))
        Dim sum As UShort = 0
        For Each exam In Exams
            sum += exam.Vote
        Next
        Return sum
    End Function

    Function SumVotexCFU(Exams As List(Of Exam))
        Dim voteCfu As Single = 0
        For Each exam In Exams
            voteCfu += exam.Vote * exam.CFU
        Next
        Return voteCfu
    End Function
End Module
