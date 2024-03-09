<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Math_btn = New System.Windows.Forms.Label()
        Me.Science_btn = New System.Windows.Forms.Label()
        Me.English_btn = New System.Windows.Forms.Label()
        Me.Gradeform_btn = New System.Windows.Forms.Label()
        Me.Evaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 27)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 189)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 27)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(57, 118)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 27)
        Me.TextBox3.TabIndex = 2
        '
        'Math_btn
        '
        Me.Math_btn.AutoSize = True
        Me.Math_btn.Location = New System.Drawing.Point(43, 20)
        Me.Math_btn.Name = "Math_btn"
        Me.Math_btn.Size = New System.Drawing.Size(31, 13)
        Me.Math_btn.TabIndex = 3
        Me.Math_btn.Text = "Math"
        '
        'Science_btn
        '
        Me.Science_btn.AutoSize = True
        Me.Science_btn.Location = New System.Drawing.Point(53, 90)
        Me.Science_btn.Name = "Science_btn"
        Me.Science_btn.Size = New System.Drawing.Size(46, 13)
        Me.Science_btn.TabIndex = 4
        Me.Science_btn.Text = "Science"
        '
        'English_btn
        '
        Me.English_btn.AutoSize = True
        Me.English_btn.Location = New System.Drawing.Point(52, 169)
        Me.English_btn.Name = "English_btn"
        Me.English_btn.Size = New System.Drawing.Size(41, 13)
        Me.English_btn.TabIndex = 5
        Me.English_btn.Text = "English"
        '
        'Gradeform_btn
        '
        Me.Gradeform_btn.AutoSize = True
        Me.Gradeform_btn.Location = New System.Drawing.Point(95, 7)
        Me.Gradeform_btn.Name = "Gradeform_btn"
        Me.Gradeform_btn.Size = New System.Drawing.Size(62, 13)
        Me.Gradeform_btn.TabIndex = 6
        Me.Gradeform_btn.Text = "Grade Form"
        '
        'Evaluate
        '
        Me.Evaluate.Location = New System.Drawing.Point(98, 222)
        Me.Evaluate.Name = "Evaluate"
        Me.Evaluate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Evaluate.Size = New System.Drawing.Size(99, 30)
        Me.Evaluate.TabIndex = 8
        Me.Evaluate.Text = "Evaluate"
        Me.Evaluate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 276)
        Me.Controls.Add(Me.Evaluate)
        Me.Controls.Add(Me.Gradeform_btn)
        Me.Controls.Add(Me.English_btn)
        Me.Controls.Add(Me.Science_btn)
        Me.Controls.Add(Me.Math_btn)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Math_btn As Label
    Friend WithEvents Science_btn As Label
    Friend WithEvents English_btn As Label
    Friend WithEvents Gradeform_btn As Label
    Friend WithEvents Evaluate As Button
End Class
