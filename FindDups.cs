
using System.Runtime.InteropServices;

namespace Rodrigues.Array.App2
{
    public class FindDups
    {
        public FindDups() { }

        public bool isIntDup(int[] intArray, int arraySize, int tempInt)
        {
            for (int n = 0; n < arraySize; n++)
            {
                if (tempInt == intArray[n])
                    return true;
            }

            return false;
        }

        public bool isStringDup(String[] stringArray, int arraySize, String tempString)
        {
            for (int n = 0; n < arraySize; n++)
            {
                if (tempString.Equals(stringArray[n]))
                    return true;
            }

            return false;
        }

        public bool isObjectDup(Node[] objArray, int arraySize, int tempInt)
        {
            for (int n = 0; n < arraySize; n++)
            {
                if (tempInt == Convert.ToInt32(objArray[n].getTheNumber()))
                    return true;
            }

            return false;
        }
    }


}
