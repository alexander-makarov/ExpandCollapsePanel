using System.Windows.Forms;

namespace MakarovDev.ExpandCollapsePanel
{
    /// <summary>
    /// FlowLayoutPanel с расширенными возможностями
    /// </summary>
    public class AdvancedFlowLayoutPanel : FlowLayoutPanel
    {
        /// <summary>
        /// Обработка события изменения размера контрола
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(System.EventArgs e)
        {
            // Подгонка ширины дочерних контролов под ширину контейнера
            foreach (Control c in Controls)
            {
                FillControlWidth(c);
            }
            // Базовая реализация метода
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Установить ширину дочерненго контрола согласно ширине контейнера
        /// </summary>
        /// <param name="c">Контрол, ширина которого устанавливается</param>
        protected void FillControlWidth(Control c)
        {
            c.Size = new System.Drawing.Size(ClientSize.Width - c.Margin.Left - c.Margin.Right, c.Height);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}
