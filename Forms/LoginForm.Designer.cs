
namespace ISBGroup.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_copyHwid = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_hwid = new System.Windows.Forms.Label();
            this.button_Enter = new System.Windows.Forms.Button();
            this.TimerDebugger = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.link_tme = new System.Windows.Forms.Label();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_rememberMe = new MultiBot.Controls.CheckBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // button_copyHwid
            // 
            this.button_copyHwid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.button_copyHwid.FlatAppearance.BorderSize = 0;
            this.button_copyHwid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyHwid.ForeColor = System.Drawing.Color.White;
            this.button_copyHwid.Location = new System.Drawing.Point(370, 191);
            this.button_copyHwid.Name = "button_copyHwid";
            this.button_copyHwid.Size = new System.Drawing.Size(129, 23);
            this.button_copyHwid.TabIndex = 8;
            this.button_copyHwid.Text = "Копировать ключ";
            this.button_copyHwid.UseVisualStyleBackColor = false;
            this.button_copyHwid.Click += new System.EventHandler(this.button_copyHwid_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(286, 165);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(213, 20);
            this.textBox_password.TabIndex = 7;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // label_hwid
            // 
            this.label_hwid.AutoSize = true;
            this.label_hwid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hwid.ForeColor = System.Drawing.Color.White;
            this.label_hwid.Location = new System.Drawing.Point(283, 144);
            this.label_hwid.Name = "label_hwid";
            this.label_hwid.Size = new System.Drawing.Size(51, 18);
            this.label_hwid.TabIndex = 6;
            this.label_hwid.Text = "Ключ: ";
            // 
            // button_Enter
            // 
            this.button_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(128)))), ((int)(((byte)(229)))));
            this.button_Enter.FlatAppearance.BorderSize = 0;
            this.button_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Enter.ForeColor = System.Drawing.Color.White;
            this.button_Enter.Location = new System.Drawing.Point(286, 191);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(78, 23);
            this.button_Enter.TabIndex = 5;
            this.button_Enter.Text = "Вход";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // TimerDebugger
            // 
            this.TimerDebugger.Enabled = true;
            this.TimerDebugger.Interval = 2000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Авторизация";
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(538, 45);
            this.pictureBox_Hat.TabIndex = 34;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // link_tme
            // 
            this.link_tme.AutoSize = true;
            this.link_tme.BackColor = System.Drawing.Color.Transparent;
            this.link_tme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_tme.ForeColor = System.Drawing.Color.Gold;
            this.link_tme.Location = new System.Drawing.Point(475, 329);
            this.link_tme.Name = "link_tme";
            this.link_tme.Size = new System.Drawing.Size(60, 18);
            this.link_tme.TabIndex = 35;
            this.link_tme.Text = "vk-isb.ru";
            this.link_tme.Click += new System.EventHandler(this.link_tme_Click);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(503, 3);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 39;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Запомнить меня";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_rememberMe
            // 
            this.checkBox_rememberMe.AutoSize = true;
            this.checkBox_rememberMe.Location = new System.Drawing.Point(286, 220);
            this.checkBox_rememberMe.MinimumSize = new System.Drawing.Size(45, 22);
            this.checkBox_rememberMe.Name = "checkBox_rememberMe";
            this.checkBox_rememberMe.OffBackColor = System.Drawing.Color.Gray;
            this.checkBox_rememberMe.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.checkBox_rememberMe.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBox_rememberMe.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_rememberMe.Size = new System.Drawing.Size(45, 22);
            this.checkBox_rememberMe.TabIndex = 42;
            this.checkBox_rememberMe.UseVisualStyleBackColor = true;
            this.checkBox_rememberMe.CheckedChanged += new System.EventHandler(this.checkBox_rememberMe_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(538, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_rememberMe);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.link_tme);
            this.Controls.Add(this.pictureBox_Hat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_copyHwid);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_hwid);
            this.Controls.Add(this.button_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB Group v";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_copyHwid;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_hwid;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Timer TimerDebugger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private System.Windows.Forms.Label link_tme;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label2;
        private MultiBot.Controls.CheckBoxCustom checkBox_rememberMe;
    }
}