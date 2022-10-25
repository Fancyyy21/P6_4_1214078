namespace P6_4_1214078
{
    partial class FormMaulanaLatihan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaulanaLatihan));
            this.FormPendaftaran = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Numeric = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Uppercase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lowercase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Selesai = new System.Windows.Forms.Button();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Words2 = new System.Windows.Forms.TextBox();
            this.Words1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPendaftaran
            // 
            this.FormPendaftaran.AutoSize = true;
            this.FormPendaftaran.BackColor = System.Drawing.Color.Transparent;
            this.FormPendaftaran.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormPendaftaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormPendaftaran.Location = new System.Drawing.Point(360, 33);
            this.FormPendaftaran.Name = "FormPendaftaran";
            this.FormPendaftaran.Size = new System.Drawing.Size(239, 37);
            this.FormPendaftaran.TabIndex = 32;
            this.FormPendaftaran.Text = "FORMULIR DIRI";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(561, 115);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(223, 22);
            this.txtID.TabIndex = 31;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // Numeric
            // 
            this.Numeric.AutoSize = true;
            this.Numeric.BackColor = System.Drawing.Color.Transparent;
            this.Numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric.Location = new System.Drawing.Point(254, 116);
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(104, 18);
            this.Numeric.TabIndex = 29;
            this.Numeric.Text = "ID (Numeric)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(561, 160);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 22);
            this.txtName.TabIndex = 34;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name (Char)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(561, 210);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(254, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Height > Weight";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(561, 308);
            this.Height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(223, 22);
            this.Height.TabIndex = 40;
            this.Height.Leave += new System.EventHandler(this.Height_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Height";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(561, 358);
            this.Weight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(223, 22);
            this.Weight.TabIndex = 42;
            this.Weight.Leave += new System.EventHandler(this.Weight_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Weight";
            // 
            // Uppercase
            // 
            this.Uppercase.Location = new System.Drawing.Point(561, 409);
            this.Uppercase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Uppercase.MaxLength = 255;
            this.Uppercase.Name = "Uppercase";
            this.Uppercase.Size = new System.Drawing.Size(223, 22);
            this.Uppercase.TabIndex = 44;
            this.Uppercase.Leave += new System.EventHandler(this.Uppercase_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Hobi1 (UPPERCASE) ";
            // 
            // Lowercase
            // 
            this.Lowercase.Location = new System.Drawing.Point(561, 454);
            this.Lowercase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lowercase.MaxLength = 255;
            this.Lowercase.Name = "Lowercase";
            this.Lowercase.Size = new System.Drawing.Size(223, 22);
            this.Lowercase.TabIndex = 46;
            this.Lowercase.Leave += new System.EventHandler(this.Lowercase_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Hobi2 (lowercase) ";
            // 
            // Selesai
            // 
            this.Selesai.BackColor = System.Drawing.Color.Plum;
            this.Selesai.Location = new System.Drawing.Point(526, 624);
            this.Selesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(108, 30);
            this.Selesai.TabIndex = 48;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = false;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // Tampilkan
            // 
            this.Tampilkan.BackColor = System.Drawing.Color.Plum;
            this.Tampilkan.Location = new System.Drawing.Point(376, 624);
            this.Tampilkan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(111, 30);
            this.Tampilkan.TabIndex = 47;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = false;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Words1 or Number (Max Lenght 5)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(254, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Words2 or Number (Max Lenght 8)";
            // 
            // Words2
            // 
            this.Words2.Location = new System.Drawing.Point(561, 541);
            this.Words2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Words2.MaxLength = 255;
            this.Words2.Name = "Words2";
            this.Words2.Size = new System.Drawing.Size(223, 22);
            this.Words2.TabIndex = 52;
            this.Words2.Leave += new System.EventHandler(this.Words2_Leave);
            // 
            // Words1
            // 
            this.Words1.Location = new System.Drawing.Point(561, 497);
            this.Words1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Words1.MaxLength = 255;
            this.Words1.Name = "Words1";
            this.Words1.Size = new System.Drawing.Size(223, 22);
            this.Words1.TabIndex = 53;
            this.Words1.Leave += new System.EventHandler(this.Words1_Leave);
            // 
            // FormMaulanaLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 706);
            this.Controls.Add(this.Words1);
            this.Controls.Add(this.Words2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.Lowercase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Uppercase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormPendaftaran);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Numeric);
            this.Name = "FormMaulanaLatihan";
            this.Text = "FormMaulanaLatihan";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FormPendaftaran;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Numeric;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Uppercase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Lowercase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Selesai;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Words1;
        private System.Windows.Forms.TextBox Words2;
        private System.Windows.Forms.Label label10;
    }
}

