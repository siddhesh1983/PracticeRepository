using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public abstract class BaseLogic
    {

        internal string firstName = string.Empty;
        internal string lastName = string.Empty;

        public BaseLogic(string firstNameData, string lastNameData)
        {
            firstName = firstNameData;
            lastName = lastNameData;

        }
        public abstract string GetFormattedString();
    }
       
}
