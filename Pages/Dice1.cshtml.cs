using dsd601DiceRolls2020.Operation;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601DiceRolls2020.Pages
{
    public class Dice1Model : PageModel
    {
        [BindProperty]
        public List<string>? Dice { get; set; }

        public void OnGet()
        {  //instantiate the List
            Dice = new List<string>();
        }

        public void OnPost()
        {
            Dice = new List<string>();
            //now the dicerolls are running from their open class
            var list = DiceRollOperations.DiceRoll();
            Dice.AddRange(list);
        }

        private List<string> DiceRoll()
        {
            int Dice1;
            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);

                //Add them to the list
                Dice.Add(Dice1.ToString());

                //while Dice 1 doesn't equal 6
            } while (Dice1 != 6);
            return Dice;
        }
    }
}
