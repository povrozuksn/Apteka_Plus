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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Психотропные медикаменты");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Препараты местноанестезирующего действия");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Моче-желчегонные препараты");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Средства для терапии секреторики");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Антибиотики/антисептики");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Аптека №1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Психотропные медикаменты");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Препараты местноанестезирующего действия");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Моче-желчегонные препараты");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Средства для терапии секреторики");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Антибиотики/антисептики");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Аптека №2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Аптеки", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1286, 61);
            this.AuthPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(429, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(854, 506);
            this.InfoPanel.TabIndex = 1;
            // 
            // CopyRightPanel
            // 
            this.CopyRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 573);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(1286, 40);
            this.CopyRightPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.18223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.81777F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 512);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Tag = "1";
            treeNode1.Text = "Психотропные медикаменты";
            treeNode2.Name = "Узел5";
            treeNode2.Tag = "2";
            treeNode2.Text = "Препараты местноанестезирующего действия";
            treeNode3.Name = "Узел6";
            treeNode3.Tag = "3";
            treeNode3.Text = "Моче-желчегонные препараты";
            treeNode4.Name = "Узел7";
            treeNode4.Tag = "4";
            treeNode4.Text = "Средства для терапии секреторики";
            treeNode5.Name = "Узел8";
            treeNode5.Tag = "5";
            treeNode5.Text = "Антибиотики/антисептики";
            treeNode6.Name = "Узел1";
            treeNode6.Tag = "1";
            treeNode6.Text = "Аптека №1";
            treeNode7.Name = "Узел9";
            treeNode7.Tag = "1";
            treeNode7.Text = "Психотропные медикаменты";
            treeNode8.Name = "Узел10";
            treeNode8.Tag = "2";
            treeNode8.Text = "Препараты местноанестезирующего действия";
            treeNode9.Name = "Узел11";
            treeNode9.Tag = "3";
            treeNode9.Text = "Моче-желчегонные препараты";
            treeNode10.Name = "Узел12";
            treeNode10.Tag = "4";
            treeNode10.Text = "Средства для терапии секреторики";
            treeNode11.Name = "Узел13";
            treeNode11.Tag = "5";
            treeNode11.Text = "Антибиотики/антисептики";
            treeNode12.Name = "Узел2";
            treeNode12.Tag = "2";
            treeNode12.Text = "Аптека №2";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "Аптеки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(420, 506);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel CopyRightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

