using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.Array.App2
{
    public class StringArray
    {
        private String[] anArray = null;
        private int arraySize = -1;
        private int maxSize = 100;

        public StringArray()
        {
            howBigIsTheArray();
            populateTheArray();
            lookAtTheArray();
            //lookAtTheArrayBackwards();
        }

        public void howBigIsTheArray()
        {
            String temp;
            UserCommunications UC = new UserCommunications();

            do
            {
                temp = UC.obtainInformationFromUser("how many elements are in this array? (max value is " + maxSize + ")   ");
                //    if (!canBePositiveInt(temp))
                //         temp = "-1";
            } while (Convert.ToInt16(temp) > 100);

            arraySize = Convert.ToInt16(temp);
        }

        private void populateTheArray()
        {
            GenerateInputs theData = new GenerateInputs();
            FindDups isDup = new FindDups();
            String tempString;

            if (arraySize == -1)
                arraySize = maxSize;

            anArray = new String[arraySize];

            for (int n = 0; n < arraySize; n++)
            {
                int minValue = 0;
                int maxValue = 10000;
                tempString = theData.generateOneString();
                while (isDup.isStringDup(anArray, n, tempString))
                    tempString = theData.generateOneString();

                anArray[n] = tempString;
            }
        }

        private bool canBePositiveInt(String s)
        {
            try
            {
                if (Convert.ToInt16(s) > -1)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void lookAtTheArray()
        {
            String outputString = "";

            for (int n = 0; n < arraySize; n++)
            {
                outputString += anArray[n] + ", ";

                if (n > 0 && n % 10 == 0)
                    outputString += "\n";
            }

            Console.WriteLine(outputString);
        }

        private void lookAtTheArrayBackwards()
        {
            String outputString = "";

            for (int n = arraySize - 1; n > -1; n--)
            {
                outputString += anArray[n] + ", ";

                if (n > 0 && n % 10 == 0)
                    outputString += "\n";
            }

            Console.WriteLine(outputString);
        }
    }
}

