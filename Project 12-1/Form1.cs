﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {

            if(sender == btn0) { Calculator.adder(btn0, txtResult);}
            if(sender == btn1) { Calculator.adder(btn1, txtResult);}
            if(sender == btn2) { Calculator.adder(btn2, txtResult);}
            if(sender == btn3) { Calculator.adder(btn3, txtResult);}
            if(sender == btn4) { Calculator.adder(btn4, txtResult);}
            if(sender == btn5) { Calculator.adder(btn5, txtResult);}
            if(sender == btn6) { Calculator.adder(btn6, txtResult);}
            if(sender == btn7) { Calculator.adder(btn7, txtResult);}
            if(sender == btn8) { Calculator.adder(btn8, txtResult);}
            if(sender == btn9) { Calculator.adder(btn9, txtResult);}
            if(sender == btnPoint) { Calculator.adder(btnPoint, txtResult); }
            if(sender == btnPlus) { Calculator.adder(btnPlus, txtResult);}
            if(sender == btnMinus) { Calculator.adder(btnMinus, txtResult);}
            if(sender == btnDivide) { Calculator.adder(btnDivide, txtResult);}
            if(sender == btnTimes) { Calculator.adder(btnTimes, txtResult);}
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculator.Calculate(txtResult);      
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Calculator.sqrt(txtResult);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            Calculator.exp(txtResult);
        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            Calculator.minus(txtResult);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calculator.remove(txtResult);
        }
    }
}
