using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;

namespace Northwind.DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new NhProductDal());
        }

        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new NhProductDal());
            dgvProduct.DataSource = _productService.GetAll();
        }
    }
}
