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
	    private CompetingNetwork _competingNetwork;
	    private readonly Dictionary<int, string> _imageClassDictionary; 
        

		public Form1()
		{
			InitializeComponent();
			
			_originalImages = new Dictionary<string, Bitmap>();
            _imageClassDictionary = new Dictionary<int, string>();
			ImageInitialization();
			InitializationPicturesPanel();
            var mapper = new ImageMapper();

            var trainedList = new List<double[]>();

            foreach (var image in _originalImages)
            {
                trainedList.Add(mapper.ToDouble(image.Value));                
            }

            _competingNetwork = new CompetingNetwork(trainedList);
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
		    pictureBoxResult.Image = null;

		    if (comboBoxPercentOfNoise.SelectedIndex < 0)
		    {
		        comboBoxPercentOfNoise.SelectedIndex = 0;
		    }

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLetter.SelectedIndex != 0 && comboBoxPercentOfNoise.SelectedIndex != 0)
			{
				buttonGenerateNoise.Enabled = true;
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
		    var result = _competingNetwork.GetResult(new ImageMapper().ToDouble(originalImage));

		    pictureBoxResult.Image = _originalImages[_imageClassDictionary[result]];

		}

		private void ImageInitialization()
		{
			var appSettings = ConfigurationManager.AppSettings;
		    int classIndex = 0;
			foreach (var letter in comboBoxLetter.Items)
			{
				var key = appSettings[letter.ToString()];
				_originalImages[key] = new Bitmap("../../Content/" + key + ".png");

                _imageClassDictionary.Add(classIndex++, key);
			}
		}

	    private void InitializationPicturesPanel()
	    {
	    }

	    private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
