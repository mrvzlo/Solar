using System;
using System.Collections.Generic;
using System.Drawing;

namespace Solar
{
    public class Logic
    {
        private const int PixPerMax = 200;
        public List<SpaceObj> Create()
        {
            var spaceObjs = new List<SpaceObj>();
            var sun = new SpaceObj
            {
                Name = "Sun",
                Color = Color.Yellow,
                Step = 0,
                Radius = 25,
                Distance = 0,
                Dir = 0,
            };
            var earth = new SpaceObj
            {
                Name = "Earth",
                Color = Color.SkyBlue,
                Step = DaysOfYearToStep(364),
                Radius = 16,
                Distance = 37,
                Parent = sun
            };
            var venus = new SpaceObj
            {
                Name = "Venus",
                Color = Color.Moccasin,
                Step = DaysOfYearToStep(234),
                Radius = 16,
                Distance = 25,
                Parent = sun
            };
            var mercury = new SpaceObj
            {
                Name = "Mercury",
                Color = Color.Gray,
                Step = DaysOfYearToStep(91),
                Radius = 8,
                Distance = 13,
                Parent = sun
            };
            var moon = new SpaceObj
            {
                Name = "Moon",
                Color = Color.Gray,
                Step = DaysOfYearToStep(26),
                Radius = 4,
                Distance = 6,
                Parent = earth
            };
            var mars = new SpaceObj
            {
                Name = "Mars",
                Color = Color.OrangeRed,
                Step = DaysOfYearToStep(364*2),
                Radius = 13,
                Distance = 55,
                Parent = sun
            };
            var fobos = new SpaceObj
            {
                Name = "Fobos",
                Color = Color.Gray,
                Step = DaysOfYearToStep(13),
                Radius = 4,
                Distance = 4,
                Parent = mars
            };
            var demos = new SpaceObj
            {
                Name = "Demos",
                Color = Color.Gray,
                Step = DaysOfYearToStep(52),
                Radius = 3,
                Distance = 6,
                Parent = mars,
                StartDegree = Math.PI*3/2,
                Degree = Math.PI * 3 / 2
            };
            var jupiter = new SpaceObj
            {
                Name = "Jupiter",
                Color = Color.PeachPuff,
                Step = DaysOfYearToStep(364*3),
                Radius = 30,
                Distance = 90,
                Parent = sun
            };
            spaceObjs.Add(sun);
            spaceObjs.Add(mercury);
            spaceObjs.Add(venus);
            spaceObjs.Add(earth);
            spaceObjs.Add(mars);
            spaceObjs.Add(moon);
            spaceObjs.Add(fobos);
            spaceObjs.Add(demos);
            spaceObjs.Add(jupiter);
            return spaceObjs;
        }

        public void ToStartAll(List<SpaceObj> objs)
        {
            foreach (var t in objs) t.ToStart();
        }

        public void MoveAll(List<SpaceObj> objs, double speedup)
        {
            foreach (var t in objs) t.Move(speedup);
        }

        public int GetDegree(SpaceObj obj) => RadToDeg(obj.Degree);

        public Point GetPoint(SpaceObj obj, int max) => new Point( GetX(obj, max), GetY(obj, max));

        public Point GetPointBetween(SpaceObj a, SpaceObj b, int max) => 
            new Point((GetX(a, max) + GetX(b,max)) / 2, (GetY(a,max) + GetY(b,max)) / 2);

        public Rectangle GetOrbit(SpaceObj obj, int max)
        {
            var center = obj.Parent == null ? new Point(max / 2, max / 2) : GetPoint(obj.Parent, max);
            var radius = obj.Distance * max / PixPerMax;
            return new Rectangle(center.X - radius, center.Y - radius, radius*2, radius*2);
        }

        public Rectangle GetObjectView(SpaceObj obj, int max)
        {
            var radius = Convert.ToInt32(obj.Radius);
            var center = GetPoint(obj, max);
            center.X -= radius;
            center.Y -= radius;
            return new Rectangle(center, new Size(radius*2, radius*2));
        }

        private int RadToDeg(double rad) => Convert.ToInt32(rad * 180 / Math.PI);

        private double DaysOfYearToStep(double daysOfYear) => Math.Abs(daysOfYear) < 0.001 ? 0 : 2 * Math.PI / daysOfYear;

        private int GetX(SpaceObj obj, int max)
        {
            var x = obj.Parent == null ? max / 2.0 : GetX(obj.Parent, max);
            return Convert.ToInt32(x + obj.Distance * Math.Cos(obj.Degree) * obj.Dir * max / PixPerMax);
        }

        private int GetY(SpaceObj obj, int max)
        {
            var y = obj.Parent == null ? max / 2.0 : GetY(obj.Parent, max);
            return Convert.ToInt32(y - obj.Distance * Math.Sin(obj.Degree) * obj.Dir * max / PixPerMax);
        }
    }
}
