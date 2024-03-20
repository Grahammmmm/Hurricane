namespace Hurricane1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int strength;
            double message;
            message = Convert.ToDouble(textBox1.Text);
            if (message >= 157)
                strength = 5;
            else if (message >= 130)
                strength = 4;
            else if (message >= 111)
                strength = 3;
            else if (message >= 96)
                strength = 2;
            else
                strength = 1;

            label2.Text = "The category of this hurricane is " + strength;
        }
    }
}
