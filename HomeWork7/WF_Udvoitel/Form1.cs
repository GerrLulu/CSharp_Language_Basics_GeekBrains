using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        private Stack<string> _number = new Stack<string>();
        private Stack<string> _count = new Stack<string>();


        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            labelRandomNumber.Text = rnd.Next(1, 1000000).ToString();
        }


        public new void Update()
        {
            this.Refresh();
            if (lablePlayerNumber.Text == labelRandomNumber.Text)
            {
                if (MessageBox.Show("Вы достигли заданного числа. Хотите попробовать еще раз?", "Поздравляю!",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Random rnd = new Random();
                    labelRandomNumber.Text = rnd.Next(1, 1000000).ToString();
                    lablePlayerNumber.Text = "0";
                    lableCountTries.Text = "0";
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void buttonPlusOne_Click(object sender, EventArgs e)
        {
            lablePlayerNumber.Text = (int.Parse(lablePlayerNumber.Text) + 1).ToString();
            _number.Push(lablePlayerNumber.Text);
            lableCountTries.Text = (int.Parse(lableCountTries.Text) + 1).ToString();
            _count.Push(lableCountTries.Text);
            Update();
        }

        private void buttonMultiplyTwo_Click(object sender, EventArgs e)
        {
            lablePlayerNumber.Text = (int.Parse(lablePlayerNumber.Text) * 2).ToString();
            _number.Push(lablePlayerNumber.Text);
            lableCountTries.Text = (int.Parse(lableCountTries.Text) + 1).ToString();
            _count.Push(lableCountTries.Text);
            Update();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            lablePlayerNumber.Text = "0";
            _number.Push(lablePlayerNumber.Text);
            lableCountTries.Text = (int.Parse(lableCountTries.Text) + 1).ToString();
            _count.Push(lableCountTries.Text);
            Update();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            lablePlayInfo.Visible = false;
            labelTask.Visible = false;
            buttonPlusOne.Visible = true;
            buttonMultiplyTwo.Visible = true;
            buttonReset.Visible = true;
            lablePlayerNumber.Visible = true;
            lableCountTries.Visible = true;
            lableInfoPlayerNumber.Visible = true;
            lableInfoCountTries.Visible = true;
            labelInfoRandomNumber.Visible = true;
            labelRandomNumber.Visible = true;
            buttonCancel.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _number.Pop();
            lablePlayerNumber.Text = _number.Peek();
            _count.Pop();
            lableCountTries.Text = _count.Peek();
        }
    }
}