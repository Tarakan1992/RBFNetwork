using System.Windows.Forms;

namespace MultilayerPerceptron
{
	using System;

	public class Perceptron
	{
		//the next IL - input layer, HL - hidden layer, OL - outputlayer
		private double[,] wHL;
		private double[,] wOL;
		private double[] valuesHL;
		private double[] valuesOL;
		private double[] deltaOL;
		private readonly int _n;
		private readonly int _p;
		private readonly int _h;
		private const double a = 0.8;
		private const double Speed = 5;

		public Perceptron(int n, int p, int h)
		{
			_n = n;
			_p = p;
			_h = h;
			PerceptronInitialization();
		}

		private void PerceptronInitialization()
		{
			wHL = new double[_n, _h];
			wOL = new double[_h, _p];
			valuesHL = new double[_h];
			valuesOL = new double[_p];
			deltaOL = new double[_p];

            var r = new Random();

			//wHL initialization
			for (int i = 0; i < _n; i++)
			{
				for (int j = 0; j < _h; j++)
				{
                    wHL[i, j] = r.Next(-100, 100) / 100.0; 
				}
			}

			//wOL initialization
			for (int i = 0; i < _h; i++)
			{
				for (int j = 0; j < _p; j++)
				{
                    wOL[i, j] = r.Next(-100, 100) / 100.0;
				}
			}
		}

		private double ActivateFunction(double argument)
		{
			return 1 / (1 + Math.Exp(-a * argument));
		}

		private double GenerateInitialValue()
		{
			var r = new Random();
			return r.Next(-100, 100) / 100.0;
		}

		public double[] GetNeuronResult(double[] input)
		{
			if (input.Length != _n)
			{
				throw new Exception("Incorrect input massive size!");
			}

			for (int j = 0; j < _h; j++)
			{
				for (int i = 0; i < _n; i++)
				{
					valuesHL[j] = ActivateFunction(GetSum(input, wHL, j));
				}
			}

			for (int j = 0; j < _p; j++)
			{
				for (int i = 0; i < _h; i++)
				{
					valuesOL[j] = ActivateFunction(GetSum(valuesHL, wOL, j));
				}
			}

			return valuesOL;
		}

		public void TrainedNeural(double[] input, int i)
		{
			double[] y;
			var expectedResult = new double[_p];
			expectedResult[i] = 1.0;

			while (true)
			{
				y = GetNeuronResult(input);

				if (y[i] > 0.95)
				{
					break;
				}

				FeedbackErrorCorrection(y, expectedResult, input);
			}
		}

		private void FeedbackErrorCorrection(double[] y, double[] expectedResult, double[] input)
		{
			CorrectionOutputLayer(y, expectedResult);
			CorrectionHiddenLayer(input);
		}

		private void CorrectionOutputLayer(double[] y, double[] expectedResult)
		{
		    for (int j = 0; j < _p; j++)
		    {
                deltaOL[j] = valuesOL[j] * (1 - valuesOL[j]) * (expectedResult[j] - valuesOL[j]);    
		    }

			for (int i = 0; i < _h; i++)
			{
				for (int j = 0; j < _p; j++)
				{		
					wOL[i, j] = wOL[i, j] + Speed * valuesHL[i] * deltaOL[j];
				}
			}
		}

		private void CorrectionHiddenLayer(double[] input)
		{
			for (int i = 0; i < _n; i++)
			{
				for (int j = 0; j < _h; j++)
				{
					double delta = 0;

                    for (int k = 0; k < _p; k++)
                    {
                        delta += deltaOL[k] * wOL[j, k];
                    }

					delta *= valuesHL[j]*(1 - valuesHL[j]);

					wHL[i, j] = wHL[i, j] + Speed * delta * input[i];
				}
			}
		}

		private double GetSum(double[] x, double[,] matrix, int j)
		{
			double sum = 0;

			for (int i = 0; i < x.Length; i++)
			{
				sum += matrix[i, j] * x[i];
			}

			return sum;
		}
	}
}
