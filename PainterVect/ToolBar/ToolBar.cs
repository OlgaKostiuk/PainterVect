using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect.ToolBar
{
    public partial class ToolBar : UserControl
    {
        public XCommand cmd { get; set; }
        public ToolBar()
        {
            InitializeComponent();
            toolStripBtnColor.Click += ToolStripBtnColor_Click;
            toolStripDropDownBtnLineWidth.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setWidth(s, e, e.ClickedItem.Text));
            toolStripDropDownBtnType.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setType(s, e, e.ClickedItem.Tag.ToString()));
            toolStripBtnOpen.Click += new EventHandler((s, e) => cmd.openFigures(s,e));
            toolStripBtnSave.Click += new EventHandler((s, e) => cmd.saveFigures(s, e));
        }

        private void ToolStripBtnColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                cmd.setColor(sender, e, dlgColor.Color);
            }
        }

    }
}
