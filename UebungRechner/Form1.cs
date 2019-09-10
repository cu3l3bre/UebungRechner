using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UebungRechner
{
    public partial class FormRechner : Form
    {

        public FormRechner()
        {
            InitializeComponent();
        }


        private void buttonNumberX_Clicked(object sender, EventArgs e)
        {

            Button buttonNumberClicked = (Button)sender;

            if(buttonNumberClicked == buttonNum0)
            {
                labelCalculation.Text += "0";
            }
            else if (buttonNumberClicked == buttonNum1)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "1";
                }
                else
                {
                    labelCalculation.Text += "1";
                }
            }
            else if (buttonNumberClicked == buttonNum2)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "2";
                }
                else
                {
                    labelCalculation.Text += "2";
                }
            }
            else if (buttonNumberClicked == buttonNum3)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "3";
                }
                else
                {
                    labelCalculation.Text += "3";
                }
            }
            else if (buttonNumberClicked == buttonNum4)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "4";
                }
                else
                {
                    labelCalculation.Text += "4";
                }
            }
            else if (buttonNumberClicked == buttonNum5)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "5";
                }
                else
                {
                    labelCalculation.Text += "5";
                }
            }
            else if (buttonNumberClicked == buttonNum6)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "6";
                }
                else
                {
                    labelCalculation.Text += "6";
                }
            }
            else if (buttonNumberClicked == buttonNum7)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "7";
                }
                else
                {
                    labelCalculation.Text += "7";
                }
            }
            else if (buttonNumberClicked == buttonNum8)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "8";
                }
                else
                {
                    labelCalculation.Text += "8";
                }
            }
            else if (buttonNumberClicked == buttonNum9)
            {
                if (labelCalculation.Text[0] == '0')
                {
                    labelCalculation.Text = "9";
                }
                else
                {
                    labelCalculation.Text += "9";
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            labelCalculation.Text = "0";
            labelSide.Text = "0";
        }


        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (labelCalculation.Text.Length != 0)
            {
                String temp = labelCalculation.Text.Remove(labelCalculation.Text.Length - 1, 1);
                labelCalculation.Text = temp;
            }
        }



        private void buttonOperation_Clicked(object sender, EventArgs e)
        {

            Button buttonOperation = (Button)sender;

            if (buttonOperation == buttonAdd)
            {
                labelSide.Text = labelCalculation.Text + " ";
                labelOperation.Text = "+";
                labelCalculation.Text = "0";
            }
            else if (buttonOperation == buttonSub)
            {
                labelSide.Text = labelCalculation.Text + " "; ;
                labelOperation.Text = "-";
                labelCalculation.Text = "0";
            }

            else if (buttonOperation == buttonMul)
            {
                labelSide.Text = labelCalculation.Text + " "; ;
                labelOperation.Text = "x";
                labelCalculation.Text = "0";
            }

            else if (buttonOperation == buttonDiv)
            {
                labelSide.Text = labelCalculation.Text + " "; ;
                labelOperation.Text = "/";
                labelCalculation.Text = "0";
            }
            else
            {
                // TBD
            }



        }




        private double add(double number1, double number2)
        {
            return number1 + number2;
        }

        private double sub(double number1, double number2)
        {
            return number1 - number2;
        }

        private double mul(double number1, double number2)
        {
            return number1 * number2;
        }

        private double div(double number1, double number2)
        {
            return number1 / number2;
        }





        private void calculate()
        {

            String calculation = labelSide.Text + labelCalculation.Text;

            //String operation = labelOperation.Text;


            //if (calculation.Contains("+"))
            //{
            //    operation = "+";
            //}
            //else if(calculation.Contains("-"))
            //{
            //    operation = "-";
            //}
            //else if (calculation.Contains("x"))
            //{
            //    operation = "x";
            //}
            //else if (calculation.Contains("/"))
            //{
            //    operation = "/";
            //}



            String[] array = calculation.Split(' ');    //, '-', 'x', '/');


            String number1String = array[0].Trim();
            String number2String = array[1].Trim();


            double number1 = 0.0;
            double number2 = 0.0;
            double result = 0.0;

            try
            {
                number1 = Double.Parse(number1String);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hoppla, iwas war falsch mit Zahl 1 {0}", ex.GetType().Name);
            }


            try
            {
                number2 = Double.Parse(number2String);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hoppla, iwas war falsch mit Zahl 2 {0}", ex.GetType().Name);
            }

            switch (labelOperation.Text)
            {
                case "+":
                    result = add(number1,number2);
                    break;

                case "-":
                    result = sub(number1, number2);
                    break;

                case "x":
                    result = mul(number1, number2);
                    break;

                case "/":
                    result = div(number1, number2);
                    break;

                default:
                    MessageBox.Show("Hoppla, die Operation scheint es nicht zu geben");
                    break;

            }

            labelCalculation.Text = result.ToString();
            labelSide.Text = "0";
            labelOperation.Text = String.Empty;


        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
