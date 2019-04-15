namespace PercentageProgramTishamI
{
    partial class PercentageProgramForm
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(193, 55);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(385, 17);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a number grade (0---- to 4++) to get your percentage:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(291, 93);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 1;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(193, 140);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(385, 17);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Enter a number grade (0---- to 4++) to get your percentage:";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(461, 92);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // PercentageProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblEnter);
            this.Name = "PercentageProgramForm";
            this.Text = "Percentage Program by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnOutput;
    }
}

