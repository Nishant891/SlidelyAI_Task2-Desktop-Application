Imports Windows.Win32.UI.Input

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewForm
    Inherits System.Windows.Forms.Form

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

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    ''' 
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtField1 = New TextBox()
        txtField2 = New TextBox()
        label1 = New Label()
        label2 = New Label()
        label3 = New Label()
        label4 = New Label()
        textBox1 = New TextBox()
        label5 = New Label()
        textBox2 = New TextBox()
        label6 = New Label()
        textBox3 = New TextBox()
        button1 = New Button()
        button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' txtField1
        ' 
        txtField1.BorderStyle = BorderStyle.FixedSingle
        txtField1.Enabled = False
        txtField1.Location = New Point(265, 106)
        txtField1.Name = "txtField1"
        txtField1.ReadOnly = True
        txtField1.Size = New Size(262, 31)
        txtField1.TabIndex = 0
        ' 
        ' txtField2
        ' 
        txtField2.BorderStyle = BorderStyle.FixedSingle
        txtField2.Enabled = False
        txtField2.Location = New Point(265, 162)
        txtField2.Name = "txtField2"
        txtField2.ReadOnly = True
        txtField2.Size = New Size(262, 31)
        txtField2.TabIndex = 1
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(29, 41)
        label1.Name = "label1"
        label1.Size = New Size(462, 25)
        label1.TabIndex = 2
        label1.Text = "Nishant Sharma, Slidely Task 2 - View Submissions"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(29, 112)
        label2.Name = "label2"
        label2.Size = New Size(64, 25)
        label2.TabIndex = 3
        label2.Text = "Name"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(29, 168)
        label3.Name = "label3"
        label3.Size = New Size(60, 25)
        label3.TabIndex = 4
        label3.Text = "Email"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label4.Location = New Point(29, 228)
        label4.Name = "label4"
        label4.Size = New Size(104, 25)
        label4.TabIndex = 5
        label4.Text = "Phone No."
        ' 
        ' textBox1
        ' 
        textBox1.BorderStyle = BorderStyle.FixedSingle
        textBox1.Enabled = False
        textBox1.Location = New Point(265, 222)
        textBox1.Name = "textBox1"
        textBox1.ReadOnly = True
        textBox1.Size = New Size(262, 31)
        textBox1.TabIndex = 6
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label5.Location = New Point(29, 285)
        label5.Name = "label5"
        label5.Size = New Size(212, 25)
        label5.TabIndex = 7
        label5.Text = "GitHub Link For Task 2"
        ' 
        ' textBox2
        ' 
        textBox2.BorderStyle = BorderStyle.FixedSingle
        textBox2.Enabled = False
        textBox2.Location = New Point(265, 279)
        textBox2.Name = "textBox2"
        textBox2.ReadOnly = True
        textBox2.Size = New Size(262, 31)
        textBox2.TabIndex = 8
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label6.Location = New Point(29, 341)
        label6.Name = "label6"
        label6.Size = New Size(153, 25)
        label6.TabIndex = 9
        label6.Text = "Stopwatch Time"
        ' 
        ' textBox3
        ' 
        textBox3.BorderStyle = BorderStyle.FixedSingle
        textBox3.Enabled = False
        textBox3.Location = New Point(265, 335)
        textBox3.Name = "textBox3"
        textBox3.ReadOnly = True
        textBox3.Size = New Size(262, 31)
        textBox3.TabIndex = 10
        ' 
        ' button1
        ' 
        button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        button1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button1.Location = New Point(29, 420)
        button1.Name = "button1"
        button1.Size = New Size(234, 66)
        button1.TabIndex = 11
        button1.Text = "PREVIOUS (CTRL + P)"
        button1.UseVisualStyleBackColor = False
        ' 
        ' button2
        ' 
        button2.BackColor = Color.LightSkyBlue
        button2.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button2.Location = New Point(293, 420)
        button2.Name = "button2"
        button2.Size = New Size(234, 66)
        button2.TabIndex = 12
        button2.Text = "NEXT (CTRL + N)"
        button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(29, 513)
        Button3.Name = "Button3"
        Button3.Size = New Size(498, 66)
        Button3.TabIndex = 13
        Button3.Text = "DELETE (CTRL + D)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(563, 621)
        Controls.Add(Button3)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(textBox3)
        Controls.Add(label6)
        Controls.Add(textBox2)
        Controls.Add(label5)
        Controls.Add(textBox1)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(txtField2)
        Controls.Add(txtField1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ViewForm"
        Text = "ViewForm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Friend WithEvents txtField1 As System.Windows.Forms.TextBox
    Friend WithEvents txtField2 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents textBox3 As System.Windows.Forms.TextBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ' Calculate the rectangle for the border inside the client area
        Dim borderRectangle As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        ' Draw a black border around the form
        e.Graphics.DrawRectangle(New Pen(Color.Black, 1), borderRectangle)
    End Sub

End Class
