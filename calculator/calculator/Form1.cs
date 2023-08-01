using static System.Net.Mime.MediaTypeNames;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        int num1;
        int num2;
        string options;
        int result;


        private void btnmul_Click(object sender, EventArgs e)
        {
            options= "*";
            num1= int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn8.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text= txtTotal.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            options= "+";
            num1= int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            options= "-";
            num1= int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            options= "/";
            num1= int.Parse(txtTotal.Text);
            txtTotal.Clear();
            
        }
    }

        private void Btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (options.Equals("+"))
                result = num1 + num2;

            if (options.Equals("-"))
                result = num1 - num2;

            if (options.Equals("*"))
                result = num1 * num2;

            if (options.Equals("/"))
                result = num1 / num2;

            txtTotal.Text= result +"";
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}