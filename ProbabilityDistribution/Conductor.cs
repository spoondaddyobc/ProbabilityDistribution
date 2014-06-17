namespace ProbabilityDistribution
{
    using System;
    using System.Collections.Generic;

    class Conductor
    {
        // Conduct the experiment and call the private report method to display the results of the experiment.
        public static void Main()
        {
            Statistician test1 = new Statistician();
            test1.Experiment(15);


            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Die Face {0} was rolled {1} times", i, test1.Results[i]);
                Console.ReadKey();
            }


        }
    }
}

        /* TODO: Finish Report Section.
         * 
		// Takes in experiment result data and displays it to the console.
		private static void Report(int totalRolls, Dictionary<int, int> data) 
        {
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i + " =" + data[i]);
                Console.ReadLine();
            }
        
         *
         */