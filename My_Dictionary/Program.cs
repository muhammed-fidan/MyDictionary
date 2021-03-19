using System;
using System.Collections.Generic;

namespace My_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> idUser = new Dictionary<int, string>();
            idUser.Add(1, "Muhammed Fidan");
            idUser.Add(2, "Sibel Cakir");
            idUser.Add(3, "Engin Demirog");

            List();

            Count();

            idUser.Remove(2); //silme islemi yapar.

            List();

            Count();


            void List()
            {
                foreach (var users in idUser)
                {
                    Console.WriteLine(Environment.NewLine + users);
                }
            }
            Console.ReadLine();

            void Count()
            {
                Console.Write("Eleman sayisi:" + idUser.Count + Environment.NewLine);
            }
        }




    }
}
