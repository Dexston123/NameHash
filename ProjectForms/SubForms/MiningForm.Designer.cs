using ProjectLibray;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectForms
{
    partial class MiningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiningForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RejectedCountLabel = new System.Windows.Forms.Label();
            this.TrexLabel = new System.Windows.Forms.Label();
            this.TrexLabelInfo = new System.Windows.Forms.Label();
            this.AlgorythmLabel = new System.Windows.Forms.Label();
            this.AlgorythmLabelInfo = new System.Windows.Forms.Label();
            this.UpTimeLabel = new System.Windows.Forms.Label();
            this.UpTimeLabelInfo = new System.Windows.Forms.Label();
            this.HashRateLabel = new System.Windows.Forms.Label();
            this.HashRateLabelInfo = new System.Windows.Forms.Label();
            this.AvgHourLabelInfo = new System.Windows.Forms.Label();
            this.AvgDayLabelInfo = new System.Windows.Forms.Label();
            this.AcceptedCountLabelInfo = new System.Windows.Forms.Label();
            this.RejectedCountLabelInfo = new System.Windows.Forms.Label();
            this.AvgHourLabel = new System.Windows.Forms.Label();
            this.AvgDayLabel = new System.Windows.Forms.Label();
            this.AcceptedCountLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FanSpeedLabelInfo = new System.Windows.Forms.Label();
            this.FanSpeedLabel = new System.Windows.Forms.Label();
            this.PowerLabelInfo = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.TempLabelInfo = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.GpuVendorLabelInfo = new System.Windows.Forms.Label();
            this.GpuVnedorLabel = new System.Windows.Forms.Label();
            this.GpuModelLabel = new System.Windows.Forms.Label();
            this.GpuModelLabelInfo = new System.Windows.Forms.Label();
            this.EfficiencyLabel = new System.Windows.Forms.Label();
            this.EfficiencyLabelInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MiningButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 601);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(311, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 400);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(109, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mining";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RejectedCountLabel, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.TrexLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TrexLabelInfo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AlgorythmLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.AlgorythmLabelInfo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.UpTimeLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.UpTimeLabelInfo, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.HashRateLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.HashRateLabelInfo, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.AvgHourLabelInfo, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.AvgDayLabelInfo, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.AcceptedCountLabelInfo, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.RejectedCountLabelInfo, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.AvgHourLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.AvgDayLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.AcceptedCountLabel, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 235);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // RejectedCountLabel
            // 
            this.RejectedCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RejectedCountLabel.AutoSize = true;
            this.RejectedCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RejectedCountLabel.Location = new System.Drawing.Point(19, 212);
            this.RejectedCountLabel.Name = "RejectedCountLabel";
            this.RejectedCountLabel.Size = new System.Drawing.Size(86, 13);
            this.RejectedCountLabel.TabIndex = 16;
            this.RejectedCountLabel.Text = "Rejected Shares";
            // 
            // TrexLabel
            // 
            this.TrexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrexLabel.AutoSize = true;
            this.TrexLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TrexLabel.Location = new System.Drawing.Point(48, 8);
            this.TrexLabel.Name = "TrexLabel";
            this.TrexLabel.Size = new System.Drawing.Size(28, 13);
            this.TrexLabel.TabIndex = 1;
            this.TrexLabel.Text = "Trex";
            // 
            // TrexLabelInfo
            // 
            this.TrexLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrexLabelInfo.AutoSize = true;
            this.TrexLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TrexLabelInfo.Location = new System.Drawing.Point(170, 8);
            this.TrexLabelInfo.Name = "TrexLabelInfo";
            this.TrexLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.TrexLabelInfo.TabIndex = 2;
            this.TrexLabelInfo.Text = "label5";
            // 
            // AlgorythmLabel
            // 
            this.AlgorythmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlgorythmLabel.AutoSize = true;
            this.AlgorythmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AlgorythmLabel.Location = new System.Drawing.Point(36, 37);
            this.AlgorythmLabel.Name = "AlgorythmLabel";
            this.AlgorythmLabel.Size = new System.Drawing.Size(53, 13);
            this.AlgorythmLabel.TabIndex = 3;
            this.AlgorythmLabel.Text = "Algorythm";
            // 
            // AlgorythmLabelInfo
            // 
            this.AlgorythmLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlgorythmLabelInfo.AutoSize = true;
            this.AlgorythmLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlgorythmLabelInfo.Location = new System.Drawing.Point(170, 37);
            this.AlgorythmLabelInfo.Name = "AlgorythmLabelInfo";
            this.AlgorythmLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.AlgorythmLabelInfo.TabIndex = 4;
            this.AlgorythmLabelInfo.Text = "label7";
            // 
            // UpTimeLabel
            // 
            this.UpTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpTimeLabel.AutoSize = true;
            this.UpTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UpTimeLabel.Location = new System.Drawing.Point(39, 66);
            this.UpTimeLabel.Name = "UpTimeLabel";
            this.UpTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.UpTimeLabel.TabIndex = 5;
            this.UpTimeLabel.Text = "Up Time";
            // 
            // UpTimeLabelInfo
            // 
            this.UpTimeLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpTimeLabelInfo.AutoSize = true;
            this.UpTimeLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpTimeLabelInfo.Location = new System.Drawing.Point(170, 66);
            this.UpTimeLabelInfo.Name = "UpTimeLabelInfo";
            this.UpTimeLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.UpTimeLabelInfo.TabIndex = 6;
            this.UpTimeLabelInfo.Text = "label9";
            // 
            // HashRateLabel
            // 
            this.HashRateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HashRateLabel.AutoSize = true;
            this.HashRateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HashRateLabel.Location = new System.Drawing.Point(33, 95);
            this.HashRateLabel.Name = "HashRateLabel";
            this.HashRateLabel.Size = new System.Drawing.Size(58, 13);
            this.HashRateLabel.TabIndex = 7;
            this.HashRateLabel.Text = "Hash Rate";
            // 
            // HashRateLabelInfo
            // 
            this.HashRateLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HashRateLabelInfo.AutoSize = true;
            this.HashRateLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HashRateLabelInfo.Location = new System.Drawing.Point(167, 95);
            this.HashRateLabelInfo.Name = "HashRateLabelInfo";
            this.HashRateLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.HashRateLabelInfo.TabIndex = 8;
            this.HashRateLabelInfo.Text = "label11";
            // 
            // AvgHourLabelInfo
            // 
            this.AvgHourLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgHourLabelInfo.AutoSize = true;
            this.AvgHourLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvgHourLabelInfo.Location = new System.Drawing.Point(167, 124);
            this.AvgHourLabelInfo.Name = "AvgHourLabelInfo";
            this.AvgHourLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.AvgHourLabelInfo.TabIndex = 9;
            this.AvgHourLabelInfo.Text = "label12";
            // 
            // AvgDayLabelInfo
            // 
            this.AvgDayLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgDayLabelInfo.AutoSize = true;
            this.AvgDayLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvgDayLabelInfo.Location = new System.Drawing.Point(167, 153);
            this.AvgDayLabelInfo.Name = "AvgDayLabelInfo";
            this.AvgDayLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.AvgDayLabelInfo.TabIndex = 10;
            this.AvgDayLabelInfo.Text = "label13";
            // 
            // AcceptedCountLabelInfo
            // 
            this.AcceptedCountLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptedCountLabelInfo.AutoSize = true;
            this.AcceptedCountLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AcceptedCountLabelInfo.Location = new System.Drawing.Point(167, 182);
            this.AcceptedCountLabelInfo.Name = "AcceptedCountLabelInfo";
            this.AcceptedCountLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.AcceptedCountLabelInfo.TabIndex = 11;
            this.AcceptedCountLabelInfo.Text = "label14";
            // 
            // RejectedCountLabelInfo
            // 
            this.RejectedCountLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RejectedCountLabelInfo.AutoSize = true;
            this.RejectedCountLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RejectedCountLabelInfo.Location = new System.Drawing.Point(167, 212);
            this.RejectedCountLabelInfo.Name = "RejectedCountLabelInfo";
            this.RejectedCountLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.RejectedCountLabelInfo.TabIndex = 12;
            this.RejectedCountLabelInfo.Text = "label15";
            // 
            // AvgHourLabel
            // 
            this.AvgHourLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgHourLabel.AutoSize = true;
            this.AvgHourLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AvgHourLabel.Location = new System.Drawing.Point(36, 124);
            this.AvgHourLabel.Name = "AvgHourLabel";
            this.AvgHourLabel.Size = new System.Drawing.Size(52, 13);
            this.AvgHourLabel.TabIndex = 13;
            this.AvgHourLabel.Text = "Avg Hour";
            // 
            // AvgDayLabel
            // 
            this.AvgDayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvgDayLabel.AutoSize = true;
            this.AvgDayLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AvgDayLabel.Location = new System.Drawing.Point(38, 153);
            this.AvgDayLabel.Name = "AvgDayLabel";
            this.AvgDayLabel.Size = new System.Drawing.Size(48, 13);
            this.AvgDayLabel.TabIndex = 14;
            this.AvgDayLabel.Text = "Avg Day";
            // 
            // AcceptedCountLabel
            // 
            this.AcceptedCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptedCountLabel.AutoSize = true;
            this.AcceptedCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AcceptedCountLabel.Location = new System.Drawing.Point(18, 182);
            this.AcceptedCountLabel.Name = "AcceptedCountLabel";
            this.AcceptedCountLabel.Size = new System.Drawing.Size(89, 13);
            this.AcceptedCountLabel.TabIndex = 15;
            this.AcceptedCountLabel.Text = "Accepted Shares";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(603, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 400);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(89, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Profit";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 235);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(20, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 400);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(103, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPU";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.FanSpeedLabelInfo, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.FanSpeedLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.PowerLabelInfo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.PowerLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TempLabelInfo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TempLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.GpuVendorLabelInfo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.GpuVnedorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.GpuModelLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GpuModelLabelInfo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EfficiencyLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.EfficiencyLabelInfo, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 235);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FanSpeedLabelInfo
            // 
            this.FanSpeedLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FanSpeedLabelInfo.AutoSize = true;
            this.FanSpeedLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FanSpeedLabelInfo.Location = new System.Drawing.Point(167, 124);
            this.FanSpeedLabelInfo.Name = "FanSpeedLabelInfo";
            this.FanSpeedLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.FanSpeedLabelInfo.TabIndex = 9;
            this.FanSpeedLabelInfo.Text = "label13";
            // 
            // FanSpeedLabel
            // 
            this.FanSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FanSpeedLabel.AutoSize = true;
            this.FanSpeedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FanSpeedLabel.Location = new System.Drawing.Point(33, 124);
            this.FanSpeedLabel.Name = "FanSpeedLabel";
            this.FanSpeedLabel.Size = new System.Drawing.Size(59, 13);
            this.FanSpeedLabel.TabIndex = 8;
            this.FanSpeedLabel.Text = "Fan Speed";
            // 
            // PowerLabelInfo
            // 
            this.PowerLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PowerLabelInfo.AutoSize = true;
            this.PowerLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PowerLabelInfo.Location = new System.Drawing.Point(167, 95);
            this.PowerLabelInfo.Name = "PowerLabelInfo";
            this.PowerLabelInfo.Size = new System.Drawing.Size(41, 13);
            this.PowerLabelInfo.TabIndex = 7;
            this.PowerLabelInfo.Text = "label11";
            // 
            // PowerLabel
            // 
            this.PowerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PowerLabel.Location = new System.Drawing.Point(44, 95);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(37, 13);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "Power";
            // 
            // TempLabelInfo
            // 
            this.TempLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TempLabelInfo.AutoSize = true;
            this.TempLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TempLabelInfo.Location = new System.Drawing.Point(170, 66);
            this.TempLabelInfo.Name = "TempLabelInfo";
            this.TempLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.TempLabelInfo.TabIndex = 5;
            this.TempLabelInfo.Text = "label9";
            // 
            // TempLabel
            // 
            this.TempLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TempLabel.AutoSize = true;
            this.TempLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TempLabel.Location = new System.Drawing.Point(45, 66);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(34, 13);
            this.TempLabel.TabIndex = 4;
            this.TempLabel.Text = "Temp";
            // 
            // GpuVendorLabelInfo
            // 
            this.GpuVendorLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GpuVendorLabelInfo.AutoSize = true;
            this.GpuVendorLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GpuVendorLabelInfo.Location = new System.Drawing.Point(170, 37);
            this.GpuVendorLabelInfo.Name = "GpuVendorLabelInfo";
            this.GpuVendorLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.GpuVendorLabelInfo.TabIndex = 3;
            this.GpuVendorLabelInfo.Text = "label7";
            // 
            // GpuVnedorLabel
            // 
            this.GpuVnedorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GpuVnedorLabel.AutoSize = true;
            this.GpuVnedorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GpuVnedorLabel.Location = new System.Drawing.Point(42, 37);
            this.GpuVnedorLabel.Name = "GpuVnedorLabel";
            this.GpuVnedorLabel.Size = new System.Drawing.Size(41, 13);
            this.GpuVnedorLabel.TabIndex = 2;
            this.GpuVnedorLabel.Text = "Vendor";
            // 
            // GpuModelLabel
            // 
            this.GpuModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GpuModelLabel.AutoSize = true;
            this.GpuModelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GpuModelLabel.Location = new System.Drawing.Point(49, 8);
            this.GpuModelLabel.Name = "GpuModelLabel";
            this.GpuModelLabel.Size = new System.Drawing.Size(27, 13);
            this.GpuModelLabel.TabIndex = 0;
            this.GpuModelLabel.Text = "Gpu";
            // 
            // GpuModelLabelInfo
            // 
            this.GpuModelLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GpuModelLabelInfo.AutoSize = true;
            this.GpuModelLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GpuModelLabelInfo.Location = new System.Drawing.Point(170, 8);
            this.GpuModelLabelInfo.Name = "GpuModelLabelInfo";
            this.GpuModelLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.GpuModelLabelInfo.TabIndex = 1;
            this.GpuModelLabelInfo.Text = "label5";
            // 
            // EfficiencyLabel
            // 
            this.EfficiencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EfficiencyLabel.AutoSize = true;
            this.EfficiencyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.EfficiencyLabel.Location = new System.Drawing.Point(36, 153);
            this.EfficiencyLabel.Name = "EfficiencyLabel";
            this.EfficiencyLabel.Size = new System.Drawing.Size(53, 13);
            this.EfficiencyLabel.TabIndex = 10;
            this.EfficiencyLabel.Text = "Efficiency";
            // 
            // EfficiencyLabelInfo
            // 
            this.EfficiencyLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EfficiencyLabelInfo.AutoSize = true;
            this.EfficiencyLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EfficiencyLabelInfo.Location = new System.Drawing.Point(170, 153);
            this.EfficiencyLabelInfo.Name = "EfficiencyLabelInfo";
            this.EfficiencyLabelInfo.Size = new System.Drawing.Size(35, 13);
            this.EfficiencyLabelInfo.TabIndex = 11;
            this.EfficiencyLabelInfo.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.MiningButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 90);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MiningButton
            // 
            this.MiningButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiningButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiningButton.BackgroundImage")));
            this.MiningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiningButton.ForeColor = System.Drawing.Color.White;
            this.MiningButton.Location = new System.Drawing.Point(384, 25);
            this.MiningButton.Name = "MiningButton";
            this.MiningButton.Size = new System.Drawing.Size(126, 40);
            this.MiningButton.TabIndex = 0;
            this.MiningButton.Text = "Zacznij Kopac";
            this.MiningButton.UseVisualStyleBackColor = true;
            this.MiningButton.Click += new System.EventHandler(this.MiningButton_Click);
            // 
            // MiningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiningForm";
            this.Text = "MiningForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(254)))), ((int)(((byte)(7)))));
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MiningButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Label GpuModelLabel;
        private Label GpuModelLabelInfo;
        private Label FanSpeedLabelInfo;
        private Label FanSpeedLabel;
        private Label PowerLabelInfo;
        private Label PowerLabel;
        private Label TempLabelInfo;
        private Label TempLabel;
        private Label GpuVendorLabelInfo;
        private Label GpuVnedorLabel;
        private Label EfficiencyLabel;
        private Label EfficiencyLabelInfo;
        private Label RejectedCountLabel;
        private Label TrexLabel;
        private Label TrexLabelInfo;
        private Label AlgorythmLabel;
        private Label AlgorythmLabelInfo;
        private Label UpTimeLabel;
        private Label UpTimeLabelInfo;
        private Label HashRateLabel;
        private Label HashRateLabelInfo;
        private Label AvgHourLabelInfo;
        private Label AvgDayLabelInfo;
        private Label AcceptedCountLabelInfo;
        private Label RejectedCountLabelInfo;
        private Label AvgHourLabel;
        private Label AvgDayLabel;
        private Label AcceptedCountLabel;
    }
}