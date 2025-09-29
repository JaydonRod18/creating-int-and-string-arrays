using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.Array.App2
{
    public class UserCommunications
    {
        public UserCommunications() { }

        public void displayMessage(String message)
        {
            Console.WriteLine(message);
        }

        public String obtainInformationFromUser(String message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
