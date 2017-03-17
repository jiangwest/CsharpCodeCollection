namespace winHexDump
{
    public partial class textForm
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
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxtBox
            // 
            this.richTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBox.Location = new System.Drawing.Point(0, 0);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(282, 255);
            this.richTxtBox.TabIndex = 0;
            this.richTxtBox.Text = "";
            // 
            // textForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.richTxtBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "textForm";
            this.Text = "textForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.textForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox;

        public string RichTxtBox
        {
            get { return richTxtBox.Text;  }
            set { richTxtBox.Text = value;  }
        }
    }
}