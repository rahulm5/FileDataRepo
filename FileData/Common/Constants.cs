using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Common
{
    public class Constants
    {
        public static readonly List<string> sizeArgs = new List<string> { "-s", "--s", "/s", "--size" };
        public static readonly List<string> versionArgs = new List<string> { "-v", "--v", "/v", "--version" };

        public const string InvalidArgsMessage= "Arguments Invalid.";
        public const string LessArgs = "Provided args are not sufficient. Please provide two arguments.";
        public const string MoreArgs = "Provided args are more than required. Please provide two arguments.";
        public const string InfoMessage = "\nFor version please enter -v or --v or /v or --version followed by space and file path.\nFor size please enter -s or --s or /s or --size followed by space and file path.";
    }
}
