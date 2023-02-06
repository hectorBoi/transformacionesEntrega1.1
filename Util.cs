using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace transformacionesEntrega1._1
{
    public class Util
    {
        private static Util ins;

        public static Util Ins
        {
            get
            {
                if (ins == null)
                    ins = new Util();
                return ins;
            }
            set { ins = value; }
        }

        public static bool IsPointInPolygon4(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        public static void RecenterCentroid(Figure f)
        {
            f.Centroid = new Point(0, 0);
            for (int p = 0; p < f.Pts.Count; p++)
            {
                f.Centroid.X += f.Pts[p].X;
                f.Centroid.Y += f.Pts[p].Y;
            }
            f.Centroid.X /= f.Pts.Count;
            f.Centroid.Y /= f.Pts.Count;
        }

        public static List<PointF> ToOrigin(List<PointF> outterbounds, PointF Centroid)
        {
            for (int p = 0; p < outterbounds.Count; p++)
            {
                outterbounds[p] = new PointF(outterbounds[p].X - Centroid.X, outterbounds[p].Y - Centroid.Y);
            }
            return outterbounds;
        }

        public static List<PointF> Translate(List<PointF> outterbounds, PointF a)
        {
            for (int p = 0; p < outterbounds.Count; p++)
            {
                outterbounds[p] = new PointF(outterbounds[p].X + a.X, outterbounds[p].Y + a.Y);
            }
            return outterbounds;
        }

        public static List<PointF> Scale(List<PointF> outterbounds, float value)
        {
            for (int p = 0; p < outterbounds.Count; p++)
            {
                outterbounds[p] = new PointF(outterbounds[p].X * value, outterbounds[p].Y * value);
            }
            return outterbounds;
        }

    }
}
