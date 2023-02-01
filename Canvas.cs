using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformacionesEntrega1._1
{
    internal class Canvas
    {
        PictureBox pct;
        Bitmap bmp;
        Graphics g;
        public Canvas(PictureBox pct)
        {
            this.pct = pct;
            bmp = new Bitmap(pct.Width, pct.Height);
            Init();

        }

        private void Init()
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            pct.Image = bmp;
            pct.Invalidate();
        }

        public void DrawPixel(int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
            pct.Invalidate();
        }

        public void Render(Scene scene)
        {
            g.Clear(Color.Black);
            for (int f = 0; f < scene.Figures.Count; f++)
            {
                if (scene.Figures[f].Pts.Count > 1)
                {
                    g.FillPolygon(Brushes.DarkSlateGray, scene.Figures[f].Pts.ToArray());
                    g.DrawPolygon(Pens.Goldenrod, scene.Figures[f].Pts.ToArray());
                    g.FillEllipse(Brushes.Violet, scene.Figures[f].Pts[scene.Figures[f].Pts.Count - 1].X - 3, scene.Figures[f].Pts[scene.Figures[f].Pts.Count - 1].Y - 3, 6, 6);
                    g.FillEllipse(Brushes.Yellow, scene.Figures[f].Centroid.X - 3, scene.Figures[f].Centroid.Y - 3, 6, 6);//*/
                }
            }
            pct.Invalidate();
        }

    }


}
