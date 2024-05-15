using KnapsackProblem;

namespace KnapsackGUI
{
    public partial class Form1 : Form
    {
        public int inputNumberOfItems;
        public int inputSeed;
        public int inputSize;
        public bool verifyNumberOfItems = false;
        public bool verifySeed = false;
        public bool verifyCapacity= false;



        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if(int.TryParse(textBox1.Text, out inputNumberOfItems) ) { textBox1.BackColor = SystemColors.Window; verifyNumberOfItems = true; }
            else { textBox1.BackColor = Color.Red; verifyNumberOfItems = false; }
            if (verifyNumberOfItems && verifyCapacity && verifySeed)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out inputSeed)) { textBox2.BackColor = SystemColors.Window; verifySeed = true; }
            else { textBox2.BackColor = Color.Red; verifySeed = false; }
            if (verifyNumberOfItems && verifyCapacity && verifySeed)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out inputSize)) { textBox3.BackColor = SystemColors.Window; verifyCapacity = true; }
            else { textBox3.BackColor = Color.Red; verifyCapacity = false; }
            if (verifyNumberOfItems && verifyCapacity && verifySeed)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(verifyNumberOfItems && verifyCapacity && verifySeed)
            {
                var MyProblem = new Problem(inputNumberOfItems, inputSeed);
                MyProblem.RandomizeProblem();
                var MyResult = new Result(MyProblem.Solve(inputSize));

                textBox4.Text = MyProblem.ToString();
                textBox5.Text = MyResult.ToString();
                textBox6.Text = $"{MyResult.totalWeight}";
                textBox7.Text = $"{MyResult.totalValue}";
            }


        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
