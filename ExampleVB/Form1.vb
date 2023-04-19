Imports TaskBarProgressBarVB
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If comboBox1.SelectedIndex = 0 Then
            TaskBarProgressBar.SetState(TaskBarProgressBar.State.None, Me)
        ElseIf comboBox1.SelectedIndex = 1 Then
            TaskBarProgressBar.SetState(TaskBarProgressBar.State.Normal, Me)
        ElseIf comboBox1.SelectedIndex = 2 Then
            TaskBarProgressBar.SetState(TaskBarProgressBar.State.Pause, Me)
        ElseIf comboBox1.SelectedIndex = 3 Then
            TaskBarProgressBar.SetState(TaskBarProgressBar.State.Error, Me)
        ElseIf comboBox1.SelectedIndex = 4 Then
            TaskBarProgressBar.SetState(TaskBarProgressBar.State.Undefined, Me)
        End If
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles trackBar1.Scroll
        TaskBarProgressBar.SetProgress(trackBar1.Value, trackBar1.Maximum)
        label2.Text = "Value: " + Convert.ToString(trackBar1.Value)
    End Sub
End Class
