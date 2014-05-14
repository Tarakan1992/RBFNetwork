﻿namespace MultilayerPerceptron
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

		public CompetingNetwork(List<double[]> images)
		{
			_images = images;
			inputVectorSize = images.First().Length;

			w = new double[inputVectorSize, images.Count];
			y = new double[2][];

			for (var i = 0; i < 2; i++)
			{
				y[i] = new double[images.Count];
			}

			for (var i = 0; i < images.Count; i++)
			{
				y[1][i] = 1;
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

	}
}
