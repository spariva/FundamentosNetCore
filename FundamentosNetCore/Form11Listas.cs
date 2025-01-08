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
    public partial class Form11Listas : Form
    {
        public Form11Listas()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtInput.Text;
            this.lstElementos.Items.Add(elem);
            this.txtInput.Focus();
            this.txtInput.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //string elemSelected = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(elemSelected);
            int indexSelected = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indexSelected);
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblResult.Text = "Index Selected: " + this.lstElementos.SelectedIndex +
                    " item selected: " + this.lstElementos.SelectedItem;
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                items += items + ", ";
            }
            this.lblResult.Text = items.Trim();
        }
    }
}
