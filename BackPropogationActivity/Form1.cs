using Backprop;

namespace BackPropogationActivity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
            inputBox1.KeyPress += new KeyPressEventHandler(OnlyAllowNumbers);
            inputBox2.KeyPress += new KeyPressEventHandler(OnlyAllowNumbers);
            inputBox3.KeyPress += new KeyPressEventHandler(OnlyAllowNumbers);
            inputBox4.KeyPress += new KeyPressEventHandler(OnlyAllowNumbers);
            this.Text = "Back Propogation Activity - Binangbang Derrick C. BSCS-3 F3";

        }

        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as RichTextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                MessageBox.Show("Please create the neural network first.");
;               return;
            }

            for (int x = 0; x < 500; x++)
            {

                //1st
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //2nd
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //3rd
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //4th
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //5th
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //7th
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //8th
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //9th
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //10th
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputBox1.Text = "";
            inputBox2.Text = "";
            inputBox3.Text = "";
            inputBox3.Text = "";
            inputBox4.Text = "";
            outputBox.Text = "";
            outputBox2.Text = "";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 50, 1);
            outputBox2.Text = "Neural network created with 4 inputs, 50 hidden nodes, and 1 output.";
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                MessageBox.Show("Please create the neural network first.");
;               return;
            }
            nn.setInputs(0, Convert.ToDouble(inputBox1.Text));
            nn.setInputs(1, Convert.ToDouble(inputBox2.Text));
            nn.setInputs(2, Convert.ToDouble(inputBox3.Text));
            nn.setInputs(3, Convert.ToDouble(inputBox4.Text));

            nn.run();

            outputBox.Text = "" + nn.getOuputData(0);

            double check = Convert.ToDouble(outputBox.Text);
            if(check > 0.6)
            {
                outputBox2.Text = "True (AND gate: both inputs are 1). Train the model if inaccurate.";
            }
            else
            {
                outputBox2.Text = "False (AND gate: one or more inputs are 0). Train the model if inaccurate.";
            }
        }

        private void outputBox2_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
