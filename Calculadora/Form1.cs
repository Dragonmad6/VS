﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        //Variables
        double primero;
        double segundo;
        double resultado;
        string operacion;
        

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);
            
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    textBox1.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    textBox1.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    textBox1.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    textBox1.Text = resultado.ToString();
                    break;
            }
        }
    }
}
