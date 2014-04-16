using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class ImageMapper
    {
        public virtual double[] ToDouble(Bitmap image)
        {
            var result = new double[image.Height * image.Width];

            for (int x = 0; x < image.Height; x++)
            {
                for (int y = 0; y < image.Width; y++)
                {
                    result[x*image.Height + y] = ActivationFunction(image.GetPixel(x, y));
                }
            }

            return result;
        }

        public virtual double ActivationFunction(Color pixel)
        {
			if (pixel.B > 127 && pixel.R > 127 && pixel.G > 127)
			{
				return 1;
			}

			return 0;
		}
        
    }
}
