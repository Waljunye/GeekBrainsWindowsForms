using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekBrainsWindowsForms
{
    
    public partial class Form1 : Form
    {
        Random random = new Random();
        int winNumer;
        bool gameEnd = false;
        public Form1()
        {
            InitializeComponent();
            winNumer = random.Next(0, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!gameEnd)
            {
                if (int.TryParse(textBox1.Text, out int guessNumber))
                {
                    if (guessNumber == winNumer)
                    {
                        label1.Text = $"Вы угадали! Число - {winNumer}";
                        gameEnd = true;
                    }
                    else if (guessNumber < winNumer)
                    {
                        label1.Text = "Нет же! Больше!";
                    }
                    else if (guessNumber > winNumer)
                    {
                        label1.Text = "Нет же! Меньше";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int guessNumber))
            {
                if(guessNumber == winNumer)
                {
                    label1.Text = $"Вы угадали! Число - {winNumer}";
                }else if(guessNumber < winNumer)
                {
                    label1.Text = "Нет же! Больше!";
                }else if(guessNumber > winNumer)
                {
                    label1.Text = "Нет же! Меньше";
                }
            }
            
        }
    }
}
