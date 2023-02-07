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
            this.startRecording = new System.Windows.Forms.Button();
            this.playRecording = new System.Windows.Forms.Button();
            this.mouseX = new System.Windows.Forms.Label();
            this.mouseY = new System.Windows.Forms.Label();
            this.TIMER2 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // newFigureButton
            // 
            this.newFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newFigureButton.BackColor = System.Drawing.Color.White;
            this.newFigureButton.FlatAppearance.BorderSize = 0;
            this.newFigureButton.ForeColor = System.Drawing.Color.Black;
            this.newFigureButton.Location = new System.Drawing.Point(8, 230);
            this.newFigureButton.Name = "newFigureButton";
            this.newFigureButton.Size = new System.Drawing.Size(115, 36);
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
            this.treeView1.Location = new System.Drawing.Point(8, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(115, 217);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(140, 12);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(632, 351);
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
            // startRecording
            // 
            this.startRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startRecording.BackColor = System.Drawing.Color.Firebrick;
            this.startRecording.FlatAppearance.BorderSize = 0;
            this.startRecording.ForeColor = System.Drawing.Color.Black;
            this.startRecording.Location = new System.Drawing.Point(8, 272);
            this.startRecording.Name = "startRecording";
            this.startRecording.Size = new System.Drawing.Size(115, 34);
            this.startRecording.TabIndex = 1;
            this.startRecording.Text = "Start Recording";
            this.startRecording.UseVisualStyleBackColor = false;
            this.startRecording.Click += new System.EventHandler(this.startRecording_Click);
            // 
            // playRecording
            // 
            this.playRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playRecording.BackColor = System.Drawing.Color.Green;
            this.playRecording.FlatAppearance.BorderSize = 0;
            this.playRecording.ForeColor = System.Drawing.Color.Black;
            this.playRecording.Location = new System.Drawing.Point(8, 312);
            this.playRecording.Name = "playRecording";
            this.playRecording.Size = new System.Drawing.Size(115, 34);
            this.playRecording.TabIndex = 1;
            this.playRecording.Text = "Play Recording";
            this.playRecording.UseVisualStyleBackColor = false;
            this.playRecording.Click += new System.EventHandler(this.playRecording_Click);
            // 
            // mouseX
            // 
            this.mouseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mouseX.AutoSize = true;
            this.mouseX.Location = new System.Drawing.Point(140, 366);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(17, 15);
            this.mouseX.TabIndex = 3;
            this.mouseX.Text = "X:";
            this.mouseX.Click += new System.EventHandler(this.mouseX_Click);
            // 
            // mouseY
            // 
            this.mouseY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mouseY.AutoSize = true;
            this.mouseY.Location = new System.Drawing.Point(219, 366);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(17, 15);
            this.mouseY.TabIndex = 4;
            this.mouseY.Text = "Y:";
            // 
            // TIMER2
            // 
            this.TIMER2.Interval = 3000;
            this.TIMER2.Tick += new System.EventHandler(this.TIMER2_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(18, 358);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(37, 15);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "Timer";
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 388);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.mouseX);
            this.Controls.Add(this.playRecording);
            this.Controls.Add(this.startRecording);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.newFigureButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newFigureButton;
        private TreeView treeView1;
        private PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer TIMER;
        private Button playRecording;
        private Button startRecording;
        private Label mouseX;
        private Label mouseY;
        private System.Windows.Forms.Timer TIMER2;
        private Label TimerLabel;
    }
}