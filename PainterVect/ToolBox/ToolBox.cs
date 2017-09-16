using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect.ToolBox
{
    public partial class ToolBox : UserControl
    {
        public XCommand cmd { get; set; }
        public ToolBox()
        {
            InitializeComponent();
            Load += ToolBox_Load;
        }

        private void ToolBox_Load(object sender, EventArgs e)
        {
            pColor1.cmd = cmd;
            pLineWidth1.cmd = cmd;
            pType1.cmd = cmd;
        }
    }
}
