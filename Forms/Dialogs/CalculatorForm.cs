using System;
using System.Windows.Forms;

namespace ISBGroup.Forms.Dialogs
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void TrackBar_countChats_ValueChanged(object sender, Moonbyte.MaterialFramework.Events.TrackBarValueChangedArgs e)
        {
            textBox_countChats.Text = TrackBar_countChats.Value.ToString();

            label3.Text = Counter(TrackBar_Delay.Value, TrackBar_countChats.Value);
        }

        private void textBox_countChats_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TrackBar_countChats.Value = int.Parse(textBox_countChats.Text);

                if (int.Parse(textBox_countChats.Text) > 300)
                    textBox_countChats.Text = "300";
            }
            catch
            {
                textBox_countChats.Text = "0";
                TrackBar_countChats.Value = 0;
            }

            label3.Text = Counter(TrackBar_Delay.Value, TrackBar_countChats.Value);
        }
        /// <summary>
        /// Метод для расчета и возврата значения счетчика.
        /// </summary>
        public string Counter(long delay, long count)
        {
            try
            {
                var counter = delay * 60000 / count;

                return "Установите интервал " + counter + " мс.";
            }
            catch
            {
                return "Установите интервал 0 мс.";
            }
        }
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }
        /// <summary>
        /// Обработчик изменения текста в поле ввода количества чатов.
        /// Обновляет значение трекбара и метку с результатом.
        /// </summary>
        private void textBox_countChats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// Обработчик изменения значения трекбара для количества чатов.
        /// Обновляет текстовое поле и метку с результатом.
        /// </summary>
        private void TrackBar_Delay_ValueChanged(object sender, Moonbyte.MaterialFramework.Events.TrackBarValueChangedArgs e)
        {
            textBox_Delay.Text = TrackBar_Delay.Value.ToString();
            label3.Text = Counter(TrackBar_Delay.Value, TrackBar_countChats.Value);
        }

        private void textBox_Delay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    TrackBar_Delay.Value = int.Parse(textBox_Delay.Text);
                    if (int.Parse(textBox_Delay.Text) > 1000)
                        textBox_Delay.Text = "1000";
                }
                catch
                {
                    textBox_Delay.Text = "0";
                    TrackBar_Delay.Value = 0;
                }
            }
            catch
            {

            }

            label3.Text = Counter(TrackBar_Delay.Value, TrackBar_countChats.Value);
        }
    }
}
