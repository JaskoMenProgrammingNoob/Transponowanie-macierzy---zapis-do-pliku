using System.IO;
class Macierz
{
    FileStream FIN, FOUT;
    int[,] macierz1 = new int[10,10];
    int[,] macierz2 = new int[10, 10];

    public void czytaj_dane()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == 1)
                {
                    macierz1[i, j] = 1;
                } else
                {
                    macierz1[i,j] = 0;
                }
            }
        }
    }
    public void przetworz_dane()
    {
        for (int i =0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                macierz2[j, i] = macierz1[i, j];
            }
        }
    }
        public void wyswietl_dane()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(macierz1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(macierz2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
                
            public void zapisz_dane_do_pliku()
    {
        Console.WriteLine("Zapisuje do pliku");
        FOUT = new FileStream("MacierzB.txt", FileMode.Create);
        StreamWriter zapisz = new StreamWriter(FOUT);
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                zapisz.Write(macierz2[i, j] + " ");
            }
            zapisz.WriteLine();
        }
        
        zapisz.Close();
        FOUT.Close();
    }
    public void czytaj_z_pliku()
    {
        Console.WriteLine("Odczytuje z pliku");
        FIN = new FileStream("MacierzB.txt", FileMode.Open);
        StreamReader odczyt = new StreamReader(FIN);
        string macierz;
        while ((macierz = odczyt.ReadLine()) != null)
        {
            Console.WriteLine(macierz);
        }
        odczyt.Close();
        FIN.Close();

    }



    static void Main(string[] args)
    {

        Macierz macierz = new Macierz();
        macierz.czytaj_dane();
        macierz.przetworz_dane();
        macierz.wyswietl_dane();
        macierz.zapisz_dane_do_pliku();
        macierz.czytaj_z_pliku();

    }
}