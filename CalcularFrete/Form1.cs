using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFrete_Click(object sender, EventArgs e)
        {
            var freteMinimo = Convert.ToDecimal( txtFreteMinimo.Text );
            var uf = txtUf.Text;

            CalcularFrete(freteMinimo, uf);
        }


        void CalcularFrete(decimal freteMinimo, string uf)
        {
            // variavel do tipo decimal
            var adicional = 5.0M;
            var freteFinal = 0.0M;

            // se uf == RS
            if (uf.Equals("RS"))
            {
                freteFinal = freteMinimo + 0.5M;

            }else if (uf == "SC" )
            {
                freteFinal = freteMinimo + 1.0M;
            }
            else
            {
                freteFinal = freteMinimo + adicional;
            }

            txtTotalFrete.Text = freteFinal.ToString("F2");
        }
    }
}
