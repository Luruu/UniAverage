<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListaEsamiRimanenti = New System.Windows.Forms.ListBox()
        Me.GAttuale = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LProgress = New System.Windows.Forms.Label()
        Me.Lmediaarit = New System.Windows.Forms.Label()
        Me.Lmediapond = New System.Windows.Forms.Label()
        Me.Votopart = New System.Windows.Forms.Label()
        Me.Lvotearit = New System.Windows.Forms.Label()
        Me.LvotePon = New System.Windows.Forms.Label()
        Me.Lvotepart = New System.Windows.Forms.Label()
        Me.Lpuntcfu = New System.Windows.Forms.Label()
        Me.BRem = New System.Windows.Forms.Button()
        Me.BAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lmaspar = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lminpond = New System.Windows.Forms.Label()
        Me.Lmaspond = New System.Windows.Forms.Label()
        Me.Lminpar = New System.Windows.Forms.Label()
        Me.ListaEsami = New System.Windows.Forms.ListBox()
        Me.LName = New System.Windows.Forms.Label()
        Me.LMaxCFU = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lcfu = New System.Windows.Forms.Label()
        Me.LExamRem = New System.Windows.Forms.Label()
        Me.LExamPas = New System.Windows.Forms.Label()
        Me.BMove = New System.Windows.Forms.Button()
        Me.BEstimate = New System.Windows.Forms.Button()
        Me.ChartVote = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LnoEstimates = New System.Windows.Forms.Label()
        Me.GAttuale.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChartVote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaEsamiRimanenti
        '
        Me.ListaEsamiRimanenti.BackColor = System.Drawing.SystemColors.Menu
        Me.ListaEsamiRimanenti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaEsamiRimanenti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaEsamiRimanenti.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaEsamiRimanenti.ForeColor = System.Drawing.Color.DimGray
        Me.ListaEsamiRimanenti.FormattingEnabled = True
        Me.ListaEsamiRimanenti.HorizontalScrollbar = True
        Me.ListaEsamiRimanenti.ItemHeight = 21
        Me.ListaEsamiRimanenti.Location = New System.Drawing.Point(927, 66)
        Me.ListaEsamiRimanenti.Name = "ListaEsamiRimanenti"
        Me.ListaEsamiRimanenti.Size = New System.Drawing.Size(245, 420)
        Me.ListaEsamiRimanenti.TabIndex = 31
        '
        'GAttuale
        '
        Me.GAttuale.Controls.Add(Me.Label11)
        Me.GAttuale.Controls.Add(Me.LProgress)
        Me.GAttuale.Controls.Add(Me.Lmediaarit)
        Me.GAttuale.Controls.Add(Me.Lmediapond)
        Me.GAttuale.Controls.Add(Me.Votopart)
        Me.GAttuale.Controls.Add(Me.Lvotearit)
        Me.GAttuale.Controls.Add(Me.LvotePon)
        Me.GAttuale.Controls.Add(Me.Lvotepart)
        Me.GAttuale.Location = New System.Drawing.Point(596, 278)
        Me.GAttuale.Name = "GAttuale"
        Me.GAttuale.Size = New System.Drawing.Size(325, 208)
        Me.GAttuale.TabIndex = 29
        Me.GAttuale.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label11.Location = New System.Drawing.Point(195, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Progress"
        '
        'LProgress
        '
        Me.LProgress.AutoSize = True
        Me.LProgress.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LProgress.ForeColor = System.Drawing.Color.SkyBlue
        Me.LProgress.Location = New System.Drawing.Point(208, 151)
        Me.LProgress.Name = "LProgress"
        Me.LProgress.Size = New System.Drawing.Size(55, 37)
        Me.LProgress.TabIndex = 39
        Me.LProgress.Text = "0%"
        '
        'Lmediaarit
        '
        Me.Lmediaarit.AutoSize = True
        Me.Lmediaarit.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmediaarit.ForeColor = System.Drawing.Color.DarkCyan
        Me.Lmediaarit.Location = New System.Drawing.Point(6, 20)
        Me.Lmediaarit.Name = "Lmediaarit"
        Me.Lmediaarit.Size = New System.Drawing.Size(151, 21)
        Me.Lmediaarit.TabIndex = 1
        Me.Lmediaarit.Text = "Arithmetic Average"
        '
        'Lmediapond
        '
        Me.Lmediapond.AutoSize = True
        Me.Lmediapond.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmediapond.ForeColor = System.Drawing.Color.Purple
        Me.Lmediapond.Location = New System.Drawing.Point(177, 20)
        Me.Lmediapond.Name = "Lmediapond"
        Me.Lmediapond.Size = New System.Drawing.Size(144, 21)
        Me.Lmediapond.TabIndex = 2
        Me.Lmediapond.Text = "Weighted Average"
        '
        'Votopart
        '
        Me.Votopart.AutoSize = True
        Me.Votopart.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Votopart.ForeColor = System.Drawing.Color.DarkBlue
        Me.Votopart.Location = New System.Drawing.Point(6, 120)
        Me.Votopart.Name = "Votopart"
        Me.Votopart.Size = New System.Drawing.Size(172, 21)
        Me.Votopart.TabIndex = 3
        Me.Votopart.Text = "Graduation Vote Start"
        '
        'Lvotearit
        '
        Me.Lvotearit.AutoSize = True
        Me.Lvotearit.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvotearit.ForeColor = System.Drawing.Color.DarkCyan
        Me.Lvotearit.Location = New System.Drawing.Point(54, 51)
        Me.Lvotearit.Name = "Lvotearit"
        Me.Lvotearit.Size = New System.Drawing.Size(32, 37)
        Me.Lvotearit.TabIndex = 6
        Me.Lvotearit.Text = "0"
        '
        'LvotePon
        '
        Me.LvotePon.AutoSize = True
        Me.LvotePon.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvotePon.ForeColor = System.Drawing.Color.Purple
        Me.LvotePon.Location = New System.Drawing.Point(208, 51)
        Me.LvotePon.Name = "LvotePon"
        Me.LvotePon.Size = New System.Drawing.Size(32, 37)
        Me.LvotePon.TabIndex = 7
        Me.LvotePon.Text = "0"
        '
        'Lvotepart
        '
        Me.Lvotepart.AutoSize = True
        Me.Lvotepart.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvotepart.ForeColor = System.Drawing.Color.DarkBlue
        Me.Lvotepart.Location = New System.Drawing.Point(54, 151)
        Me.Lvotepart.Name = "Lvotepart"
        Me.Lvotepart.Size = New System.Drawing.Size(32, 37)
        Me.Lvotepart.TabIndex = 8
        Me.Lvotepart.Text = "0"
        '
        'Lpuntcfu
        '
        Me.Lpuntcfu.AutoSize = True
        Me.Lpuntcfu.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lpuntcfu.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Lpuntcfu.Location = New System.Drawing.Point(58, 46)
        Me.Lpuntcfu.Name = "Lpuntcfu"
        Me.Lpuntcfu.Size = New System.Drawing.Size(32, 37)
        Me.Lpuntcfu.TabIndex = 9
        Me.Lpuntcfu.Text = "0"
        '
        'BRem
        '
        Me.BRem.BackColor = System.Drawing.Color.Brown
        Me.BRem.Enabled = False
        Me.BRem.FlatAppearance.BorderSize = 0
        Me.BRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRem.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BRem.Location = New System.Drawing.Point(731, 14)
        Me.BRem.Name = "BRem"
        Me.BRem.Size = New System.Drawing.Size(155, 40)
        Me.BRem.TabIndex = 28
        Me.BRem.Text = "Remove Exam"
        Me.BRem.UseVisualStyleBackColor = False
        '
        'BAdd
        '
        Me.BAdd.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BAdd.FlatAppearance.BorderSize = 0
        Me.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAdd.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.BAdd.ForeColor = System.Drawing.Color.White
        Me.BAdd.Location = New System.Drawing.Point(314, 14)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(155, 40)
        Me.BAdd.TabIndex = 27
        Me.BAdd.Text = "Add Exam"
        Me.BAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label2.Location = New System.Drawing.Point(274, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "All 30L"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LnoEstimates)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lmaspar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lminpond)
        Me.GroupBox1.Controls.Add(Me.Lmaspond)
        Me.GroupBox1.Controls.Add(Me.Lminpar)
        Me.GroupBox1.Location = New System.Drawing.Point(596, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 208)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(114, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "All 18"
        '
        'Lmaspar
        '
        Me.Lmaspar.AutoSize = True
        Me.Lmaspar.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmaspar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Lmaspar.Location = New System.Drawing.Point(208, 151)
        Me.Lmaspar.Name = "Lmaspar"
        Me.Lmaspar.Size = New System.Drawing.Size(32, 37)
        Me.Lmaspar.TabIndex = 9
        Me.Lmaspar.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "MIN Weighted"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Location = New System.Drawing.Point(177, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "MAX Weighted"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Brown
        Me.Label6.Location = New System.Drawing.Point(7, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "MIN Start Grad."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label7.Location = New System.Drawing.Point(177, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "MAX Start Grad."
        '
        'Lminpond
        '
        Me.Lminpond.AutoSize = True
        Me.Lminpond.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lminpond.ForeColor = System.Drawing.Color.Brown
        Me.Lminpond.Location = New System.Drawing.Point(54, 51)
        Me.Lminpond.Name = "Lminpond"
        Me.Lminpond.Size = New System.Drawing.Size(32, 37)
        Me.Lminpond.TabIndex = 6
        Me.Lminpond.Text = "0"
        '
        'Lmaspond
        '
        Me.Lmaspond.AutoSize = True
        Me.Lmaspond.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmaspond.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Lmaspond.Location = New System.Drawing.Point(208, 51)
        Me.Lmaspond.Name = "Lmaspond"
        Me.Lmaspond.Size = New System.Drawing.Size(32, 37)
        Me.Lmaspond.TabIndex = 7
        Me.Lmaspond.Text = "0"
        '
        'Lminpar
        '
        Me.Lminpar.AutoSize = True
        Me.Lminpar.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lminpar.ForeColor = System.Drawing.Color.Brown
        Me.Lminpar.Location = New System.Drawing.Point(54, 151)
        Me.Lminpar.Name = "Lminpar"
        Me.Lminpar.Size = New System.Drawing.Size(32, 37)
        Me.Lminpar.TabIndex = 8
        Me.Lminpar.Text = "0"
        '
        'ListaEsami
        '
        Me.ListaEsami.BackColor = System.Drawing.SystemColors.Menu
        Me.ListaEsami.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaEsami.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaEsami.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaEsami.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListaEsami.FormattingEnabled = True
        Me.ListaEsami.HorizontalScrollbar = True
        Me.ListaEsami.ItemHeight = 21
        Me.ListaEsami.Location = New System.Drawing.Point(12, 66)
        Me.ListaEsami.Name = "ListaEsami"
        Me.ListaEsami.Size = New System.Drawing.Size(245, 420)
        Me.ListaEsami.Sorted = True
        Me.ListaEsami.TabIndex = 26
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(25, 26)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(121, 28)
        Me.LName.TabIndex = 35
        Me.LName.Text = "Unknown"
        '
        'LMaxCFU
        '
        Me.LMaxCFU.AutoSize = True
        Me.LMaxCFU.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LMaxCFU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LMaxCFU.Location = New System.Drawing.Point(212, 46)
        Me.LMaxCFU.Name = "LMaxCFU"
        Me.LMaxCFU.Size = New System.Drawing.Size(32, 37)
        Me.LMaxCFU.TabIndex = 37
        Me.LMaxCFU.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Lpuntcfu)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LMaxCFU)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Lcfu)
        Me.GroupBox2.Controls.Add(Me.LExamRem)
        Me.GroupBox2.Controls.Add(Me.LExamPas)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 208)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(190, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "MAX CFU"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label9.Location = New System.Drawing.Point(165, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Remaining Exams"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label10.Location = New System.Drawing.Point(20, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Passed Exams"
        '
        'Lcfu
        '
        Me.Lcfu.AutoSize = True
        Me.Lcfu.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcfu.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Lcfu.Location = New System.Drawing.Point(55, 20)
        Me.Lcfu.Name = "Lcfu"
        Me.Lcfu.Size = New System.Drawing.Size(43, 21)
        Me.Lcfu.TabIndex = 5
        Me.Lcfu.Text = "CFU"
        '
        'LExamRem
        '
        Me.LExamRem.AutoSize = True
        Me.LExamRem.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LExamRem.ForeColor = System.Drawing.Color.OliveDrab
        Me.LExamRem.Location = New System.Drawing.Point(212, 151)
        Me.LExamRem.Name = "LExamRem"
        Me.LExamRem.Size = New System.Drawing.Size(32, 37)
        Me.LExamRem.TabIndex = 7
        Me.LExamRem.Text = "0"
        '
        'LExamPas
        '
        Me.LExamPas.AutoSize = True
        Me.LExamPas.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LExamPas.ForeColor = System.Drawing.Color.DarkOrange
        Me.LExamPas.Location = New System.Drawing.Point(63, 151)
        Me.LExamPas.Name = "LExamPas"
        Me.LExamPas.Size = New System.Drawing.Size(32, 37)
        Me.LExamPas.TabIndex = 8
        Me.LExamPas.Text = "0"
        '
        'BMove
        '
        Me.BMove.BackColor = System.Drawing.Color.SandyBrown
        Me.BMove.Enabled = False
        Me.BMove.FlatAppearance.BorderSize = 0
        Me.BMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMove.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.BMove.ForeColor = System.Drawing.Color.White
        Me.BMove.Location = New System.Drawing.Point(520, 14)
        Me.BMove.Name = "BMove"
        Me.BMove.Size = New System.Drawing.Size(155, 40)
        Me.BMove.TabIndex = 40
        Me.BMove.Text = "Move Exam"
        Me.BMove.UseVisualStyleBackColor = False
        '
        'BEstimate
        '
        Me.BEstimate.BackColor = System.Drawing.Color.Gray
        Me.BEstimate.FlatAppearance.BorderSize = 0
        Me.BEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEstimate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEstimate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BEstimate.Location = New System.Drawing.Point(957, 14)
        Me.BEstimate.Name = "BEstimate"
        Me.BEstimate.Size = New System.Drawing.Size(174, 40)
        Me.BEstimate.TabIndex = 41
        Me.BEstimate.Text = "Make an estimate"
        Me.BEstimate.UseVisualStyleBackColor = False
        '
        'ChartVote
        '
        Me.ChartVote.BackColor = System.Drawing.Color.Transparent
        Me.ChartVote.BorderlineColor = System.Drawing.SystemColors.ControlLight
        Me.ChartVote.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.ChartVote.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.ChartVote.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.IsSameFontSizeForAllAxes = True
        ChartArea3.Name = "ChartArea1"
        Me.ChartVote.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.ChartVote.Legends.Add(Legend3)
        Me.ChartVote.Location = New System.Drawing.Point(265, 284)
        Me.ChartVote.Name = "ChartVote"
        Me.ChartVote.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Me.ChartVote.Size = New System.Drawing.Size(325, 200)
        Me.ChartVote.TabIndex = 39
        Me.ChartVote.Text = "ChartVote"
        '
        'LnoEstimates
        '
        Me.LnoEstimates.AutoSize = True
        Me.LnoEstimates.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnoEstimates.ForeColor = System.Drawing.Color.Red
        Me.LnoEstimates.Location = New System.Drawing.Point(2, 103)
        Me.LnoEstimates.Name = "LnoEstimates"
        Me.LnoEstimates.Size = New System.Drawing.Size(319, 16)
        Me.LnoEstimates.TabIndex = 12
        Me.LnoEstimates.Text = "Insert remaining exams to get different future estimates!"
        Me.LnoEstimates.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 487)
        Me.Controls.Add(Me.BEstimate)
        Me.Controls.Add(Me.BMove)
        Me.Controls.Add(Me.ChartVote)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.ListaEsamiRimanenti)
        Me.Controls.Add(Me.GAttuale)
        Me.Controls.Add(Me.BRem)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListaEsami)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UniAvg"
        Me.GAttuale.ResumeLayout(False)
        Me.GAttuale.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ChartVote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEsamiRimanenti As ListBox
    Friend WithEvents GAttuale As GroupBox
    Friend WithEvents Lpuntcfu As Label
    Friend WithEvents Lmediaarit As Label
    Friend WithEvents Lmediapond As Label
    Friend WithEvents Votopart As Label
    Friend WithEvents Lvotearit As Label
    Friend WithEvents LvotePon As Label
    Friend WithEvents Lvotepart As Label
    Friend WithEvents BRem As Button
    Friend WithEvents BAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lmaspar As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lminpond As Label
    Friend WithEvents Lmaspond As Label
    Friend WithEvents Lminpar As Label
    Friend WithEvents ListaEsami As ListBox
    Friend WithEvents LName As Label
    Friend WithEvents LMaxCFU As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LExamRem As Label
    Friend WithEvents LExamPas As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LProgress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lcfu As Label
    Friend WithEvents BMove As Button
    Friend WithEvents BEstimate As Button
    Friend WithEvents ChartVote As DataVisualization.Charting.Chart
    Friend WithEvents LnoEstimates As Label
End Class
