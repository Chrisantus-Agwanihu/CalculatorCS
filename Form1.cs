using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace CalculatorC
{
    public partial class Form1 : Form
    {
        public bool OperationActive;

        
       

        private string[] operations = new string[4]
        {
            "+",
            "-",
            "/",
            "*"
        };
        private List<string> Numbs = new List<string>();
        public bool add;
        public bool multiply;
        public bool divide;
        public bool subtract;
        private Button One;
        private Label label1;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button Point;
        private Button EQUALS;
        private Button ADD;
        private Button DIVIDE;
        private Button MINUS;
        private Button MULTIPLICATION;
        private Button ClearAll;

        public Form1() => this.InitializeComponent();

        public Decimal DisplayNumb(
        string buttonNumber)
        {
            if (this.label1.Text.Length < 12)
            {

                if (!this.OperationActive)
                {
                    try
                    {
                        string str = this.label1.Text + Convert.ToString(buttonNumber);
                        Decimal num = Convert.ToDecimal(str);
                        this.label1.Text = str;
                        return num;
                    }
                    catch (Exception ex)
                    {
                        switch (ex)
                        {
                            case FormatException _:
                            case OverflowException _:
                                return 0M;
                            default:
                                goto label_11;
                        }
                    }
                }
            }
            if (this.OperationActive)
            {
                try
                {
                    this.OperationActive = false;
                    if (((IEnumerable<string>)this.operations).Contains<string>(this.label1.Text))
                        this.label1.Text = "";
                    string str = this.label1.Text + Convert.ToString(buttonNumber);
                    Convert.ToDecimal(str);
                    this.label1.Text = str;
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case FormatException _:
                        case OverflowException _:
                            return 0M;
                    }
                }
            }
        label_11:
            return 0M;
        }

        public void ADDITION()
        {
            try
            {
                this.Numbs.Add(this.label1.Text + "+");
                this.label1.Text = "+";
                this.OperationActive = true;
                this.add = true;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    return;
                OverflowException overflowException = ex as OverflowException;
            }
        }

        public void MULTIPLY()
        {
            try
            {
                if (!(this.label1.Text != "*"))
                    return;
                this.Numbs.Add(this.label1.Text + "*");
                this.label1.Text = "*";
                this.OperationActive = true;
                this.multiply = true;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    return;
                OverflowException overflowException = ex as OverflowException;
            }
        }

        public void SUBTRACT()
        {
            try
            {
                this.Numbs.Add(this.label1.Text + "-");
                this.label1.Text = "-";
                this.OperationActive = true;
                this.subtract = true;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    return;
                OverflowException overflowException = ex as OverflowException;
            }
        }

        public void DIVISION()
        {
            try
            {
                this.Numbs.Add(this.label1.Text + "/");
                this.label1.Text = "/";
                this.OperationActive = true;
                this.subtract = true;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    return;
                OverflowException overflowException = ex as OverflowException;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DisplayNumb((sender as Button).Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.DisplayNumb((sender as Button).Text);
        }

        private void EQUALS_Click(object sender, EventArgs e)
        {
            try
            {
                this.Numbs.Add(this.label1.Text);
                this.label1.Text = Convert.ToString(new DataTable().Compute(string.Join((string)null, (IEnumerable<string>)this.Numbs), (string)null));
                this.Numbs.Clear();
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    case FormatException _:
                    case OverflowException _:
                    case SyntaxErrorException _:
                        this.label1.Text = "ERROR";
                        this.Numbs.Clear();
                        break;
                }
            }
        }

        private void ADD_Click(object sender, EventArgs e) => this.ADDITION();

        private void MINUS_Click(object sender, EventArgs e) => this.SUBTRACT();

        private void DIVIDE_Click(object sender, EventArgs e) => this.DIVISION();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void MULTIPLICATION_Click(object sender, EventArgs e) => this.MULTIPLY();

        private void ClearAll_Click(object sender, EventArgs e) => this.label1.Text = "";

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}

       