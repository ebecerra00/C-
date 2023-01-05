namespace BecerraEstevan_Assignment_081
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(121, 64);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(40, 64);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(9, 167);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(77, 38);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 6;
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(9, 93);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(237, 69);
            this.lstShow.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(37, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 213);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
    }
}

