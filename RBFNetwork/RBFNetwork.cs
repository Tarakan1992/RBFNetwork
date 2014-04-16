using System;
using System.Collections.Generic;

namespace MultilayerPerceptron
{
	public class RBFNetwork
	{
		private double[,] w;
		private double[] centroids;
		private double[] delta;
		private double[] gValues;
		private readonly double _a;

		public RBFNetwork(int k)
		{
			centroids = new double[k];
			delta = new double[k];
			gValues = new double[k];
			w = new double[k, k];
			_a = 0.4;
			var r = new Random();

			for (var i = 0; i < k; i++)
			{
				for (var j = 0; j < k; j++)
				{
					w[i, j] = r.Next(-100, 100) / 100.0;
				}
			}
		}

		public void TrainedNetwork(List<double[]> images)
		{
			for (var i = 0; i < centroids.Length; i++)
			{
				centroids[i] = ComputedCenterOfMass(images[i]);
			}

			ComputingDelta();

			for (var i = 0; i < images.Count; i++)
			{
				double[] y;
				var expectedResult = new double[images.Count];
				expectedResult[i] = 1.0;

				while (true)
				{
					y = GetNeuralResult(images[i]);

					var dlt = GetMaxD(y, expectedResult);

					if (dlt < 0.05)
					{
						break;
					}

					FeedbackErrorCorrection(y, expectedResult);
				}
			}
		}

		private void ComputingDelta()
		{
			for (var i = 0; i < centroids.Length; i++)
			{
				delta[i] = double.MaxValue;
			}

			for (int i = 0; i < centroids.Length; i++)
			{
				for (int j = 0; j < centroids.Length; j++)
				{
					if (i != j)
					{
						var dlt = Math.Abs(centroids[i] - centroids[j]);

						if (dlt < delta[i] * 2)
						{
							delta[i] = dlt/2;
						}
					}
				}
			}

		}

		private double ComputedCenterOfMass(double[] ms)
		{
			double center = 0;
			double a = 0;

			for (var i = 0; i < ms.Length; i++)
			{
				center += i*ms[i];
			}

			return center / ms.Length;
		}

		public double[] GetNeuralResult(double[] source)
		{
			double[] results = new double[gValues.Length];
			var center = ComputedCenterOfMass(source);

			for (var i = 0; i < gValues.Length; i++)
			{
				gValues[i] = Math.Exp(-(center - centroids[i])/ Math.Pow(delta[i], 2.0));
			}

			for (var i = 0; i < results.Length; i++)
			{
				for (var j = 0; j < gValues.Length; j++)
				{
					results[i] += gValues[j] * w[i, j];
				}
			}

			return results;
		}

		private void FeedbackErrorCorrection(double[] y, double[] expectedResult)
		{
			for (int i = 0; i < gValues.Length; i++)
			{
				for (int j = 0; j < y.Length; j++)
				{
					w[i, j] = w[i, j] + gValues[i] * _a * (expectedResult[j] - y[j]);
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
	}
}
