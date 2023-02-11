using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal Nota1;
            Decimal Nota2;
            Decimal Nota3;
            Decimal Nota4;
            Decimal Suma;
            


            Nota1 = Convert.ToDecimal(NotaTexbox1.Text);
            Nota2 = Convert.ToDecimal(NotaTexbox2.Text);
            Nota3 = Convert.ToDecimal(NotaTexbox3.Text);
            Nota4 = Convert.ToDecimal(NotaTexbox4.Text);
            NotaTexbox1.Clear();
            NotaTexbox2.Clear();
            NotaTexbox3.Clear();
            NotaTexbox4.Clear();
            NotaTexbox1.Focus();

            Suma = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            PromedioTexbox.Text = Suma.ToString(); 

           

            

        }
    }
}
