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
                value = random.Next(1, 6);
            }

            #endregion

            #region Constructior
            public Die()
            {
                Roll();
                Value();
            }
            #endregion  
    }
    }

