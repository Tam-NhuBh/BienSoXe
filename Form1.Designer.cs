
namespace BienSoXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_cam = new System.Windows.Forms.Button();
            this.btn_cap = new System.Windows.Forms.Button();
            this.btn_offcam = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_contract = new System.Windows.Forms.Button();
            this.btn_charge = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label_licenseplates = new System.Windows.Forms.Label();
            this.richTextBox_licenseplates = new System.Windows.Forms.RichTextBox();
            this.label_vehicleclassification = new System.Windows.Forms.Label();
            this.radioButton_motorbike = new System.Windows.Forms.RadioButton();
            this.radioButton_bicycle = new System.Windows.Forms.RadioButton();
            this.radioButton_car = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 580);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(434, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_cam
            // 
            this.btn_cam.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cam.Location = new System.Drawing.Point(572, 621);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(215, 48);
            this.btn_cam.TabIndex = 1;
            this.btn_cam.Text = "Turn on Camera";
            this.btn_cam.UseVisualStyleBackColor = false;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_cap
            // 
            this.btn_cap.BackColor = System.Drawing.Color.Transparent;
            this.btn_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cap.Location = new System.Drawing.Point(572, 676);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(215, 45);
            this.btn_cap.TabIndex = 2;
            this.btn_cap.Text = "Capture";
            this.btn_cap.UseVisualStyleBackColor = false;
            this.btn_cap.Click += new System.EventHandler(this.btn_cap_Click);
            // 
            // btn_offcam
            // 
            this.btn_offcam.BackColor = System.Drawing.Color.Transparent;
            this.btn_offcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_offcam.Location = new System.Drawing.Point(572, 727);
            this.btn_offcam.Name = "btn_offcam";
            this.btn_offcam.Size = new System.Drawing.Size(215, 49);
            this.btn_offcam.TabIndex = 3;
            this.btn_offcam.Text = "Turn off Camera";
            this.btn_offcam.UseVisualStyleBackColor = false;
            this.btn_offcam.Click += new System.EventHandler(this.btn_offcam_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Jpeg image|*.jpeg|Png image|*.png|Gif image|*.gif";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Save.Location = new System.Drawing.Point(1186, 502);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 38);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Check.Location = new System.Drawing.Point(1186, 546);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(170, 35);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            // 
            // btn_contract
            // 
            this.btn_contract.BackColor = System.Drawing.Color.Transparent;
            this.btn_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_contract.Location = new System.Drawing.Point(1186, 587);
            this.btn_contract.Name = "btn_contract";
            this.btn_contract.Size = new System.Drawing.Size(170, 38);
            this.btn_contract.TabIndex = 6;
            this.btn_contract.Text = "Contract";
            this.btn_contract.UseVisualStyleBackColor = false;
            // 
            // btn_charge
            // 
            this.btn_charge.BackColor = System.Drawing.Color.Transparent;
            this.btn_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_charge.Location = new System.Drawing.Point(1186, 631);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(170, 38);
            this.btn_charge.TabIndex = 7;
            this.btn_charge.Text = "Charge";
            this.btn_charge.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1090, 270);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(421, 27);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2022, 4, 3, 0, 0, 0, 0);
            // 
            // label_licenseplates
            // 
            this.label_licenseplates.AutoSize = true;
            this.label_licenseplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_licenseplates.Location = new System.Drawing.Point(1086, 12);
            this.label_licenseplates.Name = "label_licenseplates";
            this.label_licenseplates.Size = new System.Drawing.Size(134, 20);
            this.label_licenseplates.TabIndex = 11;
            this.label_licenseplates.Text = "License Plates";
            // 
            // richTextBox_licenseplates
            // 
            this.richTextBox_licenseplates.Location = new System.Drawing.Point(1090, 35);
            this.richTextBox_licenseplates.Name = "richTextBox_licenseplates";
            this.richTextBox_licenseplates.Size = new System.Drawing.Size(421, 195);
            this.richTextBox_licenseplates.TabIndex = 4;
            this.richTextBox_licenseplates.Text = "";
            // 
            // label_vehicleclassification
            // 
            this.label_vehicleclassification.AutoSize = true;
            this.label_vehicleclassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_vehicleclassification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_vehicleclassification.Location = new System.Drawing.Point(1086, 354);
            this.label_vehicleclassification.Name = "label_vehicleclassification";
            this.label_vehicleclassification.Size = new System.Drawing.Size(192, 20);
            this.label_vehicleclassification.TabIndex = 16;
            this.label_vehicleclassification.Text = "Vehicle Classification";
            // 
            // radioButton_motorbike
            // 
            this.radioButton_motorbike.AutoSize = true;
            this.radioButton_motorbike.Location = new System.Drawing.Point(15, 13);
            this.radioButton_motorbike.Name = "radioButton_motorbike";
            this.radioButton_motorbike.Size = new System.Drawing.Size(97, 20);
            this.radioButton_motorbike.TabIndex = 17;
            this.radioButton_motorbike.TabStop = true;
            this.radioButton_motorbike.Text = "Motorbike";
            this.radioButton_motorbike.UseVisualStyleBackColor = true;
            // 
            // radioButton_bicycle
            // 
            this.radioButton_bicycle.AutoSize = true;
            this.radioButton_bicycle.Location = new System.Drawing.Point(141, 13);
            this.radioButton_bicycle.Name = "radioButton_bicycle";
            this.radioButton_bicycle.Size = new System.Drawing.Size(79, 20);
            this.radioButton_bicycle.TabIndex = 18;
            this.radioButton_bicycle.TabStop = true;
            this.radioButton_bicycle.Text = "Bicycle";
            this.radioButton_bicycle.UseVisualStyleBackColor = true;
            // 
            // radioButton_car
            // 
            this.radioButton_car.AutoSize = true;
            this.radioButton_car.Location = new System.Drawing.Point(248, 13);
            this.radioButton_car.Name = "radioButton_car";
            this.radioButton_car.Size = new System.Drawing.Size(52, 20);
            this.radioButton_car.TabIndex = 19;
            this.radioButton_car.TabStop = true;
            this.radioButton_car.Text = "Car";
            this.radioButton_car.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_car);
            this.panel1.Controls.Add(this.radioButton_bicycle);
            this.panel1.Controls.Add(this.radioButton_motorbike);
            this.panel1.Location = new System.Drawing.Point(1090, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 56);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1070, 555);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1871, 813);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_vehicleclassification);
            this.Controls.Add(this.richTextBox_licenseplates);
            this.Controls.Add(this.label_licenseplates);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.btn_contract);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_offcam);
            this.Controls.Add(this.btn_cap);
            this.Controls.Add(this.btn_cam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Button btn_cap;
        private System.Windows.Forms.Button btn_offcam;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_contract;
        private System.Windows.Forms.Button btn_charge;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label_licenseplates;
        private System.Windows.Forms.RichTextBox richTextBox_licenseplates;
        private System.Windows.Forms.Label label_vehicleclassification;
        private System.Windows.Forms.RadioButton radioButton_motorbike;
        private System.Windows.Forms.RadioButton radioButton_bicycle;
        private System.Windows.Forms.RadioButton radioButton_car;
        private System.Windows.Forms.Panel panel1;
    }
}

