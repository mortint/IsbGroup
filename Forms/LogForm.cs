using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISBGroup.Forms
{
    public partial class LogForm : Form
    {
        private static readonly LinkedList<string> Logs = new LinkedList<string>();

        public LogForm()
        {
            InitializeComponent();
            LogUpdater_Tick(null, null);
        }
        public static void PushToLog(string info)
        {
            lock (Logs)
            {
                Logs.AddFirst($"[{DateTime.Now.ToShortTimeString()}]: {info}");
            }
        }
        private void LogUpdater_Tick(object sender, EventArgs e)
        {
            lock (Logs)
            {
                richTextBox.Clear();
                foreach (string entry in Logs)
                {
                    richTextBox.Text = entry + "\n";
                }

                if (Logs.Count > 100)
                    Logs.RemoveLast();
            }
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }
    }
}
