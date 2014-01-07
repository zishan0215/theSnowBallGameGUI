using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theSnowBallGameGUI
{
    public partial class Form1 : Form
    {
        Fighter player;
        RobFighter robot;
        int distance = 10;

        //My methods
        public void choosePlay(int range, RobFighter rob)
        {
            int dis;
            bool hit = false;
            dis = rob.robPlay(range);
            if (dis >= 0) {
                if (dis < range)
                {
                    lblRobResponse1.Text = "Moving closer";
                    lblRobResponse2.Text = "";
                    distance--;
                    lblDistance.Text = "Distance: " + distance;
                }
                else if (dis > range)
                {
                    lblRobResponse1.Text = "Moving away";
                    lblRobResponse2.Text = "";
                    distance++;
                    lblDistance.Text = "Distance: " + distance;
                }
            }
            else if (dis == -1 || dis == -4)
            {
                switch (dis)
                {
                    case -1:
                        lblRobResponse1.Text = "Making a snowball";
                        lblRobResponse2.Text = "";
                        rob.snowballs++;
                        lblRobSnowballs.Text = "Snowballs:   " + rob.snowballs;
                        break;
                    case -4:
                        lblRobResponse1.Text = "Throwing a snowball";
                        rob.snowballs--;
                        lblRobSnowballs.Text = "Snowballs:   " + rob.snowballs;
                        hit = rob.throwSnow(range);
                        if (hit)
                        {
                            lblRobResponse2.Text = player.name + " has been hit";
                            player.strength--;
                            lblPlrStrength.Text = "Strength:    " + player.strength;
                        }
                        else
                        {
                            lblRobResponse2.Text = "Missed you";
                        }//end if
                        break;
                }
            }//end if
            else {
                MessageBox.Show("Something unexpected has occured.");
            }
        }

        public void checkWinner() {
            if (player.strength <= 0)
            {
                MessageBox.Show("You lost!");
                disable();
            }
            else if (robot.strength <= 0)
            {
                MessageBox.Show("You win!");
                disable();
            }
        }

        public void disable() {
            btnMakeSnow.Enabled = false;
            btnMoveAway.Enabled = false;
            btnMoveCloser.Enabled = false;
            btnThrowSnow.Enabled = false;
        }

        public void enable() {
            btnMakeSnow.Enabled = true;
            btnMoveAway.Enabled = true;
            btnMoveCloser.Enabled = true;
            btnThrowSnow.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            lblDistance.Text = "Distance: " + distance;
            disable();
        }

        private void btnMakeSnow_Click(object sender, EventArgs e)
        {
            player.snowballs++;
            lblPlrResponse1.Text = "Making a snowball";
            lblPlrResponse2.Text = "";
            lblPlrSnowballs.Text = "Snowballs:   " + player.snowballs;
            choosePlay(distance, robot);
            checkWinner();
        }

        private void btnPlrName_Click(object sender, EventArgs e)
        {
            lblPlr.Text = "Player 1:    " + txtPlrName.Text;
            player = new Fighter(txtPlrName.Text);
            lblPlrResName.Text = player.name;
            lblPlrStrength.Text = "Strength:    " + player.strength;
            lblPlrSnowballs.Text = "Snowballs:   " + player.snowballs;
            txtPlrName.Hide();
            btnPlrName.Hide();
            if (txtRobName.Text != "") {
                enable();
                rtbInstructions.Hide();
            }
        }

        private void btnComName_Click(object sender, EventArgs e)
        {
            lblRobot.Text = "Player 2:    " + txtRobName.Text;
            robot = new RobFighter(player, txtRobName.Text);
            lblRobStrength.Text = "Strength:    " + robot.strength;
            lblRobSnowballs.Text = "Snowballs:   " + robot.snowballs;
            lblRobResName.Text = robot.name;
            txtRobName.Hide();
            btnRobName.Hide();
            if (txtPlrName.Text != "") {
                enable();
                rtbInstructions.Hide();
            }
        }

        private void btnMoveCloser_Click(object sender, EventArgs e)
        {
            lblPlrResponse1.Text = "Moving Closer";
            lblPlrResponse2.Text = "";
            distance--;
            if (distance < 0) {
                distance = 0;
            }
            lblDistance.Text = "Distance: " + distance;
            choosePlay(distance, robot);
            checkWinner();
        }

        private void btnMoveAway_Click(object sender, EventArgs e)
        {
            lblPlrResponse1.Text = "Moving Away";
            lblPlrResponse2.Text = "";
            distance++;
            lblDistance.Text = "Distance: " + distance;
            choosePlay(distance, robot);
            checkWinner();
        }

        private void btnThrowSnow_Click(object sender, EventArgs e)
        {
            bool hit = false;
            player.snowballs--;
            lblPlrSnowballs.Text = "Snowballs:   " + player.snowballs;
            lblPlrResponse1.Text = "Throwing a snowball";
            hit = player.throwSnow(distance);
            if (hit)
            {
                lblPlrResponse2.Text = robot.name + " has been hit";
                robot.strength--;
                lblRobStrength.Text = "Strength:    " + robot.strength;
            }
            else {
                lblPlrResponse2.Text = "You missed";
            }
            choosePlay(distance, robot);
            checkWinner();
        }//end throwSnow
    }


    public class Fighter
    {
        //Fields
        private string pName;
        private int pStrength;
        private int pSnowballs;

        //Properties
        public string name
        {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }//end name

        public int strength
        {
            get
            {
                return pStrength;
            }
            set
            {
                pStrength = value;
            }
        }//end strength

        public int snowballs
        {
            get
            {
                return pSnowballs;
            }
            set
            {
                pSnowballs = value;
            }
        }//end snowballs

        //Constructor
        public Fighter(string theName)
        {
            snowballs = 3;
            strength = 3;
            name = theName;
        }

        //Methods
        public void makeSnow()
        {
            snowballs++;
        }

        public bool throwSnow(int distance)
        {
            Random roller = new Random();
            int rand;
            bool hit = true;
            rand = roller.Next(10);
            if (distance < rand)
            {
                //strength--;
            }
            else
            {
                hit = false;
            }
            return hit;
        }//end throwSnow

    }//end fighter class

    public class RobFighter : Fighter
    {
        private Fighter player;

        //Constructor
        public RobFighter(Fighter thePlayer, string theName)
            : base(theName)
        {
            player = thePlayer;
        }

        //Methods
        public int robPlay(int range)
        {
            Random roller = new Random();
            int choice;
            if (snowballs <= 0)
            {
                return -1;  // -1: makesnow() in the switch statement
            }
            else
            {
                choice = roller.Next(6);
                switch (choice)
                {
                    case 0:
                        return -1;  // -1: makesnow()
                    case 1:              
                        return -4;  // -4: throwsnow()
                    case 2:
                        //come closer
                        range--;
                        if (range < 0)
                        {
                            range = 0;
                        }
                        break;
                    case 3:
                        //move away
                        range++;
                        break;
                    default:                        
                        return -4;  // -4: throwsnow()
                }//end switch
            }//end if
            return range;
        }//end robPlay
    }//end robFighter class
}
