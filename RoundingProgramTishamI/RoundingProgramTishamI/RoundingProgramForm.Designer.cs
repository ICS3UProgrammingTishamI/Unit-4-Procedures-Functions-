namespace RoundingProgramTishamI
{
    partial class frmRoundingProgram
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
            this.lblEnterNumbers = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.nudRound = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRounded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterNumbers
            // 
            this.lblEnterNumbers.AutoSize = true;
            this.lblEnterNumbers.Location = new System.Drawing.Point(128, 46);
            this.lblEnterNumbers.Name = "lblEnterNumbers";
            this.lblEnterNumbers.Size = new System.Drawing.Size(449, 13);
            this.lblEnterNumbers.TabIndex = 0;
            this.lblEnterNumbers.Text = "Enter the number you want to round, and to how many decimal places you want to ro" +
    "und it by:";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(131, 75);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(446, 20);
            this.txtNumbers.TabIndex = 1;
            // 
            // nudRound
            // 
            this.nudRound.Location = new System.Drawing.Point(131, 115);
            this.nudRound.Name = "nudRound";
            this.nudRound.Size = new System.Drawing.Size(120, 20);
            this.nudRound.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(425, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRounded
            // 
            this.lblRounded.AutoSize = true;
            this.lblRounded.Location = new System.Drawing.Point(131, 161);
            this.lblRounded.Name = "lblRounded";
            this.lblRounded.Size = new System.Drawing.Size(35, 13);
            this.lblRounded.TabIndex = 4;
            this.lblRounded.Text = "label1";
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRounded);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudRound);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblEnterNumbers);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program by Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumbers;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.NumericUpDown nudRound;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRounded;
    }
}

