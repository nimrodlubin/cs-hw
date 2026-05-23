using H.W_11._5;

internal class Program
{
    private static void Main(string[] args)
    {
        MediaItem[] arr = new MediaItem[6];
        arr[0] = new Movie(180, "Lord of the rings");
        arr[1] = new Movie(90, "LegoLend");
        arr[2] = new Movie(105, "MOANA");
        arr[3] = new Song(3, "The king of the middle east");
        arr[4] = new Song(7, "crazy train");
        arr[5] = new LiveStream(130, "The king of the middle east");

        Console.WriteLine("Playing all media items");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Play();
        }

        int movieCount = 0;

        foreach (MediaItem item in arr)
        {
            if (item is Movie)
            {
                movieCount++;
            }
        }
        Movie[] justMovie = new Movie[movieCount];

        int index = 0;
        foreach (MediaItem item in arr)
        {
            if (item is Movie)
            {
                justMovie[index] = (Movie)item;
                index++;
            }
        }
        Array.Sort(justMovie);

        Console.WriteLine("Movies by Duration");
        for (int i = 0; i < justMovie.Length; i++)
        {
            Console.WriteLine($"Name: {justMovie[i].Title} \nTime: {justMovie[i].Durtcion}");
        }
    }
}