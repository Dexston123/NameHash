namespace ProjectForms
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CBCoins = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxHashrate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelMoney = new System.Windows.Forms.Label();
            this.LabelCoin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Calculate = new System.Windows.Forms.Button();
            this.Restet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(869, 294);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CBCoins);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBoxHashrate);
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 215);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Coin";
            // 
            // CBCoins
            // 
            this.CBCoins.FormattingEnabled = true;
            this.CBCoins.Items.AddRange(new object[] {
            "Ethereum",
            "Ravencoin",
            "Monero"});
            this.CBCoins.Location = new System.Drawing.Point(184, 148);
            this.CBCoins.Name = "CBCoins";
            this.CBCoins.Size = new System.Drawing.Size(111, 21);
            this.CBCoins.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hashrate";
            // 
            // TextBoxHashrate
            // 
            this.TextBoxHashrate.Location = new System.Drawing.Point(184, 44);
            this.TextBoxHashrate.Name = "TextBoxHashrate";
            this.TextBoxHashrate.Size = new System.Drawing.Size(90, 20);
            this.TextBoxHashrate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LabelMoney);
            this.panel2.Controls.Add(this.LabelCoin);
            this.panel2.Location = new System.Drawing.Point(467, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 215);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Daily coin Mined";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daily Profit";
            // 
            // LabelMoney
            // 
            this.LabelMoney.AutoSize = true;
            this.LabelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMoney.ForeColor = System.Drawing.Color.White;
            this.LabelMoney.Location = new System.Drawing.Point(218, 144);
            this.LabelMoney.Name = "LabelMoney";
            this.LabelMoney.Size = new System.Drawing.Size(70, 25);
            this.LabelMoney.TabIndex = 1;
            this.LabelMoney.Text = "label8";
            // 
            // LabelCoin
            // 
            this.LabelCoin.AutoSize = true;
            this.LabelCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCoin.ForeColor = System.Drawing.Color.White;
            this.LabelCoin.Location = new System.Drawing.Point(218, 39);
            this.LabelCoin.Name = "LabelCoin";
            this.LabelCoin.Size = new System.Drawing.Size(70, 25);
            this.LabelCoin.TabIndex = 0;
            this.LabelCoin.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Calculate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Restet, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(869, 95);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Calculate
            // 
            this.Calculate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculate.BackgroundImage")));
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(278, 27);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(126, 40);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Restet
            // 
            this.Restet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Restet.BackColor = System.Drawing.Color.Transparent;
            this.Restet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Restet.BackgroundImage")));
            this.Restet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Restet.ForeColor = System.Drawing.Color.White;
            this.Restet.Location = new System.Drawing.Point(464, 27);
            this.Restet.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Restet.Name = "Restet";
            this.Restet.Size = new System.Drawing.Size(117, 40);
            this.Restet.TabIndex = 1;
            this.Restet.Text = "Reset";
            this.Restet.UseVisualStyleBackColor = false;
            this.Restet.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxHashrate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Restet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBCoins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelMoney;
        private System.Windows.Forms.Label LabelCoin;
    }
}