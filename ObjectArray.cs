namespace Rodrigues.Array.App2
{
    public class ObjectArray
    {
        private Node[] anArray = null;
        private int arraySize = -1;
        private int maxSize = 100;

        public TheObjectArray()
        {
            howBigIsTheArray();
            populateTheArray();

            Console.WriteLine("\nthe array");
            lookAtTheArray();
            Console.WriteLine("\nthe array reversed");
            lookAtTheArrayBackwards();
        }

        public void howBigIsTheArray()
        {
            String temp;
            UserCommunications UC = new UserCommunications();

            do
            {
                temp = UC.obtainInformationFromUser("how many elements are in this array? (max value is " + maxSize + ")   ");
                if (!canBePositiveInt(temp))
                    temp = "-1";
            } while (Convert.ToInt16(temp) > 100);

            arraySize = Convert.ToInt16(temp);
        }

        private void populateTheArray()
        {
            GenerateInputs theData = new GenerateInputs();
            FindDups isDup = new FindDups();

            if (arraySize == -1)
                arraySize = maxSize;

            anArray = new Node[arraySize];

            for (int n = 0; n < arraySize; n++)
            {
                int minValue = 0;
                int maxValue = 10000;
                int tempInt;
                anArray[n] = new Node();

                tempInt = theData.generateOnePositiveInt(minValue, maxValue);
                while (isDup.isObjectDup(anArray, n, tempInt))
                {
                    tempInt++;
                    if (tempInt > maxValue)
                        tempInt = minValue;
                }

                anArray[n].setTheNumber(tempInt.ToString());
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
                outputString += anArray[n].getTheNumber() + ", ";

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
                outputString += anArray[n].getTheNumber() + ", ";

                if (n > 0 && n % 10 == 0)
                    outputString += "\n";
            }

            Console.WriteLine(outputString);
        }
    }
}
