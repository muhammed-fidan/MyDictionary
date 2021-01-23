using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Muhammed");
            isimler.Add("Rüzgar");
            isimler.Listeleniyor();
        }
    }
}
