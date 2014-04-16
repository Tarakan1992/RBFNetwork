﻿using System;
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
	}
}
