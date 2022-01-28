using ProjectLibray;

namespace ProjectForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AdvancedSettingsButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SettingsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderLabel1 = new System.Windows.Forms.Label();
            this.HeaderLabel2 = new System.Windows.Forms.Label();
            this.ListLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OptionTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OptionLabel1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.OptionTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AlgorythmComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel2 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CoinComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel3 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.StratumTextBox = new System.Windows.Forms.TextBox();
            this.OptionLabel4 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.RigNameTextBox = new System.Windows.Forms.TextBox();
            this.OptionLabel5 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.OptionLabel6 = new System.Windows.Forms.Label();
            this.ListLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OptionTableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.OptionLabel7 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel8 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel9 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel10 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.WorkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel11 = new System.Windows.Forms.Label();
            this.OptionTableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.IsVisibleComboBox = new System.Windows.Forms.ComboBox();
            this.OptionLabel12 = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            this.ButtonLayoutPanel.SuspendLayout();
            this.SettingsLayoutPanel.SuspendLayout();
            this.ListLayoutPanel1.SuspendLayout();
            this.OptionTableLayoutPanel1.SuspendLayout();
            this.OptionTableLayoutPanel2.SuspendLayout();
            this.OptionTableLayoutPanel3.SuspendLayout();
            this.OptionTableLayoutPanel4.SuspendLayout();
            this.OptionTableLayoutPanel5.SuspendLayout();
            this.OptionTableLayoutPanel6.SuspendLayout();
            this.ListLayoutPanel2.SuspendLayout();
            this.OptionTableLayoutPanel7.SuspendLayout();
            this.OptionTableLayoutPanel8.SuspendLayout();
            this.OptionTableLayoutPanel9.SuspendLayout();
            this.OptionTableLayoutPanel10.SuspendLayout();
            this.OptionTableLayoutPanel11.SuspendLayout();
            this.OptionTableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AutoSize = true;
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SettingsPanel.Controls.Add(this.ButtonLayoutPanel);
            this.SettingsPanel.Controls.Add(this.SettingsLayoutPanel);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(875, 601);
            this.SettingsPanel.TabIndex = 1;
            this.SettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsPanel_Paint);
            // 
            // ButtonLayoutPanel
            // 
            this.ButtonLayoutPanel.ColumnCount = 3;
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayoutPanel.Controls.Add(this.AdvancedSettingsButton, 0, 0);
            this.ButtonLayoutPanel.Controls.Add(this.ResetButton, 0, 0);
            this.ButtonLayoutPanel.Controls.Add(this.SaveSettingsButton, 0, 0);
            this.ButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(0, 511);
            this.ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            this.ButtonLayoutPanel.RowCount = 1;
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonLayoutPanel.Size = new System.Drawing.Size(875, 90);
            this.ButtonLayoutPanel.TabIndex = 1;
            // 
            // AdvancedSettingsButton
            // 
            this.AdvancedSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdvancedSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdvancedSettingsButton.BackgroundImage")));
            this.AdvancedSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdvancedSettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdvancedSettingsButton.ForeColor = System.Drawing.Color.White;
            this.AdvancedSettingsButton.Location = new System.Drawing.Point(665, 25);
            this.AdvancedSettingsButton.Name = "AdvancedSettingsButton";
            this.AdvancedSettingsButton.Size = new System.Drawing.Size(126, 40);
            this.AdvancedSettingsButton.TabIndex = 2;
            this.AdvancedSettingsButton.Text = "Advanced Settings";
            this.AdvancedSettingsButton.UseVisualStyleBackColor = true;
            this.AdvancedSettingsButton.Click += new System.EventHandler(this.AdvancedSettingsButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetButton.BackgroundImage")));
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(373, 25);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(126, 40);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Set To Default";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveSettingsButton.BackgroundImage")));
            this.SaveSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveSettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveSettingsButton.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.Location = new System.Drawing.Point(82, 25);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(126, 40);
            this.SaveSettingsButton.TabIndex = 0;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsLayoutPanel
            // 
            this.SettingsLayoutPanel.ColumnCount = 2;
            this.SettingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsLayoutPanel.Controls.Add(this.HeaderLabel1, 0, 0);
            this.SettingsLayoutPanel.Controls.Add(this.HeaderLabel2, 1, 0);
            this.SettingsLayoutPanel.Controls.Add(this.ListLayoutPanel1, 0, 1);
            this.SettingsLayoutPanel.Controls.Add(this.ListLayoutPanel2, 1, 1);
            this.SettingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayoutPanel.Name = "SettingsLayoutPanel";
            this.SettingsLayoutPanel.RowCount = 2;
            this.SettingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SettingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.SettingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsLayoutPanel.Size = new System.Drawing.Size(875, 601);
            this.SettingsLayoutPanel.TabIndex = 0;
            // 
            // HeaderLabel1
            // 
            this.HeaderLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel1.AutoSize = true;
            this.HeaderLabel1.Location = new System.Drawing.Point(189, 38);
            this.HeaderLabel1.Name = "HeaderLabel1";
            this.HeaderLabel1.Size = new System.Drawing.Size(59, 13);
            this.HeaderLabel1.TabIndex = 0;
            this.HeaderLabel1.Text = "Mining Info";
            // 
            // HeaderLabel2
            // 
            this.HeaderLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel2.AutoSize = true;
            this.HeaderLabel2.Location = new System.Drawing.Point(626, 38);
            this.HeaderLabel2.Name = "HeaderLabel2";
            this.HeaderLabel2.Size = new System.Drawing.Size(59, 13);
            this.HeaderLabel2.TabIndex = 1;
            this.HeaderLabel2.Text = "Application";
            // 
            // ListLayoutPanel1
            // 
            this.ListLayoutPanel1.ColumnCount = 1;
            this.ListLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel1, 0, 0);
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel2, 0, 1);
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel3, 0, 2);
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel4, 0, 3);
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel5, 0, 4);
            this.ListLayoutPanel1.Controls.Add(this.OptionTableLayoutPanel6, 0, 5);
            this.ListLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.ListLayoutPanel1.Name = "ListLayoutPanel1";
            this.ListLayoutPanel1.RowCount = 6;
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel1.Size = new System.Drawing.Size(431, 431);
            this.ListLayoutPanel1.TabIndex = 2;
            // 
            // OptionTableLayoutPanel1
            // 
            this.OptionTableLayoutPanel1.ColumnCount = 2;
            this.OptionTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel1.Controls.Add(this.OptionLabel1, 0, 0);
            this.OptionTableLayoutPanel1.Controls.Add(this.AddressTextBox, 1, 0);
            this.OptionTableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.OptionTableLayoutPanel1.Name = "OptionTableLayoutPanel1";
            this.OptionTableLayoutPanel1.RowCount = 1;
            this.OptionTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.OptionTableLayoutPanel1.Size = new System.Drawing.Size(425, 65);
            this.OptionTableLayoutPanel1.TabIndex = 0;
            // 
            // OptionLabel1
            // 
            this.OptionLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel1.AutoSize = true;
            this.OptionLabel1.Location = new System.Drawing.Point(66, 26);
            this.OptionLabel1.Name = "OptionLabel1";
            this.OptionLabel1.Size = new System.Drawing.Size(79, 13);
            this.OptionLabel1.TabIndex = 0;
            this.OptionLabel1.Text = "Mining Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTextBox.Location = new System.Drawing.Point(257, 22);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(122, 20);
            this.AddressTextBox.TabIndex = 1;
            // 
            // OptionTableLayoutPanel2
            // 
            this.OptionTableLayoutPanel2.ColumnCount = 2;
            this.OptionTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel2.Controls.Add(this.AlgorythmComboBox, 0, 0);
            this.OptionTableLayoutPanel2.Controls.Add(this.OptionLabel2, 0, 0);
            this.OptionTableLayoutPanel2.Location = new System.Drawing.Point(3, 74);
            this.OptionTableLayoutPanel2.Name = "OptionTableLayoutPanel2";
            this.OptionTableLayoutPanel2.RowCount = 1;
            this.OptionTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.OptionTableLayoutPanel2.Size = new System.Drawing.Size(425, 65);
            this.OptionTableLayoutPanel2.TabIndex = 1;
            this.OptionTableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionTableLayoutPanel2_Paint);
            // 
            // AlgorythmComboBox
            // 
            this.AlgorythmComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlgorythmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorythmComboBox.FormattingEnabled = true;
            this.AlgorythmComboBox.Items.AddRange(new object[] {
            "autolykos2",
            "etchash",
            "ethash",
            "firopow",
            "kawpow",
            "mtp",
            "mtp-tcr",
            "multi",
            "octopus",
            "progpow",
            "progpow-veil",
            "progpow-veriblock",
            "progpowz",
            "tensority"});
            this.AlgorythmComboBox.Location = new System.Drawing.Point(258, 22);
            this.AlgorythmComboBox.Name = "AlgorythmComboBox";
            this.AlgorythmComboBox.Size = new System.Drawing.Size(121, 21);
            this.AlgorythmComboBox.TabIndex = 2;
            // 
            // OptionLabel2
            // 
            this.OptionLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel2.AutoSize = true;
            this.OptionLabel2.Location = new System.Drawing.Point(79, 26);
            this.OptionLabel2.Name = "OptionLabel2";
            this.OptionLabel2.Size = new System.Drawing.Size(53, 13);
            this.OptionLabel2.TabIndex = 1;
            this.OptionLabel2.Text = "Algorythm";
            // 
            // OptionTableLayoutPanel3
            // 
            this.OptionTableLayoutPanel3.ColumnCount = 2;
            this.OptionTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel3.Controls.Add(this.CoinComboBox, 0, 0);
            this.OptionTableLayoutPanel3.Controls.Add(this.OptionLabel3, 0, 0);
            this.OptionTableLayoutPanel3.Location = new System.Drawing.Point(3, 145);
            this.OptionTableLayoutPanel3.Name = "OptionTableLayoutPanel3";
            this.OptionTableLayoutPanel3.RowCount = 1;
            this.OptionTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.OptionTableLayoutPanel3.Size = new System.Drawing.Size(425, 65);
            this.OptionTableLayoutPanel3.TabIndex = 2;
            // 
            // CoinComboBox
            // 
            this.CoinComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoinComboBox.FormattingEnabled = true;
            this.CoinComboBox.Items.AddRange(new object[] {
            "ETH",
            "BTC"});
            this.CoinComboBox.Location = new System.Drawing.Point(258, 22);
            this.CoinComboBox.Name = "CoinComboBox";
            this.CoinComboBox.Size = new System.Drawing.Size(121, 21);
            this.CoinComboBox.TabIndex = 2;
            // 
            // OptionLabel3
            // 
            this.OptionLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel3.AutoSize = true;
            this.OptionLabel3.Location = new System.Drawing.Point(92, 26);
            this.OptionLabel3.Name = "OptionLabel3";
            this.OptionLabel3.Size = new System.Drawing.Size(28, 13);
            this.OptionLabel3.TabIndex = 1;
            this.OptionLabel3.Text = "Coin";
            // 
            // OptionTableLayoutPanel4
            // 
            this.OptionTableLayoutPanel4.ColumnCount = 2;
            this.OptionTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel4.Controls.Add(this.StratumTextBox, 0, 0);
            this.OptionTableLayoutPanel4.Controls.Add(this.OptionLabel4, 0, 0);
            this.OptionTableLayoutPanel4.Location = new System.Drawing.Point(3, 216);
            this.OptionTableLayoutPanel4.Name = "OptionTableLayoutPanel4";
            this.OptionTableLayoutPanel4.RowCount = 1;
            this.OptionTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel4.Size = new System.Drawing.Size(425, 65);
            this.OptionTableLayoutPanel4.TabIndex = 3;
            // 
            // StratumTextBox
            // 
            this.StratumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StratumTextBox.Location = new System.Drawing.Point(257, 22);
            this.StratumTextBox.Name = "StratumTextBox";
            this.StratumTextBox.Size = new System.Drawing.Size(122, 20);
            this.StratumTextBox.TabIndex = 2;
            // 
            // OptionLabel4
            // 
            this.OptionLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel4.AutoSize = true;
            this.OptionLabel4.Location = new System.Drawing.Point(84, 26);
            this.OptionLabel4.Name = "OptionLabel4";
            this.OptionLabel4.Size = new System.Drawing.Size(43, 13);
            this.OptionLabel4.TabIndex = 1;
            this.OptionLabel4.Text = "Stratum";
            // 
            // OptionTableLayoutPanel5
            // 
            this.OptionTableLayoutPanel5.ColumnCount = 2;
            this.OptionTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel5.Controls.Add(this.RigNameTextBox, 0, 0);
            this.OptionTableLayoutPanel5.Controls.Add(this.OptionLabel5, 0, 0);
            this.OptionTableLayoutPanel5.Location = new System.Drawing.Point(3, 287);
            this.OptionTableLayoutPanel5.Name = "OptionTableLayoutPanel5";
            this.OptionTableLayoutPanel5.RowCount = 1;
            this.OptionTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel5.Size = new System.Drawing.Size(425, 65);
            this.OptionTableLayoutPanel5.TabIndex = 4;
            // 
            // RigNameTextBox
            // 
            this.RigNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RigNameTextBox.Location = new System.Drawing.Point(257, 22);
            this.RigNameTextBox.Name = "RigNameTextBox";
            this.RigNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.RigNameTextBox.TabIndex = 2;
            // 
            // OptionLabel5
            // 
            this.OptionLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel5.AutoSize = true;
            this.OptionLabel5.Location = new System.Drawing.Point(79, 26);
            this.OptionLabel5.Name = "OptionLabel5";
            this.OptionLabel5.Size = new System.Drawing.Size(54, 13);
            this.OptionLabel5.TabIndex = 1;
            this.OptionLabel5.Text = "Rig Name";
            // 
            // OptionTableLayoutPanel6
            // 
            this.OptionTableLayoutPanel6.ColumnCount = 2;
            this.OptionTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel6.Controls.Add(this.PassTextBox, 0, 0);
            this.OptionTableLayoutPanel6.Controls.Add(this.OptionLabel6, 0, 0);
            this.OptionTableLayoutPanel6.Location = new System.Drawing.Point(3, 358);
            this.OptionTableLayoutPanel6.Name = "OptionTableLayoutPanel6";
            this.OptionTableLayoutPanel6.RowCount = 1;
            this.OptionTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel6.Size = new System.Drawing.Size(425, 70);
            this.OptionTableLayoutPanel6.TabIndex = 5;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTextBox.Location = new System.Drawing.Point(257, 25);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(122, 20);
            this.PassTextBox.TabIndex = 2;
            // 
            // OptionLabel6
            // 
            this.OptionLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel6.AutoSize = true;
            this.OptionLabel6.Location = new System.Drawing.Point(91, 28);
            this.OptionLabel6.Name = "OptionLabel6";
            this.OptionLabel6.Size = new System.Drawing.Size(30, 13);
            this.OptionLabel6.TabIndex = 1;
            this.OptionLabel6.Text = "Pass";
            // 
            // ListLayoutPanel2
            // 
            this.ListLayoutPanel2.ColumnCount = 1;
            this.ListLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel7, 0, 0);
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel8, 0, 1);
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel9, 0, 2);
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel10, 0, 3);
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel11, 0, 4);
            this.ListLayoutPanel2.Controls.Add(this.OptionTableLayoutPanel12, 0, 5);
            this.ListLayoutPanel2.Location = new System.Drawing.Point(440, 93);
            this.ListLayoutPanel2.Name = "ListLayoutPanel2";
            this.ListLayoutPanel2.RowCount = 6;
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ListLayoutPanel2.Size = new System.Drawing.Size(432, 431);
            this.ListLayoutPanel2.TabIndex = 3;
            // 
            // OptionTableLayoutPanel7
            // 
            this.OptionTableLayoutPanel7.ColumnCount = 2;
            this.OptionTableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel7.Controls.Add(this.UsernameTextBox, 0, 0);
            this.OptionTableLayoutPanel7.Controls.Add(this.OptionLabel7, 0, 0);
            this.OptionTableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.OptionTableLayoutPanel7.Name = "OptionTableLayoutPanel7";
            this.OptionTableLayoutPanel7.RowCount = 1;
            this.OptionTableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionTableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.OptionTableLayoutPanel7.Size = new System.Drawing.Size(426, 65);
            this.OptionTableLayoutPanel7.TabIndex = 0;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(258, 22);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(122, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // OptionLabel7
            // 
            this.OptionLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel7.AutoSize = true;
            this.OptionLabel7.Location = new System.Drawing.Point(79, 26);
            this.OptionLabel7.Name = "OptionLabel7";
            this.OptionLabel7.Size = new System.Drawing.Size(55, 13);
            this.OptionLabel7.TabIndex = 1;
            this.OptionLabel7.Text = "Username";
            this.OptionLabel7.Click += new System.EventHandler(this.OptionLabel7_Click);
            // 
            // OptionTableLayoutPanel8
            // 
            this.OptionTableLayoutPanel8.ColumnCount = 2;
            this.OptionTableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel8.Controls.Add(this.ThemeComboBox, 0, 0);
            this.OptionTableLayoutPanel8.Controls.Add(this.OptionLabel8, 0, 0);
            this.OptionTableLayoutPanel8.Location = new System.Drawing.Point(3, 74);
            this.OptionTableLayoutPanel8.Name = "OptionTableLayoutPanel8";
            this.OptionTableLayoutPanel8.RowCount = 1;
            this.OptionTableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel8.Size = new System.Drawing.Size(426, 65);
            this.OptionTableLayoutPanel8.TabIndex = 1;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Black",
            "White"});
            this.ThemeComboBox.Location = new System.Drawing.Point(259, 22);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThemeComboBox.TabIndex = 2;
            // 
            // OptionLabel8
            // 
            this.OptionLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel8.AutoSize = true;
            this.OptionLabel8.Location = new System.Drawing.Point(86, 26);
            this.OptionLabel8.Name = "OptionLabel8";
            this.OptionLabel8.Size = new System.Drawing.Size(40, 13);
            this.OptionLabel8.TabIndex = 1;
            this.OptionLabel8.Text = "Theme";
            // 
            // OptionTableLayoutPanel9
            // 
            this.OptionTableLayoutPanel9.ColumnCount = 2;
            this.OptionTableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel9.Controls.Add(this.LanguageComboBox, 0, 0);
            this.OptionTableLayoutPanel9.Controls.Add(this.OptionLabel9, 0, 0);
            this.OptionTableLayoutPanel9.Location = new System.Drawing.Point(3, 145);
            this.OptionTableLayoutPanel9.Name = "OptionTableLayoutPanel9";
            this.OptionTableLayoutPanel9.RowCount = 1;
            this.OptionTableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel9.Size = new System.Drawing.Size(426, 65);
            this.OptionTableLayoutPanel9.TabIndex = 2;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "English",
            "Polish",
            "Afghan"});
            this.LanguageComboBox.Location = new System.Drawing.Point(259, 22);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 21);
            this.LanguageComboBox.TabIndex = 2;
            // 
            // OptionLabel9
            // 
            this.OptionLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel9.AutoSize = true;
            this.OptionLabel9.Location = new System.Drawing.Point(79, 26);
            this.OptionLabel9.Name = "OptionLabel9";
            this.OptionLabel9.Size = new System.Drawing.Size(55, 13);
            this.OptionLabel9.TabIndex = 1;
            this.OptionLabel9.Text = "Language";
            // 
            // OptionTableLayoutPanel10
            // 
            this.OptionTableLayoutPanel10.ColumnCount = 2;
            this.OptionTableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel10.Controls.Add(this.CurrencyComboBox, 0, 0);
            this.OptionTableLayoutPanel10.Controls.Add(this.OptionLabel10, 0, 0);
            this.OptionTableLayoutPanel10.Location = new System.Drawing.Point(3, 216);
            this.OptionTableLayoutPanel10.Name = "OptionTableLayoutPanel10";
            this.OptionTableLayoutPanel10.RowCount = 1;
            this.OptionTableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel10.Size = new System.Drawing.Size(426, 65);
            this.OptionTableLayoutPanel10.TabIndex = 3;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "PLN",
            "USD",
            "EUR"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(259, 22);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyComboBox.TabIndex = 2;
            // 
            // OptionLabel10
            // 
            this.OptionLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel10.AutoSize = true;
            this.OptionLabel10.Location = new System.Drawing.Point(82, 26);
            this.OptionLabel10.Name = "OptionLabel10";
            this.OptionLabel10.Size = new System.Drawing.Size(49, 13);
            this.OptionLabel10.TabIndex = 1;
            this.OptionLabel10.Text = "Currency";
            // 
            // OptionTableLayoutPanel11
            // 
            this.OptionTableLayoutPanel11.ColumnCount = 2;
            this.OptionTableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel11.Controls.Add(this.WorkTypeComboBox, 0, 0);
            this.OptionTableLayoutPanel11.Controls.Add(this.OptionLabel11, 0, 0);
            this.OptionTableLayoutPanel11.Location = new System.Drawing.Point(3, 287);
            this.OptionTableLayoutPanel11.Name = "OptionTableLayoutPanel11";
            this.OptionTableLayoutPanel11.RowCount = 1;
            this.OptionTableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel11.Size = new System.Drawing.Size(426, 65);
            this.OptionTableLayoutPanel11.TabIndex = 4;
            // 
            // WorkTypeComboBox
            // 
            this.WorkTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkTypeComboBox.FormattingEnabled = true;
            this.WorkTypeComboBox.Items.AddRange(new object[] {
            "Efficient",
            "Gaming",
            "Max Earnings"});
            this.WorkTypeComboBox.Location = new System.Drawing.Point(259, 22);
            this.WorkTypeComboBox.Name = "WorkTypeComboBox";
            this.WorkTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.WorkTypeComboBox.TabIndex = 2;
            // 
            // OptionLabel11
            // 
            this.OptionLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel11.AutoSize = true;
            this.OptionLabel11.Location = new System.Drawing.Point(76, 26);
            this.OptionLabel11.Name = "OptionLabel11";
            this.OptionLabel11.Size = new System.Drawing.Size(60, 13);
            this.OptionLabel11.TabIndex = 1;
            this.OptionLabel11.Text = "Work Type";
            // 
            // OptionTableLayoutPanel12
            // 
            this.OptionTableLayoutPanel12.ColumnCount = 2;
            this.OptionTableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel12.Controls.Add(this.IsVisibleComboBox, 0, 0);
            this.OptionTableLayoutPanel12.Controls.Add(this.OptionLabel12, 0, 0);
            this.OptionTableLayoutPanel12.Location = new System.Drawing.Point(3, 358);
            this.OptionTableLayoutPanel12.Name = "OptionTableLayoutPanel12";
            this.OptionTableLayoutPanel12.RowCount = 1;
            this.OptionTableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionTableLayoutPanel12.Size = new System.Drawing.Size(426, 70);
            this.OptionTableLayoutPanel12.TabIndex = 5;
            // 
            // IsVisibleComboBox
            // 
            this.IsVisibleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsVisibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsVisibleComboBox.FormattingEnabled = true;
            this.IsVisibleComboBox.Items.AddRange(new object[] {
            "Visible",
            "Not Visible"});
            this.IsVisibleComboBox.Location = new System.Drawing.Point(259, 24);
            this.IsVisibleComboBox.Name = "IsVisibleComboBox";
            this.IsVisibleComboBox.Size = new System.Drawing.Size(121, 21);
            this.IsVisibleComboBox.TabIndex = 2;
            // 
            // OptionLabel12
            // 
            this.OptionLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionLabel12.AutoSize = true;
            this.OptionLabel12.Location = new System.Drawing.Point(63, 28);
            this.OptionLabel12.Name = "OptionLabel12";
            this.OptionLabel12.Size = new System.Drawing.Size(87, 13);
            this.OptionLabel12.TabIndex = 1;
            this.OptionLabel12.Text = "Console Window";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(875, 601);
            this.Controls.Add(this.SettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.SettingsPanel.ResumeLayout(false);
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.SettingsLayoutPanel.ResumeLayout(false);
            this.SettingsLayoutPanel.PerformLayout();
            this.ListLayoutPanel1.ResumeLayout(false);
            this.OptionTableLayoutPanel1.ResumeLayout(false);
            this.OptionTableLayoutPanel1.PerformLayout();
            this.OptionTableLayoutPanel2.ResumeLayout(false);
            this.OptionTableLayoutPanel2.PerformLayout();
            this.OptionTableLayoutPanel3.ResumeLayout(false);
            this.OptionTableLayoutPanel3.PerformLayout();
            this.OptionTableLayoutPanel4.ResumeLayout(false);
            this.OptionTableLayoutPanel4.PerformLayout();
            this.OptionTableLayoutPanel5.ResumeLayout(false);
            this.OptionTableLayoutPanel5.PerformLayout();
            this.OptionTableLayoutPanel6.ResumeLayout(false);
            this.OptionTableLayoutPanel6.PerformLayout();
            this.ListLayoutPanel2.ResumeLayout(false);
            this.OptionTableLayoutPanel7.ResumeLayout(false);
            this.OptionTableLayoutPanel7.PerformLayout();
            this.OptionTableLayoutPanel8.ResumeLayout(false);
            this.OptionTableLayoutPanel8.PerformLayout();
            this.OptionTableLayoutPanel9.ResumeLayout(false);
            this.OptionTableLayoutPanel9.PerformLayout();
            this.OptionTableLayoutPanel10.ResumeLayout(false);
            this.OptionTableLayoutPanel10.PerformLayout();
            this.OptionTableLayoutPanel11.ResumeLayout(false);
            this.OptionTableLayoutPanel11.PerformLayout();
            this.OptionTableLayoutPanel12.ResumeLayout(false);
            this.OptionTableLayoutPanel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TableLayoutPanel SettingsLayoutPanel;
        private System.Windows.Forms.Label HeaderLabel1;
        private System.Windows.Forms.Label HeaderLabel2;
        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.TableLayoutPanel ListLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ListLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel OptionTableLayoutPanel12;
        private System.Windows.Forms.Label OptionLabel1;
        private System.Windows.Forms.Label OptionLabel2;
        private System.Windows.Forms.Label OptionLabel3;
        private System.Windows.Forms.Label OptionLabel4;
        private System.Windows.Forms.Label OptionLabel5;
        private System.Windows.Forms.Label OptionLabel6;
        private System.Windows.Forms.Label OptionLabel7;
        private System.Windows.Forms.Label OptionLabel8;
        private System.Windows.Forms.Label OptionLabel9;
        private System.Windows.Forms.Label OptionLabel10;
        private System.Windows.Forms.Label OptionLabel11;
        private System.Windows.Forms.Label OptionLabel12;
        private System.Windows.Forms.ComboBox AlgorythmComboBox;
        private System.Windows.Forms.ComboBox CoinComboBox;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox WorkTypeComboBox;
        private System.Windows.Forms.ComboBox IsVisibleComboBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox StratumTextBox;
        private System.Windows.Forms.TextBox RigNameTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AdvancedSettingsButton;
    }
}