namespace Apteka_Plus
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Аптеки");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DisignButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.AdminFormButton = new System.Windows.Forms.Button();
            this.AuthButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.ValComboBox = new System.Windows.Forms.ComboBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.VKpictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.дизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuEditPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменениеПанелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthPanel.SuspendLayout();
            this.CopyRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VKpictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthPanel.Controls.Add(this.DisignButton);
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.AdminFormButton);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.PassTextBox);
            this.AuthPanel.Controls.Add(this.PassLabel);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.LoginLabel);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1286, 61);
            this.AuthPanel.TabIndex = 0;
            // 
            // DisignButton
            // 
            this.DisignButton.Location = new System.Drawing.Point(1118, 20);
            this.DisignButton.Name = "DisignButton";
            this.DisignButton.Size = new System.Drawing.Size(133, 33);
            this.DisignButton.TabIndex = 8;
            this.DisignButton.Text = "Дизайн";
            this.DisignButton.UseVisualStyleBackColor = true;
            this.DisignButton.Click += new System.EventHandler(this.DisignButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.SystemColors.Control;
            this.RegButton.Location = new System.Drawing.Point(777, 20);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(147, 33);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // AdminFormButton
            // 
            this.AdminFormButton.Location = new System.Drawing.Point(930, 20);
            this.AdminFormButton.Name = "AdminFormButton";
            this.AdminFormButton.Size = new System.Drawing.Size(174, 32);
            this.AdminFormButton.TabIndex = 6;
            this.AdminFormButton.Text = "Панель админа";
            this.AdminFormButton.UseVisualStyleBackColor = true;
            this.AdminFormButton.Click += new System.EventHandler(this.AdminFormButton_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(629, 20);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(142, 34);
            this.AuthButton.TabIndex = 5;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(481, 20);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(142, 30);
            this.PassTextBox.TabIndex = 4;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(314, 20);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(161, 25);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Введите пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(167, 22);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(141, 30);
            this.LoginTextBox.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 20);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(149, 25);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Введите логин";
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(12, 22);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(27, 25);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "   ";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(338, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(945, 498);
            this.InfoPanel.TabIndex = 1;
            this.InfoPanel.Resize += new System.EventHandler(this.InfoPanel_Resize);
            // 
            // CopyRightPanel
            // 
            this.CopyRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CopyRightPanel.Controls.Add(this.ValComboBox);
            this.CopyRightPanel.Controls.Add(this.WeatherLabel);
            this.CopyRightPanel.Controls.Add(this.VKpictureBox);
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 565);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(1286, 48);
            this.CopyRightPanel.TabIndex = 2;
            // 
            // ValComboBox
            // 
            this.ValComboBox.FormattingEnabled = true;
            this.ValComboBox.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR",
            "CNY"});
            this.ValComboBox.Location = new System.Drawing.Point(803, 11);
            this.ValComboBox.Name = "ValComboBox";
            this.ValComboBox.Size = new System.Drawing.Size(121, 33);
            this.ValComboBox.TabIndex = 2;
            this.ValComboBox.SelectedIndexChanged += new System.EventHandler(this.ValComboBox_SelectedIndexChanged);
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Location = new System.Drawing.Point(12, 14);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(64, 25);
            this.WeatherLabel.TabIndex = 1;
            this.WeatherLabel.Text = "label1";
            // 
            // VKpictureBox
            // 
            this.VKpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VKpictureBox.Image")));
            this.VKpictureBox.Location = new System.Drawing.Point(374, 2);
            this.VKpictureBox.Name = "VKpictureBox";
            this.VKpictureBox.Size = new System.Drawing.Size(48, 43);
            this.VKpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VKpictureBox.TabIndex = 0;
            this.VKpictureBox.TabStop = false;
            this.VKpictureBox.Click += new System.EventHandler(this.VKpictureBox_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.04977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.95023F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 504);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Аптеки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(329, 498);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дизайнКнопкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 28);
            // 
            // дизайнКнопкиToolStripMenuItem
            // 
            this.дизайнКнопкиToolStripMenuItem.Name = "дизайнКнопкиToolStripMenuItem";
            this.дизайнКнопкиToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.дизайнКнопкиToolStripMenuItem.Text = "Дизайн кнопки";
            this.дизайнКнопкиToolStripMenuItem.Click += new System.EventHandler(this.дизайнКнопкиToolStripMenuItem_Click);
            // 
            // contextMenuEditPanel
            // 
            this.contextMenuEditPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuEditPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменениеПанелиToolStripMenuItem});
            this.contextMenuEditPanel.Name = "contextMenuEditPanel";
            this.contextMenuEditPanel.Size = new System.Drawing.Size(214, 28);
            // 
            // изменениеПанелиToolStripMenuItem
            // 
            this.изменениеПанелиToolStripMenuItem.Name = "изменениеПанелиToolStripMenuItem";
            this.изменениеПанелиToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.изменениеПанелиToolStripMenuItem.Text = "Изменение панели";
            this.изменениеПанелиToolStripMenuItem.Click += new System.EventHandler(this.изменениеПанелиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CopyRightPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.CopyRightPanel.ResumeLayout(false);
            this.CopyRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VKpictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel CopyRightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AdminFormButton;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DisignButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дизайнКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditPanel;
        private System.Windows.Forms.ToolStripMenuItem изменениеПанелиToolStripMenuItem;
        public System.Windows.Forms.PictureBox VKpictureBox;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.ComboBox ValComboBox;
    }
}

