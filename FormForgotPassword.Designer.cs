namespace BienSoXe
{
    partial class FormForgotPassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_getcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_verifycode = new System.Windows.Forms.Button();
            this.textBox_zipcode = new System.Windows.Forms.TextBox();
            this.label_zipcode = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.button_verifycode);
            this.groupBox1.Controls.Add(this.textBox_zipcode);
            this.groupBox1.Controls.Add(this.label_zipcode);
            this.groupBox1.Controls.Add(this.button_getcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Location = new System.Drawing.Point(60, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_getcode
            // 
            this.button_getcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_getcode.Location = new System.Drawing.Point(279, 218);
            this.button_getcode.Name = "button_getcode";
            this.button_getcode.Size = new System.Drawing.Size(348, 36);
            this.button_getcode.TabIndex = 23;
            this.button_getcode.Text = "Get Code";
            this.button_getcode.UseVisualStyleBackColor = true;
            this.button_getcode.Click += new System.EventHandler(this.button_getcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Forgot Password";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_email.Location = new System.Drawing.Point(279, 175);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(348, 27);
            this.textBox_email.TabIndex = 18;
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_Leave);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_email.Location = new System.Drawing.Point(175, 178);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(62, 20);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "Email:";
            // 
            // button_verifycode
            // 
            this.button_verifycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_verifycode.Location = new System.Drawing.Point(279, 344);
            this.button_verifycode.Name = "button_verifycode";
            this.button_verifycode.Size = new System.Drawing.Size(348, 36);
            this.button_verifycode.TabIndex = 26;
            this.button_verifycode.Text = "Verify Code";
            this.button_verifycode.UseVisualStyleBackColor = true;
            this.button_verifycode.Click += new System.EventHandler(this.button_verifycode_Click);
            // 
            // textBox_zipcode
            // 
            this.textBox_zipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_zipcode.Location = new System.Drawing.Point(279, 304);
            this.textBox_zipcode.Name = "textBox_zipcode";
            this.textBox_zipcode.Size = new System.Drawing.Size(348, 27);
            this.textBox_zipcode.TabIndex = 25;
            this.textBox_zipcode.Enter += new System.EventHandler(this.textBox_zipcode_Enter);
            this.textBox_zipcode.Leave += new System.EventHandler(this.textBox_zipcode_Leave);
            // 
            // label_zipcode
            // 
            this.label_zipcode.AutoSize = true;
            this.label_zipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_zipcode.Location = new System.Drawing.Point(175, 307);
            this.label_zipcode.Name = "label_zipcode";
            this.label_zipcode.Size = new System.Drawing.Size(89, 20);
            this.label_zipcode.TabIndex = 24;
            this.label_zipcode.Text = "Zip Code:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_status.Location = new System.Drawing.Point(202, 40);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(485, 28);
            this.label_status.TabIndex = 27;
            this.label_status.Text = "You can reset your password using this form";
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormForgotPassword";
            this.Text = "FormForgotPassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_getcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_verifycode;
        private System.Windows.Forms.TextBox textBox_zipcode;
        private System.Windows.Forms.Label label_zipcode;
        private System.Windows.Forms.Label label_status;
    }
}