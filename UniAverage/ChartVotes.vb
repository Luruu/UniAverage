Imports System.Windows.Forms.DataVisualization.Charting
Module ChartVotes
    Sub ResetChart(chartVote As Chart)
        For Each serie In chartVote.Series
            serie.Points.Clear()
        Next
    End Sub

    Sub SetChart(chartVote As Chart, PassedExams As List(Of Exam))

        If (chartVote.Series.Count = 0) Then
            Dim sExam As New Series("Votes")
            sExam.ChartType = SeriesChartType.Line

            Dim sCFU As New Series("CFU")
            sCFU.ChartType = SeriesChartType.Line

            chartVote.Series.Add(sExam)
            chartVote.Series("Votes").IsValueShownAsLabel = True
            chartVote.Series("Votes").MarkerSize = 1
            chartVote.Series.Add(sCFU)
            chartVote.Series("CFU").IsValueShownAsLabel = True
            chartVote.Series("CFU").MarkerSize = 1
        End If

        For Each exam In PassedExams
            chartVote.Series("Votes").Points.AddXY(exam.Name, exam.Vote)
            chartVote.Series("CFU").Points.AddXY(exam.Name, exam.CFU)
        Next
    End Sub
End Module
