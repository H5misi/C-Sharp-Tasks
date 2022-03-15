using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row, col;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                row = int.Parse(textBox1.Text);
                textBox3.Width = row * 40;
                textBox4.Width = row * 40;
            }
            catch(System.FormatException ex)
            {
                textBox3.Width = 40;
                textBox4.Width = 40;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = row * col;
            string[] sepArr = new string[count];
            string[] separator = { " ", "\n" };
            int[,] sortedArr = new int[row, col];

            sepArr = textBox3.Text.Split(separator, count, StringSplitOptions.None);
            
            textBox4.Clear();

            for (int i = 0, k = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++, k++)
                {
                    sortedArr[i, j] = int.Parse(sepArr[k]);
                }

            }




            for (int i = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++)
                {

                    for (int m = 0; m < sortedArr.GetLength(0); m++)
                    {


                        for (int h = 0; h < sortedArr.GetLength(1); h++)
                        {
                            if (sortedArr[i, j] < sortedArr[m, h])
                            {
                                int max = sortedArr[i, j];
                                sortedArr[i, j] = sortedArr[m, h];
                                sortedArr[m, h] = max;
                            }
                        }

                    }
                }
            }


            for (int i = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++)
                {
                    textBox4.Text += sortedArr[i, j] + "   ";
                }
                textBox4.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = row * col;
            string[] sepArr = new string[count];
            string[] separator = { " ", "\n" };
            int[,] sortedArr = new int[row, col];
            
            sepArr = textBox3.Text.Split(separator, count, StringSplitOptions.None);

            textBox4.Clear();

            for (int i = 0, k = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++, k++)
                {
                    sortedArr[i, j] = int.Parse(sepArr[k]);
                }

            }




            for (int i = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++)
                {

                    for (int m = 0; m < sortedArr.GetLength(0); m++)
                    {


                        for (int h = 0; h < sortedArr.GetLength(1); h++)
                        {
                            if (sortedArr[i, j] > sortedArr[m, h])
                            {
                                int max = sortedArr[i, j];
                                sortedArr[i, j] = sortedArr[m, h];
                                sortedArr[m, h] = max;
                            }
                        }

                    }
                }
            }


            for (int i = 0; i < sortedArr.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArr.GetLength(1); j++)
                {
                    textBox4.Text += sortedArr[i, j] + "    ";
                }
                textBox4.Text += Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                col = int.Parse(textBox2.Text);
                textBox3.Height = col * 30;
                textBox4.Height = col * 30;
            }
            catch (System.FormatException ex)
            {
                textBox3.Height = 30;
                textBox4.Height = 30;
            }


        }
    }
}
