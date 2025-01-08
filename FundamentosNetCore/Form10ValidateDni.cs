using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form10ValidateDni : Form
    {
        public Form10ValidateDni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = this.txtInput.Text;
            //( nº DNI - (PARTE ENTERA(nº DNI / 23) * 23))
            int numDni = int.Parse(dni.Substring(0, dni.Length - 1));
            char letra = dni[dni.Length - 1];
            int parteEntera = numDni % 23;
            int operacion = numDni - (parteEntera * (numDni / 23) * 23);
            char letraCorrecta = "TRWAGMYFPDXBNJZSQVHLCKE"[parteEntera];

            if (letra == letraCorrecta)
            {
                this.lblResult.Text = "DNI Correcto";
            }
            else
            {
                this.lblResult.Text = "DNI Incorrecto";
            }



        }
    }
}
