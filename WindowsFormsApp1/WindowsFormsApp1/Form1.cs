using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Player mainPlayer = new Player();
        Dragon mainDragon = new Dragon();
        int playerAction = new int();
        bool dragonDead = false;
        bool playerDead = false;

        public Form1()
        {
            InitializeComponent();


            funcPlayerHealth();
            txtDescription.Text += "A mighty dragon faces you down. You see fire streaming from it's nostrils, notice the sheen on it's gigantic teeth, and notice the razor sharp claws on it's feet. You feel terrified, but you must fight this dragon. For yourself, for your beloved (who incidentally doesn't love you), for your honor!" + Environment.NewLine;
            funcListUserActions();

        }

        //######## PLAYER HEALTH LIST #######
        void funcPlayerHealth()
        {
            //TODO
            //-------Move to Text box, upper left

            

        }

        //####### USER ACTION ########
        void funcListUserActions()
        {

            //Tell user his action
            txtDescription.Text += Environment.NewLine;
            txtDescription.Text += "What action would you like to take?" + Environment.NewLine;
            txtDescription.Text += Environment.NewLine; 
        }



        //###### PLAYER PERFORM #########
        bool funcPlayerPerform(int action)
        {
            //Perform action / outcome
            playerAction = action;
            txtDescription.Text += Environment.NewLine;
            switch (action)
            {
                case 1:
                    txtDescription.Text += "You attack!" + Environment.NewLine;
                    
                    mainDragon.dragonHealth -= mainPlayer.playerAttack;
                    txtDescription.Text += "You strike the dragon for " + mainPlayer.playerAttack + " damage!" + Environment.NewLine;
                    
                    return false;
                case 2:
                    txtDescription.Text += "You wave your arms around the arm in a rythmic fashion. You fizzle.... Nothing happens as you now stare down an unimpressed dragon" + Environment.NewLine;
                
                    return false;
                case 3:
                    txtDescription.Text += "You see something in the dragons eyes, and you prepare for the worst" + Environment.NewLine;
                    
                    return true;
            }
            return false;
        }

        //###### CHECK DRAGON HEALTH #########
        bool funcCheckDragonHealth()
        {
            if (mainDragon.dragonHealth <= 0)
            {
                txtDescription.Text += Environment.NewLine;
                txtDescription.Text += "You see the dragon waver, then drop to the ground" + Environment.NewLine;
                
                txtDescription.Text += "You hear one final breath escape the dragon" + Environment.NewLine;
                
                txtDescription.Text += "You've defeated him... It's over... Now go home" + Environment.NewLine;
                
                return true;
            }
            return false;
        }

        //###### DRAGON ACTION & PERFORM #########
        void funcDragonPerform()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 6);
            bool pAction = (playerAction == 3);
            txtDescription.Text += Environment.NewLine;
            switch (randomInt)
            {
                case 1:
                    txtDescription.Text += "The dragon breaths deeply then exhales a might orange flame in your direction." + Environment.NewLine;
                    
                    if (pAction)
                    {
                        txtDescription.Text += "Because you were prepared, you managed to quickly roll out of the way!" + Environment.NewLine;
                        break;
                    }
                    mainPlayer.playerHealth -= mainDragon.dragonFire;
                    txtDescription.Text += "You feel the heat wash over you and you feel your skin crackle. Ouch!" + Environment.NewLine;
                    txtDescription.Text += "The dragon hits you for " + mainDragon.dragonFire + " damage!" + Environment.NewLine;
                    txtHealth.Text = mainPlayer.playerHealth.ToString();
                    break;
                case 2:
                case 3:
                    txtDescription.Text += "The dragon quickly swipes at you with his clawed hand" + Environment.NewLine;
                    
                    if (pAction)
                    {
                        txtDescription.Text += "Because you were prepared, you managed to quickly roll out of the way!" + Environment.NewLine;
                        
                        break;
                    }
                    mainPlayer.playerHealth -= mainDragon.dragonSwipe;
                    txtDescription.Text += "The claws hit you square in the chest, denting your armor and knocking you to the floor" + Environment.NewLine;
                    txtDescription.Text += "The dragon hits you for " + mainDragon.dragonSwipe + " damage!" + Environment.NewLine;
                    txtHealth.Text = mainPlayer.playerHealth.ToString();
                    break;
                case 4:
                case 5:
                    txtDescription.Text += "The dragon roars and lunges at you with it's razor sharp teeth" + Environment.NewLine;
                    
                    if (pAction)
                    {
                        txtDescription.Text += "Because you were prepared, you managed to quickly roll out of the way!" + Environment.NewLine;
                        break;
                    }
                    mainPlayer.playerHealth -= mainDragon.dragonBite;
                    txtDescription.Text += "You feel the teeth penetrate your armor and feel the crush of bone..." + Environment.NewLine;
                    txtDescription.Text += "The dragon hits you for " + mainDragon.dragonBite + " damage!" + Environment.NewLine;
                    txtHealth.Text = mainPlayer.playerHealth.ToString();
                    break;
            }

        }

        //###### CHECK PLAYER HEALTH #########
        bool funcCheckPlayerHealth()
        {
            if (mainPlayer.playerHealth <= 0)
            {
                txtDescription.Text += Environment.NewLine;
                txtDescription.Text += "You feel your life drain away" + Environment.NewLine;
                txtDescription.Text += "Everything starts to go black" + Environment.NewLine;
                txtDescription.Text += "\"NO!\" you think. \"It can't end like this!\". But it does... Goodnight" + Environment.NewLine;
                return true;
            }
            return false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            funcPlayerPerform(1);
            dragonDead = funcCheckDragonHealth();

            //TODO - Move IF Statements to functions
            if (dragonDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnExit.Text = "Leave as a Champion!";
                return;
            }
            funcDragonPerform();
            playerDead = funcCheckPlayerHealth();
            if (playerDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnAttack.Enabled = false;
                btnDodge.Enabled = false;
                btnSpell.Enabled = false;
                btnExit.Text = "Leave as a disgraced ghost...";
                return;
            }
            funcPlayerHealth();
            funcListUserActions();

        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            funcPlayerPerform(2);
            dragonDead = funcCheckDragonHealth();
            if (dragonDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnExit.Text = "Leave as a Champion!";
                return;
            }
            funcDragonPerform();
            playerDead = funcCheckPlayerHealth();
            if (playerDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnAttack.Enabled = false;
                btnDodge.Enabled = false;
                btnSpell.Enabled = false;
                btnExit.Text = "Leave as a disgraced ghost...";
                return;
            }
            funcPlayerHealth();
            funcListUserActions();
        }

        private void btnDodge_Click(object sender, EventArgs e)
        {
            funcPlayerPerform(3);
            dragonDead = funcCheckDragonHealth();
            if (dragonDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnExit.Text = "Leave as a Champion!";
                return;
            }
            funcDragonPerform();
            playerDead = funcCheckPlayerHealth();
            if (playerDead == true)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;
                btnAttack.Enabled = false;
                btnDodge.Enabled = false;
                btnSpell.Enabled = false;
                btnExit.Text = "Leave as a disgraced ghost...";
                return;
            }
            funcPlayerHealth();
            funcListUserActions();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            txtDescription.SelectionStart = txtDescription.Text.Length;
            // scroll it automatically
            txtDescription.ScrollToCaret();
        }
    }
}
