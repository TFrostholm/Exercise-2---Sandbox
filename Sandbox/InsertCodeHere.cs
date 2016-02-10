using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            long accountNumber;
            double balance;
            string accountOwnerFirstName;
            string accountOwnerLastName;
            string accountName;

            accountNumber = 25223459993;
            balance = 2398.34;
            accountOwnerFirstName = "Toke";
            accountOwnerLastName = "Frostholm";
            accountName = "Lønkonto";

            Console.WriteLine("{0} owned by {1} {2} has a balance of {3}", accountName, accountOwnerFirstName, accountOwnerLastName, balance);


            // The LAST line of code should be ABOVE this line
        }
    }
}
