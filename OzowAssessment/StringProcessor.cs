using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OzowAssessment
{
    public class StringProcessor
    {
        public string StringExcludePunctuation(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException(nameof(input));

            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    output.Append(c);
                }
            }           
          
            return output.ToString();
        }

        public string StringSorting(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException(nameof(input));

            var result = input.ToLower().OrderBy(s => s);

            return new string(result.ToArray());
        }
    }
}
