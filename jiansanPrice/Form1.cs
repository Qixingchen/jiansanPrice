using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jiansanPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int sumPriceInt = 0;
            try
            {
                sumPriceInt = int.Parse(sumPrice.Text);
            }
            catch (Exception ignore)
            {
                MessageBox.Show("请输入正确的总价");
                return;
            }

            int sumPersonInt = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                try
                {
                    int person = int.Parse(row.Cells["人数"].Value.ToString());
                    if (person < 0)
                    {
                        MessageBox.Show("人数不能是负数");
                        return;
                    }
                    sumPersonInt += person;
                }
                catch (NullReferenceException npe)
                {

                }
                catch (Exception ignore)
                {
                    MessageBox.Show("人数:" + row.Cells["人数"].Value.ToString() + "不是有效的数字");
                    return;
                }
            }
            sumPerson.Text = sumPersonInt.ToString();
            if (sumPersonInt == 0)
            {
                MessageBox.Show("总人数为0");
                return;
            }
            int sumPriceInHundred = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                try
                {
                    int person = int.Parse(row.Cells["人数"].Value.ToString());
                    double price = (sumPriceInt * 1.0 / sumPersonInt * person);
                    row.Cells["每个帮的价格"].Value = price.ToString("F2");
                    int priceInHundred = (int)Math.Round(price / 100, 0) * 100;
                    row.Cells["调剂后价格"].Value = priceInHundred;
                    sumPriceInHundred += priceInHundred;
                }
                catch (NullReferenceException npe) { }
            }
            afterPrice.Text = sumPriceInHundred.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
