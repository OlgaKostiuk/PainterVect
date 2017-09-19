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
            colorToolStripMenuItem.Click += new EventHandler((s,e) => cmd.setColor(s,e));
            lineWidthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setWidth(s, e, e.ClickedItem.Text));
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setType(s, e, e.ClickedItem.Tag.ToString()));
            openToolStripMenuItem.Click += new EventHandler((s, e) => cmd.openFigures(s, e));
            saveToolStripMenuItem.Click += new EventHandler((s, e) => cmd.saveFigures(s, e));

            textColorToolStripMenuItem.Click += new EventHandler((s, e) => cmd.setTextColor(s, e));
            fontToolStripMenuItem.Click += new EventHandler((s, e) => cmd.setTextFont(s, e));
            textToolStripTextBox.TextChanged += new EventHandler((s, e) => cmd.setText(s, e, textToolStripTextBox.Text));
            verticalAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setVerticalAlign(s, e, verticalAlignToolStripMenuItem.Text));
            horizontalAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => cmd.setVerticalAlign(s, e, horizontalAlignToolStripMenuItem.Text));
            angleToolStripTextBox.TextChanged += new EventHandler((s, e) => cmd.setTextAngle(s, e, int.Parse(angleToolStripTextBox.Text)));
        }
    }
}
