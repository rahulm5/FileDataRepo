using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.SizeClasses
{
    public class Size :SizeValidation, ISize
    {
        public int GetSize(string[] args)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();

                if (CheckIfInputHasTwoArguments(args))
                {
                    return fileDetails.Size(args[1]);
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
