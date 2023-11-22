using BirdService;
using BusinessObjects.Models;
using System.Text.RegularExpressions;

namespace Bird.APP
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService userService = null;
        public RegisterForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        //CHECK VALIDATION
        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckName(String input)
        {
            if (input.Trim().Length <= 5)
            {
                txtFullname.Focus();
                throw new Exception("NAME WAS TOO SHORT");
            }


            string pattern = @"\d"; // Ký tự chữ cái không phải là số
            if (Regex.IsMatch(input, pattern))
            {
                txtFullname.Focus();
                throw new Exception("WRONG FORMAT OF NAME");
            }

            return true;
        }
        private bool CheckPassword(String input)
        {
            if (input.Length <= 5)
            {
                txtPassword.Focus();
                txtCfPassword.Clear();
                throw new Exception("PASSWORD WAS TOO SHORT");
            }

            return true;
        }
        private bool CheckPhone(String input)
        {
            if (!CheckCharacterOfPhone(txtPhone.Text))
            {
                txtPhone.Focus();
                throw new Exception("PLEASE TYPE THE PHONE NUMBER FROM 9 to 12 DIGITS");
            }

            if (input[0] != '0')
            {
                txtPhone.Focus();
                throw new Exception("WRONG FORMAT OF PHONE");
            }

            if (userService.GetAllUsers().Where(u => u.Phone == txtPhone.Text).Count() > 0)
            {
                txtPhone.Focus();
                throw new Exception("PHONE WAS EXIST");
            }

            return true;
        }
        private bool CheckEmail(string input)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            if (!Regex.IsMatch(input, pattern))
            {
                txtEmail.Focus();
                throw new Exception("WRONG FORMAT OF EMAIL");
            }

            if (userService.UserExit(txtEmail.Text))
            {
                txtEmail.Focus();
                throw new Exception("EMAIL WAS EXIST");
            }
            return true;
        }
        private bool ValidateInputs()
        {
            try
            {
                if (

                string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                string.IsNullOrEmpty(txtFullname.Text.Trim()) ||
                string.IsNullOrEmpty(txtPhone.Text.Trim()) ||
                string.IsNullOrEmpty(txtPassword.Text.Trim()) ||
                string.IsNullOrEmpty(txtCfPassword.Text.Trim()) ||
                (rbMale.Checked == false && rdFemale.Checked == false)
                )
                {
                    throw new Exception("PLEASE FILL ALL REQUIRED FIELD");
                }

                CheckEmail(txtEmail.Text);

                CheckName(txtFullname.Text);

                CheckPhone(txtPhone.Text);

                CheckPassword(txtPassword.Text);

                if (txtPassword.Text != txtCfPassword.Text)
                {
                    //MessageBox.Show("Password và confirm password không giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtCfPassword.Clear();
                    throw new Exception("PASSWORD AND CONFIRM PASSWORD WAS NOT SIMILAR");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string tmpGender;
            try
            {
                if (ValidateInputs() == true)
                {
                    if (rbMale.Checked == true)
                    {
                        tmpGender = "Nam";
                    }
                    else
                    {
                        tmpGender = "Nữ";
                    }
                    User user = new User()
                    {

                    };
                    DialogResult d;
                    d = MessageBox.Show($"Confirm register ", "Profile", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        userService.Create(user);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
