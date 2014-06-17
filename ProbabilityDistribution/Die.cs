using System;


namespace ProbabilityDistribution
{
    class Die : IDie
    {
        #region Properties
        private int value;
        private Random random;
        #endregion

        #region Methods

        public int Value()
            {
                    return value;
            }

        public void Roll()
            {
                value = random.Next(1, 7);
            }

            #endregion

            #region Constructior
            public Die()
            {
                random = new Random();
                Roll();
            }
            #endregion  
    }
    }

