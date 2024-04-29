using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp5
{
    public class CustomCollection<T> where T : Person
    {
        private T[] array;

        public int Count
        {
            get => array.Length;
        }

        public CustomCollection()
        {
            array = new T[0];
        }


        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }
        public T FindById(int id)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Id == id)
                {
                    return array[i];
                }
            }
            return null;
        }
        public void GetAll()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine($@"Id : {array[i].Id}
Name : {array[i].Name}
Surname : {array[i].Surname}
Age : {array[i].Age}");
                Console.WriteLine("==========================================");
            }
        }

    }
}
