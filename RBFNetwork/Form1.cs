using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MultilayerPerceptron
{
	using System.Configuration;
	using System.Linq;

	public partial class Form1 : Form
	{
		private Bitmap originalImage;
		private Dictionary<string, Bitmap> _originalImages;
        private RBFNetwork _rbfNetwork;
	    private readonly Dictionary<string, int> _imageClassDictionary; 

		public Form1()
		{
			InitializeComponent();
			
			_originalImages = new Dictionary<string, Bitmap>();
            _imageClassDictionary = new Dictionary<string, int>();
			ImageInitialization();
			InitializationPicturesPanel();
            var mapper = new ImageMapper();

            var trainedList = new List<double[]>();

            foreach (var image in _originalImages)
            {
                trainedList.Add(mapper.ToDouble(image.Value));                
            }

            _rbfNetwork = new RBFNetwork(trainedList);
  		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonGenerateNoise_Click(object sender, EventArgs e)
		{
			var appSetting = ConfigurationManager.AppSettings;
			var key = appSetting[comboBoxLetter.SelectedItem.ToString()];
			int percentOfNoise;
			int.TryParse(comboBoxPercentOfNoise.SelectedItem.ToString(), out percentOfNoise);
			originalImage = new Bitmap(_originalImages[key]);

			pictureBoxOriginal.Image = NoiseGenerator.MakeNoisy(originalImage, percentOfNoise);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			originalImage = new Bitmap(_originalImages[ConfigurationManager.AppSettings[comboBoxLetter.SelectedItem.ToString()]]);
			pictureBoxOriginal.Image = originalImage;

            labelK.Text = "";
            labelL.Text = "";
            labelM.Text = "";
            labelN.Text = "";
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLetter.SelectedIndex != 0 && comboBoxPercentOfNoise.SelectedIndex != 0)
			{
				buttonGenerateNoise.Enabled = true;
			}
            labelK.Text = "";
            labelL.Text = "";
            labelM.Text = "";
            labelN.Text = "";
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
		    var result = _rbfNetwork.GetNeuralResult(new ImageMapper().ToDouble(originalImage));

            labelK.Text = Math.Round(result[0], 4).ToString();
            labelL.Text = Math.Round(result[1], 4).ToString();
            labelM.Text = Math.Round(result[2], 4).ToString();
            labelN.Text = Math.Round(result[3], 4).ToString();

		}

		private void ImageInitialization()
		{
			var appSettings = ConfigurationManager.AppSettings;
		    int classIndex = 0;
			foreach (var letter in comboBoxLetter.Items)
			{
				var key = appSettings[letter.ToString()];
				_originalImages[key] = new Bitmap("../../Content/" + key + ".png");

                _imageClassDictionary.Add(key, classIndex++);
			}
		}

	    private void InitializationPicturesPanel()
	    {
	        pictureBoxK.Image = _originalImages["K"];
            pictureBoxL.Image = _originalImages["L"];
            pictureBoxM.Image = _originalImages["M"];
            pictureBoxN.Image = _originalImages["N"];
	    }

	    private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
