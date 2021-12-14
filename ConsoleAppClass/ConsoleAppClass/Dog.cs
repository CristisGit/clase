using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Dog
    {
        // parametreless constructor
        //public Dog()
        //{ 

        //}

        // constructorul indica cat de sanatoasa e clasa

        // constructorul un fel de metoda care nu returneaza o valoare

        // fields
        // is a way to maintain state at the calss level
        // usualy it should be private to the calss
        // a fild are accesibile from the calss no matter the access modifier.

        //public string _name;
        private string _name; // fildurile ar trebuii sa fie private
        //public readonly DateTime _birthDate;
        private readonly DateTime _birthDate; // fildurile ar trebuii sa fie private

        // readonly se initializeaza in constructor
        // readonly valoarea nu se mai poate schimba nici macar in Class)
        string _owner;
        //public const decimal PI = 3.141516M;
        private const decimal PI = 3.141516M;// fildurile ar trebuii sa fie private

        // constanta constanta trebuie definita cand o declari;
        //    myDog._birthDate = DateTime.Now.AddDays(100);
        // constanta  modificat la readonly drept urmare nu poate fi modificat din exterior 
        //myDog.PI  nu fuctioneaza ca readonly
        // se acceseaza prin TYPE <dog.>

        public static int numberOfInstances;
        public Dog(string name, string owner)
        {
          
            _name = name;
            _owner = owner;
            _birthDate = DateTime.Now;
            numberOfInstances++;
        }

        public Dog(string name)
        {

        }

        public void Bark()
        {

            string name = "local name";

            Console.WriteLine("ham ham");
         //   PI = 4.15;

          }

        public static int GetTotalInstancessCreated()
        {

            return numberOfInstances;

        }
    }
}
