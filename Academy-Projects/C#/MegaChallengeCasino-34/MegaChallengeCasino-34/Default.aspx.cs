using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino_34
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                diaplayImage(reels);
                ViewState.Add("PlayersMoney", 100);
                
                displayPlayersMoney();

            }
        }


        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                betTextBox.Text = "5";
            }

            if (RadioButton2.Checked)
            {
                betTextBox.Text = "10";
            }
            if (RadioButton3.Checked)
            {
                betTextBox.Text = "15";
            }
            if (RadioButton4.Checked)
            {
                betTextBox.Text = "20";
            }
        }
        protected void pullButton_Click(object sender, EventArgs e)
        {
            int bet = int.Parse(betTextBox.Text);
            int winnings = pullLever(bet);
            displayResult(bet,winnings);
            calculatePlayersMoney(bet, winnings);
            displayPlayersMoney();
            

        }
        private void calculatePlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
            if (playersMoney <= 0)
            {
                resultLabel.Text = "Sorry! You need more money to play!";
                 }
        }


            private int pullLever(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
           
           diaplayImage(reels);
            int multiplier = evaluateImage(reels);
            return bet * multiplier;
           
        }

        private int evaluateImage(string[] reels)
        {
            if (isBar(reels)) return 0;
            if (isSeven(reels)) return 100;
            int multiplier = 0;
            if (isWinner(reels, out multiplier)) return multiplier;

            return 0;

        }

        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
          
            if (multiplier > 0) return true;
            else
                return false;
        }

        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
           if ( cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 1) return 4;

            return 0;
 }
        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return cherryCount;
        }

        private bool isSeven(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven") return true;
            else
                return false;
        }

        private bool isBar(string []reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar") 
            return true;
            else
            return false;
        }

       
        private string spinReel(){
         string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermellon" };
       
            return images[random.Next(11)];
        
    }
        
        
        private void diaplayImage(string[] reels)
        {
            Image1.ImageUrl = "/images/" + reels[0] + ".png";
            Image2.ImageUrl = "/images/" + reels[1] + ".png";
            Image3.ImageUrl = "/images/" + reels[2] + ".png";
        }
        private void displayResult(int bet, int winnings)
        {
           
            if (winnings > 0)
            {

                resultLabel.Text = string.Format("You bet {0:C} and you won {1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = string.Format("Sorry! You lost {0:C}, Better luck next time!", bet);
            }
        }
        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
            
        }

    
    }
}