using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            int sayı1, sayıları_toplamı = 0;
            int sayı2, sayac = 0, sayac1 = 0, ortalama;
            int urunlartoplamsı = 0;
            int bakiye = 100, miktar;
            string soru, giris1, urun, kısım, islem, anahtr;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).Kullanıcıdan 5'in Katı Bir Sayı İstenir ve Girilen Sayı 5'in Katı Olana Kadar Tekrar Tekrar İstenir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kullanıcıdan Pozitif Bir Tamsayı Girmesi İstenir. Girilen Sayıya Kadar Olan Tek Sayılar " +
                    "\r\nEkrana Yazdırılır ve En Sonda Bu Sayıların Toplamı Gösterilir.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Kullanıcıdan Sürekli Sayı Talep Edin, Çıkış İsteyince Girilen Sayıların Ortalamasını" +
                    "\r\nGösterin ve Çıkış Yapın.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).Kullanıcıdan Ürün Fiyatlarını Girmesini İsteyin. Kullanıcı (0) Değerini Girene Kadar Fiyatları Alın " +
                    "\r\nve Toplam Fiyatı Hesaplayarak Ekrana Yazdırın.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).Müşteriler Para Yatırma ve Çekme İşlemleri Yapabilir, Hesap Bakiyeleri Güncellenir " +
                    "\r\nve Müşteri İşlemlere Devam Edip Etmeyeceğini Belirler.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        Console.Write("Bir Sayının Giriniz : ");
                        sayı = int.Parse(Console.ReadLine());
                        if (sayı % 5 != 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı, 5'in katlarından biridir. Eğer Ana Menu Donmek İçin (0) Giriniz, " +
                                "\r\ndevam etmek isterseniz farklı sayılar girebilirsiniz. ");
                        }
                    } while (sayı != 0);
                    Console.Clear();
                    continue;
                }

                //****************************************************************************************************//

                else if (soru == "2")
                {
                    while (true)
                    {
                        do
                        {

                            Console.Write("Bir Sayının Giriniz : ");
                            sayı1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Ana Menu Donmek İçin (0) Giriniz.");
                            if (sayı1 >= 0)
                            {
                                Console.WriteLine("Tek Olan Sayılar (0) ile " + "(" + sayı1 + ")");
                                for (int i = 0; i <= sayı1; i++)
                                {
                                    if (i % 2 == 1)
                                    {
                                        Console.WriteLine(i);
                                        sayıları_toplamı += i;
                                    }
                                }
                                Console.WriteLine("Sayıları Toplam : " + " " + sayıları_toplamı);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz Seçim, Lütfen Sayının Pozitif Olması.");
                            }
                        } while (sayı1 != 0);
                        Console.Clear();
                        break;

                    }
                }

                //****************************************************************************************************//

                else if (soru == "3")
                {

                    do
                    {
                        Console.Write("Bir Sayının Giriniz Yada Sayıları Ortalaması (-0) Giriniz : ");
                        sayı2 = int.Parse(Console.ReadLine());
                        sayac1++;
                        sayac += sayı2;
                        ortalama = sayac / sayac1;
                        if (sayı2 == -0)
                        {
                            Console.WriteLine("Toplamış Sayıları Ortalaması : " + ortalama);
                            Console.Write("Ana Menu Donmek İçin (0) Giriniz.");
                            giris1 = Console.ReadLine();
                            if (giris1 == "0")
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                    } while (true);

                    Console.Clear();
                    continue;
                }

                //****************************************************************************************************//

                else if (soru == "4")
                {
                    do
                    {
                        while (true)
                        {
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine("Emt Mağazamız Hoş Geldiniz :)");
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine("Ana Menu Donmek İçin (0) Giriniz.");
                            Console.WriteLine("1.Meyve.");
                            Console.WriteLine("2.Sebze.");
                            Console.WriteLine("3.Yeşillik.");
                            Console.WriteLine("4.Ürünlerin Toplam Fiyatı.");
                            Console.Write("Hangi kısım Geçmek İstiyorsunuz? Sayıyı Yazınız: ");
                            kısım = Console.ReadLine();
                            Console.Clear();

                            if (kısım == "1")
                            {
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Meyve Kısmındaysanız Hoş Geldiniz");
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Ana Sayfa Donmek İçin (0) Giriniz.");
                                Console.WriteLine("(karpuz, kavun, limon, muz, elma)");

                                do
                                {
                                    Console.Write("Ürünüz Giriniz : ");
                                    urun = Console.ReadLine();
                                    if (urun == "karpuz" || urun == "kavun" || urun == "limon" || urun == "muz" || urun == "elma")
                                    {
                                        urunlartoplamsı += 10;
                                    }

                                } while (urun != "0");
                                Console.Clear();
                                continue;
                            }

                            else if (kısım == "2")
                            {
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Sebze Kısmındaysanız Hoş Geldiniz");
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Ana Sayfa Donmek İçin (0) Giriniz.");
                                Console.WriteLine("(patates, soğan, domates, salatalık, mantar, patlıcan)");

                                do
                                {
                                    Console.Write("Ürünüz Giriniz : ");
                                    urun = Console.ReadLine();

                                    if (urun == "patates" || urun == "soğan" || urun == "domates" || urun == "salatalık" || urun == "mantar" || urun == "patlıcan")
                                    {
                                        urunlartoplamsı += 20;
                                    }
                                } while (urun != "0");
                                Console.Clear();
                                continue;
                            }

                            else if (kısım == "3")
                            {
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Yeşillik Kısmındaysanız Hoş Geldiniz");
                                Console.WriteLine("*************************************************************");
                                Console.WriteLine("Ana Sayfa Donmek İçin (0) Giriniz.");
                                Console.WriteLine("(maydanoz, havuç, kıvırcık, semizotu, lahana)");

                                do
                                {
                                    Console.Write("Ürünüz Giriniz : ");
                                    urun = Console.ReadLine();

                                    if (urun == "maydanoz" || urun == "havuç" || urun == "kıvırcık" || urun == "semizotu" || urun == "lahana")
                                    {
                                        urunlartoplamsı += 30;
                                    }
                                } while (urun != "0");
                                Console.Clear();

                                continue;
                            }
                            else if (kısım == "4")
                            {
                                Console.WriteLine("Ürünlerin Toplam Fiyatı: " + urunlartoplamsı + " Tl ");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz Seçim, Lütfen Tekrar Deneyin.");
                            }
                            break;
                        }
                    } while (kısım != "0");
                    Console.Clear();
                    continue;
                }

                //****************************************************************************************************//

                else if (soru == "5")
                {
                    do
                    {
                        Console.WriteLine("*************************************************************");
                        Console.WriteLine("Emt Bankımız Hoş Geldiniz :)");
                        Console.WriteLine("*************************************************************");
                        Console.WriteLine("0.Ana Menu.");
                        Console.WriteLine("1.Çekmek.");
                        Console.WriteLine("2.Yatırma.");
                        Console.Write("Hangi İşlemin Seçin : ");
                        islem = Console.ReadLine();
                        Console.Clear();

                        if (islem == "1")
                        {
                            Console.WriteLine("Bakiyeniz : " + bakiye);
                            Console.Write("İşlem Miktarını Girin : ");
                            miktar = int.Parse(Console.ReadLine());

                            if (miktar > bakiye)
                            {
                                Console.WriteLine("Yetersiz Bakiye. Çekmek İstediğiniz Miktar Bakiyenizden Fazla. " + bakiye + " Tl ");
                            }
                            else
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Para Çekme İşlemi Tamamlandı. Güncel Bakiyeniz: " + bakiye + " Tl ");
                                Console.WriteLine("Başka İşleme İster Misiniz (E) Giriniz Yada Ana Menu Donmek İçin (0) Giriniz : ");
                                anahtr = Console.ReadLine();
                                if (anahtr != "e" && anahtr != "E")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    continue;
                                }
                            }

                        }
                        else if (islem == "2")
                        {
                            Console.WriteLine("Bakiyeniz : " + bakiye + " Tl ");
                            Console.Write("İşlem Miktarını Girin : ");
                            miktar = int.Parse(Console.ReadLine());
                            bakiye += miktar;
                            Console.WriteLine("Para Ekleme İşlemi Tamamlandı. Güncel Bakiyeniz: " + bakiye + " Tl ");
                            Console.Write("Başka İşleme İster Misiniz (E) Giriniz Yada Ana Menu Donmek İçin (0) Giriniz : ");
                            anahtr = Console.ReadLine();
                            if (anahtr != "e" && anahtr != "E")
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine("Geçersiz İşlem. Lütfen Geçerli Bir İşlem Seçin.");
                            Console.WriteLine("*************************************************************");
                            continue;
                        }
                    } while (islem != "0");
                    Console.Clear();
                    continue;
                }

            } while (soru != "0");
            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }

    }
}








