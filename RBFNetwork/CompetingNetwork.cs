namespace MultilayerPerceptron
{
	public class CompetingNetwork
	{
		private double[,] w;
		private double[2][] y;


		public CompetingNetwork(int numberOfClasses, int size)
		{
			w = new double[size, numberOfClasses];
			y = new double[];
		}

	}
}
