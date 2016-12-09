namespace BlinkstickComputer
{
    partial class Form1
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
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbLED = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lRed = new System.Windows.Forms.Label();
            this.lGreen = new System.Windows.Forms.Label();
            this.lBlue = new System.Windows.Forms.Label();
            this.bLEDSet = new System.Windows.Forms.Button();
            this.gbTemps = new System.Windows.Forms.GroupBox();
            this.lGpu = new System.Windows.Forms.Label();
            this.tbGpuAlarm = new System.Windows.Forms.TextBox();
            this.lAlarmTemp = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbLED.SuspendLayout();
            this.gbTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.gbTemps);
            this.tpSettings.Controls.Add(this.gbLED);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(484, 384);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbLED
            // 
            this.gbLED.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLED.Controls.Add(this.bLEDSet);
            this.gbLED.Controls.Add(this.lBlue);
            this.gbLED.Controls.Add(this.lGreen);
            this.gbLED.Controls.Add(this.lRed);
            this.gbLED.Controls.Add(this.textBox3);
            this.gbLED.Controls.Add(this.textBox2);
            this.gbLED.Controls.Add(this.textBox1);
            this.gbLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLED.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbLED.Location = new System.Drawing.Point(302, 264);
            this.gbLED.Name = "gbLED";
            this.gbLED.Size = new System.Drawing.Size(176, 117);
            this.gbLED.TabIndex = 0;
            this.gbLED.TabStop = false;
            this.gbLED.Text = "LED Color";
            this.gbLED.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(72, 32);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(72, 64);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 92);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lRed
            // 
            this.lRed.AutoSize = true;
            this.lRed.Location = new System.Drawing.Point(6, 35);
            this.lRed.Name = "lRed";
            this.lRed.Size = new System.Drawing.Size(27, 13);
            this.lRed.TabIndex = 9999;
            this.lRed.Text = "Red";
            // 
            // lGreen
            // 
            this.lGreen.AutoSize = true;
            this.lGreen.Location = new System.Drawing.Point(6, 67);
            this.lGreen.Name = "lGreen";
            this.lGreen.Size = new System.Drawing.Size(36, 13);
            this.lGreen.TabIndex = 9999;
            this.lGreen.Text = "Green";
            this.lGreen.Click += new System.EventHandler(this.lGreen_Click);
            // 
            // lBlue
            // 
            this.lBlue.AutoSize = true;
            this.lBlue.Location = new System.Drawing.Point(6, 95);
            this.lBlue.Name = "lBlue";
            this.lBlue.Size = new System.Drawing.Size(28, 13);
            this.lBlue.TabIndex = 9999;
            this.lBlue.Text = "Blue";
            // 
            // bLEDSet
            // 
            this.bLEDSet.Location = new System.Drawing.Point(128, 86);
            this.bLEDSet.Name = "bLEDSet";
            this.bLEDSet.Size = new System.Drawing.Size(42, 22);
            this.bLEDSet.TabIndex = 3;
            this.bLEDSet.Text = "Set";
            this.bLEDSet.UseVisualStyleBackColor = true;
            // 
            // gbTemps
            // 
            this.gbTemps.Controls.Add(this.lAlarmTemp);
            this.gbTemps.Controls.Add(this.tbGpuAlarm);
            this.gbTemps.Controls.Add(this.lGpu);
            this.gbTemps.Location = new System.Drawing.Point(6, 264);
            this.gbTemps.Name = "gbTemps";
            this.gbTemps.Size = new System.Drawing.Size(176, 117);
            this.gbTemps.TabIndex = 1;
            this.gbTemps.TabStop = false;
            this.gbTemps.Text = "Temptures";
            // 
            // lGpu
            // 
            this.lGpu.AutoSize = true;
            this.lGpu.Location = new System.Drawing.Point(6, 35);
            this.lGpu.Name = "lGpu";
            this.lGpu.Size = new System.Drawing.Size(55, 13);
            this.lGpu.TabIndex = 0;
            this.lGpu.Text = "GPU 00 C";
            // 
            // tbGpuAlarm
            // 
            this.tbGpuAlarm.Location = new System.Drawing.Point(94, 32);
            this.tbGpuAlarm.Name = "tbGpuAlarm";
            this.tbGpuAlarm.Size = new System.Drawing.Size(50, 20);
            this.tbGpuAlarm.TabIndex = 1;
            // 
            // lAlarmTemp
            // 
            this.lAlarmTemp.AutoSize = true;
            this.lAlarmTemp.Location = new System.Drawing.Point(91, 16);
            this.lAlarmTemp.Name = "lAlarmTemp";
            this.lAlarmTemp.Size = new System.Drawing.Size(63, 13);
            this.lAlarmTemp.TabIndex = 2;
            this.lAlarmTemp.Text = "Alarm Temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Blinkstick Temp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.gbLED.ResumeLayout(false);
            this.gbLED.PerformLayout();
            this.gbTemps.ResumeLayout(false);
            this.gbTemps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbLED;
        private System.Windows.Forms.Label lBlue;
        private System.Windows.Forms.Label lGreen;
        private System.Windows.Forms.Label lRed;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bLEDSet;
        private System.Windows.Forms.GroupBox gbTemps;
        private System.Windows.Forms.Label lAlarmTemp;
        private System.Windows.Forms.TextBox tbGpuAlarm;
        private System.Windows.Forms.Label lGpu;
    }
}

