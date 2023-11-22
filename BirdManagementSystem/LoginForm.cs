using BirdService;
using BusinessObjects.Models;

namespace Bird.APP
{
    public partial class LoginForm : Form
    {
        private readonly IUserService userService = null;
        private string ADMIN_ROLE = "Admin";

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                //if (txtUsername.Text.Length == 0)
                //    throw new Exception("Please enter the email/username/phone!");
                //if (txtPassword.Text.Length == 0)
                //    throw new Exception("Please enter the password!");

                User user = userService.GetUserByUsername(txtUsername.Text.Trim());
                if (user != null)
                {
                    //switch(user.Role)
                    //{
                    //    case "User":
                    //        CustomerForm customerForm = new CustomerForm();
                    //        customerForm.Show();
                    //        this.Hide();
                    //        break;
                    //    case "Admin":
                    //        break;
                    //    case "Staff":
                    //        MessageBox.Show("You are not permission.");
                    //        break;
                    //}

                    GlobalData.AuthenticatedUser = user;
                    if (user.Role.Equals("User")) // CUSTOMER
                    {
                        CustomerForm customerFrom = new CustomerForm();
                        customerFrom.Show();
                        this.Hide();
                        //regis.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "!";

                        //Custo.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //this.Hide();
                        //frmCustomer.Show();

                    }
                    else if (user.Role.Equals("Staff")) // STAFF
                    {
                        //frmStaff frmStaff = new frmStaff();
                        //frmStaff.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();

                        //};
                        //frmStaff.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [Staff Mode]";
                        //this.Hide();
                        //frmStaff.Show();
                    }
                    else if (user.Role.Equals(ADMIN_ROLE)) //ADMIN
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                        //var form = new frmAdmin();
                        //form.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [ADMIN Mode]";
                        //this.Hide();
                        //form.Show();
                    }
                    else if (user.Role.Equals("SHIPPER"))
                    {
                        //var form = new frmShipper();
                        //form.FormClosed += delegate
                        //{
                        //    txtEmail.Text = "";
                        //    txtPassword.Text = "";
                        //    this.Show();
                        //};
                        //form.Text = "Welcome " + GlobalData.AuthenticatedUser.Name + "! [SHIPPER Mode]";
                        //this.Hide();
                        //form.Show();


                    }
                }
                else
                {
                    MessageBox.Show("Wrong email or password!!!", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Fail");
            }
        }
    }

}
