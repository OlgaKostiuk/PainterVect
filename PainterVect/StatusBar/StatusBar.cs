using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect.StatusBar
{
    public partial class StatusBar : UserControl
    {
        public XCommand cmd { get; set; }
        public StatusBar()
        {
            InitializeComponent();
            Load += StatusBar_Load;
        }

        private void StatusBar_Load(object sender, EventArgs e)
        {
            cmd.onCoordsChanged += Cmd_setCoordsEvent;
        }

        private void Cmd_setCoordsEvent(Point p)
        {
            if(p.X == 0 && p.Y == 0)
                coordsLabel.Text = "";
            else
                coordsLabel.Text = $"({p.X}, {p.Y})";
        }
    }
}
