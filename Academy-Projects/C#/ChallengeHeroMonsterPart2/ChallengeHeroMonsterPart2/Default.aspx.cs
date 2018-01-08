using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  
            Character Hero = new Character();
            Hero.Name = "Hero";
            Hero.Health = 50;
            Hero.DamageMaxium = 20;
            Hero.AttackBonus = true;
          

            Character Monster = new Character();
            Monster.Name = "Monster";
            Monster.Health = 100;
            Monster.DamageMaxium = 30;
            Monster.AttackBonus = false;

            Dice dice = new Dice();

            Bonus(Hero,Monster,dice);
            

            displayResult(Hero, Monster);


        }
        private void displayResult(Character opponent1, Character opponent2)
        {
            if(opponent1.Health <=0 && opponent2.Health <= 0)
            {
                resultLabel.Text += string.Format("<p>{0} and {1} died!</p>", opponent1.Name, opponent2.Name);
            }
            else if (opponent1.Health <= 0)
            {
                resultLabel.Text += string.Format("<p>{0} defeats {1}!</p>", opponent2.Name, opponent1.Name);
            }
            else if (opponent2.Health <= 0)
            {
                resultLabel.Text += string.Format("<p>{0} defeats {1}!</p>", opponent1.Name, opponent2.Name);
            }
        }

        private void Bonus(Character character1, Character character2, Dice dice)
        {
            if (character1.AttackBonus)
                character2.Defend(character1.Attack(dice));
            if (character2.AttackBonus)
                character1.Defend(character2.Attack(dice));
            while (character1.Health > 0 && character2.Health > 0)
            {
                character2.Defend(character1.Attack(dice));
                character1.Defend(character2.Attack(dice));
                print(character1);
                print(character2);

            }
        }

        
        private void print(Character character)
        {
            resultLabel.Text += string.Format("<p>Name: {0},  Health: {1},  DamageMaxium: {2},  Attack Bonus: {3}</p>",
                character.Name,
                character.Health,
                character.DamageMaxium,
                character.AttackBonus);
        }
    }

     class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaxium { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.sides = this.DamageMaxium;

            return dice.Roll();
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
        public bool Bonus()
        {
            if (this.Health > 0) this.AttackBonus = true;
            else this.AttackBonus = false;
            return this.AttackBonus;
                     
        }
       
    }

     class Dice
    {
        public int sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
           
            random.Next(this.sides);
            return random.Next(this.sides);
        }
    }

}