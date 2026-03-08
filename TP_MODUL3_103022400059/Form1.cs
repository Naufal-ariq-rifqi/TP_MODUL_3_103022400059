namespace TP_MODUL3_103022400059
{
    public partial class Form1 : Form
    {
        double total = 0;       
        bool operasiPlus = false; 
        bool isNewEntry = true;  
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "0")
            {
                label1.Text = "0";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "3")
            {
                label1.Text = "3";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "6")
            {
                label1.Text = "6";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "7")
            {
                label1.Text = "7";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operasiPlus)
            {
                total += Convert.ToDouble(label1.Text);
                label1.Text = total.ToString();
                total = 0;
                operasiPlus = false;
                isNewEntry = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "1")
            {
                label1.Text = "1";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "2")
            {
                label1.Text = "2";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "4")
            {
                label1.Text = "4";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "5")
            {
                label1.Text = "5";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "8")
            {
                label1.Text = "8";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNewEntry || label1.Text == "9")
            {
                label1.Text = "9";
                isNewEntry = false;
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(label1.Text);
            isNewEntry = true; 
            operasiPlus = true;
        }
    }
}
