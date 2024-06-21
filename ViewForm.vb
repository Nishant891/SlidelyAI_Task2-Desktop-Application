Imports System.Net.Http
Imports System.Reflection
Imports System.Text.Json

Public Class ViewForm

    Private _index As Integer = 0 ' Private backing field

    Private _max_size As Integer = 0

    ' Property to get and set the index
    Public Property Index As Integer
        Get
            Return _index
        End Get
        Set(value As Integer)
            _index = value
        End Set
    End Property

    Public Property Max_Size As Integer
        Get
            Return _max_size
        End Get
        Set(value As Integer)
            _max_size = value
        End Set
    End Property

    Private Async Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetData(Index)
    End Sub

    Private Async Function GetData(idx As Integer) As Task
        Dim apiUrl As String = $"http://localhost:5000/read?index={idx}"

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Parse the JSON response
                Dim jsonDoc As JsonDocument = JsonDocument.Parse(responseContent)
                Dim root As JsonElement = jsonDoc.RootElement

                ' Check for success flag
                Dim successProp As JsonElement
                If root.TryGetProperty("success", successProp) AndAlso successProp.GetBoolean() Then
                    ' Access data object
                    Max_Size = root.GetProperty("size").GetInt32()
                    Dim data As JsonElement = root.GetProperty("data")
                    txtField1.Text = data.GetProperty("name").GetString()
                    txtField2.Text = data.GetProperty("email").GetString()
                    textBox1.Text = data.GetProperty("phone_number").GetString()
                    textBox2.Text = data.GetProperty("github_link").GetString()
                    textBox3.Text = data.GetProperty("stopwatch_time").GetString()

                    ' Show success message
                    Dim message As String = root.GetProperty("message").GetString()
                    ' MessageBox.Show(message, "Success")
                Else
                    ' Show error message
                    Dim message As String = root.GetProperty("message").GetString()
                    MessageBox.Show(message, "Error")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show("Error communicating with the server: " & ex.Message, "Server Error")
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error")
        End Try
    End Function

    Private Async Function DeleteData(idx As Integer) As Task
        Dim apiUrl As String = $"http://localhost:5000/delete?index={idx}"

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Parse the JSON response
                Dim jsonDoc As JsonDocument = JsonDocument.Parse(responseContent)
                Dim root As JsonElement = jsonDoc.RootElement

                ' Check for success flag
                Dim successProp As JsonElement
                If root.TryGetProperty("success", successProp) AndAlso successProp.GetBoolean() Then
                    ' Access data object
                    Max_Size = root.GetProperty("size").GetInt32()

                    ' Show success message
                    Dim message As String = root.GetProperty("message").GetString()
                    MessageBox.Show(message, "Success")

                    ' Perform NextAction
                    ' NextAction()
                Else
                    ' Show error message
                    Dim message As String = root.GetProperty("message").GetString()
                    MessageBox.Show(message, "Error")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show("Error communicating with the server: " & ex.Message, "Server Error")
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error")
        End Try
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        PrevAction()
    End Sub

    Private Async Sub PrevAction()
        If (Index > 0) Then
            Index -= 1
            Await GetData(Index)
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        NextAction()
    End Sub

    Private Async Sub NextAction()
        If Index < Max_Size - 1 Then
            Index += 1
            Await GetData(Index)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteAction()
    End Sub

    Private Async Sub DeleteAction()
        Await DeleteData(Index)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            PrevAction()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.N) Then
            NextAction()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
