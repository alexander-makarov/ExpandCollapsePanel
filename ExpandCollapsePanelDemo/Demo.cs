using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MakarovDev.ExpandCollapsePanel;

namespace ExpandCollapsePanelDemo
{
    public partial class Demo : Form
    {
        private readonly List<ExpandCollapsePanel> _panelsList = new List<ExpandCollapsePanel>();
        public Demo()
        {
            InitializeComponent();

            // make a list with all ExpandCollapsePanel controls for easy access:
            _panelsList.AddRange(new []
            {
                expandCollapsePanel1,expandCollapsePanel2,expandCollapsePanel3,
                expandCollapsePanel4,expandCollapsePanel5,expandCollapsePanel6,
                expandCollapsePanel7,expandCollapsePanel8,expandCollapsePanel9,
                expandCollapsePanel10
            });

            // Attention! Unfortunately for correct handling need to set ExpandCollapsePanel control properties in code..
            foreach (var panel in _panelsList)
            {
                panel.UseAnimation = false; // disable animation for immediately collapsing
                panel.IsExpanded = false; // collapse all panels
                panel.UseAnimation = true; // enable animation for further user clicks
            }

            // only for main top panel make font Bold
            expandCollapsePanel1.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Bold);

            // initialize comboBox with ExpandButtonStyles:
            var styles = Enum.GetNames(typeof (ExpandCollapseButton.ExpandButtonStyle));
            _comboStyles.Items.AddRange(styles);
            _comboStyles.SelectedValueChanged += ComboStylesOnSelectedValueChanged;
            _comboStyles.SelectedIndex = 0;

            // initialize comboBox with ExpandButtonSizes:
            var sizes = Enum.GetNames(typeof(ExpandCollapseButton.ExpandButtonSize));
            _comboSizes.Items.AddRange(sizes);
            _comboSizes.SelectedValueChanged += ComboSizesOnSelectedValueChanged;
            _comboSizes.SelectedIndex = 0;
        }

        private void ComboSizesOnSelectedValueChanged(object sender, EventArgs eventArgs)
        {
            var sizeStr = _comboSizes.SelectedItem as string;
            var size = (ExpandCollapseButton.ExpandButtonSize)Enum.Parse(typeof(ExpandCollapseButton.ExpandButtonSize), sizeStr);

            foreach (var panel in _panelsList)
            {
                panel.ButtonSize = size;
            }
        }

        private void ComboStylesOnSelectedValueChanged(object sender, EventArgs eventArgs)
        {
            var styleStr = _comboStyles.SelectedItem as string;
            var style = (ExpandCollapseButton.ExpandButtonStyle)Enum.Parse(typeof(ExpandCollapseButton.ExpandButtonStyle), styleStr);

            foreach (var panel in _panelsList)
            {
                panel.ButtonStyle = style;
            }
        }

        private void expandCollapsePanel1_ExpandCollapse(object sender, MakarovDev.ExpandCollapsePanel.ExpandCollapseEventArgs e)
        {
            if (e.IsExpanded)
            {
                expandCollapsePanel1.Text = "Top expander. Click for collapse..";
            }
            else
            {
                expandCollapsePanel1.Text = "Top expander. Click for expand the panel content and see more..";
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            expandCollapsePanel5.IsExpanded = true;
            expandCollapsePanel6.IsExpanded = true;
            expandCollapsePanel7.IsExpanded = true;
            expandCollapsePanel8.IsExpanded = true;
            expandCollapsePanel9.IsExpanded = true;
            expandCollapsePanel10.IsExpanded = true;
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            expandCollapsePanel5.IsExpanded = false;
            expandCollapsePanel6.IsExpanded = false;
            expandCollapsePanel7.IsExpanded = false;
            expandCollapsePanel8.IsExpanded = false;
            expandCollapsePanel9.IsExpanded = false;
            expandCollapsePanel10.IsExpanded = false;
        }
    }
}
