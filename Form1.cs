using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMatriz
{
    public partial class Form1 : Form
    {
        string[] matriz = new string[7];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            matriz[i] = txtbox.Text;
            i++;
        }

        private void btlistar_Click(object sender, EventArgs e)
        {
            lbllista.Text = "";
          //string[] matriz = {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
            foreach (string dia in matriz)
            {
                lbllista.Text = lbllista.Text + dia + "\r\n";
            }
        }
    }
}
