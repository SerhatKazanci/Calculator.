namespace Calculator
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if(labelScreen.Text == "0")
            {
                labelScreen.Text = "";
                
            }
            labelScreen.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = ""; 
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = ""; ;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                labelScreen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";

            }
            labelScreen.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelScreen.Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelScreen.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelScreen.Text);
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelScreen.Text);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(labelScreen.Text);
            int sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }

            labelScreen.Text = sonuc.ToString();        }

     

        private void buttonC_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "0";
        }
    }
}