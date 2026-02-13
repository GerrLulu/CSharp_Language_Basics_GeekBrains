using System;
using System.Windows.Forms;

namespace HW_PuzzleGame
{
    public partial class Form1 : Form
    {
        private int _number;


        public Form1()
        {
            InitializeComponent();
        }


        public void RandomNumber()
        {
            Random rnd = new Random();
            _number = rnd.Next(0, 100);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            RandomNumber();
            buttonStartGame.Visible = false;
            lableInfoPlay.Visible = false;
            labelTask.Visible = false;
            buttonEnter.Visible = true;
            textBoxAnswer.Visible = true;
            lableInfoGame.Visible = true;
            lableCountTries.Visible = true;
            labelInfoCountTries.Visible = true;
        }

        private void textBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            lableCountTries.Text = (int.Parse(lableCountTries.Text) + 1).ToString();

            if (int.TryParse(textBoxAnswer.Text, out int number))
            {
                if (number < _number)
                {
                    lableInfoGame.Text = $"Вы ввели меньшее число";
                }
                else if (number > _number)
                {
                    lableInfoGame.Text = $"Вы ввели большее число";
                }
                else if(number == _number)
                {
                    if (MessageBox.Show("Вы угадали число. Хотите попробовать еще раз?", "Поздравляю!",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RandomNumber();
                        lableCountTries.Text = "0";
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else if (number > 100 || number < 0)
            {
                lableInfoGame.Text = $"Вы ввели число вне диапазона! Введите число от 0 до 100!";
            }
            else
            {
                lableInfoGame.Text = $"Вы ввели не число! Введите число от 0 до 100!";
            }
        }
    }
}
