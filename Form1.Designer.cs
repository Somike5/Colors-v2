
namespace Colors_v2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueValueLabel = new System.Windows.Forms.Label();
            this.greenValueLabel = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.redValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rgbBox = new System.Windows.Forms.TextBox();
            this.htmlBox = new System.Windows.Forms.TextBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.oleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueValueLabel);
            this.groupBox1.Controls.Add(this.greenValueLabel);
            this.groupBox1.Controls.Add(this.blueBar);
            this.groupBox1.Controls.Add(this.greenBar);
            this.groupBox1.Controls.Add(this.redValueLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.redBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szín keverés";
            // 
            // blueValueLabel
            // 
            this.blueValueLabel.AutoSize = true;
            this.blueValueLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueValueLabel.ForeColor = System.Drawing.Color.Blue;
            this.blueValueLabel.Location = new System.Drawing.Point(375, 149);
            this.blueValueLabel.Name = "blueValueLabel";
            this.blueValueLabel.Size = new System.Drawing.Size(43, 21);
            this.blueValueLabel.TabIndex = 11;
            this.blueValueLabel.Text = "110";
            // 
            // greenValueLabel
            // 
            this.greenValueLabel.AutoSize = true;
            this.greenValueLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenValueLabel.ForeColor = System.Drawing.Color.Green;
            this.greenValueLabel.Location = new System.Drawing.Point(375, 94);
            this.greenValueLabel.Name = "greenValueLabel";
            this.greenValueLabel.Size = new System.Drawing.Size(43, 21);
            this.greenValueLabel.TabIndex = 10;
            this.greenValueLabel.Text = "110";
            // 
            // blueBar
            // 
            this.blueBar.LargeChange = 10;
            this.blueBar.Location = new System.Drawing.Point(77, 149);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(292, 45);
            this.blueBar.TabIndex = 9;
            this.blueBar.Value = 110;
            this.blueBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.LargeChange = 10;
            this.greenBar.Location = new System.Drawing.Point(77, 94);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(292, 45);
            this.greenBar.TabIndex = 8;
            this.greenBar.Value = 110;
            this.greenBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // redValueLabel
            // 
            this.redValueLabel.AutoSize = true;
            this.redValueLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redValueLabel.ForeColor = System.Drawing.Color.Red;
            this.redValueLabel.Location = new System.Drawing.Point(375, 43);
            this.redValueLabel.Name = "redValueLabel";
            this.redValueLabel.Size = new System.Drawing.Size(43, 21);
            this.redValueLabel.TabIndex = 7;
            this.redValueLabel.Text = "110";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zöld";
            // 
            // redBar
            // 
            this.redBar.LargeChange = 10;
            this.redBar.Location = new System.Drawing.Point(77, 43);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(292, 45);
            this.redBar.TabIndex = 2;
            this.redBar.Value = 110;
            this.redBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "RGB Színkód:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "HTML Színkód:";
            // 
            // rgbBox
            // 
            this.rgbBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rgbBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rgbBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgbBox.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgbBox.Location = new System.Drawing.Point(166, 242);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.ReadOnly = true;
            this.rgbBox.Size = new System.Drawing.Size(203, 25);
            this.rgbBox.TabIndex = 3;
            this.rgbBox.Text = "110, 110, 110";
            this.rgbBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htmlBox
            // 
            this.htmlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.htmlBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.htmlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htmlBox.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.htmlBox.Location = new System.Drawing.Point(166, 283);
            this.htmlBox.Name = "htmlBox";
            this.htmlBox.ReadOnly = true;
            this.htmlBox.Size = new System.Drawing.Size(203, 25);
            this.htmlBox.TabIndex = 4;
            this.htmlBox.Text = "#6E6E6E";
            this.htmlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.colorPanel.Location = new System.Drawing.Point(454, 21);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(216, 330);
            this.colorPanel.TabIndex = 5;
            // 
            // oleBox
            // 
            this.oleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oleBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oleBox.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oleBox.Location = new System.Drawing.Point(166, 324);
            this.oleBox.Name = "oleBox";
            this.oleBox.ReadOnly = true;
            this.oleBox.Size = new System.Drawing.Size(203, 25);
            this.oleBox.TabIndex = 6;
            this.oleBox.Text = "7237230";
            this.oleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "OLE Színkód:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImage = global::Colors_v2.Properties.Resources.copy03;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(375, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 34);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImage = global::Colors_v2.Properties.Resources.copy03;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(375, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 34);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::Colors_v2.Properties.Resources.copy03;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(375, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 34);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oleBox);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.htmlBox);
            this.Controls.Add(this.rgbBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors V2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blueValueLabel;
        private System.Windows.Forms.Label greenValueLabel;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.Label redValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rgbBox;
        private System.Windows.Forms.TextBox htmlBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.TextBox oleBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

