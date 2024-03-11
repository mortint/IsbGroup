using System;
using System.Windows.Forms;

namespace ISBGroup.Forms
{
    public partial class AutoTargetForm : Form
    {
        public DataGridView DataGridView;
        public AutoTargetForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Установка автоматических целей в DataGrid по выбранным параметрам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_apply_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();

            if (int.TryParse(textBox_from.Text, out int from) && int.TryParse(textBox_before.Text, out int before))
            {
                try
                {
                    for (int i = from; i <= before; i++)
                    {
                        DataGridView.Rows.Add(
                            $"chat={i}",
                            comboBox_locationName.Text,
                            textBox_name.Text,
                            comboBox_contains.Text);
                    }

                    LogForm.PushToLog("Автоцели применены");
                    Close();
                }
                catch (Exception ex)
                {
                    LogForm.PushToLog("[Автоцели]: " + ex.Message);
                }
            }
            else
            {
                LogForm.PushToLog("[Автоцели]: Ошибка ввода чисел");
            }
        }

        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
