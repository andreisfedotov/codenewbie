using System;

namespace Range_and_Index
{
    internal static class RangeSample
    {
        internal static void Go()
        {
            var languages = Collections.Languages;

            Range myRange1 = 1..4;

            Index start = 1;
            Index end = 4;
            Range myRange2 = start..end;

            string[] languagesRange = languages[1..4];
            foreach (var language in languagesRange)
            {
                Console.WriteLine(language);
            }

            string[] languagesRange1 = languages[^3..]; // 3 last
            string[] languagesRange2 = languages[..^1]; // start from pre-last
            string[] languagesRange3 = languages[^4..^1]; // 3 start from pre last

            Span<string> languagesSpan = languages;
            Span<string> selectedLanguagesSpan = languagesSpan[1..4];
            foreach (var language in selectedLanguagesSpan)
            {
                Console.WriteLine(language);
            }
        }
    }
}
