namespace Apteka_Plus
{
    partial class DisignUserControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.EditLabelBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SamplePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель дизайна";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 484);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SampleLabel);
            this.tabPage1.Controls.Add(this.EditLabelBTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дизайн Надписей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(374, 120);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(174, 25);
            this.SampleLabel.TabIndex = 1;
            this.SampleLabel.Text = "Образец надписи";
            // 
            // EditLabelBTN
            // 
            this.EditLabelBTN.Location = new System.Drawing.Point(133, 120);
            this.EditLabelBTN.Name = "EditLabelBTN";
            this.EditLabelBTN.Size = new System.Drawing.Size(206, 45);
            this.EditLabelBTN.TabIndex = 0;
            this.EditLabelBTN.Text = "Изменить надпись";
            this.EditLabelBTN.UseVisualStyleBackColor = true;
            this.EditLabelBTN.Click += new System.EventHandler(this.EditLabelBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SamplePanel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дизайн Панелей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SamplePanel
            // 
            this.SamplePanel.Location = new System.Drawing.Point(383, 106);
            this.SamplePanel.Name = "SamplePanel";
            this.SamplePanel.Size = new System.Drawing.Size(393, 270);
            this.SamplePanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Образец панели";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить панель";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(900, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дизайн ТекстБоксов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(900, 446);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дизайн Кнопок";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // DisignUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisignUserControl";
            this.Size = new System.Drawing.Size(916, 515);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Button EditLabelBTN;
        private System.Windows.Forms.Panel SamplePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
