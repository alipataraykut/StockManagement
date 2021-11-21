using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.Concrete.EntityFramework;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.UIForms
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            _productDal = new EfProductDal();
            _categoryDal = new EfCategoryDal();
            _supplierDal = new EfSupplierDal();
        }

        private IProductDal _productDal;
        private ICategoryDal _categoryDal;
        private ISupplierDal _supplierDal;

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            LoadSuppliers();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryDal.ListAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

            cbxCategoryNameAdd.DataSource = _categoryDal.ListAll().Where(c => c.CategoryID != 9).ToList();
            cbxCategoryNameAdd.DisplayMember = "CategoryName";
            cbxCategoryNameAdd.ValueMember = "CategoryID";

            cbxCategoryNameUpdate.DataSource = _categoryDal.ListAll().Where(c => c.CategoryID != 9).ToList();
            cbxCategoryNameUpdate.DisplayMember = "CategoryName";
            cbxCategoryNameUpdate.ValueMember = "CategoryID";
        }

        private void LoadSuppliers()
        {
            cbxSupplierNameAdd.DataSource = _supplierDal.ListAll();
            cbxSupplierNameAdd.DisplayMember = "CompanyName";
            cbxSupplierNameAdd.ValueMember = "SupplierId";

            cbxSupplierNameUpdate.DataSource = _supplierDal.ListAll();
            cbxSupplierNameUpdate.DisplayMember = "CompanyName";
            cbxSupplierNameUpdate.ValueMember = "SupplierId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.ListAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedIndex == 0)
                LoadProducts();
            else
                dgwProducts.DataSource = _productDal.ListAll().Where(p => p.CategoryID == Convert.ToInt32(cbxCategory.SelectedIndex)).ToList();
        }

        private void tbxSearchProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchProductName.Text))
                dgwProducts.DataSource = _productDal.ListAll().Where(p => p.ProductName.ToLower().Contains(tbxSearchProductName.Text.ToLower())).ToList();
            else
                LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxSupplierNameUpdate.SelectedValue = Convert.ToInt32(row.Cells[2].Value);
            cbxCategoryNameUpdate.SelectedValue = Convert.ToInt32(row.Cells[3].Value);
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[5].Value.ToString();
            tbxStockAmountUpdate.Text = row.Cells[6].Value.ToString();
            tbxUnitsOnOrderUpdate.Text = row.Cells[7].Value.ToString();
            tbxReorderLevelUpdate.Text = row.Cells[8].Value.ToString();
            cbxDiscontinuedUpdate.Checked = Convert.ToBoolean(row.Cells[9].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Add(new Product
                {
                    ProductName = tbxProductNameAdd.Text,
                    CategoryID = Convert.ToInt32(cbxCategoryNameAdd.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitsInStock = Convert.ToInt16(tbxStockAmountAdd.Text),
                    SupplierId = Convert.ToInt32(cbxSupplierNameAdd.SelectedValue),
                    UnitsOnOrder = Convert.ToInt16(tbxUnitsOnOrderAdd.Text),
                    Discontinued = cbxDiscontinuedAdd.Checked ? true : false
                });
                MessageBox.Show("Ürün eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadCategories();
                LoadProducts();
                LoadSuppliers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryID = Convert.ToInt32(cbxCategoryNameUpdate.SelectedValue),
                    SupplierId = Convert.ToInt32(cbxSupplierNameUpdate.SelectedValue),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text),
                    UnitsOnOrder = Convert.ToInt16(tbxUnitsOnOrderUpdate.Text),
                    ReorderLevel = Convert.ToInt16(tbxReorderLevelUpdate.Text),
                    Discontinued = cbxDiscontinuedUpdate.Checked ? true : false
                });
                MessageBox.Show("Ürün güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadCategories();
                LoadProducts();
                LoadSuppliers();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadCategories();
                LoadProducts();
                LoadSuppliers();
            }
        }

        private void FrmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
