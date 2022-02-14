using System;
using System.Collections.Generic;

namespace Lesson17.Models
{
    public class GenericList<T>
    {
        public List<T> ReadOnlyList { get; private set; }

        public GenericList( List<T> readOnlyList)
        {
            ReadOnlyList = readOnlyList;
        }

        public void Print()
        {
            foreach (T item in ReadOnlyList)
            {
                Console.WriteLine($"{item}");
            }
        }
        public T[] ConvertToArray()
        {
            return ReadOnlyList.ToArray();
        }
        public T FindElement(T elementToFind)
        {
            int count = 0;
            foreach (T item in ReadOnlyList)
            {
                if (item.Equals(elementToFind)) count++;
            }
            if (count == 0)
                throw new ArgumentException(nameof(elementToFind) + "Not found in list");
            else if (count == 1)
                return elementToFind;
            else
                throw new ArgumentException(nameof(elementToFind) + "found more then one in list");
        }
        public T FindElement2(T elementToFind)
        {
            int count = 0;
            foreach (T item in ReadOnlyList)
            {
                if (item.Equals(elementToFind)) count++;
            }
            if (count == 0)
                return default;
            else if (count == 1)
                return elementToFind;
            else
                throw new ArgumentException(nameof(elementToFind) + "found more then one in list");
        }
        public bool ElementContainsInList(T elementToFind)
        {
            return ReadOnlyList.Contains(elementToFind);
        }

        /* Sukurkite generic klasę su type T Read Only sąrašu(kintamieji priskiriami inicializuojant 
         * ir jų keisti nebegalima). Sąrašas reikšmių inicializuoti sąrašui turi ateiti per konstruktorių.
            Turi būti funkcijos:
            Atspausdinti sąrašą
            Funkcija, kuri grąžina sąrašą konvertuotą į masyvą;
            Funkcija, kuri suranda ir grąžina VIENĄ atitkmenį sąraše. Jeigu rado daugiau ar mažiau negu vieną turi mesti mesti klaidą;
            Funkcija, kuri suranda ir grąžina vieną atitikmenį sąraše, BET jeigu jo neranda, grąžina default’inę to duomenų tipo reikšmę. Jeigu randa daugiau NEGU 1 tada meta klaidą;
            Funkcija kuri patikrina ar egzistuoja nurodytos reikšmės kintamasis sąraše ir grąžina bool tipo reikšmę atitinkančią paieškos rezultatą;
*/
    }
}
