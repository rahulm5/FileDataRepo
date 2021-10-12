using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.VersionClasses
{
    public class Versions :VersionValidation, IVersion
    {
        public string GetVersion(string[] args)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();
                if (CheckIfInputHasTwoArguments(args))
                {
                    return fileDetails.Version(args[1]);
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
