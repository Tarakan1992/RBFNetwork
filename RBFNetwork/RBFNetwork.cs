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

		public RBFNetwork(int k)
		{
			centroids = new double[k];
			delta = new double[k];
			gValues = new double[k];
			w = new double[k, k];

			var r = new Random();

			for (var i = 0; i < k; i++)
			{
				for (var j = 0; j < k; j++)
				{
					w[i,j] = r.Next(-100, 100) / 100.0;
				}
			}
		}

		public void SetRBFLayer(List<double[]> images)
		{
			
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
	}
}
