using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace ControlSmartTagsExample
{
    public class MyControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection actionList;
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionList == null)
                    actionList = new DesignerActionListCollection(new[] {
                    new MyControlActionList(this) });
                return actionList;
            }
        }
    }

    public class MyControlActionList : DesignerActionList
    {
        ControlDesigner designer;
        MyControl control;
        public MyControlActionList(ControlDesigner designer) : base(designer.Component)
        {
            this.designer = designer;
            control = (MyControl)designer.Control;
        }
        public Color SomeColorProperty
        {
            get { return control.SomeColorProperty; }
            set
            {
                TypeDescriptor.GetProperties(
                    (object)Component)["SomeColorProperty"]
                    .SetValue((object)this.Component, (object)value);
            }
        }
        public void EditItems()
        {
            var editorServiceContext = typeof(ControlDesigner).Assembly.GetTypes()
                .Where(x => x.Name == "EditorServiceContext").FirstOrDefault();
            var editValue = editorServiceContext.GetMethod("EditValue",
                System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.Public);
            editValue.Invoke(null, new object[] { designer, this.Component, "Items" });
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            return new DesignerActionItemCollection() {
            new DesignerActionMethodItem(this, "EditItems", "Edit Items",  true),
            new DesignerActionPropertyItem("SomeColorProperty", "Some Color"),
        };
        }
    }
}
