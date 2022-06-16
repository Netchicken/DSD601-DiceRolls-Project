using dsd601DiceRolls2020.Operation;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601DiceRolls2020.Pages
{
    public class Dice3Model : PageModel
    {
        [BindProperty]
        public List<string>? Dice { get; set; }

        public Dice3Model()
        {
            //instantiate the List
            Dice = new List<string>();
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Dice = new List<string>();

            //now the dicerolls are running from their open class
            var list = DiceRollOperations.DiceRoll3();

            Dice.AddRange(list);
        }

        private List<string> DiceRoll()
        {

            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //We need a boolean,(True, False) to tell us when the values match
            bool RollDiceAgain = true;



            //Create and set the values of the 2 dice 
            int Dice1;
            int Dice2;
            int Dice3;
            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);
                Dice2 = myrandom.Next(1, 7);
                Dice3 = myrandom.Next(1, 7);

                //Add them to the list
                Dice.Add(Dice1 + " " + Dice2 + " " + Dice3);

                //if you just use while ((Dice1 != Dice2) && (Dice1 != Dice3) && (Dice2 != Dice3)
                //we seem to get it stopped on 1 pair.

                //while Dice 1 doesn't equal Dice 2
                if ((Dice1 == Dice2) && (Dice2 == Dice3))
                { RollDiceAgain = false; }
            } while (RollDiceAgain == true);




            return Dice;


        }

    }
}