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
            this._lblLeftBorder.Size = new System.Drawing.Size(1, 227);
            this._lblLeftBorder.TabIndex = 1;
            // 
            // ExpandCollapsePanel
            // 
            this.Controls.Add(this._lblLeftBorder);
            this.Controls.Add(this._btnExpandCollapse);
            this.Name = "ExpandCollapsePanel";
            this.Size = new System.Drawing.Size(424, 286);
            this.ResumeLayout(false);

        }

        #endregion

        private MakarovDev.ExpandCollapsePanel.ExpandCollapseButton _btnExpandCollapse;
        private System.Windows.Forms.Label _lblLeftBorder;
    }
}
