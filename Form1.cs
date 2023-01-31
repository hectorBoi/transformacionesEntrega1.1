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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                bmp.SetPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }
            else MessageBox.Show("Select a Figure First");
        }
    }
}