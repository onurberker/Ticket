using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace vize
{

    class Program
    {
        private static string Path = AppDomain.CurrentDomain.BaseDirectory + "sinema.txt";
        private static List<string> data = new List<string>();
        static void Main(string[] args)
        {
            DosyaOku();
            BiletKes();
            Console.ReadKey();
        }
        
        static void BiletKes()
        {
            string info = "\t\t**Bilet sistemine hosgeldiniz**\n\t\tVizyondaki Filmler\n"
                + "Film 1(Salon1)\tFilm 2(Salon2)\tFilm 3(Salon3)\tFilm 4(Salon4)\tFilm 5(Salon5)\t";
            Console.WriteLine(info);
            Console.WriteLine("Lütfen salon numarasına göre bir film seçiniz [1,5]");

            bool exit = false;
            string salonNo = "";
            while(!exit)
            {
                try
                {
                    salonNo = Console.ReadLine();
                    if (Convert.ToInt32(salonNo) >=1 && Convert.ToInt32(salonNo) <= 5)
                        exit = true;
                    else Console.WriteLine("\nHatali secim tekrar deneyin.\n");
                }
                catch(Exception)
                {
                    Console.WriteLine("\nHatali secim tekrar deneyin.\n");
                }
            }
                    Console.WriteLine("Mevcut bos koltuklar\n");
                    List<int> mevcutKoltuklar = new List<int>();

                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i][0].ToString() == salonNo)  //eşlenen salon numarası
                        {
                            string[] parcalar = data[i].Split(',');

                            if (parcalar[3] == "boş")
                            {
                                Console.Write("\t" + parcalar[2]);
                                mevcutKoltuklar.Add(Convert.ToInt32(parcalar[2]));
                            }
                            else
                            {
                                Console.Write("\tX");
                            }

                            if (Convert.ToInt32(parcalar[2]) % 5 == 0) Console.WriteLine();

                        }
                    }

                    Console.WriteLine("Koltuk no sec");

                    exit = false;
                    string koltukNo = "";
                    while (!exit)
                    {
                        try
                        {
                            koltukNo = Console.ReadLine();
                            if (mevcutKoltuklar.Contains(Convert.ToInt32(koltukNo)))
                                exit = true;
                            else Console.WriteLine("\nHatali secim tekrar deneyin.\n");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nHatali secim tekrar deneyin.\n");
                        }
                    }
        }

        

        static void DosyaOku()
        {
            FileStream fileStream=null;

            FileMode mode = FileMode.Open;
            bool exit = false;
            while (!exit)
            {
                try
                {
                    fileStream = new FileStream(Path, mode, FileAccess.Read);
                    exit = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("veri dosya hatası :\n dosya kaybolmus olabilir \n yeri değismis olabilir");
                    Console.WriteLine("yerinin degistigini dusunuyorsaniz dosya yolu girmek icin 1e basiniz");
                    Console.WriteLine("bos bir sinema.txt dosyası oluşturmak için 2ye basınız");
                    string str = Console.ReadLine();
                    if (str.Equals("1"))
                    {
                        Console.WriteLine("gecerli dosya yolu giriniz");
                        Path = Console.ReadLine();
                    }
                    else if (str.Equals("2"))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("Sinema.txt olusturuldu.");
                        Path = AppDomain.CurrentDomain.BaseDirectory + "sinema.txt";
                        mode = FileMode.OpenOrCreate;

                    }
                    else
                    {
                        Console.WriteLine("program sona eriyor");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                }
                if(exit)
                Console.WriteLine("veri dosyasi basari ile okundu\n\n");
            }     

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while  ((line=streamReader.ReadLine())!= null)
                {
                    data.Add(line);
                }
            }

            

            /*foreach(string item in data)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
