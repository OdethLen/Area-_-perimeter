using System.Data;

namespace Area__and__perimeter
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Pentagon A = new Pentagon(Convert.ToDouble(txtSide.Text), Convert.ToDouble(txtApothem.Text));
            txtArea.Text = A.PrintA();
            txtPerimeter.Text = A.PrintP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtApothem.Clear();
            txtSide.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtTBase.Clear();
            txtTHeight.Clear();
            txtAreaT.Clear();
            txtPerT.Clear();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateT_Click(object sender, EventArgs e)
        {
            Triangle A = new Triangle(Convert.ToDouble(txtTBase.Text),Convert.ToDouble(txtTHeight.Text));
            txtAreaT.Text = A.PrintAT();
            txtPerT.Text= A.PrintPT();
        }
    }
}
