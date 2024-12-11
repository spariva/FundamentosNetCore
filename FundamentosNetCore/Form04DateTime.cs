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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if (this.rdbAnyos.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }

            this.txtNuevaFecha.Text = fecha.ToString();
        }

        private void txtFechaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFormato.Checked)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            } else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }
    }
}
