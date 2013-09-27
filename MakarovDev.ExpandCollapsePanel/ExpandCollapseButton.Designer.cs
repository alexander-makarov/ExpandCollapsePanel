namespace MakarovDev.ExpandCollapsePanel
{
    partial class ExpandCollapseButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLine = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(41, 28);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(382, 1);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "label1";
            this.lblLine.Click += new System.EventHandler(this.OnClick);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(41, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(68, 15);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Заголовок";
            this.lblHeader.Click += new System.EventHandler(this.OnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MakarovDev.ExpandCollapsePanel.Properties.Resources._1downarrow1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClick);
            // 
            // ExpandCollapseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLine);
            this.MaximumSize = new System.Drawing.Size(0, 40);
            this.MinimumSize = new System.Drawing.Size(150, 40);
            this.Name = "ExpandCollapseButton";
            this.Size = new System.Drawing.Size(150, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
    }
}
