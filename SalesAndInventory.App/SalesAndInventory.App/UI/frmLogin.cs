using SalesAndInventory.App.UI;

namespace SalesAndInventory.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123")
            {
                CashierDashboard cashier = new CashierDashboard();
                cashier.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                "Invalid Username or Password",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
