namespace CylVolumeTishamI
{
    partial class frmCylVolume
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalcVol = new System.Windows.Forms.Button();
            this.lblVol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(309, 64);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(309, 107);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(386, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(386, 104);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 3;
            // 
            // btnCalcVol
            // 
            this.btnCalcVol.Location = new System.Drawing.Point(312, 147);
            this.btnCalcVol.Name = "btnCalcVol";
            this.btnCalcVol.Size = new System.Drawing.Size(174, 62);
            this.btnCalcVol.TabIndex = 4;
            this.btnCalcVol.Text = "CALCULATE VOLUME";
            this.btnCalcVol.UseVisualStyleBackColor = true;
            this.btnCalcVol.Click += new System.EventHandler(this.btnCalcVol_Click);
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(309, 223);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(43, 13);
            this.lblVol.TabIndex = 5;
            this.lblVol.Text = "Radius:";
            // 
            // frmCylVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.btnCalcVol);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblHeight);
            this.Name = "frmCylVolume";
            this.Text = "Cylinder Volume by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalcVol;
        private System.Windows.Forms.Label lblVol;
    }
}

