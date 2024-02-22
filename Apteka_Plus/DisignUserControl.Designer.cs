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
            this.EditPanelBTN = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EditTextBoxBTN2 = new System.Windows.Forms.Button();
            this.SamplTextBox = new System.Windows.Forms.TextBox();
            this.EditTextBoxBTN1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.EditButtonBTN2 = new System.Windows.Forms.Button();
            this.EditButtonBTN1 = new System.Windows.Forms.Button();
            this.SamplButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.SampleLabel.Location = new System.Drawing.Point(400, 120);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(174, 25);
            this.SampleLabel.TabIndex = 1;
            this.SampleLabel.Text = "Образец надписи";
            // 
            // EditLabelBTN
            // 
            this.EditLabelBTN.Location = new System.Drawing.Point(100, 120);
            this.EditLabelBTN.Name = "EditLabelBTN";
            this.EditLabelBTN.Size = new System.Drawing.Size(250, 45);
            this.EditLabelBTN.TabIndex = 0;
            this.EditLabelBTN.Text = "Изменить надпись";
            this.EditLabelBTN.UseVisualStyleBackColor = true;
            this.EditLabelBTN.Click += new System.EventHandler(this.EditLabelBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SamplePanel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.EditPanelBTN);
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
            this.SamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SamplePanel.Location = new System.Drawing.Point(405, 148);
            this.SamplePanel.Name = "SamplePanel";
            this.SamplePanel.Size = new System.Drawing.Size(371, 228);
            this.SamplePanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Образец панели";
            // 
            // EditPanelBTN
            // 
            this.EditPanelBTN.Location = new System.Drawing.Point(100, 120);
            this.EditPanelBTN.Name = "EditPanelBTN";
            this.EditPanelBTN.Size = new System.Drawing.Size(250, 45);
            this.EditPanelBTN.TabIndex = 2;
            this.EditPanelBTN.Text = "Изменить панель";
            this.EditPanelBTN.UseVisualStyleBackColor = true;
            this.EditPanelBTN.Click += new System.EventHandler(this.EditPanelBTN_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EditTextBoxBTN2);
            this.tabPage3.Controls.Add(this.SamplTextBox);
            this.tabPage3.Controls.Add(this.EditTextBoxBTN1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(900, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дизайн ТекстБоксов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EditTextBoxBTN2
            // 
            this.EditTextBoxBTN2.Location = new System.Drawing.Point(100, 180);
            this.EditTextBoxBTN2.Name = "EditTextBoxBTN2";
            this.EditTextBoxBTN2.Size = new System.Drawing.Size(250, 45);
            this.EditTextBoxBTN2.TabIndex = 6;
            this.EditTextBoxBTN2.Text = "Изменить Цвет";
            this.EditTextBoxBTN2.UseVisualStyleBackColor = true;
            this.EditTextBoxBTN2.Click += new System.EventHandler(this.EditTextBoxBTN2_Click);
            // 
            // SamplTextBox
            // 
            this.SamplTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SamplTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SamplTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SamplTextBox.Location = new System.Drawing.Point(400, 120);
            this.SamplTextBox.Name = "SamplTextBox";
            this.SamplTextBox.Size = new System.Drawing.Size(248, 30);
            this.SamplTextBox.TabIndex = 5;
            this.SamplTextBox.Text = "Образец ТекстБокса";
            // 
            // EditTextBoxBTN1
            // 
            this.EditTextBoxBTN1.Location = new System.Drawing.Point(100, 120);
            this.EditTextBoxBTN1.Name = "EditTextBoxBTN1";
            this.EditTextBoxBTN1.Size = new System.Drawing.Size(250, 45);
            this.EditTextBoxBTN1.TabIndex = 0;
            this.EditTextBoxBTN1.Text = "Изменить Текст";
            this.EditTextBoxBTN1.UseVisualStyleBackColor = true;
            this.EditTextBoxBTN1.Click += new System.EventHandler(this.EditTextBoxBTN1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SamplButton);
            this.tabPage4.Controls.Add(this.EditButtonBTN2);
            this.tabPage4.Controls.Add(this.EditButtonBTN1);
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
            // EditButtonBTN2
            // 
            this.EditButtonBTN2.Location = new System.Drawing.Point(100, 180);
            this.EditButtonBTN2.Name = "EditButtonBTN2";
            this.EditButtonBTN2.Size = new System.Drawing.Size(250, 45);
            this.EditButtonBTN2.TabIndex = 8;
            this.EditButtonBTN2.Text = "Изменить Цвет";
            this.EditButtonBTN2.UseVisualStyleBackColor = true;
            this.EditButtonBTN2.Click += new System.EventHandler(this.EditButtonBTN2_Click);
            // 
            // EditButtonBTN1
            // 
            this.EditButtonBTN1.Location = new System.Drawing.Point(100, 120);
            this.EditButtonBTN1.Name = "EditButtonBTN1";
            this.EditButtonBTN1.Size = new System.Drawing.Size(250, 45);
            this.EditButtonBTN1.TabIndex = 7;
            this.EditButtonBTN1.Text = "Изменить Текст";
            this.EditButtonBTN1.UseVisualStyleBackColor = true;
            this.EditButtonBTN1.Click += new System.EventHandler(this.EditButtonBTN1_Click);
            // 
            // SamplButton
            // 
            this.SamplButton.Location = new System.Drawing.Point(429, 121);
            this.SamplButton.Name = "SamplButton";
            this.SamplButton.Size = new System.Drawing.Size(222, 42);
            this.SamplButton.TabIndex = 9;
            this.SamplButton.Text = "Образец кнопки";
            this.SamplButton.UseVisualStyleBackColor = true;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.Button EditPanelBTN;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox SamplTextBox;
        private System.Windows.Forms.Button EditTextBoxBTN1;
        private System.Windows.Forms.Button EditTextBoxBTN2;
        private System.Windows.Forms.Button SamplButton;
        private System.Windows.Forms.Button EditButtonBTN2;
        private System.Windows.Forms.Button EditButtonBTN1;
    }
}
