using System.Windows.Forms;
using System.Threading.Tasks;




namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                MessageBox.Show("Поле пусте", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.result.Text = " ";
            this.button2.ForeColor = Color.Red;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
