namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Play_btn = new System.Windows.Forms.Button();
            this.Snap_btn = new System.Windows.Forms.Button();
            this.smallField_btn = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.middleField_btn = new System.Windows.Forms.Button();
            this.bigField_btn = new System.Windows.Forms.Button();
            this.bigSnake_btn = new System.Windows.Forms.Button();
            this.middleSnake_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.smallSnake_btn = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.growTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Play_btn
            // 
            this.Play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Play_btn.Location = new System.Drawing.Point(830, 561);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(75, 53);
            this.Play_btn.TabIndex = 0;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Snap_btn
            // 
            this.Snap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Snap_btn.Location = new System.Drawing.Point(943, 561);
            this.Snap_btn.Name = "Snap_btn";
            this.Snap_btn.Size = new System.Drawing.Size(75, 53);
            this.Snap_btn.TabIndex = 1;
            this.Snap_btn.Text = "Snap";
            this.Snap_btn.UseVisualStyleBackColor = true;
            this.Snap_btn.Click += new System.EventHandler(this.Snap_btn_Click);
            // 
            // smallField_btn
            // 
            this.smallField_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smallField_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.smallField_btn.Location = new System.Drawing.Point(830, 65);
            this.smallField_btn.Name = "smallField_btn";
            this.smallField_btn.Size = new System.Drawing.Size(100, 40);
            this.smallField_btn.TabIndex = 2;
            this.smallField_btn.Text = "Small";
            this.smallField_btn.UseVisualStyleBackColor = true;
            this.smallField_btn.Click += new System.EventHandler(this.smallField_btn_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(825, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick field size";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 579);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 35);
            this.progressBar1.TabIndex = 4;
            // 
            // middleField_btn
            // 
            this.middleField_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.middleField_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.middleField_btn.Location = new System.Drawing.Point(830, 132);
            this.middleField_btn.Name = "middleField_btn";
            this.middleField_btn.Size = new System.Drawing.Size(100, 44);
            this.middleField_btn.TabIndex = 5;
            this.middleField_btn.Text = "Middle";
            this.middleField_btn.UseVisualStyleBackColor = true;
            this.middleField_btn.Click += new System.EventHandler(this.middleField_btn_Click);
            // 
            // bigField_btn
            // 
            this.bigField_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bigField_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bigField_btn.Location = new System.Drawing.Point(830, 201);
            this.bigField_btn.Name = "bigField_btn";
            this.bigField_btn.Size = new System.Drawing.Size(100, 44);
            this.bigField_btn.TabIndex = 6;
            this.bigField_btn.Text = "Big";
            this.bigField_btn.UseVisualStyleBackColor = true;
            this.bigField_btn.Click += new System.EventHandler(this.bigField_btn_Click);
            // 
            // bigSnake_btn
            // 
            this.bigSnake_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bigSnake_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bigSnake_btn.Location = new System.Drawing.Point(830, 476);
            this.bigSnake_btn.Name = "bigSnake_btn";
            this.bigSnake_btn.Size = new System.Drawing.Size(100, 48);
            this.bigSnake_btn.TabIndex = 10;
            this.bigSnake_btn.Text = "Big";
            this.bigSnake_btn.UseVisualStyleBackColor = true;
            this.bigSnake_btn.Click += new System.EventHandler(this.bigSnake_btn_Click);
            // 
            // middleSnake_btn
            // 
            this.middleSnake_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.middleSnake_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.middleSnake_btn.Location = new System.Drawing.Point(830, 407);
            this.middleSnake_btn.Name = "middleSnake_btn";
            this.middleSnake_btn.Size = new System.Drawing.Size(100, 46);
            this.middleSnake_btn.TabIndex = 9;
            this.middleSnake_btn.Text = "Middle";
            this.middleSnake_btn.UseVisualStyleBackColor = true;
            this.middleSnake_btn.Click += new System.EventHandler(this.middleSnake_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(825, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pick snake size";
            // 
            // smallSnake_btn
            // 
            this.smallSnake_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smallSnake_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.smallSnake_btn.Location = new System.Drawing.Point(830, 340);
            this.smallSnake_btn.Name = "smallSnake_btn";
            this.smallSnake_btn.Size = new System.Drawing.Size(100, 46);
            this.smallSnake_btn.TabIndex = 7;
            this.smallSnake_btn.Text = "Small";
            this.smallSnake_btn.UseVisualStyleBackColor = true;
            this.smallSnake_btn.Click += new System.EventHandler(this.smallSnake_btn_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(22, 25);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(770, 522);
            this.picCanvas.TabIndex = 11;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // growTimer
            // 
            this.growTimer.Interval = 1500;
            this.growTimer.Tick += new System.EventHandler(this.GrowTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 644);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.bigSnake_btn);
            this.Controls.Add(this.middleSnake_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smallSnake_btn);
            this.Controls.Add(this.bigField_btn);
            this.Controls.Add(this.middleField_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smallField_btn);
            this.Controls.Add(this.Snap_btn);
            this.Controls.Add(this.Play_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Snap_btn;
        private System.Windows.Forms.Button smallField_btn;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button middleField_btn;
        private System.Windows.Forms.Button bigField_btn;
        private System.Windows.Forms.Button bigSnake_btn;
        private System.Windows.Forms.Button middleSnake_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button smallSnake_btn;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer growTimer;
    }
}

