using System;
using org.mariuszgromada.math.mxparser;
using System.Windows.Forms;

namespace finalprojectadditionfinalversion_1_
{
    public partial class Derivative : Form
    {
        public Derivative()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string derArgIn = "x = " + derArgInput.Text, derIn = "der(" + derInput.Text + ",x)";
            Argument x = new Argument(derArgIn);
            Expression expr = new Expression(derIn, x);

            double ans = expr.calculate();
            derAns.Text = ans.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            derInput.Text = "";
            derAns.Text = "";
            derArgInput.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string intin;
            intin = "int(" + intInput.Text + ", x, " + intInitial.Text + "," + intFinal.Text + ")";

            Expression expr = new Expression(intin);
            double ans = expr.calculate();

            intAns.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intAns.Text = "";
            intInput.Text = "";
            intInitial.Text = "";
            intFinal.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
