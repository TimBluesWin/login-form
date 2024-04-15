namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            MessageBox.Show(username);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void Password_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
