using System.Drawing;

namespace GameSetup
{
    class Chipstack
    {
        Chip[] chips = new Chip[100];
        private int stacksize;
        private Graphics canvas;
        private string chipcolor;
        private int chipvalue;
        private int chipgoal;
        private int chipcounter = 0;
        private int betstackcount = 0;

        public Chipstack(Graphics canvas, string chipcolor, int stacksize, int chipvalue, int chipgoal)
        {
            this.stacksize = stacksize;
            this.canvas = canvas;
            this.chipcolor = chipcolor;
            this.chipvalue = chipvalue;
            this.chipgoal = chipgoal;
            Chip[] chips = new Chip[stacksize];
            for (int stacks = 0; stacks < stacksize; stacks++)
            {
                chips[stacks] = new Chip(canvas, chipcolor, chipvalue);
            }
        }

        public int showStackvalue()
        {
            int stackvalue = stacksize * chipvalue;
            return stacksize;
        }

        public string getChipcolor()
        {
            return chipcolor;
        }
        public int getChipgoal()
        {
            return chipgoal;
        }
    }
}