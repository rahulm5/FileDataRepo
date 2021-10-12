using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public static class ValidationHelper
    {
        public static bool CheckIfFirstArgIsValidForVersion(string arg)
        {
            bool isVersionArgExists = Constants.versionArgs.Contains(arg);

            return isVersionArgExists;
        }

        public static bool CheckIfFisrtArgIsValidForSize(string arg)
        {
            bool isSizeArgExists = Constants.sizeArgs.Contains(arg);

            return isSizeArgExists;
        }

        public static bool CheckIfInputHasTwoArguments(string[] args)
        {
            if (args.Length == 2)
                return true;
            else if (args.Length < 2)
                throw new ArgumentException(Constants.LessArgs + Constants.InfoMessage);
            else if (args.Length > 2)
                throw new ArgumentException(Constants.MoreArgs + Constants.InfoMessage);

            return false;
        }
    }
}
