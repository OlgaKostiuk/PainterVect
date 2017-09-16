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
    public partial class PLineWidth : UserControl
    {
        public XCommand cmd { get; set; }
        public PLineWidth()
        {
            InitializeComponent();
            comboBoxLineWidth.SelectedIndex = 0;
            comboBoxLineWidth.SelectedIndexChanged += new EventHandler((s,e)=>cmd.setWidth(s,e,comboBoxLineWidth.SelectedItem.ToString()));
        }
    }
}
