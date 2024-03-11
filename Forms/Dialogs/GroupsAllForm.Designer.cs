namespace ISBGroup.Forms.Dialogs
{
    partial class GroupsAllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsAllForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.dataGridView_groups = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(491, 4);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 40;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(528, 45);
            this.pictureBox_Hat.TabIndex = 39;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // dataGridView_groups
            // 
            this.dataGridView_groups.AllowUserToAddRows = false;
            this.dataGridView_groups.AllowUserToDeleteRows = false;
            this.dataGridView_groups.AllowUserToResizeColumns = false;
            this.dataGridView_groups.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_groups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_groups.Location = new System.Drawing.Point(8, 82);
            this.dataGridView_groups.Name = "dataGridView_groups";
            this.dataGridView_groups.ReadOnly = true;
            this.dataGridView_groups.RowHeadersVisible = false;
            this.dataGridView_groups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_groups.Size = new System.Drawing.Size(513, 236);
            this.dataGridView_groups.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название сообщества";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Токен";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 310;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(96, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Здесь список всех загруженных сообществ";
            // 
            // GroupsAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.dataGridView_groups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.pictureBox_Hat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupsAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загруженные сообщества";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView dataGridView_groups;
        private System.Windows.Forms.Label label1;
    }
}