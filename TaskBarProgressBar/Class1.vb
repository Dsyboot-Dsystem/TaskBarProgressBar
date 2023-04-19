Imports System.Windows.Forms
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class TaskBarProgressBar
    Private Shared condenatedform As Form
    Private Shared ReadOnly windowsTaskbar As TaskbarManager = TaskbarManager.Instance
    Enum State
        None
        Normal
        Pause
        [Error]
        Undefined
    End Enum
    Public Shared Function SetState(taskstate As State, form As Form)
        If taskstate = State.None Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, form.Handle)
        ElseIf taskstate = State.Normal Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, form.Handle)
        ElseIf taskstate = State.Pause Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused, form.Handle)
        ElseIf taskstate = State.Error Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Error, form.Handle)
        ElseIf taskstate = State.Undefined Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate, form.Handle)
        End If
        condenatedform = form
        Return condenatedform
    End Function
    Public Shared Function SetProgress(value As Integer, maxvalue As Integer) As Boolean
        Try
            windowsTaskbar.SetProgressValue(value, maxvalue, condenatedform.Handle)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "No se inicio el estado!")
        End Try
        Return True
    End Function
    Public Shared Function SetProgress(value As Integer, maxvalue As Integer, form As Form, taskstate As State) As Boolean
        If taskstate = State.None Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, form.Handle)
        ElseIf taskstate = State.Normal Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, form.Handle)
        ElseIf taskstate = State.Pause Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused, form.Handle)
        ElseIf taskstate = State.Error Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Error, form.Handle)
        ElseIf taskstate = State.Undefined Then
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate, form.Handle)
        End If
        windowsTaskbar.SetProgressValue(value, maxvalue, form.Handle)
        Return True
    End Function
End Class