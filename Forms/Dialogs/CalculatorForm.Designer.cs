namespace ISBGroup.Forms.Dialogs
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.textBox_countChats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBar_countChats = new Moonbyte.MaterialFramework.Controls.MaterialTrackBar();
            this.TrackBar_Delay = new Moonbyte.MaterialFramework.Controls.MaterialTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(633, 45);
            this.pictureBox_Hat.TabIndex = 40;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(595, 4);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 41;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // textBox_countChats
            // 
            this.textBox_countChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_countChats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_countChats.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_countChats.ForeColor = System.Drawing.Color.White;
            this.textBox_countChats.Location = new System.Drawing.Point(356, 86);
            this.textBox_countChats.Multiline = true;
            this.textBox_countChats.Name = "textBox_countChats";
            this.textBox_countChats.Size = new System.Drawing.Size(260, 23);
            this.textBox_countChats.TabIndex = 43;
            this.textBox_countChats.Text = "0";
            this.textBox_countChats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_countChats.TextChanged += new System.EventHandler(this.textBox_countChats_TextChanged);
            this.textBox_countChats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_countChats_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Сколько чатов будет ";
            // 
            // TrackBar_countChats
            // 
            this.TrackBar_countChats.CompleteBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TrackBar_countChats.CompleteLineColor = System.Drawing.Color.MediumSlateBlue;
            this.TrackBar_countChats.LineBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TrackBar_countChats.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TrackBar_countChats.Location = new System.Drawing.Point(12, 85);
            this.TrackBar_countChats.MaxValue = 300;
            this.TrackBar_countChats.Name = "TrackBar_countChats";
            this.TrackBar_countChats.Opacity = 100;
            this.TrackBar_countChats.Size = new System.Drawing.Size(338, 24);
            this.TrackBar_countChats.TabIndex = 45;
            this.TrackBar_countChats.TractBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.TrackBar_countChats.TractColor = System.Drawing.Color.Gainsboro;
            this.TrackBar_countChats.TractColorBorderMouseClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TrackBar_countChats.TractColorMouseClick = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TrackBar_countChats.TractColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TrackBar_countChats.TractColorMouseOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.TrackBar_countChats.Value = 1;
            this.TrackBar_countChats.ValueChanged += new System.EventHandler<Moonbyte.MaterialFramework.Events.TrackBarValueChangedArgs>(this.TrackBar_countChats_ValueChanged);
            // 
            // TrackBar_Delay
            // 
            this.TrackBar_Delay.CompleteBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TrackBar_Delay.CompleteLineColor = System.Drawing.Color.MediumSlateBlue;
            this.TrackBar_Delay.LineBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TrackBar_Delay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TrackBar_Delay.Location = new System.Drawing.Point(12, 141);
            this.TrackBar_Delay.MaxValue = 1000;
            this.TrackBar_Delay.Name = "TrackBar_Delay";
            this.TrackBar_Delay.Opacity = 100;
            this.TrackBar_Delay.Size = new System.Drawing.Size(338, 24);
            this.TrackBar_Delay.TabIndex = 46;
            this.TrackBar_Delay.TractBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.TrackBar_Delay.TractColor = System.Drawing.Color.Gainsboro;
            this.TrackBar_Delay.TractColorBorderMouseClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TrackBar_Delay.TractColorMouseClick = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TrackBar_Delay.TractColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TrackBar_Delay.TractColorMouseOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.TrackBar_Delay.Value = 1;
            this.TrackBar_Delay.ValueChanged += new System.EventHandler<Moonbyte.MaterialFramework.Events.TrackBarValueChangedArgs>(this.TrackBar_Delay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Какой интервал в чатах должен быть (мин)";
            // 
            // textBox_Delay
            // 
            this.textBox_Delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.textBox_Delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Delay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Delay.ForeColor = System.Drawing.Color.White;
            this.textBox_Delay.Location = new System.Drawing.Point(356, 142);
            this.textBox_Delay.Multiline = true;
            this.textBox_Delay.Name = "textBox_Delay";
            this.textBox_Delay.Size = new System.Drawing.Size(260, 23);
            this.textBox_Delay.TabIndex = 48;
            this.textBox_Delay.Text = "0";
            this.textBox_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Delay.TextChanged += new System.EventHandler(this.textBox_Delay_TextChanged);
            this.textBox_Delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_countChats_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Установите интервал 0 мс.";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(633, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackBar_Delay);
            this.Controls.Add(this.TrackBar_countChats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_countChats);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.pictureBox_Hat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет задержки :: ISB Group";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.TextBox textBox_countChats;
        private System.Windows.Forms.Label label1;
        private Moonbyte.MaterialFramework.Controls.MaterialTrackBar TrackBar_countChats;
        private Moonbyte.MaterialFramework.Controls.MaterialTrackBar TrackBar_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Delay;
        private System.Windows.Forms.Label label3;
    }
}