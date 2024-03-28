namespace Apteka_Plus
{
    partial class UniqueDiesignForm
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
            this.FontBTN = new System.Windows.Forms.Button();
            this.ColorBTN = new System.Windows.Forms.Button();
            this.SamplBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CoordsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FontBTN
            // 
            this.FontBTN.Location = new System.Drawing.Point(30, 76);
            this.FontBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FontBTN.Name = "FontBTN";
            this.FontBTN.Size = new System.Drawing.Size(239, 45);
            this.FontBTN.TabIndex = 0;
            this.FontBTN.Text = "Изменить текст";
            this.FontBTN.UseVisualStyleBackColor = true;
            this.FontBTN.Click += new System.EventHandler(this.FontBTN_Click);
            // 
            // ColorBTN
            // 
            this.ColorBTN.Location = new System.Drawing.Point(30, 142);
            this.ColorBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorBTN.Name = "ColorBTN";
            this.ColorBTN.Size = new System.Drawing.Size(239, 45);
            this.ColorBTN.TabIndex = 1;
            this.ColorBTN.Text = "Изменить цвет";
            this.ColorBTN.UseVisualStyleBackColor = true;
            this.ColorBTN.Click += new System.EventHandler(this.ColorBTN_Click);
            // 
            // SamplBTN
            // 
            this.SamplBTN.Location = new System.Drawing.Point(327, 76);
            this.SamplBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SamplBTN.Name = "SamplBTN";
            this.SamplBTN.Size = new System.Drawing.Size(174, 45);
            this.SamplBTN.TabIndex = 2;
            this.SamplBTN.Text = "Образец";
            this.SamplBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дизайн выбранной кнопки";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // CoordsTextBox
            // 
            this.CoordsTextBox.Location = new System.Drawing.Point(30, 255);
            this.CoordsTextBox.Name = "CoordsTextBox";
            this.CoordsTextBox.Size = new System.Drawing.Size(254, 30);
            this.CoordsTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Координаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размер";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(30, 317);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(254, 30);
            this.SizeTextBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(307, 255);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 92);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Применить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UniqueDiesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 440);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SamplBTN);
            this.Controls.Add(this.ColorBTN);
            this.Controls.Add(this.FontBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniqueDiesignForm";
            this.Text = "UniqueDiesignForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FontBTN;
        private System.Windows.Forms.Button ColorBTN;
        private System.Windows.Forms.Button SamplBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox CoordsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}