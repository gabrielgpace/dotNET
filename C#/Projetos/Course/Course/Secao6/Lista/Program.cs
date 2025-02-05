using System;
using System.Collections.Generic;

namespace Course.Secao6.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIA
            List<string> lista = new List<string>();

            //METODOS DA LIST
            lista.Add("1");
            lista.Add("OI");
            lista.Add("Ola");
            lista.Add("Ana");
            lista.Add("Alex");
            lista.Add("Daniel");

            lista.Insert(2, "Hello"); // adiciona na posiçao especifica

            lista.Count(); //exibe o tamanho da lista

            string s1 = lista.Find(x => x[0] == 'A'); //recebe uma funcao como argumento para retornar um valor booleano baseado na logica da funcao
            Console.WriteLine("Fist A" + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A" + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fist position 'A' " + s1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position" + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5); //cria um filtro para somente itens com 5 caracteres

            lista.Remove("Alex");
        }
    }
}
