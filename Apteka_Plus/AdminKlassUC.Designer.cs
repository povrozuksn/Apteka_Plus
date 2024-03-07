namespace Apteka_Plus
{
    partial class AdminKlassUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddClassifPanel = new System.Windows.Forms.Panel();
            this.NameClassifCB = new System.Windows.Forms.ComboBox();
            this.NameAptekaCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddClassifButton = new System.Windows.Forms.Button();
            this.ClassifPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoClassifPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddClassifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassifPictureBox)).BeginInit();
            this.InfoClassifPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddClassifPanel
            // 
            this.AddClassifPanel.Controls.Add(this.NameClassifCB);
            this.AddClassifPanel.Controls.Add(this.NameAptekaCB);
            this.AddClassifPanel.Controls.Add(this.label7);
            this.AddClassifPanel.Controls.Add(this.AddClassifButton);
            this.AddClassifPanel.Controls.Add(this.ClassifPictureBox);
            this.AddClassifPanel.Controls.Add(this.label8);
            this.AddClassifPanel.Controls.Add(this.label5);
            this.AddClassifPanel.Controls.Add(this.label4);
            this.AddClassifPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddClassifPanel.Location = new System.Drawing.Point(0, 225);
            this.AddClassifPanel.Name = "AddClassifPanel";
            this.AddClassifPanel.Size = new System.Drawing.Size(874, 298);
            this.AddClassifPanel.TabIndex = 5;
            // 
            // NameClassifCB
            // 
            this.NameClassifCB.FormattingEnabled = true;
            this.NameClassifCB.Items.AddRange(new object[] {
            "Психотропные медикаменты",
            "Препараты местноанестезирующего действия",
            "Моче-желчегонные препараты",
            "Средства для терапии секретори",
            "Антибиотики антисептикики"});
            this.NameClassifCB.Location = new System.Drawing.Point(39, 76);
            this.NameClassifCB.Name = "NameClassifCB";
            this.NameClassifCB.Size = new System.Drawing.Size(433, 33);
            this.NameClassifCB.TabIndex = 16;
            // 
            // NameAptekaCB
            // 
            this.NameAptekaCB.FormattingEnabled = true;
            this.NameAptekaCB.Location = new System.Drawing.Point(39, 155);
            this.NameAptekaCB.Name = "NameAptekaCB";
            this.NameAptekaCB.Size = new System.Drawing.Size(252, 33);
            this.NameAptekaCB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Аптека";
            // 
            // AddClassifButton
            // 
            this.AddClassifButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddClassifButton.Location = new System.Drawing.Point(0, 253);
            this.AddClassifButton.Name = "AddClassifButton";
            this.AddClassifButton.Size = new System.Drawing.Size(874, 45);
            this.AddClassifButton.TabIndex = 9;
            this.AddClassifButton.Text = "Добавить";
            this.AddClassifButton.UseVisualStyleBackColor = true;
            this.AddClassifButton.Click += new System.EventHandler(this.AddClassifButton_Click);
            // 
            // ClassifPictureBox
            // 
            this.ClassifPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassifPictureBox.Location = new System.Drawing.Point(478, 46);
            this.ClassifPictureBox.Name = "ClassifPictureBox";
            this.ClassifPictureBox.Size = new System.Drawing.Size(277, 179);
            this.ClassifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClassifPictureBox.TabIndex = 8;
            this.ClassifPictureBox.TabStop = false;
            this.ClassifPictureBox.Click += new System.EventHandler(this.ClassifPictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фото";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление классификатора";
            // 
            // InfoClassifPanel
            // 
            this.InfoClassifPanel.AutoScroll = true;
            this.InfoClassifPanel.Controls.Add(this.label2);
            this.InfoClassifPanel.Controls.Add(this.label1);
            this.InfoClassifPanel.Controls.Add(this.label13);
            this.InfoClassifPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoClassifPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoClassifPanel.Name = "InfoClassifPanel";
            this.InfoClassifPanel.Size = new System.Drawing.Size(874, 225);
            this.InfoClassifPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название аптеки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление классификатором";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Название классификатора";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminKlassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddClassifPanel);
            this.Controls.Add(this.InfoClassifPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminKlassUC";
            this.Size = new System.Drawing.Size(874, 523);
            this.Load += new System.EventHandler(this.AdminKlassUC_Load);
            this.AddClassifPanel.ResumeLayout(false);
            this.AddClassifPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassifPictureBox)).EndInit();
            this.InfoClassifPanel.ResumeLayout(false);
            this.InfoClassifPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddClassifPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddClassifButton;
        private System.Windows.Forms.PictureBox ClassifPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel InfoClassifPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox NameAptekaCB;
        private System.Windows.Forms.ComboBox NameClassifCB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
