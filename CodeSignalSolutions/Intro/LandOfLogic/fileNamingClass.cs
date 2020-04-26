/*
    Status:   Solved
    Imported: 2020-04-26 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/sqZ9qDTFHXBNrQeLC

    Description:
        You are given an array of desired filenames in the order of their creation.
        Since two files cannot have equal names, the one which comes later will have an
        addition to its name in a form of (k), where k is the smallest positive integer
        such that the obtained name is not used yet.
        
        Return an array of names that will
        be given to the files.
        
        Example
        
        For names = ["doc", "doc", "image", "doc(1)",
        "doc"], the output should be
        fileNaming(names) = ["doc", "doc(1)", "image",
        "doc(1)(1)", "doc(2)"].
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] array.string names
        
        Guaranteed constraints:
        5 ≤ names.length ≤ 1000,
        1 ≤
        names[i].length ≤ 15.
        
        [output] array.string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class fileNamingClass
    {
        string[] fileNaming(string[] names) {
            HashSet<string> usedNames = new HashSet<string>();
            Dictionary<string, int> nameNumber = new Dictionary<string, int>();
         
            string GenerateName(string filename)
            {
                if (!nameNumber.TryGetValue(filename, out int count))
                {
                    nameNumber.Add(filename, 0);
                    if (usedNames.Add(filename))
                    {
                        return filename;
                    }
                    return GenerateName(filename);
                }
                else
                {
                    var originalName = filename;
                    do
                    {
                        count++;
                        nameNumber[originalName] = count;
                        filename = $"{originalName}({count})";
                    } while(!usedNames.Add(filename));
                    return filename;
                }
            }
            List<string> result = new List<string>();
            foreach(var name in names)
            {
                result.Add(GenerateName(name));
            }
            return result.ToArray();
        }
    }
}
