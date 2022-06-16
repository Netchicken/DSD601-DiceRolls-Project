namespace dsd601DiceRolls2020.Operation
{
    public static class DiceRollOperations
    {
        public static List<string> DiceRoll()
        {
            int Dice1;
            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //make a list just for here
            var Dice = new List<string>();

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

        public static List<string> DiceRoll2()
        {
            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //make a list just for here
            var Dice = new List<string>();

            //Create and set the values of the 2 dice 
            int Dice1;
            int Dice2;

            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);
                Dice2 = myrandom.Next(1, 7);

                //Add them to the list
                Dice.Add(Dice1 + " " + Dice2);

                //while Dice 1 doesn't equal Dice 2
            } while (Dice1 != Dice2);
            return Dice;
        }

        public static List<string> DiceRoll3()
        {
            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //We need a boolean,(True, False) to tell us when the values match
            bool RollDiceAgain = true;

            //make a list just for here
            var Dice = new List<string>();

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
