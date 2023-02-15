namespace towerOfHanoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numTb = new System.Windows.Forms.TextBox();
            this.startB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.speedCb = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stackFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.stackFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(118, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 22);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(236, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 330);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(344, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tower of Hanoi Visualizer";
            // 
            // closeB
            // 
            this.closeB.ForeColor = System.Drawing.Color.IndianRed;
            this.closeB.Location = new System.Drawing.Point(1219, 12);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(26, 23);
            this.closeB.TabIndex = 8;
            this.closeB.Text = "X";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter the number of bars: ";
            // 
            // numTb
            // 
            this.numTb.Location = new System.Drawing.Point(413, 478);
            this.numTb.Name = "numTb";
            this.numTb.Size = new System.Drawing.Size(100, 20);
            this.numTb.TabIndex = 10;
            this.numTb.TextChanged += new System.EventHandler(this.numTb_TextChanged);
            // 
            // startB
            // 
            this.startB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.startB.ForeColor = System.Drawing.Color.Black;
            this.startB.Location = new System.Drawing.Point(572, 470);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 32);
            this.startB.TabIndex = 11;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // removeB
            // 
            this.removeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.removeB.ForeColor = System.Drawing.Color.Black;
            this.removeB.Location = new System.Drawing.Point(691, 470);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(102, 32);
            this.removeB.TabIndex = 12;
            this.removeB.Text = "Remove All";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // speedCb
            // 
            this.speedCb.FormattingEnabled = true;
            this.speedCb.Items.AddRange(new object[] {
            "0.5x",
            "1x",
            "2x",
            "3x",
            "4x",
            "5x"});
            this.speedCb.Location = new System.Drawing.Point(853, 478);
            this.speedCb.Name = "speedCb";
            this.speedCb.Size = new System.Drawing.Size(121, 21);
            this.speedCb.TabIndex = 14;
            this.speedCb.Text = "Speed";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.IndianRed;
            this.panel9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(840, 100);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 330);
            this.panel9.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(540, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 330);
            this.panel3.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(422, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(256, 22);
            this.panel7.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(722, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 22);
            this.panel5.TabIndex = 23;
            // 
            // stackFlowPanel
            // 
            this.stackFlowPanel.AutoScroll = true;
            this.stackFlowPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.stackFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stackFlowPanel.Controls.Add(this.button1);
            this.stackFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.stackFlowPanel.Location = new System.Drawing.Point(1071, 100);
            this.stackFlowPanel.Name = "stackFlowPanel";
            this.stackFlowPanel.Size = new System.Drawing.Size(125, 342);
            this.stackFlowPanel.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Method";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1257, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.stackFlowPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.speedCb);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.numTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stackFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numTb;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.ComboBox speedCb;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel stackFlowPanel;
        private System.Windows.Forms.Button button1;
    }
}

