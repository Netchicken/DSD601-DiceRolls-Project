using dsd601DiceRolls2020.Operation;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601DiceRolls2020.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string>? Dice { get; set; }

        public IndexModel()
        {
            Dice = new List<string>();
        }

        public void OnGet()
        {




        }

        public void OnPost()
        {

            // Dice = new List<string>();
            if (Dice.Count > 0)
            {
                Dice.Clear();
            }


            var list = DiceRoll();

            Dice.AddRange(list);
        }

        private List<string> DiceRoll()
        {

            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //Create and set the values of the dice to 0
            int Dice1, Dice2 = 0;


            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);
                Dice2 = myrandom.Next(1, 7);

                //Add them to the listview 
                DiceList.DiceRolls.Add(Dice1 + " " + Dice2);

                //while Dice 1 doesn't equal Dice 2
            } while (Dice1 != Dice2);



            return DiceList.DiceRolls;


        }

    }
}