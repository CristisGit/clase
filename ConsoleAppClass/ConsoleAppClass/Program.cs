using System;
// clasele au proprietati <universal valabile>
// clasele au ?comportamente? care <universal valabile>
//a constructor is a "special" method hat helps with the obj ceation(instantiation),
//public class Animal
//////{
//////  public animal()
//////////{
//////////
//////////}
//////}
// if we don't specify a parameterless constructor the compiler generates one for us
//

// ab object is a realization of a class. eg stamo is the template
// and the mark of the stamp is the 'object' 
// eg. Book vs shelf
// eg new Dog();
namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();

            Dog myDog = new Dog("Grivei", "Maricica");
            // myDog._name = "Azorel"; //'Dog._name' is inaccessible due to its protection level 


            Console.WriteLine(Dog.GetTotalInstancessCreated());
            //    myDog._birthDate = DateTime.Now.AddDays(100);
            // readonly se initializeaza in constructor
            // readonly valoarea nu se mai poate schimba nici macar in Class)

            // - modificat la readonly drept urmare nu poate fi modificat din exterior
            //myDog.PI  nu fuctioneaza ca readonly
            // se acceseaza prin TYPE <dog.>

            Dog YourDog = new Dog("Puffy", "Cristian");
            //Console.WriteLine(Dog.numberOfInstances);
            Console.WriteLine(Dog.GetTotalInstancessCreated());


           // decimal pidog = Dog.PI;//'Dog._name' is inaccessible due to its protection level 
            //decimal yourDog = pidog * 2; 
          

            // access modifier

            // public

            // private

            //protected

            //internal - limits the acces to the current assembly (la namespace)(eg same project)
        }
    }
}
