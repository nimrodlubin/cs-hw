using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H.W_11._5
{
    abstract class MediaItem
    {
        public int Durtcion { get; set; }
        public string Title { get; set; }
        public abstract void Play();
    }
    class Movie : MediaItem, IDownloadable, IComparable
    {
        public Movie(int durtcion, string title)
        {
            this.Durtcion = durtcion;
            this.Title = title;
        }
        public void Download()
        {
            Console.WriteLine("Downloading movie file");
        }
        public override void Play()
        {
            Console.WriteLine("Playing movie");
        }
        public int CompareTo (Object other)
        {
            Movie m = (Movie)other;

            if (this.Durtcion== m.Durtcion)
            {
                return 0 ;
            }
            else if (this.Durtcion < m.Durtcion)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
    class Song : MediaItem, IDownloadable
    {
        public Song(int durtcion, string title)
        {
            this.Durtcion = durtcion;
            this.Title = title;
        }
        public void Download()
        {
            Console.WriteLine("Downloading song file");
        }
        public override void Play()
        {
            Console.WriteLine("Playing song");
        }
    }
    class LiveStream : MediaItem
    {
        public LiveStream(int durtcion, string title)
        {
            this.Durtcion = durtcion;
            this.Title = title;
        }
        public override void Play()
        {
            Console.WriteLine("Playing live stream");
        }
    }
}