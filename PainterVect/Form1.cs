using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XCommand cmd = new XCommand();

            pDraw1.cmd = cmd;
            toolBox1.cmd = cmd;
            mainMenu1.cmd = cmd;
            toolBar1.cmd = cmd;
            statusBar1.cmd = cmd;

            cmd.pdraw = pDraw1;
        }
    }
}
