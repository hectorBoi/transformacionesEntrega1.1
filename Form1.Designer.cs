namespace transformacionesEntrega1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newFigureButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.StartRecording = new System.Windows.Forms.Button();
            this.TIMER2 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PCT_SLIDER_Y = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.PlayRecording = new System.Windows.Forms.Button();
            this.PCT_SLIDER_X = new System.Windows.Forms.PictureBox();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mouseY = new System.Windows.Forms.Label();
            this.mouseX = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TIMER3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDER_Y)).BeginInit();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDER_X)).BeginInit();
            this.MiddlePanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFigureButton
            // 
            this.newFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newFigureButton.BackColor = System.Drawing.Color.White;
            this.newFigureButton.FlatAppearance.BorderSize = 0;
            this.newFigureButton.ForeColor = System.Drawing.Color.Black;
            this.newFigureButton.Location = new System.Drawing.Point(5, 308);
            this.newFigureButton.Name = "newFigureButton";
            this.newFigureButton.Size = new System.Drawing.Size(85, 36);
            this.newFigureButton.TabIndex = 1;
            this.newFigureButton.Text = "New Figure";
            this.newFigureButton.UseVisualStyleBackColor = false;
            this.newFigureButton.Click += new System.EventHandler(this.newFigureButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.LightGray;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(5, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(85, 299);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(99, 9);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(557, 357);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click_1);
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // StartRecording
            // 
            this.StartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartRecording.BackColor = System.Drawing.Color.Firebrick;
            this.StartRecording.FlatAppearance.BorderSize = 0;
            this.StartRecording.ForeColor = System.Drawing.Color.Black;
            this.StartRecording.Location = new System.Drawing.Point(5, 350);
            this.StartRecording.Name = "StartRecording";
            this.StartRecording.Size = new System.Drawing.Size(85, 34);
            this.StartRecording.TabIndex = 1;
            this.StartRecording.Text = "Record";
            this.StartRecording.UseVisualStyleBackColor = false;
            this.StartRecording.Click += new System.EventHandler(this.StartRecording_Click);
            // 
            // TIMER2
            // 
            this.TIMER2.Interval = 3000;
            this.TIMER2.Tick += new System.EventHandler(this.TIMER2_Tick);
            // 
            // PCT_SLIDER_Y
            // 
            this.PCT_SLIDER_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCT_SLIDER_Y.Location = new System.Drawing.Point(19, -81);
            this.PCT_SLIDER_Y.Name = "PCT_SLIDER_Y";
            this.PCT_SLIDER_Y.Size = new System.Drawing.Size(32, 556);
            this.PCT_SLIDER_Y.TabIndex = 0;
            this.PCT_SLIDER_Y.TabStop = false;
            this.PCT_SLIDER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_Y_MouseDown);
            this.PCT_SLIDER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_Y_MouseMove);
            this.PCT_SLIDER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_Y_MouseUp);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.PlayRecording);
            this.LeftPanel.Controls.Add(this.newFigureButton);
            this.LeftPanel.Controls.Add(this.StartRecording);
            this.LeftPanel.Controls.Add(this.treeView1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(93, 440);
            this.LeftPanel.TabIndex = 7;
            // 
            // PlayRecording
            // 
            this.PlayRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayRecording.BackColor = System.Drawing.Color.Green;
            this.PlayRecording.FlatAppearance.BorderSize = 0;
            this.PlayRecording.ForeColor = System.Drawing.Color.Black;
            this.PlayRecording.Location = new System.Drawing.Point(3, 390);
            this.PlayRecording.Name = "PlayRecording";
            this.PlayRecording.Size = new System.Drawing.Size(85, 34);
            this.PlayRecording.TabIndex = 1;
            this.PlayRecording.Text = "Play";
            this.PlayRecording.UseVisualStyleBackColor = false;
            this.PlayRecording.Click += new System.EventHandler(this.PlayRecording_Click);
            // 
            // PCT_SLIDER_X
            // 
            this.PCT_SLIDER_X.Location = new System.Drawing.Point(-297, 6);
            this.PCT_SLIDER_X.Name = "PCT_SLIDER_X";
            this.PCT_SLIDER_X.Size = new System.Drawing.Size(1119, 22);
            this.PCT_SLIDER_X.TabIndex = 0;
            this.PCT_SLIDER_X.TabStop = false;
            this.PCT_SLIDER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_X_MouseDown);
            this.PCT_SLIDER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_X_MouseMove);
            this.PCT_SLIDER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDER_X_MoveUp);
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddlePanel.Controls.Add(this.PCT_SLIDER_X);
            this.MiddlePanel.Location = new System.Drawing.Point(99, 372);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(560, 31);
            this.MiddlePanel.TabIndex = 9;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.label1);
            this.BottomPanel.Controls.Add(this.mouseY);
            this.BottomPanel.Controls.Add(this.mouseX);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(93, 409);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(632, 31);
            this.BottomPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIMER";
            // 
            // mouseY
            // 
            this.mouseY.AutoSize = true;
            this.mouseY.Location = new System.Drawing.Point(90, 11);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(63, 15);
            this.mouseY.TabIndex = 1;
            this.mouseY.Text = "Centroid Y";
            // 
            // mouseX
            // 
            this.mouseX.AutoSize = true;
            this.mouseX.Location = new System.Drawing.Point(6, 11);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(63, 15);
            this.mouseX.TabIndex = 0;
            this.mouseX.Text = "Centroid X";
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.PCT_SLIDER_Y);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(662, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(63, 409);
            this.RightPanel.TabIndex = 11;
            // 
            // TIMER3
            // 
            this.TIMER3.Interval = 3000;
            this.TIMER3.Tick += new System.EventHandler(this.TIMER3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(725, 440);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDER_Y)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDER_X)).EndInit();
            this.MiddlePanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button newFigureButton;
        private TreeView treeView1;
        private PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer TIMER;
        private BindingSource bindingSource1;
        private PictureBox PCT_SLIDER_Y;
        private Panel LeftPanel;
        private Button PlayRecording;
        private PictureBox PCT_SLIDER_X;
        private Panel MiddlePanel;
        private Panel BottomPanel;
        private Panel RightPanel;
        public Button StartRecording;
        public System.Windows.Forms.Timer TIMER3;
        public System.Windows.Forms.Timer TIMER2;
        private Label mouseX;
        private Label mouseY;
        private Label label1;
    }
}