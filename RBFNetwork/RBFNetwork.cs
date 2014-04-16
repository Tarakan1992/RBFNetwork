using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _a = 0.8;
			var r = new Random();

			for (var i = 0; i < k; i++)
			{
				for (var j = 0; j < k; j++)
				{
					w[i,j] = r.Next(-100, 100) / 100.0;
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
                    y = GetNeuralResult(input);

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
            for (int i = 0; i < centroids.Length; i++ )
            {
                for (int j = 0; j < centroids.Length; j++)
                {
                    if (j == 0)
                    {
                        delta[i] = Math.Abs(centroids[i] - centroids[j]);
                        continue;
                    }

                    if (i != j)
                    {
                        var dlt = Math.Abs(centroids[i] - centroids[j]);
 
                        if (dlt < delta[i])
                        {
                            delta[i] = dlt;
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
				a += ms[i];
			}

			return center/a;
		}

		private double[] GetNeuralResult(double[] source)
		{
			double[] results = new double[gValues.Length];

			for (var i = 0; i < gValues.Length; i++)
			{
				double temp = 0;
				for (var j = 0; j < source.Length; j++)
				{
					temp += Math.Pow((source[j] - centroids[i]), 2.0);
				}

				gValues[i] = Math.Exp(-temp/delta[i]);
			}

			for (var i = 0; i < results.Length; i++)
			{
				for (var j = 0; j < results.Length; j++)
				{
					results[i] += gValues[j]*w[i, j];
				}
			}

			return results;
		}

        private void FeedbackErrorCorrection(double[] y, double[] expectedResult)
        {
            for (int i = 0; i < _h; i++)
            {
                for (int j = 0; j < _p; j++)
                {
                    w[i, j] = w[i, j] + Speed * _a * (expectedResult[j] - y[j]);
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
