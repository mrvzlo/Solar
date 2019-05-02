using System;
using System.Drawing;

namespace Solar
{
	public class SpaceObj
	{
        public SpaceObj Parent { get; set; }
        public Color Color { get; set; }
        public double Degree { get; set; }
        public double Radius { get; set; }
        public bool Draw { get; set; }
        public int Distance { get; set; }
        public int Dir { get; set; }
        public int Round { get; set; }
        public string Name { get; set; }
        public double Step { get; set; }

        public SpaceObj()
        {
            Draw = true;
            Parent = null;
            Dir = 1;
            Degree = Math.PI/2;
        }

        public void Move(double speedUp)
        {
            Degree += Step * Dir * speedUp;
            while (Degree >= Math.PI * 2)
            {
                Round++;
                Degree -= Math.PI * 2;
            }
            while (Degree < 0)
            {
                Round--;
                Degree += Math.PI * 2;
            }
        }
        public void ToStart() => Degree = Math.PI/2;
    }
}
