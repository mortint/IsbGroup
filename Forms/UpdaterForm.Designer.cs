namespace ISBGroup.Forms
{
    partial class UpdaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterForm));
            this.pictureBox_Hat = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.button_checkUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Hat
            // 
            this.pictureBox_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hat.Image")));
            this.pictureBox_Hat.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hat.Name = "pictureBox_Hat";
            this.pictureBox_Hat.Size = new System.Drawing.Size(451, 45);
            this.pictureBox_Hat.TabIndex = 36;
            this.pictureBox_Hat.TabStop = false;
            this.pictureBox_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hat_MouseDown);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(415, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 40;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // button_checkUpdate
            // 
            this.button_checkUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(128)))), ((int)(((byte)(229)))));
            this.button_checkUpdate.FlatAppearance.BorderSize = 0;
            this.button_checkUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkUpdate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_checkUpdate.ForeColor = System.Drawing.Color.White;
            this.button_checkUpdate.Location = new System.Drawing.Point(44, 116);
            this.button_checkUpdate.Name = "button_checkUpdate";
            this.button_checkUpdate.Size = new System.Drawing.Size(370, 23);
            this.button_checkUpdate.TabIndex = 41;
            this.button_checkUpdate.Text = "Проверить наличие обновления";
            this.button_checkUpdate.UseVisualStyleBackColor = false;
            this.button_checkUpdate.Click += new System.EventHandler(this.button_checkUpdate_Click);
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(451, 225);
            this.Controls.Add(this.button_checkUpdate);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.pictureBox_Hat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Hat;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Button button_checkUpdate;
    }
}