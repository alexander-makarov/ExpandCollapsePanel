using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpandCollapsePanelDemo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();

            // Attention! Unfortunately for correct handling need to set ExpandCollapsePanel control properties in code..
            expandCollapsePanel1.IsExpanded = false;
            expandCollapsePanel2.IsExpanded = false;
            expandCollapsePanel3.IsExpanded = false;
            expandCollapsePanel4.IsExpanded = false;

            expandCollapsePanel1.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Bold);
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
