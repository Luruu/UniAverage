Imports System.IO
Imports Newtonsoft.Json
Module StudentJSON
    Private strJSON As String
    Public fileJSONName As String = "student.json"

    Public Function ReadJSON_file()
        Return ReadFile(fileJSONName)
    End Function
    Public Function WriteJSON_file(student As Student)
        SetJSON(student)
        Return WriteFile(fileJSONName, strJSON)
    End Function

    Public Function JSONFileExists()
        Return FileExists(fileJSONName)
    End Function

    Private Function ReadFile(namefile As String)
        Dim file As StreamReader
        Try
            file = My.Computer.FileSystem.OpenTextFileReader(namefile)
        Catch ex1 As FileNotFoundException
            Try
                IO.File.Create(namefile).Dispose() 'File is created if not exists
                file = My.Computer.FileSystem.OpenTextFileReader(namefile)
            Catch ex4 As FileNotFoundException
                MsgBox("Error: unable to read student file. Code: -2", , Form1.Text)
                Return -2
            End Try
        Catch ex2 As Security.SecurityException
            MsgBox("Error: unable to read student file." & vbCrLf & "Change the location of the program folder. Code: -1", , Form1.Text)
            Return -1
        Catch ex3 As ArgumentException
            MsgBox("Error: unable to read student file. Code: -3", , Form1.Text)
            Return -3
        End Try

        Dim strfile As String = file.ReadToEnd
        file.Close()
        Return strfile
    End Function
    Private Function WriteFile(namefile As String, str_to_write As String)
        Dim file As StreamWriter
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(namefile, False)
            Try
                file.Write(str_to_write)
            Catch ex As IOException
                MsgBox("Error: unable to write student file. Code: -1", , Form1.Text)
                file.Close()
                Return -1
            Catch ex2 As NotSupportedException
                MsgBox("Error: unable to write student file. Code: -2", , Form1.Text)
                file.Close()
                Return -2
            End Try
        Catch ex As ArgumentException
            MsgBox("Error: unable to write student file. Code: -3", , Form1.Text)
            Return -3
        End Try

        file.Close()
        Return 1
    End Function
    Private Function FileExists(namefile As String)
        Return File.Exists(namefile)
    End Function

    Public Function GetStudent(JSON As String) As Student
        Try
            Return JsonConvert.DeserializeObject(Of Student)(JSON)
        Catch ex As Newtonsoft.Json.JsonReaderException
            MsgBox("Error: The student file is corrupt." & vbCrLf & "If you can, correct the file with JSON syntax, otherwise delete the file and restart the program." & vbCrLf & vbCrLf & "N.B: you will lose all the data you entered in this program.", , Form1.Text)
        End Try
        Return Nothing
    End Function

    Public Sub SetJSON(student As Student)
        strJSON = JsonConvert.SerializeObject(student)
        WriteFile(fileJSONName, strJSON)
    End Sub
    Public Function GetJSON() As String
        Return strJSON 'can be nothing
    End Function

End Module
