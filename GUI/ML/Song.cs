using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    class Song
    {
        public int genre;
        public string artist_name;
        public string track_name;
        public string track_id;
        public float popularity, acousticness, danceability, duration_ms, energy, instrumentalness, key, liveness, loudness, mode, speechiness, tempo, time_signature, valence, preference;
        public Song(int g, string an, string tn, string ti, int po, float ac, float da, float dm, float e, float ins, float k, float li, float lo, int mo, float sp, float t, int ts, float v, int pr)
        {
         

            genre = g;
            artist_name = an;
            track_name = tn;
            track_id = ti;
            popularity = po;
            acousticness = ac;
            danceability = da;
            duration_ms = dm;
            energy = e;
            instrumentalness = ins;
            key = k;
            liveness = li;
            loudness = lo;
            mode = mo;
            speechiness = sp;
            tempo = t;
            time_signature = ts;
            valence = v;
            preference = pr;
        }
    }
}
