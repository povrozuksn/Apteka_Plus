namespace Apteka_Plus
{
    partial class AdminApteksUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddApteksPanel = new System.Windows.Forms.Panel();
            this.AddAptekaButton = new System.Windows.Forms.Button();
            this.AptekaPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameAptekaTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoApteksPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AdressAptekaTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddApteksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AptekaPictureBox)).BeginInit();
            this.InfoApteksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление аптеками";
            // 
            // AddApteksPanel
            // 
            this.AddApteksPanel.Controls.Add(this.AdressAptekaTB);
            this.AddApteksPanel.Controls.Add(this.label7);
            this.AddApteksPanel.Controls.Add(this.AddAptekaButton);
            this.AddApteksPanel.Controls.Add(this.AptekaPictureBox);
            this.AddApteksPanel.Controls.Add(this.label8);
            this.AddApteksPanel.Controls.Add(this.NameAptekaTB);
            this.AddApteksPanel.Controls.Add(this.label5);
            this.AddApteksPanel.Controls.Add(this.label4);
            this.AddApteksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddApteksPanel.Location = new System.Drawing.Point(0, 225);
            this.AddApteksPanel.Name = "AddApteksPanel";
            this.AddApteksPanel.Size = new System.Drawing.Size(860, 326);
            this.AddApteksPanel.TabIndex = 3;
            // 
            // AddAptekaButton
            // 
            this.AddAptekaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAptekaButton.Location = new System.Drawing.Point(0, 281);
            this.AddAptekaButton.Name = "AddAptekaButton";
            this.AddAptekaButton.Size = new System.Drawing.Size(860, 45);
            this.AddAptekaButton.TabIndex = 9;
            this.AddAptekaButton.Text = "Добавить";
            this.AddAptekaButton.UseVisualStyleBackColor = true;
            this.AddAptekaButton.Click += new System.EventHandler(this.AddAptekaButton_Click);
            // 
            // AptekaPictureBox
            // 
            this.AptekaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AptekaPictureBox.Location = new System.Drawing.Point(478, 46);
            this.AptekaPictureBox.Name = "AptekaPictureBox";
            this.AptekaPictureBox.Size = new System.Drawing.Size(277, 179);
            this.AptekaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AptekaPictureBox.TabIndex = 8;
            this.AptekaPictureBox.TabStop = false;
            this.AptekaPictureBox.Click += new System.EventHandler(this.AptekaPictureBox_Click);
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
            // NameAptekaTB
            // 
            this.NameAptekaTB.Location = new System.Drawing.Point(106, 74);
            this.NameAptekaTB.Name = "NameAptekaTB";
            this.NameAptekaTB.Size = new System.Drawing.Size(256, 30);
            this.NameAptekaTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 46);
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
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление аптек";
            // 
            // InfoApteksPanel
            // 
            this.InfoApteksPanel.AutoScroll = true;
            this.InfoApteksPanel.Controls.Add(this.label2);
            this.InfoApteksPanel.Controls.Add(this.label1);
            this.InfoApteksPanel.Controls.Add(this.label13);
            this.InfoApteksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoApteksPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoApteksPanel.Name = "InfoApteksPanel";
            this.InfoApteksPanel.Size = new System.Drawing.Size(860, 225);
            this.InfoApteksPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Название";
            // 
            // AdressAptekaTB
            // 
            this.AdressAptekaTB.Location = new System.Drawing.Point(106, 144);
            this.AdressAptekaTB.Name = "AdressAptekaTB";
            this.AdressAptekaTB.Size = new System.Drawing.Size(256, 30);
            this.AdressAptekaTB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Адрес";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminApteksUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddApteksPanel);
            this.Controls.Add(this.InfoApteksPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminApteksUC";
            this.Size = new System.Drawing.Size(860, 551);
            this.Load += new System.EventHandler(this.AdminApteksUC_Load);
            this.AddApteksPanel.ResumeLayout(false);
            this.AddApteksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AptekaPictureBox)).EndInit();
            this.InfoApteksPanel.ResumeLayout(false);
            this.InfoApteksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddApteksPanel;
        private System.Windows.Forms.TextBox AdressAptekaTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddAptekaButton;
        private System.Windows.Forms.PictureBox AptekaPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameAptekaTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel InfoApteksPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
