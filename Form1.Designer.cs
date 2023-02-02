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
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // newFigureButton
            // 
            this.newFigureButton.Location = new System.Drawing.Point(12, 393);
            this.newFigureButton.Name = "newFigureButton";
            this.newFigureButton.Size = new System.Drawing.Size(151, 32);
            this.newFigureButton.TabIndex = 0;
            this.newFigureButton.Text = "New Figure";
            this.newFigureButton.UseVisualStyleBackColor = true;
            this.newFigureButton.Click += new System.EventHandler(this.newFigureButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(151, 375);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PCT_CANVAS.Location = new System.Drawing.Point(169, 12);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(619, 375);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.newFigureButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button newFigureButton;
        private TreeView treeView1;
        private PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer TIMER;
    }
}