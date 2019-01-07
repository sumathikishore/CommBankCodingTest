using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommBankCodingTest.Common
{
    public static class MiscellaneousUtil
    {
        public static bool IsBlank<T>(this ICollection<T> current)
        {
            return current == null || current.Count == 0;
        }
    }
}
