using System;
using System.Collections.Generic;
using System.Text;

namespace My_Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] ids;
        TValue[] users;
        public MyDictionary()
        {
            ids = new TKey[0];
            users = new TValue[0];

        }

        public void Add(TKey Id, TValue User)
        {

            TKey[] tempKey = ids;
            TValue[] tempValue = users;

            ids = new TKey[ids.Length + 1];
            users = new TValue[users.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                ids[i] = tempKey[i];
                users[i] = tempValue[i];
            }

            ids[ids.Length - 1] = Id;
            users[users.Length - 1] = User;
        }

        public TKey[] Key
        {
            get { return ids; }
        }

        public TValue[] Value
        {
            get { return users; }
        }

        public void Listele()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Id No: " + ids[i] + " " + "Kullanıcı adı: " + users[i]);
            }
        }
    }
}
