using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601DiceRolls2020.Pages
{
    public class Dice1Model : PageModel
    {
        [BindProperty]
        public List<string>? Dice { get; set; }
        
        //Define a random generator that uses milliseconds as the seed 
        private Random myrandom;

        public Dice1Model()
        {
            //instantiate the List
            Dice = new List<string>();
            myrandom = new(DateTime.Now.Millisecond);
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Dice = new List<string>();

            var list = DiceRoll();

            Dice.AddRange(list);
        }

        private List<string> DiceRoll()
        {
            int Dice1;


            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);

                //Add them to the list
                Dice.Add(Dice1.ToString());

                //while Dice 1 doesn't equal Dice 2
            } while (Dice1 != 6);



            return Dice;


        }

    }
}
