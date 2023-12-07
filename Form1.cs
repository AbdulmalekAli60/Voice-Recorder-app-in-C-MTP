using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using NAudio;
using NAudio.Wave;
namespace Voice_Recorder
{

    public partial class Form1 : Form
    {
        bool isRecordingPaused = false;
        bool isRecording = false;
        int ElapsedTime = 0;

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string a, string b, int c, int d);

        SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ElapsedTime++;
            TimerLabel.Text = ElapsedTime.ToString() + " Seconds";
        }

        private void startRecordingPictureBox_Click(object sender, EventArgs e)
        {
            isRecording = true;
            try
            {
                ElapsedTime = 0;
                TimerLabel.Text = "0";

                record("open new Type waveaudio Alias recsound", "", 0, 0);

                record("record recsound", "", 0, 0);
                recoringStatusLable.Text = "Recording";
                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex);
            }
        }

        private void stopRecordingPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }

            if (isRecording)
            {
                try
                {
                    record("stop recsound", "", 0, 0);

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Wave files|*.wav";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        record("save recsound \"" + sfd.FileName + "\"", "", 0, 0);
                        record("close recsound", "", 0, 0);
                        recoringStatusLable.Text = "Recording Saved";
                        timer1.Stop();

                        string filePath = sfd.FileName;
                        string fileName = Path.GetFileName(filePath);

                        var recordingItem = new RecordedItem
                        {
                            FileName = fileName,
                            Length = ElapsedTime,
                            FilePath = filePath
                        };

                        listBox1.Items.Add(recordingItem);
                        ElapsedTime = 0;
                        TimerLabel.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex);
                }
            }
        }

        private void pauseRecordingPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRecordingPaused == false)
                {
                    timer1.Stop();

                    record("pause recsound", "", 0, 0);
                    isRecordingPaused = true;
                    recoringStatusLable.Text = "Recording Paused";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex);

            }
        }

        private void filesPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                TimerLabel.Text = "0";
                ElapsedTime = 0;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "wave|*.wav";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);

                    recoringStatusLable.Text = "Playing " + fileName;
                    soundPlayer = new SoundPlayer(filePath);

                    timer1.Start();

                    soundPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex);
            }
        }

        private void playPictureBox_Click(object sender, EventArgs e)
        {
            if (isRecordingPaused == true)
            {
                timer1.Start();

                record("resume recsound", "", 0, 0);
                isRecordingPaused = false;
                recoringStatusLable.Text = "Recording Resumed";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool x = true;

            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem is RecordedItem selectedRecording)
            {
                try
                {
                    ElapsedTime = 0;
                    TimerLabel.Text = "0";

                    recoringStatusLable.Text = "Playing " + selectedRecording.FileName;
                    soundPlayer = new SoundPlayer(selectedRecording.FilePath);

                    // Start a new thread to play the sound file
                    Thread audioThread = new Thread(PlayAudio);
                    audioThread.Start();

                    timer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex);
                }
            }
        }

        private void PlayAudio()
        {
            soundPlayer.PlaySync();
            StopPlayback();
        }

        private void StopPlayback()
        {
            timer1.Stop();
            recoringStatusLable.Text = "Finished Playing ";
            TimerLabel.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }//class

} //namespace

