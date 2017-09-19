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
    public partial class PColor : UserControl
    {
        public XCommand cmd { get; set; }
        public PColor()
        {
            InitializeComponent();
            btnColor.Click += new EventHandler((s,e)=>cmd.setColor(s,e));
            //btnColor.Click += BtnColor_Click;
        }

        //private void BtnColor_Click(object sender, EventArgs e)
        //{
        //    if(dlgColor.ShowDialog() == DialogResult.OK)
        //    {
        //        cmd.setColor(sender, e, dlgColor.Color);
        //    }
        //}
    }
}
