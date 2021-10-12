using FileData.Common;
using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.VersionClasses
{
    public class VersionValidation:Validation,IVersionValidation
    {
        public bool CheckIfFirstArgIsValidForVersion(string arg)
        {
            bool isVersionArgExists = Constants.versionArgs.Contains(arg);

            return isVersionArgExists;
        }
    }
}
