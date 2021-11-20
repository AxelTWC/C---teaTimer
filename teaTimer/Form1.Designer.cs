namespace teaTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tea1 = new System.Windows.Forms.PictureBox();
            this.tea2 = new System.Windows.Forms.PictureBox();
            this.tea3 = new System.Windows.Forms.PictureBox();
            this.teaPot = new System.Windows.Forms.PictureBox();
            this.intro = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.teaLabel1 = new System.Windows.Forms.Label();
            this.teaLabel2 = new System.Windows.Forms.Label();
            this.teaLabel3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.start1 = new System.Windows.Forms.Button();
            this.start2 = new System.Windows.Forms.Button();
            this.start3 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.sandTimer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tea1
            // 
            this.tea1.BackColor = System.Drawing.Color.Transparent;
            this.tea1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tea1.BackgroundImage")));
            this.tea1.Location = new System.Drawing.Point(12, 557);
            this.tea1.Name = "tea1";
            this.tea1.Size = new System.Drawing.Size(201, 160);
            this.tea1.TabIndex = 0;
            this.tea1.TabStop = false;
            this.tea1.Click += new System.EventHandler(this.tea1_Click);
            // 
            // tea2
            // 
            this.tea2.BackColor = System.Drawing.Color.Transparent;
            this.tea2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tea2.BackgroundImage")));
            this.tea2.Location = new System.Drawing.Point(279, 444);
            this.tea2.Name = "tea2";
            this.tea2.Size = new System.Drawing.Size(201, 160);
            this.tea2.TabIndex = 1;
            this.tea2.TabStop = false;
            this.tea2.Click += new System.EventHandler(this.tea2_Click);
            // 
            // tea3
            // 
            this.tea3.BackColor = System.Drawing.Color.Transparent;
            this.tea3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tea3.BackgroundImage")));
            this.tea3.Location = new System.Drawing.Point(539, 557);
            this.tea3.Name = "tea3";
            this.tea3.Size = new System.Drawing.Size(201, 160);
            this.tea3.TabIndex = 2;
            this.tea3.TabStop = false;
            this.tea3.Click += new System.EventHandler(this.tea3_Click);
            // 
            // teaPot
            // 
            this.teaPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teaPot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teaPot.BackgroundImage")));
            this.teaPot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teaPot.Location = new System.Drawing.Point(279, 56);
            this.teaPot.Name = "teaPot";
            this.teaPot.Size = new System.Drawing.Size(200, 200);
            this.teaPot.TabIndex = 3;
            this.teaPot.TabStop = false;
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro.Location = new System.Drawing.Point(218, 283);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(330, 29);
            this.intro.TabIndex = 4;
            this.intro.Text = "Click the tea you want to brew";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(316, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(126, 29);
            this.title.TabIndex = 5;
            this.title.Tag = "";
            this.title.Text = "Tea Timer";
            // 
            // teaLabel1
            // 
            this.teaLabel1.AutoSize = true;
            this.teaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaLabel1.Location = new System.Drawing.Point(58, 557);
            this.teaLabel1.Name = "teaLabel1";
            this.teaLabel1.Size = new System.Drawing.Size(121, 29);
            this.teaLabel1.TabIndex = 6;
            this.teaLabel1.Text = "Black Tea";
            // 
            // teaLabel2
            // 
            this.teaLabel2.AutoSize = true;
            this.teaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaLabel2.Location = new System.Drawing.Point(316, 444);
            this.teaLabel2.Name = "teaLabel2";
            this.teaLabel2.Size = new System.Drawing.Size(129, 29);
            this.teaLabel2.TabIndex = 7;
            this.teaLabel2.Text = "Green Tea";
            // 
            // teaLabel3
            // 
            this.teaLabel3.AutoSize = true;
            this.teaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaLabel3.Location = new System.Drawing.Point(576, 557);
            this.teaLabel3.Name = "teaLabel3";
            this.teaLabel3.Size = new System.Drawing.Size(123, 29);
            this.teaLabel3.TabIndex = 8;
            this.teaLabel3.Text = "White Tea";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(204, 336);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 29);
            this.timer.TabIndex = 9;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(307, 283);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 29);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Visible = false;
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(516, 586);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(224, 120);
            this.temperature.TabIndex = 11;
            this.temperature.Visible = false;
            // 
            // start1
            // 
            this.start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start1.Location = new System.Drawing.Point(279, 342);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(75, 23);
            this.start1.TabIndex = 12;
            this.start1.Text = "Start";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // start2
            // 
            this.start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start2.Location = new System.Drawing.Point(279, 341);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(75, 23);
            this.start2.TabIndex = 13;
            this.start2.Text = "Start";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // start3
            // 
            this.start3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start3.Location = new System.Drawing.Point(279, 342);
            this.start3.Name = "start3";
            this.start3.Size = new System.Drawing.Size(75, 23);
            this.start3.TabIndex = 14;
            this.start3.Text = "Start";
            this.start3.UseVisualStyleBackColor = true;
            this.start3.Click += new System.EventHandler(this.start3_Click_1);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.reset.Location = new System.Drawing.Point(405, 341);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sandTimer
            // 
            this.sandTimer.BackColor = System.Drawing.Color.Transparent;
            this.sandTimer.Image = ((System.Drawing.Image)(resources.GetObject("sandTimer.Image")));
            this.sandTimer.Location = new System.Drawing.Point(259, 444);
            this.sandTimer.Name = "sandTimer";
            this.sandTimer.Size = new System.Drawing.Size(220, 220);
            this.sandTimer.TabIndex = 16;
            this.sandTimer.TabStop = false;
            this.sandTimer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 729);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.teaLabel3);
            this.Controls.Add(this.teaLabel2);
            this.Controls.Add(this.teaLabel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.teaPot);
            this.Controls.Add(this.tea3);
            this.Controls.Add(this.tea2);
            this.Controls.Add(this.tea1);
            this.Controls.Add(this.sandTimer);
            this.Controls.Add(this.temperature);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tea1;
        private System.Windows.Forms.PictureBox tea2;
        private System.Windows.Forms.PictureBox tea3;
        private System.Windows.Forms.PictureBox teaPot;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label teaLabel1;
        private System.Windows.Forms.Label teaLabel2;
        private System.Windows.Forms.Label teaLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Button start3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox sandTimer;
    }
}

