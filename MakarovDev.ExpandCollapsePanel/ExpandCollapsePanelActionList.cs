using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace MakarovDev.ExpandCollapsePanel
{
    /// <summary>
    /// DesignerActionList-derived class defines smart tag entries and resultant actions. 
    /// <remarks>http://msdn.microsoft.com/en-us/library/ms171829.aspx</remarks>
    /// </summary>
    public class ExpandCollapsePanelActionList : System.ComponentModel.Design.DesignerActionList
    {
        private ExpandCollapsePanel panel;

        private DesignerActionUIService designerActionUISvc = null;

        //The constructor associates the control  
        //with the smart tag list. 
        public ExpandCollapsePanelActionList(IComponent component)
            : base(component)
        {
            this.panel = component as ExpandCollapsePanel;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc =
                GetService(typeof(DesignerActionUIService))
                as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of  
        // GetProperties enables undo and menu updates to work properly. 
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(panel)[propName];
            if (null == prop)
                throw new ArgumentException(
                    "Matching ExpandCollapsePanel property not found!",
                    propName);
            else
                return prop;
        }

        // Properties that are targets of DesignerActionPropertyItem entries. 
        public bool IsExpanded
        {
            get
            {
                return panel.IsExpanded;
            }
            set
            {
                GetPropertyByName("IsExpanded").SetValue(panel, value);

                // Refresh the list. 
                //this.designerActionUISvc.Refresh(this.Component);
            }
        }

        public ExpandCollapseButton.ExpandButtonStyle ButtonStyle
        {
            get
            {
                return panel.ButtonStyle;
            }
            set
            {
                GetPropertyByName("ButtonStyle").SetValue(panel, value);

                // Refresh the list. 
                //this.designerActionUISvc.Refresh(this.Component);
            }
        }

        public ExpandCollapseButton.ExpandButtonSize ButtonSize
        {
            get
            {
                return panel.ButtonSize;
            }
            set
            {
                GetPropertyByName("ButtonSize").SetValue(panel, value);

                // Refresh the list. 
                //this.designerActionUISvc.Refresh(this.Component);
            }
        }
        

        // Implementation of this abstract method creates smart tag   
        // items, associates their targets, and collects into list. 
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));
            //items.Add(new DesignerActionHeaderItem("Information"));

            //Boolean property for locking color selections.
            items.Add(new DesignerActionPropertyItem("IsExpanded",
                                                     "IsExpanded", "Appearance",
                                                     "Expand/collapse the panel."));
            items.Add(new DesignerActionPropertyItem("ButtonStyle",
                                                     "ButtonStyle", "Appearance",
                                                     "Visual style of the expand-collapse button."));
            items.Add(new DesignerActionPropertyItem("ButtonSize",
                                                     "ButtonSize", "Appearance",
                                                     "Size preset of the expand-collapse button."));

            return items;
        }
    }
}