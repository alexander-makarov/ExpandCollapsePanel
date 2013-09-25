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
            expandCollapsePanel1.IsExpanded = false;
            expandCollapsePanel2.IsExpanded = false;
            expandCollapsePanel3.IsExpanded = false;
            expandCollapsePanel4.IsExpanded = false;

            const BorderStyle border = BorderStyle.None;
            expandCollapsePanel1.BorderStyle = border;
            expandCollapsePanel2.BorderStyle = border;
            expandCollapsePanel3.BorderStyle = border;
            expandCollapsePanel4.BorderStyle = border;
            advancedFlowLayoutPanel1.BorderStyle = border;
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
    }
}
