using System.Net;

namespace MultilayerPerceptron
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class CompetingNetwork
	{
		private double[][] w;
		private double[] y;
		private List<double[]> _images;
		private int inputVectorSize;
		private double[][] classesKeys;
	    private double _speed = 2;

		public CompetingNetwork(List<double[]> images)
		{
			_images = images;
			inputVectorSize = images.First().Length;

			classesKeys = new double[images.Count][];

		    w = new double[images.Count][];
		    for (var i = 0; i < w.Length; i++)
		    {
		        w[i] = new double[inputVectorSize];
		    }

		    y = new double[images.Count];                                //y[0] - value, v[1] - winnings count

			for (var i = 0; i < images.Count; i++)
			{
				y[i] = 1;
				classesKeys[i] = new double[images.Count];
			}

			var r = new Random();

			for (var j = 0; j < images.Count; j++)
			{
				for (var i = 0; i < inputVectorSize; i++)
				{
					w[j][i] = r.NextDouble() > 0.5 ? 1.0 : 0;
				}
			}
            TrainingNetwork();
		}

	    private void TrainingNetwork()
	    {
            
	        for (var i = 0; i < _images.Count; i++)
	        {
	            while (true)
	            {
	                var winner = new double[_images.Count];
	                for (var j = 0; j < winner.Length; j++)
	                {
	                    winner[j] = y[j]*VectorModule(VectorSumAndSub(_images[i], w[i], -1));
	                }

	                var winnerIndex = Min(winner);

	                y[winnerIndex]++;

	                CorrectNeuralWeight(winnerIndex);

	                if (GetEvclidDistance(_images[i], w[winnerIndex]) < 0.2)
                        break;
	            }

	            classesKeys[i] = GetNeuralResult(_images[i]);
	        }
	    }

	    private void CorrectNeuralWeight(int winner)
	    {
	        var temp = VectorSumAndSub(_images[winner], w[winner], -1);
	        for (int i = 0; i < temp.Length; i++)
	        {
	            temp[i] *= _speed;
	        }

	        var denominator = VectorModule(VectorSumAndSub(w[winner], temp, 1));

	        for (var i = 0; i < inputVectorSize; i++)
	        {
	            w[winner][i] = w[winner][i] + _speed*(_images[winner][i] - w[winner][i])/denominator;
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

		public int GetResult(double[] input)
		{
			var result = GetNeuralResult(input);

			var evclidDistances = new double[classesKeys.Length];
			for (var i = 0; i < classesKeys.Length; i++)
			{
				evclidDistances[i] = GetEvclidDistance(classesKeys[i], result);
			}

			return Min(evclidDistances);
		}

		private double[] GetNeuralResult(double[] input)
		{
			var result = new double[_images.Count];

			for (var j = 0; j < _images.Count; j++)
			{
				double temp = 0;
				for (var i = 0; i < inputVectorSize; i++)
				{
					temp += input[i]*w[j][i];
				}

				result[j] = temp;
			}

			return result;
		}
	}
}
