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
    public partial class Form14Tienda : Form
    {
        public Form14Tienda()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstTienda.SelectedItems.Clear();
            if (this.lstTienda.Items.Contains(this.txtInput.Text))
            {
                // if the item is already in the list, select it
                int index = this.lstTienda.Items.IndexOf(this.txtInput.Text);
                this.lstTienda.SelectedIndex = index;
            }
            else
            {
                this.lstTienda.Items.Add(this.txtInput.Text);
                this.lstTienda.SelectedIndex = this.lstTienda.Items.Count - 1;
            }

            //string producto = this.txtProducto.Text.ToUpper();
            //int index = this.lstTienda.Items.IndexOf(producto);
            //if (index == -1)
            //{
            //    this.lstTienda.Items.Add(producto);
            //    this.txtProducto.SelectAll();
            //    this.txtProducto.Focus();
            //}
            //else
            //{
            //    this.lstTienda.SelectedIndex = index;
            //}


        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numItems = this.lstTienda.SelectedItems.Count;
            for (int i = numItems - 1; i >= 0; i--)
            {
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int numItems = this.lstTienda.SelectedItems.Count;
            for (int i = numItems - 1; i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.SelectedItems[i]);
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;


        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }

    }
}
