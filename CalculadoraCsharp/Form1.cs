using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCsharp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 3;
        }
        private void button5_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e) {
            //soma
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }
        private void button13_Click(object sender, EventArgs e) {
            //subtração
            if (textBox1.Text != "") {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }

        private void button14_Click(object sender, EventArgs e) {
            //Multiplicação
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button15_Click(object sender, EventArgs e) {
            //Divisão
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button18_Click(object sender, EventArgs e) {
            //C
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e) {
            //CE
            if (num1 == 0 && textBox1.TextLength > 0) {
                num1 = 0;
                textBox1.Clear();
            } else if (num1 > 0 && textBox1.TextLength > 0) {
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            //resultado
            compute(count);
        }
        public void compute(int count) {
            switch (count) {
                case 1:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e) {
            //apagar
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button17_Click(object sender, EventArgs e) {
            //. (ponto)
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++) { if (text[i].ToString() == ".") { flag = 1; break; } else { flag = 0; } }
            if (flag == 0) { textBox1.Text = textBox1.Text + "."; }
        }

        private void button21_Click(object sender, EventArgs e) {
            //sqrt
            double sqrt = Math.Sqrt(float.Parse(textBox1.Text));
            textBox1.Text = sqrt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
