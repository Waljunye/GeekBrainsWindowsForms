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
        Stack<int> gameNumbers = new Stack<int>();
        private int labelNumber = 0;
        private int commandsCount = 0;
        private bool gameStarted = false;
        private int gameNumber;
        private int countOfTurns;
        public Form1()
        {
            InitializeComponent();
            gameNumbers.Push(labelNumber);
            UpdateNumber();
            UpdateCountOfCommands();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlusOne_Click(object sender, EventArgs e)
        {
            labelNumber++;
            commandsCount++;
            gameNumbers.Push(labelNumber);
            UpdateCountOfCommands();
            UpdateNumber();
            CheckGameNumber();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            labelNumber *= 2;
            commandsCount++;
            gameNumbers.Push(labelNumber);
            UpdateCountOfCommands();
            UpdateNumber();
            CheckGameNumber();
        }
        private void Win()
        {
            MessageBox.Show("Вы справились!", "Сообщение", MessageBoxButtons.OK);
        }
        private void CheckGameNumber()
        {
            if (gameStarted)
            {
                if(labelNumber == gameNumber)
                {
                    Win();
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            labelNumber = 0;
            commandsCount = 0;
            gameNumbers = new Stack<int>();
            gameNumbers.Push(labelNumber);
            UpdateCountOfCommands();
            UpdateNumber();

        }
        private void UpdateNumber()
        {

            label1.Text = gameNumbers.Peek().ToString();
        }
        private void UpdateCountOfCommands()
        {
            label2.Text = "Количество команд: " + commandsCount.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnPlayButtonClick(object sender, EventArgs e)
        {
            labelNumber = 0;
            commandsCount = 0;
            gameNumbers = new Stack<int>();
            UpdateCountOfCommands();
            UpdateNumber();
            gameStarted = true;
            Random random = new Random();
            countOfTurns = random.Next(5, 15);
            gameNumber = 0;
            for (int i = 0; i < countOfTurns; i++)
            {
                if (i == 0) gameNumber++;
                if (random.Next(1, 3) == 1)
                {
                    gameNumber++;
                }
                else
                {
                    gameNumber *= 2;
                }
            }
            label3.Text = $"Число: {gameNumber}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameNumbers.Pop();
            labelNumber = gameNumbers.Peek();
            commandsCount--;
            UpdateNumber();
            UpdateCountOfCommands();
        }
    }
}
