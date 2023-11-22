using BirdService;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird.APP
{
    public partial class AdminForm : Form
    {
        BindingSource source;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private BindingSource bindingSource = null;
        public AdminForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _productService = new ProductService();
            _categoryService = new CategoryService();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // load user
            dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
            {
                c.Username,
                c.Password,
                c.Name,
                c.Email,
                c.Phone,
                c.Yob,
                c.Gender,
                c.Address,
                c.Image,
                c.Role
            }).ToList();

            // load product
            dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Quantity,
                p.Description,
                p.Price,
                p.Category.CategoryName,
                p.Status,
                p.Image
            }).ToList();

            cb_category.DataSource = _categoryService.GetCategories();
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryID";
        }

        private void dtg_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_username.Text = dtg_user.CurrentRow.Cells[0].Value.ToString();
            txt_password.Text = dtg_user.CurrentRow.Cells[1].Value.ToString();
            lb_nameuser.Text = dtg_user.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dtg_user.CurrentRow.Cells[3].Value.ToString();
            txt_phone.Text = dtg_user.CurrentRow.Cells[4].Value.ToString();
            txt_yob.Text = dtg_user.CurrentRow.Cells[5].Value.ToString();
            txt_gender.Text = dtg_user.CurrentRow.Cells[6].Value.ToString();
            txt_address.Text = dtg_user.CurrentRow.Cells[7].Value.ToString();
            txt_role.Text = dtg_user.CurrentRow.Cells[9].Value.ToString();

            Block_Active();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //string searchValue = txt_searchuser.Text.Trim();
            //if (searchValue.Length > 0)
            //{
            //    dtg_user.DataSource = _userService.GetAllUsers().Where(u => u.Username.Contains(searchValue))
            //    .Select(c => new
            //    {
            //        c.Username,
            //        c.Password,
            //        c.Name,
            //        c.Email,
            //        c.Phone,
            //        c.Yob,
            //        c.Gender,
            //        c.Address,
            //        c.Image,
            //        c.Role
            //    }).ToList();
            //}
            //else
            //{
            //    dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
            //    {
            //        c.Username,
            //        c.Password,
            //        c.Name,
            //        c.Email,
            //        c.Phone,
            //        c.Yob,
            //        c.Gender,
            //        c.Address,
            //        c.Image,
            //        c.Role
            //    }).ToList();
            //}
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User();
                user.Username = txt_username.Text.Trim();
                user.Password = txt_password.Text.Trim();
                user.Name = lb_nameuser.Text.Trim();
                user.Email = txt_email.Text.Trim();
                user.Phone = txt_phone.Text.Trim();
                user.Yob = int.Parse(txt_yob.Text.Trim());
                user.Gender = txt_gender.Text.Trim();
                user.Address = txt_address.Text.Trim();
                user.Role = "User";
                _userService.Create(user);
                MessageBox.Show("Add Successful!");

                dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
                {
                    c.Username,
                    c.Password,
                    c.Name,
                    c.Email,
                    c.Phone,
                    c.Yob,
                    c.Gender,
                    c.Address,
                    c.Image,
                    c.Role
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add fail!!!" + ex.Message);
            }
        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _userService.GetUserByUsername(txt_username.Text.Trim());
                if (user != null)
                {
                    user.Username = txt_username.Text.Trim();
                    user.Password = txt_password.Text.Trim();
                    user.Name = lb_nameuser.Text.Trim();
                    user.Email = txt_email.Text.Trim();
                    user.Phone = txt_phone.Text.Trim();
                    user.Yob = int.Parse(txt_yob.Text.Trim());
                    user.Gender = txt_gender.Text.Trim();
                    user.Address = txt_address.Text.Trim();
                    user.Role = txt_role.Text.Trim();
                    _userService.UpdateUser(user);
                    MessageBox.Show("Update Successful");
                    dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
                    {
                        c.Username,
                        c.Password,
                        c.Name,
                        c.Email,
                        c.Phone,
                        c.Yob,
                        c.Gender,
                        c.Address,
                        c.Image,
                        c.Role
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Username isn't existed!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error!!!" + ex.Message);
            }
        }
        private void Block_Active()
        {
            User user = _userService.GetUserByUsername(txt_username.Text.Trim());
            btn_block.Enabled = true;
            if (user == null)
            {
                btn_block.Enabled = false;
            }
            else if (user.Status == true)
            {
                btn_block.Text = "BLOCK";
                btn_block.ForeColor = Color.Red;
            }
            else
            {
                btn_block.Text = "ACTIVE";
                btn_block.ForeColor = Color.Blue;
            }
        }
        private void btn_blockuser_Click(object sender, EventArgs e)
        {
            User user = _userService.GetUserByUsername(txt_username.Text.Trim());
            if (btn_block.Text == "BLOCK")
            {
                if (MessageBox.Show($"DO YOU WANT TO BAN {user.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    user.Status = false;
                    _userService.UpdateUser(user);
                    dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
                    {
                        c.Username,
                        c.Password,
                        c.Name,
                        c.Email,
                        c.Phone,
                        c.Yob,
                        c.Gender,
                        c.Address,
                        c.Image,
                        c.Role
                    }).ToList();
                }
            }
            else
            {
                if (MessageBox.Show($"DO YOU WANT TO ACTIVE {user.Name}?", "CONFIRM BOX", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    user.Status = true;
                    _userService.UpdateUser(user);
                    dtg_user.DataSource = _userService.GetAllUsers().Select(c => new
                    {
                        c.Username,
                        c.Password,
                        c.Name,
                        c.Email,
                        c.Phone,
                        c.Yob,
                        c.Gender,
                        c.Address,
                        c.Image,
                        c.Role
                    }).ToList();
                }
            }

        }

        private List<User> LoadCustomerFilter(List<User> list)
        {
            list = list.Where(u => u.Name.ToLower().Contains(txt_searchuser.Text.ToLower())).ToList();
            if (cb_userstatus.SelectedIndex == 1)
            {
                list = list.Where(u => u.Status == true).ToList();
            }
            else if (cb_userstatus.SelectedIndex == 2)
            {
                list = list.Where(u => u.Status == false).ToList();
            }
            return list;
        }
        private void LoadUserData()
        {
            source = new BindingSource();
            List<User> list = _userService.GetAllUsers();
            list = LoadCustomerFilter(list);

            source.DataSource = list;
            lb_nameuser.DataBindings.Clear();
            txt_username.DataBindings.Clear();
            txt_password.DataBindings.Clear();
            txt_phone.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_yob.DataBindings.Clear();
            txt_role.DataBindings.Clear();
            txt_gender.DataBindings.Clear();
            txt_address.DataBindings.Clear();

            lb_nameuser.DataBindings.Add("Text", source, "Name");
            txt_username.DataBindings.Add("Text", source, "Username");
            txt_password.DataBindings.Add("Text", source, "Password");
            txt_phone.DataBindings.Add("Text", source, "Phone");
            txt_email.DataBindings.Add("Text", source, "Email");
            txt_yob.DataBindings.Add("Text", source, "Yob");
            txt_role.DataBindings.Add("Text", source, "Role");
            txt_gender.DataBindings.Add("Text", source, "Gender");
            txt_address.DataBindings.Add("Text", source, "Address");

            dtg_user.DataSource = source;
            btn_block.Enabled = false;
        }
        private void cb_userstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserData();
        }


        private void dtg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_product.CurrentRow.Cells[0].Value.ToString();
            lb_nameproduct.Text = dtg_product.CurrentRow.Cells[1].Value.ToString();
            gb_productname.Text = dtg_product.CurrentRow.Cells[1].Value.ToString();
            txt_productname.Text = dtg_product.CurrentRow.Cells[1].Value.ToString();
            txt_quantity.Text = dtg_product.CurrentRow.Cells[2].Value.ToString();
            txt_description.Text = dtg_product.CurrentRow.Cells[3].Value.ToString();
            txt_price.Text = dtg_product.CurrentRow.Cells[4].Value.ToString();
            cb_category.Text = dtg_product.CurrentRow.Cells[5].Value.ToString();
            txt_image.Text = dtg_product.CurrentRow.Cells[7].Value.ToString();

            object cellValue = dtg_product.CurrentRow.Cells[7].Value;
            if (cellValue != null)
            {
                string imageURL = cellValue.ToString();
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageData = client.DownloadData(imageURL);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            pb_productimage.Image = image;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtg_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = _productService.GetProductById(int.Parse(txt_id.Text.Trim()));
                if (product != null)
                {
                    product.Name = txt_productname.Text.Trim();
                    product.Price = double.Parse(txt_price.Text.Trim());
                    product.Quantity = int.Parse(txt_quantity.Text.Trim());
                    product.Description = txt_description.Text.Trim();
                    product.CategoryId = int.Parse(cb_category.SelectedValue.ToString());
                    //product.Name = txt_name.Text.Trim();
                    _productService.UpdateProduct(product);
                    MessageBox.Show("Update Successful!!!");
                    dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
                    {
                        p.ProductId,
                        p.Name,
                        p.Quantity,
                        p.Description,
                        p.Price,
                        p.Category.CategoryName,
                        p.Status
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("ProductID isn't empty!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_closeuser_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_closeproduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            bool status = true;
            try
            {
                Product product = new Product();
                product.Name = txt_productname.Text.Trim();
                product.Price = double.Parse(txt_price.Text.Trim());
                product.Quantity = int.Parse(txt_quantity.Text.Trim());
                product.Description = txt_description.Text.Trim();
                product.CategoryId = int.Parse(cb_category.SelectedValue.ToString());
                product.Status = status;

                _productService.AddProduct(product);
                MessageBox.Show("Add Product Successful!");
                dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    p.Quantity,
                    p.Description,
                    p.Price,
                    p.Category.CategoryName,
                    p.Status
                }).ToList();

                cb_category.DataSource = _categoryService.GetCategories();
                cb_category.DisplayMember = "CategoryName";
                cb_category.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Product Failed!" + ex.Message);
            }
        }

        private void btn_searchproduct_Click(object sender, EventArgs e)
        {
            string searchValue = txt_searchproduct.Text.Trim();
            if (searchValue.Length > 0)
            {
                dtg_product.DataSource = _productService.GetAllProducts()
                    .Where(s => s.Name.Contains(searchValue)).Select(p => new
                    {
                        p.ProductId,
                        p.Name,
                        p.Quantity,
                        p.Description,
                        p.Price,
                        p.Category.CategoryName,
                        p.Status
                    }).ToList();
            }
            else
            {
                dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    p.Quantity,
                    p.Description,
                    p.Price,
                    p.Category.CategoryName,
                    p.Status
                }).ToList();
            }
        }

        private void btn_deleteproduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.DeleteProduct(int.Parse(txt_id.Text.Trim()));
                MessageBox.Show("Delete Successful!");
                dtg_product.DataSource = _productService.GetAllProducts().Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    p.Quantity,
                    p.Description,
                    p.Price,
                    p.Category.CategoryName,
                    p.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_totalproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void tab_manageaccounts_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_productimage_Click(object sender, EventArgs e)
        {

        }
    }
}
