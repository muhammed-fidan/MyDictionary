using System;
using System.Collections.Generic;

namespace My_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> idUser = new MyDictionary<int, string>();
            idUser.Add(1, "Muhammed Fidan");
            idUser.Add(2, "Sibel Cakir");
            idUser.Add(3, "Engin Demirog");

            idUser.Listele();

           




            

           
        }




    }
}
