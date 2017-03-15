using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool bRechenoperation = false;
        private bool bDezimal = false;
        private bool bErsteStelle = false;
        private bool bEineRechenoperation = false;
        private int iNameRechenoperation = 0;       //0=Keine 1=Addieren 2=Multiplizieren 3=Minus 4=Geteilt
        private string sTextBoxInhalt = "";
        private StringBuilder sbTextBoxInhalt = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation==false)
            {
                textBoxErsteZahl.AppendText("0");

            }
            if (bRechenoperation==true)
            {
                textBoxZweiteZahl.AppendText("0");
            }

        }

        private void textBoxErsteZahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("1");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("2");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("3");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("4");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("5");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("6");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("7");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("8");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                textBoxErsteZahl.AppendText("9");

            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("9");
            }
        }

        private void buttonKomma_Click(object sender, EventArgs e)
        {
            if (bErsteStelle == true)
            {
                if (bDezimal == false)
                {
                    if (bRechenoperation == false)
                    {
                        textBoxErsteZahl.AppendText(",");

                    }
                    if (bRechenoperation == true)
                    {
                        textBoxZweiteZahl.AppendText(",");
                    }
                    bDezimal = true;
                }
            }
        }

        private void buttonGeteilt_Click(object sender, EventArgs e) //0=Keine 1=Addieren 2=Multiplizieren 3=Minus 4=Geteilt
        {
            if (bEineRechenoperation == false && bErsteStelle==true)
            {
                iNameRechenoperation=4;
                bEineRechenoperation = true;
                bErsteStelle = false;
                bDezimal = false;
                bRechenoperation = true;
            }

        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            if (bEineRechenoperation == false && bErsteStelle == true)
            {
                iNameRechenoperation = 2;
                bEineRechenoperation = true;
                bErsteStelle = false;
                bDezimal = false;
                bRechenoperation = true;
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (bEineRechenoperation == false && bErsteStelle == true)
            {
                iNameRechenoperation = 3;
                bEineRechenoperation = true;
                bErsteStelle = false;
                bDezimal = false;
                bRechenoperation = true;
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (bEineRechenoperation == false && bErsteStelle == true)
            {
                iNameRechenoperation = 1;
                bEineRechenoperation = true;
                bErsteStelle = false;
                bDezimal = false;
                bRechenoperation = true;
            }

        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {

            bErsteStelle = true;
            if (bRechenoperation == false)
            {
                sTextBoxInhalt = textBoxErsteZahl.Text.ToString();
                 if (sTextBoxInhalt.Length > 0)          
                        {
                            
                            if (sTextBoxInhalt.Length - 1 = ",")        
                            {
                              bDezimal=false;
                            }
                 }
            }
            if (bRechenoperation == true)
            {
                textBoxZweiteZahl.AppendText("7");
            }
        }
    }
}
