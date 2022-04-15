namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private Rectangle oneButtomOriginalRectangle;
        private Rectangle twoButtomOriginalRectangle;
        private Rectangle threeButtomOriginalRectangle;
        private Rectangle fourButtomOriginalRectangle;
        private Rectangle fiveButtomOriginalRectangle;
        private Rectangle sixButtomOriginalRectangle;
        private Rectangle sevenButtomOriginalRectangle;
        private Rectangle eightButtomOriginalRectangle;
        private Rectangle nineButtomOriginalRectangle;
        private Rectangle zeroButtomOriginalRectangle;
        private Rectangle decimalButtomOriginalRectangle;
        private Rectangle clearButtomOriginalRectangle;
        private Rectangle multiplyButtomOriginalRectangle;
        private Rectangle divideButtomOriginalRectangle;
        private Rectangle minusButtomOriginalRectangle;
        private Rectangle equalButtomOriginalRectangle;
        private Rectangle plusButtomOriginalRectangle;
        private Rectangle binButtomOriginalRectangle;
        private Rectangle decButtomOriginalRectangle;
        private Rectangle locButtomOriginalRectangle;
        private Rectangle titleOriginalRectangle;

        private Size originalFormSize;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            oneButtomOriginalRectangle = new Rectangle(n1.Location.X, n1.Location.Y, n1.Width, n1.Height);
            twoButtomOriginalRectangle = new Rectangle(n2.Location.X, n2.Location.Y, n2.Width, n2.Height);
            threeButtomOriginalRectangle = new Rectangle(n3.Location.X, n3.Location.Y, n3.Width, n3.Height);
            fourButtomOriginalRectangle = new Rectangle(n4.Location.X, n4.Location.Y, n4.Width, n4.Height);
            fiveButtomOriginalRectangle = new Rectangle(n5.Location.X, n5.Location.Y, n5.Width, n5.Height);
            sixButtomOriginalRectangle = new Rectangle(n6.Location.X, n6.Location.Y, n6.Width, n6.Height);
            sevenButtomOriginalRectangle = new Rectangle(n7.Location.X, n7.Location.Y, n7.Width, n7.Height);
            eightButtomOriginalRectangle = new Rectangle(n8.Location.X, n8.Location.Y, n8.Width, n8.Height);
            nineButtomOriginalRectangle = new Rectangle(n9.Location.X, n9.Location.Y, n9.Width, n9.Height);
            zeroButtomOriginalRectangle = new Rectangle(n0.Location.X, n0.Location.Y, n0.Width, n0.Height);
            clearButtomOriginalRectangle = new Rectangle(AC.Location.X, AC.Location.Y, AC.Width, AC.Height);
            plusButtomOriginalRectangle = new Rectangle(plus.Location.X, plus.Location.Y, plus.Width, plus.Height);
            minusButtomOriginalRectangle = new Rectangle(minus.Location.X, minus.Location.Y, minus.Width, minus.Height);
            multiplyButtomOriginalRectangle = new Rectangle(multiply.Location.X, multiply.Location.Y, multiply.Width, multiply.Height);
            divideButtomOriginalRectangle = new Rectangle(divide.Location.X, divide.Location.Y, divide.Width, divide.Height);
            equalButtomOriginalRectangle = new Rectangle(equal.Location.X, equal.Location.Y, equal.Width, equal.Height);
            decimalButtomOriginalRectangle = new Rectangle(DecimalPoint.Location.X, DecimalPoint.Location.Y, DecimalPoint.Width, DecimalPoint.Height);
            binButtomOriginalRectangle = new Rectangle(bin.Location.X, bin.Location.Y, bin.Width, bin.Height);
            decButtomOriginalRectangle = new Rectangle(dec.Location.X, dec.Location.Y, dec.Width, dec.Height);
            locButtomOriginalRectangle = new Rectangle(loc.Location.X, loc.Location.Y, loc.Width, loc.Height);
            titleOriginalRectangle = new Rectangle(title.Location.X, title.Location.Y, title.Width, title.Height);


        }
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(oneButtomOriginalRectangle, n1);
            resizeControl(twoButtomOriginalRectangle, n2);
            resizeControl(threeButtomOriginalRectangle, n3);
            resizeControl(fourButtomOriginalRectangle, n4);
            resizeControl(fiveButtomOriginalRectangle, n5);
            resizeControl(sixButtomOriginalRectangle, n6);
            resizeControl(sevenButtomOriginalRectangle, n7);
            resizeControl(eightButtomOriginalRectangle, n8);
            resizeControl(nineButtomOriginalRectangle, n9);
            resizeControl(zeroButtomOriginalRectangle, n0);
            resizeControl(clearButtomOriginalRectangle, AC);
            resizeControl(plusButtomOriginalRectangle, plus);
            resizeControl(minusButtomOriginalRectangle, minus);
            resizeControl(multiplyButtomOriginalRectangle, multiply);
            resizeControl(divideButtomOriginalRectangle, divide);
            resizeControl(equalButtomOriginalRectangle, equal);
            resizeControl(decimalButtomOriginalRectangle, DecimalPoint);
            resizeControl(binButtomOriginalRectangle, bin);
            resizeControl(decButtomOriginalRectangle, dec);
            resizeControl(locButtomOriginalRectangle, loc);
            resizeControl(titleOriginalRectangle, title);

        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        float num1, num2, result;
        char operation;
        bool dec1 = false;

        private void changeLabel(int numPressed)
        {
            if(dec1 == true)
            {
                int decimalCount = 0;
                foreach(char c in title.Text)
                {
                    if(c == '.')
                    {
                        decimalCount++;
                    }
                }
                if(decimalCount < 1)
                {
                    title.Text = title.Text + ".";
                }
                dec1 = false;
            }
            else
            {
                if(title.Text.Equals("0") == true && title.Text != null)
                {
                    title.Text = numPressed.ToString();
                }
                else if(title.Text.Equals("-0") == true)
                {
                    title.Text = "-" + numPressed.ToString();
                }
                else
                {
                    title.Text = title.Text + numPressed.ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dec1 = true;
            changeLabel(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }

        private void n7_Click(object sender, EventArgs e)
        {
            changeLabel(7);

        }

        private void n8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }
        private void n2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }
        private void n4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void n1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void AC_Click(object sender, EventArgs e)
        {
            title.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec1 = false;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(title.Text);
            operation = '+';
            result = result + num1;
            title.Text = "";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(title.Text);
            operation = '-';
            result = result - num1;
            title.Text = "";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(title.Text);
            operation = '*';
            result = result * num1;
            title.Text = "";
        }

        private void division_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(title.Text);
            operation = '/';
            result = result / num1;
            title.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            result = 0;
            if(title.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(title.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(title.Text);
                        result = num1 - num2;
                        break;
                    case '*':
                        num2 = float.Parse(title.Text);
                        result = num1 * num2;
                        break;
                    case '/':
                        num2 = float.Parse(title.Text);
                        result = num1 / num2;
                        break;
                    default:
                        break;
                }
            }
            title.Text = result.ToString();
        }
    

        private void BinaryNumber_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(title.Text);
            title.Text = CovertToBinary(dec);
        }
        public string CovertToBinary(double Dec)
        {
            int maxPow = 0;
            string binary = "";
            while (Math.Pow(2, maxPow) < Dec)
            {
                maxPow++;
            }
            maxPow--;
            for (int i = maxPow; i >= 0; i--)
            {
                if (Math.Pow(2, i) <= Dec)
                {
                    binary += "1";
                    Dec = Dec - Math.Pow(2, i);
                }
                else
                {
                    binary += "0";
                }
            }
            return binary;
        }

        private void DecimalNumber_Click(object sender, EventArgs e)
        {
            string dec = title.Text.ToString();
            title.Text = ConvertToDec(dec).ToString();
        }

        private double ConvertToDec(string Bin)
        {
            double Dec = 0;
            var length = Bin.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                if (Bin[length - 1 - i] == '1')
                {
                    Dec += Math.Pow(2, i);
                }
            }
            return Dec;
        }

        private void LocationalNumeral_Click(object sender, EventArgs e)
        {

        }


    }
}