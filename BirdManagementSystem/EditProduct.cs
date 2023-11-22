using BirdService;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird.APP
{
    public partial class EditProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public EditProduct()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Description,
                p.Quantity,
                p.Price,
                p.Category.CategoryName,
                p.Image
            }).ToList();
            cb_category.DataSource = _categoryService.GetCategories();
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryID";
        }

        private void dtg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_productid.Text = dtg_product.CurrentRow.Cells[0].Value.ToString();
            txt_productname.Text = dtg_product.CurrentRow.Cells[1].Value.ToString();
            txt_description.Text = dtg_product.CurrentRow.Cells[2].Value.ToString();
            txt_quantity.Text = dtg_product.CurrentRow.Cells[3].Value.ToString();
            txt_price.Text = dtg_product.CurrentRow.Cells[4].Value.ToString();
            cb_category.Text = dtg_product.CurrentRow.Cells[5].Value.ToString();
            //txt_image.Text = dtg_product.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = _productService.GetProductById(int.Parse(txt_productid.Text.Trim()));
                if(product != null)
                {
                    product.Name = txt_productname.Text.Trim();
                    product.Description = txt_description.Text.Trim();
                    product.Quantity = int.Parse(txt_quantity.Text.Trim());
                    product.Price = double.Parse(txt_price.Text.Trim());
                    product.CategoryId = int.Parse(cb_category.SelectedValue.ToString());

                    _productService.UpdateProduct(product);
                    MessageBox.Show("Update Successful");
                    dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
                    {
                        p.ProductId,
                        p.Name,
                        p.Description,
                        p.Quantity,
                        p.Price,
                        p.Category.CategoryName,
                        p.Image
                    }).ToList();
                    cb_category.DataSource = _categoryService.GetCategories();
                    cb_category.DisplayMember = "CategoryName";
                    cb_category.ValueMember = "CategoryID";
                }
                else
                {
                    MessageBox.Show("PRoductId isn't empty!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
