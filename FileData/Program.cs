using FileData.Common;
using FileData.SizeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                VersionClasses.Versions version = new VersionClasses.Versions();
                Size size = new Size();
                if (version.CheckIfFirstArgIsValidForVersion(args[0]))
                {
                    Console.WriteLine("Vesrion:" + version.GetVersion(args));
                }
                else if (size.CheckIfFisrtArgIsValidForSize(args[0]))
                {
                    Console.WriteLine("Size:"+ size.GetSize(args));
                }
                else
                {
                    Console.WriteLine(Constants.InvalidArgsMessage + Constants.InfoMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.ReadLine();
            }
        }
    }
}
