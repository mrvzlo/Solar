namespace Solar
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.picturePlanets = new System.Windows.Forms.PictureBox();
            this.Reverse = new System.Windows.Forms.Button();
            this.Orbits = new System.Windows.Forms.Button();
            this.speedometr = new System.Windows.Forms.NumericUpDown();
            this.Restart = new System.Windows.Forms.Button();
            this.list2 = new System.Windows.Forms.ComboBox();
            this.list1 = new System.Windows.Forms.ComboBox();
            this.HideAllRadio = new System.Windows.Forms.RadioButton();
            this.ChosenOnlyRadio = new System.Windows.Forms.RadioButton();
            this.ChosenWithParentsRadio = new System.Windows.Forms.RadioButton();
            this.ShowAllRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedometr)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 18;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(700, 0);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(150, 40);
            this.Start.TabIndex = 1;
            this.Start.Text = "Play";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.DodgerBlue;
            this.status.Location = new System.Drawing.Point(700, 664);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(150, 36);
            this.status.TabIndex = 4;
            this.status.Text = "Stopped";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(775, 40);
            this.Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 40);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // picturePlanets
            // 
            this.picturePlanets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePlanets.BackColor = System.Drawing.Color.Black;
            this.picturePlanets.Location = new System.Drawing.Point(0, 0);
            this.picturePlanets.Margin = new System.Windows.Forms.Padding(0);
            this.picturePlanets.Name = "picturePlanets";
            this.picturePlanets.Size = new System.Drawing.Size(700, 700);
            this.picturePlanets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlanets.TabIndex = 8;
            this.picturePlanets.TabStop = false;
            // 
            // Reverse
            // 
            this.Reverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Reverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reverse.Cursor = System.Windows.Forms.Cursors.Default;
            this.Reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reverse.ForeColor = System.Drawing.Color.White;
            this.Reverse.Location = new System.Drawing.Point(700, 80);
            this.Reverse.Margin = new System.Windows.Forms.Padding(0);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(75, 40);
            this.Reverse.TabIndex = 12;
            this.Reverse.Text = "Invert";
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Orbits
            // 
            this.Orbits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Orbits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Orbits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Orbits.Cursor = System.Windows.Forms.Cursors.Default;
            this.Orbits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orbits.ForeColor = System.Drawing.Color.White;
            this.Orbits.Location = new System.Drawing.Point(700, 40);
            this.Orbits.Margin = new System.Windows.Forms.Padding(0);
            this.Orbits.Name = "Orbits";
            this.Orbits.Size = new System.Drawing.Size(75, 40);
            this.Orbits.TabIndex = 13;
            this.Orbits.Text = "Orbits";
            this.Orbits.UseVisualStyleBackColor = false;
            this.Orbits.Click += new System.EventHandler(this.Orbits_Click);
            // 
            // speedometr
            // 
            this.speedometr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedometr.BackColor = System.Drawing.Color.Black;
            this.speedometr.DecimalPlaces = 1;
            this.speedometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedometr.ForeColor = System.Drawing.Color.White;
            this.speedometr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.speedometr.Location = new System.Drawing.Point(700, 631);
            this.speedometr.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.speedometr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedometr.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.speedometr.Name = "speedometr";
            this.speedometr.Size = new System.Drawing.Size(150, 30);
            this.speedometr.TabIndex = 15;
            this.speedometr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedometr.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Restart
            // 
            this.Restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Default;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(775, 80);
            this.Restart.Margin = new System.Windows.Forms.Padding(0);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 40);
            this.Restart.TabIndex = 16;
            this.Restart.Text = "Reset";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // list2
            // 
            this.list2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.list2.BackColor = System.Drawing.Color.Black;
            this.list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list2.ForeColor = System.Drawing.Color.White;
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(700, 555);
            this.list2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(150, 32);
            this.list2.TabIndex = 18;
            this.list2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // list1
            // 
            this.list1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.list1.BackColor = System.Drawing.Color.Black;
            this.list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list1.ForeColor = System.Drawing.Color.White;
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(700, 593);
            this.list1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(150, 32);
            this.list1.TabIndex = 19;
            this.list1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HideAllRadio
            // 
            this.HideAllRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HideAllRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.HideAllRadio.ForeColor = System.Drawing.Color.White;
            this.HideAllRadio.Location = new System.Drawing.Point(700, 525);
            this.HideAllRadio.Name = "HideAllRadio";
            this.HideAllRadio.Size = new System.Drawing.Size(150, 24);
            this.HideAllRadio.TabIndex = 20;
            this.HideAllRadio.Text = "Hide all";
            this.HideAllRadio.UseVisualStyleBackColor = true;
            this.HideAllRadio.CheckedChanged += new System.EventHandler(this.HideAllRadio_CheckedChanged);
            // 
            // ChosenOnlyRadio
            // 
            this.ChosenOnlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChosenOnlyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ChosenOnlyRadio.ForeColor = System.Drawing.Color.White;
            this.ChosenOnlyRadio.Location = new System.Drawing.Point(700, 495);
            this.ChosenOnlyRadio.Name = "ChosenOnlyRadio";
            this.ChosenOnlyRadio.Size = new System.Drawing.Size(150, 24);
            this.ChosenOnlyRadio.TabIndex = 21;
            this.ChosenOnlyRadio.Text = "Chosen only";
            this.ChosenOnlyRadio.UseVisualStyleBackColor = true;
            this.ChosenOnlyRadio.CheckedChanged += new System.EventHandler(this.ChosenOnlyRadio_CheckedChanged);
            // 
            // ChosenWithParentsRadio
            // 
            this.ChosenWithParentsRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChosenWithParentsRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ChosenWithParentsRadio.ForeColor = System.Drawing.Color.White;
            this.ChosenWithParentsRadio.Location = new System.Drawing.Point(700, 445);
            this.ChosenWithParentsRadio.Name = "ChosenWithParentsRadio";
            this.ChosenWithParentsRadio.Size = new System.Drawing.Size(150, 44);
            this.ChosenWithParentsRadio.TabIndex = 22;
            this.ChosenWithParentsRadio.Text = "Chosen with parents";
            this.ChosenWithParentsRadio.UseVisualStyleBackColor = true;
            this.ChosenWithParentsRadio.CheckedChanged += new System.EventHandler(this.ChosenWithParentsRadio_CheckedChanged);
            // 
            // ShowAllRadio
            // 
            this.ShowAllRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllRadio.Checked = true;
            this.ShowAllRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ShowAllRadio.ForeColor = System.Drawing.Color.White;
            this.ShowAllRadio.Location = new System.Drawing.Point(700, 415);
            this.ShowAllRadio.Name = "ShowAllRadio";
            this.ShowAllRadio.Size = new System.Drawing.Size(150, 24);
            this.ShowAllRadio.TabIndex = 23;
            this.ShowAllRadio.TabStop = true;
            this.ShowAllRadio.Text = "Show all";
            this.ShowAllRadio.UseVisualStyleBackColor = true;
            this.ShowAllRadio.CheckedChanged += new System.EventHandler(this.ShowAllRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.Controls.Add(this.ShowAllRadio);
            this.Controls.Add(this.ChosenWithParentsRadio);
            this.Controls.Add(this.ChosenOnlyRadio);
            this.Controls.Add(this.HideAllRadio);
            this.Controls.Add(this.picturePlanets);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.speedometr);
            this.Controls.Add(this.Orbits);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.status);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedometr)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.PictureBox picturePlanets;
		private System.Windows.Forms.Button Reverse;
		private System.Windows.Forms.Button Orbits;
		private System.Windows.Forms.NumericUpDown speedometr;
		private System.Windows.Forms.Button Restart;
		private System.Windows.Forms.ComboBox list2;
		private System.Windows.Forms.ComboBox list1;
        private System.Windows.Forms.RadioButton HideAllRadio;
        private System.Windows.Forms.RadioButton ChosenOnlyRadio;
        private System.Windows.Forms.RadioButton ChosenWithParentsRadio;
        private System.Windows.Forms.RadioButton ShowAllRadio;
    }
}

