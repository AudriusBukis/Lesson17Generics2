using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson17.Models
{
    public class GenericList2<T>
    {
        public List<T> ReadOnlyList { get; private set; }

        public GenericList2( List<T> readOnlyList)
        {
            ReadOnlyList = readOnlyList;
        }

        public void Print()
        {
            foreach (T item in ReadOnlyList) Console.WriteLine($"{item}");
        }
        public T[] ConvertToArray()
        {
            return ReadOnlyList.ToArray();
        }
        public T FindElement(T elementToFind)
        {
            Validation.CheckIfNull(elementToFind);
            return ReadOnlyList.Single(x => x.Equals(elementToFind));
        }
        public T FindElement2(T elementToFind)
        {
            Validation.CheckIfNull(elementToFind);
            return ReadOnlyList.SingleOrDefault(x => x.Equals(elementToFind));
        }
        public bool ElementContainsInList(T elementToFind)
        {
            Validation.CheckIfNull(elementToFind);
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
