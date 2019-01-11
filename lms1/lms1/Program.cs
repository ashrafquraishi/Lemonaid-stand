using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Instructions = "Lemonade Stand instructions:\n";
            Instructions = Instructions + " it is multi player game\n";
            Instructions = Instructions + " The basic objective of this game is to buy the materials needed to make lemonade, and then sell it to customers as they walk by during the day. \n";
            Instructions = Instructions + "You are to manage the whole lemonade stand business. \n";
            Instructions = Instructions + "Your job is to first buy the materials such as cups, lemons, cups of sugar and ice. \n";
            Instructions = Instructions + "Secondly, you will need to set the cost per cup of lemonade and the number of lemons, cups of sugar, and ice that will be needed per cup of lemonade..\n";
            Instructions = Instructions + " Then you start the game and people will start to come.  \n";
            Instructions = Instructions + " Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.\n";
            Instructions = Instructions + "These are changes you might want to consider for the next day of selling your lemonade.\n";
            Instructions = Instructions + "This is just the basic summary of the game; but now lets go in-depth a bit more on each step.\n\n";


            Console.WriteLine(Instructions);
            Game game = new Game();
            do
            {
                game.RunGame();
            }
            while (Shopping.GetInput("Would you like to play again? <yes/no>", "yes/no") == "yes");
        }
    }
    }

