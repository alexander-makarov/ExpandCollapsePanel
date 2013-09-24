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
            this.SuspendLayout();
            // 
            // _btnExpandCollapse
            // 
            this._btnExpandCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExpandCollapse.AutoSize = false;
            this._btnExpandCollapse.Location = new System.Drawing.Point(3, 3);
            this._btnExpandCollapse.Name = "_btnExpandCollapse";
            this._btnExpandCollapse.Size = new System.Drawing.Size(359, 40);
            this._btnExpandCollapse.TabIndex = 0;
            // 
            // ExpandCollapsePanel
            // 
            this.Controls.Add(this._btnExpandCollapse);
            this.Size = new System.Drawing.Size(365, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MakarovDev.ExpandCollapsePanel.ExpandCollapseButton _btnExpandCollapse;
    }
}
