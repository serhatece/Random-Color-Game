using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Color_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Random rnd2 = new Random();

        int Random, Random2, ColorOrder;
        int AskOrder = 1;
        string[] ColorLists = new string[] { "Black", "Yellow", "Red", "Blue", "Green", "Orange", "Purple", "Pink", "Brown", "Gray", };


        private void Form1_Load(object sender, EventArgs e)
        {
            TakeColor();
        }

        void TakeColor()
        {
            Random2 = rnd2.Next(0, 4);
            for (int i = 0; i < 4; i++)
            {
                Random = rnd.Next(0, 10);

                switch (i)
                {
                    case 0:
                        button1.BackColor = Color.FromName(ColorLists[Random].ToString());
                        if (Random2 == 0)
                        {
                            label1.Text = "Which of the following colors " + ColorLists[Random] + "?";
                            ColorOrder = Random;
                        }
                        break;

                    case 1:
                        button2.BackColor = Color.FromName(ColorLists[Random].ToString());
                        if (Random2 == 1)
                        {
                            label1.Text = "Which of the following colors " + ColorLists[Random] + "?";
                            ColorOrder = Random;
                        }
                        break;

                    case 2:
                        button3.BackColor = Color.FromName(ColorLists[Random].ToString());
                        if (Random2 == 2)
                        {
                            label1.Text = "Which of the following colors " + ColorLists[Random] + "?";
                            ColorOrder = Random;
                        }
                        break;

                    case 3:
                        button4.BackColor = Color.FromName(ColorLists[Random].ToString());
                        if (Random2 == 3)
                        {
                            label1.Text = "Which of the following colors " + ColorLists[Random] + "?";
                            ColorOrder = Random;
                        }
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor.Name == ColorLists[ColorOrder])
            {
                MessageBox.Show("Congratulations, Correct Answer");
                if (AskOrder <= 10)
                {
                    AskOrder++;
                    TakeColor();
                }
                else
                {
                    MessageBox.Show("All Questions Answered");
                }
            }
            else
            {
                MessageBox.Show("Wrong answer, please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor.Name == ColorLists[ColorOrder])
            {
                MessageBox.Show("Congratulations, Correct Answer");
                if (AskOrder <= 10)
                {
                    AskOrder++;
                    TakeColor();
                }
                else
                {
                    MessageBox.Show("All Questions Answered");
                }
            }
            else
            {
                MessageBox.Show("Wrong answer, please try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor.Name == ColorLists[ColorOrder])
            {
                MessageBox.Show("Congratulations, Correct Answer");
                if (AskOrder <= 10)
                {
                    AskOrder++;
                    TakeColor();
                }
                else
                {
                    MessageBox.Show("All Questions Answered");
                }
            }
            else
            {
                MessageBox.Show("Wrong answer, please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor.Name == ColorLists[ColorOrder])
            {
                MessageBox.Show("Congratulations, Correct Answer");
                if (AskOrder <= 10)
                {
                    AskOrder++;
                    TakeColor();
                }
                else
                {
                    MessageBox.Show("All Questions Answered");
                }
            }
            else
            {
                MessageBox.Show("Wrong answer, please try again.");
            }
        }

    }
}