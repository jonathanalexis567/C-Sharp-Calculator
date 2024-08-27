/*
 * Author of the program: Jonathan A. Ramírez Colón
 * Updated Date: 8/26/2024
 */
namespace Calculator
{
    public partial class Calculator1 : Form
    {
        //Initializing the variables.
        private Size formOriginalSize;
        private Rectangle rectButton1;
        private Rectangle rectButton2;
        private Rectangle rectButton3;
        private Rectangle rectButton4;
        private Rectangle rectButton5;
        private Rectangle rectButton6;
        private Rectangle rectButton7;
        private Rectangle rectButton8;
        private Rectangle rectButton9;
        private Rectangle rectButton0;
        private Rectangle rectButtondot;
        private Rectangle rectButtonEqual;
        private Rectangle rectButtonMinus;
        private Rectangle rectButtonPlus;
        private Rectangle rectButtonMultiply;
        private Rectangle rectButtonClear;
        private Rectangle rectTextBox;

        public Calculator1()
        {
            InitializeComponent();

            //Resize the buttons of the calculator depending on the size of the windows.
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            rectButton1 = new Rectangle(number1.Location, number1.Size);
            rectButton2 = new Rectangle(number2.Location, number2.Size);
            rectButton3 = new Rectangle(number3.Location, number3.Size);
            rectButton4 = new Rectangle(number4.Location, number4.Size);
            rectButton5 = new Rectangle(number5.Location, number5.Size);
            rectButton6 = new Rectangle(number6.Location, number6.Size);
            rectButton7 = new Rectangle(number7.Location, number7.Size);
            rectButton8 = new Rectangle(number8.Location, number8.Size);
            rectButton9 = new Rectangle(number9.Location, number9.Size);
            rectButton0 = new Rectangle(number0.Location, number0.Size);
            rectButtondot = new Rectangle(dot.Location, dot.Size);
            rectButtonEqual = new Rectangle(equal.Location, equal.Size);
            rectButtonMinus = new Rectangle(subtract.Location, subtract.Size);
            rectButtonPlus = new Rectangle(plus.Location, plus.Size);
            rectButtonMultiply = new Rectangle(multiply.Location, multiply.Size);
            rectButtonClear = new Rectangle(clear.Location, clear.Size);
            rectTextBox = new Rectangle(textTotal.Location, textTotal.Size);
        }

        //Globals variables
        string option = "";
        double num1;
        double num2;
        double result;

        //Clicking function to display the number.
        private void number7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "9";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "6";
        }

        private void number3_Click_1(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "3";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "2";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "1";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "5";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + ".";
        }

        //Function to multiply numbers.
        private void multiply_Click(object sender, EventArgs e)
        {
            option = "X";

            num1 = double.Parse(textTotal.Text);

            textTotal.Clear();
        }

        //Function to display the results of the mathematic equation.
        private void equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textTotal.Text);

            //Statement to select which mathematical option is going to be executed.
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("X"))
                result = num1 * num2;

            textTotal.Text = result + "";
        }

        //Function to add numbers.
        private void plus_Click(object sender, EventArgs e)
        {
            option = "+";

            num1 = double.Parse(textTotal.Text);

            textTotal.Clear();
        }

        //Function to subtract the numbers.
        private void subtract_Click(object sender, EventArgs e)
        {
            option = "-";

            num1 = double.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Calculator1_Load(object sender, EventArgs e)
        {
            //Changing the background color of the application.
            this.BackColor = System.Drawing.Color.Black;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Clearing the textTotal Box.
            textTotal.Clear();
        }
        
        //Function to resize the buttons.
        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(number9, rectButton9);
            resize_Control(number8, rectButton8);
            resize_Control(number7, rectButton7);
            resize_Control(number6, rectButton6);
            resize_Control(number5, rectButton5);
            resize_Control(number4, rectButton4);
            resize_Control(number3, rectButton3);
            resize_Control(number2, rectButton2);
            resize_Control(number1, rectButton1);
            resize_Control(number0, rectButton0);
            resize_Control(multiply, rectButtonMultiply);
            resize_Control(subtract, rectButtonMinus);
            resize_Control(plus, rectButtonPlus);
            resize_Control(equal, rectButtonEqual);
            resize_Control(dot, rectButtondot);
            resize_Control(clear, rectButtonClear);
            resize_Control(textTotal, rectTextBox);
            AdjustFontSize(textTotal);
        }
        
        //Function to resize the position of the buttons.
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        //Function to resize the font inside the textTotal box.
        private void AdjustFontSize(TextBox textBox)
        {
            float newSize = Math.Max(8, textBox.Height / 4); // Example calculation
            textBox.Font = new Font(textBox.Font.FontFamily, newSize, textBox.Font.Style);
        }
    }
}
