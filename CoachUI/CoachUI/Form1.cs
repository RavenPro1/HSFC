using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {


        public Coach myCoach = new Coach();


        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Create person with name and age
            Person p1 = new Person(textBoxName.Text, Convert.ToInt32(textBoxAge.Text));
            //Add to the coach; it passes back the seat number
            int seat = myCoach.AddPerson(p1);
            //display seat number
            textBoxSeat.Text = seat + "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxAge.Text = "";
            textBoxSeat.Text = "";
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            textBoxSeat.Text = Convert.ToString(myCoach.GetSeatByName(textBoxName.Text));
        }
        

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            myCoach.RemovePersonByName(textBoxName.Text);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

