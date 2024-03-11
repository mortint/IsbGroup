using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ISBGroup.Forms
{
    public partial class UpdaterForm : Form
    {
        public UpdaterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события щелчка мыши на изображении pictureBox_Hat.
        /// </summary>
        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }

        private void button_checkUpdate_Click(object sender, EventArgs e)
        {
            // Указать свой путь до сервера
            var url = "https://domains.ru";

            MessageBox.Show("Автоматические обновления отключены", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var wc = new WebClient();

            var response = wc.UploadString($"{url}/api/updater/update.php?v=" + Application.ProductVersion, "GET");

            if (response.ToLower().Contains("last"))
            {
                MessageBox.Show("У Вас последняя версия приложения!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Доступна новая версия приложения! Скачать?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.CreateDirectory("Update");

                    var downloadFileLink = $"{url}/api/updater/app/isbgroup.rar";
                    var path = "Update\\ISB Group.rar";
                    wc.DownloadFile(url, path);

                    MessageBox.Show("Обновление скачано и находится по пути: " + path, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
