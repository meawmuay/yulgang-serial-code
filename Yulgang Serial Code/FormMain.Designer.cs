﻿namespace Yulgang_Serial_Code
{
    partial class FormMain
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
            if( disposing && ( components != null ) )
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxSerialCode = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxGameWindow = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelCodeIndex = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTyping = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNpcZoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNpcMenu = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSerialCode
            // 
            this.textBoxSerialCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxSerialCode.Location = new System.Drawing.Point(12, 35);
            this.textBoxSerialCode.Multiline = true;
            this.textBoxSerialCode.Name = "textBoxSerialCode";
            this.textBoxSerialCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSerialCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSerialCode.Size = new System.Drawing.Size(185, 195);
            this.textBoxSerialCode.TabIndex = 99;
            this.textBoxSerialCode.Text = "# ใส่ Code ที่นี่\r\n# 1 โค้ด ต่อ 1 บรรทัด";
            this.textBoxSerialCode.WordWrap = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonStart.Location = new System.Drawing.Point(304, 190);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxGameWindow
            // 
            this.comboBoxGameWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGameWindow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxGameWindow.FormattingEnabled = true;
            this.comboBoxGameWindow.Location = new System.Drawing.Point(302, 33);
            this.comboBoxGameWindow.Name = "comboBoxGameWindow";
            this.comboBoxGameWindow.Size = new System.Drawing.Size(147, 22);
            this.comboBoxGameWindow.TabIndex = 2;
            this.comboBoxGameWindow.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelCodeIndex);
            this.groupBox.Controls.Add(this.labelCode);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox.Location = new System.Drawing.Point(212, 110);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(239, 74);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // labelCodeIndex
            // 
            this.labelCodeIndex.AutoSize = true;
            this.labelCodeIndex.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelCodeIndex.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCodeIndex.Location = new System.Drawing.Point(86, 46);
            this.labelCodeIndex.Name = "labelCodeIndex";
            this.labelCodeIndex.Size = new System.Drawing.Size(13, 14);
            this.labelCodeIndex.TabIndex = 3;
            this.labelCodeIndex.Text = "?";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCode.Location = new System.Drawing.Point(86, 20);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(13, 14);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Code Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // timerTyping
            // 
            this.timerTyping.Interval = 2000;
            this.timerTyping.Tick += new System.EventHandler(this.timerTyping_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(395, 190);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 40);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonIndex
            // 
            this.buttonIndex.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonIndex.Location = new System.Drawing.Point(212, 190);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(79, 40);
            this.buttonIndex.TabIndex = 5;
            this.buttonIndex.Text = "SET INDEX";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.buttonIndex_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 237);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(461, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(209, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game window";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout,
            this.ToolStripMenuItemUpdate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(58, 20);
            this.ToolStripMenuItemAbout.Text = "เกี่ยวกับ";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // ToolStripMenuItemUpdate
            // 
            this.ToolStripMenuItemUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate";
            this.ToolStripMenuItemUpdate.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItemUpdate.Text = "อัปเดต";
            this.ToolStripMenuItemUpdate.Click += new System.EventHandler(this.ToolStripMenuItemUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(209, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 101;
            this.label2.Text = "NPC";
            // 
            // comboBoxNpcZoom
            // 
            this.comboBoxNpcZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNpcZoom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxNpcZoom.FormattingEnabled = true;
            this.comboBoxNpcZoom.Items.AddRange(new object[] {
            "ZOOM",
            "NORMAL"});
            this.comboBoxNpcZoom.Location = new System.Drawing.Point(302, 61);
            this.comboBoxNpcZoom.Name = "comboBoxNpcZoom";
            this.comboBoxNpcZoom.Size = new System.Drawing.Size(147, 22);
            this.comboBoxNpcZoom.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(208, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 103;
            this.label4.Text = "NPC Menu";
            // 
            // comboBoxNpcMenu
            // 
            this.comboBoxNpcMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNpcMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxNpcMenu.FormattingEnabled = true;
            this.comboBoxNpcMenu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxNpcMenu.Location = new System.Drawing.Point(301, 89);
            this.comboBoxNpcMenu.Name = "comboBoxNpcMenu";
            this.comboBoxNpcMenu.Size = new System.Drawing.Size(147, 22);
            this.comboBoxNpcMenu.TabIndex = 104;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNpcMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNpcZoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonIndex);
            this.Controls.Add(this.comboBoxGameWindow);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSerialCode);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Yulgang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSerialCode;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxGameWindow;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerTyping;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCodeIndex;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNpcZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNpcMenu;
    }
}

