namespace MakarovDev.ExpandCollapsePanel
{
    partial class ExpandCollapsePanel
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
            this._btnExpandCollapse = new MakarovDev.ExpandCollapsePanel.ExpandCollapseButton();
            this._lblLeftBorder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lblBottomBorder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnExpandCollapse
            // 
            this._btnExpandCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExpandCollapse.IsExpanded = false;
            this._btnExpandCollapse.Location = new System.Drawing.Point(3, 3);
            this._btnExpandCollapse.MaximumSize = new System.Drawing.Size(0, 40);
            this._btnExpandCollapse.MinimumSize = new System.Drawing.Size(150, 40);
            this._btnExpandCollapse.Name = "_btnExpandCollapse";
            this._btnExpandCollapse.Size = new System.Drawing.Size(418, 40);
            this._btnExpandCollapse.TabIndex = 0;
            // 
            // _lblLeftBorder
            // 
            this._lblLeftBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lblLeftBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lblLeftBorder.Enabled = false;
            this._lblLeftBorder.Location = new System.Drawing.Point(20, 50);
            this._lblLeftBorder.Name = "_lblLeftBorder";
            this._lblLeftBorder.Size = new System.Drawing.Size(10, 227);
            this._lblLeftBorder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(411, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 227);
            this.label1.TabIndex = 1;
            // 
            // _lblBottomBorder
            // 
            this._lblBottomBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lblBottomBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lblBottomBorder.Enabled = false;
            this._lblBottomBorder.Location = new System.Drawing.Point(27, 267);
            this._lblBottomBorder.Name = "_lblBottomBorder";
            this._lblBottomBorder.Size = new System.Drawing.Size(378, 10);
            this._lblBottomBorder.TabIndex = 1;
            // 
            // ExpandCollapsePanel
            // 
            this.Controls.Add(this._lblBottomBorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblLeftBorder);
            this.Controls.Add(this._btnExpandCollapse);
            this.Name = "ExpandCollapsePanel";
            this.Size = new System.Drawing.Size(424, 286);
            this.ResumeLayout(false);

        }

        #endregion

        private MakarovDev.ExpandCollapsePanel.ExpandCollapseButton _btnExpandCollapse;
        private System.Windows.Forms.Label _lblLeftBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblBottomBorder;
    }
}
