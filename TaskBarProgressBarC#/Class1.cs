using Microsoft.VisualBasic;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Windows.Forms;

namespace TaskBarProgressBarC_
{
    public partial class TaskBarProgressBar
    {
        private static Form condenatedform;
        private static readonly TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        public enum State
        {
            None,
            Normal,
            Pause,
            Error,
            Undefined
        }
        public static object SetState(State taskstate, Form form)
        {
            if (taskstate == State.None)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, form.Handle);
            }
            else if (taskstate == State.Normal)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, form.Handle);
            }
            else if (taskstate == State.Pause)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused, form.Handle);
            }
            else if (taskstate == State.Error)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Error, form.Handle);
            }
            else if (taskstate == State.Undefined)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate, form.Handle);
            }
            condenatedform = form;
            return condenatedform;
        }
        public static bool SetProgress(int value, int maxvalue)
        {
            try
            {
                windowsTaskbar.SetProgressValue(value, maxvalue, condenatedform.Handle);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "No se inicio el estado!");
            }
            return true;
        }
        public static bool SetProgress(int value, int maxvalue, Form form, State taskstate)
        {
            if (taskstate == State.None)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, form.Handle);
            }
            else if (taskstate == State.Normal)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, form.Handle);
            }
            else if (taskstate == State.Pause)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused, form.Handle);
            }
            else if (taskstate == State.Error)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Error, form.Handle);
            }
            else if (taskstate == State.Undefined)
            {
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate, form.Handle);
            }
            windowsTaskbar.SetProgressValue(value, maxvalue, form.Handle);
            return true;
        }
    }
}