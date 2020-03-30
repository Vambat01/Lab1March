using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1March
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ageEnter_TextChanged(object sender, EventArgs e)
        {

        }
        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
        private void CountButton_Click(object sender, EventArgs e)
        {

            string line = ageEnter.Text;
            string[] a = line.Split(' ');
            string[] result = new string[100];
                richTextBox1.Text += $"Average: {AverageAge(a)} \n";
            LessThanAverage(a, result);
                richTextBox1.Text += $"Less than average: {result} \n";
        }

        decimal AverageAge(string[] a)
        {
            decimal count = 0;
            decimal ave = 0;
            for (int i = 0; i < a.Length; i++)
            {
                ave += int.Parse(a[i]) ;
                count++;
            }
            ;
            ave = ave / count;// or/=
            return ave;
        }
        void LessThanAverage(string[] a, string[] result)
        {
            decimal ave = AverageAge(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null) { break; }
                if (decimal.Parse(a[i]) < ave)
                {
                    result[i] = a[i];
                }
            }
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//string[] LessThanAverage(string[] a)
//{
//    decimal ave = AverageAge(a);
//    for (int i = 0; i < a.Length; i++)
//    {
//        if (a[i] == null) { break; }
//        if (decimal.Parse(a[i]) < ave)
//        {
//            string[] result = new string[100];
//            result[i] += a[i];
//        }
//    }
//    result[0] = "fff";
//    return result;
//}
