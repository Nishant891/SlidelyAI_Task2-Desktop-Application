Imports System.Net.Http
Imports System.Text.Json

Public Class SubmissionForm
    Private ss As Integer
    Private vv As Integer
    Private tt As Integer

    Private Sub SubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Interval = 1000
        timer1.Enabled = True
    End Sub

    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await PostData()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ToggleTimer()
    End Sub

    Private Sub ToggleTimer()
        If timer1.Enabled Then
            timer1.Enabled = False
        Else
            timer1.Enabled = True
        End If
    End Sub

    Private Async Function PostData() As Task
        Dim apiUrl As String = "http://localhost:5000/submit"

        Dim jsonData As String = JsonSerializer.Serialize(New With {
            .name = txtField1.Text,
            .email = txtField2.Text,
            .phone_number = textBox1.Text,
            .github_link = textBox2.Text,
            .stopwatch_time = label6.Text
        })

        timer1.Enabled = False

        'POST request to /submit
        Try
            Using client As New HttpClient()
                client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

                Dim content As New StringContent(jsonData, System.Text.Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                ' Handle response correctly
                If response.IsSuccessStatusCode Then
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonDocument As JsonDocument = JsonDocument.Parse(responseContent)
                    Dim message As String = jsonDocument.RootElement.GetProperty("message").GetString()
                    MessageBox.Show(message, "Success")
                    timer1.Enabled = True
                Else
                    MessageBox.Show("Failed to add user", "Error")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show("Error communicating with the server: " & ex.Message, "Server Error")
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error")
        End Try
    End Function


    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If timer1.Enabled Then
            ss += 1
            If ss > 59 Then
                ss = 0
                vv += 1
            End If
            If vv > 59 Then
                vv = 0
                tt += 1
            End If
            label6.Text = $"{tt:D2}:{vv:D2}:{ss:D2}"
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleTimer()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.S) Then
            Task.Run(Sub() PostData())
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
