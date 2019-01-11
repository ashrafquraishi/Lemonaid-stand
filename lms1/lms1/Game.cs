using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms1
{
    class Game
    {


        List<Player> players;
        Dictionary<int, double> finalScores;
        List<Day> days;
        int numberOfDaysToPlay;
        Random random;
        Store store;

        public Game()
        {
            days = new List<Day>();
            random = new Random();
            players = new List<Player>();

            numberOfDaysToPlay = 7;
            store = new Store();

        }











        public void RunGame()
        {



            SetupPlayers();

            for (int i = 0; i < numberOfDaysToPlay; i++)
            {
                if (i != 0)
                {
                    days.Add(new Day(random, players, days[i - 1].Forecast, i));
                }
                else
                {
                    days.Add(new Day(random, players, i));
                }
                Shopping.DisplayForecast(days[i].Forecast);
                SendPlayersToStore();
                days[i].SetPlayerRecipes(store.Products);
                days[i].SimulateDay();
            }

            GetFinalScores();
            Shopping.DisplayFinalScores(players, finalScores);

        }

        private void GetFinalScores()
        {
            throw new NotImplementedException();
        }

        private void SendPlayersToStore()
        {
            throw new NotImplementedException();
        }

        private void SetupPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
