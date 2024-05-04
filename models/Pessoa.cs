using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_Projeto_Em_DotNet.models
{
    public class Person
    {
        // Atributos
        public string Name { get; set; }
        public int Age { get; set; }


        // Constructor Item obrigario na criação do objeto
        public Person()
        {
        }

        // Metodos

        public void Presentation()
        {
            PrintDisplay($"Hi, my name is {Name},  i´m {Age} years old");
        }

        public void PrintDisplay(string text)
        {
            Console.WriteLine(text);
        }
    }
}