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
            this.listbox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedometr)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.Navy;
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
            this.Clear.BackColor = System.Drawing.Color.Navy;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(775, 40);
            this.Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 40);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "C";
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
            this.Reverse.BackColor = System.Drawing.Color.Navy;
            this.Reverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reverse.Cursor = System.Windows.Forms.Cursors.Default;
            this.Reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reverse.ForeColor = System.Drawing.Color.White;
            this.Reverse.Location = new System.Drawing.Point(700, 80);
            this.Reverse.Margin = new System.Windows.Forms.Padding(0);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(75, 40);
            this.Reverse.TabIndex = 12;
            this.Reverse.Text = "↷";
            this.Reverse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Orbits
            // 
            this.Orbits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Orbits.BackColor = System.Drawing.Color.Navy;
            this.Orbits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Orbits.Cursor = System.Windows.Forms.Cursors.Default;
            this.Orbits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orbits.ForeColor = System.Drawing.Color.White;
            this.Orbits.Location = new System.Drawing.Point(700, 40);
            this.Orbits.Margin = new System.Windows.Forms.Padding(0);
            this.Orbits.Name = "Orbits";
            this.Orbits.Size = new System.Drawing.Size(75, 40);
            this.Orbits.TabIndex = 13;
            this.Orbits.Text = "O";
            this.Orbits.UseVisualStyleBackColor = false;
            this.Orbits.Click += new System.EventHandler(this.Orbits_Click);
            // 
            // speedometr
            // 
            this.speedometr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedometr.BackColor = System.Drawing.Color.Black;
            this.speedometr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedometr.DecimalPlaces = 1;
            this.speedometr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedometr.ForeColor = System.Drawing.Color.White;
            this.speedometr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.speedometr.Location = new System.Drawing.Point(700, 628);
            this.speedometr.Margin = new System.Windows.Forms.Padding(0);
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
            this.speedometr.Size = new System.Drawing.Size(150, 26);
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
            this.Restart.BackColor = System.Drawing.Color.Navy;
            this.Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Default;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(775, 80);
            this.Restart.Margin = new System.Windows.Forms.Padding(0);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 40);
            this.Restart.TabIndex = 16;
            this.Restart.Text = "R";
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
            this.list2.Location = new System.Drawing.Point(700, 474);
            this.list2.Margin = new System.Windows.Forms.Padding(0);
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
            this.list1.Location = new System.Drawing.Point(700, 511);
            this.list1.Margin = new System.Windows.Forms.Padding(0);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(150, 32);
            this.list1.TabIndex = 19;
            this.list1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listbox
            // 
            this.listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox.BackColor = System.Drawing.Color.Black;
            this.listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox.CheckOnClick = true;
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listbox.ForeColor = System.Drawing.Color.White;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(700, 261);
            this.listbox.Margin = new System.Windows.Forms.Padding(0);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(150, 210);
            this.listbox.TabIndex = 21;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.Controls.Add(this.picturePlanets);
            this.Controls.Add(this.listbox);
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
		private System.Windows.Forms.CheckedListBox listbox;
    }
}

