using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithString_35
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1.
            /* string name = "Mary Liu";


             for (int i = name.Length-1; i>= 0; i--) 
             {
                 resultLabel.Text += name[i];
             }*/


            //2.
            /* string names = "Luke,Leia,Han,Chewbacca";
             string[] reverse = names.Split(',');
             string result = "";
             for (int i = reverse.Length-1 ;i >= 0; i--)
             { if (i > 0)
                 result += reverse[i] + ",";
                 if (i == 0)
                     result += reverse[i];   // result = result.Remove(reverse.Length-1,1);

             }
             resultLabel.Text = result;*/

            //3.
            /* string names = "Luke,Leia,Han,Chewbacca";
             string[] newOrder = names.Split(',');
             string result = "";
             for (int i = 0; i < newOrder.Length; i++)
             {
                int padLeft = (14 - newOrder[i].Length) / 2;
               string temp = newOrder[i].PadLeft(newOrder[i].Length + padLeft, '*');

                result += temp.PadRight(14, '*');
                result += "<br />";
             }
             resultLabel.Text = result;*/

            //4.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO ZHE AID OF ZHE COUNTRY.";
              string result = puzzle.Replace('Z', 'T');
          int index = result.IndexOf("remove-me");
          result = result.Remove(index, 9);
          result = result.ToLower();
          //result = result.Replace("now", "Now");
            result = result.Remove(0, 1);
           result = result.Insert(0, "N");

          resultLabel.Text = result;
           // resultLabel.Text = puzzle.ToLower().Remove(10, 9).Replace('z', 't').Replace("now", "Now");

        }
    }
}