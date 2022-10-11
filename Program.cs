namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] octave = Octave(1);


            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    octave = Octave(1);
                    Console.WriteLine("Выбрана октава 1");
                }
                if (key.Key == ConsoleKey.F2)
                {
                    octave = Octave(2);
                    Console.WriteLine("Выбрана октава 2");
                }
                if (key.Key == ConsoleKey.Q)
                {
                    Sound(octave[0]);

                }
                if (key.Key == ConsoleKey.W)
                {
                    Sound(octave[2]);
                }
                if (key.Key == ConsoleKey.E)
                {
                    Sound(octave[4]);
                }
                if (key.Key == ConsoleKey.R)
                {
                    Sound(octave[5]);
                }
                if (key.Key == ConsoleKey.T)
                {
                    Sound(octave[7]);
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octave[9]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Sound(octave[11]);
                }
                if (key.Key == ConsoleKey.A)
                {
                    Sound(octave[1]);
                }
                if (key.Key == ConsoleKey.S)
                {
                    Sound(octave[3]);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Sound(octave[6]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Sound(octave[8]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Sound(octave[10]);
                }
            }


        }

        static void Sound(int chastota)
        {
            Console.Beep(chastota, 500);
        }

        static int[] Octave(int octave)
        {
            int[] octave4 = { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] octave5 = { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            if (octave == 2)
            {
                return octave5;
            }
            return octave4;
        }
    }
}