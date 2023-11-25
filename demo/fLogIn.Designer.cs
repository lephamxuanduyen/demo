namespace demo
{
    partial class fLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogIn));
            this.paLogIn = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.paPass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.laPass = new System.Windows.Forms.Label();
            this.paName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.laName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paLogIn.SuspendLayout();
            this.paPass.SuspendLayout();
            this.paName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paLogIn
            // 
            this.paLogIn.Controls.Add(this.textBox1);
            this.paLogIn.Controls.Add(this.btnLogIn);
            this.paLogIn.Controls.Add(this.btnExit);
            this.paLogIn.Controls.Add(this.paPass);
            this.paLogIn.Controls.Add(this.paName);
            this.paLogIn.Location = new System.Drawing.Point(465, 5);
            this.paLogIn.Name = "paLogIn";
            this.paLogIn.Size = new System.Drawing.Size(369, 494);
            this.paLogIn.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(103, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 45);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "TESTDB";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(94, 295);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(91, 36);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(191, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // paPass
            // 
            this.paPass.Controls.Add(this.tbPass);
            this.paPass.Controls.Add(this.laPass);
            this.paPass.Location = new System.Drawing.Point(5, 218);
            this.paPass.Name = "paPass";
            this.paPass.Size = new System.Drawing.Size(357, 53);
            this.paPass.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(8, 24);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(346, 22);
            this.tbPass.TabIndex = 1;
            this.tbPass.Text = "TestDB";
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // laPass
            // 
            this.laPass.AutoSize = true;
            this.laPass.Location = new System.Drawing.Point(5, 5);
            this.laPass.Name = "laPass";
            this.laPass.Size = new System.Drawing.Size(62, 16);
            this.laPass.TabIndex = 0;
            this.laPass.Text = "Mật Khẩu";
            // 
            // paName
            // 
            this.paName.Controls.Add(this.tbName);
            this.paName.Controls.Add(this.laName);
            this.paName.Location = new System.Drawing.Point(8, 142);
            this.paName.Name = "paName";
            this.paName.Size = new System.Drawing.Size(354, 56);
            this.paName.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(345, 22);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "admin";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(5, 5);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(102, 16);
            this.laName.TabIndex = 0;
            this.laName.Text = "Tên Đăng Nhập";
            this.laName.Click += new System.EventHandler(this.laName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 494);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fLogIn
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(840, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paLogIn);
            this.Name = "fLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogIn_FormClosing);
            this.paLogIn.ResumeLayout(false);
            this.paLogIn.PerformLayout();
            this.paPass.ResumeLayout(false);
            this.paPass.PerformLayout();
            this.paName.ResumeLayout(false);
            this.paName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paLogIn;
        private System.Windows.Forms.Panel paPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label laPass;
        private System.Windows.Forms.Panel paName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

