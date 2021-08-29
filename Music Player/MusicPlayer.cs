using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        private List<string> playList;
        private WindowsMediaPlayer wmp;

        public MusicPlayer()
        {
            InitializeComponent();
            playList = new List<string>();
            wmp = new WindowsMediaPlayer();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "MP3 files|*.mp3|WMV files|*.wmv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (PlayListBox.Items.Contains(open.SafeFileNames.GetValue(i)) == false)
                    {
                        PlayListBox.Items.Add(open.SafeFileNames.GetValue(i));
                        playList.Add(open.FileNames[i]);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный вами трек уже добавлен в плейлист!");
                    }
                }
            }
            if (PlayListBox.SelectedIndex < 0 & PlayListBox.Items.Count > 0) { PlayListBox.SetSelected(0, true); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playList.Count; i++)
            {
                if (i == PlayListBox.SelectedIndex)
                {
                    CurrentTime.Text = "Текущее время:0:00:00";
                    FullTime.Text = "Общее время:0:00:00";
                    playList.RemoveAt(i);

                    break;
                }
            }
            if (PlayListBox.SelectedIndex != -1)
            {
                PlayListBox.Items.RemoveAt(PlayListBox.SelectedIndex);
            }

            wmp.controls.stop();
            TrackBar.Enabled = false;
            TrackName.Text = "";
            TrackBar.Value = 0;
            Continue.Enabled = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (playList.Count > 0)
            {
                TrackBar.Enabled = true;
                timer1.Enabled = true;
                timer1.Interval = 1000;

                PlayListBox.SetSelected(PlayListBox.SelectedIndex, true);
                wmp.URL = playList[PlayListBox.SelectedIndex];

                timer1.Start();
                TrackName.Text = PlayListBox.SelectedItem.ToString();
            }

            Continue.Enabled = true;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (PlayListBox.SelectedIndex != -1)
            {
                wmp.controls.play();
            }
        }

        private void Previo_Click(object sender, EventArgs e)
        {
            if (PlayListBox.Items.Count > 1 & PlayListBox.SelectedIndex != -1)
            {

                if (PlayListBox.SelectedIndex != 0)
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex - 1, true);
                    wmp.URL = playList[PlayListBox.SelectedIndex];
                    TrackName.Text = PlayListBox.SelectedItem.ToString();
                }
                else
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex + PlayListBox.Items.Count - 1, true);
                    wmp.URL = playList[PlayListBox.SelectedIndex];
                    TrackName.Text = PlayListBox.SelectedItem.ToString();
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (PlayListBox.Items.Count > 1 & PlayListBox.SelectedIndex != -1)
            {

                if (PlayListBox.SelectedIndex != PlayListBox.Items.Count - 1)
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex + 1, true);
                    wmp.URL = playList[PlayListBox.SelectedIndex];
                    TrackName.Text = PlayListBox.SelectedItem.ToString();
                }
                else
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex - PlayListBox.Items.Count + 1, true);
                    wmp.URL = playList[PlayListBox.SelectedIndex];
                    TrackName.Text = PlayListBox.SelectedItem.ToString();
                }
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = TrackBar.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TrackBar.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
            TrackBar.Value = Convert.ToInt32(wmp.controls.currentPosition);

            if (wmp != null)
            {
                int s = (int)wmp.currentMedia.duration;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                FullTime.Text = String.Format("Общее время:{0:D}:{1:D2}:{2:D2}", h, m, s);

                s = (int)wmp.controls.currentPosition;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                CurrentTime.Text = String.Format("Текущее время:{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                FullTime.Text = "Общее время:0:00:00";
                CurrentTime.Text = "Текущее время:0:00:00";
            }
        }

        private void PlayListBox_DoubleClick(object sender, EventArgs e)
        {
            if (playList.Count > 0 & PlayListBox.SelectedIndex != -1)
            {
                TrackBar.Enabled = true;
                timer1.Enabled = true;
                timer1.Interval = 1000;
                wmp.URL = playList[PlayListBox.SelectedIndex];
                timer1.Start();
                TrackName.Text = PlayListBox.SelectedItem.ToString();
                Continue.Enabled = true;
            }
        }

        private void PlayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayListBox.SelectedIndex != -1)
            {
                Play.Enabled = true;
            }
            else
            {
                Play.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
                wmp.settings.volume = trackBar1.Value;
            }
            catch
            {
                // Если ни одно видео не запущено, игнорируем нажатие кнопки
            }
        }
    }
}
