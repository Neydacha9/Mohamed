namespace Win1
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_button(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                //code if true
                MessageBox.Show("You need to write UserName or Password");
                return;
            }
            if (txtUserName.Text == "123" && txtPassword.Text == "321")
            {
                //code if true
                this.Hide();
                FormMain _formmain = new FormMain();
                _formmain.ShowDialog();

            }
            else
            {
                // code if false
                MessageBox.Show("You UserName or Password not right");
            }

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_button(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
