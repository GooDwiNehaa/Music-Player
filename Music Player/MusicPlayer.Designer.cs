namespace Music_Player
{
    partial class MusicPlayer
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
            this.PlayListBox = new System.Windows.Forms.ListBox();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Previo = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.TrackName = new System.Windows.Forms.Label();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.FullTime = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayListBox
            // 
            this.PlayListBox.FormattingEnabled = true;
            this.PlayListBox.ItemHeight = 16;
            this.PlayListBox.Location = new System.Drawing.Point(123, 12);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.Size = new System.Drawing.Size(295, 308);
            this.PlayListBox.TabIndex = 0;
            this.PlayListBox.SelectedIndexChanged += new System.EventHandler(this.PlayListBox_SelectedIndexChanged);
            this.PlayListBox.DoubleClick += new System.EventHandler(this.PlayListBox_DoubleClick);
            // 
            // Play
            // 
            this.Play.Enabled = false;
            this.Play.Location = new System.Drawing.Point(18, 12);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(86, 29);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(18, 72);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(86, 29);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Continue
            // 
            this.Continue.Enabled = false;
            this.Continue.Location = new System.Drawing.Point(18, 127);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(86, 29);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Previo
            // 
            this.Previo.Location = new System.Drawing.Point(18, 232);
            this.Previo.Name = "Previo";
            this.Previo.Size = new System.Drawing.Size(86, 29);
            this.Previo.TabIndex = 4;
            this.Previo.Text = "Previo";
            this.Previo.UseVisualStyleBackColor = true;
            this.Previo.Click += new System.EventHandler(this.Previo_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(18, 179);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(86, 29);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // TrackName
            // 
            this.TrackName.Location = new System.Drawing.Point(15, 335);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(472, 17);
            this.TrackName.TabIndex = 6;
            // 
            // TrackBar
            // 
            this.TrackBar.Enabled = false;
            this.TrackBar.Location = new System.Drawing.Point(8, 355);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(479, 56);
            this.TrackBar.TabIndex = 7;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Location = new System.Drawing.Point(12, 421);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(114, 17);
            this.CurrentTime.TabIndex = 8;
            this.CurrentTime.Text = "Текущее время:";
            // 
            // FullTime
            // 
            this.FullTime.AutoSize = true;
            this.FullTime.Location = new System.Drawing.Point(369, 421);
            this.FullTime.Name = "FullTime";
            this.FullTime.Size = new System.Drawing.Size(102, 17);
            this.FullTime.TabIndex = 9;
            this.FullTime.Text = "Общее время:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(424, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 29);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(424, 51);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 29);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Громкость:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBar1.Location = new System.Drawing.Point(440, 154);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 157);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 447);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.FullTime);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previo);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.PlayListBox);
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayListBox;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Previo;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label TrackName;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label FullTime;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

