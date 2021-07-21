﻿
namespace MORT
{
    partial class UIAdvencedOption
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udMaxSFontize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.udMinFontSize = new System.Windows.Forms.NumericUpDown();
            this.cbOverlayAutoSize = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.ctSettingHotKey4 = new MORT.CustomControl.CtSettingHotKey();
            this.ctSettingHotKey3 = new MORT.CustomControl.CtSettingHotKey();
            this.ctSettingHotKey2 = new MORT.CustomControl.CtSettingHotKey();
            this.ctSettingHotKey1 = new MORT.CustomControl.CtSettingHotKey();
            this.tabControl1.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSFontize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage16);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 35);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(26, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage16
            // 
            this.tabPage16.AutoScroll = true;
            this.tabPage16.Controls.Add(this.groupBox1);
            this.tabPage16.Location = new System.Drawing.Point(4, 39);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(767, 382);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "고급 단축키";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctSettingHotKey4);
            this.groupBox1.Controls.Add(this.ctSettingHotKey3);
            this.groupBox1.Controls.Add(this.ctSettingHotKey2);
            this.groupBox1.Controls.Add(this.ctSettingHotKey1);
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 337);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정 불러오기";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 382);
            this.tabPage1.TabIndex = 16;
            this.tabPage1.Text = "번역창";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.udMaxSFontize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.udMinFontSize);
            this.groupBox2.Controls.Add(this.cbOverlayAutoSize);
            this.groupBox2.Location = new System.Drawing.Point(20, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 153);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "오버레이 번역창";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "폰트 최대 크기";
            // 
            // udMaxSFontize
            // 
            this.udMaxSFontize.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udMaxSFontize.Location = new System.Drawing.Point(104, 96);
            this.udMaxSFontize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMaxSFontize.Name = "udMaxSFontize";
            this.udMaxSFontize.Size = new System.Drawing.Size(62, 23);
            this.udMaxSFontize.TabIndex = 7;
            this.udMaxSFontize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMaxSFontize.ValueChanged += new System.EventHandler(this.udMaxSFontize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "폰트 최소 크기";
            // 
            // udMinFontSize
            // 
            this.udMinFontSize.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udMinFontSize.Location = new System.Drawing.Point(104, 62);
            this.udMinFontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMinFontSize.Name = "udMinFontSize";
            this.udMinFontSize.Size = new System.Drawing.Size(62, 23);
            this.udMinFontSize.TabIndex = 5;
            this.udMinFontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMinFontSize.ValueChanged += new System.EventHandler(this.udMinFontSize_ValueChanged);
            // 
            // cbOverlayAutoSize
            // 
            this.cbOverlayAutoSize.AutoSize = true;
            this.cbOverlayAutoSize.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbOverlayAutoSize.Location = new System.Drawing.Point(15, 37);
            this.cbOverlayAutoSize.Name = "cbOverlayAutoSize";
            this.cbOverlayAutoSize.Size = new System.Drawing.Size(239, 19);
            this.cbOverlayAutoSize.TabIndex = 4;
            this.cbOverlayAutoSize.Text = "자동 폰트 크기 - 원문에 맞춰 크기 조절";
            this.cbOverlayAutoSize.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(398, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 44);
            this.button2.TabIndex = 83;
            this.button2.Text = "적용";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnClickApply);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.ForeColor = System.Drawing.Color.Black;
            this.btReset.Location = new System.Drawing.Point(17, 444);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(380, 44);
            this.btReset.TabIndex = 84;
            this.btReset.Text = "초기화";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.OnClickReset);
            // 
            // ctSettingHotKey4
            // 
            this.ctSettingHotKey4.Location = new System.Drawing.Point(6, 263);
            this.ctSettingHotKey4.Name = "ctSettingHotKey4";
            this.ctSettingHotKey4.Size = new System.Drawing.Size(465, 75);
            this.ctSettingHotKey4.TabIndex = 3;
            // 
            // ctSettingHotKey3
            // 
            this.ctSettingHotKey3.Location = new System.Drawing.Point(6, 182);
            this.ctSettingHotKey3.Name = "ctSettingHotKey3";
            this.ctSettingHotKey3.Size = new System.Drawing.Size(465, 75);
            this.ctSettingHotKey3.TabIndex = 2;
            // 
            // ctSettingHotKey2
            // 
            this.ctSettingHotKey2.Location = new System.Drawing.Point(6, 101);
            this.ctSettingHotKey2.Name = "ctSettingHotKey2";
            this.ctSettingHotKey2.Size = new System.Drawing.Size(465, 75);
            this.ctSettingHotKey2.TabIndex = 1;
            // 
            // ctSettingHotKey1
            // 
            this.ctSettingHotKey1.Location = new System.Drawing.Point(6, 20);
            this.ctSettingHotKey1.Name = "ctSettingHotKey1";
            this.ctSettingHotKey1.Size = new System.Drawing.Size(465, 75);
            this.ctSettingHotKey1.TabIndex = 0;
            // 
            // UIAdvencedOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "UIAdvencedOption";
            this.ShowIcon = false;
            this.Text = "고급 설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIAdvencedOption_FormClosing);
            this.Load += new System.EventHandler(this.UIAdvencedOption_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSFontize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btReset;
        private CustomControl.CtSettingHotKey ctSettingHotKey1;
        private CustomControl.CtSettingHotKey ctSettingHotKey3;
        private CustomControl.CtSettingHotKey ctSettingHotKey2;
        private CustomControl.CtSettingHotKey ctSettingHotKey4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbOverlayAutoSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udMaxSFontize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udMinFontSize;
    }
}