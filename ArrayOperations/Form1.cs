using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArrayOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ToArray()
        {
            string[] sNums = ArrayTB.Text.Split(' ');
            int[] nums = new int[sNums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(sNums[i]);
            }
            return nums;
            
        }

        private void SumBtnClick(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ToArray();

                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                SumTB.Text = sum.ToString();
            }
            catch
            {
                SumTB.Text = "Ошибка";
            }
        }

        private void CompositionBtnClick(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ToArray();

                int composition = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    composition *= arr[i];
                }
                CompTB.Text = composition.ToString();
            }
            catch
            {
                CompTB.Text = "Ошибка";
            }
        }

        private void GetMaxBtnClick(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ToArray();
                MaxTB.Text = arr.Max().ToString();
            }
            catch
            {
                MaxTB.Text = "Ошибка";
            }
        }

        private void GetMinBtnClick(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ToArray();
                MinTB.Text = arr.Min().ToString();
            }
            catch
            {
                MinTB.Text = "Ошибка";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
