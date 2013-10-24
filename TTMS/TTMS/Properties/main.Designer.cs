namespace TTMS
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.LOGIN = new System.Windows.Forms.Button();
            this.NEWREG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(304, 224);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(223, 30);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // NEWREG
            // 
            this.NEWREG.Location = new System.Drawing.Point(304, 307);
            this.NEWREG.Name = "NEWREG";
            this.NEWREG.Size = new System.Drawing.Size(223, 30);
            this.NEWREG.TabIndex = 1;
            this.NEWREG.Text = "NEW REGISTRATION";
            this.NEWREG.UseVisualStyleBackColor = true;
            this.NEWREG.Click += new System.EventHandler(this.NEWREG_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "     TIME TABLE MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEWREG);
            this.Controls.Add(this.LOGIN);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button NEWREG;
        private System.Windows.Forms.Label label1;
    }
}