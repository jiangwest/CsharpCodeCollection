namespace WebSnatchDemo1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSnatch = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // btnSnatch
            // 
            this.btnSnatch.Location = new System.Drawing.Point(16, 64);
            this.btnSnatch.Name = "btnSnatch";
            this.btnSnatch.Size = new System.Drawing.Size(75, 23);
            this.btnSnatch.TabIndex = 1;
            this.btnSnatch.Text = "Snatch";
            this.btnSnatch.UseVisualStyleBackColor = true;
            this.btnSnatch.Click += new System.EventHandler(this.btnSnatch_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(62, 28);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(237, 25);
            this.txtURL.TabIndex = 2;
            // 
            // txtWebPage
            // 
            this.txtWebPage.Location = new System.Drawing.Point(11, 94);
            this.txtWebPage.Multiline = true;
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(287, 132);
            this.txtWebPage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 255);
            this.Controls.Add(this.txtWebPage);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnSnatch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSnatch;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtWebPage;
    }
}

