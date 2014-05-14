namespace MultilayerPerceptron
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class CompetingNetwork
	{
		private double[,] w;
		private double[][] y;
		private List<double[]> _images;
		private int inputVectorSize;
		private double[][] classesKeys; 

		public CompetingNetwork(List<double[]> images)
		{
			_images = images;
			inputVectorSize = images.First().Length;

			classesKeys = new double[images.Count][];


			w = new double[inputVectorSize, images.Count];
			y = new double[2][];

			for (var i = 0; i < 2; i++)
			{
				y[i] = new double[images.Count];
			}

			for (var i = 0; i < images.Count; i++)
			{
				y[1][i] = 1;
				classesKeys[i] = new double[images.Count];
			}

			var r = new Random();

			for (var j = 0; j < images.Count; j++)
			{
				for (var i = 0; i < inputVectorSize; i++)
				{
					w[i, j] = r.NextDouble() > 0.5 ? 1.0 : 0;
				}
			}
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

		private int Min(double[] vec)
		{
			if (vec == null || vec.Length == 0)
			{
				return -1;
			}

			var min = 0;
			for (var i = 1; i < vec.Length; i++)
			{
				min = vec[i] < vec[min] ? i : min;
			}

			return min;
		}

		private double VectorModule(double[] vector)
		{
			double module = 0;
			for (var i = 0; i < vector.Length; i++)
			{
				module += Math.Pow(vector[i], 2.0);
			}

			return Math.Sqrt(module);
		}

		private double[] VectorSumAndSub(double[] vector1, double[] vector2, int sign)
		{
			if (vector1.Length != vector2.Length)
			{
				throw new Exception("Vector size must be equal!");
			}

			var resutl = new double[vector1.Length];

			for (var i = 0; i < vector1.Length; i++)
			{
				resutl[i] = vector1[i] + vector2[i]*sign;
			}

			return resutl;
		}

		//private int Get
	}
}
