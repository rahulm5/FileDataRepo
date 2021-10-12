using FileData.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.SizeClasses
{
    public class SizeValidation:Validation
    {

        public bool CheckIfFisrtArgIsValidForSize(string arg)
        {
            bool isSizeArgExists = Constants.sizeArgs.Contains(arg);

            return isSizeArgExists;
        }
    }
}
