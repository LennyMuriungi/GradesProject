<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Score1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Score2 = New System.Windows.Forms.TextBox()
        Me.Score3 = New System.Windows.Forms.TextBox()
        Me.Score4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalScore = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AverageScore = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DisplayGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject 1 score:"
        '
        'Score1
        '
        Me.Score1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Score1.Location = New System.Drawing.Point(229, 105)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(75, 31)
        Me.Score1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(406, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(163, 58)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject 2 score:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(28, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject 3 score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(28, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Subject 4 score:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(296, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 54)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Grade Calculator"
        '
        'Score2
        '
        Me.Score2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Score2.Location = New System.Drawing.Point(229, 154)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(75, 31)
        Me.Score2.TabIndex = 7
        '
        'Score3
        '
        Me.Score3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Score3.Location = New System.Drawing.Point(229, 208)
        Me.Score3.Name = "Score3"
        Me.Score3.Size = New System.Drawing.Size(75, 31)
        Me.Score3.TabIndex = 8
        '
        'Score4
        '
        Me.Score4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Score4.Location = New System.Drawing.Point(229, 259)
        Me.Score4.Name = "Score4"
        Me.Score4.Size = New System.Drawing.Size(75, 31)
        Me.Score4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(165, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 38)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total score:"
        '
        'TotalScore
        '
        Me.TotalScore.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalScore.Location = New System.Drawing.Point(368, 339)
        Me.TotalScore.Name = "TotalScore"
        Me.TotalScore.Size = New System.Drawing.Size(150, 31)
        Me.TotalScore.TabIndex = 11
        Me.TotalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(680, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 38)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Letter Grade"
        '
        'AverageScore
        '
        Me.AverageScore.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AverageScore.Location = New System.Drawing.Point(368, 398)
        Me.AverageScore.Name = "AverageScore"
        Me.AverageScore.Size = New System.Drawing.Size(150, 31)
        Me.AverageScore.TabIndex = 15
        Me.AverageScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(165, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 38)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Average score:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(406, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 55)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Redo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DisplayGrade
        '
        Me.DisplayGrade.Font = New System.Drawing.Font("Mongolian Baiti", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisplayGrade.Location = New System.Drawing.Point(697, 162)
        Me.DisplayGrade.Multiline = True
        Me.DisplayGrade.Name = "DisplayGrade"
        Me.DisplayGrade.Size = New System.Drawing.Size(124, 128)
        Me.DisplayGrade.TabIndex = 17
        Me.DisplayGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(919, 471)
        Me.Controls.Add(Me.DisplayGrade)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AverageScore)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Score4)
        Me.Controls.Add(Me.Score3)
        Me.Controls.Add(Me.Score2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Score1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Score1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Score2 As TextBox
    Friend WithEvents Score3 As TextBox
    Friend WithEvents Score4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalScore As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AverageScore As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DisplayGrade As TextBox
End Class
