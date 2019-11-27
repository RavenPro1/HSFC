using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OandX.Properties;

namespace OandX
{
    public partial class Form1 : Form
    {
        bool Player1 = true;
        bool Player2 = false;

        bool but1 = false;
        bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        bool but5 = false;
        bool but6 = false;
        bool but7 = false;
        bool but8 = false;
        bool but9 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (but1) { return; }
                if (Player1 == true)
                {
                    Player1 = false; Player2 = true;
                    button1.BackgroundImage = Resources.Cross;
                    button1.Update();
                }
                else if (Player2 == true)
                {
                    Player1 = true; Player2 = false;
                    button1.BackgroundImage = Resources.Nought;
                    button1.Update();
                }
            but1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (but2) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button2.BackgroundImage = Resources.Cross;
                button2.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button2.BackgroundImage = Resources.Nought;
                button2.Update();
            }
            but2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (but3) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button3.BackgroundImage = Resources.Cross;
                button3.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button3.BackgroundImage = Resources.Nought;
                button3.Update();
            }
            but3 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (but4) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button4.BackgroundImage = Resources.Cross;
                button4.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button4.BackgroundImage = Resources.Nought;
                button4.Update();
            }
            but4 = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (but5) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button5.BackgroundImage = Resources.Cross;
                button5.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button5.BackgroundImage = Resources.Nought;
                button5.Update();
            }
            but5 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (but6) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button6.BackgroundImage = Resources.Cross;
                button6.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button6.BackgroundImage = Resources.Nought;
                button6.Update();
            }
            but6 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (but7) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button7.BackgroundImage = Resources.Cross;
                button7.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button7.BackgroundImage = Resources.Nought;
                button7.Update();
            }
            but7 = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (but8) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button8.BackgroundImage = Resources.Cross;
                button8.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button8.BackgroundImage = Resources.Nought;
                button8.Update();
            }
            but8 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (but9) { return; }
            if (Player1 == true)
            {
                Player1 = false; Player2 = true;
                button9.BackgroundImage = Resources.Cross;
                button9.Update();
            }
            else if (Player2 == true)
            {
                Player1 = true; Player2 = false;
                button9.BackgroundImage = Resources.Nought;
                button9.Update();
            }
            but9 = true;
        }
    }
}
