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
            toolStripBtnColor.Click += new EventHandler((s,e)=>cmd.setColor(s,e));
            toolStripDropDownBtnLineWidth.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setWidth(s, e, e.ClickedItem.Text));
            toolStripDropDownBtnType.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setType(s, e, e.ClickedItem.Tag.ToString()));
            toolStripBtnOpen.Click += new EventHandler((s, e) => cmd.openFigures(s,e));
            toolStripBtnSave.Click += new EventHandler((s, e) => cmd.saveFigures(s, e));

            textColorToolStripMenuItem.Click += new EventHandler((s, e) => cmd.setTextColor(s, e));
            fontToolStripMenuItem.Click += new EventHandler((s, e) => cmd.setTextFont(s, e));
            textToolStripTextBox.TextChanged += new EventHandler((s, e) => cmd.setText(s, e, textToolStripTextBox.Text));
            verticalAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setVerticalAlign(s, e, verticalAlignToolStripMenuItem.Text));
            horizontalAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setVerticalAlign(s, e, horizontalAlignToolStripMenuItem.Text));
            angleToolStripTextBox.TextChanged += new EventHandler((s, e) => cmd.setTextAngle(s, e, int.Parse(angleToolStripTextBox.Text)));
        }

    }
}
