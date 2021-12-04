using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors_v2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        private void colorBar_Scroll(object sender, EventArgs e) {
            int rv = redBar.Value;
            int gv = greenBar.Value;
            int bv = blueBar.Value;

            string rvt = rv.ToString();
            string gvt = gv.ToString();
            string bvt = bv.ToString();

            redValueLabel.Text = rvt;
            blueValueLabel.Text = bvt;
            greenValueLabel.Text = gvt;

            setRGBcode(rvt,gvt,bvt);
            Color color = Color.FromArgb(rv, gv, bv);
            setCodeBoxes(color);
            colorPanel.BackColor = color;
        }

        private void setCodeBoxes(Color color) {
            htmlBox.Text = ColorTranslator.ToHtml(color);
            oleBox.Text = ColorTranslator.ToOle(color).ToString();
        }

        private void setRGBcode(string rv, string gv, string bv) {
            rgbBox.Text = rv + ", " + gv + ", " + bv;
        }

        private void button1_Click(object sender, EventArgs e) {
            Clipboard.SetText(rgbBox.Text);
        }

        private void button2_Click(object sender, EventArgs e) {
            Clipboard.SetText(htmlBox.Text);
        }

        private void button3_Click(object sender, EventArgs e) {
            Clipboard.SetText(oleBox.Text);
        }
    }
}
