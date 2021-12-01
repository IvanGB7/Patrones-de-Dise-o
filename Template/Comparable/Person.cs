using System;

namespace TemplatePattern.Comparable
{
    class Person : IComparable
    {
        //Aqui tenemos nuestro comparativo y creamos nuestras variables que recibiran los valores
        public string Name { get; }
        public int Age { get; }

        //Creamos el objeto con sus atributos
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Aqui creamos una comparacion que va a recibir un objeto
        public int CompareTo(object obj)
        {

            var other = (Person)obj;
            if (String.Compare(Name, other.Name, StringComparison.Ordinal) == 0)
            {
                return Age.CompareTo(other.Age);
            }
            return String.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Name} : {Age} < ";
        }

    }
}