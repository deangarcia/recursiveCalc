using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursiveDescentCalculator
{
    public partial class Form1 : Form
    {
        private int accumulator = 0; // keeps track of token index
        private char token; // keeps value of current token
        private double result = 0; // result of arithmetic operation
        char[] tokens; // char array of all tokens in expression

        public Form1()
        {
            InitializeComponent();
        }

        // Initializes textbox1 to have 0 on load
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        // *
        private void button19_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // /
        private void button1_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // %
        private void button2_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // ^
        private void button4_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // ( 
        private void button3_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // )
        private void button20_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // -
        private void button5_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // +
        private void button6_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 1
        private void button8_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 2
        private void button7_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 3
        private void button9_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 4
        private void button10_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 5
        private void button11_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 6
        private void button12_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 7
        private void button13_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 8
        private void button14_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 9
        private void button15_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // 0
        private void button16_Click(object sender, EventArgs e)
        {
            // takes name of button and turns it into a string
            string number = (sender as Button).Text;
            // places name of button into textbox as string
            textBox1.Text = textBox1.Text == "0" ? number : textBox1.Text + number;
        }

        // Answer Text Box
        private void textBox1_TextChanged(object sender, EventArgs e){}

        // Clear
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            accumulator = 0;
        }

        // Calc
        private void button18_Click(object sender, EventArgs e)
        {
            tokens = textBox1.Text.ToCharArray();
            token = tokens[accumulator];
            result = exp();
            textBox1.Text = Convert.ToString(result);
        }

        // Function encapsulates third level of precedence for expression 
        int exp()
        {
            int temp = term();
            if (token == '+')
            {
                match('+');
                temp += term();
            }
            else if (token == '-')
            { 
                // handles unary operator as well as subtraction
                match('-');
                temp += -1 * term();
            }
            return temp;
        }

        // encapsulates second level of precedence for expression 
        int term()
        {
            int temp = power();
            if (token == '*')
            {
                match('*');
                temp *= power();
            }
            else if (token == '/')
            {
                match('/');
                temp /= power();
            }
            else if (token == '%')
            {
                match('%');
                temp %= power();
            }
            return temp;
        }

        // Encapsulates first level of precedence for expression
        // since power ^ is higher then / * and % it needed its own function
        int power()
        {
            int temp = factor();
            if (token == '^')
            {
                match('^');
                temp = (int) Math.Pow(temp, factor());
            }
            return temp;
        }

        // Encapsulates last level of expression hierarchy 
        int factor()
        {
            int temp = 0;
            // start new expression tree when paranthesis are encountered
            if (token == '(')
            {
                match('(');
                temp = exp();
                match(')');
            }
            else if (Char.IsNumber(token))
            {
                // Converts char to string and saves it into temp
                temp = (int)Char.GetNumericValue(token);
                // if this is not executed then we are at the end of the expression
                if (tokens.Length - 1 > accumulator)
                {
                    accumulator++;
                    token = tokens[accumulator];
                }
            }
            return temp;
        }

        // match function is responsible for debbuging pre compiled code and also increments the accumulator 
        void match(char expectedToken)
        {
            if (expectedToken == tokens[accumulator])
            {
                accumulator++;
                token = tokens[accumulator];
            }
        }
    }
}
