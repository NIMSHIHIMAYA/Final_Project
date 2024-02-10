namespace Login_Form_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;

            // Check the username and password
            if (username == "Admin" && password == "Skills@123")
            {
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials. Please check Username and Password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Do you really want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;

            // Check the username and password
            if (username == "Admin" && password == "Skills@123")
            {
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials. Please check Username and Password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
