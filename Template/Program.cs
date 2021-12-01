using System;
using System.Collections.Generic;
using TemplatePattern;
using TemplatePattern.Comparable;

namespace Template
{
    class Program
    {
        static void Main()
        {
            //Aqui estamos creando un proceso en donde una persona pide una bebida y va decidiendo si le agregamos condimentos, si agregamos azucar, etc
            var tea = new Tea();
            var coffee = new Coffee();
            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();

            Console.WriteLine();
            coffee.WantsCondiments = true;
            coffee.Prepare();

            //Aqui creamos una lista de objetos de persona, donde solo ponemos su nombre y su edad
            var people = new List<Person> { new Person("Ram", 25), new Person("Abishek", 12), new Person("Ram", 18), new Person("Abishek", 18) };
            //Por cada objeto imprimiremos sus datos en consola
            foreach (var person in people)
            {
                Console.Write(person);
            }
            people.Sort();
            Console.WriteLine();
            foreach (var person in people)
            {
                Console.Write(person);
            }
        }
    }
}
