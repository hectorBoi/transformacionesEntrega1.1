using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformacionesEntrega1._1
{
    public class Figure
    {
        public List<PointF> Pts, OutterBounds;
        public PointF Centroid, Last;
        public Boolean moving = false;

        public Figure()
        {
            Pts = new List<PointF>();
            //OutterBounds = new List<PointF>();
        }

        public void Add(PointF point)
        {
            Centroid = new PointF();
            Pts.Add(point);
            //OutterBounds.Add(point);

            OutterBounds = new List<PointF>();


            for (int p = 0; p < Pts.Count; p++)
            {
                OutterBounds.Add(Pts[p]);
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = point;

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;

            OutterBounds = Util.ToOrigin(OutterBounds, Centroid);
            OutterBounds = Util.Scale(OutterBounds, (float)1.2);
            OutterBounds = Util.Translate(OutterBounds, Centroid);
        }

        public void TranslatePoints(PointF a)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X + a.X, Pts[p].Y + a.Y);
            }

        }

        public void TranslateToOrigin()
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X - Centroid.X, Pts[p].Y - Centroid.Y);
            }
        }

        public void RecenterOutterBounds()
        {

            OutterBounds = Util.Translate(OutterBounds, Centroid);
        }
    }
}