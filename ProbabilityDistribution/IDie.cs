namespace ProbabilityDistribution
{
	interface IDie
	{
		// Roll the die.
		void Roll();

		// Return the current value of the die.
		int Value();
	}
}