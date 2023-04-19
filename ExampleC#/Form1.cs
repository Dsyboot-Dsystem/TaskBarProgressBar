using System;
using System.Windows.Forms;
using TaskBarProgressBarC_;

namespace ExampleC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                TaskBarProgressBar.SetState(TaskBarProgressBar.State.None, this);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                TaskBarProgressBar.SetState(TaskBarProgressBar.State.Normal, this);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                TaskBarProgressBar.SetState(TaskBarProgressBar.State.Pause, this);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                TaskBarProgressBar.SetState(TaskBarProgressBar.State.Error, this);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                TaskBarProgressBar.SetState(TaskBarProgressBar.State.Undefined, this);
            }
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            TaskBarProgressBar.SetProgress(trackBar1.Value, trackBar1.Maximum);
            label2.Text = "Value: " + trackBar1.Value;
        }
    }
}
