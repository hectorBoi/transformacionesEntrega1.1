using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformacionesEntrega1._1
{
    internal class Figure
    {
        public List<PointF> Pts;
        public PointF Centroid, Last;
        public Boolean moving = false;

        public Figure()
        {
            Pts = new List<PointF>();
        }

        public void Add(PointF point)
        {
            Centroid = new PointF();
            Pts.Add(point);

            for (int p = 0; p < Pts.Count; p++)
            {
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = point;

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;
        }

        public void TranslatePoints(PointF a)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X + a.X, Pts[p].Y + a.Y);
            }
            moving= true;
        }
    }
}
