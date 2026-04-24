namespace FreshCartManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new FreshCartContext())
            {
                // Find if the username exists
                var user = db.Users.FirstOrDefault(u => u.UserName == txtUsername.Text);

                if (user == null)
                {
                    MessageBox.Show("No users found!");
                }
                else if (user.Password != txtPassword.Text)
                {
                    MessageBox.Show("Incorrect Password");
                }
                else
                {
                    // If there is a match - open the second Form
                    GroceryForm mainForm = new GroceryForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
