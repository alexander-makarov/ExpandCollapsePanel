using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MakarovDev.ExpandCollapsePanel;

namespace MakarovDev.ExpandCollapsePanel
{
    public partial class ExpandCollapseButton : UserControl
    {
        private readonly Image _expanded;
        private readonly Image _collapsed;
        /// <summary>
        /// Флаг. true - контейнер развёрнут. false - контейнер свёрнут. 
        /// </summary>
        private bool _isExpanded;

        /// <summary>
        /// Флаг. true - контейнер развёрнут. false - контейнер свёрнут. 
        /// Установка флага вызывает свёртывание/развёртывание контейнера
        /// </summary>
        [Description("Свёртывание/развёртывание контейнера")]
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
        /// Событие: сворачивание/разворачивание
        /// </summary>
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;   
        
        public ExpandCollapseButton()
        {
            InitializeComponent();
            _isExpanded = false; // в самом начале состояние - свернуто
            
            _collapsed = pictureBox1.Image;
            
            _expanded = new Bitmap(pictureBox1.Image);
            _expanded.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        /// <summary>
        /// Обрабатываем клики по контролу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnClick(object sender, EventArgs e)
        {
            IsExpanded = !IsExpanded;
        }

        protected virtual void OnExpandCollapse()
        {
            pictureBox1.Image = _isExpanded ? _expanded : _collapsed;

            // Событие развёртывания панели
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, new ExpandCollapseEventArgs(_isExpanded));
        }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Description("Заголовок")]
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
    }
}
