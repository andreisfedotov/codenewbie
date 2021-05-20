using System;

namespace Range_and_Index
{
    internal static class IndexSample
    {
        internal static void Go()
        {
            var languages = Collections.Languages;

            // Get the second element
            int index = 1;
            var english = languages[index];
            Console.WriteLine(english); // Output: English

            // Get the second element by using index
            Index index1 = 1;
            var english2 = languages[index1];
            Console.WriteLine(english2); // Output: English

            // another way to declare index
            var index2 = new Index(); // zero by default because this is a structure
            var spanish = languages[index2];
            Console.WriteLine(spanish); // Output: Spanish

            // one more way
            var index3 = new Index(2);
            var japanese = languages[index3];
            Console.WriteLine(japanese);

            // Get the last element
            var lastIndex1 = languages.Length - 1;
            var chinese1 = languages[lastIndex1];
            Console.WriteLine(chinese1);

            // Get the last element by using index
            Index lastIndex2 = ^1;
            var chinese2 = languages[lastIndex2];
            Console.WriteLine(chinese2);

            // this
            Console.WriteLine(languages[languages.Length - 2]); // Korean
            // vs this
            Console.WriteLine(languages[^2]); // Korean

            var equals = index1.Equals(index2);
            Console.WriteLine(equals); // false
        }
    }
}
