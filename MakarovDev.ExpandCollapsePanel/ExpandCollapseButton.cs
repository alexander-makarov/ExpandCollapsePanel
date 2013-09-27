using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Image _expanded;
        /// <summary>
        /// Image displays collapsed state of button
        /// </summary>
        private Image _collapsed;

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

            #region initialize expanded/collapsed state bitmaps:
            InitButtonStyle(ExpandButtonStyle.Style5);
            #endregion

            // initial state of panel - collapsed
            _isExpanded = false;
        }

        private ExpandButtonStyle _expandButtonStyle = ExpandButtonStyle.Style1;
        public ExpandButtonStyle ButtonStyle
        {
            get { return _expandButtonStyle; }
            set
            {
                if (_expandButtonStyle != value)
                {
                    _expandButtonStyle = value;
                    InitButtonStyle(_expandButtonStyle);
                }
            }
        }

        private void InitButtonStyle(ExpandButtonStyle style)
        {
            switch (style)
            {
                case ExpandButtonStyle.Style1:
                    pictureBox1.Image = Properties.Resources._1downarrow1;
                    pictureBox1.Location = new Point(0, 3);
                    pictureBox1.Size = new Size(35, 35);
                    lblLine.Location = new Point(41, 28);
                    lblHeader.Location = new Point(41, 3);
                    break;
                case ExpandButtonStyle.Style2:
                    var bmp = Properties.Resources.Upload;
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox1.Image = bmp;
                    pictureBox1.Location = new Point(0, 3);
                    pictureBox1.Size = new Size(35, 35);
                    lblLine.Location = new Point(41, 28);
                    lblHeader.Location = new Point(41, 3);
                    break;
                case ExpandButtonStyle.Style3:
                    pictureBox1.Image = Properties.Resources.icon_expand;
                    pictureBox1.Location = new Point(0, 3);
                    pictureBox1.Size = new Size(35, 35);
                    lblLine.Location = new Point(41, 28);
                    lblHeader.Location = new Point(41, 3);
                    break;
                case ExpandButtonStyle.Style4:
                    bmp = Properties.Resources.up_256;
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox1.Image = bmp;
                    pictureBox1.Location = new Point(0, 3);
                    pictureBox1.Size = new Size(35, 35);
                    lblLine.Location = new Point(41, 28);
                    lblHeader.Location = new Point(41, 3);
                    break;
                case ExpandButtonStyle.Style5:
                    bmp = Properties.Resources._1downarrow1;
                    pictureBox1.Image = bmp;
                    pictureBox1.Location = new Point(0, 3);
                    pictureBox1.Size = new Size(24, 24);
                    lblLine.Location = new Point(30, 22);
                    lblHeader.Location = new Point(30, 3);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("style");
            }

            // collapsed bitmap:
            _collapsed = pictureBox1.Image;

            // expanded bitmap is rotated collapsed bitmap:
            _expanded = MakeGrayscale3(pictureBox1.Image);
            _expanded.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        public enum ExpandButtonStyle
        {
            Style1, Style2, Style3, Style4, Style5, Style6
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
            //lblHeader.ForeColor = _isExpanded ? Color.DarkGray : Color.SteelBlue;

            // and fire the event:
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, new ExpandCollapseEventArgs(_isExpanded));
        }

        /// <summary>
        /// Utillity method for createing a grayscale copy of image
        /// </summary>
        /// <param name="original">original image</param>
        /// <returns>grayscale copy of image</returns>
        public static Bitmap MakeGrayscale3(Image original)
        {
            // create a blank bitmap the same size as original
            var newBitmap = new Bitmap(original.Width, original.Height);

            // get a graphics object from the new image
            using (var g = Graphics.FromImage(newBitmap))
            {

                // create the grayscale ColorMatrix
                var colorMatrix = new ColorMatrix(
                    new float[][]
                        {
                            new float[] {.3f, .3f, .3f, 0, 0},
                            new float[] {.59f, .59f, .59f, 0, 0},
                            new float[] {.11f, .11f, .11f, 0, 0},
                            new float[] {0, 0, 0, 1, 0},
                            new float[] {0, 0, 0, 0, 1}
                        });

                // create some image attributes
                var attributes = new ImageAttributes();

                // set the color matrix attribute
                attributes.SetColorMatrix(colorMatrix);

                // draw the original image on the new image
                // using the grayscale color matrix
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                            0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

                // dispose the Graphics object
                g.Dispose();
            }

            return newBitmap;
        }
    }
}
