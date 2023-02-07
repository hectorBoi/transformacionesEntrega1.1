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


namespace transformacionesEntrega1._1
{
    public partial class Form1 : Form
    {
        Scene scene;
        Figure f;
        Canvas canvas;
        Bitmap bmp;
        Point mouse, mouse2;
        PointF mouseStartPos;
        Boolean mouseDown = false;
        Boolean insideF = false;
        float[] corX;
        float[] corY;
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
            treeView1.Nodes.Add(node); ;
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
                            float angleDegree = (float)(radians / 57.2958);

                            //radiansLabel.Text = angleDegree.ToString();
                        }

                    }

                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            float mouseXloc = mouse2.X;
            float mouseYloc = mouse2.Y;
            mouseX.Text = string.Format("X: {0:0}", mouseXloc);
            mouseY.Text = string.Format("Y: {0:0}", mouseYloc);

        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown= true;

        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
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

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            mouseDown = false;
            PCT_CANVAS.Select();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }


        public void startRecording_Click(object sender, EventArgs e)
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
            

            
           if (f != null)
            {
                //f.TranslatePoints(f.Centroid);
                corX = new float[TIMER2.Interval];
                corY = new float[TIMER2.Interval];
                for (int i = 0; i < TIMER2.Interval; i++)
                {
                    corX[i] = mouse2.X;
                    corY[i] = mouse2.Y;
                }

            }
            else
            {
                MessageBox.Show("Choose a figure");
            } 


            
            
        }

        private void playRecording_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TIMER2.Interval; i++)
            {
                canvas.DrawPixel((int)corX[i], (int)corY[i], Color.White);
                f.Add(new PointF((int)corX[i], (int)corY[i]));
            }

        }

        private void PCT_CANVAS_Click_1(object sender, EventArgs e)
        {

        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {
          
        }

        private void mouseX_Click(object sender, EventArgs e)
        {

        }
    }
}