
namespace ISBGroup.Forms
{
    partial class AutoTargetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTargetForm));
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.textBox_before = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.comboBox_locationName = new Moonbyte.MaterialFramework.Controls.MaterialComboBox();
            this.comboBox_contains = new Moonbyte.MaterialFramework.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_from
            // 
            this.textBox_from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_from.ForeColor = System.Drawing.Color.White;
            this.textBox_from.Location = new System.Drawing.Point(84, 134);
            this.textBox_from.Multiline = true;
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(100, 20);
            this.textBox_from.TabIndex = 0;
            // 
            // textBox_before
            // 
            this.textBox_before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_before.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_before.ForeColor = System.Drawing.Color.White;
            this.textBox_before.Location = new System.Drawing.Point(193, 134);
            this.textBox_before.Multiline = true;
            this.textBox_before.Name = "textBox_before";
            this.textBox_before.Size = new System.Drawing.Size(100, 20);
            this.textBox_before.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.ForeColor = System.Drawing.Color.White;
            this.textBox_name.Location = new System.Drawing.Point(85, 177);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(207, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "От (какой цели)";
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(128)))), ((int)(((byte)(229)))));
            this.button_apply.FlatAppearance.BorderSize = 0;
            this.button_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apply.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_apply.ForeColor = System.Drawing.Color.White;
            this.button_apply.Location = new System.Drawing.Point(85, 204);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(370, 23);
            this.button_apply.TabIndex = 13;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = false;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "До (какой цели)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Расположение обращения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Обращение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(297, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Содержимое";
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(566, 45);
            this.pictureBox_Hat.TabIndex = 35;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // comboBox_locationName
            // 
            this.comboBox_locationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_locationName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_locationName.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_locationName.ButtonColorClicked = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_locationName.ButtonMouseOverColor = System.Drawing.Color.White;
            this.comboBox_locationName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_locationName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_locationName.FontColor = System.Drawing.Color.White;
            this.comboBox_locationName.ForeColor = System.Drawing.Color.White;
            this.comboBox_locationName.FormattingEnabled = true;
            this.comboBox_locationName.Items.AddRange(new object[] {
            "Начало",
            "Конец"});
            this.comboBox_locationName.Location = new System.Drawing.Point(299, 132);
            this.comboBox_locationName.Name = "comboBox_locationName";
            this.comboBox_locationName.Size = new System.Drawing.Size(156, 23);
            this.comboBox_locationName.TabIndex = 36;
            // 
            // comboBox_contains
            // 
            this.comboBox_contains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_contains.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_contains.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_contains.ButtonColorClicked = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.comboBox_contains.ButtonMouseOverColor = System.Drawing.Color.White;
            this.comboBox_contains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_contains.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_contains.FontColor = System.Drawing.Color.White;
            this.comboBox_contains.ForeColor = System.Drawing.Color.White;
            this.comboBox_contains.FormattingEnabled = true;
            this.comboBox_contains.Items.AddRange(new object[] {
            "Текст",
            "Рейд (смайлы)",
            "Текст+фото",
            "Текст+видео"});
            this.comboBox_contains.Location = new System.Drawing.Point(299, 175);
            this.comboBox_contains.Name = "comboBox_contains";
            this.comboBox_contains.Size = new System.Drawing.Size(156, 23);
            this.comboBox_contains.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(101, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 36);
            this.label5.TabIndex = 38;
            this.label5.Text = "Автоцели — функция помогает автоматически указать\r\nбольшое количество целей.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(532, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 39;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // AutoTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(566, 274);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_contains);
            this.Controls.Add(this.comboBox_locationName);
            this.Controls.Add(this.pictureBox_Hat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_before);
            this.Controls.Add(this.textBox_from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoTargetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB Group :: Автоцели";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.TextBox textBox_before;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private Moonbyte.MaterialFramework.Controls.MaterialComboBox comboBox_locationName;
        private Moonbyte.MaterialFramework.Controls.MaterialComboBox comboBox_contains;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}