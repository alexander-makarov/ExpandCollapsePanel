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
        /// Конструктор
        /// </summary>
        public ExpandCollapsePanel()
        {
            InitializeComponent();
            
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
                Collaspse();
            }

            // Событие свёртывания/разворачивания панели
            EventHandler<ExpandCollapseEventArgs> handler = OnExpandCollapse;
            if (handler != null)
                handler(this, e);
        }

        /// <summary>
        /// Флаг. true - контейнер развёрнут. false - контейнер свёрнут. 
        /// Установка флага вызывает свёртывание/развёртывание контейнера
        /// </summary>
        [Description("Свёртывание/развёртывание контейнера")]
        public bool IsExpanded 
        {
            get { return _btnExpandCollapse.IsExpanded; }
            set { _btnExpandCollapse.IsExpanded = value; }
        }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Description("Заголовок")]
        [Browsable(true)]
        public override string Text
        {
            get { return _btnExpandCollapse.Text; }
            set { _btnExpandCollapse.Text = value; }
        }
        
        /// <summary>
        /// Скрыто т.к. выставление в true имеет мало смысла.
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
        /// Развернуть контейнер
        /// </summary>
        protected virtual void Expand()
        {
            // Ширина не изменяется
            int width = Size.Width;
            // Высота рассчитывается исходя из сохранённой высоты панели в развёрнутом состоянии
            int height = _expandedHeight;
            // Установка нового размера панели
            Size = new Size(width, height);
        }

        /// <summary>
        /// Свернуть контейнер
        /// </summary>
        protected virtual void Collaspse()
        {
            // перед тем как свернуть запоминаем высоту панели
            _expandedHeight = Size.Height;

            // при сворачивании подгоняем высоту панели под размер кнопки:
            // Ширина не изменяется
            int width = Size.Width;
            // Высота рассчитывается исходя из высоты кнопки
            int height = _btnExpandCollapse.Location.Y + _btnExpandCollapse.Size.Height + _btnExpandCollapse.Margin.Bottom;
            // Установка нового размера панели
            Size = new Size(width, height);
        }

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
        }

        /// <summary>
        /// Событие: сворачивание/разворачивание панели
        /// </summary>
        public event EventHandler<ExpandCollapseEventArgs> OnExpandCollapse;      
    }
}
