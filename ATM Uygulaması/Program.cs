using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_uygulamasi
{
    internal class Program
    {
        
        private static int secim;

        private static void Main(string[] args)
        {
            double bakiye = 50000;
           
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("===================");
            Console.WriteLine("Lütfen adınızı giriniz:...  ");
            string name0 = Console.ReadLine();
            Console.WriteLine("Kullanıcı adı geçersiz...  ");
            Console.WriteLine("===================");          
            Console.WriteLine("Kayıt olmak için bir kullanıcı adı girin:...  ");
            Console.WriteLine("===================");
            string name = Console.ReadLine();
        
            Console.WriteLine("Onaylamak için kullanıcı adını tekrar girin   ");
            string name2 = Console.ReadLine();
 
            
            do
            {
                if (name2 != name)
                {

                    Console.WriteLine("name yanlış...!!!");
                    Console.WriteLine("name tekrar girin...");
                    Console.WriteLine("===================");
                    
                }
                else
                {
                    Console.WriteLine("Ana Menüye Hoşgeldiniz...");
                    Console.WriteLine("===================");
                    Console.WriteLine("İşelm 1 - Para Çek");
                    Console.WriteLine("İşelm 2 - Para Yatır");
                    Console.WriteLine("İşelm 3 - Para tTransferi");
                    Console.WriteLine("İşelm 0 - Çıkış");
                    secim = Convert.ToInt32(Console.ReadLine());

                }

                if (secim == 1)
                {
                    Console.WriteLine("Para Çekme Menüsü..");
                    Console.WriteLine("Çekilecek Para Miktarını Miriniz : ");
                    int cekilen_para = Convert.ToInt32(Console.ReadLine());
                    if (cekilen_para > 50000)
                    {
                        Console.WriteLine("Yetersiz Limit.");
                        Console.WriteLine("\n ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                        Console.WriteLine("Ana Menüye Hoşgeldiniz...");
                        Console.WriteLine("===================");
                        Console.WriteLine("İşelm 1 - Para Çek");
                        Console.WriteLine("İşelm 2 - Para Yatır");
                        Console.WriteLine("İşelm 3 - Para tTransferi");
                        Console.WriteLine("İşelm 0 - Çıkış");
                        secim = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        bakiye -= cekilen_para;
                        Console.WriteLine("Para Çekme İşlemi Başarılı  Kalan Bakiye: " + bakiye);
                        Console.WriteLine("===================");
                        Console.WriteLine("İşelm 1 - Para Çek");
                        Console.WriteLine("İşelm 2 - Para Yatır");
                        Console.WriteLine("İşelm 3 - Para tTransferi");
                        Console.WriteLine("İşelm 0 - Çıkış");
                        secim = Convert.ToInt32(Console.ReadLine());
                    }

                }

                if (secim == 2)
                {
                    Console.WriteLine(" Para Yatırma Menüsü ");
                    Console.WriteLine(" Yatırmak İstedğiniz Tutarı Giriniz : ");
                    int yatırılan_para = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatırılan_para;
                    Console.WriteLine("Para Yatırma İslemi Başarılı Yeni Bakiye : " + bakiye);
                    Console.WriteLine("===================");
                    Console.WriteLine("İşelm 1 - Para Çek");
                    Console.WriteLine("İşelm 2 - Para Yatır");
                    Console.WriteLine("İşelm 3 - Para tTransferi");
                    Console.WriteLine("İşelm 0 - Çıkış");
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Para Transfer ...");
                    Console.WriteLine("Lütfen hedef hesap numarasını girin : ");
                    string numarası = Console.ReadLine();
                    Console.WriteLine("Transfer Etmek İstediğiniz Miktarı Giriniz : ");
                    int transfer = Convert.ToInt32(Console.ReadLine());

                    if (bakiye - transfer >= 0)
                    {
                        Console.WriteLine("İşlem Başarılı...");
                        bakiye -= transfer;
                        Console.WriteLine("Kalan Bakiyie " + bakiye);
                        Console.WriteLine("===================");
                        Console.WriteLine("İşelm 1 - Para Çek");
                        Console.WriteLine("İşelm 2 - Para Yatır");
                        Console.WriteLine("İşelm 3 - Para tTransferi");
                        Console.WriteLine("İşelm 0 - Çıkış");
                        secim = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Envanteriniz yeterli değil... ");
                        Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz.. ");
                        Console.WriteLine("Ana Menüye Hoşgeldiniz...");
                        Console.WriteLine("===================");
                        Console.WriteLine("İşelm 1 - Para Çek");
                        Console.WriteLine("İşelm 2 - Para Yatır");
                        Console.WriteLine("İşelm 3 - Para tTransferi");
                        Console.WriteLine("İşelm 0 - Çıkış");
                        secim = Convert.ToInt32(Console.ReadLine());
                    }

                }



            }
            while (secim != 0);
        }

    }
}

