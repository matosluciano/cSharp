using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            /*string texto = "Este tipo de variável é alfanumérica.";

            if (texto.Contains("Tipo"))
            {
                label1.Text = "Contém.";
            }
            else
            {
                label1.Text = "Não Contém."; ;
            }*/
            int num = 5400;
            int val = 2000;
            label1.Text = num.ToString();
            label1.Text = val.ToString();
            int res = num + val;

            label1.Text = res.ToString();

            Console.WriteLine(res);

            #endregion

            #region ToUpper / ToLower
            string nome = "Luciano";

            //nome = nome.ToUpper(); mesmo efeito do código abaixo:
            // string nomeMaiusculo = nome.ToUpper();



            label1.Text = nome.ToLower();
            #endregion



        }
    }
}
