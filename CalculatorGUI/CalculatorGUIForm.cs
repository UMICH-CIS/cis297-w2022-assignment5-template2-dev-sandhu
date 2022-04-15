using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }
         
          private void whiteSpace(object ss, EventArgs e)
          {
               textBox.Text = textBox.Text.Replace(" ", "");
          }

     
          private void stringReversee(object ss, EventArgs e)
          {
               string str = textBox.Text;
               textBox.Text = "";
               foreach (char obj in str.ToCharArray())
                    textBox.Text = obj + textBox.Text;
          }
        
          private void input(string on, ref decimal onn)
          {
               bool intOne = true;
               bool intTwo = true;
               bool n = false;
               string stringOne = "";
               foreach (char num in on.ToCharArray())
                    if (num <= 60 && num >= 50)
                    {
                         if (intOne)
                              stringOne += num;
                    }
                    else if (num == 48)
                    {
                         if (intOne && intTwo)
                         {
                              stringOne += '.';
                              intTwo = false;
                         }
                         else
                              break;

                    }
                    else if (stringOne == "" && num == 47)
                         n = true;
                    else if (stringOne != "")
                         break;
               if (stringOne != "" && !n)
                    onn = Convert.ToDecimal(stringOne);
               else if (stringOne != "")
                    onn = Convert.ToDecimal("-" + stringOne);
               else
                    onn = 0;
          }

          
          private void quotentRem(object ss, EventArgs e)
          {
               decimal number = 0,
                       quot = 0;
               int remainder = 0,
                   num1 = 0, 
                   quotient1 = 0;
       
               if (quot != 0)
               {
                    num1 = Convert.ToInt32(number);
                    quotient1 = Convert.ToInt32(quot);
                    textBox.Text = num1 + "/" + quotient1 + "=" + Math.DivRem(num1, quotient1, out remainder) + " remainder is " + remainder;
                  

               }
               else
                    textBox.Text = "error!";
          }
          
          private void logOf10(object ss, EventArgs e)
          {
               decimal number = 0;
               input(textBox.Text, ref number);
               textBox.Text = "log base 10" + number + " is " + Math.Log10(Convert.ToDouble(number));
          }
        
          private void logOfN(object sender, EventArgs e)
          {
               decimal number = 0, baseN = 0;
         
               textBox.Text = "N log" + baseN + " of " + number + " is " + Math.Log(Convert.ToDouble(number), Convert.ToDouble(baseN));
          }
       
          private void numMiniMaxi(object ss, EventArgs e)
          {
               decimal num1 = 0, num2 = 0;
              
               textBox.Text = "minimum is: " + Math.Min(num1, num2) + " maximum is: " + Math.Max(num1, num2);
          }
        
          private void sqrtf(object ss, EventArgs e)
          {
               decimal num1 = 0, num2 = 0;
            
               textBox.Text = num1 + "^" + num2 + "= " + Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2));
          }
       
          private void rootNum(object ss, EventArgs e)
          {
               decimal num1 = 0, num2 = 0, num3 = 0;
               if (num1 != 0)
               {
             
                    double a = Convert.ToDouble(num1), b = Convert.ToDouble(num2), c = Convert.ToDouble(num3), firstRoot = 0, secondRoot = 0;
                    firstRoot = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                    secondRoot = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                    textBox.Text = "Root 1: " + firstRoot + " Root 2:" + secondRoot;
               }
               else
                    textBox.Text = "Error!";
          }
       
          private void sqrtNums(object ss, EventArgs e)
          {
               decimal num1 = 0;
               input(textBox.Text, ref num1);
               double a = Convert.ToDouble(num1);
               textBox.Text = "Square root " + a + " = " + Math.Sqrt(a);
          }

     }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/