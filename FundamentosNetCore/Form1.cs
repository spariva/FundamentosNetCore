namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SuspendLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.txtName.Location = new Point(100, 100);
            this.txtName.Text = "Hello World";
            this.txtName.Width = 200;
            this.txtName.TextAlign = HorizontalAlignment.Center;
            this.txtName.BackColor = Color.HotPink;
        }
    }
}
