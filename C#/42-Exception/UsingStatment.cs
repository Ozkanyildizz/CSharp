/*
 Nerede Kullanılır?
Dosya işlemleri (StreamReader, FileStream)

Veritabanı bağlantıları (SqlConnection)

Grafik nesneleri (Bitmap, Graphics)

Ağ bağlantıları (HttpClient)

Herhangi bir IDisposable nesne*/

using System;
using System.IO;


namespace C_._42_Exception
{
    internal class UsingStatment
    {
        public void usingtest()
        {
            using (var reader = new StreamReader("veri.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            // reader.Dispose() otomatik çağrılır

        }
        public void usingtest1()
        {
           // using var reader = new StreamReader("veri.txt");  // C# 8.0 ile gelen özellik
            //string line = reader.ReadLine();

        }

        public void usingtest2() // usingtest ve usingtest1 ile aynı işi yapar
        {
            var reader = new StreamReader("veri.txt");
            try
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }
        }
        }
    }
