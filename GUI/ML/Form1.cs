using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using SpotifyAPI.Web.Models;
using System.Dynamic;
using IronPython;

namespace ML
{
    public partial class Form1 : Form
    {

        string[] id;
        string selectedSon;
        Song selectedSong;
        Form popUp;
        Form popUp2;
        Label[] lables;
        TextBox[] description;
        int song_counter = 0;
        TextBox[] controls;
        string[] names = { "genre", "artist_name", "track_name", "track_id", "popularity", "acousticness", "danceability", "duration_ms", "energy", "instrumentalness", "key", "liveness", "loudness", "mode", "speechiness", "tempo", "time_signature", "valence", "preference" };
        int cnt = 0;
        List<Song> songs;
        List<Song> songs2;
        #Import here Engines


        public Form1()
        {
            InitializeComponent();
            init();
            #Import here functions
        }
        void init()
        {
           




            songs = new List<Song>();
            songs2 = new List<Song>();
            popUp2 = new Form();
            popUp2.Size = new Size(250, 550);
            popUp = new Form();
            popUp.Size = new Size(250, 700);
            controls = new TextBox[19];
            description = new TextBox[19];
            lables = new Label[19];
            for(int i = 0; i < controls.Length; i++)
            {
                description[i] = new TextBox();
                description[i].Location = new Point(0, i * 30);
                description[i].Text = names[i];
                description[i].BorderStyle = BorderStyle.None;
                description[i].RightToLeft = RightToLeft.Yes;
                description[i].ReadOnly = true;
                controls[i] = new TextBox();
                controls[i].Location = new Point(100, i * 30);
                lables[i] = new Label();
                lables[i].Location = new Point(0, i * 30);
                lables[i].AutoSize = true;
                lables[i].Text = "test1";
                popUp.Controls.Add(description[i]);
                popUp.Controls.Add(controls[i]);
                popUp2.Controls.Add(lables[i]);
            }
            Button ok, cancel;
            ok = new Button();
            cancel = new Button();
            ok.Location = new Point(20, 600);
            cancel.Location = new Point(120, 600);
            ok.Text = "Ok";
            cancel.Text = "Cancel";
            ok.Click += ok_Click;
            cancel.Click += cancel_Click;
            popUp.Controls.Add(ok);
            popUp.Controls.Add(cancel);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            double acoust = random.NextDouble();
            double dance = random.NextDouble();
            double energy = random.NextDouble();
            double instrum = random.NextDouble();
            double liveness = random.NextDouble();
            double speechiness = random.NextDouble();
            double valence = random.NextDouble();
            int preference = random.Next(0, 1);
            double loudness = random.NextDouble();
            loudness = 0 - loudness*10;
            int key = random.Next(0, 12);
            int duration = random.Next(0, 300000);
            int popularity = random.Next(0, 100);
            int time_sign = random.Next(0, 5);
            double tempo = random.NextDouble();
            int mode = random.Next(0, 2);
            tempo = tempo * 200;

            controls[0].Text = "Movie";
            controls[1].Text = "Test_Author" + song_counter;
            controls[2].Text = "Test_Song" + song_counter;
            controls[3].Text = "Test_Id" + song_counter;
            controls[4].Text = popularity.ToString();
            controls[5].Text = acoust.ToString();
            controls[6].Text = dance.ToString();
            controls[7].Text = duration.ToString();
            controls[8].Text = energy.ToString();
            controls[9].Text = instrum.ToString();
            controls[10].Text = key.ToString();
            controls[11].Text = liveness.ToString();
            controls[12].Text = loudness.ToString();
            controls[13].Text = mode.ToString();
            controls[14].Text = speechiness.ToString();
            controls[15].Text = tempo.ToString();
            controls[16].Text = time_sign.ToString();
            controls[17].Text = valence.ToString();
            controls[18].Text = preference.ToString();

            song_counter += 1;
            popUp.ShowDialog(this);
        }
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if((controls[0].Text).Equals("Movie"))
                {
                controls[0].Text = "0";
            }
            else
            if ((controls[0].Text).Equals("R&B"))
            {
                controls[0].Text = "1";
            }
            else
            if ((controls[0].Text).Equals("A Capella"))
            {
                controls[0].Text = "2";
            }
            else
            if ((controls[0].Text).Equals("Alternative"))
            {
                controls[0].Text = "3";
            }
            else
            if ((controls[0].Text).Equals("Country"))
            {
                controls[0].Text = "4";
            }
            else
            if ((controls[0].Text).Equals("Dance"))
            {
                controls[0].Text = "5";
            }
            else
            if ((controls[0].Text).Equals("Electronic"))
            {
                controls[0].Text = "6";
            }
            else
            if ((controls[0].Text).Equals("Anime"))
            {
                controls[0].Text = "7";
            }
            else
            if ((controls[0].Text).Equals("Folk"))
            {
                controls[0].Text = "8";
            }
            else
            if ((controls[0].Text).Equals("Blues"))
            {
                controls[0].Text = "9";
            }
            else
            if ((controls[0].Text).Equals("Opera"))
            {
                controls[0].Text = "10";
            }
            else
            if ((controls[0].Text).Equals("Hip-Hop"))
            {
                controls[0].Text = "11";
            }
            else
            if ((controls[0].Text).Equals("Children's Music"))
            {
                controls[0].Text = "12";
            }
            else
            if ((controls[0].Text).Equals("Children’s Music"))
            {
                controls[0].Text = "13";
            }
            else
            if ((controls[0].Text).Equals("Rap"))
            {
                controls[0].Text = "14";
            }
            else
            if ((controls[0].Text).Equals("Indie"))
            {
                controls[0].Text = "15";
            }
            else
            if ((controls[0].Text).Equals("Classical"))
            {
                controls[0].Text = "16";
            }
            else
            if ((controls[0].Text).Equals("Pop"))
            {
                controls[0].Text = "17";
            }
            else
            if ((controls[0].Text).Equals("Reggae"))
            {
                controls[0].Text = "18";
            }
            else
            if ((controls[0].Text).Equals("Reggaeton"))
            {
                controls[0].Text = "19";
            }
            else
            if ((controls[0].Text).Equals("Jazz"))
            {
                controls[0].Text = "20";
            }
            else
            if ((controls[0].Text).Equals("Rock"))
            {
                controls[0].Text = "21";
            }
            else
            if ((controls[0].Text).Equals("Ska"))
            {
                controls[0].Text = "22";
            }
            else
            if ((controls[0].Text).Equals("Comedy"))
            {
                controls[0].Text = "23";
            }
            else
            if ((controls[0].Text).Equals("Soul"))
            {
                controls[0].Text = "24";
            }
            else
            if ((controls[0].Text).Equals("Soundtrack"))
            {
                controls[0].Text = "25";
            }
            else
            if ((controls[0].Text).Equals("World"))
            {
                controls[0].Text = "26";
            }

                

            songs2.Add(new Song(Int32.Parse(controls[0].Text), (controls[1].Text), (controls[2].Text), (controls[3].Text), int.Parse(controls[4].Text), float.Parse(controls[5].Text), float.Parse(controls[6].Text), float.Parse(controls[7].Text), float.Parse(controls[8].Text), float.Parse(controls[9].Text), float.Parse(controls[10].Text), float.Parse(controls[11].Text), float.Parse(controls[12].Text), int.Parse(controls[13].Text), float.Parse(controls[14].Text), float.Parse(controls[15].Text), int.Parse(controls[16].Text), float.Parse(controls[17].Text), int.Parse(controls[18].Text)));
            listBox4.Items.Add("ID: " + controls[3].Text + " Title: " + controls[2].Text);
            popUp.Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            popUp.Close();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            cnt = 0;
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            cnt = 1;
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            cnt = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (cnt)
            {
                case 0:
                    MessageBox.Show(listBox2.Items[listBox2.SelectedIndex].ToString());
                    break;
                case 1:
                    MessageBox.Show(listBox1.Items[listBox1.SelectedIndex].ToString());
                    break;
                case 2:
                    MessageBox.Show(listBox3.Items[listBox3.SelectedIndex].ToString());
                    break;
                default:
                    break;
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSon = listBox2.SelectedItem.ToString();
            id = selectedSon.Split(' ');
            for (int i = 0; i < songs2.Count; i++)
            {
                if (id[1].Equals(songs2[i].track_id))
                {
                    selectedSong = songs2[i];
                }
            }
            CalculateV();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            CalculateV();
            popUp2.ShowDialog();
        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedSon = listBox4.SelectedItem.ToString();
            id = selectedSon.Split(' ');
            for (int i = 0; i < songs2.Count ; i++)
            {
                if (id[1].Equals(songs2[i].track_id))
                {
                    selectedSong = songs2[i];
                }
            }
            CalculateV();
        }

        private void CalculateV()
        {
            for (int i = 0; i < 19; i++)
            {
                if (i == 0)
                    lables[i].Text = "Song's genre: " + selectedSong.artist_name;
                if (i == 1)
                    lables[i].Text = "Song's title: " + selectedSong.track_name;
                if (i == 2)
                    lables[i].Text = "Song's genre: " + selectedSong.genre;
                if (i == 3)
                    lables[i].Text = "Song's acousticness: " + selectedSong.acousticness;
                if (i == 4)
                    lables[i].Text = "Song's danceability: " + selectedSong.danceability;
                if (i == 5)
                    lables[i].Text = "Song's duration_ms: " + selectedSong.duration_ms;
                if (i == 6)
                    lables[i].Text = "Song's energy: " + selectedSong.energy;
                if (i == 7)
                    lables[i].Text = "Song's instrumentalness: " + selectedSong.instrumentalness;
                if (i == 8)
                    lables[i].Text = "Song's key: " + selectedSong.key;
                if (i == 9)
                    lables[i].Text = "Song's liveness: " + selectedSong.liveness;
                if (i == 10)
                    lables[i].Text = "Song's loudness: " + selectedSong.loudness;
                if (i == 11)
                    lables[i].Text = "Song's mode: " + selectedSong.mode;
                if (i == 12)
                    lables[i].Text = "Song's popularity: " + selectedSong.popularity;
                if (i == 13)
                    lables[i].Text = "Song's preference: " + selectedSong.preference;
                if (i == 14)
                    lables[i].Text = "Song's speechiness: " + selectedSong.speechiness;
                if (i == 15)
                    lables[i].Text = "Song's tempo: " + selectedSong.tempo;
                if (i == 16)
                    lables[i].Text = "Song's time_signature: " + selectedSong.time_signature;
                if (i == 17)
                    lables[i].Text = "Song's valence: " + selectedSong.valence;
                if (i == 18)
                    lables[i].Text = "=====================";
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            songs.Add(selectedSong);
            listBox2.Items.Add("ID: " + selectedSong.track_id + " Title: " + selectedSong.track_name);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
