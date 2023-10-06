using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal class Engine
    {
        private int _squareSize { get; set; }
        private int _width, _height;
        private Color _squareColor { get; set; }
        private Color _backgrounColor { get; set; }

        private bool[,] _matrix;

        public Engine(PictureBox pictureBox, int squareSize)
        {
            _squareSize = squareSize;
            _width = pictureBox.Width / squareSize;
            _height = pictureBox.Height / squareSize;
            Generate();
        }

        public void Start()
        {

        }

        public void Generate()
        {
            Random random = new Random(Convert.ToInt32(DateTime.UtcNow.ToFileTimeUtc()));
            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    _matrix[i, j] = random.Next(0, 100) > 30;
        }

        public void Stop()
        {

        }


        private void NextStep()
        {
            
        }
    }
}
