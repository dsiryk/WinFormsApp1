namespace WinFormsApp3
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userText = this.textBox1.Text;
            button1.ForeColor = Color.Black;
            if (userText.Trim().Length > 0)
            {

                this.result.Text = userText;
                this.textBox1.Text = "";
                this.button1.ForeColor = Color.Green;
            }
            else
            {

                MessageBox.Show("1", "2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.result.Text) + 1; 
            this.result.Text = a.ToString(); 

        }
    }

    }

