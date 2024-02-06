namespace Apteka_Plus
{
    partial class AdminUserControl
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
            this.AdminApteksBTN = new System.Windows.Forms.Button();
            this.AdminKlassBTN = new System.Windows.Forms.Button();
            this.AdminMedicBTN = new System.Windows.Forms.Button();
            this.AdminUseraBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель администратора";
            // 
            // AdminApteksBTN
            // 
            this.AdminApteksBTN.Location = new System.Drawing.Point(93, 116);
            this.AdminApteksBTN.Name = "AdminApteksBTN";
            this.AdminApteksBTN.Size = new System.Drawing.Size(312, 54);
            this.AdminApteksBTN.TabIndex = 1;
            this.AdminApteksBTN.Text = "Управление аптеками";
            this.AdminApteksBTN.UseVisualStyleBackColor = true;
            this.AdminApteksBTN.Click += new System.EventHandler(this.AdminApteksBTN_Click);
            // 
            // AdminKlassBTN
            // 
            this.AdminKlassBTN.Location = new System.Drawing.Point(93, 176);
            this.AdminKlassBTN.Name = "AdminKlassBTN";
            this.AdminKlassBTN.Size = new System.Drawing.Size(312, 54);
            this.AdminKlassBTN.TabIndex = 2;
            this.AdminKlassBTN.Text = "Управление классификатором";
            this.AdminKlassBTN.UseVisualStyleBackColor = true;
            this.AdminKlassBTN.Click += new System.EventHandler(this.AdminKlassBTN_Click);
            // 
            // AdminMedicBTN
            // 
            this.AdminMedicBTN.Location = new System.Drawing.Point(93, 236);
            this.AdminMedicBTN.Name = "AdminMedicBTN";
            this.AdminMedicBTN.Size = new System.Drawing.Size(312, 54);
            this.AdminMedicBTN.TabIndex = 3;
            this.AdminMedicBTN.Text = "Управление медикоментами";
            this.AdminMedicBTN.UseVisualStyleBackColor = true;
            this.AdminMedicBTN.Click += new System.EventHandler(this.AdminMedicBTN_Click);
            // 
            // AdminUseraBTN
            // 
            this.AdminUseraBTN.Location = new System.Drawing.Point(93, 296);
            this.AdminUseraBTN.Name = "AdminUseraBTN";
            this.AdminUseraBTN.Size = new System.Drawing.Size(312, 54);
            this.AdminUseraBTN.TabIndex = 4;
            this.AdminUseraBTN.Text = "Управление пользователями";
            this.AdminUseraBTN.UseVisualStyleBackColor = true;
            this.AdminUseraBTN.Click += new System.EventHandler(this.AdminUseraBTN_Click);
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminUseraBTN);
            this.Controls.Add(this.AdminMedicBTN);
            this.Controls.Add(this.AdminKlassBTN);
            this.Controls.Add(this.AdminApteksBTN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(812, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminApteksBTN;
        private System.Windows.Forms.Button AdminKlassBTN;
        private System.Windows.Forms.Button AdminMedicBTN;
        private System.Windows.Forms.Button AdminUseraBTN;
    }
}
