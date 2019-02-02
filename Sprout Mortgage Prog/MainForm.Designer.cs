namespace Sprout_Mortgage_Prog
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yearPlanLabel = new System.Windows.Forms.Label();
            this.yearPlanComboBox = new System.Windows.Forms.ComboBox();
            this.creditScoreRangeLabel = new System.Windows.Forms.Label();
            this.creditScoreRangeComboBox = new System.Windows.Forms.ComboBox();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.loanAmountComboBox = new System.Windows.Forms.ComboBox();
            this.addOnsComboBox = new System.Windows.Forms.ComboBox();
            this.addOnsLabel = new System.Windows.Forms.Label();
            this.LTVRangeComboBox = new System.Windows.Forms.ComboBox();
            this.LTVRangeLabel = new System.Windows.Forms.Label();
            this.Alerts = new System.Windows.Forms.ListBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.baseRateComboBox = new System.Windows.Forms.ComboBox();
            this.baseRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(329, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 108);
            this.listBox1.TabIndex = 0;
            // 
            // yearPlanLabel
            // 
            this.yearPlanLabel.AutoSize = true;
            this.yearPlanLabel.Location = new System.Drawing.Point(175, 52);
            this.yearPlanLabel.Name = "yearPlanLabel";
            this.yearPlanLabel.Size = new System.Drawing.Size(53, 13);
            this.yearPlanLabel.TabIndex = 1;
            this.yearPlanLabel.Text = "Year Plan";
            this.yearPlanLabel.Click += new System.EventHandler(this.yearPlanLabel_Click);
            // 
            // yearPlanComboBox
            // 
            this.yearPlanComboBox.FormattingEnabled = true;
            this.yearPlanComboBox.Location = new System.Drawing.Point(12, 49);
            this.yearPlanComboBox.Name = "yearPlanComboBox";
            this.yearPlanComboBox.Size = new System.Drawing.Size(157, 21);
            this.yearPlanComboBox.TabIndex = 2;
            this.yearPlanComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // creditScoreRangeLabel
            // 
            this.creditScoreRangeLabel.AutoSize = true;
            this.creditScoreRangeLabel.Location = new System.Drawing.Point(175, 154);
            this.creditScoreRangeLabel.Name = "creditScoreRangeLabel";
            this.creditScoreRangeLabel.Size = new System.Drawing.Size(100, 13);
            this.creditScoreRangeLabel.TabIndex = 3;
            this.creditScoreRangeLabel.Text = "Credit Score Range";
            // 
            // creditScoreRangeComboBox
            // 
            this.creditScoreRangeComboBox.FormattingEnabled = true;
            this.creditScoreRangeComboBox.Location = new System.Drawing.Point(12, 151);
            this.creditScoreRangeComboBox.Name = "creditScoreRangeComboBox";
            this.creditScoreRangeComboBox.Size = new System.Drawing.Size(157, 21);
            this.creditScoreRangeComboBox.TabIndex = 4;
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Location = new System.Drawing.Point(202, 188);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.loanAmountLabel.TabIndex = 7;
            this.loanAmountLabel.Text = "Loan Amount";
            // 
            // loanAmountComboBox
            // 
            this.loanAmountComboBox.FormattingEnabled = true;
            this.loanAmountComboBox.Location = new System.Drawing.Point(12, 185);
            this.loanAmountComboBox.Name = "loanAmountComboBox";
            this.loanAmountComboBox.Size = new System.Drawing.Size(184, 21);
            this.loanAmountComboBox.TabIndex = 8;
            // 
            // addOnsComboBox
            // 
            this.addOnsComboBox.Enabled = false;
            this.addOnsComboBox.FormattingEnabled = true;
            this.addOnsComboBox.Location = new System.Drawing.Point(12, 219);
            this.addOnsComboBox.Name = "addOnsComboBox";
            this.addOnsComboBox.Size = new System.Drawing.Size(157, 21);
            this.addOnsComboBox.TabIndex = 12;
            this.addOnsComboBox.SelectedIndexChanged += new System.EventHandler(this.addOnsComboBox_SelectedIndexChanged);
            // 
            // addOnsLabel
            // 
            this.addOnsLabel.AutoSize = true;
            this.addOnsLabel.Enabled = false;
            this.addOnsLabel.Location = new System.Drawing.Point(175, 222);
            this.addOnsLabel.Name = "addOnsLabel";
            this.addOnsLabel.Size = new System.Drawing.Size(46, 13);
            this.addOnsLabel.TabIndex = 11;
            this.addOnsLabel.Text = "Add-ons";
            // 
            // LTVRangeComboBox
            // 
            this.LTVRangeComboBox.FormattingEnabled = true;
            this.LTVRangeComboBox.Location = new System.Drawing.Point(12, 117);
            this.LTVRangeComboBox.Name = "LTVRangeComboBox";
            this.LTVRangeComboBox.Size = new System.Drawing.Size(157, 21);
            this.LTVRangeComboBox.TabIndex = 16;
            this.LTVRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // LTVRangeLabel
            // 
            this.LTVRangeLabel.AutoSize = true;
            this.LTVRangeLabel.Location = new System.Drawing.Point(175, 120);
            this.LTVRangeLabel.Name = "LTVRangeLabel";
            this.LTVRangeLabel.Size = new System.Drawing.Size(62, 13);
            this.LTVRangeLabel.TabIndex = 15;
            this.LTVRangeLabel.Text = "LTV Range";
            this.LTVRangeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Alerts
            // 
            this.Alerts.FormattingEnabled = true;
            this.Alerts.Location = new System.Drawing.Point(329, 23);
            this.Alerts.Name = "Alerts";
            this.Alerts.Size = new System.Drawing.Size(362, 121);
            this.Alerts.TabIndex = 17;
            this.Alerts.SelectedIndexChanged += new System.EventHandler(this.Alerts_SelectedIndexChanged);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(175, 86);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(31, 13);
            this.daysLabel.TabIndex = 15;
            this.daysLabel.Text = "Days";
            this.daysLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // daysComboBox
            // 
            this.daysComboBox.FormattingEnabled = true;
            this.daysComboBox.Location = new System.Drawing.Point(12, 83);
            this.daysComboBox.Name = "daysComboBox";
            this.daysComboBox.Size = new System.Drawing.Size(157, 21);
            this.daysComboBox.TabIndex = 16;
            this.daysComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 261);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(94, 261);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // baseRateComboBox
            // 
            this.baseRateComboBox.FormattingEnabled = true;
            this.baseRateComboBox.Location = new System.Drawing.Point(12, 12);
            this.baseRateComboBox.Name = "baseRateComboBox";
            this.baseRateComboBox.Size = new System.Drawing.Size(157, 21);
            this.baseRateComboBox.TabIndex = 21;
            // 
            // baseRateLabel
            // 
            this.baseRateLabel.AutoSize = true;
            this.baseRateLabel.Location = new System.Drawing.Point(175, 15);
            this.baseRateLabel.Name = "baseRateLabel";
            this.baseRateLabel.Size = new System.Drawing.Size(57, 13);
            this.baseRateLabel.TabIndex = 20;
            this.baseRateLabel.Text = "Base Rate";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 322);
            this.Controls.Add(this.baseRateComboBox);
            this.Controls.Add(this.baseRateLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.Alerts);
            this.Controls.Add(this.daysComboBox);
            this.Controls.Add(this.LTVRangeComboBox);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.LTVRangeLabel);
            this.Controls.Add(this.addOnsComboBox);
            this.Controls.Add(this.addOnsLabel);
            this.Controls.Add(this.loanAmountComboBox);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.creditScoreRangeComboBox);
            this.Controls.Add(this.creditScoreRangeLabel);
            this.Controls.Add(this.yearPlanComboBox);
            this.Controls.Add(this.yearPlanLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label yearPlanLabel;
        private System.Windows.Forms.ComboBox yearPlanComboBox;
        private System.Windows.Forms.Label creditScoreRangeLabel;
        private System.Windows.Forms.ComboBox creditScoreRangeComboBox;
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.ComboBox loanAmountComboBox;
        private System.Windows.Forms.ComboBox addOnsComboBox;
        private System.Windows.Forms.Label addOnsLabel;
        private System.Windows.Forms.ComboBox LTVRangeComboBox;
        private System.Windows.Forms.Label LTVRangeLabel;
        private System.Windows.Forms.ListBox Alerts;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.ComboBox daysComboBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox baseRateComboBox;
        private System.Windows.Forms.Label baseRateLabel;
    }
}