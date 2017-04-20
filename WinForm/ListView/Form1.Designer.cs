namespace ListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTile = new System.Windows.Forms.RadioButton();
            this.radioButtonDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallIcon = new System.Windows.Forms.RadioButton();
            this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(16, 10);
            this.labelCurrentPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(95, 15);
            this.labelCurrentPath.TabIndex = 0;
            this.labelCurrentPath.Text = "CurrentPath";
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilesAndFolders.LargeImageList = this.imageListLarge;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(16, 29);
            this.listViewFilesAndFolders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(616, 241);
            this.listViewFilesAndFolders.SmallImageList = this.imageListSmall;
            this.listViewFilesAndFolders.TabIndex = 1;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Folder32x32.ICO");
            this.imageListLarge.Images.SetKeyName(1, "Text 32x32.ICO");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Folder 16x16.ICO");
            this.imageListSmall.Images.SetKeyName(1, "Text 16x16.ICO");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonTile);
            this.groupBox1.Controls.Add(this.radioButtonDetails);
            this.groupBox1.Controls.Add(this.radioButtonList);
            this.groupBox1.Controls.Add(this.radioButtonSmallIcon);
            this.groupBox1.Controls.Add(this.radioButtonLargeIcon);
            this.groupBox1.Location = new System.Drawing.Point(641, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(153, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Mode";
            // 
            // radioButtonTile
            // 
            this.radioButtonTile.AutoSize = true;
            this.radioButtonTile.Location = new System.Drawing.Point(25, 130);
            this.radioButtonTile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonTile.Name = "radioButtonTile";
            this.radioButtonTile.Size = new System.Drawing.Size(60, 19);
            this.radioButtonTile.TabIndex = 4;
            this.radioButtonTile.Text = "Tile";
            this.radioButtonTile.UseVisualStyleBackColor = true;
            this.radioButtonTile.CheckedChanged += new System.EventHandler(this.radioButtonTile_CheckedChanged);
            // 
            // radioButtonDetails
            // 
            this.radioButtonDetails.AutoSize = true;
            this.radioButtonDetails.Checked = true;
            this.radioButtonDetails.Location = new System.Drawing.Point(25, 104);
            this.radioButtonDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonDetails.Name = "radioButtonDetails";
            this.radioButtonDetails.Size = new System.Drawing.Size(84, 19);
            this.radioButtonDetails.TabIndex = 3;
            this.radioButtonDetails.TabStop = true;
            this.radioButtonDetails.Text = "Details";
            this.radioButtonDetails.UseVisualStyleBackColor = true;
            this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.radioButtonDetails_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(25, 77);
            this.radioButtonList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(60, 19);
            this.radioButtonList.TabIndex = 2;
            this.radioButtonList.Text = "List";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButtonList_CheckedChanged);
            // 
            // radioButtonSmallIcon
            // 
            this.radioButtonSmallIcon.AutoSize = true;
            this.radioButtonSmallIcon.Location = new System.Drawing.Point(25, 51);
            this.radioButtonSmallIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSmallIcon.Name = "radioButtonSmallIcon";
            this.radioButtonSmallIcon.Size = new System.Drawing.Size(100, 19);
            this.radioButtonSmallIcon.TabIndex = 1;
            this.radioButtonSmallIcon.Text = "SmallIcon";
            this.radioButtonSmallIcon.UseVisualStyleBackColor = true;
            this.radioButtonSmallIcon.CheckedChanged += new System.EventHandler(this.radioButtonSmallIcon_CheckedChanged);
            // 
            // radioButtonLargeIcon
            // 
            this.radioButtonLargeIcon.AutoSize = true;
            this.radioButtonLargeIcon.Location = new System.Drawing.Point(25, 23);
            this.radioButtonLargeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            this.radioButtonLargeIcon.Size = new System.Drawing.Size(100, 19);
            this.radioButtonLargeIcon.TabIndex = 0;
            this.radioButtonLargeIcon.Text = "LargeIcon";
            this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
            this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.radioButtonLargeIcon_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.Location = new System.Drawing.Point(356, 277);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 27);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(790, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 317);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Controls.Add(this.labelCurrentPath);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelCurrentPath;
    private System.Windows.Forms.ListView listViewFilesAndFolders;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonTile;
    private System.Windows.Forms.RadioButton radioButtonDetails;
    private System.Windows.Forms.RadioButton radioButtonList;
    private System.Windows.Forms.RadioButton radioButtonSmallIcon;
    private System.Windows.Forms.RadioButton radioButtonLargeIcon;
    private System.Windows.Forms.Button buttonBack;
    private System.Windows.Forms.ImageList imageListLarge;
    private System.Windows.Forms.ImageList imageListSmall;
    private System.Windows.Forms.RadioButton radioButton1;
  }
}

