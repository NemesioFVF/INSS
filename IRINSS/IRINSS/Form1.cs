using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IRINSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double sb, inss, ir, irrf=0, salb, sl, ndp;
            String esl, einss, eir;
            sb = Convert.ToDouble(salBruto.Text);
            if (sb <= 1317.07)
            {
                inss = sb * 0.08;
            }
            else if (sb <= 2195.12)
            {
                inss = sb * 0.09;
            }
            else
            {
                inss = sb * 0.11;
            }

            if (inss > 482.93)
            {
                inss = 482.93;
            }

            ndp = Convert.ToDouble(depend.Text);

            salb = sb - inss - (179.71 * ndp);

            if (salb <= 1787.77)
            {
                ir = 0;
            }
            else if (salb <= 2679.29)
            {
                ir = salb * 0.075;
                irrf = ir - 134.08;
            }
            else if (salb <= 3572.43)
            {
                ir = salb * 0.15;
                irrf = ir - 335.08;
            }
            else if (salb <= 4463.81)
            {
                ir = salb * 0.225;
                irrf = ir - 602.96;
            }
            else
            {
                ir = salb * 0.275;
                irrf = ir - 826.15;
            }

            sl = sb - inss - irrf;
            esl = Convert.ToString(sl);
            lblSL.Text = esl;
            einss = Convert.ToString(inss);
            lblINSS.Text = einss;
            eir = Convert.ToString(irrf);
            lblIR.Text = eir;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
