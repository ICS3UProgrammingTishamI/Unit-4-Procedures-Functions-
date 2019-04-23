namespace StringEqualityTishamI
{
    partial class frmStringEquality
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblEqual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(63, 88);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(358, 20);
            this.txtInput1.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(60, 46);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(560, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Slap some text in here, and then this form will check if they have the same chara" +
    "cters (caps ignored, spaces counted)";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(442, 88);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(315, 20);
            this.txtInput2.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(266, 138);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(155, 64);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(60, 219);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(560, 13);
            this.lblEqual.TabIndex = 4;
            this.lblEqual.Text = "Slap some text in here, and then this form will check if they have the same chara" +
    "cters (caps ignored, spaces counted)";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput1);
            this.Name = "frmStringEquality";
            this.Text = "String Equality by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblEqual;
    }
}

