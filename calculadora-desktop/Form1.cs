using System;
using System.Globalization;
using System.Windows.Forms;

namespace calculadora_desktop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool clearAfterOp = false;
        string operation = "";
        static string lastOp = "";
        double secondNum = 0;
        double result = 0;
        int dotCount = 0;


        //0 - 9 buttons
        private void btnNum_Click(object btn, EventArgs e) {
            if (clearAfterOp == true) {
                display.Clear();
                clearAfterOp = false;
            }

            display.Text += (btn as Button).Text;
        }

        //DOT
        private void dot_Click(object btn, EventArgs e) {
            if (dotCount == 0) {
                display.Text += ".";
                dotCount++;
            }


        }

        //BACKSPACE
        private void backSpace_Click(object btn, EventArgs e) {
            if (display.Text != "") {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }

        }

        //FULL CLEAR
        private void clear_Click(object btn, EventArgs e) {
            display.Clear();
            dotCount = 0;
            secondNum = 0;
            result = 0;
            operation = "";

        }

        //DISPLAY CLEAR
        private void clearEntry_Click(object btn, EventArgs e) {
            display.Clear();
        }

        private void percent_Click(object btn, EventArgs e) {

        }


        private void operator_Click(object btn, EventArgs e) {
            operatorsLogic((btn as Button).Text);
        }



        private void equal_Click(object sender, EventArgs e) {

            calc(operation);
            operation = "";


        }

        private void calc(string op) {

            if (display.Text != "") {
                switch (op) {
                    case "+":

                        secondNum = double.Parse(display.Text, CultureInfo.InvariantCulture);

                        result += secondNum;
                        display.Text = result.ToString(CultureInfo.InvariantCulture);

                        break;

                    case "-":

                        secondNum = double.Parse(display.Text, CultureInfo.InvariantCulture);
                        result -= secondNum;
                        display.Text = result.ToString(CultureInfo.InvariantCulture);


                        break;
                    case "x":

                        secondNum = double.Parse(display.Text, CultureInfo.InvariantCulture);
                        result *= secondNum;
                        display.Text = result.ToString(CultureInfo.InvariantCulture);


                        break;
                    case "/":
                        if (secondNum == 0) {
                            MessageBox.Show("Cannot divide by zero", "ERROR");
                            display.Text = "error...";
                        }
                        else {

                            secondNum = double.Parse(display.Text, CultureInfo.InvariantCulture);
                            result /= secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }

                        break;
                    default:
                        if (lastOp == "+") {
                            result += secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }
                        else if (lastOp == "-") {
                            result -= secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }
                        else if (lastOp == "x") {
                            result *= secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }
                        else if (lastOp == "/") {
                            result /= secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }
                        break;

                }
            }



        }

        private void operatorsLogic(string buttonText) {
            if (clearAfterOp == false) {

                if (operation != "") {
                    calc(operation);
                }

                operation = buttonText;
                lastOp = operation;

                if (display.Text != "") {
                    result = double.Parse(display.Text, CultureInfo.InvariantCulture);
                    dotCount = 0;
                    clearAfterOp = true;
                }
            }
        }

        /*
         48 -> 57 Numero
         44 e 46 -> ponto
         42 * 43 + 45 - 47 /  
         13 enter
         8 backspace
         27 esc
        */

        private void keyboardController(object sender, KeyPressEventArgs e) {
            
            if (e.KeyChar >= 48 && e.KeyChar <= 57) {
                if (clearAfterOp == true) {
                    display.Clear();
                    clearAfterOp = false;
                }
                display.Text += e.KeyChar.ToString();
            }
            if(e.KeyChar == 42 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 47) {
                if(e.KeyChar == 42) {
                    operatorsLogic("x");
                }
                else {
                    operatorsLogic(e.KeyChar.ToString());
                }
            }


            if(e.KeyChar == 13 ){
                calc(operation);
                operation = "";
                e.Handled = true;
            }
        }
    }
}
