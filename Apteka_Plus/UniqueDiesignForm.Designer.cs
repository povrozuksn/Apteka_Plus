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
            // UniqueDiesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 440);
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
    }
}