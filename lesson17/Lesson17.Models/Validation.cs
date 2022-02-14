using System;

namespace Lesson17.Models
{
    public class Validation
    {
               
   
        public static void CheckIfNull<T>(T input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
        }
        
    }
}
