using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MakarovDev.ExpandCollapsePanel
{
    /// <summary>
    /// Простой разворачиваемый/сворачиваемый контейнер (панель)
    /// </summary>
    [Designer(typeof(ExpandCollapsePanelDesigner))]
    public partial class ExpandCollapsePanel : Panel
    {
        /// <summary>
        /// Высота панели в развёрнутом состоянии
        /// </summary>
        private int _expandedHeight;

        /// <summary>
        /// Высота панели в свёрнутом состоянии
        /// </summary>
        private readonly int _collapsedHeight;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ExpandCollapsePanel()
        {
            InitializeComponent();

            // при сворачивании подгоняем высоту панели под размер кнопки:
            _collapsedHeight = _btnExpandCollapse.Location.Y + _btnExpandCollapse.Size.Height + _btnExpandCollapse.Margin.Bottom;
            
            // сразу отмасштабируем вручную кнопку сокрытия раскрытия панели
            _btnExpandCollapse.Size = new Size(ClientSize.Width - _btnExpandCollapse.Margin.Left - _btnExpandCollapse.Margin.Right,
                         _btnExpandCollapse.Height);

            // несмотря на то что размер мы проставляем вручную, задания якорей с автосайзом, обеспечивает правильную прорисовку в дизайнере форм
            _btnExpandCollapse.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            _btnExpandCollapse.AutoSize = true;

            // начальное состояние панели - развернута
            _btnExpandCollapse.IsExpanded = true;
            // подписываемся на все следующие изменения состояния по клику на кнопке:
            _btnExpandCollapse.ExpandCollapse += BtnExpandCollapseExpandCollapse;
         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExpandCollapseExpandCollapse(object sender, ExpandCollapseEventArgs e)
        {
            if (e.IsExpanded)
            {
                Expand();
            }
            else
            {
                Collapse();
            }

            // Событие свёртывания/разворачивания панели
            EventHandler<ExpandCollapseEventArgs> handler = ExpandCollapse;
            if (handler != null)
                handler(this, e);
        }

        /// <summary>
        /// Флаг. true - контейнер развёрнут. false - контейнер свёрнут. 
        /// Установка флага вызывает свёртывание/развёртывание контейнера
        /// </summary>
        [Category("ExpandCollapsePanel")]
        [Description("Expand or collapse panel content")]
        [Browsable(true)]
        public bool IsExpanded 
        {
            get { return _btnExpandCollapse.IsExpanded; }
            set { _btnExpandCollapse.IsExpanded = value; }
        }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Category("ExpandCollapsePanel")]
        [Description("Header")]
        [Browsable(true)]
        public override string Text
        {
            get { return _btnExpandCollapse.Text; }
            set { _btnExpandCollapse.Text = value; }
        }
        
        /// <summary>
        /// AutoScroll property
        /// <remarks>Overridden only to hide from designer as mindless and useless</remarks>
        /// </summary>
        [Browsable(false)]
        public override bool AutoScroll
        {
            get
            {
                return base.AutoScroll;
            }
            set
            {
                base.AutoScroll = value;
            }
        }

        /// <summary>
        /// Expand panel content
        /// </summary>
        protected virtual void Expand()
        {
            // Установка нового размера панели
            Size = new Size(Size.Width, _expandedHeight);
        }

        /// <summary>
        /// Collapse panel content
        /// </summary>
        protected virtual void Collapse()
        {
            // перед тем как свернуть запоминаем высоту панели
            _expandedHeight = Size.Height;

            // Установка нового размера панели
            Size = new Size(Size.Width, _collapsedHeight);
        }

        private Size _previousSize = Size.Empty;
        private Size _previousParentSize = Size.Empty;

        /// <summary>
        /// Реакция на изменение размера панели
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // отмасштабируем вручную кнопку сокрытия раскрытия панели
            _btnExpandCollapse.Size = new Size(ClientSize.Width - _btnExpandCollapse.Margin.Left - _btnExpandCollapse.Margin.Right,
                _btnExpandCollapse.Height);
            
            #region Anchor to Bottom handling for collapsed panel

            int height = Size.Height;
            if (!IsExpanded // if panel collapsed
                && ((Anchor & AnchorStyles.Bottom) != 0) //and panel's Anchor property sets to Bottom
                && Size.Height != _collapsedHeight // and panel height is changed (it could happens only if parent control just has resized)
                && Parent != null) // and panel has the parent control
            {
                _expandedHeight += Parent.Height - _previousParentSize.Height;//Size.Height - _previousSize.Height;
                // при сворачивании подгоняем высоту панели под размер кнопки:
                // Высота рассчитывается исходя из высоты кнопки
                height = _collapsedHeight;
            }
            _previousSize = Size;
            if(Parent != null)
                _previousParentSize = Parent.Size;

            if (Size.Height != height)
            {
                // Установка нового размера панели
                Size = new Size(Size.Width, height);
            }
            #endregion
        }

        /// <summary>
        /// Occurs when the panel has expanded or collapsed
        /// </summary>
        [Category("ExpandCollapsePanel")]
        [Description("Occurs when the panel has expanded or collapsed.")]
        [Browsable(true)]
        public event EventHandler<ExpandCollapseEventArgs> ExpandCollapse;      
    }
}
