using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSmartTagsExample
{
    [Designer(typeof(MyControlDesigner))]
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        public Color SomeColorProperty { get; set; }
        public string[] Items { get; set; }
    }
}
