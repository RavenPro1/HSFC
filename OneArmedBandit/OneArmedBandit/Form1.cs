using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using OneArmedBandit.Properties;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Image[] wheelimages = {Resources.apple, Resources.banana, Resources.cherries, Resources.grapes, Resources.lemon, Resources.seven, Resources.strawberry, Resources.watermelon,};
        private int[] currentPosPerWheel = new int[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void updatePictureBoxes()
        {
            PicBox1.Image = wheelimages[currentPosPerWheel[0]];
            PicBox1.Update();

            PicBox2.Image = wheelimages[currentPosPerWheel[1]];
            PicBox2.Update();

            PicBox3.Image = wheelimages[currentPosPerWheel[2]];
            PicBox3.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 3; i++)
            {
                currentPosPerWheel[i] = rand.Next(0, wheelimages.Length);
            }
            playStart();
            updatePictureBoxes();
        }

        private void Nudge1_Click(object sender, EventArgs e)
        {
            spin(0, 1);
            startNudge();
        }
        private void Nudge2_Click(object sender, EventArgs e)
        {
            spin(1, 1);
            startNudge();
        }

        private void Nudge3_Click(object sender, EventArgs e)
        {
            spin(2, 1);
            startNudge();
        }
        private void Spin1_Click(object sender, EventArgs e)
        {
            playStart();
            updatePictureBoxes();
            spinWheels();
            enableRandomNudge();
        }
        //Spin the wheel
        private void spin(int wheelNum, int amount)
        {
            currentPosPerWheel[wheelNum] = (currentPosPerWheel[wheelNum] + amount) % wheelimages.Length;
        }
        // update the pictures after clicking "nudge"
        public void startNudge()
        {
            playSpin();
            updatePictureBoxes();
            if (detectWin())
            {
                playWin();
            }
        }

        public void enableRandomNudge()
        {
            int theNum = rand.Next(0, 24);
            flashButtonOff(Nudge1);
            flashButtonOff(Nudge2);
            flashButtonOff(Nudge3);
            if (theNum % 2 == 0)
            {
                flashButtonOn(Nudge1);   
            }
            if (theNum % 3 == 0)
            {
                flashButtonOn(Nudge2);   
            }
            if (theNum % 5 == 0)
            {
                flashButtonOn(Nudge3);
            }
        }
        public void flashButtonOn(Button theButton)
        {
            theButton.ForeColor = System.Drawing.Color.Gold;
            theButton.Enabled = true;
        }
        public void flashButtonOff(Button theButton)
        {
            theButton.ForeColor = System.Drawing.Color.Black;
            theButton.Enabled = false;
        }


        private bool detectWin()
        {
            return ((currentPosPerWheel[0] == currentPosPerWheel[1]) &
                    (currentPosPerWheel[1] == currentPosPerWheel[2]));
        }

        public void spinWheels()
        {
            for (int i = 0; i < 10; i++)
            {
                spin(0, rand.Next(0,8));
                updatePictureBoxes();
                System.Threading.Thread.Sleep(100);
                spin(1, rand.Next(0, 8));
                System.Threading.Thread.Sleep(100);
                updatePictureBoxes();
                spin(2, rand.Next(0, 8));
                System.Threading.Thread.Sleep(100);
                updatePictureBoxes();
            }
        }
        private void playStart() 
        {
            SoundPlayer audio = new SoundPlayer(Resources.startSound);
            audio.Play();
        }

        private void playSpin()
        {
            SoundPlayer audio = new SoundPlayer(Resources.spinSound);
            audio.Play();
        }

        private void playWin() 
        {
            SoundPlayer audio = new SoundPlayer(Resources.winSound);
            audio.Play();
        }





        private void PicBox1_Click(object sender, EventArgs e)
        {

        }

        private void PicBox2_Click(object sender, EventArgs e)
        {

        }

        private void PicBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
