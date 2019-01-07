
using System.Collections.Generic;

namespace CommBankCoding.Interface
{
    interface IIOOperations
    {
        void WriteToTextFile(List<string> text, string fileName);
    }
}
