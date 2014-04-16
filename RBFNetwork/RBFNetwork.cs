using System;
using System.Collections.Generic;

namespace MultilayerPerceptron
{
	public class RBFNetwork
	{
		private double[,] w;
		private List<double[]> centroids;
		private double[] delta;
		private double[] gValues;
		private readonly double _a;
	    private const double speed = 0.9;

		public RBFNetwork(List<double[]> images)
		{
			delta = new double[images.Count];
            gValues = new double[images.Count];
            w = new double[images.Count, images.Count];
		    centroids = images;
            _a = 0.9;


            var r = new Random();

			for (var i = 0; i < images.Count; i++)
			{
				for (var j = 0; j < images.Count; j++)
				{
					w[i, j] = r.Next(-100, 100) / 100.0;
				}
			}

            TrainedNetwork();
		}

		private void TrainedNetwork()
		{
			ComputingDelta();

			for (var i = 0; i < centroids.Count; i++)
			{
				double[] y;
				var expectedResult = new double[centroids.Count];
				expectedResult[i] = 1.0;

				while (true)
				{
					y = GetNeuralResult(centroids[i]);

					var dlt = GetMaxD(y, expectedResult);

					if (y[i] > 0.95)
					{
						break;
					}

					FeedbackErrorCorrection(y, expectedResult);
				}
			}
		}

		private void ComputingDelta()
		{
			for (var i = 0; i < centroids.Count; i++)
			{
				delta[i] = double.MaxValue;
			}

            for (int i = 0; i < centroids.Count; i++)
			{
                for (int j = 0; j < centroids.Count; j++)
				{
					if (i != j)
					{
					    var dlt = GetEvclidDistance(centroids[i], centroids[j])/2;

						if (dlt < delta[i])
						{
							delta[i] = dlt;
						}
					}
				}
			}

		}

		public double[] GetNeuralResult(double[] source)
		{
			double[] results = new double[gValues.Length];

			for (var i = 0; i < gValues.Length; i++)
			{
				gValues[i] = Math.Exp(-1 * Math.Pow(GetEvclidDistance(source, centroids[i]), 2.0)/ Math.Pow(delta[i], 2.0));
			}

			for (var i = 0; i < results.Length; i++)
			{
				for (var j = 0; j < gValues.Length; j++)
				{
					results[i] += gValues[j] * w[i, j];
				}
			    results[i] = ActivateFunction(results[i]);
			}

			return results;
		}

		private void FeedbackErrorCorrection(double[] y, double[] expectedResult)
		{
			for (int i = 0; i < gValues.Length; i++)
			{
				for (int j = 0; j < y.Length; j++)
				{
					w[i, j] = w[i, j] + gValues[i] * speed * (expectedResult[j] - y[j]);
				}
			}
		}

		private double GetMaxD(double[] ms1, double[] ms2)
		{
			double max = 0;

			for (var i = 0; i < ms1.Length; i++)
			{
				if (Math.Abs(ms1[i] - ms2[i]) > max)
				{
					max = Math.Abs(ms1[i] - ms2[i]);
				}
			}

			return max;
		}

	    private double GetEvclidDistance(double[] vec1, double[] vec2)
	    {
	        double resutl = 0;
	        for (var i = 0; i < vec1.Length; i++)
	        {
	            resutl += Math.Pow(vec1[i] - vec2[i], 2.0);
	        }

	        return Math.Sqrt(resutl);
	    }

        private double ActivateFunction(double argument)
        {
            return 1 / (1 + Math.Exp(-_a * argument));
        }
	}
}
