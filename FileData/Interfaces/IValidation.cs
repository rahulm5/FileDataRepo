using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Interfaces
{
    public interface IValidation
    {
        bool CheckIfInputHasTwoArguments(string[] args);
    }
}
