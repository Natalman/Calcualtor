using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_1
{
    class Calculator
    {
        public static void adder(Button number, TextBox text)
        {
            string[] notIn = {"++", "+-", "+*", "+/", "--", "-+", "-/", "-*", "//", "/+","/*","/-",
            "**","*+", "*-","*/"};
            string OldNum = Convert.ToString(text.Text);
            string Num = Convert.ToString(number.Tag);
            string NewNum = OldNum + Num;

            for (int n = 0; n < notIn.Length; n++)
            {
                if (NewNum.Contains(notIn[n])){ MessageBox.Show("It contains two operators, please get rid of one operator"); }

                else{ text.Text = NewNum; }
            }      
        }

        public static void Calculate(TextBox Inside)
        {
            
            string num = Convert.ToString(Inside.Text);
            string[] nums = new string[2];
            char[] serp = new char[] { '+', '/', '*', '-' };
            double[] nl =new  double[2];
            double sum = 0.0;
            if (num.EndsWith("+") || num.EndsWith("/") || num.EndsWith("*") || num.EndsWith("-"))
            {
                MessageBox.Show("Operation Invalid");
            }
            else
            {
                if (!num.StartsWith("-")){ nums = num.Split(serp); }

                if (num.StartsWith("-"))
                {
                    string[] elevator = new string[2];
                    num = num.Remove(0, 1);
                    nums = num.Split(serp);
                    nums[0] = "-" + nums[0];
                }

                nl = Array.ConvertAll(nums, double.Parse);

                if (num.Contains('+')) { sum = nl[0] + nl[1]; }
                if (num.Contains('-')) { sum = nl[0] - nl[1]; }
                if (num.Contains('/')) { sum = nl[0] / nl[1]; }
                if (num.Contains('*')) { sum = nl[0] * nl[1]; }

                Inside.Text = Convert.ToString(sum);
            }   
        }

        public static void sqrt(TextBox Inside)
        {
            double num = Convert.ToDouble(Inside.Text);
            double square = Math.Sqrt(num);
            Inside.Text = Convert.ToString(square);
        }

        public static void exp(TextBox Inside)
        {
            double num = Convert.ToDouble(Inside.Text);
            double resp = 1 / num;
            Inside.Text = Convert.ToString(resp);
        }

        public static void minus(TextBox Inside)
        {
            string num = Convert.ToString(Inside.Text);
            string minuser = "";

            if (num.StartsWith("-")) { minuser = num.Trim('-'); }
            else { minuser = "-" + num; }

            Inside.Text = Convert.ToString(minuser);
        }

        public static void remove( TextBox Inside)
        {
            string num = Convert.ToString(Inside.Text);
            string remover = num.Remove(num.Length - 1);
            Inside.Text = Convert.ToString(remover);
        }
    }
}
