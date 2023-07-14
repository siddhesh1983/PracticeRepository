using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class DerivedLogic : BaseLogic
    {

        public DerivedLogic(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public override string GetFormattedString()
        {
            return $"{firstName} ---- {lastName}";
        }
    }
}
