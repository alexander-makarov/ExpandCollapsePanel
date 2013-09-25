using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MakarovDev.ExpandCollapsePanel
{
    /// <summary>
    /// Button with two states: expanded/collapsed
    /// </summary>
    public partial class ExpandCollapseButton : UserControl
    {
        /// <summary>
        /// Image displays expanded state of button
        /// </summary>
        private readonly Image _expanded;
        /// <summary>
        /// Image displays collapsed state of button
        /// </summary>
        private readonly Image _collapsed;

        /// <summary>
        /// Set flag for expand or collapse button
        /// (true - expanded, false - collapsed)
        /// </summary>
        private bool _isExpanded;

        /// <summary>
        /// Set flag for expand or collapse button
        /// (true - expanded, false - collapsed)
        /// </summary>
        [Browsable(true)]
        [Category("ExpandCollapseButton")]
        [Description("Expand or collapse button.")]
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                _isExpanded = value;
                OnExpandCollapse();
            }
        }

        /// <summary>
        /// Header
        /// </summary>
        [Category("ExpandCollapseButton")]
        [Description("Header")]
        [Browsable(true)]
        public override string Text
        {
            get
            {
                return lblHeader.Text;
            }
            set
            {
                lblHeader.Text = value;
            }
        }

        /// <summary>
        /// Font used for displays header text
        /// </summary>
        public override Font Font
        {
            get
            {
                return lblHeader.Font;
            }
            set
            {
                lblHeader.Font = value;
            }
        }

        /// <summary>
        /// Foreground color used for displays header text
        /// </summary>
        public override Color ForeColor
        {
            get
            {
                return lblHeader.ForeColor;
            }
            set
            {
                lblHeader.ForeColor = value;
            }
        }


        /// <summary>
        /// Occurs when the button has expanded or collapsed
        /// </summary>
        [Category("ExpandCollapseButton")]
        [Description("Occurs when the button has expanded or collapsed.")]
        [Browsable(true)]
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;   
        
        public ExpandCollapseButton()
        {
            InitializeComponent();

            #region initialize readonly expanded/collapsed state bitmaps:
            // collapsed bitmap:
            _collapsed = pictureBox1.Image;

            // expanded bitmap is rotated collapsed bitmap:
            _expanded = new Bitmap(pictureBox1.Image);
            _expanded.RotateFlip(RotateFlipType.Rotate180FlipNone);
            #endregion

            // initial state of panel - collapsed
            _isExpanded = false;
        }

        /// <summary>
        /// Handle clicks from PictureBox and Header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnClick(object sender, EventArgs e)
        {
            // just invert current state
            IsExpanded = !IsExpanded;
        }

        /// <summary>
        /// Handle state changing
        /// </summary>
        protected virtual void OnExpandCollapse()
        {
            // set appropriate bitmap
            pictureBox1.Image = _isExpanded ? _expanded : _collapsed;

            // and fire the event:
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, new ExpandCollapseEventArgs(_isExpanded));
        }
    }
}
