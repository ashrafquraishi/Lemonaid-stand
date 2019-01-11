using System;
using System.Collections.Generic;

namespace lms1
{
    internal class Day
    {
        internal readonly object Forecast;
        private Random random;
        private List<Player> players;
        private object forecast;
        private int i;

        public Day(Random random, List<Player> players, int i)
        {
            this.random = random;
            this.players = players;
            this.i = i;
        }

        public Day(Random random, List<Player> players, object forecast, int i)
        {
            this.random = random;
            this.players = players;
            this.forecast = forecast;
            this.i = i;
        }

        internal void SetPlayerRecipes(object products)
        {
            throw new NotImplementedException();
        }

        internal void SimulateDay()
        {
            throw new NotImplementedException();
        }
    }
}