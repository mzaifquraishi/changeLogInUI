namespace changeUi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usrn = new System.Windows.Forms.Label();
            this.setreg = new System.Windows.Forms.Button();
            this.brws = new System.Windows.Forms.Button();
            this.resetreg = new System.Windows.Forms.Button();
            this.setImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(158, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // usrn
            // 
            this.usrn.AutoSize = true;
            this.usrn.Location = new System.Drawing.Point(182, 189);
            this.usrn.Name = "usrn";
            this.usrn.Size = new System.Drawing.Size(35, 13);
            this.usrn.TabIndex = 1;
            this.usrn.Text = "label1";
            // 
            // setreg
            // 
            this.setreg.Location = new System.Drawing.Point(119, 259);
            this.setreg.Name = "setreg";
            this.setreg.Size = new System.Drawing.Size(75, 23);
            this.setreg.TabIndex = 2;
            this.setreg.Text = "create reg.";
            this.setreg.UseVisualStyleBackColor = true;
            this.setreg.Click += new System.EventHandler(this.setreg_Click);
            // 
            // brws
            // 
            this.brws.Location = new System.Drawing.Point(212, 223);
            this.brws.Name = "brws";
            this.brws.Size = new System.Drawing.Size(75, 23);
            this.brws.TabIndex = 2;
            this.brws.Text = "browse Image";
            this.brws.UseVisualStyleBackColor = true;
            this.brws.Click += new System.EventHandler(this.brws_Click_1);
            // 
            // resetreg
            // 
            this.resetreg.Location = new System.Drawing.Point(212, 259);
            this.resetreg.Name = "resetreg";
            this.resetreg.Size = new System.Drawing.Size(75, 23);
            this.resetreg.TabIndex = 2;
            this.resetreg.Text = "reset";
            this.resetreg.UseVisualStyleBackColor = true;
            this.resetreg.Click += new System.EventHandler(this.resetreg_Click);
            // 
            // setImg
            // 
            this.setImg.Location = new System.Drawing.Point(119, 223);
            this.setImg.Name = "setImg";
            this.setImg.Size = new System.Drawing.Size(75, 23);
            this.setImg.TabIndex = 2;
            this.setImg.Text = "setImg";
            this.setImg.UseVisualStyleBackColor = true;
            this.setImg.Click += new System.EventHandler(this.setImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.setImg);
            this.Controls.Add(this.resetreg);
            this.Controls.Add(this.brws);
            this.Controls.Add(this.setreg);
            this.Controls.Add(this.usrn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label usrn;
        private System.Windows.Forms.Button setreg;
        private System.Windows.Forms.Button brws;
        private System.Windows.Forms.Button resetreg;
        private System.Windows.Forms.Button setImg;
    }
}

