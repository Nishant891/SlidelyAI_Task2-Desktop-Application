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
        buttonCreateSubmission = New Button()
        buttonViewSubmission = New Button()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' buttonCreateSubmission
        ' 
        buttonCreateSubmission.BackColor = Color.LightSkyBlue
        buttonCreateSubmission.Font = New Font("Microsoft Sans Serif", 10F)
        buttonCreateSubmission.Location = New Point(13, 86)
        buttonCreateSubmission.Margin = New Padding(3, 4, 3, 4)
        buttonCreateSubmission.Name = "buttonCreateSubmission"
        buttonCreateSubmission.Size = New Size(538, 69)
        buttonCreateSubmission.TabIndex = 1
        buttonCreateSubmission.Text = "Create New Submission (Ctrl + N)"
        buttonCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' buttonViewSubmission
        ' 
        buttonViewSubmission.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        buttonViewSubmission.Font = New Font("Microsoft Sans Serif", 10F)
        buttonViewSubmission.Location = New Point(13, 178)
        buttonViewSubmission.Margin = New Padding(3, 4, 3, 4)
        buttonViewSubmission.Name = "buttonViewSubmission"
        buttonViewSubmission.Size = New Size(538, 66)
        buttonViewSubmission.TabIndex = 0
        buttonViewSubmission.Text = "View Submissions (Ctrl + V)"
        buttonViewSubmission.UseVisualStyleBackColor = False
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Microsoft Sans Serif", 10F)
        label1.Location = New Point(13, 30)
        label1.Name = "label1"
        label1.Size = New Size(451, 25)
        label1.TabIndex = 2
        label1.Text = "Nishant Sharma, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(563, 273)
        Controls.Add(label1)
        Controls.Add(buttonCreateSubmission)
        Controls.Add(buttonViewSubmission)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents buttonCreateSubmission As Button
    Friend WithEvents buttonViewSubmission As Button
    Friend WithEvents label1 As Label

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ' Calculate the rectangle for the border inside the client area
        Dim borderRectangle As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        ' Draw a black border around the form
        e.Graphics.DrawRectangle(New Pen(Color.Black, 1), borderRectangle)
    End Sub
End Class
