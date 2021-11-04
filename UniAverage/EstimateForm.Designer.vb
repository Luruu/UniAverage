<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstimateForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioClassic = New System.Windows.Forms.RadioButton()
        Me.RadioAdvanced = New System.Windows.Forms.RadioButton()
        Me.BStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select the type of estimate"
        '
        'RadioClassic
        '
        Me.RadioClassic.AutoSize = True
        Me.RadioClassic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioClassic.Location = New System.Drawing.Point(62, 55)
        Me.RadioClassic.Name = "RadioClassic"
        Me.RadioClassic.Size = New System.Drawing.Size(163, 28)
        Me.RadioClassic.TabIndex = 6
        Me.RadioClassic.TabStop = True
        Me.RadioClassic.Text = "Classic Estimate"
        Me.RadioClassic.UseVisualStyleBackColor = True
        '
        'RadioAdvanced
        '
        Me.RadioAdvanced.AutoSize = True
        Me.RadioAdvanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAdvanced.Location = New System.Drawing.Point(62, 98)
        Me.RadioAdvanced.Name = "RadioAdvanced"
        Me.RadioAdvanced.Size = New System.Drawing.Size(190, 28)
        Me.RadioAdvanced.TabIndex = 7
        Me.RadioAdvanced.TabStop = True
        Me.RadioAdvanced.Text = "Advanced Estimate"
        Me.RadioAdvanced.UseVisualStyleBackColor = True
        '
        'BStart
        '
        Me.BStart.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BStart.FlatAppearance.BorderSize = 0
        Me.BStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BStart.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.BStart.ForeColor = System.Drawing.Color.White
        Me.BStart.Location = New System.Drawing.Point(70, 153)
        Me.BStart.Name = "BStart"
        Me.BStart.Size = New System.Drawing.Size(155, 31)
        Me.BStart.TabIndex = 29
        Me.BStart.Text = "Make Estimate"
        Me.BStart.UseVisualStyleBackColor = False
        '
        'EstimateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 196)
        Me.Controls.Add(Me.BStart)
        Me.Controls.Add(Me.RadioAdvanced)
        Me.Controls.Add(Me.RadioClassic)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EstimateForm"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EstimateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioClassic As RadioButton
    Friend WithEvents RadioAdvanced As RadioButton
    Friend WithEvents BStart As Button
End Class
