﻿using System;
using System.IO;

namespace cw
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("C:/Users/АкчуринНа/source/repos/Modul_16/", FileMode.OpenOrCreate))
            {
                string data = "hello world";
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(data);

                stream.Write(bytes, 0, bytes.Length);

            }
            //после память освободится

            using (FileStream stream = new FileStream("C:/Users/АкчуринНа/source/repos/Modul_16/", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];

                stream.Read(bytes, 0, bytes.Length);

                string data = System.Text.Encoding.Unicode.GetString(bytes);

                Console.WriteLine(data);
                Console.ReadLine();
            }
        }
    }
}