using MetroSet_UI.Forms;
namespace keyboards
{
    public partial class Keyboards : MetroSetForm
    {
        public Keyboards()
        {
            InitializeComponent();
        }
        private void Keyboards_Load(object sender, EventArgs e)
        {
            this.ActiveControl = usr_txtbox;
        }
        private void log_in_btn_Click(object sender, EventArgs e)
        {
            if (usr_txtbox.Text == "admin" && pwd_txtbox.Text == "admin")
            {
                this.Hide();
                new keyboards_src().Show();
            }
            else if (string.IsNullOrEmpty(this.usr_txtbox.Text) && string.IsNullOrEmpty(this.pwd_txtbox.Text))
            {
                usr_txtbox.PlaceholderText = "This is required!";
                pwd_txtbox.PlaceholderText = "This is required!";
            }
            else if (string.IsNullOrEmpty(this.usr_txtbox.Text))
            {
                usr_txtbox.PlaceholderText = "This is required!";
            }
            else if (string.IsNullOrEmpty(this.pwd_txtbox.Text))
            {
                pwd_txtbox.PlaceholderText = "This is required!";
            }
            else if (usr_txtbox.Text != "admin")
            {
                MessageBox.Show("No user found!");
            }
            else if (usr_txtbox.Text == "admin" && pwd_txtbox.Text != "admin")
            {
                MessageBox.Show("The password is not correct, please try again.");
            }
        }


    }
}