namespace BecerraEstevan_Assignment06
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
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblLoanamount = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtLoanamount = new System.Windows.Forms.TextBox();
            this.grpDuration = new System.Windows.Forms.GroupBox();
            this.radThirty = new System.Windows.Forms.RadioButton();
            this.radTwenty = new System.Windows.Forms.RadioButton();
            this.radFifteen = new System.Windows.Forms.RadioButton();
            this.radTen = new System.Windows.Forms.RadioButton();
            this.lblLoanpaymentcalculator = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(42, 71);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(128, 25);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First Name: ";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(40, 121);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(127, 25);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Last Name: ";
            // 
            // lblLoanamount
            // 
            this.lblLoanamount.AutoSize = true;
            this.lblLoanamount.Location = new System.Drawing.Point(22, 171);
            this.lblLoanamount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoanamount.Name = "lblLoanamount";
            this.lblLoanamount.Size = new System.Drawing.Size(145, 25);
            this.lblLoanamount.TabIndex = 2;
            this.lblLoanamount.Text = "Loan Amount:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(202, 215);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(150, 44);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(180, 65);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(196, 31);
            this.txtFirstname.TabIndex = 4;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(180, 115);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(196, 31);
            this.txtLastname.TabIndex = 5;
            // 
            // txtLoanamount
            // 
            this.txtLoanamount.Location = new System.Drawing.Point(180, 165);
            this.txtLoanamount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLoanamount.Name = "txtLoanamount";
            this.txtLoanamount.Size = new System.Drawing.Size(196, 31);
            this.txtLoanamount.TabIndex = 6;
            // 
            // grpDuration
            // 
            this.grpDuration.Controls.Add(this.radThirty);
            this.grpDuration.Controls.Add(this.radTwenty);
            this.grpDuration.Controls.Add(this.radFifteen);
            this.grpDuration.Controls.Add(this.radTen);
            this.grpDuration.Location = new System.Drawing.Point(392, 65);
            this.grpDuration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDuration.Name = "grpDuration";
            this.grpDuration.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDuration.Size = new System.Drawing.Size(186, 217);
            this.grpDuration.TabIndex = 7;
            this.grpDuration.TabStop = false;
            this.grpDuration.Text = "Duration";
            // 
            // radThirty
            // 
            this.radThirty.AutoSize = true;
            this.radThirty.Location = new System.Drawing.Point(12, 169);
            this.radThirty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radThirty.Name = "radThirty";
            this.radThirty.Size = new System.Drawing.Size(130, 29);
            this.radThirty.TabIndex = 3;
            this.radThirty.TabStop = true;
            this.radThirty.Text = "30 Years";
            this.radThirty.UseVisualStyleBackColor = true;
            this.radThirty.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // radTwenty
            // 
            this.radTwenty.AutoSize = true;
            this.radTwenty.Location = new System.Drawing.Point(12, 125);
            this.radTwenty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radTwenty.Name = "radTwenty";
            this.radTwenty.Size = new System.Drawing.Size(130, 29);
            this.radTwenty.TabIndex = 2;
            this.radTwenty.TabStop = true;
            this.radTwenty.Text = "20 Years";
            this.radTwenty.UseVisualStyleBackColor = true;
            // 
            // radFifteen
            // 
            this.radFifteen.AutoSize = true;
            this.radFifteen.Location = new System.Drawing.Point(12, 81);
            this.radFifteen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radFifteen.Name = "radFifteen";
            this.radFifteen.Size = new System.Drawing.Size(130, 29);
            this.radFifteen.TabIndex = 1;
            this.radFifteen.TabStop = true;
            this.radFifteen.Text = "15 Years";
            this.radFifteen.UseVisualStyleBackColor = true;
            // 
            // radTen
            // 
            this.radTen.AutoSize = true;
            this.radTen.Location = new System.Drawing.Point(12, 37);
            this.radTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(130, 29);
            this.radTen.TabIndex = 0;
            this.radTen.TabStop = true;
            this.radTen.Text = "10 Years";
            this.radTen.UseVisualStyleBackColor = true;
            // 
            // lblLoanpaymentcalculator
            // 
            this.lblLoanpaymentcalculator.AutoSize = true;
            this.lblLoanpaymentcalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanpaymentcalculator.Location = new System.Drawing.Point(108, 17);
            this.lblLoanpaymentcalculator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoanpaymentcalculator.Name = "lblLoanpaymentcalculator";
            this.lblLoanpaymentcalculator.Size = new System.Drawing.Size(400, 37);
            this.lblLoanpaymentcalculator.TabIndex = 8;
            this.lblLoanpaymentcalculator.Text = "Loan Payment Calculator";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(28, 294);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(546, 200);
            this.txtOutput.TabIndex = 9;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(60, 506);
            this.btnStats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(150, 44);
            this.btnStats.TabIndex = 10;
            this.btnStats.Text = "&Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 506);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(384, 506);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 577);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblLoanpaymentcalculator);
            this.Controls.Add(this.grpDuration);
            this.Controls.Add(this.txtLoanamount);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblLoanamount);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDuration.ResumeLayout(false);
            this.grpDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblLoanamount;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtLoanamount;
        private System.Windows.Forms.GroupBox grpDuration;
        private System.Windows.Forms.RadioButton radThirty;
        private System.Windows.Forms.RadioButton radTwenty;
        private System.Windows.Forms.RadioButton radFifteen;
        private System.Windows.Forms.RadioButton radTen;
        private System.Windows.Forms.Label lblLoanpaymentcalculator;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

