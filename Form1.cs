using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace transformacionesEntrega1._1
{
    public partial class Form1 : Form
    {
        Scene scene;
        Figure f;
        Canvas canvas;
        Bitmap bmp;
        Point mouse;
        Boolean mouseDown = false;
        Boolean insideF = false;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void newFigureButton_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig." + (treeView1.Nodes.Count + 1));
            node.Tag = f;
            treeView1.Nodes.Add(node);
        }

        private void Init()
        {
            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }
            else MessageBox.Show("Select a Figure First");
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null && f.moving)
            {
                //f.TranslatePoints(f.Centroid);
            }
            canvas.Render(scene);
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView1.SelectedNode.Tag;
            newFigureButton.Select();
        }


        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouse2 = e.Location;
            if (f != null)
            {
                if (Util.IsPointInPolygon4(f.Pts.ToArray(), mouse2)){
                    Cursor.Current = Cursors.SizeAll;
                    if (mouseDown)
                    {
                        Cursor.Current = Cursors.SizeAll;
                        mouse.X -= e.X;
                        mouse.Y -= e.Y;
                        f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                        Util.RecenterCentroid(f);
                        mouse = e.Location;
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
            }

        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown= true;

        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown = false;
            PCT_CANVAS.Select();
        }
    }
}