using System;
using System.Collections.Generic;

namespace ProbabilityDistribution
{
    class Statistician : IStatistician
    {
        #region Fields

        private Die die;
        private Dictionary<int, int> results;

        #endregion  

        #region Property

        public IDictionary<int, int> Results { get { return results; } }

        #endregion

        #region Methods

        public void Experiment(int numberOfRolls)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                die.Roll();
                results[die.Value()] = ++results[die.Value()];
            }
        }
        #endregion  

        #region Constructor
        public Statistician()
        {
            die = new Die();
            results = new Dictionary<int, int>();
            for (int i = 1; i < 7; i++)
                results.Add(i, 0);
        }


        #endregion  
    }
}
