
namespace ISBGroup.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_flooderTarget = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label_countTarget = new System.Windows.Forms.Label();
            this.label_workbot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_licence = new System.Windows.Forms.Label();
            this.label_TitleGr = new System.Windows.Forms.Label();
            this.button_actionLog = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_GetChat = new System.Windows.Forms.Button();
            this.button_autoSettingsLongPoll = new System.Windows.Forms.Button();
            this.button_autoTarget = new System.Windows.Forms.Button();
            this.button_autoUpdater = new System.Windows.Forms.Button();
            this.button_charity = new System.Windows.Forms.Button();
            this.button_faq = new System.Windows.Forms.Button();
            this.button_websiteProject = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Delay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SourcePhrases = new Moonbyte.MaterialFramework.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_AllTarget = new MultiBot.Controls.CheckBoxCustom();
            this.checkBox_modeAutoans = new MultiBot.Controls.CheckBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderTarget)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Informations";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_flooderTarget
            // 
            this.dataGridView_flooderTarget.AllowUserToResizeColumns = false;
            this.dataGridView_flooderTarget.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_flooderTarget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_flooderTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flooderTarget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView_flooderTarget.Location = new System.Drawing.Point(164, 143);
            this.dataGridView_flooderTarget.Name = "dataGridView_flooderTarget";
            this.dataGridView_flooderTarget.RowHeadersVisible = false;
            this.dataGridView_flooderTarget.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_flooderTarget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_flooderTarget.Size = new System.Drawing.Size(543, 240);
            this.dataGridView_flooderTarget.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID чата";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Расположение";
            this.Column2.Items.AddRange(new object[] {
            "Начало",
            "Конец"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Обращение";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "Содержимое";
            this.Column3.Items.AddRange(new object[] {
            "Текст",
            "Рейд (смайлы)",
            "Текст+фото",
            "Текст+видео"});
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 118;
            // 
            // label_countTarget
            // 
            this.label_countTarget.AutoSize = true;
            this.label_countTarget.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_countTarget.ForeColor = System.Drawing.Color.Magenta;
            this.label_countTarget.Location = new System.Drawing.Point(8, 23);
            this.label_countTarget.Name = "label_countTarget";
            this.label_countTarget.Size = new System.Drawing.Size(103, 17);
            this.label_countTarget.TabIndex = 10;
            this.label_countTarget.Text = "Кол-во целей: 0";
            // 
            // label_workbot
            // 
            this.label_workbot.AutoSize = true;
            this.label_workbot.BackColor = System.Drawing.Color.Transparent;
            this.label_workbot.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workbot.ForeColor = System.Drawing.Color.Gold;
            this.label_workbot.Location = new System.Drawing.Point(7, 4);
            this.label_workbot.Name = "label_workbot";
            this.label_workbot.Size = new System.Drawing.Size(146, 17);
            this.label_workbot.TabIndex = 9;
            this.label_workbot.Text = "Время работы: 00:00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.button_Back);
            this.panel2.Controls.Add(this.button_Next);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 93);
            this.panel2.TabIndex = 16;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(11, 63);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(29, 20);
            this.button_Back.TabIndex = 37;
            this.button_Back.Text = "←";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Visible = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.ForeColor = System.Drawing.Color.White;
            this.button_Next.Location = new System.Drawing.Point(118, 63);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(29, 20);
            this.button_Next.TabIndex = 36;
            this.button_Next.Text = "→";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Visible = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.label_licence);
            this.panel3.Controls.Add(this.label_TitleGr);
            this.panel3.Controls.Add(this.label_workbot);
            this.panel3.Controls.Add(this.label_countTarget);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(164, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 93);
            this.panel3.TabIndex = 17;
            // 
            // label_licence
            // 
            this.label_licence.AutoSize = true;
            this.label_licence.BackColor = System.Drawing.Color.Transparent;
            this.label_licence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_licence.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_licence.Location = new System.Drawing.Point(8, 58);
            this.label_licence.Name = "label_licence";
            this.label_licence.Size = new System.Drawing.Size(137, 15);
            this.label_licence.TabIndex = 13;
            this.label_licence.Text = "Лицензия активна до: ";
            this.label_licence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TitleGr
            // 
            this.label_TitleGr.AutoSize = true;
            this.label_TitleGr.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleGr.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_TitleGr.Location = new System.Drawing.Point(8, 41);
            this.label_TitleGr.Name = "label_TitleGr";
            this.label_TitleGr.Size = new System.Drawing.Size(194, 17);
            this.label_TitleGr.TabIndex = 12;
            this.label_TitleGr.Text = "Название сообщества: загрузка...";
            // 
            // button_actionLog
            // 
            this.button_actionLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_actionLog.FlatAppearance.BorderSize = 0;
            this.button_actionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actionLog.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_actionLog.ForeColor = System.Drawing.Color.White;
            this.button_actionLog.Location = new System.Drawing.Point(608, 46);
            this.button_actionLog.Name = "button_actionLog";
            this.button_actionLog.Size = new System.Drawing.Size(99, 20);
            this.button_actionLog.TabIndex = 22;
            this.button_actionLog.Text = "Лог действий";
            this.button_actionLog.UseVisualStyleBackColor = false;
            this.button_actionLog.Click += new System.EventHandler(this.button_actionLog_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(608, 69);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(99, 20);
            this.button_Save.TabIndex = 23;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.button_Start.FlatAppearance.BorderSize = 0;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.ForeColor = System.Drawing.Color.White;
            this.button_Start.Location = new System.Drawing.Point(608, 93);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(99, 20);
            this.button_Start.TabIndex = 24;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button_Stop.Enabled = false;
            this.button_Stop.FlatAppearance.BorderSize = 0;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stop.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Location = new System.Drawing.Point(608, 117);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(99, 20);
            this.button_Stop.TabIndex = 25;
            this.button_Stop.Text = "Стоп";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_GetChat
            // 
            this.button_GetChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_GetChat.FlatAppearance.BorderSize = 0;
            this.button_GetChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetChat.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GetChat.ForeColor = System.Drawing.Color.White;
            this.button_GetChat.Location = new System.Drawing.Point(0, 143);
            this.button_GetChat.Name = "button_GetChat";
            this.button_GetChat.Size = new System.Drawing.Size(158, 35);
            this.button_GetChat.TabIndex = 26;
            this.button_GetChat.Text = "Команды";
            this.button_GetChat.UseVisualStyleBackColor = false;
            this.button_GetChat.Click += new System.EventHandler(this.button_GetChat_Click);
            // 
            // button_autoSettingsLongPoll
            // 
            this.button_autoSettingsLongPoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_autoSettingsLongPoll.FlatAppearance.BorderSize = 0;
            this.button_autoSettingsLongPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoSettingsLongPoll.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_autoSettingsLongPoll.ForeColor = System.Drawing.Color.White;
            this.button_autoSettingsLongPoll.Location = new System.Drawing.Point(0, 184);
            this.button_autoSettingsLongPoll.Name = "button_autoSettingsLongPoll";
            this.button_autoSettingsLongPoll.Size = new System.Drawing.Size(158, 35);
            this.button_autoSettingsLongPoll.TabIndex = 27;
            this.button_autoSettingsLongPoll.Text = "Автомат. Настройка";
            this.button_autoSettingsLongPoll.UseVisualStyleBackColor = false;
            this.button_autoSettingsLongPoll.Click += new System.EventHandler(this.button_autoSettingsLongPoll_Click);
            // 
            // button_autoTarget
            // 
            this.button_autoTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_autoTarget.FlatAppearance.BorderSize = 0;
            this.button_autoTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoTarget.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_autoTarget.ForeColor = System.Drawing.Color.White;
            this.button_autoTarget.Location = new System.Drawing.Point(0, 225);
            this.button_autoTarget.Name = "button_autoTarget";
            this.button_autoTarget.Size = new System.Drawing.Size(158, 35);
            this.button_autoTarget.TabIndex = 28;
            this.button_autoTarget.Text = "Авто цели";
            this.button_autoTarget.UseVisualStyleBackColor = false;
            this.button_autoTarget.Click += new System.EventHandler(this.button_autoTarget_Click);
            // 
            // button_autoUpdater
            // 
            this.button_autoUpdater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_autoUpdater.FlatAppearance.BorderSize = 0;
            this.button_autoUpdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoUpdater.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_autoUpdater.ForeColor = System.Drawing.Color.White;
            this.button_autoUpdater.Location = new System.Drawing.Point(0, 266);
            this.button_autoUpdater.Name = "button_autoUpdater";
            this.button_autoUpdater.Size = new System.Drawing.Size(158, 35);
            this.button_autoUpdater.TabIndex = 29;
            this.button_autoUpdater.Text = "Обновление";
            this.button_autoUpdater.UseVisualStyleBackColor = false;
            this.button_autoUpdater.Click += new System.EventHandler(this.button_autoUpdater_Click);
            // 
            // button_charity
            // 
            this.button_charity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_charity.FlatAppearance.BorderSize = 0;
            this.button_charity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_charity.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_charity.ForeColor = System.Drawing.Color.White;
            this.button_charity.Location = new System.Drawing.Point(0, 307);
            this.button_charity.Name = "button_charity";
            this.button_charity.Size = new System.Drawing.Size(158, 35);
            this.button_charity.TabIndex = 30;
            this.button_charity.Text = "Расчет задержки";
            this.button_charity.UseVisualStyleBackColor = false;
            this.button_charity.Click += new System.EventHandler(this.button_charity_Click);
            // 
            // button_faq
            // 
            this.button_faq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_faq.FlatAppearance.BorderSize = 0;
            this.button_faq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_faq.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_faq.ForeColor = System.Drawing.Color.White;
            this.button_faq.Location = new System.Drawing.Point(0, 348);
            this.button_faq.Name = "button_faq";
            this.button_faq.Size = new System.Drawing.Size(158, 35);
            this.button_faq.TabIndex = 31;
            this.button_faq.Text = "F.A.Q";
            this.button_faq.UseVisualStyleBackColor = false;
            this.button_faq.Click += new System.EventHandler(this.button_faq_Click);
            // 
            // button_websiteProject
            // 
            this.button_websiteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button_websiteProject.FlatAppearance.BorderSize = 0;
            this.button_websiteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_websiteProject.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_websiteProject.ForeColor = System.Drawing.Color.White;
            this.button_websiteProject.Location = new System.Drawing.Point(0, 389);
            this.button_websiteProject.Name = "button_websiteProject";
            this.button_websiteProject.Size = new System.Drawing.Size(158, 35);
            this.button_websiteProject.TabIndex = 32;
            this.button_websiteProject.Text = "Сайт проекта";
            this.button_websiteProject.UseVisualStyleBackColor = false;
            this.button_websiteProject.Click += new System.EventHandler(this.button_websiteProject_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(42, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Version 2.2";
            // 
            // textBox_Delay
            // 
            this.textBox_Delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_Delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Delay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Delay.ForeColor = System.Drawing.Color.White;
            this.textBox_Delay.Location = new System.Drawing.Point(164, 404);
            this.textBox_Delay.Multiline = true;
            this.textBox_Delay.Name = "textBox_Delay";
            this.textBox_Delay.Size = new System.Drawing.Size(218, 23);
            this.textBox_Delay.TabIndex = 14;
            this.textBox_Delay.Text = "900";
            this.textBox_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Delay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Интервал (мс)";
            // 
            // comboBox_SourcePhrases
            // 
            this.comboBox_SourcePhrases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_SourcePhrases.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_SourcePhrases.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_SourcePhrases.ButtonColorClicked = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_SourcePhrases.ButtonMouseOverColor = System.Drawing.Color.White;
            this.comboBox_SourcePhrases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SourcePhrases.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_SourcePhrases.FontColor = System.Drawing.Color.White;
            this.comboBox_SourcePhrases.ForeColor = System.Drawing.Color.White;
            this.comboBox_SourcePhrases.FormattingEnabled = true;
            this.comboBox_SourcePhrases.Location = new System.Drawing.Point(388, 405);
            this.comboBox_SourcePhrases.Name = "comboBox_SourcePhrases";
            this.comboBox_SourcePhrases.Size = new System.Drawing.Size(319, 23);
            this.comboBox_SourcePhrases.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(385, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Источник фраз";
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Minimize.Image")));
            this.pictureBox_Minimize.Location = new System.Drawing.Point(645, 3);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Minimize.TabIndex = 39;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(681, 3);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 38;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(715, 45);
            this.pictureBox_Hat.TabIndex = 33;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Режим автоответчика";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Писать одновременно во все чаты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AllTarget
            // 
            this.checkBox_AllTarget.AutoSize = true;
            this.checkBox_AllTarget.Location = new System.Drawing.Point(384, 433);
            this.checkBox_AllTarget.MinimumSize = new System.Drawing.Size(45, 22);
            this.checkBox_AllTarget.Name = "checkBox_AllTarget";
            this.checkBox_AllTarget.OffBackColor = System.Drawing.Color.Gray;
            this.checkBox_AllTarget.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.checkBox_AllTarget.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBox_AllTarget.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_AllTarget.Size = new System.Drawing.Size(45, 22);
            this.checkBox_AllTarget.TabIndex = 42;
            this.checkBox_AllTarget.UseVisualStyleBackColor = true;
            // 
            // checkBox_modeAutoans
            // 
            this.checkBox_modeAutoans.AutoSize = true;
            this.checkBox_modeAutoans.Location = new System.Drawing.Point(164, 433);
            this.checkBox_modeAutoans.MinimumSize = new System.Drawing.Size(45, 22);
            this.checkBox_modeAutoans.Name = "checkBox_modeAutoans";
            this.checkBox_modeAutoans.OffBackColor = System.Drawing.Color.Gray;
            this.checkBox_modeAutoans.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.checkBox_modeAutoans.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBox_modeAutoans.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_modeAutoans.Size = new System.Drawing.Size(45, 22);
            this.checkBox_modeAutoans.TabIndex = 40;
            this.checkBox_modeAutoans.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(715, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_AllTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_modeAutoans);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_SourcePhrases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Delay);
            this.Controls.Add(this.dataGridView_flooderTarget);
            this.Controls.Add(this.pictureBox_Hat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_websiteProject);
            this.Controls.Add(this.button_faq);
            this.Controls.Add(this.button_charity);
            this.Controls.Add(this.button_autoUpdater);
            this.Controls.Add(this.button_autoTarget);
            this.Controls.Add(this.button_autoSettingsLongPoll);
            this.Controls.Add(this.button_GetChat);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_actionLog);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB Group v";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderTarget)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_flooderTarget;
        private System.Windows.Forms.Label label_workbot;
        private System.Windows.Forms.Label label_countTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_actionLog;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_GetChat;
        private System.Windows.Forms.Button button_autoSettingsLongPoll;
        private System.Windows.Forms.Button button_autoTarget;
        private System.Windows.Forms.Button button_autoUpdater;
        private System.Windows.Forms.Button button_charity;
        private System.Windows.Forms.Button button_faq;
        private System.Windows.Forms.Button button_websiteProject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.TextBox textBox_Delay;
        private System.Windows.Forms.Label label2;
        private Moonbyte.MaterialFramework.Controls.MaterialComboBox comboBox_SourcePhrases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label_TitleGr;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private MultiBot.Controls.CheckBoxCustom checkBox_modeAutoans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MultiBot.Controls.CheckBoxCustom checkBox_AllTarget;
        private System.Windows.Forms.Label label_licence;
    }
}