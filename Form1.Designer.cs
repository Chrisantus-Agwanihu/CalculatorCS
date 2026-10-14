using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CalculatorC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.One = new Button();
            this.label1 = new Label();
            this.Two = new Button();
            this.Three = new Button();
            this.Four = new Button();
            this.Five = new Button();
            this.Six = new Button();
            this.Seven = new Button();
            this.Eight = new Button();
            this.Nine = new Button();
            this.Zero = new Button();
            this.Point = new Button();
            this.EQUALS = new Button();
            this.ADD = new Button();
            this.DIVIDE = new Button();
            this.MINUS = new Button();
            this.MULTIPLICATION = new Button();
            this.ClearAll = new Button();
            this.SuspendLayout();
            this.One.AutoSize = true;
            this.One.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.One.ForeColor = SystemColors.ControlText;
            this.One.Location = new System.Drawing.Point(12, 102);
            this.One.Name = "One";
            this.One.Size = new Size(75, 75);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new EventHandler(this.button1_Click_1);
            this.label1.BackColor = SystemColors.Control;
            this.label1.BorderStyle = BorderStyle.FixedSingle;
            this.label1.Font = new Font("Segoe UI", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new Size(416, 62);
            this.label1.TabIndex = 2;
            this.label1.Click += new EventHandler(this.label1_Click);
            this.Two.AutoSize = true;
            this.Two.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Two.ForeColor = SystemColors.ControlText;
            this.Two.Location = new System.Drawing.Point(90, 102);
            this.Two.Name = "Two";
            this.Two.Size = new Size(75, 75);
            this.Two.TabIndex = 1;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new EventHandler(this.button1_Click_1);
            this.Three.AutoSize = true;
            this.Three.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Three.ForeColor = SystemColors.ControlText;
            this.Three.Location = new System.Drawing.Point(171, 102);
            this.Three.Name = "Three";
            this.Three.Size = new Size(75, 75);
            this.Three.TabIndex = 1;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new EventHandler(this.button1_Click_1);
            this.Four.AutoSize = true;
            this.Four.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Four.ForeColor = SystemColors.ControlText;
            this.Four.Location = new System.Drawing.Point(12, 183);
            this.Four.Name = "Four";
            this.Four.Size = new Size(75, 75);
            this.Four.TabIndex = 1;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new EventHandler(this.button1_Click_1);
            this.Five.AutoSize = true;
            this.Five.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Five.ForeColor = SystemColors.ControlText;
            this.Five.Location = new System.Drawing.Point(90, 183);
            this.Five.Name = "Five";
            this.Five.Size = new Size(75, 75);
            this.Five.TabIndex = 1;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new EventHandler(this.button1_Click_1);
            this.Six.AutoSize = true;
            this.Six.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Six.ForeColor = SystemColors.ControlText;
            this.Six.Location = new System.Drawing.Point(171, 183);
            this.Six.Name = "Six";
            this.Six.Size = new Size(75, 75);
            this.Six.TabIndex = 1;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new EventHandler(this.button1_Click_1);
            this.Seven.AutoSize = true;
            this.Seven.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Seven.ForeColor = SystemColors.ControlText;
            this.Seven.Location = new System.Drawing.Point(12, 265);
            this.Seven.Name = "Seven";
            this.Seven.Size = new Size(75, 75);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new EventHandler(this.button1_Click_1);
            this.Eight.AutoSize = true;
            this.Eight.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Eight.ForeColor = SystemColors.ControlText;
            this.Eight.Location = new System.Drawing.Point(93, 265);
            this.Eight.Name = "Eight";
            this.Eight.Size = new Size(75, 75);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new EventHandler(this.button1_Click_1);
            this.Nine.AutoSize = true;
            this.Nine.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Nine.ForeColor = SystemColors.ControlText;
            this.Nine.Location = new System.Drawing.Point(171, 265);
            this.Nine.Name = "Nine";
            this.Nine.Size = new Size(75, 75);
            this.Nine.TabIndex = 1;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new EventHandler(this.button1_Click_1);
            this.Zero.AutoSize = true;
            this.Zero.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Zero.ForeColor = SystemColors.ControlText;
            this.Zero.Location = new System.Drawing.Point(12, 345);
            this.Zero.Name = "Zero";
            this.Zero.Size = new Size(234, 75);
            this.Zero.TabIndex = 1;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new EventHandler(this.button1_Click_1);
            this.Point.AutoSize = true;
            this.Point.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.Point.ForeColor = SystemColors.ControlText;
            this.Point.Location = new System.Drawing.Point(252, 345);
            this.Point.Name = "Point";
            this.Point.Size = new Size(75, 75);
            this.Point.TabIndex = 3;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new EventHandler(this.button11_Click);
            this.EQUALS.AutoSize = true;
            this.EQUALS.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.EQUALS.ForeColor = SystemColors.ControlText;
            this.EQUALS.Location = new System.Drawing.Point(333, 265);
            this.EQUALS.Name = "EQUALS";
            this.EQUALS.Size = new Size(75, 155);
            this.EQUALS.TabIndex = 4;
            this.EQUALS.Text = "=";
            this.EQUALS.UseVisualStyleBackColor = true;
            this.EQUALS.Click += new EventHandler(this.EQUALS_Click);
            this.ADD.AutoSize = true;
            this.ADD.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.ADD.ForeColor = SystemColors.ControlText;
            this.ADD.Location = new System.Drawing.Point(252, 183);
            this.ADD.Name = "ADD";
            this.ADD.Size = new Size(75, 75);
            this.ADD.TabIndex = 5;
            this.ADD.Text = "+";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new EventHandler(this.ADD_Click);
            this.DIVIDE.AutoSize = true;
            this.DIVIDE.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.DIVIDE.ForeColor = SystemColors.ControlText;
            this.DIVIDE.Location = new System.Drawing.Point(333, 183);
            this.DIVIDE.Name = "DIVIDE";
            this.DIVIDE.Size = new Size(75, 75);
            this.DIVIDE.TabIndex = 6;
            this.DIVIDE.Text = "/";
            this.DIVIDE.UseVisualStyleBackColor = true;
            this.DIVIDE.Click += new EventHandler(this.DIVIDE_Click);
            this.MINUS.AutoSize = true;
            this.MINUS.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.MINUS.ForeColor = SystemColors.ControlText;
            this.MINUS.Location = new System.Drawing.Point(252, 265);
            this.MINUS.Name = "MINUS";
            this.MINUS.Size = new Size(75, 75);
            this.MINUS.TabIndex = 7;
            this.MINUS.Text = "-";
            this.MINUS.UseVisualStyleBackColor = true;
            this.MINUS.Click += new EventHandler(this.MINUS_Click);
            this.MULTIPLICATION.AutoSize = true;
            this.MULTIPLICATION.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.MULTIPLICATION.ForeColor = SystemColors.ControlText;
            this.MULTIPLICATION.Location = new System.Drawing.Point(333, 102);
            this.MULTIPLICATION.Name = "MULTIPLICATION";
            this.MULTIPLICATION.Size = new Size(75, 75);
            this.MULTIPLICATION.TabIndex = 8;
            this.MULTIPLICATION.Text = "X";
            this.MULTIPLICATION.UseVisualStyleBackColor = true;
            this.MULTIPLICATION.Click += new EventHandler(this.MULTIPLICATION_Click);
            this.ClearAll.AutoSize = true;
            this.ClearAll.Font = new Font("Lucida Sans Unicode", 20.25f, (FontStyle)1);
            this.ClearAll.ForeColor = SystemColors.ControlText;
            this.ClearAll.Location = new System.Drawing.Point(252, 102);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new Size(75, 75);
            this.ClearAll.TabIndex = 9;
            this.ClearAll.Text = "AC";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new EventHandler(this.ClearAll_Click);
            this.AutoScaleDimensions = new SizeF(7f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new Size(444, 485);
            this.Controls.Add((Control)this.ClearAll);
            this.Controls.Add((Control)this.MULTIPLICATION);
            this.Controls.Add((Control)this.MINUS);
            this.Controls.Add((Control)this.DIVIDE);
            this.Controls.Add((Control)this.ADD);
            this.Controls.Add((Control)this.EQUALS);
            this.Controls.Add((Control)this.Point);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.Zero);
            this.Controls.Add((Control)this.Nine);
            this.Controls.Add((Control)this.Eight);
            this.Controls.Add((Control)this.Seven);
            this.Controls.Add((Control)this.Six);
            this.Controls.Add((Control)this.Five);
            this.Controls.Add((Control)this.Four);
            this.Controls.Add((Control)this.Three);
            this.Controls.Add((Control)this.Two);
            this.Controls.Add((Control)this.One);
            this.ForeColor = SystemColors.ControlText;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = nameof(Form1);
            this.Text = "Chrisantus's Calculator";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    } // end class Form1
} // end namespace CalculatorC

