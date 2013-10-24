namespace TTMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.STUD = new System.Windows.Forms.Button();
            this.TEACH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STUD
            // 
            this.STUD.Location = new System.Drawing.Point(225, 132);
            this.STUD.Name = "STUD";
            this.STUD.Size = new System.Drawing.Size(186, 70);
            this.STUD.TabIndex = 0;
            this.STUD.Text = "STUDENT";
            this.STUD.UseVisualStyleBackColor = true;
            this.STUD.Click += new System.EventHandler(this.STUD_Click);
            // 
            // TEACH
            // 
            this.TEACH.Location = new System.Drawing.Point(225, 232);
            this.TEACH.Name = "TEACH";
            this.TEACH.Size = new System.Drawing.Size(186, 67);
            this.TEACH.TabIndex = 1;
            this.TEACH.Text = "TEACHER";
            this.TEACH.UseVisualStyleBackColor = true;
            this.TEACH.Click += new System.EventHandler(this.TEACH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TEACH);
            this.Controls.Add(this.STUD);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button STUD;
        private System.Windows.Forms.Button TEACH;
        private System.Windows.Forms.Button button1;
    }
}