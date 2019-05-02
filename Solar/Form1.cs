using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
// ReSharper disable LocalizableElement

namespace Solar
{
	public partial class Form1 : Form
    {
        private const int Year = 364;
        private const int PictureSize = 1000;
        private List<SpaceObj> SpaceObjs { get; set; }
        private Logic Core { get; }
        private int TieType { get; set; }
        private double SpeedUp { get; set; }
        private double Day { get; set; }
        private bool ShowOrbits { get; set; }
        private Label[] Info { get; set; }
        private Bitmap PlanetsImg { get; set; }
        private Bitmap TrajectoryImg { get; set; }
        private Bitmap TieImg { get; set; }
        private Bitmap OrbitsImg { get; set; }
        private int _p1, _p2;
        private Point? TempPoint {get; set;}

		public Form1()
        {
            Day = 0;
            TieType = 0;
            Core = new Logic();
            SpaceObjs = Core.Create();
            TempPoint = null;
            InitImages();
            InitializeComponent();
            CreateInfo();
            SpeedUp = Convert.ToDouble(speedometr.Value);
            speedometr.Maximum = 100;
            for (var i = 0; i < SpaceObjs.Count; i++)
			{
				list1.Items.Add(SpaceObjs[i].Name);
				list2.Items.Add(SpaceObjs[i].Name);
				listbox.Items.Add(SpaceObjs[i].Name);
				listbox.SetItemChecked(i,true);
			}
			list1.SelectedIndex = 0;
			list2.SelectedIndex = 0;
            DrawOrbitAndPlanets(true);
        }

        private void InitImages()
        {
            ShowOrbits = true;
            TieImg = new Bitmap(PictureSize, PictureSize);
            OrbitsImg = new Bitmap(PictureSize, PictureSize);
            PlanetsImg = new Bitmap(PictureSize, PictureSize);
            TrajectoryImg = new Bitmap(PictureSize, PictureSize);
        }

		private void CreateInfo()
		{
            Info = new Label[SpaceObjs.Count + 2];
			for (var i = 0; i < Info.Length; i++)
			{
                Info[i] = new Label
                {
                    AutoSize = false,
                    Width = 150,
                    Height = 25,
                    BackColor = Color.Black,
                    ForeColor = Color.White
                };
                var p = new Point();
				Info[i].Font = list1.Font;
				Info[i].Anchor = Reverse.Anchor;
				Info[i].Margin = new Padding(0,5,0,5);
				if (i == 0) p.Y = Reverse.Location.Y + Reverse.Height;
				else p.Y = Info[i - 1].Height + Info[i - 1].Top;
				p.X = picturePlanets.Width + picturePlanets.Left;
				Info[i].Location = p;
				Controls.Add(Info[i]);
			}
			Info[0].Text = "Degree:";
		}
        
        private void Statistics()
		{
			var i = 1;
			for (; i < SpaceObjs.Count; i++) Info[i].Text = SpaceObjs[i].Name + " " + Core.GetDegree(SpaceObjs[i]) + "°";
            Day %= Year*1000;
			Info[i].Text = "Day: " + Day % Year;
			Info[i+1].Text = "Year: " +Math.Floor(Day/ Year);
		}

		private void DrawOrbitAndPlanets(bool reload)
        {
            var gOrb = Graphics.FromImage(OrbitsImg);
            var gObj = Graphics.FromImage(PlanetsImg);
            if (ShowOrbits) gOrb.Clear(Color.Transparent);
            gObj.Clear(Color.Transparent);

            foreach (var obj in SpaceObjs)
            {
                if (!obj.Draw) continue;
                DrawCircle(Core.GetObjectView(obj,PictureSize), obj.Color, gObj);
                if (ShowOrbits)
                    DrawEllipse(Core.GetOrbit(obj, PictureSize), obj.Color, gOrb);
            }
			Statistics();
            if (reload) CombineLayers();
        }

        #region Draw
        
        private void DrawTiePoint(SpaceObj a, SpaceObj b)
        {
            var p = Core.GetPointBetween(a, b, PictureSize);
            var g = Graphics.FromImage(TrajectoryImg);
            if (TempPoint == null) TempPoint = p;
            else
            {
                DrawLine(p, TempPoint.Value, Color.White, g);
                TempPoint = p;
            }
			g.FillRectangle(new SolidBrush(Color.White), p.X, p.Y, 1, 1);
		}

        private void DrawLine(Point p1, Point p2, Color col, Graphics g) => g.DrawLine(new Pen(col), p1, p2);

        private void DrawEllipse(Rectangle rectangle, Color col, Graphics g) => g.DrawEllipse(new Pen(col), rectangle);

        private void DrawCircle(Rectangle rectangle, Color col, Graphics g) => g.FillEllipse(new SolidBrush(col), rectangle);

        #endregion

        private void Tick(double speedUp)
        {
            Day += speedUp;
            Core.MoveAll(SpaceObjs, speedUp);
            DrawOrbitAndPlanets(false);
            if (Finish()) Toggle();
            if (SpaceObjs[_p1].Parent != null || SpaceObjs[_p2].Parent != null)
            {
                var g = Graphics.FromImage(TieImg);
                g.Clear(Color.Transparent);
                DrawLine(Core.GetPoint(SpaceObjs[_p1], PictureSize), Core.GetPoint(SpaceObjs[_p2], PictureSize), Color.White, g);
                DrawTiePoint(SpaceObjs[_p1], SpaceObjs[_p2]);
            }
            CombineLayers();
        }

        private void CombineLayers()
        {
            var final = new Bitmap(PictureSize, PictureSize);
            using (var g = Graphics.FromImage(final))
            {
                g.Clear(Color.Black);
                g.DrawImage(PlanetsImg, new Rectangle(0, 0, PictureSize, PictureSize));
                g.DrawImage(TrajectoryImg, new Rectangle(0, 0, PictureSize, PictureSize));
                if (timer1.Enabled) g.DrawImage(TieImg, new Rectangle(0, 0, PictureSize, PictureSize));
                if (ShowOrbits) g.DrawImage(OrbitsImg, new Rectangle(0, 0, PictureSize, PictureSize));
            }
            picturePlanets.Image = final;
        }
        
        private bool Finish()
        {
			var d1 = Core.GetDegree(SpaceObjs[1]);
			for (var i = 2; i < SpaceObjs.Count; i++)
			{
				var d2 = Core.GetDegree(SpaceObjs[i]);
				if (Math.Abs(d1-d2)%360!=0) return false;
			}
			return true;
		}

        private void Toggle()
        {
            timer1.Enabled = !timer1.Enabled;
            var running = timer1.Enabled;
            list1.Enabled = !running;
            list2.Enabled = !running;
            if (running)
            {
                status.Text = "Drawing";
                Start.Text = "Stop";
            }
            else
            {
                status.Text = "Stopped";
                Start.Text = "Play";
            }

            CombineLayers();
        }

		#region Ticks and clicks
        private void timer1_Tick(object sender, EventArgs e) => Tick(SpeedUp);

        private void Start_Click(object sender, EventArgs e) => Toggle();

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(TrajectoryImg).Clear(Color.Transparent);
            TempPoint = null;
        }

		private void Reverse_Click(object sender, EventArgs e)
        {
            SpeedUp *= -1;
            Reverse.Text = SpeedUp > 0 ? "↷" : "↶";
        }

		private void Orbits_Click(object sender, EventArgs e)
        {
            ShowOrbits = !ShowOrbits;
            CombineLayers();
        }

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
            SpeedUp = Convert.ToDouble(speedometr.Value);
			if (SpeedUp < 0) SpeedUp *= -1;
		}

		private void Restart_Click(object sender, EventArgs e)
        {
			Day = 0;
            Core.ToStartAll(SpaceObjs);
			list1.SelectedIndex = 0;
			list2.SelectedIndex = 0;
			DrawOrbitAndPlanets(true);
            if (timer1.Enabled) Toggle();
        }

		private void listbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (var i=0; i<listbox.Items.Count; i++)
                SpaceObjs[i].Draw = listbox.GetItemChecked(i);
            if (!timer1.Enabled) DrawOrbitAndPlanets(true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempPoint = null;
            _p1 = list1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempPoint = null;
            _p2 = list2.SelectedIndex;
        }
        #endregion
    }
}
