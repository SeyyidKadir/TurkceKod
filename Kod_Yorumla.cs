using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.IO.Pipes;
using System.IO.Ports;
using System.Collections;
namespace Algoritma_Programlama_Dli
{


    class Degiskenler
    {

        /* Begin */

        public static List<string> Sayisal_isimler = new List<string>();
        public static List<int> Sayisal_Degerler = new List<int>();

        /* End  */



        /* Begin */

        public static List<string> Metin_isimler = new List<string>();
        public static List<string> Metin_Degerler = new List<string>();

        /* End */

        /* Begin */

        public static List<string> Mantiksal_isimler = new List<string>();
        public static List<string> Mantiksal_Degerler = new List<string>();

        /* End */
        public static bool Mantiksal_mi(string deger)
        {

            bool dogru_mu = false;
            if (deger == "Dogru")
            {

                dogru_mu = true;
            }
            else if (deger == "Yanlis")
            {

                dogru_mu = true;
            }
            else
            {

                dogru_mu = false;
            }
            return dogru_mu;
        
        }

        public static bool Turkce_Ve_Gereksiz_Karakter_Denetle(string isim)
        {

            bool dogru_mu;
            int sayi = 0;
            isim = isim.Replace(isim[isim.Length - 1].ToString(), "");
            foreach (char karakter in isim)
            {

                if (karakter == 'ş')
                {
                    sayi -= 1;
              
                }
                if (karakter == 'ö')
                {
                    sayi -= 1;
                
                }
                if (karakter == 'ğ')
                {
                    sayi -= 1;
                
                }
                if (karakter == 'ü')
                {
                    sayi -= 1;
                
                }
                if (karakter == '.')
                {
                    sayi -= 1;
                
                }
                if (karakter == '/')
                {
                    sayi -= 1;
                
                }
                if (karakter == '*')
                {

                    sayi -= 1;
                }
                if (karakter == '-')
                {
                    sayi -= 1;
                }
                if (karakter == '+')
                {
                    sayi -= 1;
                
                }
                if (karakter == '?')
                {
                    sayi -= 1;
                
                }
                if (karakter == '{')
                {
                    sayi -= 1;
                
                }
                if (karakter == '}')
                {
                    sayi -= 1;
                
                }
                if (karakter == '=')
                {

                    sayi -= 1;
                }
                if (karakter == '\\')
                {
                    sayi -= 1;
                
                }
                if (karakter == '#')
                {
                    sayi -= 1;
                
                }
                if (karakter == '$')
                {
                    sayi -= 1;
                
                }
                if (karakter == '%')
                {
                    sayi -= 1;
                
                }
                if (karakter == '\'')
                {
                    sayi -= 1;
                
                }
                if (karakter == 'ı')
                {
                    sayi -= 1;
                
                }
                if (karakter == 'İ')
                {
                    sayi -= 1;
                
                }
                if (karakter == ':')
                {

                    sayi -= 1;
                }
                if (karakter == ';')
                {

                    sayi -= 1;
                }
                if (karakter == '(')
                {
                    sayi -= 1;
                }
                if (karakter == ')')
                {
                    sayi -= 1;
                }
                if (karakter == ',')
                {
                    sayi -= 1;
                }
                if (karakter == '<')
                {
                    sayi -= 1;
                
                }
                if (karakter == '>')
                {
                    sayi -= 1;
                }
                if (karakter == '&')
                {
                    sayi -= 1;
                }
                if (karakter == 'é')
                {
                    sayi -= 1;
                }
                if (karakter == '0')
                {
                    sayi -= 1;
                
                }
                if (karakter == '1')
                {
                    sayi -= 1;
                }
                if (karakter == '2')
                {
                    sayi -= 1;
                }
                if (karakter == '3')
                {
                    sayi -= 1;
                }
                if (karakter == '4')
                {
                    sayi -= 1;
                
                }
                if (karakter == '5')
                {
                    sayi -= 1;
                }
                if (karakter == '6')
                {
                    sayi -= 1;
                }
                if (karakter == '7')
                {
                    sayi -= 1;
                }
                if (karakter == '8')
                {
                    sayi -= 1;
                }
                if (karakter == '9')
                {
                    sayi -= 1;
                }
                if (karakter == 'ç')
                {
                    sayi -= 1;
                }
                if (karakter == 'Ç')
                {
                    sayi -= 1;
                
                }
                if (karakter == 'Ö')
                {
                    sayi -= 1;
                }
                if (karakter == 'Ğ')
                {
                    sayi -= 1;
                }
                if (karakter == '!')
                {
                    sayi -= 1;
                }
                else
                {
                    sayi++;
                }


            }
            if (sayi == isim.Length)
            {
                dogru_mu = false;

            }
            else
            {

                dogru_mu = true;
            }

            return dogru_mu;
        
        
        
        }

        public static void Mantiksal_Deger_Ata(string isim1)
        {
            if (Mantiksal_Degerler.Count != 0)
            {

                int index_1 = Mantiksal_isimler.IndexOf(isim1);
                string deger = Mantiksal_Degerler[index_1].ToString();

                Mantiksal_Degerler.Insert(index_1, deger);

            }
       
        }
        

        public static void Mantiksal_isim_Ekle(string isim)
        {
            Mantiksal_isimler.Add(isim);

        }
        public static void Mantiksal_Deger_Ekle(string deger)
        {
           

            
            Mantiksal_Degerler.Add(deger);

        }
        public static string Mantiksal_Deger_Oku(string isim)
        {


            int index = Mantiksal_isimler.IndexOf(isim);
            if (Mantiksal_Degerler.Count != 0)
            {

                if (Mantiksal_Degerler[index] != "")
                {


                    return Mantiksal_Degerler[index];

                }
                else
                {


                    return "";
                }

            }
            else
            {

                return "";
            }
        
        }
        public static void Sayisal_isim_Ekle(string isim)
        {
            Sayisal_isimler.Add(isim);


        }
        public static void Sayisal_Deger_Ekle(int deger)
        {

            Sayisal_Degerler.Add(deger);
        }
        public static int Sayisal_Deger_Oku(string isim)
        {

            int index = Sayisal_isimler.IndexOf(isim);
            if (Sayisal_Degerler.Count != 0)
            {
                if (Sayisal_Degerler[index] != 0)
                {
                    return Sayisal_Degerler[index];


                }
                else
                {
                    return 0;
                }
            }
            else
            {

                return 0;
            }

        }
        public static string Metin_Deger_Oku(string isim)
        {

            int index = Metin_isimler.IndexOf(isim);
            if (Metin_Degerler.Count != 0)
            {
                if (Metin_Degerler[index] != "")
                {

                    return Metin_Degerler[index].ToString();
                }
                else
                {

                    return "";
                }

            }
            else
            {
                return "";
            
            }
        
        }
        public static void Metin_isim_Ekle(string isim)
        {

            Metin_isimler.Add(isim);
        }
        public static void Metin_deger_Ekle(string deger)
        {

            Metin_Degerler.Add(deger);
        }
        public static void Topla(string isim1, string isim2,string isim3)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int index2 = Sayisal_isimler.IndexOf(isim2);
                int index3 = Sayisal_isimler.IndexOf(isim3);
                if (index3 != -1)
                {
                    Sayisal_Degerler.Insert(index3, Sayisal_Degerler[index] + Sayisal_Degerler[index2]);
                }
                else
                {
                    index3 = Metin_isimler.IndexOf(isim3);
                    Metin_Degerler.Insert(index3, (Sayisal_Degerler[index] + Sayisal_Degerler[index2]).ToString());
                }
            }
        }
        public static void Cikar(string isim1, string isim2, string isim3)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int index2 = Sayisal_isimler.IndexOf(isim2);
                int index3 = Sayisal_isimler.IndexOf(isim3);
                if (index3 != -1)
                {
                    Sayisal_Degerler.Insert(index3, Sayisal_Degerler[index] - Sayisal_Degerler[index2]);
                }
                else
                {
                    index3 = Metin_isimler.IndexOf(isim3);
                    Metin_Degerler.Insert(index3, (Sayisal_Degerler[index] - Sayisal_Degerler[index2]).ToString());
                }
            }
        }
        public static void Carp(string isim1, string isim2, string isim3)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int index2 = Sayisal_isimler.IndexOf(isim2);
                int index3 = Sayisal_isimler.IndexOf(isim3);
                if (index3 != -1)
                {
                    Sayisal_Degerler.Insert(index3, Sayisal_Degerler[index] * Sayisal_Degerler[index2]);
                }
                else
                {
                    index3 = Metin_isimler.IndexOf(isim3);
                    Metin_Degerler.Insert(index3, (Sayisal_Degerler[index] * Sayisal_Degerler[index2]).ToString());
                }
            }
        }
        public static void Bol(string isim1, string isim2, string isim3)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int index2 = Sayisal_isimler.IndexOf(isim2);
                int index3 = Sayisal_isimler.IndexOf(isim3);
                if (index3 != -1)
                {
                    Sayisal_Degerler.Insert(index3, Sayisal_Degerler[index] / Sayisal_Degerler[index2]);
                }
                else
                {
                    index3 = Metin_isimler.IndexOf(isim3);
                    Metin_Degerler.Insert(index3, (Sayisal_Degerler[index] / Sayisal_Degerler[index2]).ToString());
                }
            }
        }

        public static void Mod(string isim1, string isim2, string isim3)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int index2 = Sayisal_isimler.IndexOf(isim2);
                int index3 = Sayisal_isimler.IndexOf(isim3);
                if (index3 != -1)
                {
                    Sayisal_Degerler.Insert(index3, Sayisal_Degerler[index] % Sayisal_Degerler[index2]);
                }
                else
                {
                    index3 = Metin_isimler.IndexOf(isim3);
                    Metin_Degerler.Insert(index3, (Sayisal_Degerler[index] % Sayisal_Degerler[index2]).ToString());
                }
            }
        }

        public static void Degisken_Deger_Ata_Sayisal(string isim1)
        {
            if (Sayisal_Degerler.Count != 0)
            {
                int index = Sayisal_isimler.IndexOf(isim1);
                int deger = Sayisal_Degerler[index];
                Sayisal_Degerler.Insert(index, deger);
            }
            
            
            }
        public static void Degisken_Deger_Ata_Metin(string isim1)
        {

            if (Metin_Degerler.Count != 0)
            {

                int index = Metin_isimler.IndexOf(isim1);
                string deger = Metin_Degerler[index].ToString();
                Metin_Degerler.Insert(index, deger);
            
            }
        }
        public static bool Varmi(string isim)
        {

            bool sonuc;
            if (Sayisal_isimler.Contains(isim))
            {

                sonuc = true;
            }
            else if (Metin_isimler.Contains(isim))
            {

                sonuc = true;
            }
            else if (Mantiksal_isimler.Contains(isim))
            {

                sonuc = true;
            }
            else
            {

                sonuc = false;
            }
            return sonuc;
        
        
        
        }

        public static bool Sayimi(string deger)
        {
            bool dogru_mu = false;
            int sayi = 0;

            foreach (char a in deger)
            {

                if (a == '0')
                {

                    sayi++;
                }
                if (a == '1')
                {

                    sayi++;
                }
                if (a == '2')
                {

                    sayi++;
                }
                if (a == '3')
                {
                    sayi++;
                
                }
                if (a == '4')
                {
                    sayi++;
                
                }
                if (a == '5')
                {

                    sayi++;
                }
                if (a == '6')
                {

                    sayi++;
                }
                if (a == '7')
                {

                    sayi++;
                }
                if (a == '8')
                {

                    sayi++;
                }
                if (a == '9')
                {

                    sayi++;
                }
            }

            if (sayi == deger.Length)
            {

                dogru_mu = true;
            }
            else
            {

                dogru_mu = false;
            }
            return dogru_mu;
        }


        public class Kod_Yorumla
        {

            public static string kod1;
           public static bool Eger = false;
           public static bool ilk_defami = true;
           public static bool Satir_sonu_mu = false;
           public static bool Degilse_Bekle = false;
           public static bool Degilse = false;
           public static bool Degilse_gordu = false;
           public static int dongu_deger = 0;
           public static bool Tekrarla = false;
            public static void Oku(string Kod)
            {
                bool Yaz_Cagirildi = false;
                if (Eger == false && ilk_defami == true && Degilse == false && Degilse_Bekle == false && Tekrarla == false)
                {
                    kod1 = "";
                    Degiskenler.Sayisal_Degerler.Clear();
                    Degiskenler.Sayisal_isimler.Clear();
                    Degiskenler.Metin_isimler.Clear();
                    Degiskenler.Metin_Degerler.Clear();
                    Degiskenler.Mantiksal_isimler.Clear();
                    Degiskenler.Mantiksal_Degerler.Clear();
                    ilk_defami = false;
                }
                else
                {
                    ilk_defami = true;
                
                }
                   Kod = Kod.Replace("\r", "");


                   foreach (string satir in Kod.Split('\n'))
                   {
                       try
                       {
                           if (Eger == false && Satir_sonu_mu == false || Degilse_Bekle == false && Satir_sonu_mu == false || Tekrarla == false && Satir_sonu_mu == false)
                           {
                               Yaz_Cagirildi = false;
                               if (satir.StartsWith("Yaz "))
                               {


                                   if (satir.Substring(4).StartsWith("('") && satir.Substring(4).EndsWith("');"))
                                   {


                                       string kod = satir.Substring(4).Split('\'')[1].Split('\'')[0].ToString();
                                       MessageBox.Show(kod);




                                   }
                                   else if (satir.Substring(4).StartsWith("(\"") && satir.Substring(4).EndsWith("\");") && satir.Substring(4).Split('(')[1].Split(')')[0].Split('"')[1].Contains('+') || satir.Substring(4).StartsWith("(\"") && satir.Substring(4).EndsWith("\");") && !satir.Substring(4).Split('(')[1].Contains('+') && !satir.Substring(4).Split('(')[1].Split(')')[0].Contains('+'))
                                   {

                                       string kod = satir.Substring(4).Split('\"')[1].Split('\"')[0].ToString();
                                       MessageBox.Show(kod);

                                       Yaz_Cagirildi = true;

                                   }

                                   else if (satir.Substring(4).StartsWith("(") && satir.EndsWith(");"))
                                   {


                                       if (Degiskenler.Sayisal_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()) && Degiskenler.Sayisal_Degerler.Count != 0 && Degiskenler.Sayisal_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()))
                                       {

                                           MessageBox.Show(Degiskenler.Sayisal_Deger_Oku(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()).ToString());


                                       }
                                       else if (Degiskenler.Metin_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()) && Degiskenler.Metin_Degerler.Count != 0 && Degiskenler.Metin_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()))
                                       {

                                           MessageBox.Show(Degiskenler.Metin_Deger_Oku(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()).ToString());


                                       }
                                       else if (Degiskenler.Mantiksal_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()) && Degiskenler.Mantiksal_Degerler.Count != 0 && Degiskenler.Mantiksal_isimler.Contains(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()))
                                       {

                                           MessageBox.Show(Degiskenler.Mantiksal_Deger_Oku(satir.Substring(4).Split('(')[1].Split(')')[0].ToString()).ToString());


                                       }
                                       else if (satir.Substring(4).Contains('+'))
                                       {

                                           string deger1 = satir.Substring(4).Split('(')[1].Split('+')[0].ToString().Replace("\"", "");
                                           if (deger1 == "")
                                           {

                                               break;
                                           }
                                           string deger2 = satir.Substring(4).Split('(')[1].Split('+')[1].Split(')')[0].ToString().Replace("\"", "");
                                           if (Sayimi(deger1) && Sayimi(deger2))
                                           {
                                               int sonuc;
                                               sonuc = int.Parse(deger1) + int.Parse(deger2);
                                               MessageBox.Show(sonuc.ToString());
                                               Yaz_Cagirildi = true;
                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                           {

                                               if (Sayisal_Degerler.Count == 2)
                                               {
                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   int sonuc;
                                                   sonuc = Sayisal_Degerler[index1] + Sayisal_Degerler[index2];
                                                   MessageBox.Show(sonuc.ToString());
                                                   Yaz_Cagirildi = true;

                                               }
                                               else if (Sayisal_Degerler.Count == 1)
                                               {

                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   int sonuc;
                                                   sonuc = Sayisal_Degerler[index1] + Sayisal_Degerler[index2];
                                                   MessageBox.Show(sonuc.ToString());
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("Lütfen Değişkenlere Değer Atayınız ! Boş Değişken Toplanamaz !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }

                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayimi(deger2))
                                           {


                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger1);
                                                   int sonuc;
                                                   sonuc = int.Parse(deger2) + Sayisal_Degerler[index];
                                                   MessageBox.Show(sonuc.ToString());
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;
                                               }


                                           }
                                           else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                           {



                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger2);
                                                   int sonuc;
                                                   sonuc = int.Parse(deger1) + Sayisal_Degerler[index];
                                                   MessageBox.Show(sonuc.ToString());
                                                   Yaz_Cagirildi = true;


                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;
                                               }

                                           }
                                           else if (satir.Substring(4).Contains('"'))
                                           {

                                               if (satir.EndsWith("\");") && !Metin_isimler.Contains(deger1) && !Metin_isimler.Contains(deger2) && satir.Substring(4).StartsWith("(\""))
                                               {


                                                   MessageBox.Show(deger1 + deger2);
                                                   Yaz_Cagirildi = true;
                                               }
                                               if (Metin_isimler.Contains(deger1) && deger2 != "")
                                               {

                                                   if (Metin_Degerler.Count != 0)
                                                   {
                                                       int index = Metin_isimler.IndexOf(deger1);

                                                       MessageBox.Show(Metin_Degerler[index].ToString() + deger2);

                                                       Yaz_Cagirildi = true;


                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;


                                                   }
                                               }
                                               else if (deger1 != "" && Metin_isimler.Contains(deger2))
                                               {

                                                   if (Metin_Degerler.Count != 0)
                                                   {

                                                       int index = Metin_isimler.IndexOf(deger2);
                                                       MessageBox.Show(deger1 + Metin_Degerler[index].ToString());
                                                       Yaz_Cagirildi = true;
                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;


                                                   }

                                               }
                                               else if (deger1 != "" && Sayisal_isimler.Contains(deger2))
                                               {


                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger2);
                                                       MessageBox.Show(deger1 + Sayisal_Degerler[index].ToString());
                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }

                                               }
                                               else if (deger2 != "" && Sayisal_isimler.Contains(deger1))
                                               {

                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger1);
                                                       MessageBox.Show(Sayisal_Degerler[index] + deger2.ToString());

                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;


                                                   }


                                               }
                                               else if (!Metin_isimler.Contains(deger1) && Yaz_Cagirildi != true)
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }

                                               if (deger2 == "")
                                               {

                                                   MessageBox.Show("Derleme Hatası ! \n Lütfen Değer Birleştirirken BirLeştirilcek Metinleri Düzgün Yerleştirin \n Örnek:\n Yaz (\"Merhaba \"+\" Dünya !\"); Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;
                                               }

                                           }
                                           else
                                           {

                                               Yaz_Cagirildi = true;
                                               MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;

                                           }

                                       }
                                       else if (satir.Substring(4).Contains('-') && !satir.Contains('"'))
                                       {

                                           string deger1 = satir.Substring(4).Split('(')[1].Split('-')[0].ToString();
                                           string deger2 = satir.Substring(4).Split('(')[1].Split('-')[1].Split(')')[0].ToString();
                                           if (deger1 == "" || deger2 == "")
                                           {

                                               break;
                                           }
                                           if (Sayimi(deger1) && Sayimi(deger2))
                                           {
                                               MessageBox.Show((int.Parse(deger1) - int.Parse(deger2)).ToString());
                                               Yaz_Cagirildi = true;
                                           }
                                           else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (int.Parse(deger1) - Sayisal_Degerler[index]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;
                                               }
                                               else
                                               {
                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {
                                                   int index = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index] - int.Parse(deger2)).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;


                                               }

                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                           {


                                               if (Sayisal_Degerler.Count == 2)
                                               {

                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (Sayisal_Degerler[index1] - Sayisal_Degerler[index2]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else if (Sayisal_Degerler.Count == 1)
                                               {


                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index1] - Sayisal_Degerler[index1]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;


                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else
                                           {

                                               Yaz_Cagirildi = true;
                                               MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;

                                           }

                                       }
                                       else if (satir.Substring(4).Contains('*') && !satir.Contains('"'))
                                       {

                                           string deger1 = satir.Substring(4).Split('(')[1].Split('*')[0].ToString();
                                           string deger2 = satir.Substring(4).Split('(')[1].Split('*')[1].Split(')')[0].ToString();
                                           if (deger1 == "" || deger2 == "")
                                           {

                                               break;
                                           }
                                           if (Sayimi(deger1) && Sayimi(deger2))
                                           {
                                               MessageBox.Show((int.Parse(deger1) * int.Parse(deger2)).ToString());
                                               Yaz_Cagirildi = true;
                                           }
                                           else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (int.Parse(deger1) * Sayisal_Degerler[index]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;
                                               }
                                               else
                                               {
                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {
                                                   int index = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index] * int.Parse(deger2)).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;


                                               }

                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                           {


                                               if (Sayisal_Degerler.Count == 2)
                                               {

                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (Sayisal_Degerler[index1] * Sayisal_Degerler[index2]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else if (Sayisal_Degerler.Count == 1)
                                               {


                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index1] * Sayisal_Degerler[index1]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;


                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else
                                           {

                                               Yaz_Cagirildi = true;
                                               MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;

                                           }

                                       }
                                       else if (satir.Substring(4).Contains('/') && !satir.Contains('"'))
                                       {

                                           string deger1 = satir.Substring(4).Split('(')[1].Split('/')[0].ToString();
                                           string deger2 = satir.Substring(4).Split('(')[1].Split('/')[1].Split(')')[0].ToString();
                                           if (deger1 == "" || deger2 == "")
                                           {

                                               break;
                                           }
                                           if (Sayimi(deger1) && Sayimi(deger2))
                                           {
                                               MessageBox.Show((int.Parse(deger1) / int.Parse(deger2)).ToString());
                                               Yaz_Cagirildi = true;
                                           }
                                           else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (int.Parse(deger1) / Sayisal_Degerler[index]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;
                                               }
                                               else
                                               {
                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {
                                                   int index = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index] / int.Parse(deger2)).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;


                                               }

                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                           {


                                               if (Sayisal_Degerler.Count == 2)
                                               {

                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (Sayisal_Degerler[index1] / Sayisal_Degerler[index2]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else if (Sayisal_Degerler.Count == 1)
                                               {


                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index1] / Sayisal_Degerler[index1]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;


                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else
                                           {

                                               Yaz_Cagirildi = true;
                                               MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;

                                           }

                                       }
                                       else if (satir.Substring(4).Contains('%') && !satir.Contains('"'))
                                       {

                                           string deger1 = satir.Substring(4).Split('(')[1].Split('%')[0].ToString();
                                           string deger2 = satir.Substring(4).Split('(')[1].Split('%')[1].Split(')')[0].ToString();
                                           if (deger1 == "" || deger2 == "")
                                           {

                                               break;
                                           }
                                           if (Sayimi(deger1) && Sayimi(deger2))
                                           {
                                               MessageBox.Show((int.Parse(deger1) % int.Parse(deger2)).ToString());
                                               Yaz_Cagirildi = true;
                                           }
                                           else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (int.Parse(deger1) % Sayisal_Degerler[index]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;
                                               }
                                               else
                                               {
                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                           {

                                               if (Sayisal_Degerler.Count != 0)
                                               {
                                                   int index = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index] % int.Parse(deger2)).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;


                                               }

                                           }
                                           else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                           {


                                               if (Sayisal_Degerler.Count == 2)
                                               {

                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   int index2 = Sayisal_isimler.IndexOf(deger2);
                                                   string sonuc = (Sayisal_Degerler[index1] % Sayisal_Degerler[index2]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;

                                               }
                                               else if (Sayisal_Degerler.Count == 1)
                                               {


                                                   int index1 = Sayisal_isimler.IndexOf(deger1);
                                                   string sonuc = (Sayisal_Degerler[index1] % Sayisal_Degerler[index1]).ToString();
                                                   MessageBox.Show(sonuc);
                                                   Yaz_Cagirildi = true;


                                               }
                                               else
                                               {

                                                   MessageBox.Show("En Az Bir Değişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else
                                           {

                                               Yaz_Cagirildi = true;
                                               MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;

                                           }

                                       }
                                       else
                                       {

                                           MessageBox.Show("Derleme Hatası Değişken Adı Belirtilmedi Ve Değeri Belirtilmedi !\n örnek:\n Sayisal a; a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;
                                       }





                                   }

                                   else
                                   {


                                       MessageBox.Show("Yaz Komut Kullanım Hatası !\n Aşşağıdakileri Gözden Geçirin\n 1.Yaz ('Yazılacak Değer'); \n 2.; Dikkat Edin !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       break;
                                   }



                               }
                               if (satir.StartsWith("Oku "))
                               {

                                   if (satir.Substring(4).Contains('(') && satir.Substring(4).Contains(')') && satir.Substring(4).EndsWith(");") && satir.Contains(','))
                                   {

                                       string isim = satir.Substring(4).Split('(')[1].Split(')')[0].Split(',')[1].ToString();
                                       string baslik = satir.Substring(4).Split('(')[1].Split('"')[1].Split('"')[0].ToString();

                                       if (baslik != "")
                                       {
                                           if (Degiskenler.Metin_isimler.Contains(isim))
                                           {

                                               Oku_Form _oku = new Oku_Form();
                                               _oku.Text = baslik.ToString();
                                               _oku.ShowDialog();
                                               if (_oku.txtDeger.Text != null || _oku.txtDeger.Text != "")
                                               {
                                                   Metin_deger_Ekle(_oku.txtDeger.Text.ToString());
                                               }
                                               else
                                               {

                                                   break;
                                               }
                                           }
                                           else if (Degiskenler.Sayisal_isimler.Contains(isim))
                                           {


                                               Oku_Form _oku = new Oku_Form();
                                               _oku.Text = baslik.ToString();
                                               _oku.ShowDialog();
                                               if (_oku.txtDeger.Text != "" && Sayimi(_oku.txtDeger.Text))
                                               {
                                                   Sayisal_Deger_Ekle(int.Parse(_oku.txtDeger.Text));

                                               }
                                               else
                                               {

                                                   break;

                                               }

                                           }
                                           else
                                           {



                                               MessageBox.Show("Değişken Tanımsız Ve Mantıksal Değişken Kullanılmaz ! Örnek:\n Metin a; \n Oku (\"1 Sayi Girin\",a); Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }
                                       }
                                       else
                                       {


                                           MessageBox.Show("Başlığı Girmelisiniz !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;
                                       }


                                   }
                                   else
                                   {


                                       MessageBox.Show("Derleme Hatası ! Oku Kullanım Örnek : \n Oku (\"1 Sayı Girin\",degisken); \n Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       break;
                                   }


                               }
                               if (satir.StartsWith("Sayisal "))
                               {

                                   if (satir.Substring(8).ToString() != null)
                                   {


                                       if (satir.Substring(8).EndsWith(";"))
                                       {

                                           if (!Varmi(satir.Substring(8).Split(';')[0].ToString()))
                                           {
                                               if (!Turkce_Ve_Gereksiz_Karakter_Denetle(satir.Substring(8).Split(';')[0].ToString()))
                                               {
                                                   Degiskenler.Sayisal_isim_Ekle(satir.Substring(8).Split(';')[0].ToString());

                                               }
                                               else
                                               {

                                                   MessageBox.Show("Lütfen Değişken Adlarında Sayı ve Türkçe Karakter Kullanmayınız ! \n " + satir.Substring(8).Split(';')[0].ToString() + "\n Değişken Adı Olamaz !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;
                                               }

                                           }
                                           else
                                           {

                                               MessageBox.Show("Aynı Değişken İsimini Kullanamazsınız !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                               break;

                                           }
                                       }
                                       else
                                       {

                                           MessageBox.Show("Değişken Atama Hatası ! ; Gerekli Örnek :\n Sayisal a; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;
                                       }

                                   }
                                   else
                                   {

                                       MessageBox.Show("Değişken Tanımlama Hatası ! İsim Gerekli ! Örnek \n Sayisal a; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       break;
                                   }





                               }
                               if (satir.StartsWith("Metin "))
                               {
                                   if (satir.Substring(6).ToString() != null)
                                   {


                                       if (satir.Substring(6).EndsWith(";"))
                                       {
                                           if (!Varmi(satir.Substring(6).Split(';')[0].ToString()))
                                           {

                                               if (!Turkce_Ve_Gereksiz_Karakter_Denetle(satir.Substring(6).Split(';')[0].ToString()))
                                               {
                                                   Degiskenler.Metin_isim_Ekle(satir.Substring(6).Split(';')[0].ToString());
                                               }
                                               else
                                               {
                                                   MessageBox.Show("Lütfen Değişken Adlarında Sayı ve Türkçe Karakter Kullanmayınız ! \n " + satir.Substring(6).Split(';')[0].ToString() + "\n Değişken Adı Olamaz !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }
                                           }
                                           else
                                           {
                                               MessageBox.Show("Aynı Değişken İsimini Kullanamazsınız !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                               break;

                                           }

                                       }
                                       else
                                       {
                                           MessageBox.Show("Değişken Atama Hatası ! ; Gerekli Örnek :\n Metin a; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;

                                       }
                                   }


                               }
                               if (satir.StartsWith("Mantiksal "))
                               {

                                   if (satir.Substring(10).ToString() != null)
                                   {


                                       if (satir.Substring(10).EndsWith(";"))
                                       {
                                           if (!Varmi(satir.Substring(10).Split(';')[0].ToString()))
                                           {
                                               if (!Turkce_Ve_Gereksiz_Karakter_Denetle(satir.Substring(10).Split(';')[0].ToString()))
                                               {
                                                   Degiskenler.Mantiksal_isim_Ekle(satir.Substring(10).Split(';')[0].ToString());
                                               }
                                               else
                                               {

                                                   MessageBox.Show("Lütfen Değişken Adlarında Sayı ve Türkçe Karakter Kullanmayınız ! \n " + satir.Substring(10).Split(';')[0].ToString() + "\n Değişken Adı Olamaz !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;

                                               }


                                           }
                                           else
                                           {
                                               MessageBox.Show("Aynı Değişken İsimini Kullanamazsınız !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                               break;

                                           }
                                       }
                                       else
                                       {

                                           MessageBox.Show("Değişken Atama Hatası ! ; Gerekli Örnek :\n Mantiksal a; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;

                                       }

                                   }


                               }
                               if (satir.StartsWith("Eger "))
                               {

                                   if (satir.Substring(5).StartsWith("(") && satir.Substring(5).EndsWith(")"))
                                   {
                                       if (Kod.Contains("Eger Bitti"))
                                       {
                                           if (satir.Substring(5).Contains('='))
                                           {

                                               string deger1 = satir.Substring(5).Split('(')[1].Split('=')[0].ToString();
                                               string deger2 = satir.Substring(5).Split('(')[1].Split('=')[1].Split(')')[0].ToString();
                                               if (deger1 != "" && Metin_isimler.Contains(deger2) && satir.Substring(5).Contains('"'))
                                               {

                                                   if (Metin_Degerler.Count != 0)
                                                   {

                                                       int index = Metin_isimler.IndexOf(deger2);
                                                       if (deger1.Replace("\"", "").ToString() == Metin_Degerler[index].ToString())
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;
                                                       }

                                                   }
                                                   else
                                                   {


                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;
                                                   }

                                               }
                                               else if (deger2 != "" && Metin_isimler.Contains(deger1) && satir.Substring(5).Contains('"'))
                                               {

                                                   if (Metin_Degerler.Count != 0)
                                                   {

                                                       int index = Metin_isimler.IndexOf(deger1);
                                                       if (deger2.Replace("\"", "").ToString() == Metin_Degerler[index].ToString())
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;
                                                       }

                                                   }
                                                   else
                                                   {


                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;
                                                   }

                                               }
                                               else if (deger1 != "" && deger2 != "" && satir.Substring(5).Contains('"'))
                                               {
                                                   if (deger1.Replace("\"", "").ToString() == deger2.Replace("\"", "").ToString())
                                                   {

                                                       Eger = true;

                                                   }
                                                   else
                                                   {

                                                       Degilse_Bekle = true;
                                                       Degilse = true;


                                                   }


                                               }
                                               else if (Sayimi(deger1) && Sayimi(deger2))
                                               {

                                                   if (int.Parse(deger1) == int.Parse(deger2))
                                                   {

                                                       Eger = true;
                                                   }
                                                   else
                                                   {
                                                       Degilse_Bekle = true;
                                                       Degilse = true;

                                                   }

                                               }
                                               else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                               {


                                                   if (Sayisal_Degerler.Count != 0)
                                                   {


                                                       int index = Sayisal_isimler.IndexOf(deger2);
                                                       if (int.Parse(deger1) == Sayisal_Degerler[index])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }


                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }


                                               }
                                               else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                               {


                                                   if (Sayisal_Degerler.Count != 0)
                                                   {
                                                       int index = Sayisal_isimler.IndexOf(deger1);
                                                       if (int.Parse(deger2) == Sayisal_Degerler[index])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }

                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }


                                               }
                                               else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                               {

                                                   if (Sayisal_Degerler.Count == 2)
                                                   {

                                                       int index1 = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index1] == Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;


                                                       }


                                                   }
                                                   else if (Sayisal_Degerler.Count == 1)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index] == Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }

                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }


                                               }
                                               else if (Metin_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                               {
                                                   if (Metin_Degerler.Count != 0 && Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index1 = Metin_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index2].ToString() == Metin_Degerler[index1].ToString())
                                                       {


                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;


                                                       }

                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;


                                                   }






                                               }
                                               else if (Metin_isimler.Contains(deger2) && Sayisal_isimler.Contains(deger1))
                                               {
                                                   if (Metin_Degerler.Count != 0 && Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index1 = Metin_isimler.IndexOf(deger2);
                                                       int index2 = Sayisal_isimler.IndexOf(deger1);
                                                       if (Sayisal_Degerler[index2].ToString() == Metin_Degerler[index1].ToString())
                                                       {


                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;


                                                       }

                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;


                                                   }






                                               }
                                               else
                                               {



                                                   MessageBox.Show("Eger Kullanım Hatası ! Örnek:\n Eger (Degiskenismi=\"11\")\n Yaz (\"11\");\n Eger Bitti \n Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   break;
                                               }
                                           }
                                           else if (satir.Substring(5).Contains('>'))
                                           {
                                               string deger1 = satir.Substring(5).Split('(')[1].Split('>')[0].ToString();
                                               string deger2 = satir.Substring(5).Split('(')[1].Split('>')[1].Split(')')[0].ToString();
                                               if (Sayimi(deger1) && Sayimi(deger2))
                                               {

                                                   if (int.Parse(deger1) > int.Parse(deger2))
                                                   {

                                                       Eger = true;

                                                   }
                                                   else
                                                   {
                                                       Degilse_Bekle = true;
                                                       Degilse = true;

                                                   }


                                               }
                                               else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                               {

                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger2);
                                                       if (int.Parse(deger1) > Sayisal_Degerler[index])
                                                       {


                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;


                                                       }




                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }



                                               }
                                               else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                               {

                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger1);
                                                       if (Sayisal_Degerler[index] > int.Parse(deger2))
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }

                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }

                                               }
                                               else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                               {

                                                   if (Sayisal_Degerler.Count == 2)
                                                   {

                                                       int index1 = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index1] > Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }


                                                   }
                                                   else if (Sayisal_Degerler.Count == 1)
                                                   {

                                                       int index1 = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index1] > Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }
                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }

                                               }


                                           }
                                           else if (satir.Substring(5).Contains('<'))
                                           {
                                               string deger1 = satir.Substring(5).Split('(')[1].Split('<')[0].ToString();
                                               string deger2 = satir.Substring(5).Split('(')[1].Split('<')[1].Split(')')[0].ToString();
                                               if (Sayimi(deger1) && Sayimi(deger2))
                                               {

                                                   if (int.Parse(deger1) < int.Parse(deger2))
                                                   {

                                                       Eger = true;

                                                   }
                                                   else
                                                   {
                                                       Degilse_Bekle = true;
                                                       Degilse = true;

                                                   }


                                               }
                                               else if (Sayimi(deger1) && Sayisal_isimler.Contains(deger2))
                                               {

                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger2);
                                                       if (int.Parse(deger1) < Sayisal_Degerler[index])
                                                       {


                                                           Eger = true;
                                                       }
                                                       else
                                                       {
                                                           Degilse_Bekle = true;
                                                           Degilse = true;


                                                       }




                                                   }
                                                   else
                                                   {

                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }



                                               }
                                               else if (Sayimi(deger2) && Sayisal_isimler.Contains(deger1))
                                               {

                                                   if (Sayisal_Degerler.Count != 0)
                                                   {

                                                       int index = Sayisal_isimler.IndexOf(deger1);
                                                       if (Sayisal_Degerler[index] < int.Parse(deger2))
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }

                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }

                                               }
                                               else if (Sayisal_isimler.Contains(deger1) && Sayisal_isimler.Contains(deger2))
                                               {

                                                   if (Sayisal_Degerler.Count == 2)
                                                   {

                                                       int index1 = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index1] < Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }


                                                   }
                                                   else if (Sayisal_Degerler.Count == 1)
                                                   {

                                                       int index1 = Sayisal_isimler.IndexOf(deger1);
                                                       int index2 = Sayisal_isimler.IndexOf(deger2);
                                                       if (Sayisal_Degerler[index1] < Sayisal_Degerler[index2])
                                                       {

                                                           Eger = true;
                                                       }
                                                       else
                                                       {

                                                           Degilse_Bekle = true;
                                                           Degilse = true;

                                                       }
                                                   }
                                                   else
                                                   {
                                                       MessageBox.Show("Karşılatırma Yapmak İçin Değişken Değeri Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       break;

                                                   }

                                               }


                                           }
                                           else
                                           {

                                               MessageBox.Show("Geçersiz Karşılaştırma ! Eger Komutu Yapmış Olduğunuz Karşılaştırma Tipini Desteklemiyor !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }
                                       }
                                       else
                                       {

                                           MessageBox.Show("Derleme Hatası Eger Bitti Gerekli !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;
                                       }


                                   }

                               }
                               if (satir.StartsWith("Tekrarla "))
                               {

                                   if (satir.Substring(9).StartsWith("(") && satir.Substring(9).EndsWith(")") && Kod.Contains("Tekrarla Bitti"))
                                   {
                                       string deger1 = satir.Substring(9).Split('(')[1].Split(')')[0].ToString();
                                       if (Sayimi(deger1))
                                       {
                                           Tekrarla = true;
                                           dongu_deger = int.Parse(deger1);
                                       }
                                       else if (Sayisal_isimler.Contains(deger1))
                                       {


                                           if (Sayisal_Degerler.Count != 0)
                                           {
                                               int index = Sayisal_isimler.IndexOf(deger1);
                                               dongu_deger = Sayisal_Degerler[index];
                                               Tekrarla = true;

                                           }
                                           else
                                           {

                                               MessageBox.Show("Tekrarla Komutu Çalışma Hatası ! \nDeğişkene Değer Atamalısınız !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }

                                       }
                                       else
                                       {

                                           MessageBox.Show("Tekrarla Kullanım Hatası ! Örnek:\n Tekrarla (10) \n Tekrarla Bitti \n Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           break;

                                       }

                                   }
                                   else
                                   {


                                       MessageBox.Show("Tekrarla Komutunu Kullanmanız İçin Değişkene Değer Atamalısınız ! \n Tekrarla Bitti Gerekli ! \n Örnek :\n Sayisal a; \n a=10; \n Tekrarla (a) \n Yaz (\"10\"); \n Tekrarla Bitti \n Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       break;


                                   }

                               }
                               if (Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[0].ToString()) && satir.EndsWith(";") && satir.StartsWith(satir.Split('=')[0] + "=") && !satir.Contains('+') && !satir.Contains('-') && !satir.Contains('%') && !satir.Contains('/') && !satir.Contains('*') && !Eger == true && !Degilse_Bekle == true)
                               {

                                   if (Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split(';')[0].ToString()))
                                   {
                                       Degiskenler.Degisken_Deger_Ata_Sayisal(satir.Split('=')[1].Split(';')[0].ToString());

                                   }
                                   else
                                   {
                                       if (Degiskenler.Sayisal_isimler.Count != 0)
                                       {

                                           if (Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[0].ToString()) && Sayimi(satir.Split('=')[1].Split(';')[0].ToString()))
                                           {

                                               if (Degiskenler.Sayisal_Degerler.Count != 0)
                                               {

                                                   int index = Degiskenler.Sayisal_isimler.IndexOf(satir.Split('=')[0]);
                                                   int deger = int.Parse(satir.Split('=')[1].Split(';')[0]);
                                                   Degiskenler.Sayisal_Degerler.Insert(index, deger);
                                               }
                                               else
                                               {

                                                   Degiskenler.Sayisal_Deger_Ekle(int.Parse(satir.Split('=')[1].Split(';')[0].ToString()));
                                               }

                                           }
                                           else
                                           {
                                               MessageBox.Show("Lütfen Değişken İsmi Ve Değer Belirtiniz Ve Değişken Ataması Yapınız ! Örnek : \n Sayisal a; \n a=123; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }



                                       }
                                   }
                               }
                               else if (Degiskenler.Metin_isimler.Contains(satir.Split('=')[0].ToString()) && satir.EndsWith("\";") && satir.StartsWith(satir.Split('=')[0] + "=\"") && satir.Contains(";") || satir.Contains("=") && !Degiskenler.Mantiksal_isimler.Contains(satir.Split('=')[0].ToString()) && !Eger == true && !Degilse_Bekle == true)
                               {

                                   if (Degiskenler.Metin_isimler.Contains(satir.Replace("\"", "").ToString().Split('=')[1].Split(';')[0].ToString()))
                                   {
                                       Degiskenler.Degisken_Deger_Ata_Metin(satir.Replace("\"", "").ToString().Split('=')[1].Split(';')[0].ToString());

                                   }
                                   else
                                   {
                                       if (Degiskenler.Metin_isimler.Count != 0)
                                       {

                                           if (Degiskenler.Metin_isimler.Contains(satir.Split('=')[0].ToString()) && !Eger == true && !Degilse_Bekle == true)
                                           {

                                               if (Degiskenler.Metin_Degerler.Count != 0)
                                               {
                                                   string deger = "";
                                                   int index = Metin_isimler.IndexOf(satir.Replace("\"", "").Split('=')[0].ToString());
                                                   if (satir.Contains('+'))
                                                   {

                                                       int index1;
                                                       int index2;
                                                       index1 = Metin_isimler.IndexOf(satir.Split('=')[1].Split('+')[0].ToString());
                                                       index2 = Metin_isimler.IndexOf(satir.Split('=')[1].Split('+')[1].Split(';')[0].ToString());
                                                       if (index1 != -1 && index2 != -1)
                                                       {
                                                           deger = (Metin_Degerler[index1] + Metin_Degerler[index2]).ToString();


                                                       }
                                                       else
                                                       {

                                                           deger = satir.Replace("\"", "").Split('=')[1].Split(';')[0].ToString();

                                                       }
                                                   }
                                                   else
                                                   {
                                                       deger = satir.Replace("\"", "").Split('=')[1].Split(';')[0].ToString();
                                                   }
                                                   Degiskenler.Metin_Degerler.Insert(index, deger);

                                               }
                                               else
                                               {
                                                   Degiskenler.Metin_deger_Ekle(satir.Replace("\"", "").Split('=')[1].Split(';')[0].ToString());
                                               }

                                           }
                                           else
                                           {
                                               MessageBox.Show("Lütfen Değişken İsmi Ve Değer Belirtiniz Ve Değişken Ataması Yapınız ! Örnek : \n Metin a; \n a=\"123\"; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }



                                       }
                                   }
                               }
                               else if (Degiskenler.Mantiksal_isimler.Contains(satir.Split('=')[0].ToString()) && satir.EndsWith(";") && satir.StartsWith(satir.Split('=')[0] + "=") && !satir.Contains('+') && !satir.Contains('-') && !satir.Contains('%') && !satir.Contains('/') && !satir.Contains('*') && !Eger == true && !Degilse_Bekle == true)
                               {

                                   if (Degiskenler.Mantiksal_isimler.Contains(satir.Split('=')[1].Split(';')[0].ToString()))
                                   {
                                       Degiskenler.Mantiksal_Deger_Ata(satir.Split('=')[1].Split(';')[0].ToString());

                                   }
                                   else
                                   {
                                       if (Degiskenler.Mantiksal_isimler.Count != 0)
                                       {

                                           if (Degiskenler.Mantiksal_isimler.Contains(satir.Split('=')[0].ToString()) && Mantiksal_mi(satir.Split('=')[1].Split(';')[0].ToString()))
                                           {

                                               if (Degiskenler.Mantiksal_Degerler.Count != 0)
                                               {

                                                   int index = Degiskenler.Mantiksal_isimler.IndexOf(satir.Split('=')[0]);
                                                   string deger = satir.Split('=')[1].Split(';')[0].ToString();
                                                   Degiskenler.Mantiksal_Degerler.Insert(index, deger);
                                               }
                                               else
                                               {

                                                   Degiskenler.Mantiksal_Deger_Ekle(satir.Split('=')[1].Split(';')[0].ToString());
                                               }

                                           }
                                           else
                                           {
                                               MessageBox.Show("Lütfen Değişken İsmi Ve Değer Belirtiniz Ve Değişken Ataması Yapınız ! Örnek : \n Mantiksal a; \n a=Dogru; Gibi !", "Derleme Hatası !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                               break;
                                           }



                                       }
                                   }
                               }
                               if (satir.Contains('+') && Yaz_Cagirildi == false && satir.Contains('=') && !Eger == true && !Degilse_Bekle == true)
                               {

                                   if (satir.Split('=')[0].ToString() != null && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('+')[0].ToString()) && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('+')[1].Split(';')[0].ToString()))
                                   {

                                       Degiskenler.Topla(satir.Split('=')[1].Split('+')[0].ToString(), satir.Split('=')[1].Split('+')[1].Split(';')[0].ToString(), satir.Split('=')[0].ToString());


                                   }


                               }
                               if (satir.Contains('-') && Yaz_Cagirildi == false)
                               {

                                   if (satir.Split('=')[0].ToString() != null && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('-')[0].ToString()) && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('-')[1].Split(';')[0].ToString()))
                                   {

                                       Degiskenler.Cikar(satir.Split('=')[1].Split('-')[0].ToString(), satir.Split('=')[1].Split('-')[1].Split(';')[0].ToString(), satir.Split('=')[0].ToString());


                                   }


                               }
                               if (satir.Contains('*') && Yaz_Cagirildi == false)
                               {

                                   if (satir.Split('=')[0].ToString() != null && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('*')[0].ToString()) && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('*')[1].Split(';')[0].ToString()))
                                   {

                                       Degiskenler.Carp(satir.Split('=')[1].Split('*')[0].ToString(), satir.Split('=')[1].Split('*')[1].Split(';')[0].ToString(), satir.Split('=')[0].ToString());


                                   }


                               }
                               if (satir.Contains('/') && Yaz_Cagirildi == false)
                               {

                                   if (satir.Split('=')[0].ToString() != null && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('/')[0].ToString()) && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('/')[1].Split(';')[0].ToString()))
                                   {

                                       Degiskenler.Bol(satir.Split('=')[1].Split('/')[0].ToString(), satir.Split('=')[1].Split('/')[1].Split(';')[0].ToString(), satir.Split('=')[0].ToString());


                                   }


                               }
                               if (satir.Contains('%') && Yaz_Cagirildi == false)
                               {

                                   if (satir.Split('=')[0].ToString() != null && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('%')[0].ToString()) && Degiskenler.Sayisal_isimler.Contains(satir.Split('=')[1].Split('%')[1].Split(';')[0].ToString()))
                                   {

                                       Degiskenler.Mod(satir.Split('=')[1].Split('%')[0].ToString(), satir.Split('=')[1].Split('%')[1].Split(';')[0].ToString(), satir.Split('=')[0].ToString());


                                   }


                               }

                           }
                           if (satir.StartsWith("Eger Bitti"))
                           {
                               if (Eger == true || Degilse == true)
                               {
                                   Eger = false;
                                   Degilse = false;
                                   Satir_sonu_mu = false;
                                   Degilse_Bekle = false;
                                   Kod_Yorumla.Oku(kod1);
                                   kod1 = "";
                                   Degilse_gordu = false;
                                   ilk_defami = false;
                               }
                               else
                               {
                                   Satir_sonu_mu = false;
                                   Eger = false;
                                   Degilse_Bekle = false;
                                   Degilse = false;
                                   Degilse_gordu = false;
                                   ilk_defami = false;
                               }

                           }
                           if (satir.StartsWith("Tekrarla Bitti"))
                           {
                               Tekrarla = false;
                               Satir_sonu_mu = false;
                               for (int i = 0; i < dongu_deger; i++)
                               {
                                   ilk_defami = false;
                                   Kod_Yorumla.Oku(kod1);


                               }

                               ilk_defami = false;
                               kod1 = "";
                           }

                           if (satir.StartsWith("Degilse"))
                           {
                               if (Eger == true)
                               {
                                   Degilse_gordu = true;
                               }
                               else
                               {
                                   Degilse_Bekle = false;
                               }
                           }
                           if (satir.StartsWith("Bitir"))
                           {
                               Satir_sonu_mu = false;
                               Eger = false;
                               Degilse_Bekle = false;
                               Degilse = false;
                               ilk_defami = true;
                               Degilse_gordu = false;
                               kod1 = "";
                           }
                           else if (Eger == true && Satir_sonu_mu == true || Degilse_Bekle == false && Satir_sonu_mu == true)
                           {

                               if (Degilse_gordu == false && Tekrarla == false && Degilse == false)
                               {
                                   kod1 += satir + "\n";
                               }
                               else if (Degilse == true && Satir_sonu_mu == true && satir != "Degilse" && satir != "Tekrarla Bitti")
                               {
                                   kod1 += satir + "\n";

                               }
                               else if (Tekrarla == true)
                               {


                                   kod1 += satir + "\n";
                               }

                           }
                           if (Satir_sonu_mu == false && Eger == true || Satir_sonu_mu == false && Degilse_Bekle == true || Satir_sonu_mu == false && Tekrarla == true)
                           {

                               if (Degilse == true)
                               {

                                   Satir_sonu_mu = true;
                               }
                               else if (Eger == true)
                               {

                                   Satir_sonu_mu = true;
                               }
                               else if (Tekrarla == true)
                               {

                                   Satir_sonu_mu = true;
                               }

                           }



                       }
                       catch
                       {
                           Degiskenler.Sayisal_Degerler.Clear();
                           Degiskenler.Sayisal_isimler.Clear();
                           Degiskenler.Metin_Degerler.Clear();
                           Degiskenler.Metin_isimler.Clear();
                           Degiskenler.Mantiksal_Degerler.Clear();
                           Degiskenler.Mantiksal_isimler.Clear();
                           Satir_sonu_mu = false;
                           Eger = false;
                           Degilse_Bekle = false;
                           Degilse_gordu = false;
                           dongu_deger = 0;
                           Tekrarla = false;
                           kod1 = "";
                           ilk_defami = true;
                           MessageBox.Show("Program Derleme Hatası Derleme Yapılırken Bir Sorun Oluştu Aşşağıdaki Hataları Gözden Geçiriniz \n 1.Değişken Tanımsız ! \n 2.Döngü Değer Verilmedi ! \n 3.Değişkene Değer Verilmedi ! \n Hatalarınızı Gözden Geçirin Tekrar Deneyin !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           break;
                       
                       }


                   }
             
               


                }





            }





        }





    }