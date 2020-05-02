/*
    Status:   Solved
    Imported: 2020-05-02 12:47
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/W5Sq7taLSzNHh8GiF

    Description:
        You're a crossword fanatic, and have finally decided to try and create your own.
        However, you also love symmetry and good design, so you come up with a set of
        rules they should follow:
        the crossword must contain exactly four words;
        these four words should form four pairwise intersections;
        all words must be written either left-to-right or top-to-bottom;
        the area of the rectangle formed by empty cells inside the intersections isn't
        equal to zero.
        Given 4 words, find the number of ways to make a crossword following the
        above-described rules. Note that two crosswords which differ by rotation are
        considered different.
        Example
        For words = ["crossword", "square", "formation", "something"], the output should
        be
        crosswordFormation(words) = 6.
        The six crosswords can be formed as shown below:
        f                         f                             f
        o                     c r o s s w o r d     c r o s s w o r d
        c r o s s w o r d           r   o                   q     r
        m   q                     m   m                   u     m
        a   u            ;  s q u a r e          ;        a     a
        t   a                     t   t                   r     t
        i   r                     i   h             s o m e t h i n g
        s o m e t h i n g           o   i                         o
        n                         n   n                         n
        c         s               s
        f o r m a t i o n       c     q               c         s
        o         m         r     u               r         o
        s q u a r e       f o r m a t i o n       o         m
        s         t    ;    s     r            ;  s q u a r e
        w         h         s o m e t h i n g     s         t
        o         i         w                     w         h
        r         n         o                   f o r m a t i o n
        d         g         r                     r         n
        d                     d         g
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string words
        An array of distinct strings, the words you need to use in your crossword.
        Guaranteed constraints:
        words.length = 4,
        3 ≤ words[i].length < 15.
        [output] integer
        The number of ways to make a correct crossword of the desired formation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class crosswordFormationClass
    {
        int crosswordFormation(string[] words) {
            // Vildt svært, men start med et ord og prøv hvert bogstav med et af de andre ord
            // Eks. crossword kan krydses med square i et af s'erne og med formation i o'et
            // Så skal man bare finde ud af om something kan krydses med både square's e og formation's i og få det til at passe
            // Ved rent hæld virkede det men kunsten er at give op så hurtigt som muligt fordi der kan være mange kombinationer.
            // Dette er den 6. løsning.
            // Et index med hvilke bogstaver der er i hvilke ord og deres position ville sikkert hjælpe.
            // Dictionary<char, (wordIndex, positon)[]>
            int result = 0;
            var dic = GenerateDictionary(words);
            for (int word = 0; word < words.Length; word++)
            {
                var firstWordText = words[word];
                foreach (var second in Select(firstWordText, dic)
                    .Where(t => t.wordIndex != word))
                {
                    var secondWordText = words[second.wordIndex];
                    foreach (var third in Select(secondWordText, dic, second.position + 2)
                        .Where(t => t.wordIndex != word && t.wordIndex != second.wordIndex))
                    {
                        var thirdWordText = words[third.wordIndex];
                        foreach (var fourth in Select(thirdWordText, dic, third.position + 2)
                            .Where(t => t.wordIndex != word && t.wordIndex != second.wordIndex && t.wordIndex != third.wordIndex))
                        {
                            var fourthWordText = words[fourth.wordIndex];
                            var p1 = second.prevPosition - third.position + fourth.prevPosition;
                            if (p1 < 0 || p1 >= firstWordText.Length) continue;
                            var p4 = second.position - third.prevPosition + fourth.position;
                            if (p4 < 0 || p4 >= fourthWordText.Length) continue;
                            if (firstWordText[p1] != fourthWordText[p4]) continue;
                            result++;
                        }
                    }
                }
            }
            return result;
        }
        static IEnumerable<(int prevPosition, int wordIndex, int position)> Select(string word, Dictionary<char, (int wordIndex, int position)[]> dic, int skip = 0)
        {
            for (int i = skip; i < word.Length; i++)
            {
                if (dic.TryGetValue(word[i], out var array))
                {
                    foreach (var tuple in array)
                    {
                        yield return (prevPosition: i, tuple.wordIndex, tuple.position);
                    }
                }
            }
        }
        static Dictionary<char, (int wordIndex, int position)[]> GenerateDictionary(string[] words)
        {
            return words
                .Select((w, i) => (wordIndex: i, word: w))
                .SelectMany(t => t.word.Select((c, i) => (chr: c, position: i, wordIndex: t.wordIndex)))
                .GroupBy(t => t.chr, t => (wordIndex: t.wordIndex, positon: t.position))
                .Select(g => (Key: g.Key, Value: g.ToArray()))
                .Where(g => g.Value.Select(i => i.wordIndex).Distinct().Count() > 1)  // Only letters in more than one word is interesting
                .ToDictionary(g => g.Key, g => g.Value);
        }
    }
}
