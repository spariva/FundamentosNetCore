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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //	• No exista espacio
            string mail = this.txtMail.Text;

            //  • Exista @
            if (!mail.Contains('@'))
            {
                MessageBox.Show("El mail no contiene @");
            }

            //	• Ni @ al inicio ni al final
            if (mail.StartsWith("@") || mail.EndsWith("@"))
            {
                MessageBox.Show("El mail no puede empezar ni terminar con @");
            }
            //mail = mail.Trim('@');

            //	• No exista más de una @
            if (mail.IndexOf('@') != mail.LastIndexOf('@'))
            {
                MessageBox.Show("El mail contiene más de una @");
            }

            //	• Exista un punto
            if (!mail.Contains('.'))
            {
                MessageBox.Show("El mail no contiene .");
            }

            //	• Exista un punto después de @
            if (mail.LastIndexOf('.') < mail.IndexOf('@'))
            {
                MessageBox.Show("El mail no contiene . después de @");
            }

            //Dominio de 2 a 4 caracteres(com, es, org, como)
            if (mail.Substring(mail.LastIndexOf('.')).Length < 2 || mail.Substring(mail.LastIndexOf('.')).Length > 4)
            {
                MessageBox.Show("El mail no contiene dominio de 2 a 4 caracteres");
            }
        }
    }
}
