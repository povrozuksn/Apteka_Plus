namespace Apteka_Plus
{
    partial class AdminMedicUC
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
            this.InfoMedicPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddMedicPanel = new System.Windows.Forms.Panel();
            this.NameMedicTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameClassifCB = new System.Windows.Forms.ComboBox();
            this.AddMedicButton = new System.Windows.Forms.Button();
            this.MedicPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InfoMedicPanel.SuspendLayout();
            this.AddMedicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление медикоментами";
            // 
            // InfoMedicPanel
            // 
            this.InfoMedicPanel.AutoScroll = true;
            this.InfoMedicPanel.Controls.Add(this.label3);
            this.InfoMedicPanel.Controls.Add(this.label2);
            this.InfoMedicPanel.Controls.Add(this.label1);
            this.InfoMedicPanel.Controls.Add(this.label13);
            this.InfoMedicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoMedicPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoMedicPanel.Name = "InfoMedicPanel";
            this.InfoMedicPanel.Size = new System.Drawing.Size(867, 225);
            this.InfoMedicPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название медикомента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название аптеки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Название классификатора";
            // 
            // AddMedicPanel
            // 
            this.AddMedicPanel.Controls.Add(this.NameMedicTB);
            this.AddMedicPanel.Controls.Add(this.label6);
            this.AddMedicPanel.Controls.Add(this.NameClassifCB);
            this.AddMedicPanel.Controls.Add(this.AddMedicButton);
            this.AddMedicPanel.Controls.Add(this.MedicPictureBox);
            this.AddMedicPanel.Controls.Add(this.label8);
            this.AddMedicPanel.Controls.Add(this.label5);
            this.AddMedicPanel.Controls.Add(this.label4);
            this.AddMedicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMedicPanel.Location = new System.Drawing.Point(0, 225);
            this.AddMedicPanel.Name = "AddMedicPanel";
            this.AddMedicPanel.Size = new System.Drawing.Size(867, 314);
            this.AddMedicPanel.TabIndex = 6;
            // 
            // NameMedicTB
            // 
            this.NameMedicTB.Location = new System.Drawing.Point(8, 111);
            this.NameMedicTB.Name = "NameMedicTB";
            this.NameMedicTB.Size = new System.Drawing.Size(351, 30);
            this.NameMedicTB.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Классификатор + Аптека";
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
            this.NameClassifCB.Location = new System.Drawing.Point(8, 175);
            this.NameClassifCB.Name = "NameClassifCB";
            this.NameClassifCB.Size = new System.Drawing.Size(559, 33);
            this.NameClassifCB.TabIndex = 16;
            // 
            // AddMedicButton
            // 
            this.AddMedicButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddMedicButton.Location = new System.Drawing.Point(0, 269);
            this.AddMedicButton.Name = "AddMedicButton";
            this.AddMedicButton.Size = new System.Drawing.Size(867, 45);
            this.AddMedicButton.TabIndex = 9;
            this.AddMedicButton.Text = "Добавить";
            this.AddMedicButton.UseVisualStyleBackColor = true;
            this.AddMedicButton.Click += new System.EventHandler(this.AddMedicButton_Click);
            // 
            // MedicPictureBox
            // 
            this.MedicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedicPictureBox.Location = new System.Drawing.Point(573, 48);
            this.MedicPictureBox.Name = "MedicPictureBox";
            this.MedicPictureBox.Size = new System.Drawing.Size(277, 179);
            this.MedicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedicPictureBox.TabIndex = 8;
            this.MedicPictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фото";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
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
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление медикомента";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminMedicUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddMedicPanel);
            this.Controls.Add(this.InfoMedicPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminMedicUC";
            this.Size = new System.Drawing.Size(867, 539);
            this.Load += new System.EventHandler(this.AdminMedicUC_Load);
            this.InfoMedicPanel.ResumeLayout(false);
            this.InfoMedicPanel.PerformLayout();
            this.AddMedicPanel.ResumeLayout(false);
            this.AddMedicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InfoMedicPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AddMedicPanel;
        private System.Windows.Forms.TextBox NameMedicTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NameClassifCB;
        private System.Windows.Forms.Button AddMedicButton;
        private System.Windows.Forms.PictureBox MedicPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
