using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISBGroup.Forms.Dialogs
{
    public partial class GroupsAllForm : Form
    {
        public GroupsAllForm()
        {
            InitializeComponent();

            // Установка стилей для Data Grid
            dataGridView_groups.BorderStyle = BorderStyle.None;
            dataGridView_groups.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_groups.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_groups.DefaultCellStyle.SelectionBackColor = Color.FromArgb(54, 57, 62);
            dataGridView_groups.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_groups.BackgroundColor = Color.FromArgb(48, 49, 54);
            dataGridView_groups.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_groups.EnableHeadersVisualStyles = false;
            dataGridView_groups.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_groups.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 8);
            dataGridView_groups.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 49, 54);
            dataGridView_groups.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
    }
}
