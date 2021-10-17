
using System;
using System.Collections;

namespace Homework_Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Kelvin kel = new Kelvin(400); 
            //Celsius celsi = kel;
            //Console.WriteLine(celsi.Degree);
            #endregion
            #region Task2

            
            Person p1 = new Person("Resul","Rustemli",24);
            Person p2 = new Person("Kamal","Nurmemmedov",12);
            Person p3 = new Person("Zeyneb","Aksin",20);
            Person p4 = new Person("Nicat","Cool",23);
            Person[] person = { p1, p2, p3, p4 };
            for (int i = 0; i < person.Length; i++)
            {
                for (int j = 0; j < person.Length - 1; j++)
                {
                    if (person[j] > person[j + 1])
                    {
                        var temp = person[j];
                        person[j] = person[j + 1];
                        person[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].Fullname());
            }
            #endregion
        }
    }
}
