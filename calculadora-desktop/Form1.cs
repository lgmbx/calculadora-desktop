using System;
using System.Globalization;
using System.Windows.Forms;

namespace calculadora_desktop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //Initial variables
        bool clearAfterOp = false;
        string operation = "";
        static string lastOp = "";
        double secondNum = 0;
        double result = 0;
        int dotCount = 0;


        ////Events for buttons
        //0 - 9
        private void BtnNum_Click(object btn, EventArgs e) {
            if (clearAfterOp == true) {
                display.Clear();
                clearAfterOp = false;
            }
            display.Text += (btn as Button).Text;
        }

        //Dot 
        private void Dot_Click(object btn, EventArgs e) {
            if (dotCount == 0) {
                display.Text += ".";
                dotCount++;
            }
        }

        //Backspace
        private void BackSpace_Click(object btn, EventArgs e) {
            if (display.Text != "") {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        //Full clear
        private void Clear_Click(object btn, EventArgs e) {
            display.Clear();
            dotCount = 0;
            secondNum = 0;
            result = 0;
            operation = "";
            lastOp = "";
        }

        //Display clear
        private void ClearEntry_Click(object btn, EventArgs e) {
            display.Clear();
        }

        //Percent
        private void Percent_Click(object btn, EventArgs e) {
            if (display.Text != "") {
                double percent = Convert.ToDouble(display.Text);
                double aux;
                if (operation == "+" || operation == "-") {
                    aux = (percent * result) / 100;
                    display.Text = aux.ToString(CultureInfo.InvariantCulture);
                }
                else if (operation == "x" || operation == "/") {
                    aux = percent / 100;
                    display.Text = aux.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        //Add, sub, mult and div
        private void Operator_Click(object btn, EventArgs e) {
            Operation((btn as Button).Text);
            
        }

        //Equal
        private void Equal_Click(object sender, EventArgs e) {
            Calculation(operation);
            operation = "";
        }
        


        ////Events for key pressed
        private void KeyboardController(object sender, KeyPressEventArgs e) {
            e.Handled = false;

            //Numerics
            if (e.KeyChar >= 48 && e.KeyChar <= 57) {
                if (clearAfterOp == true) {
                    display.Clear();
                    clearAfterOp = false;
                }
                display.Text += e.KeyChar.ToString();
            }

            //Dot (comma also work as a dot, in this case)
            else if (e.KeyChar == 44 || e.KeyChar == 46) {
                if (dotCount == 0) {
                    display.Text += ".";
                    dotCount++;
                }
            }

            //Operators
            else if (e.KeyChar == 42 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 47) {
                if (e.KeyChar == 42) {
                    Operation("x");
                }
                else {
                    Operation(e.KeyChar.ToString());
                }
            }

            //Percent
            else if (e.KeyChar == 37) {

                if (display.Text != "") {
                    double percent = Convert.ToDouble(display.Text);
                    double aux;

                    if (operation == "+" || operation == "-") {
                        aux = (percent * result) / 100;
                        display.Text = aux.ToString(CultureInfo.InvariantCulture);
                    }

                    else if (operation == "x" || operation == "/") {
                        aux = percent / 100;
                        display.Text = aux.ToString(CultureInfo.InvariantCulture);
                    }
                }
            }

            //Enter (equal)
            else if (e.KeyChar == 13) {
                Calculation(operation);
                operation = "";
                e.Handled = true;
            }

            //Backspace
            else if (e.KeyChar == Convert.ToInt32(Keys.Back)) {
                if (display.Text != "") {
                    display.Text = display.Text.Remove(display.Text.Length - 1);
                }
            }

            //Delete (clear entry)
            else if (e.KeyChar == Convert.ToInt32(Keys.Delete)) {
                display.Clear();
            }

            //Escape (full clear)
            else if (e.KeyChar == Convert.ToInt32(Keys.Escape)) {
                display.Clear();
                dotCount = 0;
                secondNum = 0;
                result = 0;
                operation = "";
                lastOp = "";
            }

            else {
                e.Handled = true;
            }
        }
        


        ////Logic
        //for calculation
        private void Calculation(string op) {
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
                        secondNum = double.Parse(display.Text, CultureInfo.InvariantCulture);
                        if (secondNum == 0.0) {
                            MessageBox.Show("Cannot divide by zero", "ERROR");
                            display.Text = "error...";
                        }
                        else {
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
        
        //for operation
        private void Operation(string opText) {
            if (clearAfterOp == false) {

                if (operation != "") {
                    Calculation(operation);
                }

                operation = opText;
                lastOp = operation;

                if (display.Text != "") {
                    result = double.Parse(display.Text, CultureInfo.InvariantCulture);
                    dotCount = 0;
                    clearAfterOp = true;
                }
            }
        }
        
    }
}
