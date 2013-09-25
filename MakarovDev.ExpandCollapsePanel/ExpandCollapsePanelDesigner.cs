using System.ComponentModel.Design;

namespace MakarovDev.ExpandCollapsePanel
{
    /// <summary>
    /// Designer for the ExpandCollapsePanel control with support for a smart tag panel.
    /// <remarks>http://msdn.microsoft.com/en-us/library/ms171829.aspx</remarks>
    /// </summary>
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ExpandCollapsePanelDesigner : System.Windows.Forms.Design.ScrollableControlDesigner
    {
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu. 
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(
                        new ExpandCollapsePanelActionList(this.Component));
                }
                return actionLists;
            }
        }
    }
}