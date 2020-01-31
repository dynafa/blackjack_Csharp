using System.Drawing;

namespace GameSetup
{
    class Chip
    {
        private Graphics canvas;
        private int chipValue;
        private string chipColor;

        public Chip(Graphics canvas, string chipColor, int chipValue)
        {
            this.canvas = canvas;
            this.chipColor = chipColor;
            this.chipValue = chipValue;
        }
    }
}