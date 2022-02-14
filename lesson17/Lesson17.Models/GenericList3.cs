using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson17.Models
{
    public class GenericList3<T>
    {
        public static List<T> TList { get; set; }      

        public GenericList3()
        {
            TList = new List<T>();
        }


        public void Print()
        {
            foreach (T item in TList) Console.WriteLine($"{item}");
        }

        public T[] ConvertToArray()
        {
            return TList.ToArray();
        }
        public void AddElementToList(T elementToAdd)
        {
            Validation.CheckIfNull(elementToAdd);
            TList.Add(elementToAdd);
        }
        public void AddListOfElementsToList(List<T> listToAdd)
        {
            TList.AddRange(listToAdd);
        }
        public void RemuveElementFromList()
        {
            TList.RemoveAt(TList.Count() - 1);
        }
        public void RemuveElementFromListByIndex(int index)
        {
            Validation.CheckIfNull(index);
            TList.RemoveAt(index);
        }
        public void RemuveAllSelectesdElements(T elementsToRemuve)
        {
            Validation.CheckIfNull(elementsToRemuve);
            TList.RemoveAll(x => x.Equals(elementsToRemuve));
        }
       
    }
}
