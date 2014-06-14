namespace ProbabilityDistribution
{
	using System.Collections.Generic;

	interface IStatistician
	{
		// Roll a die and record the resulting value.
		void Experiment(int numberOfRolls);

		// Return the results in a dictionary object. <DieValue, NumberOfInstances>
		IDictionary<int, int> Results { get; }
	}
}