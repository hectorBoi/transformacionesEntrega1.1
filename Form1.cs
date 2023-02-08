using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace transformacionesEntrega1._1
{
    public partial class Form1 : Form
    {
        Scene scene;
        Figure f;
        Canvas canvas;
        Bitmap bmpY, bmpX;
        Point ptX, ptY, mouse;
        PointF mouseStartPos;
        Boolean mouseDown = false;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        float deltaX = 0;
        float deltaY = 1;
        Graphics gX, gY;
        PointF[] newPoints;
        public Form1()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        public void newFigureButton_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig." + (treeView1.Nodes.Count + 1));
            node.Tag = f;
            treeView1.Nodes.Add(node); ;
        }

        public void Init()
        {
            bmpX = new Bitmap(PCT_SLIDER_X.Width, PCT_SLIDER_X.Height);
            bmpY = new Bitmap(PCT_SLIDER_Y.Width, PCT_SLIDER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDER_X.Image = bmpX;
            PCT_SLIDER_Y.Image = bmpY;

            gX.DrawLine(Pens.Black, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.Red, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.Black, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Red, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);


            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS);

        }


        public void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));

                
            }
            else MessageBox.Show("Select a Figure First");
        }

        public void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null && f.moving)
            {
                //f.TranslatePoints(f.Centroid);
            }
            canvas.Render(scene);

            if (f != null && (IsMouseDownX || IsMouseDownY))
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);
                f.TranslatePoints(f.Centroid);
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene);

        }

        public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView1.SelectedNode.Tag;
            newFigureButton.Select();
        }

        public void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouse2 = e.Location;
            if (f != null && f.OutterBounds != null)
            {
                //IF the CURSOR is in the OUTTERBOUNDS
                if (Util.IsPointInPolygon4(f.OutterBounds.ToArray(), mouse2))
                {
                    //IF the CURSOR is in the FIGURE f
                    if (Util.IsPointInPolygon4(f.Pts.ToArray(), mouse2))
                    {
                        Cursor.Current = Cursors.SizeAll;
                        if (mouseDown)
                        {
                            Cursor.Current = Cursors.SizeAll;
                            mouse.X -= e.X;
                            mouse.Y -= e.Y;
                            f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                            Util.RecenterCentroid(f);
                            Util.Translate(f.OutterBounds, new Point(-mouse.X, -mouse.Y));
                            mouse = e.Location;
                        }
                    }
                    else
                    //Cursor is in OUTTERBOUNDS but NOT IN FIGURE f
                    {
                        if (mouseDown)
                        {
                            Cursor.Current = Cursors.PanNW;
                            PointF mousePos1 = mouseStartPos;
                            PointF mousePos2 = mouse2;
                            float a = (float)Math.Sqrt(Math.Pow(f.Centroid.X - mousePos1.X, 2) +
                                                Math.Pow(f.Centroid.Y - mousePos1.Y, 2));
                            float b = (float)Math.Sqrt(Math.Pow(f.Centroid.X - mousePos2.X, 2) +
                                                Math.Pow(f.Centroid.Y - mousePos2.Y, 2));
                            float c = (float)Math.Sqrt(Math.Pow(mousePos2.X - mousePos1.X, 2) +
                                                Math.Pow(mousePos2.Y - mousePos1.Y, 2));
                            float radians = (float)Math.Acos((b * b + a * a - c * c) / (2 * a * b));
                           // float angleDegree = (float)(radians / 57.2958);

                            //radiansLabel.Text = angleDegree.ToString();
                        }

                    }

                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
                // Store centroid coordinates in array of type PointF

                if (TIMER2.Enabled)
                {
                    PointF pointX = new(f.Centroid.X, f.Centroid.Y);
                    newPoints = new PointF[TIMER2.Interval + 1];

                    mouseX.Text = string.Format("Centroid X: {0:0}", pointX.X);
                    mouseY.Text = string.Format("Centroid Y: {0:0}", pointX.Y);

                    for(int i = 0; i <= TIMER2.Interval; i++)
                    {
                        newPoints[i] = pointX;
                    }
                }

            }
        }

        public void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown= true;

        }

        public void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            PointF mouse2 = e.Location;
            if (f != null && f.OutterBounds != null)
            {
                if (Util.IsPointInPolygon4(f.OutterBounds.ToArray(), mouse2))
                {

                }
                else
                {
                    mouseStartPos = mouse2;
                }
            }
        }

        public void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown = false;
            PCT_CANVAS.Select();
        }

        public void Form1_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }
        private void PlayRecording_Click(object sender, EventArgs e)
        {
            TIMER3.Interval = TIMER2.Interval;
            TIMER3.Enabled = true;
            TIMER3.Start();
            TIMER3.Tick += new System.EventHandler(TIMER3_Tick);

        }

        public void StartRecording_Click(object sender, EventArgs e)
        {
            /*
             * By pressing this button, the timer will start (which will last a bout 3 seconds)
             * it will record all the data of the movement, storing it in certain arrays with locations, movements, etc
             * and then will stop after timer runs out
             * The data will then be stored in a tree and by pressing the play recording it will be ale to simulate 
             * and run the data obtained.
             * This is how its going to work but we need to learn how to implement it
             */

            
            TIMER2.Start();

            TIMER2.Enabled = true;
            TIMER2.Tick += new System.EventHandler(TIMER2_Tick);

        }

        public void TIMER2_Tick(object sender, EventArgs e)
        {

           
            TIMER2.Stop();
            TIMER2.Enabled = false;
            MessageBox.Show("Timer Stopped");

        }

        private void TIMER3_Tick(object sender, EventArgs e)
        {

            if (TIMER3.Enabled)
            {
                int time = TIMER2.Interval;
                int[] count = new int[time + 1];

                for (int i = 0; i <= time; i++)
                {


                    count[i] = i;
                    label1.Text = string.Format("Timer: {0:0}", count[i]);
                    label1.Refresh();
                }
            }

            TIMER3.Enabled = false;
            TIMER3.Stop();
        }

        public void PCT_CANVAS_Click_1(object sender, EventArgs e)
        {

        }

        public void PCT_SLIDER_X_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        public void PCT_SLIDER_Y_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        public void PCT_SLIDER_X_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, PCT_SLIDER_X.Height / 2, PCT_SLIDER_X.Width, PCT_SLIDER_X.Height / 2);
                gX.FillEllipse(Brushes.Red, e.X, PCT_SLIDER_X.Height / 4, PCT_SLIDER_X.Height / 2, PCT_SLIDER_X.Height / 2);

                PCT_SLIDER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;//------------------
                ptX.X = e.Location.X;
            }
        }

        public void PCT_SLIDER_Y_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.Red, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;//------------------
                ptY.Y = e.Location.Y;
               
            }
        }

        public void PCT_SLIDER_Y_MouseUp(object sender, MouseEventArgs e)
        {

            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Red, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            PCT_SLIDER_Y.Invalidate();
        }

        public void PCT_SLIDER_X_MoveUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, PCT_SLIDER_X.Height / 2, PCT_SLIDER_X.Width, PCT_SLIDER_X.Height / 2);
            gX.FillEllipse(Brushes.Red, PCT_SLIDER_X.Width / 2, PCT_SLIDER_X.Height / 4, PCT_SLIDER_X.Height / 2, PCT_SLIDER_X.Height / 2);

            PCT_SLIDER_X.Invalidate();

        }

        
    }
}