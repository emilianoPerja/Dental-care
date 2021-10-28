using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBasics
{
    public partial class Form1 : Form
    {
        private int cont;
        private CheckBox[] chkColorsArray;

        public Form1()
        {
            InitializeComponent();

            cont = 0;
            txtTest.Text = "Clicks: 0";

            chkColorsArray = new CheckBox[]
            {
                chkRed, chkGreen, chkBlue, chkMagenta,
                chkCyan, chkYellow, chkOrange, chkBrown
            };
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            cont++;
            txtTest.Text = $"Clicks: {cont}";

            //txtTest.Text = "¡Hola Windows Forms!";
        }

        private void chkRed_CheckedChanged(object sender, EventArgs e)
        {
            List<string> colors = new List<string>();
            foreach (var chk in chkColorsArray)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            txtColor.Text = String.Join("+", colors);
        }

        private void radTierra_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                txtPlanetas.Text = radio.Text;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            txtBrillo.Text = trackBar1.Value.ToString();
        }
    }
}
