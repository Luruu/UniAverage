<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewExamForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BAdd = New System.Windows.Forms.Button()
        Me.CheckPassedExam = New System.Windows.Forms.CheckBox()
        Me.DateExamPicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(153, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "0"
        Me.TextBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CFU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Vote"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "(optional)"
        Me.Label4.Visible = False
        '
        'BAdd
        '
        Me.BAdd.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BAdd.FlatAppearance.BorderSize = 0
        Me.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAdd.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.BAdd.ForeColor = System.Drawing.Color.White
        Me.BAdd.Location = New System.Drawing.Point(65, 197)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(155, 31)
        Me.BAdd.TabIndex = 28
        Me.BAdd.Text = "add the exam to the list"
        Me.BAdd.UseVisualStyleBackColor = False
        '
        'CheckPassedExam
        '
        Me.CheckPassedExam.AutoSize = True
        Me.CheckPassedExam.Location = New System.Drawing.Point(95, 174)
        Me.CheckPassedExam.Name = "CheckPassedExam"
        Me.CheckPassedExam.Size = New System.Drawing.Size(90, 17)
        Me.CheckPassedExam.TabIndex = 29
        Me.CheckPassedExam.Text = "Passed Exam"
        Me.CheckPassedExam.UseVisualStyleBackColor = True
        '
        'DateExamPicker
        '
        Me.DateExamPicker.Location = New System.Drawing.Point(35, 148)
        Me.DateExamPicker.Name = "DateExamPicker"
        Me.DateExamPicker.Size = New System.Drawing.Size(218, 20)
        Me.DateExamPicker.TabIndex = 30
        Me.DateExamPicker.Visible = False
        '
        'NewExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 240)
        Me.Controls.Add(Me.DateExamPicker)
        Me.Controls.Add(Me.CheckPassedExam)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewExamForm"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add a new exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BAdd As Button
    Friend WithEvents CheckPassedExam As CheckBox
    Friend WithEvents DateExamPicker As DateTimePicker
End Class
