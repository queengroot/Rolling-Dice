using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kate_Blunt_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //Kate Blunt
            //COP2551
            //Project 4 - Dice Roll

            //Declare variables
            
            int rollOne;
            int rollTwo;

            instructionLabel.Visible = false;

            //Create a random object
            Random rand = new Random();

            //1-6 needs to be generated
            //it is 0-5, but if you add the 1 it becomes 1-6
            rollOne = rand.Next(6) + 1;
            rollTwo = rand.Next(6) + 1;

            //Must also set every other value to false, or the user can not click Roll without clearing because the picture from previous roll will stay true
            //the number rolled displays the corresponding dice picture
            if (rollOne == 1)
            { oneDicePictureBox.Visible = true;

                twoDicePictureBox.Visible = false;
                threeDicePictureBox.Visible = false;
                fourDicePictureBox.Visible = false;
                fiveDicePictureBox.Visible = false;
                sixDicePictureBox.Visible = false;
            }
            else if (rollOne == 2)
            { twoDicePictureBox.Visible = true;

                oneDicePictureBox.Visible = false;
                threeDicePictureBox.Visible = false;
                fourDicePictureBox.Visible = false;
                fiveDicePictureBox.Visible = false;
                sixDicePictureBox.Visible = false;
            }

            else if (rollOne == 3)
            { threeDicePictureBox.Visible = true;

                oneDicePictureBox.Visible = false;
                twoDicePictureBox.Visible = false;
                fourDicePictureBox.Visible = false;
                fiveDicePictureBox.Visible = false;
                sixDicePictureBox.Visible = false;
            }
            else if (rollOne == 4)
            { fourDicePictureBox.Visible = true;

                oneDicePictureBox.Visible = false;
                twoDicePictureBox.Visible = false;
                threeDicePictureBox.Visible = false;
                fiveDicePictureBox.Visible = false;
                sixDicePictureBox.Visible = false;
            }
            else if (rollOne == 5)
            { fiveDicePictureBox.Visible = true;

                oneDicePictureBox.Visible = false;
                twoDicePictureBox.Visible = false;
                threeDicePictureBox.Visible = false;
                fourDicePictureBox.Visible = false;
                sixDicePictureBox.Visible = false;
            }
            else
            { sixDicePictureBox.Visible = true;

                oneDicePictureBox.Visible = false;
                twoDicePictureBox.Visible = false;
                threeDicePictureBox.Visible = false;
                fourDicePictureBox.Visible = false;
                fiveDicePictureBox.Visible = false;
            }

            if (rollTwo == 1)
            {
                oneDiceSecondPictureBox.Visible = true;

                twoDiceSecondPictureBox.Visible = false;
                threeDiceSecondPictureBox.Visible = false;
                fourDiceSecondPictureBox.Visible = false;
                fiveDiceSecondPictureBox.Visible = false;
                sixDiceSecondPictureBox.Visible = false;
            }
            else if (rollTwo == 2)
            {
                twoDiceSecondPictureBox.Visible = true;

                oneDiceSecondPictureBox.Visible = false;
                threeDiceSecondPictureBox.Visible = false;
                fourDiceSecondPictureBox.Visible = false;
                fiveDiceSecondPictureBox.Visible = false;
                sixDiceSecondPictureBox.Visible = false;
            }
            else if (rollTwo == 3)
            {
                threeDiceSecondPictureBox.Visible = true;

                oneDiceSecondPictureBox.Visible = false;
                twoDiceSecondPictureBox.Visible = false;
                fourDiceSecondPictureBox.Visible = false;
                fiveDiceSecondPictureBox.Visible = false;
                sixDiceSecondPictureBox.Visible = false;
            }
            else if (rollTwo == 4)
            {
                fourDiceSecondPictureBox.Visible = true;

                oneDiceSecondPictureBox.Visible = false;
                twoDiceSecondPictureBox.Visible = false;
                threeDiceSecondPictureBox.Visible = false;
                fiveDiceSecondPictureBox.Visible = false;
                sixDiceSecondPictureBox.Visible = false;
            }
            else if (rollTwo == 5)
            {
                fiveDiceSecondPictureBox.Visible = true;

                oneDiceSecondPictureBox.Visible = false;
                twoDiceSecondPictureBox.Visible = false;
                threeDiceSecondPictureBox.Visible = false;
                fourDiceSecondPictureBox.Visible = false;
                sixDiceSecondPictureBox.Visible = false;
            }
            else
            {
                sixDiceSecondPictureBox.Visible = true;

                oneDiceSecondPictureBox.Visible = false;
                twoDiceSecondPictureBox.Visible = false;
                threeDiceSecondPictureBox.Visible = false;
                fourDiceSecondPictureBox.Visible = false;
                fiveDiceSecondPictureBox.Visible = false;
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //sets all picture boxes to false and shows the instructions again
            oneDicePictureBox.Visible = false;
            twoDicePictureBox.Visible = false;
            threeDicePictureBox.Visible = false;
            fourDicePictureBox.Visible = false;
            fiveDicePictureBox.Visible = false;
            sixDicePictureBox.Visible = false;

            oneDiceSecondPictureBox.Visible = false;
            twoDiceSecondPictureBox.Visible = false;
            threeDiceSecondPictureBox.Visible = false;
            fourDiceSecondPictureBox.Visible = false;
            fiveDiceSecondPictureBox.Visible = false;
            sixDiceSecondPictureBox.Visible = false;

            instructionLabel.Visible = true;


            //Basic expectations checklist
            //Image added to the form - y
            //Form text property updated - title changed - y
            //AcceptButton and CancelButton - y 
            //Form and control look professional 
            //Clear button works - y 
            //Exit button works - y
            //A title is on the form describing the application and letting user know what to do - y
            //comments - y
            //Keyboard access keys are defined - y
            //Tab order - y - left to right
            //focus set on first textbox - NA
            //invalid input caught - NA

        }
    }
}
