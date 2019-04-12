namespace OptionalParametersTishamI
{
    partial class frmOptionalParameters
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
            this.txtApartmentNum = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblEnterInfo = new System.Windows.Forms.Label();
            this.lblExitInfo = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApartmentNum
            // 
            this.txtApartmentNum.Location = new System.Drawing.Point(72, 117);
            this.txtApartmentNum.Name = "txtApartmentNum";
            this.txtApartmentNum.Size = new System.Drawing.Size(191, 20);
            this.txtApartmentNum.TabIndex = 0;
            this.txtApartmentNum.Text = "Apartment Number (Optional)";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(72, 221);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(191, 20);
            this.txtPostalCode.TabIndex = 1;
            this.txtPostalCode.Text = "Postal Code";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(72, 195);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(191, 20);
            this.txtProvince.TabIndex = 2;
            this.txtProvince.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(72, 169);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(191, 20);
            this.txtCity.TabIndex = 3;
            this.txtCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(72, 143);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(191, 20);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.Text = "Street Address";
            // 
            // lblEnterInfo
            // 
            this.lblEnterInfo.AutoSize = true;
            this.lblEnterInfo.Location = new System.Drawing.Point(111, 83);
            this.lblEnterInfo.Name = "lblEnterInfo";
            this.lblEnterInfo.Size = new System.Drawing.Size(109, 13);
            this.lblEnterInfo.TabIndex = 5;
            this.lblEnterInfo.Text = "Enter your information";
            // 
            // lblExitInfo
            // 
            this.lblExitInfo.AutoSize = true;
            this.lblExitInfo.Location = new System.Drawing.Point(30, 265);
            this.lblExitInfo.Name = "lblExitInfo";
            this.lblExitInfo.Size = new System.Drawing.Size(86, 13);
            this.lblExitInfo.TabIndex = 6;
            this.lblExitInfo.Text = "Your information:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(284, 117);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(294, 124);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmOptionalParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblExitInfo);
            this.Controls.Add(this.lblEnterInfo);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtApartmentNum);
            this.Name = "frmOptionalParameters";
            this.Text = "Optional Parameters by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApartmentNum;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblEnterInfo;
        private System.Windows.Forms.Label lblExitInfo;
        private System.Windows.Forms.Button btnEnter;
    }
}

