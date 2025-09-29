using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.Array.App2
{
    public class GenerateInputs
    {

        private string randomParagraphOfWords = "Enter Words Here";

        public GenerateInputs() { }
        public int generateonePositiveInt(int minValue, int maxValue)
        {
            Random rnd = new Random();

            return rnd.Next(minValue, maxValue);

        }

        public string generateOneString()
        {
            String tempString;
            int stringLength;

            tempString = randomParagraphForWords.Substring(0, randomParagraphForWords.IndexOf(" "));
            stringLength = tempString.Length + 1;
            randomParagraphForWords = randomParagraphForWords.Substring(stringLength);

            return tempString;
        }
    }
}

