namespace MultiDbTest
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
            this.cboSelectDb = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblSelectedDb = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblConString = new System.Windows.Forms.Label();
            this.lstConString = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboSelectDb
            // 
            this.cboSelectDb.FormattingEnabled = true;
            this.cboSelectDb.Location = new System.Drawing.Point(12, 25);
            this.cboSelectDb.Name = "cboSelectDb";
            this.cboSelectDb.Size = new System.Drawing.Size(121, 21);
            this.cboSelectDb.TabIndex = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(12, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(86, 13);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Database";
            // 
            // lblSelectedDb
            // 
            this.lblSelectedDb.AutoSize = true;
            this.lblSelectedDb.Location = new System.Drawing.Point(9, 114);
            this.lblSelectedDb.Name = "lblSelectedDb";
            this.lblSelectedDb.Size = new System.Drawing.Size(147, 13);
            this.lblSelectedDb.TabIndex = 2;
            this.lblSelectedDb.Text = "Data from Selected Database";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(12, 68);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(121, 34);
            this.btnShowData.TabIndex = 5;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(12, 130);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(120, 43);
            this.lstData.TabIndex = 6;
            // 
            // lblConString
            // 
            this.lblConString.AutoSize = true;
            this.lblConString.Location = new System.Drawing.Point(12, 189);
            this.lblConString.Name = "lblConString";
            this.lblConString.Size = new System.Drawing.Size(197, 13);
            this.lblConString.TabIndex = 7;
            this.lblConString.Text = "Connection string for selected database:";
            // 
            // lstConString
            // 
            this.lstConString.FormattingEnabled = true;
            this.lstConString.Location = new System.Drawing.Point(12, 206);
            this.lstConString.Name = "lstConString";
            this.lstConString.Size = new System.Drawing.Size(770, 43);
            this.lstConString.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 261);
            this.Controls.Add(this.lstConString);
            this.Controls.Add(this.lblConString);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.lblSelectedDb);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cboSelectDb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectDb;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblSelectedDb;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblConString;
        private System.Windows.Forms.ListBox lstConString;
    }
}

