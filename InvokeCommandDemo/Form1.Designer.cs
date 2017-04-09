namespace WindowsFormsApplication1
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
            this.txtExecute = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtArgument = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "command (exe/bat)";
            // 
            // txtExecute
            // 
            this.txtExecute.Location = new System.Drawing.Point(161, 12);
            this.txtExecute.Name = "txtExecute";
            this.txtExecute.Size = new System.Drawing.Size(152, 25);
            this.txtExecute.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(369, 386);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 58);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(561, 313);
            this.txtResult.TabIndex = 3;
            // 
            // txtArgument
            // 
            this.txtArgument.Location = new System.Drawing.Point(414, 12);
            this.txtArgument.Name = "txtArgument";
            this.txtArgument.Size = new System.Drawing.Size(160, 25);
            this.txtArgument.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "arguments";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(461, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArgument);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtExecute);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExecute;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtArgument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

