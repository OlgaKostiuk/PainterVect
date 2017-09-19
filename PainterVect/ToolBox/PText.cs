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
    public partial class PText : UserControl
    {
        public XCommand cmd { get; set; }
        public PText()
        {
            InitializeComponent();
            comboBoxVerticalAlign.SelectedIndex = 0;
            comboBoxHorizontalAlign.SelectedIndex = 0;
            btnTextColor.Click += new EventHandler((s, e) => cmd.setTextColor(s, e));
            btnFont.Click += new EventHandler((s, e) => cmd.setTextFont(s, e));
            textBoxText.TextChanged += new EventHandler((s, e) => cmd.setText(s, e, textBoxText.Text));
            numericUpDownAngle.ValueChanged += new EventHandler((s, e) => cmd.setTextAngle(s, e, (int)numericUpDownAngle.Value));
            comboBoxVerticalAlign.SelectedIndexChanged += new EventHandler((s, e) => cmd.setVerticalAlign(s, e, comboBoxVerticalAlign.SelectedItem.ToString()));
            comboBoxHorizontalAlign.SelectedIndexChanged += new EventHandler((s, e) => cmd.setHorizontalAlign(s, e, comboBoxHorizontalAlign.SelectedItem.ToString()));
        }
    }
}
