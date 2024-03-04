using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class HagmanWord
    {

        public static List<String> getWords()
        {
            var r = new List<String>();
            string contents = File.ReadAllText("words.txt");
           
            foreach (var w in contents.Split(',').ToList())
            {
                r.Add(w.Trim().ToUpper());
            }
            return r;
        }
    }
}
