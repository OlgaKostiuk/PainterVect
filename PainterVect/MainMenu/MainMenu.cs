using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect.MainMenu
{
    public partial class MainMenu : UserControl
    {
        public XCommand cmd { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            colorToolStripMenuItem.Click += ToolStripBtnColor_Click;
            lineWidthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setWidth(s, e, e.ClickedItem.Text));
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setType(s, e, e.ClickedItem.Tag.ToString()));
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
