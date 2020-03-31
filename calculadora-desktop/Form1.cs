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
        double Result = 0;

        //0 - 9 buttons
        private void btnNum_Click(object btn, EventArgs e) {
            if (clearAfterOp == true) {
                display.Clear();
                clearAfterOp = false;
            }
            display.Text += (btn as Button).Text;
        }


        //DOT
        int dotCount = 0;
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

        private void div_Click(object btn, EventArgs e) {

        }

        private void mult_Click(object btn, EventArgs e) {

        }

        private void add_Click(object btn, EventArgs e) {
            

            if(clearAfterOp == false) {
                
                if (operation != "") {
                    calc(operation);
                }
            
                operation = "+";
                lastOp = operation;

                if (display.Text != "") {
                    result = double.Parse(display.Text, CultureInfo.InvariantCulture);
                    dotCount = 0;
                    clearAfterOp = true;
                }
            }
           



        }

        private void sub_Click(object sender, EventArgs e) {

            if (clearAfterOp == false) {

                if (operation != "") {
                    calc(operation);
                }

                operation = "-";
                lastOp = operation;

                if (display.Text != "") {
                    result = double.Parse(display.Text, CultureInfo.InvariantCulture);
                    dotCount = 0;
                    clearAfterOp = true;
                }
            }




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
                    default:
                        if(lastOp == "+") {
                            result += secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture); 
                        }
                        else if(lastOp == "-") {
                            result -= secondNum;
                            display.Text = result.ToString(CultureInfo.InvariantCulture);
                        }
                        break;

                }
            }



        }

    }
}
