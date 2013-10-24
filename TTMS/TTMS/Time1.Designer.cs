namespace TTMS
{
    partial class Time1
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
            this.DAY = new System.Windows.Forms.ComboBox();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.SUBCODE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DAY
            // 
            this.DAY.FormattingEnabled = true;
            this.DAY.Items.AddRange(new object[] {
            "MON",
            "TUE",
            "WED",
            "THU",
            "FRI"});
            this.DAY.Location = new System.Drawing.Point(289, 105);
            this.DAY.Name = "DAY";
            this.DAY.Size = new System.Drawing.Size(121, 21);
            this.DAY.TabIndex = 0;
            // 
            // SUBMIT
            // 
            this.SUBMIT.Location = new System.Drawing.Point(307, 172);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT.TabIndex = 1;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // SUBCODE
            // 
            this.SUBCODE.AutoSize = true;
            this.SUBCODE.Location = new System.Drawing.Point(182, 228);
            this.SUBCODE.Name = "SUBCODE";
            this.SUBCODE.Size = new System.Drawing.Size(0, 13);
            this.SUBCODE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // Time1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(781, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SUBCODE);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.DAY);
            this.Name = "Time1";
            this.Text = "Time1";
            this.Load += new System.EventHandler(this.Time1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DAY;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.Label SUBCODE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}