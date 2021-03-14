/*
 * Name: David Montanez
 * Created: March 12, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        decimal firstNumber = 0;
        decimal secondNumber = 0;
        decimal results = 0;
        Boolean isOn = false;

        public Form1()
        {
            InitializeComponent();

            this.btnPower.Click += BtnPower_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSubtract.Click += BtnSubtract_Click;
            this.btnMultiply.Click += BtnMultiply_Click;
            this.btnDivide.Click += BtnDivide_Click;
            this.btnClear.Click += BtnClear_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if(isOn)
            {
                this.txtNumber1.Text = "";
                this.txtNumber2.Text = "";
                this.lblResults.Text = "";
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (isOn && this.txtNumber1.Text != "" && this.txtNumber2.Text != "")
            {
                ValidNumbers();

                firstNumber = Decimal.Parse((this.txtNumber1.Text));
                secondNumber = Decimal.Parse((this.txtNumber2.Text));

                results = firstNumber / secondNumber;
                this.lblResults.Text = results.ToString();
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (isOn && this.txtNumber1.Text != "" && this.txtNumber2.Text != "")
            {
                ValidNumbers();

                firstNumber = Decimal.Parse((this.txtNumber1.Text));
                secondNumber = Decimal.Parse((this.txtNumber2.Text));

                results = firstNumber * secondNumber;
                this.lblResults.Text = results.ToString();
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (isOn && this.txtNumber1.Text != "" && this.txtNumber2.Text != "")
            {
                ValidNumbers();

                firstNumber = Decimal.Parse((this.txtNumber1.Text));
                secondNumber = Decimal.Parse((this.txtNumber2.Text));

                results = firstNumber - secondNumber;
                this.lblResults.Text = results.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (isOn && this.txtNumber1.Text != "" && this.txtNumber2.Text != "")
            {
                ValidNumbers();

                firstNumber = Decimal.Parse((this.txtNumber1.Text));
                secondNumber = Decimal.Parse((this.txtNumber2.Text));

                results = firstNumber + secondNumber;
                this.lblResults.Text = results.ToString();
            }
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            if(this.btnPower.Text == "OFF")
            {
                this.txtNumber1.Visible = true;
                this.txtNumber2.Visible = true;
                this.btnPower.Text = "ON";
                isOn = true;
            }
            else if(this.btnPower.Text == "ON")
            {
                this.txtNumber1.Visible = false;
                this.txtNumber2.Visible = false;
                this.btnPower.Text = "OFF";
                isOn = false;
                this.txtNumber1.Text = "";
                this.txtNumber2.Text = "";
                this.lblResults.Text = "";
            }
        }

        private void ValidNumbers()
        {
            if(isOn)
            {
                try
                {
                    firstNumber = Decimal.Parse(this.txtNumber1.Text);
                    secondNumber = Decimal.Parse(this.txtNumber2.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Numbers cannot contain letters or special characters.");
                    this.txtNumber1.Text = "";
                    this.txtNumber2.Text = "";
                }
            }

        }
    }
}
