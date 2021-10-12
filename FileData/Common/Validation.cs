using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Common
{
    public class Validation : IValidation
    {
        public bool CheckIfInputHasTwoArguments(string[] args)
        {
            if (args.Length == 2)
                return true;
            else if (args.Length < 2)
                Console.WriteLine(Constants.LessArgs + Constants.InfoMessage);
            else if (args.Length > 2)
                Console.WriteLine(Constants.MoreArgs + Constants.InfoMessage);

            return false;
        }
    }
}
