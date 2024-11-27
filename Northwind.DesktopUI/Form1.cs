using Northwind.Business.Concrete;

namespace Northwind.DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            dgvProduct.DataSource = productManager.GetAll();
        }
    }
}
