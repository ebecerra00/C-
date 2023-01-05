namespace BecerraEstevan_Assignment11
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.grpFocus = new System.Windows.Forms.GroupBox();
            this.radSystem = new System.Windows.Forms.RadioButton();
            this.radCyber = new System.Windows.Forms.RadioButton();
            this.radNET = new System.Windows.Forms.RadioButton();
            this.radCIT = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFocus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(92, 9);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(62, 13);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test File 10";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(32, 61);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(32, 13);
            this.lblGPA.TabIndex = 2;
            this.lblGPA.Text = "GPA:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(80, 58);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 2;
            // 
            // grpFocus
            // 
            this.grpFocus.Controls.Add(this.radSystem);
            this.grpFocus.Controls.Add(this.radCyber);
            this.grpFocus.Controls.Add(this.radNET);
            this.grpFocus.Controls.Add(this.radCIT);
            this.grpFocus.Location = new System.Drawing.Point(186, 9);
            this.grpFocus.Name = "grpFocus";
            this.grpFocus.Size = new System.Drawing.Size(120, 113);
            this.grpFocus.TabIndex = 5;
            this.grpFocus.TabStop = false;
            this.grpFocus.Text = "Focus";
            // 
            // radSystem
            // 
            this.radSystem.AutoSize = true;
            this.radSystem.Location = new System.Drawing.Point(21, 88);
            this.radSystem.Name = "radSystem";
            this.radSystem.Size = new System.Drawing.Size(59, 17);
            this.radSystem.TabIndex = 3;
            this.radSystem.TabStop = true;
            this.radSystem.Text = "System";
            this.radSystem.UseVisualStyleBackColor = true;
            // 
            // radCyber
            // 
            this.radCyber.AutoSize = true;
            this.radCyber.Location = new System.Drawing.Point(21, 65);
            this.radCyber.Name = "radCyber";
            this.radCyber.Size = new System.Drawing.Size(88, 17);
            this.radCyber.TabIndex = 2;
            this.radCyber.TabStop = true;
            this.radCyber.Text = "Cybersecurity";
            this.radCyber.UseVisualStyleBackColor = true;
            // 
            // radNET
            // 
            this.radNET.AutoSize = true;
            this.radNET.Location = new System.Drawing.Point(21, 42);
            this.radNET.Name = "radNET";
            this.radNET.Size = new System.Drawing.Size(47, 17);
            this.radNET.TabIndex = 1;
            this.radNET.TabStop = true;
            this.radNET.Text = "NET";
            this.radNET.UseVisualStyleBackColor = true;
            // 
            // radCIT
            // 
            this.radCIT.AutoSize = true;
            this.radCIT.Location = new System.Drawing.Point(21, 19);
            this.radCIT.Name = "radCIT";
            this.radCIT.Size = new System.Drawing.Size(42, 17);
            this.radCIT.TabIndex = 0;
            this.radCIT.TabStop = true;
            this.radCIT.Text = "CIT";
            this.radCIT.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(95, 94);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // lstShow
            // 
            this.lstShow.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 14;
            this.lstShow.Location = new System.Drawing.Point(35, 123);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(271, 88);
            this.lstShow.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 224);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(93, 224);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 9;
            this.btnAverage.Text = "&Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 267);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.grpFocus);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFocus.ResumeLayout(false);
            this.grpFocus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.GroupBox grpFocus;
        private System.Windows.Forms.RadioButton radSystem;
        private System.Windows.Forms.RadioButton radCyber;
        private System.Windows.Forms.RadioButton radNET;
        private System.Windows.Forms.RadioButton radCIT;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

